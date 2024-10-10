<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="PSD_LAB.Views.Admin.ManageMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="insertmkupbtn" runat="server" Text="Insert Make Up" OnClick= "insertmkupbtn_Click"/>
        <asp:Button ID="insertmkupbrndbtn" runat="server" Text="Insert Make Up Brand" OnClick="insertmkupbrndbtn_Click" />
        <asp:Button ID="insertmkuptypebtn" runat="server" Text="Insert Make Up Type" OnClick="insertmkuptypebtn_Click" />
    </div>
    <h1>Makeup</h1>
    <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="false" OnRowEditing="MakeupGV_RowEditing" Onrowdeleting="MakeupGV_RowDeleting" >
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName"></asp:BoundField>
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice"></asp:BoundField>
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight"></asp:BoundField>
            <asp:BoundField DataField="MakeupType.MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypes.MakeupTypeID"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrand.MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrands.MakeupBrandID"></asp:BoundField>
            <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button"></asp:CommandField>
        </Columns>
    </asp:GridView><br />
    <h1>Makeup Brands</h1>
    <asp:GridView ID="MakeupBrandGV" runat="server" AutoGenerateColumns="false" OnRowEditing="MakeupBrandGV_RowEditing" OnRowDeleting="MakeupBrandGV_RowDeleting" >
        <Columns>
            <asp:BoundField DataField="MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrandID"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrandRating"></asp:BoundField>
            <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button"></asp:CommandField>
        </Columns>
    </asp:GridView><br />
    <h1>Makeup Types
    </h1>
    <asp:GridView ID="MakeupTypeGV" runat="server" AutoGenerateColumns="false" OnRowDeleting="MakeupTypeGV_RowDeleting" OnRowEditing="MakeupTypeGV_RowEditing" >
        <Columns>
            <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID"></asp:BoundField>
            <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName"></asp:BoundField>
            <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button"></asp:CommandField>
        </Columns>
    </asp:GridView><br />
</asp:Content>
