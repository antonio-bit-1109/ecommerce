<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ecommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:TextBox ID="nome" runat="server"></asp:TextBox>
        <asp:TextBox ID="cognome" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Registrati"  OnClick="Button1_Click"/>
        <h2 id="TITOLO" runat="server"> INSERISCI VALORI VALIDI  </h2>
    </main>

</asp:Content>
