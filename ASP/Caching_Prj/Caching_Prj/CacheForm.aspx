<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="Caching_Prj.CacheForm" %>
<%--<%@ OutputCache Duration="30" VaryByParam="None" Location="Client" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Select a product  : &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDL" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelectedIndexChanged">
              <asp:ListItem Text="All" Value="All"></asp:ListItem>
            <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
            <asp:ListItem Text="DeskTops" Value="Desktops"></asp:ListItem>
            <asp:ListItem Text="Tablets" Value="Tablets"></asp:ListItem>
            <asp:ListItem Text="Mobiles" Value="Mobiles"></asp:ListItem>
                                              </asp:DropDownList>
        <br /><br />

        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <br />
        Server Time : <br />
        <asp:Label ID="lblmsg" runat="server" Text="">  </asp:Label>
            <br /><br />
        Client Time : 
        <br />
        <br />
       
            <script>
                document.write(Date());
            </script>      
    </form>
</body>
</html>
