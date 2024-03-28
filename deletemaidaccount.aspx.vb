Imports System.Data.SqlClient
Imports System.Data

Public Class deleteaccountmaid
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        con.Open()

    End Sub

    Protected Sub btndeletemaidaccount_Click(sender As Object, e As EventArgs) Handles btndeletemaidaccount.Click
        Dim instr As String
        instr = "delete from Maid where Maid_id= @Maid_id"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, con)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        
    End Sub
End Class