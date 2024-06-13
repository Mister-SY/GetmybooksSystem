<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomerWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <link rel ="stylesheet" type="text/css" href="WebsiteStyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            height: 505px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
            <asp:Image ID="Image1" runat="server" Height="147px" ImageAlign="Right" ImageUrl="~/Getmybooks logo.png" Width="168px" />
        <div>
        </div>
            <asp:ListBox ID="lstCustomer" runat="server" Height="240px" Width="338px" DataTextField="Username" DataValueField="CustomerID" DataMember="DefaultView" DataSourceID="CustomerList" ></asp:ListBox>
            <asp:SqlDataSource ID="CustomerList" runat="server" ConnectionString="<%$ ConnectionStrings:GetmybooksdatabaseConnectionString %>" SelectCommand="SELECT [CustomerID], [Username] FROM [tblCustomer]"></asp:SqlDataSource>
        <br />
        <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome to Getmybooks. Please select an option to begin."></asp:Label>
        <br />
        <br />
        <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create New Account" Width="170px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit Account" Width="170px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete Account" Width="170px" />
        <asp:Button ID="btnOrders" runat="server" Text="View Orders" Width="170px" OnClick="btnOrders_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
