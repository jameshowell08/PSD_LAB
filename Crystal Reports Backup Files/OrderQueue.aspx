<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="PSD_LAB.Views.Admin.OrderQueue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Queue</h1>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false" OnRowCommand="TransactionGV_RowCommand">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
            <asp:ButtonField CommandName="Handle" Text="Handle" ButtonType="Button" ShowHeader="True" HeaderText="Details"></asp:ButtonField>
        </Columns>
    </asp:GridView>
</asp:Content>
