<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="OnlineJobSearchPortal.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="aId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="aId" HeaderText="aId" InsertVisible="False" ReadOnly="True" SortExpression="aId" />
                    <asp:BoundField DataField="cid" HeaderText="cid" SortExpression="cid" />
                    <asp:BoundField DataField="uid" HeaderText="uid" SortExpression="uid" />
                    <asp:BoundField DataField="resume" HeaderText="resume" SortExpression="resume" />
                </Columns>
            </asp:GridView>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <%#Eval("a") %>
                </ItemTemplate>
            </asp:DataList><asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">

                           </asp:DetailsView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectiondb %>" SelectCommand="SELECT * FROM [apply]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
