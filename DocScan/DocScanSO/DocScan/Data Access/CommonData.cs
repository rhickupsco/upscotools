using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

namespace DocScanSO.Data_Access
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

        public static DataTable GetSalesOrderData(string SONumber)
        {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter SOParam = new OdbcParameter();

            string sql = null;
            //set the parameter equal to the customerNumber passed in
            SOParam.Value = SONumber;

            sql = GetSalesOrderQueryString();

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

        private static string GetSalesOrderQueryString()
        {
            string sql = string.Empty;

            sql= "SELECT soh.SalesOrderNo, soh.OrderDate, soh.CustomerNo From SO_SalesOrderHistoryHeader soh where soh.SalesOrderNo = ?";
            
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

        public static string GetVendorName(string vendorNumber)
        {
            string ret = string.Empty;
            DataTable localDt = new DataTable();
            localDt = Data_Access.CommonData.GetCustomerInfo(vendorNumber);
            ret = localDt.Rows[0]["CustomerName"].ToString();
            return ret;
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
