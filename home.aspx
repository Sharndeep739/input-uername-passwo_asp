<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="sharn.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtUser" runat="server" OnTextChanged="Texuser_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#99FF99" ForeColor="Black" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
