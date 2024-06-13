<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="CustomerWebsite.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Orders</title>
    <link rel ="stylesheet" type="text/css" href="WebsiteStyleSheet.css" />
    </head>
<body style="height: 115px">
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="147px" ImageAlign="Right" ImageUrl="~/Getmybooks logo.png" Width="168px" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="No orders have been made yet."></asp:Label>
        </p>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Return to Homepage" Width="177px" />
    </form>
</body>
</html>
