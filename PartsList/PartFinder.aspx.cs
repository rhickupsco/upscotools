using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PartFinder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int rowIndex = -1;
        string searchString = TextBox1.Text;

        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.Cells[1].Text.ToString().Equals(searchString))
            {
                rowIndex = row.RowIndex;
                break;
            }
        }
        if (rowIndex >= 0)
        {
            GridView1.SelectedIndex = rowIndex;
            GridView1.Focus();
            GridView1.SelectedRow.Focus();
        }
    }

    protected void btnDescription_Click(object sender, EventArgs e)
    {
        int rowIndex = -1;
        string searchString = TextBox2.Text;

        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.Cells[2].Text.ToString().Contains(searchString))
            {
                rowIndex = row.RowIndex;
                break;
            }
        }
        if (rowIndex >= 0)
        {
            GridView1.SelectedIndex = rowIndex;
            GridView1.Focus();
            GridView1.SelectedRow.Focus();
        }
    }
}