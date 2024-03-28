Imports System.Data.SqlClient
Imports System.Data

Public Class deleteaccount
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        con.Open()
    End Sub

    Protected Sub btnadminaccount_Click(sender As Object, e As EventArgs) Handles btnadminaccount.Click
        Dim instr As String
        instr = "insert into Deleteadminaccount(Admindelete_name,Login_id,Confirm Delete Account) values ('" + TextBox3.Text + "' , '" + TextBox4.Text + "', '" + TextBox5.Text + "')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, con)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class