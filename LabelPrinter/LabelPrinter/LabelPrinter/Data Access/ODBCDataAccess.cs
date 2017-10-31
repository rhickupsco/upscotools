﻿using System;
using System.Data.Odbc;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Data_Access
{
    public class ODBCDataAccess
    {    
        //Sage Connection Class
        private OdbcConnection Conn;
        private OdbcCommand Comm;
        private OdbcDataReader Dr;
        private string ConnectionString;
        public DataTable Dt;
        //This is the function you call to return all data with no parameters
        public DataTable GetAllDataFromQuery(string sql)
        {
            Initialize();
            Connect(sql);
            return Fill();
        }
        //This is the function you call to return all data that has one filter parameter, such as ("Where workOrder = ?", workOrderNo)
        public DataTable GetDynamicTableFromQuery(string sql, OdbcParameter parameter)
        {
            Initialize();
            //Add the parameters
            Comm.Parameters.Add(parameter);
            Connect(sql);
            return (Fill());
        }

        public DataTable GetDynamicTableMultipleParams(OdbcCommand thisCommand)
        {
            DataTable dt = new DataTable();
            Initialize(thisCommand);
            //this assigns the connection to the comm object
            Comm.Connection = Conn;
            Comm.Connection.ConnectionTimeout = 300;
            Comm.CommandTimeout = 6000;

            try
            {
                //this establishes the connection ad opens it to the database, like a funnel
                Conn.Open();
                dt = Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to SAGE database failed in ODBCDataAccess -" + ex.Message.ToString());
            }
            return dt;
        }

      

        //This is the function you would call to return a single string value from a table such as "the value is green"
        //public string GetSingleString(string sql, OdbcParameter parameter = null)
        //{
        //    if (parameter != null)
        //    {
        //        Initialize();
        //        Comm.Parameters.Add(parameter);
        //        try
        //        {
        //            Connect(sql);
        //            DataTable dtLocal = new DataTable();
        //            dtLocal = Fill();
        //            string strValue = null;
        //            strValue = string.Concat(dtLocal.Rows(0)(0).ToString, ",", dtLocal.Rows(0)(1).ToString);
        //            return strValue;
        //        }
        //        catch (Exception ex)
        //        {
        //            return ("none");
        //        }

        //    }
        //    else
        //    {
        //    }
        //    return null;
        //}
        //This is the function you would call to return a boolean  value from a table such as True
        //public bool GetBooleanValue(string sql)
        //{
        //    return false;
        //}
        //This is the function you would call to return a single Integer value from a table such as the total count of records in a file
        //public int GetCount(string sql)
        //{
        //    return Nothing;
        //}
        ////This is the function you would call to return a single double value from a table such as 14.75
        //public double GetDouble(string sql)
        //{
        //    return Nothing;
        //}
        ////This is the function you would call to return a single integer value from a table such as 28
        //public int GetInteger(string sql)
        //{
        //    return Nothing;
        //}

        private void Initialize()
        {
            Dt = new DataTable();
            //this is the reference to the SQL Connection string which is the login details and location of the Sage Database
            //Can be modified in the app.config
            //ConnectionString = ConfigurationManager.ConnectionStrings["DocScanWO.Properties.Settings.SOTAMASConnectionString"].ToString();
            ConnectionString = LabelPrinter.Properties.Settings.Default.dbConnection;
            //this builds a new connection to the database
            Conn = new OdbcConnection(ConnectionString);
            //this is a container for the command that you will send it on its way with, such as "Select * from LabelsTable"
            Comm = new OdbcCommand();
        }

        private void Initialize(OdbcCommand thisCommand)
        {
            Dt = new DataTable();
            ConnectionString = LabelPrinter.Properties.Settings.Default.dbConnection;
            //this builds a new connection to the database
            Conn = new OdbcConnection(ConnectionString);
            //this is a container for the command that you will send it on its way with, such as "Select * from LabelsTable"
            Comm = thisCommand;
        }



        private void Connect(string sql)
        {
            //this assigns the query to the comm object
            Comm.CommandText = sql;

            //this assigns the connection to the comm object
            Comm.Connection = Conn;
            Comm.Connection.ConnectionTimeout = 300;
            Comm.CommandTimeout = 6000;
            
            try
            {
                //this establishes the connection ad opens it to the database, like a funnel
                Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to SAGE database failed in ODBCDataAccess -" + ex.Message.ToString());
         
            }

        }

        private DataTable Fill()
        {
            try
            {
                 //Excecute the command that is loaded in the comm object (open the valve on the funnel to let the data flow from the datasource)
                Dr = Comm.ExecuteReader();
                //Fill dataTable with contents from datareader
                Dt.Load(Dr);
            }
            catch (Exception ex)
            {

                MessageBox.Show("SAGE Query failed in ODBCDataAccess -" + ex.Message.ToString());
            }
         
            return Dt;
        }

        private string GetStringValue()
        {
            string strResult = null;
            Dr = Comm.ExecuteReader();
            strResult = Dr.GetString(0);

            return strResult;
        }

        public void Disconnect()
        {
            //Clean up after yourselves and close the connections, good housekeeping
            Conn.Close();
            Dr.Close();
            Comm.Dispose();
            Conn.Dispose();
            Dt.Dispose();
        }



    }
}

