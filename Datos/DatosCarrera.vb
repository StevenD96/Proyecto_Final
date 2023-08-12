Imports Entidades

Public Class DatosCarrera
    'Metodo para insertar
    Public Sub InsertarCarrera(ByVal carrera As Entidades.Carreras)


        Try
            Dim consultar As New Text.StringBuilder

            consultar.Append($"insert into Carreras values ('{carrera.codigo}', '{carrera.nombre}', '{carrera.grado}', {carrera.estado})")

            Dim iDatos As New DatosSQL.DatosSQL
            iDatos.QueryDB(consultar.ToString)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Metodo para consultar
    Public Function ConsultarCarrera() As DataTable

        Try
            Dim consultar As New Text.StringBuilder
            consultar.Append($"Select * From Carreras")
            Dim iDatos As New DatosSQL.DatosSQL
            Return iDatos.QueryDBwithDT(consultar.ToString)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class