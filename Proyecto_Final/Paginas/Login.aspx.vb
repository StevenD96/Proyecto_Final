Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click



        Try
            Dim eUsuario As New Entidades.Usuarios
            Dim iSeguridad As New Negocios.Seguridad

            eUsuario.usuario = txtUsuario.Text
            eUsuario.contrasena = txtContrasena.Text

            eUsuario = iSeguridad.validarLogin(eUsuario)

            If eUsuario.validarCredencial Then
                Session("usuario") = eUsuario
                FormsAuthentication.RedirectFromLoginPage(eUsuario.usuario, False)

            Else
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", "javascript:alert('Hubo un error al inicio de sesión')", True)

            End If

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", $"javascript: alert('(ex.Message);", True)


        End Try





    End Sub
End Class