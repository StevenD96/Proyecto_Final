Imports Entidades
Imports Negocios

Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim usuarioActual As GestorUsuarios = DirectCast(Session("UsuarioActual"), GestorUsuarios)
        bienvenida.InnerHtml = "Bienvenido " + usuarioActual.tablaDatos.Rows(0)(2)
    End Sub
    Protected Sub lnkFuncionarios_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim usuarioActual As GestorUsuarios = DirectCast(Session("UsuarioActual"), GestorUsuarios)
        If usuarioActual.esFuncionario Then
            Session("UsuarioActual") = usuarioActual
            Response.Redirect("~/Funcionarios", False)
        Else
            indicacion.InnerHtml = "Lo sentimos no eres funcionario"
        End If
    End Sub

    Protected Sub lnkEstudiantes_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim usuarioActual As GestorUsuarios = DirectCast(Session("UsuarioActual"), GestorUsuarios)
        If usuarioActual.esEstudiante Then
            Session("UsuarioActual") = usuarioActual
            Response.Redirect("~/Estudiantes", False)
        Else
            indicacion.InnerHtml = "Lo sentimos no eres Estudiante"
        End If
    End Sub
End Class