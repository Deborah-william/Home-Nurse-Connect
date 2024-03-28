Imports System.Data.SqlClient
Imports System.Data

Public Class deleteagencyaccount
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        con.Open()
    End Sub

    Protected Sub btndeleteagencyaccount_Click(sender As Object, e As EventArgs) Handles btndeleteagencyaccount.Click
        Dim instr As String
        instr = "insert into Deleteagencyaccount(Deleteagency_id,Agency_id) values ('" + TextBox1.Text + "' , '" + TextBox3.Text + "')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, con)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        TextBox1.Text = ""
        TextBox3.Text = ""
    End Sub
End Class