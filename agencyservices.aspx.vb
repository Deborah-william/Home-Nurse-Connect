Imports System.Data.SqlClient
Imports System.Data
Public Class agencyservices
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        con.Open()
    End Sub

    Protected Sub btnagencyservices_Click(sender As Object, e As EventArgs) Handles btnagencyservices.Click
        Dim instr As String
        instr = "insert into Agency_service(Agencyservice_name) values ('" + txtagencyservicename.Text + "')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, con)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        txtagencyservicename.Text = ""
    End Sub

    Protected Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtagencyservicename.TextChanged

    End Sub
End Class