<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Validation_Prj.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .selfstyle{
            height:400px;
            margin-left:40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="selfstyle">
            <h1 style="color:darkblue;font-size:20px;text-align:center">Registration Form</h1>
            <br /><br />
            Name  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="NameValidator" runat="server" ErrorMessage="Name cannot be Blank" ControlToValidate="txtname" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Age   :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="AgeValidator" runat="server" ErrorMessage="Age is must" ControlToValidate="txtage" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
