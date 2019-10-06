<%@ Page Language="C#" AutoEventWireup="true" CodeFile="descriptionPersonne.aspx.cs" Inherits="descriptionPersonne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nom&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Nom" runat="server"></asp:TextBox>
            <br />
            <br />
            Prenom&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Prenom" runat="server"></asp:TextBox>
            <br />
            <br />
            Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Age" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Description" runat="server" Text="Description" OnClick="Description_Click" />
            <br />
            <br />
            <asp:Label ID="descriptionLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
