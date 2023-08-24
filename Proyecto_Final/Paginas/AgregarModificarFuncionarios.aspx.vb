Imports Negocios

Public Class Formulario_web32
    Inherits System.Web.UI.Page
    Private _gestorUsuarios As GestorFuncionarios

    Public Sub New()
        _gestorUsuarios = New GestorFuncionarios()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMensaje.InnerHtml = Session("mensaje").ToString
    End Sub

    Protected Sub btnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs)


        ' Verificar si todos los campos requeridos están llenos y son válidos
        If Page.IsValid Then
            Dim identificacion As String = txtIdentificacion.Text
            Dim nombre As String = txtNombre.Text
            Dim apellidos As String = txtApellidos.Text
            Dim telefono As String = txtTelefono.Text
            Dim correo As String = txtCorreo.Text
            Dim estado As String = ""
            If rbActivo.Checked Then
                estado = "1"
            ElseIf rbInactivo.Checked Then
                estado = "0"
            End If
            ' Luego puedes ejecutar la inserción en la base de datos u otra lógica
            ' ...

            ' Mostrar mensaje de éxito
            Session("mensaje") = "Funcionario agregado exitosamente."
            Response.Redirect("~/Paginas/AgregarModificarFuncionarios", False)
        Else
            ' Mostrar mensaje de error si no se llenaron todos los campos requeridos
            Session("mensaje") = "Por favor, complete todos los campos requeridos."
            Response.Redirect("~/Paginas/AgregarModificarFuncionarios", False)
        End If
    End Sub

    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If txtIdentificacion.Text <> "" Then
            Dim identificacion As String = txtIdentificacion.Text
            Dim nombre As String = txtNombre.Text
            Dim apellidos As String = txtApellidos.Text
            Dim telefono As String = txtTelefono.Text
            Dim correo As String = txtCorreo.Text
            Dim estado As String = ""
            If rbActivo.Checked Then
                estado = "1"
            ElseIf rbInactivo.Checked Then
                estado = "0"
            End If
            ' Luego puedes ejecutar la inserción en la base de datos u otra lógica
            Dim funcionario As Entidades.Funcionarios = New Entidades.Funcionarios(identificacion, nombre, apellidos, telefono, correo, estado)
            _gestorUsuarios.modificarFuncionario(funcionario)
            Session("mensaje") = "Funcionario modificado exitosamente."
            Response.Redirect("~/Paginas/AgregarModificarFuncionarios", False)
            ' Mostrar mensaje de éxito
        Else
            ' Mostrar mensaje de error si no se llenaron todos los campos requeridos
            Session("mensaje") = "Por favor, complete el campo de identificacion para realizar el cambio."
            Response.Redirect("~/Paginas/AgregarModificarFuncionarios", False)
        End If
    End Sub
End Class