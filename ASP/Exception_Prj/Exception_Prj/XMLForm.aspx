<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLForm.aspx.cs" Inherits="Exception_Prj.XMLForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Grid1" runat="server"></asp:GridView>
            <br /><br />
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
