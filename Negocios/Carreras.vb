﻿Public Class Carreras

    Public Sub insertarCarrera(ByVal carrera As Entidades.Carreras)

        Try
            Dim datos As New Datos.DatosCarrera
            datos.InsertarCarrera(carrera)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub











End Class