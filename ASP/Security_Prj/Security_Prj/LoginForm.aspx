<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Security_Prj.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login Name  :  &nbsp; &nbsp; &nbsp; 
            <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            <br /><br />
            Password  :  &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnLogin" runat="server" Text=" Login" OnClick="btnLogin_Click" />
            <br /><br />
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
