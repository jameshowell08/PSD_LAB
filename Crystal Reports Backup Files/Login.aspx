<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSD_LAB.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="username_tb" runat="server" placeholder="username"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="password_tb" runat="server" type="password" placeholder="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Remember Me"></asp:Label>
                <asp:CheckBox ID="remember_me" runat="server" />
            </div>
            <asp:Button ID="loginbtn" runat="server" Text="Login" OnClick="loginbtn_Click"/>
            <div>
                <asp:Label ID="Label8" runat="server" Text="Label">Don't have an account?</asp:Label>
                <asp:LinkButton ID="registerlink" runat="server" OnClick="registerlink_Click">Register</asp:LinkButton>
            </div>

            <asp:Label ID="erroelbl" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="rolename" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
