<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="Proyecto_Final.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <p>Your app description page.</p>
        <p>Use this area to provide additional information.</p>

        <button id="boton" class="btn" style="background-color: forestgreen; width:200px">Prueba </button>
        <input type="text" name="name" value="" />


    </main>
</asp:Content>
