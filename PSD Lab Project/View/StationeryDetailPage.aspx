<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="StationeryDetailPage.aspx.cs" Inherits="PSD_Lab_Project.View.StationeryDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Stationery Detail Page</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:Label ID="LblStationName" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="LblPrice" runat="server" Text="Price : "></asp:Label>
        <asp:Label ID="LblStationPrice" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="LblQuantity" runat="server" Text="Quantity : "></asp:Label>
        <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnCart" runat="server" Text="Add to Cart" OnClick="BtnCart_Click" />
        <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
