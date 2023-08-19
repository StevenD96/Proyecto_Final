Public Class DatosUsuario








    Public Function consultarUsuario(ByVal user As Entidades.Usuarios)

        Try
            Dim consultar As New Text.StringBuilder

            consultar.Append($"Select * From Usuarios where Usuario = '{user.usuario}' and Contrasena = '{user.contrasena}'")

            Dim idatos As New DatosSQL.DatosSQL
            Return idatos.QueryDBwithDT(consultar.ToString)


        Catch ex As Exception
            Throw ex
        End Try


    End Function

End Class
