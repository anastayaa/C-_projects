<%@ Page Language="C#" AutoEventWireup="true" CodeFile="filieres.aspx.cs" Inherits="filieres" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="FiliereGridView" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id_filiere" HeaderText="Id_filiere" SortExpression="Id_filiere" />
                    <asp:BoundField DataField="Nom_filiere" HeaderText="Nom_filiere" SortExpression="Nom_filiere" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAllFilieres" TypeName="FiliereServiceReference.FiliereServiceClient"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
