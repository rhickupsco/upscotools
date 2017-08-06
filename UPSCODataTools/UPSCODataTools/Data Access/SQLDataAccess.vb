Imports System.Data.SqlClient
Imports System

'If you want a rundown of how everything works in this class, see notes from ODBCDataAccess.vb file in this project
Public Class SQLDataAccess
    Private Conn As SqlConnection
    Private Comm As SqlCommand
    Private Dr As SqlDataReader
    Private ConnectionString As String
    Private Dt As DataTable

    Public Function GetAllDataFromQuery(ByVal sql As String) As DataTable
        Initialize()
        Connect(sql)
        Return Fill()
    End Function
    Public Function GetDynamicTableFromQuery(ByVal sql As String, ByVal parameter() As String) As DataTable
        Return Nothing
    End Function
    Public Function GetSingleString(ByVal sql As String, Optional parameter As String = Nothing) As String
        If parameter IsNot Nothing Then

            'create a variable to store a parameter in, this parameter will replace the ? in the query you see from the database
            Dim itemParam As New SqlParameter("@parameter", parameter)

            Initialize()
            Comm.Parameters.Add(itemParam)
            Try
                Connect(sql)
                Dim dtLocal As New DataTable
                dtLocal = Fill()
                Dim strValue As String
                strValue = dtLocal.Rows(0)(0).ToString
                Return strValue
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
        Else

        End If
        Return Nothing
    End Function

    Public Function GetSingleRow(ByVal sql As String, Optional parameter As String = Nothing) As DataTable
        If parameter IsNot Nothing Then

            'create a variable to store a parameter in, this parameter will replace the @parameter value in the query you see from the database
            Dim itemParam As New SqlParameter("@parameter", parameter)

            Initialize()
            Comm.Parameters.Add(itemParam)
            Try
                Connect(sql)
                Return Fill()
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
        Else

        End If
        Return Nothing
    End Function

    Public Function GetBooleanValue(ByVal sql As String) As Boolean
        Return Nothing
    End Function
    Public Function GetCount(ByVal sql As String) As Integer
        Return Nothing
    End Function
    Public Function GetDouble(ByVal sql As String) As Double
        Return Nothing
    End Function
    Public Function GetInteger(ByVal sql As String) As Integer
        Return Nothing
    End Function

    Private Sub Initialize()
        Dt = New DataTable
        'this is the reference to the SQL Connection string which is the login details and location of the SQL Database, 
        'can be modified in the APP.Config
        ConnectionString = My.MySettings.Default.Item("SqlConnectionString").ToString
        Conn = New SqlConnection(ConnectionString)
        Comm = New SqlCommand()
    End Sub

    Private Sub Connect(ByVal sql As String)
        Comm.CommandText = sql
        Comm.Connection = Conn
        Conn.Open()
    End Sub

    Private Function Fill() As DataTable
        Dim dt As New DataTable

        Dr = Comm.ExecuteReader()
        'Fill dataTable with contents from datareader
        dt.Load(Dr)
        Return dt

    End Function

    Public Sub Disconnect()
        Conn.Close()
        Dr.Close()
        Comm.Dispose()
        Conn.Dispose()
        Dt.Dispose()
    End Sub

End Class
