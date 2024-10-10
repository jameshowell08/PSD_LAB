<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSD_LAB.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RegisterPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">Register</asp:Label>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="username_tb" runat="server" placeholder="username"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="email_tb" runat="server" placeholder="email"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                <asp:RadioButtonList ID="GenderRadioList" runat="server">
                    <asp:ListItem ID="MalesList">Male</asp:ListItem>
                    <asp:ListItem ID="FemaleList">Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Date Of Birth"></asp:Label>
                <asp:Calendar ID="dob_input" runat="server"></asp:Calendar>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="password_tb" runat="server" type="password" placeholder="Password" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Confirm Password"></asp:Label>
               <asp:TextBox ID="confirmpassword_tb" runat="server" type="password" placeholder="Confirm Password" ></asp:TextBox>
            </div>
            <asp:Button ID="registerbtn" runat="server" Text="Register" OnClick="registerbtn_Click" />
            <br /><asp:Label ID="output" runat="server" Text=""></asp:Label>
            <div>
                <asp:Label ID="Label8" runat="server" Text="Label">Already have an account?</asp:Label>
                <asp:LinkButton ID="loginlink" runat="server" OnClick="loginlink_Click" >Login</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
