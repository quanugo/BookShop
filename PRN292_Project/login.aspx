<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PRN292_Project.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <div id="loginbox">
        <img id="avatar" src="image/avt.png" />
        <h1>Login Here</h1>
        <form id="form1" runat="server">
            <p>Username</p>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            &nbsp;<p>Password</p>
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="Button1_Click" />
            &nbsp;
            <a href="register.aspx">Don't have an account?</a>
        </form>

    </div>
</body>
</html>
