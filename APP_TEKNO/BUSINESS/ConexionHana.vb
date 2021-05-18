Imports Sap.Data.Hana

Public Class ConexionHana

#Region "Propiedades"
    Private Property Conexion As HanaConnection
#End Region

#Region "Constructores"
    Sub New()
        Try
            Conexion = New HanaConnection(My.Settings.conexionDBHANA)
        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "Metodos"

    ''' <summary>
    ''' Abre la conexion de la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub abrirConexion()
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If
        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        End Try
    End Sub

    ''' <summary>
    ''' Cierra la conexion hacia la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cerrarConexion()
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta una transaccion (Insert,Delete,Update)
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns>Numero de filas afectadas</returns>
    ''' <remarks></remarks>
    Public Function ejecutarSQL(ByVal sql As String) As Integer
        Dim resul As Integer
        Try
            Dim cmd As New HanaCommand
            abrirConexion()
            cmd.Connection = Conexion
            cmd.CommandText = sql
            resul = cmd.ExecuteNonQuery()
            cerrarConexion()
        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        End Try
        Return resul
    End Function

    ''' <summary>
    ''' Ejecutar Consulta a la base de datos
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function ejecutarQuery(ByVal sql As String) As DataSet
        Dim resul As New DataSet()
        Try
            abrirConexion()
            Dim cmd As New HanaCommand
            Dim adapter As New HanaDataAdapter(sql, Conexion)
            adapter.Fill(resul, "Consulta")
        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        Finally
            cerrarConexion()
        End Try
        Return resul
    End Function

    ''' <summary>
    ''' Ejecuta un procedimiento almacenado de tipo transaccion 
    ''' </summary>
    ''' <param name="spName"></param>
    ''' <param name="parametros"></param>
    ''' <returns>Numero de Filas Afectadas</returns>
    ''' <remarks></remarks>
    Public Function ejecutarSP(ByVal spName As String, Optional ByVal parametros As List(Of HanaParameter) = Nothing) As Integer

        Dim resul As Integer
        Try
            abrirConexion()
            Dim cmd As New HanaCommand
            With cmd
                .Connection = Conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = spName
            End With

            If Not parametros Is Nothing Then
                For Each p In parametros
                    cmd.Parameters.Add(p)
                Next
            End If

            resul = cmd.ExecuteNonQuery()

        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        Finally
            cerrarConexion()
        End Try
        Return resul
    End Function

    ''' <summary>
    ''' Ejecutar una consulta desde un procedimiento almacenado
    ''' </summary>
    ''' <param name="spName"></param>
    ''' <param name="parametros"></param>
    ''' <returns>Dataset</returns>
    ''' <remarks></remarks>
    Public Function ejecutarSPQuery(ByVal spName As String, Optional ByVal parametros As List(Of HanaParameter) = Nothing) As DataSet
        Dim ds As New DataSet()
        Try
            Dim adapter As New HanaDataAdapter
            Dim cmd As New HanaCommand
            abrirConexion()
            With cmd
                .Connection = Conexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = spName
            End With

            If Not parametros Is Nothing Then
                For Each p In parametros
                    cmd.Parameters.Add(p)
                Next
            End If

            adapter.SelectCommand = cmd
            adapter.Fill(ds)

        Catch ex As HanaException
            Throw New Exception(ex.Errors(0).Source + " : " & ex.Errors(0).Message + " (" & ex.Errors(0).NativeError.ToString() + ")")
        Finally
            cerrarConexion()
        End Try
        Return ds
    End Function

#End Region


End Class