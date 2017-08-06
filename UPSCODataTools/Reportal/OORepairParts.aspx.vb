Imports System.Data
Partial Class Open_Order_Repair_Parts_View
    Inherits System.Web.UI.Page
    Dim sList As New List(Of InventoryItem)

    Private Sub ListView1_ItemDataBound(sender As Object, e As ListViewItemEventArgs) Handles ListView1.ItemDataBound

        Dim item As ListViewItem
        item = e.Item
        sList.Add(New InventoryItem() With {
             .LocalId = item.DataItemIndex,
             .PartNumber = item.DataItem("ItemCode").ToString(),
             .Customer = item.DataItem("ShipToName").ToString().ToUpper()
             })


    End Sub

    Private Sub Open_Order_Repair_Parts_View_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Page.IsPostBack Then
            btnClear.Visible = True
        End If

    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchParameter As String
        If txtSearchParam.Text.Trim <> Nothing Then
            searchParameter = txtSearchParam.Text.Trim.ToString().ToUpper()
        Else
            searchParameter = "none"
        End If

        SageDS1.FilterParameters.Add("ItemCode", searchParameter.ToString())
        SageDS1.FilterParameters.Add("ShipToName", searchParameter.ToString())
        SageDS1.FilterExpression = "ItemCode LIKE '%{0}%' or ShipToName LIKE '%{0}%'"
        Try
            ListView1.DataBind()
        Catch ex As Exception
            Response.Write("MAS Was Too Slow, Please Click Show All Again")
        End Try


    End Sub


    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'btnClear.Visible = False
        'SageDS1.FilterParameters.Clear()
        'ListView1.DataSourceID = "SageDS1"
        'ListView1.DataBind()
    End Sub
End Class
