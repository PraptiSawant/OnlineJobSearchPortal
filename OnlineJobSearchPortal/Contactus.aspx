<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="OnlineJobSearchPortal.Contactus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <formview id="contact">
             <asp:Label ID="Label2" runat="server" Text="Contact Us"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Name"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Email"></asp:TextBox>
        <br />
        <textarea id="TextArea1" cols="20" name="S1" rows="2" placeholder="Message"></textarea><br />
        <asp:Button ID="Button1" runat="server" Text="SEND" OnClick="Button1_Click" />
        </formview>
    </div>
</asp:Content>
