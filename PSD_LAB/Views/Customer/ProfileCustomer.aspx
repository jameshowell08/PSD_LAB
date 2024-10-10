<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="ProfileCustomer.aspx.cs" Inherits="PSD_LAB.Views.Customer.ProfileCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Profile Customer</h3>
    <br />
    <div>
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
        <asp:Button ID="updateprofilebtn" runat="server" Text="Update Profile" OnClick="updateprofilebtn_Click" />
        <asp:Label ID="errorprofilelbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Old Password"></asp:Label>
            <asp:TextBox ID="oldpassword_tb" runat="server" type="password" placeholder="Old Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="New Password"></asp:Label>
            <asp:TextBox ID="newpassword_tb" runat="server" type="password" placeholder="New Password"></asp:TextBox>
        </div>
        <asp:Button ID="updatepasswordbtn" runat="server" Text="Update Password" OnClick="updatepasswordbtn_Click" />
        <asp:Label ID="errorpasslbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
