<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaProdotti.aspx.cs" Inherits="ecommerce.PaginaProdotti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            
            <ul>
                
                <li id="elem1" runat="server"> orsetto  </li> <asp:Button ID="Button1" runat="server" Text="aggiungi Alla wishList" OnClick="AddtoWishlist" CommandArgument="orsetto"/>
                <li id="elem2" runat="server"> Palla</li> <asp:Button ID="Button2" runat="server" Text="aggiungi Alla wishList" OnClick="AddtoWishlist" CommandArgument="palla"/>
                <li id="elem3" runat="server"> Forma Di Parmigiano </li><asp:Button ID="Button3" runat="server" Text="aggiungi Alla wishList" OnClick="AddtoWishlist" CommandArgument="Forma Di Parmigiano"/> 
                <li id="elem4" runat="server"> I-phone</li> <asp:Button ID="Button4" runat="server" Text="aggiungi Alla wishList"  OnClick="AddtoWishlist" CommandArgument="I-phone"/>
             
            </ul>
            <h3 id="noProdottiInLista" runat="server"></h3>
            <asp:Button ID="Button5" runat="server" Text="VaiAllaWishList"  OnClick="VaiWishList"/>
        </div>
    </form>
</body>
</html>
