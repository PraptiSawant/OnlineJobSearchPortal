<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="OnlineJobSearchPortal.view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectiondb %>" SelectCommand="SELECT * FROM [companydb] WHERE (([job] LIKE '%' + @job + '%') AND ([loc] LIKE '%' + @loc + '%'))">
                <SelectParameters>
                    <asp:SessionParameter Name="job" SessionField="name" Type="String" />
                    <asp:SessionParameter Name="loc" SessionField="loc" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView class="styled-table" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" DataKeyNames="cid">
                <Columns>
                    <asp:BoundField DataField="comname" HeaderText="COMPANY" SortExpression="comname" />
                    <asp:BoundField DataField="loc" HeaderText="LOCATION" SortExpression="loc" />
                    <asp:BoundField DataField="job" HeaderText="JOB" SortExpression="job" />
                    <asp:BoundField DataField="pack" HeaderText="SALARY" SortExpression="pack" />
                    <asp:BoundField DataField="qual" HeaderText="QUALIFICATION" SortExpression="qual" />
                    <asp:BoundField DataField="exper" HeaderText="EXPERIANCE" SortExpression="exper" />
                    <asp:BoundField DataField="jbtype" HeaderText="TYPE" SortExpression="jbtype" />
                    <asp:BoundField DataField="descri" HeaderText="DESCRIPTION" SortExpression="descri" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="WANT TO APPLY? " ShowHeader="True" Text="APPLY" />
                </Columns>
            </asp:GridView>
</asp:Content>
