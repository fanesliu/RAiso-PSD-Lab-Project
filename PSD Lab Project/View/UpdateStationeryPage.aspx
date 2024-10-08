<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateStationeryPage.aspx.cs" Inherits="PSD_Lab_Project.View.UpdateStationeryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Update Stationery Page</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblPrice" runat="server" Text="Price : "></asp:Label>
        <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnUpdate" runat="server" Text="Update Stationery" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
