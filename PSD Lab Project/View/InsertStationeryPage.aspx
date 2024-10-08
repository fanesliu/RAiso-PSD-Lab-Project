<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertStationeryPage.aspx.cs" Inherits="PSD_Lab_Project.View.InsertStationeryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Insert Stationery Page</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblPrice" runat="server" Text="Price : "></asp:Label>
        <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click" />
        <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
