<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsViewForm.aspx.cs" Inherits="DataControls_Prj.DetailsViewForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="empno" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="empno" HeaderText="empno" ReadOnly="True" SortExpression="empno" />
                    <asp:BoundField DataField="job" HeaderText="job" SortExpression="job" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="empno" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="empno" HeaderText="empno" ReadOnly="True" SortExpression="empno" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="job" HeaderText="job" SortExpression="job" />
                    <asp:BoundField DataField="mgr_id" HeaderText="mgr_id" SortExpression="mgr_id" />
                    <asp:BoundField DataField="hire_date" HeaderText="hire_date" SortExpression="hire_date" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                    <asp:BoundField DataField="comm" HeaderText="comm" SortExpression="comm" />
                    <asp:BoundField DataField="deptno" HeaderText="deptno" SortExpression="deptno" />
                </Fields>
            </asp:DetailsView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfiniteDBConnectionString2 %>" SelectCommand="SELECT [ename], [empno], [job] FROM [emp]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:InfiniteDBConnectionString2 %>" SelectCommand="SELECT * FROM [emp] WHERE ([empno] = @empno)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="empno" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
