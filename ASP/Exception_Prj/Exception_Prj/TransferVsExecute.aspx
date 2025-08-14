<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransferVsExecute.aspx.cs" Inherits="Exception_Prj.TransferVsExecute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <table>
                <tr>
                    <td colspan="2">
                        <h1>This is Transfer Vs Execute Form</h1>
                    </td>
                </tr>
                <tr>
                    <td><b>Name : </b></td>
                    <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>EMail :</b></td>
                    <td><asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnExecute" runat="server" Text="Server.ExecuteWebForm2" OnClick="btnExecute_Click" />
                    </td>
                </tr>
                <tr>
                <td colspan="2">
                        <asp:Button ID="btnExecuteExternal" runat="server" Text="Server.ExecuteExternal" OnClick="btnExecuteExternal_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblstatus" runat="server" ForeColor="DarkGreen"
                             Font-Bold="true"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
