Public Class DepartmentSummaries
#Region "Private Variables"
    Private _shipDate As String
    Private _intBacklogRemaining As Integer
    Private _intDueThisWeekPlanned As Integer
    Private _intDueThisWeekCompleted As Integer
    Private _intDueThisWeekRemaining As Integer
    Private _intDueThisWeekPercentComplete As Integer
    Private _intDueNextWeekPlanned As Integer
    Private _intDueNextWeekCompleted As Integer
    Private _intDueNextWeekRemaining As Integer
    Private _intDueNextWeekPercentComplete As Integer
    Private _boolShipThisWeek As Boolean = False
    Private _boolShipNextWeek As Boolean = False
    Private _quantityRemaining As Integer
    Private _dnwComplete As Integer
    Private _dtwComplete As Integer
    Private _dnwPlanned As Integer
    Private _dtwPlanned As Integer
    Private _dpwPlanned As Integer
    Private _dnwRemaining As Integer
    Private _dtwRemaining As Integer
    Private _dnwPercentage As Integer
    Private _dtwPercentage As Integer

#End Region

#Region "Public Properties"
    Public Property ShipDate() As String
        Get
            Return _shipDate
        End Get
        Set(ByVal value As String)
            _shipDate = value
        End Set
    End Property


    Public Property IntBackLogRemaining As Integer
        Get
            Return _intBacklogRemaining
        End Get
        Set(ByVal value As Integer)
            _intBacklogRemaining = value
        End Set
    End Property


    Public Property IntDueThisWeekPlanned As Integer
        Get
            Return _intDueThisWeekPlanned
        End Get
        Set(ByVal value As Integer)
            _intDueThisWeekPlanned = value
        End Set
    End Property


    Public Property IntDueThisWeekCompleted() As Integer
        Get
            Return _intDueThisWeekCompleted
        End Get
        Set(ByVal value As Integer)
            _intDueThisWeekCompleted = value
        End Set
    End Property


    Public Property IntDueThisWeekRemaining() As Integer
        Get
            Return _intDueThisWeekRemaining
        End Get
        Set(ByVal value As Integer)
            _intDueThisWeekRemaining = value
        End Set
    End Property


    Public Property IntDueThisWeekPercentComplete() As Integer
        Get
            Return _intDueThisWeekPercentComplete
        End Get
        Set(ByVal value As Integer)
            _intDueThisWeekPercentComplete = value
        End Set
    End Property


    Public Property IntDueNextWeekPlanned As Integer
        Get
            Return _intDueNextWeekPlanned
        End Get
        Set(ByVal value As Integer)
            _intDueNextWeekPlanned = value
        End Set
    End Property


    Public Property IntDueNextWeekCompleted() As Integer
        Get
            Return _intDueNextWeekCompleted
        End Get
        Set(ByVal value As Integer)
            _intDueNextWeekCompleted = value
        End Set
    End Property


    Public Property IntDueNextWeekRemaining() As Integer
        Get
            Return _intDueNextWeekRemaining
        End Get
        Set(ByVal value As Integer)
            _intDueNextWeekRemaining = value
        End Set
    End Property


    Public Property IntDueNextWeekPercentComplete() As Integer
        Get
            Return _intDueNextWeekPercentComplete
        End Get
        Set(ByVal value As Integer)
            _intDueNextWeekPercentComplete = value
        End Set
    End Property

    Public Property QuantityRemaining As Integer
        Get
            Return _quantityRemaining
        End Get
        Set(value As Integer)
            _quantityRemaining = value
        End Set
    End Property

    Public Property DnwComplete As Integer
        Get
            Return _dnwComplete
        End Get
        Set(value As Integer)
            _dnwComplete = value
        End Set
    End Property

    Public Property DtwComplete As Integer
        Get
            Return _dtwComplete
        End Get
        Set(value As Integer)
            _dtwComplete = value
        End Set
    End Property

    Public Property DnwPlanned As Integer
        Get
            Return _dnwPlanned
        End Get
        Set(value As Integer)
            _dnwPlanned = value
        End Set
    End Property

    Public Property DtwPlanned As Integer
        Get
            Return _dtwPlanned
        End Get
        Set(value As Integer)
            _dtwPlanned = value
        End Set
    End Property
    Public Property DpwPlanned As Integer
        Get
            Return _dpwPlanned
        End Get
        Set(value As Integer)
            _dpwPlanned = value
        End Set
    End Property

    Public Property DnwRemaining As Integer
        Get
            Return _dnwRemaining
        End Get
        Set(value As Integer)
            _dnwRemaining = value
        End Set
    End Property

    Public Property DtwRemaining As Integer
        Get
            Return _dtwRemaining
        End Get
        Set(value As Integer)
            _dtwRemaining = value
        End Set
    End Property

    Public Property DnwPercentage As Integer
        Get
            Return _dnwPercentage
        End Get
        Set(value As Integer)
            _dnwPercentage = value
        End Set
    End Property

    Public Property DtwPercentage As Integer
        Get
            Return _dtwPercentage
        End Get
        Set(value As Integer)
            _dtwPercentage = value
        End Set
    End Property

    Public Property BoolShipThisWeek As Boolean
        Get
            Return _boolShipThisWeek
        End Get
        Set(value As Boolean)
            _boolShipThisWeek = value
        End Set
    End Property

    Public Property BoolShipNextWeek As Boolean
        Get
            Return _boolShipNextWeek
        End Get
        Set(value As Boolean)
            _boolShipNextWeek = value
        End Set
    End Property

    Private _plannedForLastWeek As Integer
    Public Property PlannedForLastWeek() As Integer
        Get
            Return _plannedForLastWeek
        End Get
        Set(ByVal value As Integer)
            _plannedForLastWeek = value
        End Set
    End Property
