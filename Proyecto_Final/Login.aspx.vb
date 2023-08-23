Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click



        Try
            Dim eUsuario As New Negocios.Usuario(txtUsuario.Text, txtContrasena.Text)

            'MsgBox("Hubo un error al iniciar sesión", MsgBoxStyle.Exclamation, "Alerta")
            Dim valor As String = eUsuario.esUsuario.ToString()
            MsgBox(valor, MsgBoxStyle.Exclamation, "Alerta")

            If eUsuario.esUsuario Then
                Response.Redirect("~/", False)
            Else
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", "javascript:alert('Hubo un error al inicio de sesión')", True)

            End If

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", $"javascript: alert('(ex.Message);", True)


        End Try


    End Sub
End Class