Imports Entidades

Public Class DatosFuncionarios


    'Metodo para insertar
    Public Sub InsertarFuncionario(ByVal funcionario As Entidades.Funcionarios)


        Try
            Dim consultar As New Text.StringBuilder

            '  consultar.Append($"insert into Carreras values ('{carrera.codigo}', '{carrera.nombre}', '{carrera.grado}', {carrera.estado})")

            Dim iDatos As New DatosSQL.DatosSQL
            iDatos.QueryDB(consultar.ToString)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class
