using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

namespace Data_Access
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

        public static DataTable GetDataFromQuery(string sql, string parameter) {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = parameter;

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;

        }

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
                sql = GetItemFromWorkOrderWithSalesOrderLink();
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


        //Uses U01105 Template
        private static string GetItemFromWorkOrderWithSalesOrderLink()
        {
            string sql = string.Empty;

            sql= "";
            
            return sql;
        }


        private static string GetWorkOrderQueryStringFromHistory() ///////to be updated with new QUERY
        {
            string sql = string.Empty;

            sql = "SELECT WOL.WorkOrder, WOL.WODueDate, WOL.StdLaborCost, WOL.SOCustNumber, WOL.MakeForOrderNumber, WOL.ActualLaborCost, WOL.ItemBillNumber, WOL.ItemDescription, MakeFor FROM WOL_WorkOrderHistoryHeader WOL WHERE(WOL.WorkOrder =?)";

            return sql;
        }

        public static DataTable GetSalesOrderItems(string soNumber)
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();
            DataTable tblCurrent = new DataTable();
            DataTable tblHistory = new DataTable();

            OdbcParameter SOParam = new OdbcParameter();
            OdbcParameter SOParam2 = new OdbcParameter();
            
            

            string sql = null;
            string sql2 = null;

            sql = SalesOrderItemsQuery();
            sql2 = SalesOrderItemsHistoryQuery();

            //set the parameter equal to the customerNumber passed in
            SOParam.Value = soNumber;
            SOParam2.Value = soNumber;

            tblCurrent = bs.GetDynamicTableFromQuery(sql2, SOParam);
            tblHistory = bs.GetDynamicTableFromQuery(sql, SOParam2);

            tblBuildData = tblCurrent.Copy();
            tblBuildData.Merge(tblHistory);

            return tblBuildData;

        }

        public static DataTable GetShippingLabelData(string soNumber, string itemCode, bool current, string query)
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();
            DataTable tblCurrent = new DataTable();
            DataTable tblHistory = new DataTable();
            OdbcCommand myOdbcCommand = new OdbcCommand();


            myOdbcCommand.Parameters.AddWithValue("SalesOrderNo", soNumber); //first ? in statement
            myOdbcCommand.Parameters.AddWithValue("ItemCode", itemCode); //second ? in statement
            //myOdbcCommand.Parameters.AddWithValue("warehouse", warehouse); //third ? in statement

            string sql = null;
            sql = query;
            if(current == false) {
                sql = query.Replace("SO_SalesOrderDetail", "SO_SalesOrderHistoryDetail");
                sql = sql.Replace("SO_SalesOrderHeader", "SO_SalesOrderHistoryHeader");
            }

             myOdbcCommand.CommandText = sql;
             tblBuildData = bs.GetDynamicTableMultipleParams(myOdbcCommand);
         //   tblHistory = bs.GetDynamicTableFromQuery(sql, SOParam2);

         
            return tblBuildData;

        }


        private static string SalesOrderItemsQuery()
        {
           string sql = string.Empty;
            sql = "Select soh.salesOrderNo, sod.linekey linekey, sod.warehouseCode, sod.ItemCode from so_salesorderheader soh, so_salesorderdetail sod where soh.salesorderno = sod.salesorderno and soh.salesorderno = ? ";
            return sql;
        }

        private static string SalesOrderItemsHistoryQuery()
        {
            string sql = string.Empty;
            sql = "Select sohh.salesOrderNo, 'closed SO' linekey, sohd.warehouseCode, sohd.ItemCode from so_salesorderhistoryheader sohh, so_salesorderhistorydetail sohd where sohh.salesorderno = sohd.salesorderno and sohh.salesorderno = ? ";
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

        internal static DataTable GetFilteredTemplates(string askType)
        {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = askType;

            string sql = "Select TemplateName, TemplateType from Labels where TemplateType = ?";

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;
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
