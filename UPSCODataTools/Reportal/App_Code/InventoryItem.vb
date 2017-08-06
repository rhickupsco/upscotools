Imports Microsoft.VisualBasic

Public Class InventoryItem
    Private _localID As Integer
    Public Property LocalId() As Integer
        Get
            Return _localID
        End Get
        Set(ByVal value As Integer)
            _localID = value
        End Set
    End Property
    Private _partNumber As String
    Public Property PartNumber() As String
        Get
            Return _partNumber
        End Get
        Set(ByVal value As String)
            _partNumber = value
        End Set
    End Property

    Private _customer As String
    Public Property Customer() As String
        Get
            Return _customer
        End Get
        Set(ByVal value As String)
            _customer = value
        End Set
    End Property
End Class
