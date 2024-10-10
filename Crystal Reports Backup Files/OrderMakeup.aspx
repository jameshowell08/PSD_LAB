<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="PSD_LAB.Views.Customer.OrderMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Makeup</h1>
    <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName"></asp:BoundField>
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice"></asp:BoundField>
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight"></asp:BoundField>
            <asp:BoundField DataField="MakeupType.MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypes.MakeupTypeID"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrand.MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrands.MakeupBrandID"></asp:BoundField>
            <asp:TemplateField HeaderText="Add to cart">
                <ItemTemplate>
                    <asp:TextBox ID="quantity_tb" runat="server" placeholder="Quantity" Width="40px"></asp:TextBox>
                    <asp:Button ID="addtocartbtn" runat="server" Text="Add to cart" CommandArgument='<%# Eval("MakeupID") %>' OnClick="addtocartbtn_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="errorlbl" runat="server" Text=""></asp:Label>
</asp:Content>
