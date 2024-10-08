<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="PSD_Lab_Project.View.UpdateProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1>Update Profile Page</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblDOB" runat="server" Text="DOB : "></asp:Label>
        <asp:TextBox ID="TxtDOB" runat="server" type="date"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblGender" runat="server" Text="Gender : "></asp:Label>
        <asp:DropDownList ID="DropDownListGender" runat="server">
            <asp:ListItem Text="Please Select" />
            <asp:ListItem Text="Male" />
            <asp:ListItem Text="Female" />
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="LblAddress" runat="server" Text="Address : "></asp:Label>
        <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblPassword" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblPhone" runat="server" Text="Phone : "></asp:Label>
        <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="BtnRegister" runat="server" Text="Update Profile" OnClick="BtnRegister_Click" />
    </div>
</asp:Content>
