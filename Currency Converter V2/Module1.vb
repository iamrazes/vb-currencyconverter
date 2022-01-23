Imports System.Data.Odbc

Module Module1
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public table As DataTable
    Public MyDB As String

    Public Sub Connect()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=vb_currencyconverterv2;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module
