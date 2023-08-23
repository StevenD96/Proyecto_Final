Imports Entidades

Public Class DatosUsuario


    Dim usuario As String
    Dim contrasena As String

    Public Sub New(usuario As String, contrasena As String)
        Me.usuario = usuario
        Me.contrasena = contrasena
    End Sub
    Public Function verificarUsuario() As DataTable
        Dim query As String = "SELECT Usuario, Identificacion, Nombre, Apellidos, EsEstudiante, EsFuncionario FROM VistaUsuariosRoles WHERE Usuario = @Usuario"
        Dim iUsuario As New DatosSQL.DatosSQL
        Dim dataTable As DataTable = iUsuario.QueryDBwithDTConUnParametro(query, usuario)
        Return dataTable

    End Function


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
