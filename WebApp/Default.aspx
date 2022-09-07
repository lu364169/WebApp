<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <p> This is the Home Page </p>
    <a href="#">Home</a> | <a href="DisplayPage.aspx">Display Page</a >
    <form id="form1" runat="server">
        <div>

            <p>Enter Name</p>
            <asp:TextBox ID="nameTextBox" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                runat="server" ErrorMessage="Name cannot be blank" 
                ControlToValidate="nameTextBox" 
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <p>Enter Age</p>
            <asp:TextBox ID="ageTextBox" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                runat="server" ErrorMessage="Age cannot be blank" 
                ControlToValidate="ageTextBox" 
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <p>Enter Address</p>
            <asp:TextBox ID="addressTextBox" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                runat="server" ErrorMessage="Address cannot be blank" 
                ControlToValidate="addressTextBox" 
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <p></p>
            <asp:Button ID="UploadButton" Text="Insert" runat="server" Onclick="insertEventMethod"/>



        </div>
    </form>
</body>
</html>
