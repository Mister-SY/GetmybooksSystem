<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="CustomerWebsite.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Details</title>
    <link rel ="stylesheet" type="text/css" href="WebsiteStyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            margin-left: 96px;
        }
        .auto-style2 {
            margin-left: 95px;
        }
        .auto-style3 {
            margin-left: 94px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="169px" ImageAlign="Right" ImageUrl="~/Getmybooks logo.png" Width="191px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            Customer Details:</p>
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style2" style="margin-left: 78px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style3" style="margin-left: 87px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address:"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server" CssClass="auto-style4" style="margin-left: 25px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email:"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server" CssClass="auto-style5" style="margin-left: 44px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="auto-style6" style="margin-left: 55px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style1" style="margin-left: 94px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk_Click" runat="server" OnClick="btnOk_Click_Click" Text="Ok" Width="77px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </p>
    </form>
</body>
</html>
