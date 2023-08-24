<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Estudiantes.aspx.vb" Inherits="Proyecto_Final.Formulario_web31" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
    <div class="row">
      <div class="col-md-4">
        <div class="list-group">
          <a href="prueba" class="list-group-item list-group-item-action">Registro de Estudiantes en Cursos</a>
          <a href="prueba" class="list-group-item list-group-item-action">Confirmación de Cursos Abiertos</a>
          <a href="prueba" class="list-group-item list-group-item-action">Consulta de Materias Matriculadas y Costo</a>
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
