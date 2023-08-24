Public Class Funcionarios

    Public Property identificacion As String
    Public Property nombre As String
    Public Property apellidos As String
    Public Property telefono As String
    Public Property correo As String
    Public Property estado As String

    Public Sub New(ByVal id As String, ByVal nom As String, ByVal apell As String, ByVal tel As String, ByVal corr As String, ByVal est As String)
        identificacion = id
        nombre = nom
        apellidos = apell
        telefono = tel
        correo = corr
        estado = est
    End Sub


End Class
