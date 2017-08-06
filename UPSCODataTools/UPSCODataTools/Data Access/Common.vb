Module Common



    Private Function sqlGenerator() As String
        Dim Sql As String

        '''''Removed  -----   AND (wood.operationcode NOT IN ('00003', '00002', '00005')) --------- From Query on 4/10/2017 

        Sql = "SELECT wom.QtyPlanned, wom.WODueDate, 
                    wood.StepNumber, wom.Status,                
                    wood.QtyCompleted, wom.WorkOrder
                    From  WO1_WorkOrderMaster wom, WO3_WorkOrderOperationDetail wood
                    Where (wom.WorkOrder = wood.WorkOrder And wom.SubstepPrefix = wood.SubstepPrefix)
                    AND (wom.WODueDate between {d '" + GetMonthsBack() + "'} and  {d '" + GetFutureShipDate() + "'})
                    AND (wood.StepNumber In ('0010','0020','0021','0023','0043','0030','0040','0050')) AND (wood.operationcode NOT IN ('00003', '00002', '00005'))
                    ORDER BY wom.WODueDate ASC"
        Return Sql




        Return Sql
    End Function

    Public Function isNumeric(ByVal expression As Object) As Boolean
        Dim isNumber As Boolean = False
        Dim s As Double
        isNumber = Double.TryParse(expression, s)
        Return isNumber
    End Function
    Public Function GetSummaryData() As DataTable
        Dim bs As New ODBCDataAccess
        Dim tblBuildData As New DataTable
        Dim sql As String
        sql = sqlGenerator()
        tblBuildData = bs.GetAllDataFromQuery(sql)
        Return tblBuildData
    End Function

    Public Function GetTestData(ByVal stepNumber As String) As DataTable
        Dim da As New ODBCDataAccess
        Dim tblTestData As New DataTable
        Dim sql As String
        sql = sqlGenerator(stepNumber)
        tblTestData = da.GetAllDataFromQuery(sql)
        Return tblTestData
    End Function
    Public Function GetNonCertData(ByVal stepNumber As String) As DataTable
        Dim da As New ODBCDataAccess
        Dim tblTestData As New DataTable
        Dim sql As String
        sql = sqlGenerator(stepNumber)
        tblTestData = da.GetAllDataFromQuery(sql)
        Return tblTestData
    End Function
    Public Function GetWeldData(ByVal stepNumber As String) As DataTable
        Dim da As New ODBCDataAccess
        Dim tblTestData As New DataTable
        Dim sql As String
        sql = sqlGenerator(stepNumber)
        tblTestData = da.GetAllDataFromQuery(sql)
        Return tblTestData
    End Function
    Public Function GetPaintData(ByVal stepNumber As String) As DataTable
        Dim da As New ODBCDataAccess
        Dim tblTestData As New DataTable
        Dim sql As String
        sql = sqlGenerator(stepNumber)
        tblTestData = da.GetAllDataFromQuery(sql)
        Return tblTestData
    End Function
    Public Function GetNippleData(ByVal stepNumber As String) As DataTable
        Dim da As New ODBCDataAccess
        Dim tblTestData As New DataTable
        Dim sql As String
        sql = sqlGenerator(stepNumber)
        tblTestData = da.GetAllDataFromQuery(sql)
        Return tblTestData
    End Function

    Public Function LoadShipDate() As Date
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
    Private Function GetFollowingFriday(ByVal d As DayOfWeek) As Date

        Dim StartDate As New DateTime()
        StartDate = LoadShipDate()

        For p As Integer = 2 To 7
            If StartDate.AddDays(p).DayOfWeek = d Then
                StartDate = StartDate.AddDays(p)
            End If
        Next

        Return StartDate.AddDays(1)
    End Function

    Public Function GetMonthsBack() As String
        Dim StartDate As New DateTime()
        StartDate = System.DateTime.Now()
        StartDate = DateAdd(DateInterval.Day, -90, StartDate)
        Return StartDate.ToString("yyyy-MM-dd")
    End Function


    Private Function GetPastShipDate() As String
        Dim StartDate As New DateTime()
        StartDate = System.DateTime.Now()
        StartDate = DateAdd(DateInterval.Day, -7, StartDate)
        Return StartDate.ToString("yyyy-MM-dd")
    End Function

    Public Function GetFutureShipDate() As String
        Dim SecondFriday As Date = GetFollowingFriday(DayOfWeek.Friday)

        Dim StartDate As New DateTime()
        StartDate = System.DateTime.Now()
        StartDate = GetFollowingFriday(DayOfWeek.Friday)
        'This is used to go through the Following Fridady
        StartDate.AddDays(1)
        Return StartDate.ToString("yyyy-MM-dd")
    End Function

    Public Function ToPercentString(ByVal unformattedNumber As Integer) As String
        Return Math.Min(unformattedNumber, 100).ToString() + "%"
    End Function
End Module
