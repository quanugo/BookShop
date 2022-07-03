<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="PRN292_Project.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/register.css" rel="stylesheet" />
</head>
<body>
    <div id="loginbox">
        <img id="avatar" src="image/avt.png" />
        <h1>Create New Acount</h1>
        <form id="form1" runat="server">
            <p>Email</p>
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            &nbsp;<p>Date of Birth</p>
            <asp:TextBox ID="tbDOB" runat="server"></asp:TextBox>
            &nbsp;<p>Phone</p>
            <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
            &nbsp;<p>Address</p>
            <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
            &nbsp;<p>Password</p>
            <asp:TextBox ID="tbPass" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="SignUp" runat="server" Text="Sign up" OnClick="SignUp_Click"/>
            <a href="login.aspx">Already have an account?</a>
        </form>

    </div>
</body>
</html>

