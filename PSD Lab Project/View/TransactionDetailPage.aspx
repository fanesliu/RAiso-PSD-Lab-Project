<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="PSD_Lab_Project.View.TransactionDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Transaction Detail Page</h1>
    <div>
        <asp:GridView ID="GridViewCart" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="StationeryName" SortExpression="StationeryName"></asp:BoundField>
                <asp:BoundField DataField="StationeryPrice" HeaderText="StationeryPrice" SortExpression="StationeryPrice"></asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
