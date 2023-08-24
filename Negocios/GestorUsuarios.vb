Public Class GestorUsuarios
    Dim usuario As String
    Dim contrasena As String
    Public Sub New(usuario As String, contrasena As String)
        Me.usuario = usuario
        Me.contrasena = contrasena
    End Sub
    Public Function esFuncionario() As Boolean
        Dim resultadoQuery As New Datos.DatosUsuario(Me.usuario, Me.contrasena)
        Dim miDataTable As DataTable = resultadoQuery.verificarUsuario()
        Dim valorColFuncionario As String = miDataTable.Rows(0)(5)
        If valorColFuncionario = "1" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function esEstudiante() As Boolean
        Dim resultadoQuery As New Datos.DatosUsuario(Me.usuario, Me.contrasena)
        Dim miDataTable As DataTable = resultadoQuery.verificarUsuario()

        Dim valorColEstudiante As String = miDataTable.Rows(0)(4)
        If valorColEstudiante = "1" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function esUsuario() As Boolean
        If esEstudiante() Or esFuncionario() Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function tablaDatos() As DataTable
        Dim resultadoQuery As New Datos.DatosUsuario(Me.usuario, Me.contrasena)
        Dim miDataTable As DataTable = resultadoQuery.verificarUsuario()

        Return miDataTable

    End Function

    Public Shared Widening Operator CType(v As GestorFuncionarios) As GestorUsuarios
        Throw New NotImplementedException()
    End Operator
End Class
