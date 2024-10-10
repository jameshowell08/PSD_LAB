<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="PSD_LAB.Views.Customer.TransactionDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Details</h1>
    <asp:GridView ID="TransactionDetailsGV" runat="server" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
