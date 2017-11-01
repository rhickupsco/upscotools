using System;
using System.IO;
using System.Drawing;
using System.Data;
using Data_Access;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

public partial class Default2 : System.Web.UI.Page
{

    public string SONumber { get; set; }
    public string WONumber { get; set; }
    public List<string>WONumberList { get; set; }
    public string LateStatus { get; set; }
    public string HoldStatus { get; set; }
    public string MathcingItemDescriptions { get; set; }
    public string PromiseDate { get; set; }
    public string BOMRevision { get; set; }
    public string ProductionStatus { get; set; }
    public string UDF_Customer { get; set; }
    public string ItemDescription { get; set; }
    public int OrderCount { get; set; }


    protected void Page_Load(object sender, EventArgs e)
    {
        string soNum = Request.QueryString["id"];
        SONumber = soNum;

        if (!Page.IsPostBack)
        {
            
            if (soNum != null)
            {               
                LoadSODetails();
                panelWrapper.Attributes.Add("class", "whiteBackTall panel");
                
                //only load the WO Scheduling details if there are WorkOrder Details
                if (LoadWODetails()==true) {
                    LoadScheduling();
                   contentBottom.Attributes.Add("class", "whiteBack panel");
                  }
                else {
                   // summaryContainer.Attributes.Add("class", "hide");                    
                }

                //Databind needs to go here to handles property binding with or without WO results
                DataBind();
              }
       
        }
        if (soNum != null)
        {
            Response.Write("<p class='title'>Sales Order " + soNum.ToString() + " Details</p>");            
        }

    }

    private void LoadScheduling()
    {
        DataTable dtSched = new DataTable();
        dtSched = CommonData.GetScheduling(WONumber);
        int rowCount = dtSched.Rows.Count;

        if ( rowCount > 0)
        {
            WOFooterTextHere(rowCount);
            gvScheduling.DataSource = dtSched;
            gvScheduling.DataBind();
        }     
    }

    private bool LoadWODetails()
    {
        DataTable dtDetails = new DataTable();
        WONumberList = new List<string>();
        bool available = false;

        dtDetails = CommonData.GetWODetails(SONumber);

        foreach (DataRow dr in dtDetails.Rows)
        {
            string woNum = string.Empty;
            woNum = dr.ItemArray[7].ToString();
            WONumberList.Add(woNum);
        }

        if (dtDetails.Rows.Count > 0)
        {            
            WONumber = dtDetails.Rows[0]["WorkOrder"].ToString();
            available = true;        
            dvWODetails.DataSource = dtDetails;
            dvWODetails.DataBind();           
        }

        return available;
     
    }

    private void LoadSODetails()
    {
        DataTable dtDetails = new DataTable();
        
        dtDetails = CommonData.GetSODetails(SONumber);
        if (dtDetails.Rows.Count > 0)
        {
            dvSODetails.DataSource = dtDetails;
            dvSODetails.DataBind();
        }
        else {
            panelWrapper.InnerHtml = "<h1 class='contrast'>This Sales Order contains no rows that are associated with shippable items</h1>";
        }
        
    }

    protected string SOHeaderTextHere()
    {
        string response = string.Empty;

        response = "Sales Order Details for SO# " + SONumber.ToString();
        return response;
    }

    protected string WOHeaderTextHere()
    {
        int totalMemoCount = 0;
        string response = string.Empty;

        if(WONumber != null){ 
        response = "Work Order Details for WO# " + WONumber.ToString();
            totalMemoCount = CommonData.GetMemoCount(WONumber);

            response += " - " + totalMemoCount.ToString() + " Memos Available";
        }

        return response;
    }

    protected string WOFooterTextHere(int records=0)
    {
        string response = string.Empty;

        if (records > 0)
            response = "Scheduling Information is available";
        else response = "No Scheduling Information available";
        

        return response;
    }
    
    protected string MemoCount() {
        int totalMemoCount = 0;
        string response = string.Empty;
        
        if(WONumber != null)
        totalMemoCount = CommonData.GetMemoCount(WONumber);

        if(totalMemoCount == 0)
        {
            response = "No Memos Available for this Work Order";
        }
        else {
            response = totalMemoCount.ToString() + " Memos Available For this WorkOrder";
        }

        return response;
    }

    protected void dvWODetails_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

