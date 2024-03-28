<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="agencyservices.aspx.vb" Inherits="home_nurse_connect1.agencyservices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 298px;
        }
        .auto-style2 {
            width: 298px;
            height: 33px;
        }
        .auto-style3 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Agency service Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtagencyservicename" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnagencyservices" runat="server" Text="Submit" Width="184px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
