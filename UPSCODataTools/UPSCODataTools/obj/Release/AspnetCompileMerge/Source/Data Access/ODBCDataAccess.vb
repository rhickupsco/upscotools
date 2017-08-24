Imports System.Data.Odbc
Public Class ODBCDataAccess 'Sage Connection Class
    Private Conn As OdbcConnection
    Private Comm As OdbcCommand
    Private Dr As OdbcDataReader
    Private ConnectionString As String
    Private Dt As DataTable
    'This is the function you call to return all data with no parameters
    Public Function GetAllDataFromQuery(ByVal sql As String) As DataTable
        Initialize()
        Connect(sql)
        Return Fill()
    End Function
    'This is the function you call to return all data that has one filter parameter, such as ("Where workOrder = ?", workOrderNo)
    Public Function GetDynamicTableFromQuery(ByVal sql As String, ByVal parameter As Odbc.OdbcParameter) As DataTable
        Initialize()
        'Add the parameters
        Comm.Parameters.Add(parameter)
        Connect(sql)
        Return (Fill())
    End Function
    'This is the function you would call to return a single string value from a table such as "the value is green"
    Public Function GetSingleString(ByVal sql As String, Optional parameter As Odbc.OdbcParameter = Nothing) As String
        If parameter IsNot Nothing Then
            Initialize()
            Comm.Parameters.Add(parameter)
            Try
                Connect(sql)
                Dim dtLocal As New DataTable
                dtLocal = Fill()
                Dim strValue As String
                strValue = String.Concat(dtLocal.Rows(0)(0).ToString, ",", dtLocal.Rows(0)(1).ToString)
                Return strValue
            Catch ex As Exception
                Return ("none")
            End Try
        Else

        End If
        Return Nothing
    End Function
    'This is the function you would call to return a boolean  value from a table such as True
    Public Function GetBooleanValue(ByVal sql As String) As Boolean
        Return Nothing
    End Function
    'This is the function you would call to return a single Integer value from a table such as the total count of records in a file
    Public Function GetCount(ByVal sql As String) As Integer
        Return Nothing
    End Function
    'This is the function you would call to return a single double value from a table such as 14.75
    Public Function GetDouble(ByVal sql As String) As Double
        Return Nothing
    End Function
    'This is the function you would call to return a single integer value from a table such as 28
    Public Function GetInteger(ByVal sql As String) As Integer
        Return Nothing
    End Function

    Private Sub Initialize()
        Dt = New DataTable
        'this is the reference to the SQL Connection string which is the login details and location of the Sage Database
        'Can be modified in the app.config
        ConnectionString = "DSN=Sage 100 2014; UID=swk; PWD=indigo01; 
        Directory=\\mas3\Sage\Version_2014\MAS90; 
        Prefix=\\mas3\Sage\Version_2014\MAS90\SY\,\\mas3\Sage\Version_2014\MAS90\==\; 
        ViewDLL=\\mas3\Sage\Version_2014\MAS90\Home; Company=UMD; LogFile=\PVXODBC.LOG; 
        RemotePVKIOHost=MAS3; DirtyReads=1; BurstMode=1; StripTrailingSpaces=1; 
        SERVER=NotTheServer"
        'this builds a new connection to the database
        Conn = New OdbcConnection(ConnectionString)
        'this is a container for the command that you will send it on its way with, such as "Select * from LabelsTable"
        Comm = New OdbcCommand()
    End Sub

    Private Sub Connect(ByVal sql As String)
        'this assigns the query to the comm object
        Comm.CommandText = sql

        'this assigns the connection to the comm object
        Comm.Connection = Conn
        Comm.Connection.ConnectionTimeout = 30
        Comm.CommandTimeout = 600
        Try
            'this establishes the connection ad opens it to the database, like a funnel
            Conn.Open()
        Catch ex As Exception
            Throw New Exception("Connection to SAGE database failed -" + ex.ToString())
        End Try

    End Sub

    Private Function Fill() As DataTable
        'Excecute the command that is loaded in the comm object (open the valve on the funnel to let the data flow from the datasource)
        Dr = Comm.ExecuteReader()
        'Fill dataTable with contents from datareader
        Dt.Load(Dr)
        Return Dt
    End Function

    Private Function GetSrtringValue() As String
        Dim strResult As String = Nothing
        Dr = Comm.ExecuteScalar

        strResult = Dr.GetString(0)

        Return strResult
    End Function

    Public Sub Disconnect()
        'Clean up after yourselves and close the connections, good housekeeping
        Conn.Close()
        Dr.Close()
        Comm.Dispose()
        Conn.Dispose()
        Dt.Dispose()
    End Sub



End Class
