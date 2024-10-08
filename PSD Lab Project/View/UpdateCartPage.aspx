<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateCartPage.aspx.cs" Inherits="PSD_Lab_Project.View.UpdateCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Update Cart Page</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="LblPrice" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="LblQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnUpdate" runat="server" Text="Update Cart" OnClick="BtnUpdate_Click"/>
        <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
