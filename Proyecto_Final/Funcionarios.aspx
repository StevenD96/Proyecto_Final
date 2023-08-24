<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Funcionarios.aspx.vb" Inherits="Proyecto_Final.Funcionarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
    <div class="row">
      <div class="col-md-4">
        <div class="list-group">
          <a id="lnkModificarFuncionario" class="list-group-item list-group-item-action" runat="server" OnServerClick="lnkModificarFuncionario_Click">Mantenimiento de Funcionarios</a>
          <a href="prueba" class="list-group-item list-group-item-action">Registro y Modificación de Carreras</a>
          <a href="prueba" class="list-group-item list-group-item-action">Registro y Modificación de Cursos</a>
          <a href="prueba" class="list-group-item list-group-item-action">Registro y Modificación de Estudiantes</a>
        </div>
      </div>
      <div class="col-md-8">
        <div class="jumbotron">
          <h1 runat="server" id="bienvenida">Bienvenido</h1>
          <p>Selecciona una opción del menú para comenzar.</p>
        </div>
      </div>
    </div>
  </div>

</asp:Content>
