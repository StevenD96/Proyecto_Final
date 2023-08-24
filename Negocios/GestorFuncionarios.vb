Public Class GestorFuncionarios
    Dim _datosFuncionario As Datos.DatosFuncionarios

    Public Sub New()
        _datosFuncionario = New Datos.DatosFuncionarios()
    End Sub

    Public Sub modificarFuncionario(ByVal funcionario As Entidades.Funcionarios)
        _datosFuncionario.ModificarFuncionario(funcionario)

    End Sub

    Public Sub insertarFuncionario(ByVal funcionario As Entidades.Funcionarios)
        _datosFuncionario.InsertarFuncionario(funcionario)

    End Sub


End Class
