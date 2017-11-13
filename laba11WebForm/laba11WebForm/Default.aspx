<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="laba11WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
      <br />
    <asp:Label ID="X" runat="server" Text="X"></asp:Label> <asp:TextBox ID="TextBoxX" runat="server"></asp:TextBox>
    <br />
     <br />
    <asp:Label ID="Y" runat="server" Text="Y"></asp:Label> <asp:TextBox ID="TextBoxY" runat="server"></asp:TextBox>
    <br />
     <br />
    <div class="row">
    <asp:Button ID="Plus" runat="server" Text="+" Width="27px" OnClick="Plus_Click" />
    <asp:Button ID="Minus" runat="server" Text="-" OnClick="Minus_Click" />
    <asp:Button ID="Multiply" runat="server" Text="*" OnClick="Multiply_Click" />
       
        <asp:Label ID="Result" runat="server" Text="Result"></asp:Label>
        <asp:TextBox ID="TextBoxResult" runat="server"></asp:TextBox>

        </div>
    <br />
    <br />
    <asp:TextBox ID="Set" runat="server"></asp:TextBox>
    <asp:Button ID="SetI" runat="server" Text="SetI" OnClick="SetI_Click" Width="58px" />
    <br />
    <br />

    <asp:Button ID="GetI" runat="server" Text="GetI" OnClick="GetI_Click" Width="55px" />

    <asp:TextBox ID="Get" runat="server" Width="179px"></asp:TextBox>
    <br />
    <br />

    <asp:TextBox ID="Add" runat="server"></asp:TextBox>
    <asp:Button ID="Addd" runat="server" Text="AddI" OnClick="Addd_Click" Width="46px" />
    <asp:TextBox ID="AddI" runat="server"></asp:TextBox>
    <br />
</asp:Content>
