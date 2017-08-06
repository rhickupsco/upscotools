Partial Class MissingParts
    Inherits System.Web.UI.Page


    Dim sList As New List(Of InventoryItem)

    Private _shipmentDate As Date
    Public Property ShipmentDate() As Date
        Get
            Return _shipmentDate
        End Get
        Set(ByVal value As Date)
            _shipmentDate = value
        End Set
    End Property

    Private Sub ListView1_ItemDataBound(sender As Object, e As ListViewItemEventArgs) Handles ListView1.ItemDataBound

        Dim item As ListViewItem
        item = e.Item
        sList.Add(New InventoryItem() With {
             .LocalId = item.DataItemIndex,
             .Customer = item.DataItem("WorkCenter").ToString()
             })


    End Sub

    Private Sub Open_Order_Repair_Parts_View_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Page.IsPostBack Then
            '    btnClear.Visible = True
        Else
            Dim currDate As New Date
            currDate = Date.Today

            While (currDate.DayOfWeek <> DayOfWeek.Friday)
                currDate = currDate.AddDays(1)
            End While

            ShipmentDate = currDate

            SageDS1.SelectCommand =
            "Select wood.WorkOrder, WO1_WorkOrderMaster.QtyPlanned, WO1_WorkOrderMaster.WODueDate, wood.StepNumber, " &
            "WO1_WorkOrderMaster.Status, wood.WorkCenter, " &
            "wood.OperationCode, wood.StepDescription, " &
            "wood.StepComplete, wood.QtyCompleted, " &
            "wood.StdRunTime, wood.ExtdStdTime, " &
            "wood.ActualRunTime, wood.StdLaborCost, " &
            "wood.StdMaterialCost, wood.StdLaborVariableOHCost, " &
            "wood.ActualLaborCost, wood.ActualMaterialCost, " &
            "wood.ActualOutsideProcessCost, wood.ActualLaborFixedOH, " &
            "wood.ActualLaborVariableOHCost, wood.RunHoursSchedOnStartDate " &
            "From WO1_WorkOrderMaster WO1_WorkOrderMaster, WO3_WorkOrderOperationDetail wood " &
            "Where WO1_WorkOrderMaster.WorkOrder = wood.WorkOrder And WO1_WorkOrderMaster.SubstepSuffix = wood.SubstepSuffix " &
            "And WO1_WorkOrderMaster.WODueDate between {fn CURDATE()} AND {fn CURDATE()}+6   And WO1_WorkOrderMaster.QtyPlanned <> wood.QtyCompleted And " &
            "wood.workcenter <> 'WHSE1' AND wood.operationcode NOT IN ('00098', '00099') ORDER BY wood.StepNumber ASC"


        End If

    End Sub

    'Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    Dim searchParameter As String
    '    If txtSearchParam.Text.Trim <> Nothing Then
    '        searchParameter = txtSearchParam.Text.Trim.ToString().ToUpper()
    '    Else
    '        searchParameter = "none"
    '    End If

    '    SageDS1.FilterParameters.Add("WorkCenter", searchParameter.ToString())
    '    SageDS1.FilterExpression = "workCenter = '{0}'"

    '    Try
    '        ListView1.DataBind()
    '    Catch ex As Exception
    '        Response.Write("MAS Was Too Slow, Please Click Show All Again")
    '    End Try


    'End Sub

    Private Function LoadShipDate() As Date
        Dim NextFriday As Date = GetNext(DayOfWeek.Friday)
        Return NextFriday
    End Function


    Private Function GetNext(ByVal d As DayOfWeek) As Date
        Dim StartDate As New DateTime()
        StartDate = System.DateTime.Now()

        For p As Integer = 0 To 6
            If StartDate.AddDays(p).DayOfWeek = d Then
                StartDate = StartDate.AddDays(p)
            End If
        Next

        Return StartDate
    End Function

End Class
