<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="PSD_LAB.Views.Customer.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction History</h1>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false" OnRowCommand="TransactionGV_RowCommand" >
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
            <asp:ButtonField CommandName="Details" Text="Details" ButtonType="Button" ShowHeader="True" HeaderText="Details"></asp:ButtonField>
        </Columns>
    </asp:GridView>
</asp:Content>
