<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="P-Funcionarios.aspx.vb" Inherits="Proyecto_Final.P_Funcionarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>

    <div class="input-group form-group" >
        <span class="input-group-addon" id="basic-addon1">Usuario</span>
        <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1" pattern="[A-Za-z0-9]+" title="Por favor utilice letras y números"></asp:TextBox>

    </div>

        <div class="input-group form-group">
            <span class="input-group-addon" id="basic-addon2">Contrasena</span>
            <asp:TextBox ID="txtContrasena" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1" pattern="[A-Za-z0-9]+" title="Por favor utilice letras y números"></asp:TextBox>
        </div>

        <div class="input-group form-group">
            <span class="input-group-addon" id="basic-addon3">Identificacion</span>
            <asp:TextBox ID="txtIdentificacion" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
        </div>

        <div class="input-group form-group">
            <span class="input-group-addon" id="basic-addon4">Nombre</span>
            <asp:TextBox ID="txtNi" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
        </div>

        <div class="input-group form-group">
            <span class="input-group-addon" id="basic-addon5">Primer Apellido</span>
            <asp:TextBox ID="txtPrimerApellido" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
        </div>

        <div class="input-group form-group">
            <span class="input-group-addon" id="basic-addon6">Segundo Apellido</span>
            <asp:TextBox ID="txtSegundoApellido" runat="server" class="form-control" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
        </div>

        <div class="input-group form-group">
            <span class="input-group-addon" id="basic-addon7">Estado</span>
            <asp:CheckBox ID="chkEstado" runat="server" />
        </div>
        </div>

</asp:Content>
