using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using EquipmentInventoryModel;

public partial class List : System.Web.UI.Page {
    protected MetaTable table;
        
    protected void Page_Init(object sender, EventArgs e) {
        DynamicDataManager1.RegisterControl(GridView1, true);
    }

    protected void Page_Load(object sender, EventArgs e) {
        table = GridDataSource.GetTable();        
        Title = table.DisplayName;
        GridDataSource.Include = table.ForeignKeyColumnsNames;
        InsertHyperLink.NavigateUrl = table.GetActionPath(PageAction.Insert);

        // Disable various options if the table is readonly
        if (table.IsReadOnly) {
            GridView1.Columns[0].Visible = false;
            InsertHyperLink.Visible = false;
        }

        if (table.DisplayName == "Assignees") { MultiSearchAssigneesFieldSet.Visible = true; }
      //  else if (table.DisplayName == "MasterLists") { MultiSearchComputersFieldSet.Visible = true; }
        //else
        //{ MultiSearchAssigneesFieldSet.Visible = false; MultiSearchComputersFieldSet.Visible = false; }

    }

    protected void OnFilterSelectedIndexChanged(object sender, EventArgs e) {
        GridView1.PageIndex = 0;
    }

    protected void btnMultiColumnSearchSubmit_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;
        if (button.ID == btnMultiColumnSearchClear.ID)
        {
            txbMultiColumnSearch.Text = String.Empty;
        // allResults(table.DisplayName);
        }
        else
            using (EquipmentInventoryEntities Data = new EquipmentInventoryEntities())
            {
                string EmployeeNameString = txbMultiColumnSearch.Text;
                string PhoneNumber = string.Empty;
                char phoneExtension = 'x';

                //check to see if the search string is referring to a phone extension
                if (EmployeeNameString.StartsWith(phoneExtension.ToString()))
                    PhoneNumber = EmployeeNameString.TrimStart(phoneExtension);

                var SearchResults = Data.Assignees.Where
                   (Assignee => (Assignee.FirstName.Contains(EmployeeNameString)) ||
                   (Assignee.LastName.Contains(EmployeeNameString)) ||
                   (Assignee.PhoneExtension == PhoneNumber) ||
                   (Assignee.JobTitle.Contains(EmployeeNameString))
                   );

                GridView1.DataSourceID = "";
                GridView1.DataSource = SearchResults;
                GridView1.DataBind();


            }
    }

    //protected void btnMultiColumnSearchComputersSubmit_Click(object sender, EventArgs e)
    //{
    //    var button = (Button)sender;
    //    if (button.ID == btnMultiComputerClear.ID)
    //        txbMultiColumnSearchComputer.Text = String.Empty;
    //    else
    //        using (EquipmentInventoryEntities Data = new EquipmentInventoryEntities())
    //        {
    //            string EquipmentString = txbMultiColumnSearchComputer.Text;
               
    //            //check to see if the search string is referring to a phone extension

    //            var SearchResults = Data.MasterLists.Where
    //               (MasterList => (MasterList.Model.Contains(EquipmentString)) ||
    //               (MasterList.AssetName == EquipmentString) ||
    //               (MasterList.AssetTag == EquipmentString)                
    //               ).ToList();

    //            GridView1.DataSourceID = "";
    //            GridView1.DataSource = SearchResults;
    //            GridView1.DataBind();


    //        }
    //}

    //protected void allResults(string sender)
    //{
    //    if (sender == "Assignees")
    //    {
    //        using (EquipmentInventoryEntities Data = new EquipmentInventoryEntities())
    //        {
    //            var SearchResults = Data.Assignees.ToList();
    //            GridView1.DataSource = SearchResults;
    //        }
    //    }
    //    else
    //    {
    //        using (EquipmentInventoryEntities Data = new EquipmentInventoryEntities())
    //        {
    //            var SearchResults = Data.EquipmentTypes.ToList();
    //            GridView1.DataSource = SearchResults;
    //        }
    //    }
    //    GridView1.DataSourceID = "";
    //    GridView1.DataBind();
    //}
}
