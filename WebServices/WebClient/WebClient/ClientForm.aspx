<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="WebClient.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter User Name :  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            <br /><br />
            Enter a float Number : &nbsp;&nbsp;
            <asp:TextBox ID="txtfnum" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnHelloWorld" runat="server" Text="Hello World" OnClick="btnHelloWorld_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSayHello" runat="server" Text="Say Hello " OnClick="btnSayHello_Click" />
           &nbsp;&nbsp;&nbsp;
            <asp:button id = "btnSqaure" runat="server" Text="Get Sqaure" OnClick="btnSqaure_Click" />
            <br />
            <br />
            <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
