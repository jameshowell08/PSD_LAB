<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSD_LAB.Views.Admin.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label ID="username_lbl" runat="server" Text="label"></asp:Label>
        <asp:Label ID="role_lbl" runat="server" Text="label"></asp:Label>
    </div>
    <asp:GridView ID="UserGV" runat="server" OnSelectedIndexChanged="UserGV_SelectedIndexChanged" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username"></asp:BoundField>
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="Email"></asp:BoundField>
            <asp:BoundField DataField="UserDOB" HeaderText="DOB" SortExpression="Gender"></asp:BoundField>
            <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="DOB"></asp:BoundField>
            <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
