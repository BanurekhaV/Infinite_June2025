<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="StateManagement.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text=""></asp:Label>
            <br />
             <asp:Label ID="lblcity" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnGetSession" runat="server" Text="Get Session" OnClick="btnGetSession_Click" /><br />

            <asp:Button ID="btnthird" runat="server" Text="Redirect" OnClick="btnthird_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
