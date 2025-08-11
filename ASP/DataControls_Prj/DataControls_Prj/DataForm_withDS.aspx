<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm_withDS.aspx.cs" Inherits="DataControls_Prj.DataForm_withDS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="empno" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="empno" HeaderText="empno" ReadOnly="True" SortExpression="empno" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="job" HeaderText="job" SortExpression="job" />
                    <asp:BoundField DataField="mgr_id" HeaderText="mgr_id" SortExpression="mgr_id" />
                    <asp:BoundField DataField="hire_date" HeaderText="hire_date" SortExpression="hire_date" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                    <asp:BoundField DataField="comm" HeaderText="comm" SortExpression="comm" />
                    <asp:BoundField DataField="deptno" HeaderText="deptno" SortExpression="deptno" />
                </Columns>
                
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfiniteDBConnectionString %>" SelectCommand="SELECT * FROM [emp]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
