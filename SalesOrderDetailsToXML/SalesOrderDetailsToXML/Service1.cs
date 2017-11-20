using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.IO;
using Data_Access;
using System.Collections;
using System.Timers;
using System.Configuration;

namespace SalesOrderDetailsToXML
{
    public partial class Service1 : ServiceBase
    {

        private Timer _timer;

        public Int16 RefreshRate { get; private set; }

        public Service1()
        {
            InitializeComponent();
            RefreshRate = Convert.ToInt16(ConfigurationManager.AppSettings["RefreshRate"]);
        }

        public void RunInDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "UPSCOSalesOrderChangeWatcherStarted.txt");

            _timer = new Timer(1000 * 60 * RefreshRate);  
            _timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
            _timer.AutoReset = true;
            _timer.Start();
            RunCheckForChanges();

        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            RunCheckForChanges();
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "UPSCOSalesOrderChangeWatcherStopped.txt");
            _timer.Stop();
            _timer.Dispose();
        }

        protected DataTable RemoveDuplicateRows(DataTable source, string colName)
        {

            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.


            foreach (DataRow drow in source.Rows)
            {

                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                source.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return source;
        }

        protected void WriteValues(Information i)
        {
            try
            {
                //EventLog.WriteEntry("WriteValues is attempting to saveData: ", EventLogEntryType.Information, 121, short.MaxValue);
                SaveXML.SaveData(i);
            }
            catch (Exception exf)
            {
                #if !DEBUG
                EventLog.WriteEntry("Exception occured when trying to Write Values from Information Class: ", exf.Message + "Trace" +
                     exf.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
                #endif
            }
        }

        protected void RunCheckForChanges()
        {

#if !DEBUG
            EventLog.WriteEntry("Running Check for Changes at : " + DateTime.Now.ToLongTimeString(), EventLogEntryType.SuccessAudit, 121, short.MaxValue);
#endif

            DataTable dtSalesOrders = new DataTable();
            DataTable dtMakeItems = new DataTable();
            int salesRecordCount = 0;

            List<string> lsSalesOrdersFiltered = new List<string>();
            List<string> makeList = new List<string>();

            try
            {
                dtSalesOrders = CommonData.GetAllOpenSalesOrders();
                salesRecordCount = dtSalesOrders.Rows.Count;

                //EventLog.WriteEntry("RunCheckForChanges is attempting to load" + salesRecordCount.ToString() + " orders ", EventLogEntryType.Information, 121, short.MaxValue);

            }
            catch (Exception ex)
            {

                EventLog.WriteEntry("Exception occured when trying to load OpenOrders: ", ex.Message + "Trace" +
                        ex.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
            }


            try
            {
                dtMakeItems = CommonData.GetMakeItems();
                foreach (DataRow part in dtMakeItems.Rows)
                {
                    makeList.Add(part["ItemCode"].ToString());
                }
            }
            catch (Exception e)
            {
#if !DEBUG
                EventLog.WriteEntry("Exception occured when trying to load List of Make Parts: ", e.Message + "Trace" +
                        e.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
#endif
            }

            DataTable dtSalesOrderItems = new DataTable();
            dtSalesOrderItems = CommonData.GetAllSalesOrderItems();

            DataColumn[] keyColumn = new DataColumn[1];
            keyColumn[0] = dtSalesOrderItems.Columns["unique"];
            dtSalesOrderItems.PrimaryKey = keyColumn;

            int i = 0;
            foreach (DataRow item in dtSalesOrderItems.Rows)
            {

                //if (!soList.Contains(item["SalesOrderNo"].ToString()))
                //     { soList.Add(item["SalesOrderNo"].ToString()); }

                if (!makeList.Contains(item["ItemCode"].ToString()))
                {
                    dtSalesOrderItems.Rows[i].Delete();
                }

                i += 1;

            }
            dtSalesOrderItems.AcceptChanges();

            ////remove the blank rows
            //for (int i = dtSalesOrderItems.Rows.Count; i >= 1; i--)
            //{
            //    DataRow currentRow = dtSalesOrderItems.Rows[i - 1];
            //    foreach (var colValue in currentRow.ItemArray)
            //    {
            //        if (!string.IsNullOrEmpty(colValue.ToString()))
            //            break;

            //        // If we get here, all the columns are empty
            //        dtSalesOrderItems.Rows[i - 1].Delete();
            //    }
            //}

            //Remove the duplicates from the datatable
          //  dtSalesOrderItems = RemoveDuplicateRows(dtSalesOrderItems, "SalesOrderNo");
            salesRecordCount = dtSalesOrderItems.Rows.Count;

            try
            {
                foreach (DataRow item in dtSalesOrderItems.Rows)
                {
                    Information infoItem = new Information();

                    infoItem.SalesOrderNo = item["SalesOrderNo"].ToString();
                    infoItem.ItemCode = item["ItemCode"].ToString();
                    infoItem.UniqueId = item["unique"].ToString();
                    infoItem.PromiseDate = Information.GetDate(item["PromiseDate"].ToString());
                    infoItem.OriginalPromiseDate = Information.GetDate(item["UDF_ORIG_PROMISE"].ToString());
                    infoItem.OrderType = item["OrderType"].ToString();

                    WriteValues(infoItem);
                }
            }
            catch (Exception ex)
            {
#if !DEBUG
                EventLog.WriteEntry("Exception occured when trying to write to iterate SalesOrderItems: ", ex.Message + "Trace" +
                        ex.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
#endif
            }
        }
    }
}
