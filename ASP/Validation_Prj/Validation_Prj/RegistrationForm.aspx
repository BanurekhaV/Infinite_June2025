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
            <br />&nbsp;&nbsp;&nbsp; <br />
            Name  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="NameValidator" runat="server" 
                ErrorMessage="Name cannot be Blank" ControlToValidate="txtname" 
                ForeColor="Red"  ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Age   :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="AgeValidator" runat="server" 
                ErrorMessage="Age is must" ControlToValidate="txtage" 
                ForeColor="Red" Display="Dynamic" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            &nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ErrorMessage="Age must be between 21 and 50" 
                ControlToValidate="txtage" Display="Dynamic" 
                ForeColor="Red" MaximumValue="50" MinimumValue="21" 
                Type="Integer" ValidationGroup="Regn">*</asp:RangeValidator>
            <br />
            <br />
            Password&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Provide Password" ControlToValidate="txtpass"
                ForeColor="Red" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcpass" runat="server"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ErrorMessage="Enter Confirm password " ControlToValidate="txtcpass" 
                Display="Dynamic" ForeColor="Red" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ErrorMessage="Password and Confirm Password does not Match" 
                ControlToCompare="txtpass" ControlToValidate="txtcpass" Display="Dynamic" 
                ForeColor="Red" ValidationGroup="Regn">*</asp:CompareValidator>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Please enter Email" ControlToValidate="txtemail" Display="Dynamic" 
                ForeColor="Red" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Enter Email in Correct Format" ControlToValidate="txtemail"
                Display="Dynamic" ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Regn">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" ValidationGroup="Regn" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"  ValidationGroup="Regn"/>
        </div>

        <br /><br />
        <hr />
        <div>
            <h1 style="color:crimson;font-size:20px;text-align:center;">Login Form</h1>
            <br />
            Login Name :  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtlogin" runat="server">     </asp:TextBox>  
            &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="loginnamevalidator" runat="server"
                 ControlToValidate="txtlogin" ErrorMessage="Enter Login Name"
                 ForeColor="red" ValidationGroup="Login">*</asp:RequiredFieldValidator>                
            <br />
            Password   :  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="txtlpass" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtlpass" 
                ErrorMessage="Enter Password please" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" ValidationGroup="Login" />
            
        </div>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="Login" />
    </form>
</body>
</html>
