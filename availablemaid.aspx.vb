Imports System.Data.SqlClient
Imports System.Data

Public Class appointmaid
    Inherits System.Web.UI.Page
    Dim co As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        co.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        co.Open()
    End Sub

    Protected Sub btnavailablemaid_Click(sender As Object, e As EventArgs) Handles btnavailablemaid.Click
        Dim instr As String
        instr = "insert into Availability(Maid_id,Start_time,End_time,Is_available) values ( ' " + TextBox3.Text + " ' ," + TextBox4.Text + " , '" + TextBox7.Text + "' , '" + TextBox5.Text + "')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, co)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox5.Text = ""
    End Sub
End Class