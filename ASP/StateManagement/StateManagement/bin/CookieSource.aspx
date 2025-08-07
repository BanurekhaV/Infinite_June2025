<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSource.aspx.cs" Inherits="StateManagement.CookieSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
            <asp:Button ID="btnStore" runat="server" text="Store Data"  />
            &nbsp; &nbsp;<asp:Button ID="btnLoad" runat="server" Text=" Load Data"  />
              &nbsp;&nbsp; <asp:Button ID="Btnredirect" runat="server" Text="Redirect" OnClick="Btnredirect_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblmessage" runat="server" Text=" "></asp:Label>
             <br />
            <br />
        </p>
        </div>
    </form>
</body>
</html>
