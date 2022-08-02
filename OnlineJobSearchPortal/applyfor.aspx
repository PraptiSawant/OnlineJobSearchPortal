<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="applyfor.aspx.cs" Inherits="OnlineJobSearchPortal.applyfor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Black" Font-Size="Large"></asp:Label><br />
      <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="Medium"></asp:Label><br />
    <div class="container">
  <div class="card">
    <h3>Upload Your Resume</h3>
    <div class="drop_box">
      <p>Files Supported: PDF, TEXT, DOC , DOCX</p>
       <asp:FileUpload ID="FileUpload1" runat="server" BackColor="#3366FF" BorderStyle="None" ForeColor="White" />
        <br /><br />
    </div>
      <asp:Button ID="Button1" runat="server" Text="APPLY" OnClick="Button1_Click"  />
  </div>
</div>
</asp:Content>
