<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="PSD_LAB.Views.Customer.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <br />
    <asp:GridView ID="CartGv" runat="server" AutoGenerateColumns="false">
        <Columns>

            <asp:BoundField DataField="MakeupID" HeaderText="Makeup" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="checkoutbtn" runat="server" Text="Checkout" OnClick="checkoutbtn_Click" />
    <asp:Button ID="clearcartbtn" runat="server" Text="Clear Cart" OnClick="clearcartbtn_Click" />
    <asp:Label ID="errorlbl" runat="server" Text="Label"></asp:Label>
</asp:Content>
