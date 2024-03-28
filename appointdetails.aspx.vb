Imports System.Data.SqlClient
Imports System.Data

Public Class appointmentcustomer
    Inherits System.Web.UI.Page
    Dim co As New SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        co.ConnectionString = "Data source=DEBORAH\SQLEXPRESS;Initial Catalog = maidservices;User ID= sa;password= 123"
        co.Open()
        'If Not Me.IsPostBack Then

        'End If
        If Not Me.IsPostBack Then
            maid()
        End If
    End Sub

    Protected Sub btnappointdetails_Click(sender As Object, e As EventArgs) Handles btnappointdetails.Click
        Dim instr As String
        instr = "INSERT INTO Appointdetails(Customer_name, Start_time, End_time, Appoint_date) VALUES ('" & txtcustomerid.Text & "', '" & txtstarttime.Text & "', '" & txtendtime.Text & "', '" & txtappointdate.Text & "')"
        Dim cmdemp As SqlCommand = New SqlCommand(instr, co)
        cmdemp.ExecuteNonQuery()

        Response.Write(" <script> alert('Data saved'); </script>")

        txtcustomerid.Text = ""
        'drpdwnagencyname = ""
        txtstarttime.Text = ""
        txtendtime.Text = ""
        txtappointdate.Text = ""

    End Sub

    'Public Sub drpdwnagencyname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnagencyname.SelectedIndexChanged
    Public Sub agency()
        Dim dt As DataTable = New DataTable
        Dim strsts As String
        strsts = "select Agency_id,Agency_name from Agency"
        Dim cmdshowdt As SqlCommand = New SqlCommand(strsts, co)
        Dim adp As SqlDataAdapter = New SqlDataAdapter(cmdshowdt)
        adp.Fill(dt)
        drpdwnagencyname.Items.Clear()
        drpdwnagencyname.Items.Add("--Select--")
        drpdwnagencyname.DataValueField = "Agency_id"
        drpdwnagencyname.DataTextField = "Agency_name"
        drpdwnagencyname.DataSource = dt
        drpdwnagencyname.DataMember = "Agency"
        drpdwnagencyname.DataBind()
    End Sub
    Public Sub maid()
        Dim dt As DataTable = New DataTable
        Dim strsts As String
        strsts = "select Maid_id,Maid_name from Maid where Agency_id=" & drpdwnagencyname.SelectedValue & ""
        Dim cmdshowdt As SqlCommand = New SqlCommand(strsts, co)
        Dim adp As SqlDataAdapter = New SqlDataAdapter(cmdshowdt)
        adp.Fill(dt)
        drpdwnmaidname.Items.Clear()
        drpdwnmaidname.Items.Add("--Select--")
        drpdwnmaidname.DataValueField = "Maid_id"
        drpdwnmaidname.DataTextField = "Maid_name"
        drpdwnmaidname.DataSource = dt
        drpdwnmaidname.DataMember = "Maid"
        drpdwnmaidname.DataBind()
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnagencyname.SelectedIndexChanged
        'Response.Write("DropDownList1_SelectedIndexChanged event fired.")
        DropDownList1_SelectedIndexChanged()
    End Sub

    Private Sub DropDownList1_SelectedIndexChanged()
        Throw New NotImplementedException
    End Sub
















End Class