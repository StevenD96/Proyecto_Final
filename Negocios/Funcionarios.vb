Public Class Funcionarios


    Public Sub insertarFuncionario(ByVal funcionario As Entidades.Funcionarios)

        Try
            Dim datos As New Datos.DatosFuncionarios
            datos.InsertarFuncionario(funcionario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
