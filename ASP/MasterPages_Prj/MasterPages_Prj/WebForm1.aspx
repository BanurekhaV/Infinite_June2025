<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPages_Prj.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PrimaryContent" runat="server">
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button id="btnDo" runat="server" Text="Click for Data" OnClick="btnDo_Click" />

</form>
</asp:Content>
