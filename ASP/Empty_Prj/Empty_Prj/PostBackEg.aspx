<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackEg.aspx.cs" Inherits="Empty_Prj.PostBackEg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtcount" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btncount" runat="server" Text="Click For Count" OnClick="btncount_Click" />
        </div>
        
    </form>
</body>
</html>