   // if(WONumber != null)
        ChangePage(e.NewPageIndex);
    }

    protected void dvSODetails_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        ChangePage(e.NewPageIndex);
    }

    protected void ChangePage(int pageNum)
    {
        DataTable dtWODetails = new DataTable();
        DataTable dtSODetails = new DataTable();

        string soNum = Request.QueryString["id"];
        if (soNum != null) { 
            dtWODetails = CommonData.GetWODetails(soNum);

            dvWODetails.PageIndex = pageNum;
            dvWODetails.DataSource = dtWODetails;
            if (dtWODetails.Rows.Count > 0)
            {
                try
                {
                    WONumber = dtWODetails.Rows[pageNum]["WorkOrder"].ToString();
                }
                catch (Exception)
                {
                    WONumber = dtWODetails.Rows[0]["WorkOrder"].ToString();
                }
            }
               

            LoadScheduling();
           dvWODetails.DataBind();
         }
       
        dtSODetails = CommonData.GetSODetails(soNum);

        dvSODetails.PageIndex = pageNum;
        dvSODetails.DataSource = dtSODetails;
        dvSODetails.DataBind();

        DataBind();
    }


    protected void dvWODetails_DataBound(object sender, EventArgs e)

    {
        if (WONumber != null)
        {

            if (dvWODetails.Rows[12].Cells[1].Text == "Y")
            {
                HoldStatus = "ON HOLD";
                holdDiv.Attributes.Add("class", "error");
            }
            else
            {
                HoldStatus = "NOT ON HOLD";
            }

            if (dvWODetails.Rows[2].Cells[1].Text.Length > 1)
            {
                DataTable dt = CommonData.GetBOMInfo(dvWODetails.Rows[2].Cells[1].Text.ToString());

                if (dt.Rows.Count > 0)
                {
                    var specifiedColumn = dt.Columns.Cast<DataColumn>().SingleOrDefault(col => col.ColumnName == "CurrentBillRevision");
                    if (specifiedColumn != null)
                    {

                        DataRow row = dt.Rows[0];
                        string rowValue = row[specifiedColumn.ColumnName].ToString();

                        if (rowValue.Contains("V"))
                        {
                            bomDiv.Attributes.Add("class", "error");
                        }
                        BOMRevision = rowValue.ToString();

                    }

                }

                DateTime promiseDate;
                DateTime woDueDate;

                if (DateTime.TryParse(dvSODetails.Rows[5].Cells[1].Text.ToString(), out promiseDate))
                {
                    if (DateTime.TryParse(dvWODetails.Rows[5].Cells[1].Text.ToString(), out woDueDate))
                    {
                        if (promiseDate < woDueDate)
                        {
                            LateStatus = "LATE";
                            onTimeDiv.Attributes.Add("class", "error");
                            dvSODetails.Rows[5].Cells[1].BackColor = Color.Yellow;
                            dvWODetails.Rows[5].Cells[1].BackColor = Color.Yellow;
                        }
                        else
                        {

                            onTimeDiv.Attributes.Add("class", "dashboard");
                            LateStatus = "ON TIME";
                        }

                    }
                }
            }

            ///////Testing production Status
            if (dvWODetails.Rows[10].Cells[1].Text.Length > 0)
            {
                string status = string.Empty;
                status = dvWODetails.Rows[10].Cells[1].Text.ToString();
                switch (status)
                {
                    case "F":
                        status = "Firm Planned";
                        break;
                    case "R":
                        status = "Released";
                        break;
                    case "E":
                        status = "Estimate";
                        productionDiv.Attributes.Add("class", "estimate");
                        break;
                    case "C":
                        status = "Completed";
                        productionDiv.Attributes.Add("class", "completed");
                        break;

                    default:
                        status = "Error Retrieving Status";
                        productionDiv.Attributes.Add("class", "error");
                        break;
                }

                ProductionStatus = status;
            }

            if (dvWODetails.Rows[2].Cells[1].ToString() != string.Empty)
            {
                string itemCode = dvWODetails.Rows[2].Cells[1].Text.ToString().TrimEnd();
                DataTable it = new DataTable();
                it = CommonData.GetItemDescriptionInfo(itemCode);
                OrderCount = it.Rows.Count;
                if (it.Rows.Count > 0)
                {
                    UDF_Customer = it.Rows[0][1].ToString();
                    ItemDescription = it.Rows[0][2].ToString();
                }
                else {
                //replaced by databound property
                    //ItemsLabelingInfo.InnerHtml = "<h1 class='contrast'>No special labeling information</h1>";
                }


            }


        }
    }


    protected void dvSODetails_DataBound(object sender, EventArgs e)
    {
        
        if (dvSODetails.Rows[5].Cells[1].Text != null)
        {
            PromiseDate = dvSODetails.Rows[5].Cells[1].Text.ToString();
        }
        else
        {
            PromiseDate = "NOT PROMISED";
        }


        ///Original Promise Date Check
        if (dvSODetails.Rows[17].Cells[1].Text.Length > 1)
        {
            DateTime originalPromiseDate;
            DateTime promiseDate;


           if (DateTime.TryParse(dvSODetails.Rows[17].Cells[1].Text.ToString(), out originalPromiseDate))
            {
                if(DateTime.TryParse(dvSODetails.Rows[5].Cells[1].Text.ToString(), out promiseDate)){
                    if(originalPromiseDate < promiseDate) {
                        LateStatus = "RE-PROMISED";
                      onTimeDiv.Attributes.Add("class", "error");
                        dvSODetails.Rows[5].Cells[1].BackColor = Color.Yellow;
                        dvSODetails.Rows[17].Cells[1].BackColor = Color.Yellow;
                    }
                    else {
                        onTimeDiv.Attributes.Add("class","dashboard");
                        LateStatus = "ON TIME"; }
                }
            }
            else {
                LateStatus = "NOT AVAILABLE";
                onTimeDiv.Attributes.Add("class", "error");
                dvSODetails.Rows[5].Cells[1].BackColor = Color.Yellow;
                dvSODetails.Rows[17].Cells[1].BackColor = Color.Yellow;
            }

          

        }
        else
        {
            LateStatus = "NOT AVAILABLE";
        }
    }

    protected void gvScheduling_DataBound(object sender, EventArgs e)
    {
        if (WONumber != null)
        {
            if (gvScheduling.Rows[0].Cells[12].Text.Length > 1)
            {
                string status = string.Empty;
                status = gvScheduling.Rows[0].Cells[12].Text.ToString();
                if (status == "DEL")
                {
                    LateStatus = "ORDER DELAYED";
                    onTimeDiv.Attributes.Add("class", "error");
                    gvScheduling.Rows[0].BackColor = Color.Yellow;
                }
            }
        }
    }
}