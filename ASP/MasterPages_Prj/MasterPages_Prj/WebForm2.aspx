<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MasterPages_Prj.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PrimaryContent" runat="server">

    <form id="form2" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnGo" runat="server" Text="Go" OnClick="BtnGo_Click" />
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </form>
</asp:Content>
