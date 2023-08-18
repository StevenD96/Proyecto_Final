Public Class Seguridad


    Public Function validarLogin(ByVal eUsuario As Entidades.Usuarios)

        Try

            Dim iDatos As New Datos.DatosUsuario
            eUsuario.validarCredencial = False

            Dim dt As DataTable = iDatos.consultarUsuario(eUsuario)

            If dt.Rows.Count <> 0 Then
                eUsuario.validarCredencial = True
            End If

            Return eUsuario
        Catch ex As Exception

        End Try


    End Function


End Class
