<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="PSD_Lab_Project.View.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Cart Page</h1>
    <div>
        <asp:GridView ID="GridViewCart" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridViewCart_RowDeleting" OnRowEditing="GridViewCart_RowEditing">
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="StationeryName" SortExpression="StationeryName" ></asp:BoundField>
                <asp:BoundField DataField="StationeryPrice" HeaderText="StationeryPrice" SortExpression="StationeryPrice"></asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Qunatity"></asp:BoundField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="BtnUpdate" runat="server" Text="Update" CommandName="Edit" />
                        <asp:Button ID="BtnDelete" runat="server" Text="Delete" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="BtnCheckOut" runat="server" Text="Check Out" OnClick="BtnCheckOut_Click"/>
        <asp:Label ID="Lbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
