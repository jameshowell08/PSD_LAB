<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupType.aspx.cs" Inherits="PSD_LAB.Views.Admin.UpdateMakeupType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Makeup Type</h1>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="name_tb" runat="server" placeholder="name"></asp:TextBox>
    </div>

    <asp:Label ID="errorlbl" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="updatemakeupTypebtn" runat="server" Text="Insert Makeup Brand" onclick="updatemakeupTypebtn_Click" />

</asp:Content>
