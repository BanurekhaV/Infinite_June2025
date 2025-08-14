<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectVsTransfer.aspx.cs" Inherits="Caching_Prj.RedirectVsTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name  : &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            Email : &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnGetData" runat="server" Text="Get Page" OnClick="BtnGetData_Click" />
        </div>
    </form>
</body>
</html>
