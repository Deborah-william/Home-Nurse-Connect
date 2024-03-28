<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="servicesbooked.aspx.vb" Inherits="home_nurse_connect1.servicesbooked" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 293px;
        }
        .auto-style2 {
            width: 162px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Booked_id</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Customer_id</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox5" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Agency_id</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Maid_id</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox7" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Service_id</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox8" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Start_time</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox11" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                    <asp:TextBox ID="TextBox9" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">End_time</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox12" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Appointment_date</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox13" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Total_cost</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox10" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
