Public Class JumbotronNorth
    Inherits Page
    Public Property Shipdate As String

    Public Property PreviousShipDate As String
    ''This is for Certified Weld
    Public Property CWBackLogRemaining As String = String.Empty
    Public Property CWDTWPlanned As String = String.Empty
    Public Property CWDTWCompleted As String = String.Empty
    Public Property CWDTWRemaining As String = String.Empty
    Public Property CWDTWPCTCompleted As String = String.Empty
    Public Property CWDNWPlanned As String = String.Empty
    Public Property CWDNWCompleted As String = String.Empty
    Public Property CWDNWRemaining As String = String.Empty
    Public Property CWDNWPCTCompleted As String = String.Empty
    'This is for NonCertified Weld
    Public Property NCWBackLogRemaining As String = String.Empty
    Public Property NCWDTWPlanned As String = String.Empty
    Public Property NCWDTWCompleted As String = String.Empty
    Public Property NCWDTWRemaining As String = String.Empty
    Public Property NCWDTWPCTCompleted As String = String.Empty
    Public Property NCWDNWPlanned As String = String.Empty
    Public Property NCWDNWCompleted As String = String.Empty
    Public Property NCWDNWRemaining As String = String.Empty
    Public Property NCWDNWPCTCompleted As String = String.Empty
    'This is for Nipple
    Public Property NIPBackLogRemaining As String = String.Empty
    Public Property NIPDTWPlanned As String = String.Empty
    Public Property NIPDTWCompleted As String = String.Empty
    Public Property NIPDTWRemaining As String = String.Empty
    Public Property NIPDTWPCTCompleted As String = String.Empty
    Public Property NIPDNWPlanned As String = String.Empty
    Public Property NIPDNWCompleted As String = String.Empty
    Public Property NIPDNWRemaining As String = String.Empty
    Public Property NIPDNWPCTCompleted As String = String.Empty
    'This is for Paint
    Public Property PNTBackLogRemaining As String = String.Empty
    Public Property PNTDTWPlanned As String = String.Empty
    Public Property PNTDTWCompleted As String = String.Empty
    Public Property PNTDTWRemaining As String = String.Empty
    Public Property PNTDTWPCTCompleted As String = String.Empty
    Public Property PNTDNWPlanned As String = String.Empty
    Public Property PNTDNWCompleted As String = String.Empty
    Public Property PNTDNWRemaining As String = String.Empty
    Public Property PNTDNWPCTCompleted As String = String.Empty
    'This is for Test
    Public Property TSTBackLogRemaining As String = String.Empty
    Public Property TSTDTWPlanned As String = String.Empty
    Public Property TSTDTWCompleted As String = String.Empty
    Public Property TSTDTWRemaining As String = String.Empty
    Public Property TSTDTWPCTCompleted As String = String.Empty
    Public Property TSTDNWPlanned As String = String.Empty
    Public Property TSTDNWCompleted As String = String.Empty
    Public Property TSTDNWRemaining As String = String.Empty
    Public Property TSTDNWPCTCompleted As String = String.Empty
    'This is for Test
    Public Property TST2BackLogRemaining As String = String.Empty
    Public Property TST2DTWPlanned As String = String.Empty
    Public Property TST2DTWCompleted As String = String.Empty
    Public Property TST2DTWRemaining As String = String.Empty
    Public Property TST2DTWPCTCompleted As String = String.Empty
    Public Property TST2DNWPlanned As String = String.Empty
    Public Property TST2DNWCompleted As String = String.Empty
    Public Property TST2DNWRemaining As String = String.Empty
    Public Property TST2DNWPCTCompleted As String = String.Empty
    'This is for Build
    Public Property BLDBackLogRemaining As String = String.Empty
    Public Property BLDDTWPlanned As String = String.Empty
    Public Property BLDDTWCompleted As String = String.Empty
    Public Property BLDDTWRemaining As String = String.Empty
    Public Property BLDDTWPCTCompleted As String = String.Empty
    Public Property BLDDNWPlanned As String = String.Empty
    Public Property BLDDNWCompleted As String = String.Empty
    Public Property BLDDNWRemaining As String = String.Empty
    Public Property BLDDNWPCTCompleted As String = String.Empty

    Public Property BLDDPWPlanned As String = String.Empty




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This sets the next shipdate to the next Fdiday as next ship date
        Shipdate = "Shipment Date: " + Common.LoadShipDate().ToShortDateString

        'This establishes a connection to the database and return data using odbc collection (Sage 2014 DSN Connection)
        LoadValues()
        DataBind()

    End Sub

    Private Sub LoadValues()

        Dim i As Integer = 0
        Dim shippingDueDate As DateTime = Common.LoadShipDate
        Dim orderDueDate As DateTime = DateTime.Now
        Dim dateDifference As New TimeSpan()
        Dim shipDateDiff As New TimeSpan()
        Dim shipThisWeek As Boolean = False
        Dim shipNextWeek As Boolean = False
        Dim shipBackLog As Boolean = False
        Dim WODueDate As New DateTime()
        Dim thisShipDueDate As New DateTime()
        Dim nextShipDate As New DateTime()
        Dim summaryTable As DataTable = New DataTable
        Dim auditTable As DataTable = New DataTable
        Dim daysTilThisFriday As Integer = 0
        Dim daysTilNextFriday As Integer = 0
        Dim previousShipDate As New DateTime()
        Dim auditFlag As Boolean = False


        thisShipDueDate = shippingDueDate
        nextShipDate = Common.GetFutureShipDate()
        'this gets us to midnight of the next shipdate
        nextShipDate = nextShipDate.AddDays(1)
        'this sets the number of days til the next friday
        daysTilThisFriday = CInt(thisShipDueDate.Subtract(orderDueDate).Days)
        'this sets the number of days til the Friday after next
        daysTilNextFriday = CInt(nextShipDate.Subtract(orderDueDate).Days)


        'Load all data into the local datatable
        summaryTable = Common.GetSummaryData()
        '   auditTable = Common.GetPlannedAuditData()



        If summaryTable.Rows.Count > 0 Then
            For i = 0 To summaryTable.Rows.Count - 1

                Dim qtyToAddForRemaining As Integer = 0
                Dim qtyCompleted As Integer = 0
                Dim qtyPlanned As Integer = 0

                'determine when the item Is planned to ship
                If summaryTable.Rows(i).Item("WODueDate").ToString() IsNot Nothing AndAlso
                Not IsDBNull(summaryTable.Rows(i).Item("WODueDate")) Then

                    Dim tempWOName As String = summaryTable.Rows(i).Item(5).ToString


                    WODueDate = CDate(summaryTable.Rows(i).Item("WODueDate"))
                    dateDifference = WODueDate.Subtract(shippingDueDate)

                    'If dateDifference.Days >= -10 AndAlso dateDifference.Days < -7 Then
                    '    shipBackLog = True
                    '    shipThisWeek = False
                    '    shipNextWeek = False
                    '    auditFlag = True

                    If dateDifference.Days <= (daysTilThisFriday - 7) Then
                        shipBackLog = True
                        shipThisWeek = False
                        shipNextWeek = False
                        auditFlag = True

                    ElseIf dateDifference.Days <= daysTilThisFriday Then
                        shipThisWeek = True
                        shipNextWeek = False
                        shipBackLog = False

                    ElseIf dateDifference.Days < daysTilNextFriday Then
                        shipNextWeek = True
                        shipThisWeek = False
                        shipBackLog = False
                    Else
                        shipThisWeek = False
                        shipNextWeek = False
                        shipBackLog = False

                    End If
                End If



                Dim thissin As New ListItem


                Select Case summaryTable.Rows(i).Item("StepNumber").ToString().Trim()
                    Case "0010" 'Nipple Data

                        Dim sumNip As DepartmentSummaries
                        If sumNip Is Nothing Then
                            sumNip = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumNip.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")


                        If shipBackLog = False Then


                            If shipNextWeek = False AndAlso shipThisWeek = True Then

                                sumNip.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumNip.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumNip.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then

                                sumNip.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumNip.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumNip.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                        Else

                            If auditFlag Then

                                sumNip.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                            'If qtyToAddForRemaining > 0 Then
                            '    sumNip.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            'End If

                        End If


                        NIPBackLogRemaining = sumNip.GetBackLog()

                        NIPDTWPlanned = sumNip.GetDTWPlanned()
                        NIPDTWCompleted = sumNip.GetDTWCompleted()
                        NIPDTWRemaining = sumNip.GETDTWRemaining()

                        NIPDNWPlanned = sumNip.GetDNWPlanned()
                        NIPDNWCompleted = sumNip.GetDNWCompleted()
                        NIPDNWRemaining = sumNip.GetDNWRemaining()

                    Case "0020" 'Non Certified Weld Data

                        Dim sumNonCert As DepartmentSummaries
                        If sumNonCert Is Nothing Then
                            sumNonCert = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumNonCert.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then


                            If shipNextWeek = False AndAlso shipThisWeek = True Then

                                sumNonCert.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumNonCert.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumNonCert.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then
                                sumNonCert.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumNonCert.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumNonCert.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                        Else
                            If auditFlag Then

                                sumNonCert.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            End If

                            ' If qtyToAddForRemaining > 0 Then
                            'sumNonCert.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            ' End If

                        End If
                        NCWBackLogRemaining = sumNonCert.GetBackLog()
                        NCWDNWCompleted = sumNonCert.GetDNWCompleted()
                        NCWDNWPlanned = sumNonCert.GetDNWPlanned()
                        NCWDNWRemaining = sumNonCert.GetDNWRemaining()
                        NCWDTWCompleted = sumNonCert.GetDTWCompleted()
                        NCWDTWPlanned = sumNonCert.GetDTWPlanned()
                        NCWDTWCompleted = sumNonCert.GetDTWCompleted()
                        NCWDTWRemaining = sumNonCert.GETDTWRemaining()

                    Case "0021" 'Non Certified Weld Data

                        Dim sumNonCert As DepartmentSummaries
                        If sumNonCert Is Nothing Then
                            sumNonCert = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumNonCert.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then


                            If shipNextWeek = False AndAlso shipThisWeek = True Then

                                sumNonCert.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumNonCert.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumNonCert.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then
                                sumNonCert.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumNonCert.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumNonCert.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                        Else

                            If auditFlag Then


                                sumNonCert.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If
                            ' If qtyToAddForRemaining > 0 Then
                            'sumNonCert.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            ' End If

                        End If
                        NCWBackLogRemaining = sumNonCert.GetBackLog()
                        NCWDNWCompleted = sumNonCert.GetDNWCompleted()
                        NCWDNWPlanned = sumNonCert.GetDNWPlanned()
                        NCWDNWRemaining = sumNonCert.GetDNWRemaining()
                        NCWDTWCompleted = sumNonCert.GetDTWCompleted()
                        NCWDTWPlanned = sumNonCert.GetDTWPlanned()
                        NCWDTWCompleted = sumNonCert.GetDTWCompleted()
                        NCWDTWRemaining = sumNonCert.GETDTWRemaining()

                    Case "0023" 'Certified Weld Data
                        Dim sumCert As DepartmentSummaries
                        If sumCert Is Nothing Then
                            sumCert = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumCert.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then


                            If shipNextWeek = False AndAlso shipThisWeek = True Then

                                sumCert.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumCert.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumCert.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then

                                sumCert.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumCert.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumCert.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                        Else
                            If auditFlag Then


                                sumCert.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                            'If qtyToAddForRemaining > 0 Then
                            '    sumCert.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            'End If

                        End If
                        CWBackLogRemaining = sumCert.GetBackLog()
                        CWDNWCompleted = sumCert.GetDNWCompleted()

                        CWDNWPlanned = sumCert.GetDNWPlanned()
                        CWDNWRemaining = sumCert.GetDNWRemaining()

                        CWDTWCompleted = sumCert.GetDTWCompleted()
                        CWDTWPlanned = sumCert.GetDTWPlanned()
                        CWDTWCompleted = sumCert.GetDTWCompleted()
                        CWDTWRemaining = sumCert.GETDTWRemaining()

                    Case "0030" 'Build Data
                        Dim sumBuild As DepartmentSummaries
                        If sumBuild Is Nothing Then
                            sumBuild = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumBuild.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then


                            If shipNextWeek = False AndAlso shipThisWeek = True Then

                                sumBuild.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumBuild.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumBuild.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then

                                sumBuild.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumBuild.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumBuild.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If

                        Else

                            'This is a call to add the qty Planned during the "Planned to be shipped Last Week" timeframe
                            If auditFlag Then


                                sumBuild.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)


                            End If

                        End If
                        BLDBackLogRemaining = sumBuild.GetBackLog()
                        BLDDNWCompleted = sumBuild.GetDNWCompleted()

                        BLDDNWPlanned = sumBuild.GetDNWPlanned()
                        BLDDNWRemaining = sumBuild.GetDNWRemaining()

                        BLDDTWCompleted = sumBuild.GetDTWCompleted()
                        BLDDTWPlanned = sumBuild.GetDTWPlanned()
                        BLDDTWCompleted = sumBuild.GetDTWCompleted()
                        BLDDTWRemaining = sumBuild.GETDTWRemaining()
                        BLDDPWPlanned = sumBuild.GetDPWPlanned()

                    Case "0040" 'Test Data
                        Dim sumTest As DepartmentSummaries
                        If sumTest Is Nothing Then
                            sumTest = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumTest.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then

                            If shipNextWeek = False AndAlso shipThisWeek = True Then


                                sumTest.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumTest.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumTest.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then

                                sumTest.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumTest.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumTest.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If



                        Else
                            If auditFlag Then


                                sumTest.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If
                            'If qtyToAddForRemaining > 0 Then
                            '        sumTest.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            '    End If

                        End If
                        TSTBackLogRemaining = sumTest.GetBackLog()
                        TSTDNWCompleted = sumTest.GetDNWCompleted()

                        TSTDNWPlanned = sumTest.GetDNWPlanned()
                        TSTDNWRemaining = sumTest.GetDNWRemaining()

                        TSTDTWCompleted = sumTest.GetDTWCompleted()
                        TSTDTWPlanned = sumTest.GetDTWPlanned()
                        TSTDTWCompleted = sumTest.GetDTWCompleted()
                        TSTDTWRemaining = sumTest.GETDTWRemaining()

                    Case "0043" 'Test2 Data
                        Dim sumTest As DepartmentSummaries
                        If sumTest Is Nothing Then
                            sumTest = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumTest.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then

                            If shipNextWeek = False AndAlso shipThisWeek = True Then


                                sumTest.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumTest.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)

                                If qtyToAddForRemaining > 0 Then
                                    sumTest.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                                End If


                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then

                                sumTest.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumTest.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumTest.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If



                        Else
                            If auditFlag Then


                                sumTest.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If
                            'If qtyToAddForRemaining > 0 Then
                            '        sumTest.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            '    End If

                        End If
                        TST2BackLogRemaining = sumTest.GetBackLog()
                        TST2DNWCompleted = sumTest.GetDNWCompleted()

                        TST2DNWPlanned = sumTest.GetDNWPlanned()
                        TST2DNWRemaining = sumTest.GetDNWRemaining()

                        TST2DTWCompleted = sumTest.GetDTWCompleted()
                        TST2DTWPlanned = sumTest.GetDTWPlanned()
                        TST2DTWCompleted = sumTest.GetDTWCompleted()
                        TST2DTWRemaining = sumTest.GETDTWRemaining()



                    Case "0050" 'Paint Data
                        Dim sumPaint As DepartmentSummaries
                        If sumPaint Is Nothing Then
                            sumPaint = New DepartmentSummaries()
                        End If

                        qtyToAddForRemaining = sumPaint.GetQuantityRemaining(summaryTable.Rows(i).Item("Status"), summaryTable.Rows(i).Item("QtyPlanned"), summaryTable.Rows(i).Item("QtyCompleted"))
                        qtyCompleted = summaryTable.Rows(i).Item("QtyCompleted")
                        qtyPlanned = summaryTable.Rows(i).Item("QtyPlanned")

                        If shipBackLog = False Then


                            If shipNextWeek = False AndAlso shipThisWeek = True Then

                                sumPaint.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumPaint.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)


                                sumPaint.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)



                            ElseIf shipNextWeek = True AndAlso shipThisWeek = False Then


                                sumPaint.AddComplete(qtyCompleted, shipThisWeek, shipNextWeek)
                                sumPaint.AddPlanned(qtyPlanned, shipThisWeek, shipNextWeek)
                                sumPaint.AddRemaining(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)

                            End If



                        Else
                            If auditFlag Then


                                sumPaint.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)


                            End If
                            'If qtyToAddForRemaining > 0 Then
                            '    sumPaint.AddBackLog(qtyToAddForRemaining, shipBackLog, shipThisWeek, shipNextWeek)
                            'End If

                        End If
                        PNTBackLogRemaining = sumPaint.GetBackLog()
                        PNTDNWCompleted = sumPaint.GetDNWCompleted()

                        PNTDNWPlanned = sumPaint.GetDNWPlanned()
                        PNTDNWRemaining = sumPaint.GetDNWRemaining()

                        PNTDTWCompleted = sumPaint.GetDTWCompleted()
                        PNTDTWPlanned = sumPaint.GetDTWPlanned()
                        PNTDTWCompleted = sumPaint.GetDTWCompleted()
                        PNTDTWRemaining = sumPaint.GETDTWRemaining()

                    Case Else

                End Select


            Next

            ''''''''''''''''''Testing for Completion Rating with Red to Yellow to Green and Errors''''''''''''''''''''''''''''''''''''''''''''
            Dim lowerLimit As Double = 50
            Dim homestretch As Double = 90

            ''''''''''''''''''''Non certified Weld'''''''''''''''''

            If (NCWDTWPlanned > 0) Then
                NCWDTWPCTCompleted = Common.ToPercentString(CInt((NCWDTWCompleted / NCWDTWPlanned) * 100))
            Else
                NCWDTWPCTCompleted = Common.ToPercentString(0)
            End If

            If (NCWDNWPlanned > 0) Then
                NCWDNWPCTCompleted = Common.ToPercentString(CInt((NCWDNWCompleted / NCWDNWPlanned) * 100))
            Else
                NCWDNWPCTCompleted = Common.ToPercentString(0)
            End If

            If isNumeric(NCWDTWPCTCompleted.Replace("%", "")) Then
                If CDbl(NCWDTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
                    ncw.Attributes.Add("class", "behind")
                ElseIf CDbl(NCWDTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(NCWDTWPCTCompleted.Replace("%", "")) < homestretch Then
                    ncw.Attributes.Add("class", "mediocre")
                ElseIf CDbl(NCWDTWPCTCompleted.Replace("%", "")) >= homestretch Then
                    ncw.Attributes.Add("class", "excellent")
                    If CDbl(NCWDTWRemaining <> (NCWDTWPlanned - NCWDTWCompleted)) Then
                        ncw.Attributes.Add("class", "error")
                    End If

                End If
            End If

            '''''''''''''''''''''''''''Nipple''''''''''''''''''''''

            If (NIPDTWPlanned > 0) Then
                NIPDTWPCTCompleted = Common.ToPercentString(CInt((NIPDTWCompleted / NIPDTWPlanned) * 100))
            Else
                NIPDTWPCTCompleted = Common.ToPercentString(0)
            End If

            If (NIPDNWPlanned > 0) Then
                NIPDNWPCTCompleted = Common.ToPercentString(CInt((NIPDNWCompleted / NIPDNWPlanned) * 100))
            Else
                NIPDNWPCTCompleted = Common.ToPercentString(0)
            End If

            If isNumeric(NIPDTWPCTCompleted.Replace("%", "")) Then
                If CDbl(NIPDTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
                    nip.Attributes.Add("class", "behind")
                ElseIf CDbl(NIPDTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(NIPDTWPCTCompleted.Replace("%", "")) < homestretch Then
                    nip.Attributes.Add("class", "mediocre")
                ElseIf CDbl(NIPDTWPCTCompleted.Replace("%", "")) >= homestretch Then
                    nip.Attributes.Add("class", "excellent")
                    If CDbl(NIPDTWRemaining <> (NIPDTWPlanned - NIPDTWCompleted)) Then
                        nip.Attributes.Add("class", "error")
                    End If
                End If
            End If

            ''''''''''''''''''''Paint'''''''''''''''''''''

            'If (PNTDTWPlanned > 0) Then
            '    PNTDTWPCTCompleted = Common.ToPercentString(CInt((PNTDTWCompleted / PNTDTWPlanned) * 100))
            'Else
            '    PNTDTWPCTCompleted = Common.ToPercentString(0)
            'End If

            'If (PNTDNWPlanned > 0) Then
            '    PNTDNWPCTCompleted = Common.ToPercentString(CInt((PNTDNWCompleted / PNTDNWPlanned) * 100))
            'Else
            '    PNTDNWPCTCompleted = Common.ToPercentString(0)
            'End If



            'If isNumeric(PNTDTWPCTCompleted.Replace("%", "")) Then
            '    If CDbl(PNTDTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
            '        pnt.Attributes.Add("class", "behind")
            '    ElseIf CDbl(PNTDTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(PNTDTWPCTCompleted.Replace("%", "")) < homestretch Then
            '        pnt.Attributes.Add("class", "mediocre")
            '    ElseIf CDbl(PNTDTWPCTCompleted.Replace("%", "")) >= homestretch Then
            '        pnt.Attributes.Add("class", "excellent")
            '        If CDbl(PNTDTWRemaining <> (PNTDTWPlanned - PNTDTWCompleted)) Then
            '            pnt.Attributes.Add("class", "error")
            '        End If
            '    End If
            'End If

            ''''''''''''''''''''''''' Test 1 '''''''''''''''''''
            'If (TSTDTWPlanned > 0) Then
            '    TSTDTWPCTCompleted = Common.ToPercentString(CInt((TSTDTWCompleted / TSTDTWPlanned) * 100))
            'Else
            '    TSTDTWPCTCompleted = Common.ToPercentString(0)
            'End If

            'If (TSTDNWPlanned > 0) Then
            '    TSTDNWPCTCompleted = Common.ToPercentString(CInt((TSTDNWCompleted / TSTDNWPlanned) * 100))
            'Else
            '    TSTDNWPCTCompleted = Common.ToPercentString(0)
            'End If

            'If isNumeric(TSTDTWPCTCompleted.Replace("%", "")) Then
            '    If CDbl(TSTDTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
            '        tst.Attributes.Add("class", "behind")
            '    ElseIf CDbl(TSTDTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(TSTDTWPCTCompleted.Replace("%", "")) < homestretch Then
            '        tst.Attributes.Add("class", "mediocre")
            '    ElseIf CDbl(TSTDTWPCTCompleted.Replace("%", "")) >= homestretch Then
            '        tst.Attributes.Add("class", "excellent")
            '        If CDbl(TSTDTWRemaining <> (TSTDTWPlanned - TSTDTWCompleted)) Then
            '            tst.Attributes.Add("class", "error")
            '        End If
            '    End If
            'End If

            ''''''''''''''''''''''''Test 2'''''''''''''''''''''''''''''''

            If (TST2DTWPlanned > 0) Then
                TST2DTWPCTCompleted = Common.ToPercentString(CInt((TST2DTWCompleted / TST2DTWPlanned) * 100))
            Else
                TST2DTWPCTCompleted = Common.ToPercentString(0)
            End If

            If (TST2DNWPlanned > 0) Then
                TST2DNWPCTCompleted = Common.ToPercentString(CInt((TST2DNWCompleted / TST2DNWPlanned) * 100))
            Else
                TST2DNWPCTCompleted = Common.ToPercentString(0)
            End If

            If isNumeric(TST2DTWPCTCompleted.Replace("%", "")) Then
                If CDbl(TST2DTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
                    tst2.Attributes.Add("class", "behind")
                ElseIf CDbl(TST2DTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(TST2DTWPCTCompleted.Replace("%", "")) < homestretch Then
                    tst2.Attributes.Add("class", "mediocre")
                ElseIf CDbl(TST2DTWPCTCompleted.Replace("%", "")) >= homestretch Then
                    tst2.Attributes.Add("class", "excellent")
                    If CDbl(TST2DTWRemaining <> (TST2DTWPlanned - TSTDTWCompleted)) Then
                        tst2.Attributes.Add("class", "error")
                    End If
                End If
            End If


            ''''''''''''''''''''''''Build '''''''''''''''''''''''''
            'If (BLDDTWPlanned > 0) Then
            '    BLDDTWPCTCompleted = Common.ToPercentString(CInt((BLDDTWCompleted / BLDDTWPlanned) * 100))
            'Else
            '    BLDDTWPCTCompleted = Common.ToPercentString(0)
            'End If

            'If (BLDDNWPlanned > 0) Then
            '    BLDDNWPCTCompleted = Common.ToPercentString(CInt((BLDDNWCompleted / BLDDNWPlanned) * 100))
            'Else
            '    BLDDNWPCTCompleted = Common.ToPercentString(0)
            'End If

            'If isNumeric(BLDDTWPCTCompleted.Replace("%", "")) Then
            '    If CDbl(BLDDTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
            '        bld.Attributes.Add("class", "behind")
            '    ElseIf CDbl(BLDDTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(BLDDTWPCTCompleted.Replace("%", "")) < homestretch Then
            '        bld.Attributes.Add("class", "mediocre")
            '    ElseIf CDbl(BLDDTWPCTCompleted.Replace("%", "")) >= homestretch Then
            '        bld.Attributes.Add("class", "excellent")
            '        If CDbl(BLDDTWRemaining <> (BLDDTWPlanned - BLDDTWCompleted)) Then
            '            bld.Attributes.Add("class", "error")
            '        End If
            '    End If
            'End If

            '''''''''''''''''''''''''Certified Weld '''''''''''''''''''''''''''''

            If (CWDTWPlanned > 0) Then
                CWDTWPCTCompleted = Common.ToPercentString(CInt((CWDTWCompleted / CWDTWPlanned) * 100))
            Else
                CWDTWPCTCompleted = Common.ToPercentString(0)
            End If

            If (CWDNWPlanned > 0) Then
                CWDNWPCTCompleted = Common.ToPercentString(CInt((CWDNWCompleted / CWDNWPlanned) * 100))
            Else
                CWDNWPCTCompleted = Common.ToPercentString(0)
            End If




            If isNumeric(CWDTWPCTCompleted.Replace("%", "")) Then
                If CDbl(CWDTWPCTCompleted.Replace("%", "")) <= lowerLimit Then
                    cw.Attributes.Add("class", "behind")
                ElseIf CDbl(CWDTWPCTCompleted.Replace("%", "")) > lowerLimit AndAlso CDbl(CWDTWPCTCompleted.Replace("%", "")) < homestretch Then
                    cw.Attributes.Add("class", "mediocre")
                ElseIf CDbl(CWDTWPCTCompleted.Replace("%", "")) >= homestretch Then
                    cw.Attributes.Add("class", "excellent")
                    If CDbl(CWDTWRemaining <> (CWDTWPlanned - CWDTWCompleted)) Then
                        cw.Attributes.Add("class", "error")
                    End If
                End If
            End If
        End If
    End Sub








End Class