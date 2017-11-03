using System;
using System.IO;
using System.Reflection;
using System.Data;
using Data_Access;
using System.Web.UI.WebControls;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;

public partial class MyOrders : System.Web.UI.Page
{

    public int OrderCount { get; set; }
    private List<SalesOrder> lsChanges = new List<SalesOrder>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            LoadSalesPersons();
            //lsChanges = await RetrieveChanges();
        }

    }


    private void LoadSalesPersons()
    {

        ddlSalesTeam.Items.Clear();

        DataTable dt = new DataTable();

        string salesTeamName = string.Empty;
        string insideSalesPersonName = string.Empty;
        string outsideSalesPersonName = string.Empty;
        string teamNumber = string.Empty;


        dt = CommonData.GetSalesPersonNames();

        if (dt.Rows.Count > 1)
        {
            foreach (DataRow items in dt.Rows)
            {
                salesTeamName = items["SalespersonName"].ToString();
                insideSalesPersonName = items["UDF_INSIDE"].ToString();
                outsideSalesPersonName = items["UDF_OUTSIDE"].ToString();
                teamNumber = items["SalespersonNo"].ToString();

                ComboItem salesPerson = new ComboItem();
                salesPerson.Text = string.Format("{0} Sales Team: {1} / {2}", salesTeamName, insideSalesPersonName, outsideSalesPersonName);
                salesPerson.Value = teamNumber;

                ListItem li = new ListItem(salesPerson.Text, salesPerson.Value);

                ddlSalesTeam.Items.Add(li);
            }
        }

    }

    protected void btnGetMySalesOrders_Click(object sender, EventArgs e)
    {
        DataTable dtSalesOrders = new DataTable();
        List<string> lsSalesOrdersFiltered = new List<string>();

        string selectedSalesTeamNumber = ddlSalesTeam.SelectedValue.ToString();
        
        dtSalesOrders = CommonData.GetMySalesOrders(selectedSalesTeamNumber);

        /////remove items that are not make items
        if (cbOnlyMake.Checked == true)
        {
            DataTable dtMakeItems = new DataTable();
            dtMakeItems = CommonData.GetMakeItems();

            List<string> makeList = new List<string>();

            foreach (DataRow part in dtMakeItems.Rows)
            {
                makeList.Add(part["ItemCode"].ToString());
            }

            DataTable dtSalesOrderItems = new DataTable();
            dtSalesOrderItems = CommonData.GetSalesOrderItems(selectedSalesTeamNumber);

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
            dtSalesOrderItems = RemoveDuplicateRows(dtSalesOrderItems, "SalesOrderNo");

            dlMyOrders.DataSource = dtSalesOrderItems;

            OrderCount = dtSalesOrderItems.Rows.Count;
            LoadInfoFromXML();

            /////this section moved to service
            //   try
            //   {
            //       foreach (DataRow item in dtSalesOrderItems.Rows)
            //       {
            //           Information infoItem = new Information();

            //           infoItem.SalesOrderNo = item["SalesOrderNo"].ToString();
            //           infoItem.PromiseDate = DateTime.Now;
            //           infoItem.OriginalPromiseDate = new DateTime(2017, 12, 01);
            //           infoItem.Status = "O";

            ////           WriteValues(infoItem);
            //       }
            //   }
            //   catch (Exception ex)
            //   {
            //       Response.Write("Could Not Save Information: " + ex.Data.ToString());
            //   }
            dlMyOrders.DataBind();


        }
        else
        {
            dlMyOrders.DataSource = dtSalesOrders;
            OrderCount = dtSalesOrders.Rows.Count;
            LoadInfoFromXML();
            dlMyOrders.DataBind();
        }
    }

    protected string UrlHelper(string prefix, object link)
    {
        return prefix + link.ToString();
    }

    protected string OrderStringBuilder(object firstVar, object secondVar)
    {
        return String.Format("{0} {1}", firstVar.ToString(), secondVar.ToString());
    }

    public DataTable RemoveDuplicateRows(DataTable source, string colName)
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

    //private async void CheckOrderDates()
    //{
    //    Task<InformationList> task = new Task<InformationList>(LoadInfoFromXml);
    //    task.Start();

    //    int totalChangeCount = 0;

    //    lsChanges = await task;
    //    OrderCount = totalChangeCount;

    //}

    private void LoadInfoFromXML()
    {
        int totalChangesFound = 0;
        XMLHandler xh = new XMLHandler();
        lsChanges = xh.GetListOfChanges();
        totalChangesFound = lsChanges.Count;
         
    }

    //moved to service on UPSCOSP

    //    protected void WriteValues(Information i)
    //    {
    //        try
    //        {
    //            SaveXML.SaveData(i);
    //        }
    //        catch (Exception ex)
    //        {
    //            System.Diagnostics.Debug.WriteLine("Could Not Check for changes: " + ex.Data.ToString());
    //        }
    //    }

    protected void dlMyOrders_ItemDataBound(object sender, DataListItemEventArgs e)
    {


        if( e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Button SoNum = (Button)e.Item.FindControl("lblSONum");

            DataTable view = (DataTable)dlMyOrders.DataSource;

            string currentOrderType = view.Rows[e.Item.ItemIndex]["OrderType"].ToString();
            if(currentOrderType == "B" && (!SoNum.CssClass.Contains("changes"))) {
               
           
                SoNum.CssClass = "order backOrder";
               
            }

            string currentOrder = view.Rows[e.Item.ItemIndex]["SalesOrderNo"].ToString();
            var value = lsChanges.FindIndex(item => item.SalesOrderNo == currentOrder);

            if(value >= 0) { 
            //this is where I will look for the sales order in the list of changes
                SoNum.CssClass += " changes";
            //append some detail into the mouse hover information area somehow

            }


        }

    }
}
public class ComboItem
{
    public string Text { get; set; }
    public string Value { get; set; }

    public override string ToString()
    {
        return Text;
    }
}