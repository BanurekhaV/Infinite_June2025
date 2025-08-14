<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorSource2.aspx.cs" Inherits="Exception_Prj.ErrorSource2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Btn1" runat="server" Text="Click" OnClick="Btn1_Click" />
            <br />
             <asp:Label ID="Lblerrormsg" runat="server" Text="Label"></asp:Label>
        </div>
       
    </form>
</body>
</html>
