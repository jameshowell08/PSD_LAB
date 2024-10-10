<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupBrand.aspx.cs" Inherits="PSD_LAB.Views.Admin.UpdateMakeupBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Update Makeup Brand</h1>
 <div>
     <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
     <asp:TextBox ID="name_tb" runat="server" placeholder="name"></asp:TextBox>
 </div>
 <div>
     <asp:Label ID="Label3" runat="server" Text="Rating"></asp:Label>
     <asp:TextBox ID="rating_tb" runat="server" placeholder="rating"></asp:TextBox>
 </div>
 <asp:Label ID="errorlbl" runat="server" Text="Label"></asp:Label>
 <asp:Button ID="updatemakeupbrandbtn" runat="server" Text="Update Makeup Brand" onclick="updatemakeupbrandbtn_Click" />

</asp:Content>
