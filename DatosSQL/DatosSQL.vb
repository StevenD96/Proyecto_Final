﻿Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatosSQL

    Dim sqlConn As SqlConnection 'variable q me permite conectarme
    Public Sub New() 'constructor
        Try
            Dim strConector As New System.Text.StringBuilder 'objeto almacena string de conexion

            With strConector
                'Agrege comentario
                .Append("Data Source=")
                .Append(ConfigurationManager.AppSettings("ServerName"))
                .Append(";Initial Catalog=")
                .Append(ConfigurationManager.AppSettings("DBName"))
                .Append(";Integrated Security=True;Trusted_Connection=true") ' con esta linea ingresa usando autentificacion de windows
                '.Append(";User=")
                '.Append(ConfigurationManager.AppSettings("UserDB"))
                '.Append(";Password=")
                '.Append(ConfigurationManager.AppSettings("PassDB"))
            End With

            Me.sqlConn = New SqlConnection(strConector.ToString) 'convertimos la variable en un objeto

        Catch sql As SqlException
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function QueryDBwithDTConUnParametro(ByVal QuerySQL As String, ByVal usuario As String) As DataTable
        Try

            Dim cmd As New SqlCommand(QuerySQL, Me.sqlConn)

            ' Agregar parámetro del usuario a la consulta
            cmd.Parameters.AddWithValue("@Usuario", usuario)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim Tabla_Datos As New DataTable

            adapter.Fill(Tabla_Datos)

            Return Tabla_Datos

        Catch sql As SqlException
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function QueryDBwithDT(ByVal QuerySQL As String) As DataTable
        Try

            Dim cmd As New SqlCommand(QuerySQL) With {
            .Connection = Me.sqlConn
            }

            Dim adapter As New SqlDataAdapter(cmd) ' objeto adaptador q ejecuta la consulta

            Dim Tabla_Datos As New DataTable ' almacena info obtenida de la B.D

            adapter.Fill(Tabla_Datos)  'con fill abre conexion a B.D, ejecuta consulta, toma la info,agrega info al dataTable, cierra consulta

            Return Tabla_Datos ' retornamos el data set ya con la info 

        Catch sql As SqlException
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Sub QueryDB(ByVal QuerySQL As String)
        Try

            Dim cmd As New SqlCommand(QuerySQL) With {
            .Connection = Me.sqlConn
            }
            sqlConn.Open()
            cmd.ExecuteNonQuery()
            sqlConn.Close() ' cierra la conexion 

        Catch sql As SqlException
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try


    End Sub


#Region "Manejo de Procedimientos Alacenados"
    Public Sub ExecuteSP(ByVal SP_Nombre As String, ByVal listaParametros As List(Of SqlParameter))
        Try

            Dim cmd As New SqlCommand() With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = SP_Nombre,
            .Connection = Me.sqlConn
            }


            For Each sqlParam As SqlParameter In listaParametros 'aqui comprobamos si la lista trae parametros y no venga vacia ni nula
                cmd.Parameters.Add(sqlParam) 'al obj comando le agregamos la lista de parametros que se llenaran en la clase q lo llame
            Next

            sqlConn.Open() ' abrimos conexion a la base de datos 

            cmd.ExecuteNonQuery() ' ejecuta la consulta

            sqlConn.Close() ' cierra la conexion 

        Catch sql As SqlException
            If sqlConn.State = ConnectionState.Open Then ' si la conexion esta abierta, cierrela 
                sqlConn.Close()
            End If
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function ExecuteSP_withDT(ByVal SP_Nombre As String, ByVal listaParametros As List(Of SqlParameter)) As DataTable
        Try

            Dim cmd As New SqlCommand() With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = SP_Nombre,
            .Connection = Me.sqlConn
            }


            For Each sqlParam As SqlParameter In listaParametros 'aqui comprobamos si la lista trae parametros y no venga vacia ni nula
                cmd.Parameters.Add(sqlParam) 'al obj comando le agregamos la lista de parametros que se llenaran en la clase q lo llame
            Next

            Dim adapter As New SqlDataAdapter(cmd) ' objeto adaptador q ejecuta la consulta

            Dim Tabla_Datos As New DataTable ' almacena info obtenida de la B.D

            adapter.Fill(Tabla_Datos)  'con fill abre conexion a B.D, ejecuta consulta, toma la info,agrega info al dataset, cierra consulta

            Return Tabla_Datos ' retornamos el data set ya con la info 

        Catch sql As SqlException
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ExecutSPWithDS(ByVal SPName As String, ByVal ListaParametros As List(Of SqlParameter)) As DataSet
        Try
            'indica la consulta de base de datos que se desea ejecutar
            Dim cmd As New SqlCommand() With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = SPName,
                .Connection = Me.sqlConn
            }

            'agrega los parametros a la ejecución del SP
            For Each sqlParam As SqlParameter In ListaParametros
                cmd.Parameters.Add(sqlParam)
            Next

            'objeto para ejecutar la consulta de la base de datos que retorna información
            Dim adapter As New SqlDataAdapter(cmd)

            'objeto para almacenar la información que se obtiene de la base de datos
            Dim dsDatos As New DataSet

            'ejecuta la consulta
            adapter.Fill(dsDatos)

            'retorna el resultado obtenido
            Return dsDatos

        Catch sql As SqlException
            If sqlConn.State = ConnectionState.Open Then sqlConn.Close()
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
