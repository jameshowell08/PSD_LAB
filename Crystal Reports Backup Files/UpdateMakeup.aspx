<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="PSD_LAB.Views.Admin.UpdateMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Makeup</h1>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="name_tb" runat="server" placeholder="name"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="price_tb" runat="server" placeholder="price"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Weight"></asp:Label>
        <asp:TextBox ID="weight_tb" runat="server" placeholder="weight"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Type ID"></asp:Label>
        <asp:TextBox ID="typeid_tb" runat="server" placeholder="TypeID"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Brand ID"></asp:Label>
        <asp:TextBox ID="brandid_tb" runat="server" placeholder="BrandID"></asp:TextBox>
    </div>
    <asp:Label ID="errorlbl" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="updatemakeupbtn" runat="server" Text="Insert Makeup" OnClick="updatemakeupbtn_Click" />

</asp:Content>
