<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="InsertMakeupType.aspx.cs" Inherits="PSD_LAB.Views.Admin.InsertMakeupType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Makeup Type</h1>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="name_tb" runat="server" placeholder="name"></asp:TextBox>
    </div>

    <asp:Label ID="errorlbl" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="insertmakeupTypebtn" runat="server" Text="Insert Makeup Brand" OnClick="insertmakeupTypebtn_Click" />

</asp:Content>
