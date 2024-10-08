<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PSD_Lab_Project.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
        <h1>Home Page</h1>
    <div>
        <asp:Label ID="LblWellcome" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:GridView ID="GridViewStationery" runat="server" AutoGenerateColumns="false" OnRowDataBound="GridViewStationery_RowDataBound" OnRowDeleting="GridViewStationery_RowDeleting" OnRowEditing="GridViewStationery_RowEditing" OnRowUpdating="GridViewStationery_RowUpdating">
            <Columns>
                <asp:BoundField DataField="StationeryID" HeaderText="StationeryID" SortExpression="StationeryID"></asp:BoundField>
                <asp:BoundField DataField="StationeryName" HeaderText="StationeryName" SortExpression="StationeryName"></asp:BoundField>
                <asp:BoundField DataField="StationeryPrice" HeaderText="StationeryPrice" SortExpression="StationeryPrice"></asp:BoundField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="BtnUpdate" runat="server" Text="Update" UseSubmitBehavior="false" CommandName="Edit" />
                        <asp:Button ID="BtnDelete" runat="server" Text="Delete" UseSubmitBehavior="false" CommandName="Delete" />
                        <asp:Button ID="BtnDetail" runat="server" Text="Detail" UseSubmitBehavior="false" CommandName="Update"/>
                    </ItemTemplate>   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <asp:Button ID="BtnInsert" runat="server" Text="Insert Stationery" OnClick="BtnInsert_Click"/>
    </div>
</asp:Content>
