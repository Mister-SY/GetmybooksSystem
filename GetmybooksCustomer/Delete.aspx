<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CustomerWebsite.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Page</title>
    <link rel ="stylesheet" type="text/css" href="WebsiteStyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="147px" ImageAlign="Right" ImageUrl="~/Getmybooks logo.png" Width="168px" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this account?"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnYes_Click" runat="server" OnClick="btnYes_Click_Click" Text="Yes" />
        <asp:Button ID="btnNo_Click" runat="server" OnClick="btnNo_Click_Click" Text="No" Width="42px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
