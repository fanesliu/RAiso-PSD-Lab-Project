<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PSD_Lab_Project.View.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div>
        <h1>Login</h1>
    </div>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblPassword" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="CheckBoxCookies" runat="server" Text="Remember Me" />
    </div>
    <div>
        <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
        <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
