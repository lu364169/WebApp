<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayPage.aspx.cs" Inherits="WebApp.DisplayPage" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Page</title>
</head>
<body>
    <p> This is the Display Page </p>
    <a href="Default.aspx">Home</a> | <a href="#">Display Page</a >
    <form id="form1" runat="server">
        <p></p>
        <div>
            <asp:GridView ID="userName" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
