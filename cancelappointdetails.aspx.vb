Imports System.Data.SqlClient
Imports System.Data

Public Class canceldetails
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        con.Open()
    End Sub

    Protected Sub btncancelappointdetails_Click(sender As Object, e As EventArgs) Handles btncancelappointdetails.Click
        Dim instr As String
        instr = "insert into cancelappointdetails(Appoint_id,Agency_id,Customer_id) values ('" + TextBox5.Text + "' , '" + TextBox1.Text + "', '" + TextBox4.Text + "')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, con)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        TextBox5.Text = ""
        TextBox1.Text = ""
        TextBox4.Text = ""
    End Sub
End Class