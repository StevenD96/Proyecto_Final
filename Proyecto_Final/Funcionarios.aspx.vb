Imports Negocios

Public Class Funcionarios
    Inherits System.Web.UI.Page
    Dim _usuarioActual As GestorFuncionarios

    Public Sub New()
        _usuarioActual = New GestorFuncionarios()
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuarioActual As GestorUsuarios = DirectCast(Session("UsuarioActual"), GestorUsuarios)
        bienvenida.InnerHtml = "Bienvenido " + usuarioActual.tablaDatos.Rows(0)(2)
    End Sub
    Protected Sub lnkModificarFuncionario_Click(ByVal sender As Object, ByVal e As EventArgs)
        Session("mensaje") = " "
        Response.Redirect("~/Paginas/AgregarModificarFuncionarios", False)
    End Sub

End Class