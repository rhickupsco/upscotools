using System;
using System.Data;
using System.Data.Odbc;
using System.IO;
using Data_Access;
using System.Collections.Generic;

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

        public static DataTable GetMySalesOrders(string SalesPersonNo) {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = SalesPersonNo;

            string sql = GetMySalesOrdersQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;

        }

        

        //public static DataTable GetWorkOrderData(string WONumber, string optionalHistory = "no")
        //{
        //    ODBCDataAccess bs = new ODBCDataAccess();

        //    DataTable tblBuildData = new DataTable();

        //    OdbcParameter SOParam = new OdbcParameter();

        //    string sql = null;
        //    //set the parameter equal to the customerNumber passed in
        //    SOParam.Value = WONumber;

        //    if(optionalHistory == "history")
        //    {
        //        sql = GetWorkOrderQueryStringFromHistory();
        //    }
        //    else
        //    {
        //        sql = GetItemFromWorkOrderWithSalesOrderLink();
        //    }
            

        //    tblBuildData = bs.GetDynamicTableFromQuery(sql, SOParam);
           
        //    return tblBuildData;
        //}

        //public static DataTable GetBomInfoDatatable(string labelNumbers, string sql)
        //{

        //    ODBCDataAccess bs = new ODBCDataAccess();

        //    DataTable tblBuildData = new DataTable();

        //    OdbcParameter Param = new OdbcParameter();

        //    Param.Value = labelNumbers;

        //    tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

        //    return tblBuildData;
        //}


        //public static DataTable GetCustomerInfo(string customerNo)
        //{
               
        //    ODBCDataAccess bs = new ODBCDataAccess();
          
        //    DataTable tblBuildData = new DataTable();
           
        //    OdbcParameter CustomerParam = new OdbcParameter();
          
        //    string sql = null;
          
        //    //set the parameter equal to the customerNumber passed in
        //    CustomerParam.Value = customerNo;
           
        //    sql = GetBOMInfo();
         
        //    tblBuildData = bs.GetDynamicTableFromQuery(sql, CustomerParam);
           
        //    return tblBuildData;
        //}

        public static DataTable GetSalesPersonNames()
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            string sql = null;

            sql = GetSalesPersonQuery();

            tblBuildData = bs.GetAllDataFromQuery(sql);

            return tblBuildData;
        }

        public static DataTable GetSODetails(string SalesOrderNo) {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = SalesOrderNo;

            string sql = GetSODetailsQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;
        }


        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string GetSODetailsQuery() {
            string sql = string.Empty;

            sql = "SELECT SO_SalesOrderDetail.SalesOrderNo, " +
            "SO_SalesOrderDetail.LineKey, " +
            //"SO_SalesOrderDetail.LineSeqNo, " +
            //"SO_SalesOrderDetail.ItemType, " +
            "SO_SalesOrderDetail.ItemCode, " +
            "SO_SalesOrderDetail.ItemCodeDesc, " +
            // "SO_SalesOrderDetail.ExtendedDescriptionKey, " +
            "SO_SalesOrderDetail.QuantityOrdered, " +
            "SO_SalesOrderDetail.PromiseDate, " +
            "SO_SalesOrderDetail.CommentText, " +
            "SO_SalesOrderDetail.WarehouseCode, SO_SalesOrderDetail.DropShip, " +
            
            "SO_SalesOrderDetail.AliasItemNo, " +
           // "SO_SalesOrderDetail.SOHistoryDetlSeqNo, " +           
           // "SO_SalesOrderDetail.QuantityShipped, " +
            "SO_SalesOrderDetail.QuantityBackordered, " +
            //"SO_SalesOrderDetail.UnitPrice, SO_SalesOrderDetail.UnitCost, " +
            //"SO_SalesOrderDetail.ExtensionAmt, SO_SalesOrderDetail.UnitOfMeasureConvFactor, " +
           // "SO_SalesOrderDetail.QuantityPerBill, SO_SalesOrderDetail.LineDiscountPercent, " +
            //"SO_SalesOrderDetail.LineWeight, " +
            "SO_SalesOrderDetail.UDF_CUST_REQ_DATE, " +
            "SO_SalesOrderDetail.VendorNo, " +
            "SO_SalesOrderDetail.PurchaseOrderNo, SO_SalesOrderDetail.PurchaseOrderRequiredDate, " +
            //"SO_SalesOrderDetail.DebitCreditIndicator, SO_SalesOrderDetail.TaxAmt, " +
            //"SO_SalesOrderDetail.TaxRate, " +
            //"SO_SalesOrderDetail.D404_WorkOrderNo, " +
            "SO_SalesOrderDetail.UnitOfMeasure, " +
            "SO_SalesOrderDetail.UDF_NEW_BUSINESS, " +
            "SO_SalesOrderDetail.UDF_ORIG_PROMISE, " +
            "SO_SalesOrderDetail.UDF_REPROMISE, " +
            "SO_SalesOrderDetail.UDF_CTPC " +
            "FROM SO_SalesOrderDetail SO_SalesOrderDetail " +
            "WHERE(SO_SalesOrderDetail.SalesOrderNo = ?) AND SO_SalesOrderDetail.ItemType = '1'";

            return sql;
        }

        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        //Uses U01105 Template
        private static string GetSalesPersonQuery()
        {
            string sql = string.Empty;

            sql= "SELECT AR_Salesperson.SalespersonNo, AR_Salesperson.SalespersonName, AR_Salesperson.UDF_INSIDE, " +
            "AR_Salesperson.UDF_OUTSIDE, AR_Salesperson.UDF_GOAL FROM AR_Salesperson AR_Salesperson " +
            "WHERE(AR_Salesperson.SalespersonName Not Like '%#DO NOT USE%') ORDER BY AR_Salesperson.SalespersonName ASC";
            
            return sql;
        }

        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string GetWorkOrdersQueryString() ///////to be updated with new QUERY
        {
            string sql = string.Empty;

            sql = "SELECT WO1_WorkOrderMaster.MakeForOrderNumber, " +
            "WO1_WorkOrderMaster.SOLineIndex, " +
            "WO1_WorkOrderMaster.ItemBillNumber, " +
            "WO1_WorkOrderMaster.ItemBillDescription, " +
            "WO1_WorkOrderMaster.QtyComplete, " +
            "WO1_WorkOrderMaster.WODueDate, " +
            "WO1_WorkOrderMaster.StatusComment, " +
            "WO1_WorkOrderMaster.WorkOrder, " +
            "WO1_WorkOrderMaster.SchedRelDate, " +
            "WO1_WorkOrderMaster.WODate, " +            
            "WO1_WorkOrderMaster.Status, " +
            "WO1_WorkOrderMaster.LastReschedDate, " +
            "WO1_WorkOrderMaster.OnHold, " +
            "WO1_WorkOrderMaster.PlannerCode, " +
            "WO1_WorkOrderMaster.PriorDueDate, " +
            "WO1_WorkOrderMaster.UserWhoLastResched " +
            "FROM WO1_WorkOrderMaster WO1_WorkOrderMaster " +
            "WHERE(WO1_WorkOrderMaster.MakeForOrderNumber = ?)";

            return sql;
        }

        public static DataTable GetWODetails(string SalesOrderNo)
        {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = SalesOrderNo;

            string sql = GetWorkOrdersQueryString();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;
        }


        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string GetMySalesOrdersQuery()
        {
            string sql = string.Empty;

            sql = "SELECT SO_SalesOrderHeader.SalesOrderNo, AR_Customer.CustomerName " +
            "FROM AR_Customer AR_Customer, SO_SalesOrderHeader SO_SalesOrderHeader " +
            "WHERE AR_Customer.ARDivisionNo = SO_SalesOrderHeader.ARDivisionNo AND " +
            "AR_Customer.CustomerNo = SO_SalesOrderHeader.CustomerNo AND((SO_SalesOrderHeader.SalespersonNo = ?) " +
            "AND(SO_SalesOrderHeader.OrderStatus = 'O') AND (SO_SalesOrderHeader.OrderType in ('B','S')) ORDER BY SO_SalesOrderHeader.SalesOrderNo DESC";

            return sql;
        }

        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string GetMakeItemsQuery()
        {
            string sql = string.Empty;

             sql = "SELECT CI_Item.ItemCode, CI_Item.ProcurementType, " +
            "CI_Item.InactiveItem FROM CI_Item CI_Item " +
            "WHERE(CI_Item.ProcurementType = 'M') AND(CI_Item.InactiveItem = 'N')";

            return sql;
        }

        //public static DataTable GetSalesOrderItems(string soNumber)
        //{

        //    ODBCDataAccess bs = new ODBCDataAccess();

        //    DataTable tblBuildData = new DataTable();
        //    DataTable tblCurrent = new DataTable();
        //    DataTable tblHistory = new DataTable();

        //    OdbcParameter SOParam = new OdbcParameter();
        //    OdbcParameter SOParam2 = new OdbcParameter();



        //    string sql = null;
        //    string sql2 = null;

        //    sql = SalesOrderItemsQuery();
        //    sql2 = SalesOrderItemsHistoryQuery();

        //    //set the parameter equal to the customerNumber passed in
        //    SOParam.Value = soNumber;
        //    SOParam2.Value = soNumber;

        //    tblCurrent = bs.GetDynamicTableFromQuery(sql2, SOParam);
        //    tblHistory = bs.GetDynamicTableFromQuery(sql, SOParam2);

        //    tblBuildData = tblCurrent.Copy();
        //    tblBuildData.Merge(tblHistory);

        //    return tblBuildData;

        //}

        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>

        private static string ItemDescriptionsInfoQuery() {
            string sql = string.Empty;

            sql = "SELECT  CI.ItemCode, CI.UDF_CUSTOMER, CI.ItemCodeDesc " +
                    "FROM CI_Item CI WHERE(CI.ItemCode Not Like '/%') AND(CI.UDF_CUSTOMER Is Not Null) "+
                    "AND CI.ItemCode = ?";


            return sql;
        }

        public static DataTable GetItemDescriptionInfo(string itemCode) {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = itemCode;

            string sql = ItemDescriptionsInfoQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;
        }


        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string GetMemosQuery()
        {
            string sql = string.Empty;

            sql = "SELECT WOP_WorkOrderMemo.WorkOrder, WOP_WorkOrderMemo.MemoNumber, " +
            "WOP_WorkOrderMemo.MemoSeqNumber, WOP_WorkOrderMemo.MemoSubject, " +
            "WOP_WorkOrderMemo.MemoDate, WOP_WorkOrderMemo.MemoSize, WOP_WorkOrderMemo.ReminderDate, " +
            "WOP_WorkOrderMemo.MemoText FROM WOP_WorkOrderMemo WOP_WorkOrderMemo " +
            "Where WorkOrder = ? " +
            "ORDER BY WOP_WorkOrderMemo.WorkOrder DESC, WOP_WorkOrderMemo.MemoDate DESC ";           

            return sql;
        }

        public static DataTable GetMemos(string soNumber)
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = soNumber;

            string sql = GetMemosQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;

        }

        public static int GetMemoCount(string woNumber)
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            int RecordCount = 0;

            OdbcParameter Param = new OdbcParameter();

            Param.Value = woNumber;

            string sql = GetMemosCountQuery();

            RecordCount= bs.GetCount(sql, Param);

            return RecordCount;

        }


        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string GetMemosCountQuery() {
            string sql = string.Empty;

            sql = "SELECT Count(WOP_WorkOrderMemo.WorkOrder)  FROM WOP_WorkOrderMemo WOP_WorkOrderMemo " +
            "Where WorkOrder = ? ";

            return sql;
        }

        private static string GetBOMQuery()
        {
            string sql = string.Empty;

            sql = "SELECT BOMD.BillNo, BOMD.CommentText, BOMD.ComponentItemCode, " +
                  "BOMH.DateCreated, BOMH.UDF_BOMVDATE, BOMH.CurrentBillRevision " +
                  "FROM BM_BillDetail BOMD, BM_BillHeader BOMH " +
                  "WHERE BOMH.BillNo = BOMD.BillNo AND BOMH.Revision = BOMD.Revision AND BOMD.BILLNO = ?";

            return sql;
        }

        public static DataTable GetBOMInfo(string itemNumber)
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();        

            Param.Value = itemNumber;

            string sql = GetBOMQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;

        }



        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>

        private static string GetSchedulingQuery() {
            string sql = string.Empty;

            sql="SELECT WO_95_UDF_WOHeader.WorkOrder, " +
            "WO_95_UDF_WOHeader.Custname, " +
            "WO_95_UDF_WOHeader.Custpono, " +
            "WO_95_UDF_WOHeader.Cust_Req_Date, " +
            "WO_95_UDF_WOHeader.Cust_Req_Date2, " +
            "WO_95_UDF_WOHeader.Est_Flip_Date, " +
            "WO_95_UDF_WOHeader.Est_Flip_User, " +
            "WO_95_UDF_WOHeader.Orig_Promise, " +
            "WO_95_UDF_WOHeader.Wo_Notes, "+
            "WO_95_UDF_WOHeader.Wo_Opd, " +
            "WO_95_UDF_WOHeader.Wo_Planstatus, " +
            "WO_95_UDF_WOHeader.Wo_Planstatus2, " +
            "WO_95_UDF_WOHeader.Wo_Status " +
            "FROM WO_95_UDF_WOHeader WO_95_UDF_WOHeader WHERE (WO_95_UDF_WOHeader.WorkOrder = ?)";

            return sql;
        }


        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        public static DataTable GetScheduling(string woNumber)
        {

            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            //string csvWONumbers = string.Empty;
            //int counter = 1;
            //int totalCount = woNumbers.Count;

            //foreach(string woNumber in woNumbers)
            //{
            //    if (counter != totalCount)
            //    { csvWONumbers += woNumber + ","; }
            //    else
            //        csvWONumbers += woNumber;
            //    counter += 1;
            //}

            Param.Value = woNumber;

            string sql = GetSchedulingQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;

        }





        //public static DataTable GetShippingLabelData(string soNumber, string itemCode, bool current, string query)
        //{

        //    ODBCDataAccess bs = new ODBCDataAccess();

        //    DataTable tblBuildData = new DataTable();
        //    DataTable tblCurrent = new DataTable();
        //    DataTable tblHistory = new DataTable();
        //    OdbcCommand myOdbcCommand = new OdbcCommand();


        //    myOdbcCommand.Parameters.AddWithValue("SalesOrderNo", soNumber); //first ? in statement
        //    myOdbcCommand.Parameters.AddWithValue("ItemCode", itemCode); //second ? in statement
        //    //myOdbcCommand.Parameters.AddWithValue("warehouse", warehouse); //third ? in statement

        //    string sql = null;
        //    sql = query;
        //    if(current == false) {
        //        sql = query.Replace("SO_SalesOrderDetail", "SO_SalesOrderHistoryDetail");
        //        sql = sql.Replace("SO_SalesOrderHeader", "SO_SalesOrderHistoryHeader");
        //    }

        //     myOdbcCommand.CommandText = sql;
        //     tblBuildData = bs.GetDynamicTableMultipleParams(myOdbcCommand);
        // //   tblHistory = bs.GetDynamicTableFromQuery(sql, SOParam2);


        //    return tblBuildData;

        //}


        /// <summary>
        /// Order of the items in the query is important
        /// </summary>
        /// <returns></returns>
        private static string SalesOrderItemsQuery()
        {
           string sql = string.Empty;
            sql = "Select soh.salesOrderNo, sod.linekey linekey, " +
            "sod.warehouseCode, sod.ItemCode from so_salesorderheader soh, so_salesorderdetail sod where soh.salesorderno = sod.salesorderno and soh.salesorderno = ? ";
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

        //internal static DataTable GetFilteredTemplates(string askType)
        //{
        //    ODBCDataAccess bs = new ODBCDataAccess();

        //    DataTable tblBuildData = new DataTable();

        //    OdbcParameter Param = new OdbcParameter();

        //    Param.Value = askType;

        //    string sql = "Select TemplateName, TemplateType from Labels where TemplateType = ?";

        //    tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

        //    return tblBuildData;
        //}



        //private static string GetSpecificJobInfo(string)

        public static DataTable GetMakeItems()
        {
            ODBCDataAccess bs = new ODBCDataAccess();
            DataTable tblBuildData = new DataTable();
            string sql = GetMakeItemsQuery();

            tblBuildData = bs.GetAllDataFromQuery(sql);

            return tblBuildData;
        }

        private static string GetSalesOrderItemsQuery()
        {
            string sql = string.Empty;
            sql = "SELECT SO_SalesOrderHeader.SalesOrderNo+SO_SalesOrderDetail.ItemCode+SO_SalesOrderDetail.LineSeqNo AS 'unique', " +
                  "SO_SalesOrderHeader.SalesOrderNo, SO_SalesOrderDetail.ItemCode, SO_SalesOrderHeader.OrderType, AR_Customer.CustomerName " +
                  "FROM AR_Customer AR_Customer, SO_SalesOrderDetail SO_SalesOrderDetail, SO_SalesOrderHeader SO_SalesOrderHeader " +
                  "WHERE SO_SalesOrderDetail.SalesOrderNo = SO_SalesOrderHeader.SalesOrderNo AND AR_Customer.ARDivisionNo = SO_SalesOrderHeader.ARDivisionNo AND " +
                  "AR_Customer.CustomerNo = SO_SalesOrderHeader.CustomerNo " +
                  "AND (OrderType in ('B', 'S')) AND (SO_SalesOrderHeader.SalespersonNo = ? ) AND " +
                  "(SO_SalesOrderHeader.OrderStatus = 'O') Order by SO_SalesOrderHeader.SalesOrderNo DESC";
            return sql;
        }


        public static DataTable GetSalesOrderItems(string askType)
        {
            ODBCDataAccess bs = new ODBCDataAccess();

            DataTable tblBuildData = new DataTable();

            OdbcParameter Param = new OdbcParameter();

            Param.Value = askType;

            string sql = GetSalesOrderItemsQuery();

            tblBuildData = bs.GetDynamicTableFromQuery(sql, Param);

            return tblBuildData;
        }



    }
}
