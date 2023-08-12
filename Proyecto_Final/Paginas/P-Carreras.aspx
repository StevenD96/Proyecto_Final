<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="P-Carreras.aspx.vb" Inherits="Proyecto_Final.Prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    <div class="input-group form-group" >
        <span class="input-group-addon" id="basic-addon1">Codigo</span>
        <asp:TextBox ID="txtCodigo" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1" required pattern="[A-Za-z0-9]+" title="Por favor utilice letras y números"></asp:TextBox>

    </div>

    <div class="input-group form-group">
        <span class="input-group-addon" id="basic-addon1">Nombre</span>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
    </div>

     <div class="input-group form-group">
        <span class="input-group-addon" id="basic-addon1">Grado</span>
        <asp:TextBox ID="txtGrado" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
    </div>

    <div class="input-group form-group">
        <span class="input-group-addon" id="basic-addon1">Estado</span>
        <asp:CheckBox ID="chkEstado" runat="server" />
      
    </div>
        <asp:Button ID="txtIngresar" runat="server" Text="Ingresar" />

    </div>

</asp:Content>