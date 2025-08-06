<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASP_WebAppln_1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <asp:Button ID ="btn1" runat="server" Text="Hello Click Me  !!" OnClick="btn1_Click" />
</asp:Content>