#End Region

    'Default New Constructor
    Public Sub New()

        IntDueNextWeekCompleted = 0
        IntDueNextWeekPercentComplete = 0
        IntDueNextWeekPlanned = 0
        IntDueNextWeekRemaining = 0
        IntDueThisWeekCompleted = 0
        IntDueThisWeekPercentComplete = 0
        IntDueThisWeekPlanned = 0
        IntDueThisWeekRemaining = 0
        PlannedForLastWeek = 0

    End Sub
#Region "Worker Region"
    Public Sub AddComplete(ByVal intQty As Integer, ByVal shipThisWeek As Boolean, ByVal shipNextWeek As Boolean)

        BoolShipNextWeek = shipNextWeek
        BoolShipThisWeek = shipThisWeek

        If BoolShipNextWeek = True AndAlso BoolShipThisWeek = False Then
            If intQty > 0 Then
                IntDueNextWeekCompleted += intQty
                DnwComplete = IntDueNextWeekCompleted
            End If
        ElseIf BoolShipThisWeek = True AndAlso BoolShipNextWeek = False Then
            If intQty > 0 Then
                IntDueThisWeekCompleted += intQty
                DtwComplete = IntDueThisWeekCompleted
            End If
        Else
                'do Nothing if it is not due this week or next week, we don't care about those numbers 
            End If

    End Sub

    Public Sub AddPlanned(ByVal intQty As Integer, ByVal shipThisWeek As Boolean, ByVal shipNextWeek As Boolean)

        BoolShipNextWeek = shipNextWeek
        BoolShipThisWeek = shipThisWeek

        If BoolShipNextWeek = True AndAlso BoolShipThisWeek = False Then
            If intQty > 0 Then
                IntDueNextWeekPlanned += intQty
                DnwPlanned = IntDueNextWeekPlanned
            End If
        ElseIf BoolShipThisWeek = True AndAlso BoolShipNextWeek = False Then
            If intQty > 0 Then
                IntDueThisWeekPlanned += intQty
                DtwPlanned = IntDueThisWeekPlanned
            End If
        Else
            If intQty > 0 Then

            End If
        End If
    End Sub

    Public Sub AddPlannedForLastWeek(ByVal intQty As Integer)
        DpwPlanned += intQty
    End Sub

    Friend Sub AddBackLog(ByVal intQty As Integer, ByVal shipBackLog As Boolean, ByVal shipThisWeek As Boolean, ByVal shipNextWeek As Boolean)
        BoolShipNextWeek = shipNextWeek
        BoolShipThisWeek = shipThisWeek

        If BoolShipNextWeek = False AndAlso BoolShipThisWeek = False AndAlso shipBackLog = True AndAlso intQty > 0 Then
            IntBackLogRemaining += intQty
        End If
    End Sub



    Friend Sub AddRemaining(ByVal intQty As Integer, ByVal shipBackLog As Boolean, ByVal shipThisWeek As Boolean, ByVal shipNextWeek As Boolean)
        BoolShipNextWeek = shipNextWeek
        BoolShipThisWeek = shipThisWeek


        If BoolShipNextWeek = True AndAlso shipBackLog = False Then
            'If intQty > 0 Then
            '    QuantityRemaining += intQty
            '    DnwRemaining = QuantityRemaining
            'End If

            DnwRemaining = IntDueNextWeekPlanned - IntDueNextWeekCompleted

        ElseIf BoolShipThisWeek = True AndAlso shipBackLog = False Then
            'If intQty > 0 Then
            '    QuantityRemaining += intQty
            '    DtwRemaining = QuantityRemaining
            'End If
            DtwRemaining = IntDueThisWeekPlanned - IntDueThisWeekCompleted
        Else
            'do Nothing if it is not due this week or next week, we don't care about those numbers 
        End If
    End Sub
