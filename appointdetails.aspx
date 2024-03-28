<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="appointdetails.aspx.vb" Inherits="home_nurse_connect1.appointmentcustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 244px;
        }
        .auto-style2 {
            width: 244px;
            height: 33px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            width: 244px;
            height: 39px;
        }
        .auto-style5 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">Customer Name </td>
                <td>
                    <asp:TextBox ID="txtcustomerid" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Agency Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="drpdwnagencyname" runat="server" AutoPostBack="True" Width="185px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">Maid Name</td>
                <td>
                    <asp:DropDownList ID="drpdwnmaidname" runat="server" AutoPostBack="True" Width="184px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Service Name</td>
                <td>
                    <asp:DropDownList ID="drpdwnservicename" runat="server" AutoPostBack="True" Width="187px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Start_time</td>
                <td>
                    <asp:TextBox ID="txtstarttime" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">End_time</td>
                <td>
                    <asp:TextBox ID="txtendtime" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Appoint_date</td>
                <td>
                    <asp:TextBox ID="txtappointdate" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnappointdetails" runat="server" Text="Save Appointment" Width="356px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style5">
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
