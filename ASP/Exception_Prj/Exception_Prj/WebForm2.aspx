<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Exception_Prj.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Algerian">
            <table>
                <tr>
                    <td colspan="2">
                        <h1>Web Form 2</h1>
                    </td>
                </tr>
                <tr>
                    <td><b>Name :</b></td>
                    <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td><b>Email :</b></td>
                    <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2"</td>
                    <td><asp:Button ID="btnPostBack" runat="server" Text="Just PostBack" OnClick="btnPostBack_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