#End Region

#Region "Getters Region"
    Public Function GetPercentage(ByVal weekRef As String) As Integer
        Dim percentageRemaining As Integer = 0



        'this prevents division by zero fault
        If IntDueThisWeekPlanned > 0 AndAlso IntDueNextWeekPlanned > 0 Then
            If weekRef = "next" Then
                percentageRemaining = (IntDueNextWeekCompleted / IntDueNextWeekPlanned) * 100

                'If percentageRemaining > 100 Then
                '    percentageRemaining = 100
                'End If
                DnwPercentage = Math.Min(percentageRemaining, 100)
            Else
                percentageRemaining = (IntDueThisWeekCompleted / IntDueThisWeekPlanned) * 100

                'If percentageRemaining > 100 Then
                '    percentageRemaining = 100
                'End If

                DtwPercentage = Math.Min(percentageRemaining, 100)
            End If
        End If

        Return Math.Min(percentageRemaining, 100)
    End Function

    Public Function GetQuantityRemaining(ByVal status As String, ByVal amountPlanned As Integer, ByVal amountComplete As Integer) As Integer
        'This adds to the quantity Remaining if the status of the order is "C"
        Dim amount As Integer = 0
        If Not status = "C" Then
            amount = amountPlanned - amountComplete
        End If
        Return amount
    End Function

    Friend Function GetDNWCompleted() As String
        Return DnwComplete
    End Function

    Friend Function GetDNWPlanned() As String
        Return DnwPlanned
    End Function

    Friend Function GetDNWRemaining() As String
        Return DnwRemaining
    End Function

    Friend Function GetDTWCompleted() As String
        Return DtwComplete
    End Function

    Friend Function GetDNWPercentage() As String
        Return Math.Min(DnwPercentage, 100)
    End Function

    Friend Function GetDTWPlanned() As String
        Return DtwPlanned
    End Function

    Friend Function GETDTWRemaining() As String

        Return Math.Max(DtwRemaining, 0)
    End Function

    Friend Function GetBackLog() As String
        Return Math.Max(IntBackLogRemaining, 0)
    End Function

    Friend Function GetDPWPlanned() As String
        Return DpwPlanned
    End Function


#End Region
End Class

