<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPreferiti.aspx.cs" Inherits="ecommerce.PaginaPreferiti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <h2> La tua lista dei preferiti: </h2>
            <asp:Label ID="LabelMOstraPreferiti" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="BUttonLogOut" runat="server" Text="Fai logout"  OnClick="BUttonLogOut_Click"/>
        </div>
    </form>
</body>
</html>
