Public Class WorkOrder
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _workOrderNumber As String
    Public Property WorkOrderNumber() As String
        Get
            Return _workOrderNumber
        End Get
        Set(ByVal value As String)
            _workOrderNumber = value
        End Set
    End Property

    Private _qtyPlanned As Double
    Public Property QtyPlanned() As Double
        Get
            Return _qtyPlanned
        End Get
        Set(ByVal value As Double)
            _qtyPlanned = value
        End Set
    End Property

    Private _woDueDate As Date
    Public Property WODueDate() As Date
        Get
            Return _woDueDate
        End Get
        Set(ByVal value As Date)
            _woDueDate = value
        End Set
    End Property

    Private _stepNumber As String
    Public Property StepNumber() As String
        Get
            Return _stepNumber
        End Get
        Set(ByVal value As String)
            _stepNumber = value
        End Set
    End Property

    Private _status As Char
    Public Property Status() As Char
        Get
            Return _status
        End Get
        Set(ByVal value As Char)
            _status = value
        End Set
    End Property

    Private _qtyCompleted As Double
    Public Property QtyCompleted() As Double
        Get
            Return _qtyCompleted
        End Get
        Set(ByVal value As Double)
            _qtyCompleted = value
        End Set
    End Property

End Class
