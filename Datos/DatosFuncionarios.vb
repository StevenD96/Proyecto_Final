Imports Entidades

Public Class DatosFuncionarios



    Public Sub ModificarFuncionario(ByVal funcionario As Entidades.Funcionarios)
        Dim storedProcedureName As String = "ModificarFuncionario"
        Dim modificarBD As New DatosSQL.DatosSQL

        modificarBD.QueryDBwithDTModificarFuncionario(storedProcedureName, funcionario)
    End Sub

    Public Sub InsertarFuncionario(ByVal funcionario As Entidades.Funcionarios)

    End Sub



End Class
