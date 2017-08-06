using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

namespace DocScanWO.Data_Access
{
    public static class CommonData
    {
        public static DataSet AllData = new DataSet();
        //public static DataTable GetSalesOrderData()
        //{
         
        //    ODBCDataAccess bs = new ODBCDataAccess();
        //    DataTable tblBuildData = new DataTable();
        //    string sql = null;
         
        //    sql = GetSalesOrderQueryString();
           
        //    tblBuildData = bs.GetAllDataFromQuery(sql);
         
        //    return tblBuildData;
        //}

        public static DataTable GetWorkOrderData(string WONumber, string optionalHistory = "no")
        {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter SOParam = new OdbcParameter();

            string sql = null;
            //set the parameter equal to the customerNumber passed in
            SOParam.Value = WONumber;

            if(optionalHistory == "history")
            {
                sql = GetWorkOrderQueryStringFromHistory();
            }
            else
            {
                sql = GetWorkOrderQueryString();
            }
            

            tblBuildData = bs.GetDynamicTableFromQuery(sql, SOParam);
           
            return tblBuildData;
        }


        public static DataTable GetCustomerInfo(string customerNo)
        {
               
            ODBCDataAccess bs = new ODBCDataAccess();
          
            DataTable tblBuildData = new DataTable();
           
            OdbcParameter CustomerParam = new OdbcParameter();
          
            string sql = null;
          
            //set the parameter equal to the customerNumber passed in
            CustomerParam.Value = customerNo;
           
            sql = GetCustomerNameQuery();
         
            tblBuildData = bs.GetDynamicTableFromQuery(sql, CustomerParam);
           
            return tblBuildData;
        }

        private static string GetWorkOrderQueryString()
        {
            string sql = string.Empty;

            sql= "SELECT WorkOrder, WODueDate, StdLaborCost, SOCustNumber, MakeForOrderNumber, MakeFor, ActualLaborCost, ItemBillNumber, ItemBillDescription, MakeFor FROM WO1_WorkOrderMaster Where workorder =  ? ";
            
            return sql;
        }

        private static string GetWorkOrderQueryStringFromHistory() ///////to be updated with new QUERY
        {
            string sql = string.Empty;

            sql = "SELECT WOL.WorkOrder, WOL.WODueDate, WOL.StdLaborCost, WOL.SOCustNumber, WOL.MakeForOrderNumber, WOL.ActualLaborCost, WOL.ItemBillNumber, WOL.ItemDescription, FROM WOL_WorkOrderHistoryHeader WOL WHERE(WOL.WorkOrder =?)";

            return sql;
        }


        private static string GetCustomerNameQuery() {
            string sql = string.Empty;
            sql = "SELECT c.CustomerName FROM AR_Customer c where c.CustomerNo = ?";
            return sql;
        }

        public static DateTime ConvertToDate(string val)
        {
            DateTime dt = new DateTime();

            if (DateTime.TryParse(val, out dt))
            {
                return dt;
            }
            else return dt.ToLocalTime();
        }

        internal static float? ConvertToNumber(string val)
        {
            float flNum = new float();

            if (float.TryParse(val, out flNum))
            {
                return flNum;
            }
            else return flNum;
        }

        public static byte[] ConvertFileToStream(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] dbFile = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return dbFile;
        }



        //private static string GetSpecificJobInfo(string)

        //public static DataSet GetAllData()
        //{
        //    //check to see if the data is populated
        //    if (AllData.Tables.Count == 0) 
        //    {

        //        DataTable dt = new DataTable();
        //        dt = GetSalesOrderData();

        //        AllData.Tables.Add(dt);
        //    }

        //    return AllData;
        //}



    }
}
