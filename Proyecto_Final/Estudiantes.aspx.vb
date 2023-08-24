Imports Negocios

Public Class Formulario_web31
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuarioActual As GestorUsuarios = DirectCast(Session("UsuarioActual"), GestorUsuarios)
        bienvenida.InnerHtml = "Bienvenido " + usuarioActual.tablaDatos.Rows(0)(2)
    End Sub

End Class