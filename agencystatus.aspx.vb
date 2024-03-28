Imports System.Data.SqlClient
Imports System.Data

Public Class agencystatus
    Inherits System.Web.UI.Page
    Dim co As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        co.ConnectionString = "Data Source=DEBORAH\SQLEXPRESS;Initial Catalog=maidservices;User ID=sa;Password=123"
        co.Open()
    End Sub

    Protected Sub btnagencystatus_Click(sender As Object, e As EventArgs) Handles btnagencystatus.Click
        Dim instr As String
        instr = "insert into Status(Status_type,Appoint_id) values ('" + txtstatustype.Text + "' , ' " + txtappointid.Text + " ')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, co)
        cmdemp.ExecuteNonQuery()
        Response.Write(" <script> alert('Data saved'); </script>")
        txtstatustype.Text = ""
        txtappointid.Text = ""
    End Sub
End Class