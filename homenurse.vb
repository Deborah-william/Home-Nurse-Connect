Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Public Class test
    Public con As SqlConnection = New SqlConnection

    Public Function connect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Dim str As String = ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString
        con.ConnectionString = str
        con.Open()
        Return con
    End Function

End Class
