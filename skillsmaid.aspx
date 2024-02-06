<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="skillsmaid.aspx.vb" Inherits="home_nurse_connect1.skillsmaid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 324px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Maidskills_id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Maid_id</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 2px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Maidskills_name</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" style="margin-bottom: 2px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
