<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="Proyecto_Final.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div class="form-group">
            <label for="exampleInputEmail1">Usuario</label>
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" aria-describedby="emailHelp"  ></asp:TextBox>
            
        </div>

        <div class="form-group">
            <label for="exampleInputPassword1">Contrasena</label>
            <asp:TextBox ID="txtContrasena" runat="server" class="form-control" aria-describedby="emailHelp"  ></asp:TextBox>
            
        </div>

        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary" />
      
</asp:Content>
