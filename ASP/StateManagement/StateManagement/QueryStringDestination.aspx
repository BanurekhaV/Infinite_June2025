<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringDestination.aspx.cs" Inherits="StateManagement.QueryStringDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblpassword" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnGet" runat="server" Text="Get Data" OnClick="btnGet_Click" />
        </div>
    </form>
</body>
</html>
