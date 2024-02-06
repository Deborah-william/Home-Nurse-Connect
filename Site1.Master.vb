Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        Dim s As String
        s = Menu1.SelectedItem.Text
        If s = "Login" Then
            Response.Redirect("loginadmin.aspx")
        ElseIf s = "Delete Account" Then
            Response.Redirect("deleteaccount.aspx")
        ElseIf s = "Login Customer" Then
            Response.Redirect("logincustomer.aspx")
        ElseIf s = "Book Appointments" Then
            Response.Redirect("bookappointment.aspx")
        ElseIf s = "Payments" Then
            Response.Redirect("payments.aspx")
        ElseIf s = "Login Maid" Then
            Response.Redirect("loginmaid.aspx")
        ElseIf s = "Availabilty" Then
            Response.Redirect("availablemaid.aspx")
        ElseIf s = "Skills" Then
            Response.Redirect("skillsmaid.aspx")
        ElseIf s = "Delete Account" Then
            Response.Redirect("deleteaccountmaid.aspx")
        ElseIf s = "Login Agency" Then
            Response.Redirect("loginagency.aspx")
        ElseIf s = "Services" Then
            Response.Redirect("agencyservices.aspx")
        ElseIf s = "Status" Then
            Response.Redirect("agencystatus.aspx")
        ElseIf s = "Delete Agency Account" Then
            Response.Redirect("deleteagencyaccount.aspx")
        ElseIf s = "Add Categories" Then
            Response.Redirect("servicecategories.aspx")
        ElseIf s = "Booked Services" Then
            Response.Redirect("servicesbooked.aspx")
        ElseIf s = "Available Services" Then
            Response.Redirect("availableservices.aspx")
        ElseIf s = "Remove Services" Then
            Response.Redirect("removeservices.aspx")
        ElseIf s = "Remove Services" Then
            Response.Redirect("removeservices.aspx")
        ElseIf s = "Remove Services" Then
            Response.Redirect("removeservices.aspx")
        Else
            s = "Cancel Appointments"
            Response.Redirect("cancelappointmentscustomer.aspx")
        End If

    End Sub
End Class