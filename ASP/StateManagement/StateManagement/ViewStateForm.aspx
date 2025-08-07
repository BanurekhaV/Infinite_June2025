<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateForm.aspx.cs" Inherits="StateManagement.ViewStateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblusername" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server" Width="214px"></asp:TextBox>
            <br />
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnStore" runat="server" text="Store Data"  OnClick="btnStore_Click"/>
            &nbsp; &nbsp;<asp:Button ID="btnLoad" runat="server" Text=" Load Data" OnClick="btnLoad_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblmessage" runat="server" Text=" "></asp:Label>
             <br />
            <br />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
