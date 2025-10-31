<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Logout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Logged out</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="12pt"
            Height="21px" Text="You have been looged out from system!!!" Width="372px"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Verdana" Font-Size="10pt"
            ForeColor="#0000FF" NavigateUrl="~/Login.aspx" Width="237px">Click here to Login again.....</asp:HyperLink></div>
    </form>
</body>
</html>
