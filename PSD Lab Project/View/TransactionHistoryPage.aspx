<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="PSD_Lab_Project.View.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Transaction History Page</h1>
    <div>
        <asp:Label ID="LblUsername" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:GridView ID="GridViewStationery" runat="server" AutoGenerateColumns="false" OnRowUpdating="GridViewStationery_RowUpdating">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="BtnUpdate" runat="server" Text="Detail" UseSubmitBehavior="false" CommandName="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
