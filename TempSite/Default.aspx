<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TempSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <p>
        <asp:Label ID="Label1" runat="server" Text="C2F"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="53px"></asp:TextBox>
        &nbsp;=
        <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" />
    </p>
    <p>
        F2C
        <asp:TextBox ID="TextBox2" runat="server" Width="55px"></asp:TextBox>
        &nbsp;=
        <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Convert" />
    </p>

    
</asp:Content>
