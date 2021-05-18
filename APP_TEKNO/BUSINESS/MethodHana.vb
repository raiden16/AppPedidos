Public Class MethodHana


    Public Function getArticulos(ByVal fechaIni As String, ByVal FechaFin As String, ByVal CardCode As String) As DataTable
        Try
            Dim tabla As DataTable
            Dim sql As String = "SELECT *, 0 as ""NoPedido"", 0 as ""Cond"" FROM """ & My.Settings.Empresa & """.""FT_CALCULOINV"" ('" & fechaIni & "','" & FechaFin & "', '" & CardCode & "') order by 1,2"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                tabla = ds.Tables(0)
            End If
            Return tabla
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
    Public Function getTotalVenta(ByVal item As String) As DataTable
        Try
            Dim tabla As DataTable

            Dim sql As String = "SELECT (SUM(""T1"".""Quantity""))  AS ""Total"",""T1"".""ItemCode"" FROM  """ & My.Settings.Empresa & """.""OINV"" T0 INNER JOIN """ & My.Settings.Empresa & """.""INV1"" ""T1"" " +
                                "ON ""T0"".""DocEntry"" =""T1"".""DocEntry"" WHERE ""T0"".""DocDate"" "
            sql = sql + "BETWEEN to_date('" & DateTime.Now.AddMonths(-3).ToShortDateString & "', 'MM/DD/YYYY') and    to_date('" & DateTime.Now.ToShortDateString & "', 'MM/DD/YYYY')  GROUP BY ""T1"".""ItemCode"" "
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                tabla = ds.Tables(0)
            End If
            Return tabla
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function getProveedor() As DataTable
        Try
            Dim tabla As DataTable
            Dim sql As String = "SELECT Concat(CONCAT(ROW_NUMBER() OVER(ORDER BY ""T0"".""CardName"" ASC), ' - '), (""T0"".""CardName""))  AS ""CardName"",""T0"".""CardCode"" FROM  """ & My.Settings.Empresa & """.""OCRD"" T0 " +
                                "WHERE ""T0"".""CardCode"" in (SELECT ""T1"".""CardCode"" FROM  """ & My.Settings.Empresa & """.""OITM"" T1 WHERE ""T1"".""CardCode"" IS NOT NULL) "
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                tabla = ds.Tables(0)
            End If
            Return tabla
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetEmailProveedor(ByVal CardCode As String) As String
        Try
            Dim email As String
            Dim sql As String = "SELECT T0.""E_Mail""  FROM  " & My.Settings.Empresa & ".OCRD T0 WHERE T0.""CardCode"" =  '" & CardCode & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                email = ds.Tables(0).Rows(0).Item(0).ToString()
            End If
            Return email
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetPersonaContProveedor(ByVal CardCode As String) As String
        Try
            Dim Contacto As String
            Dim sql As String = "SELECT Top 1 T1.""FirstName""  FROM  " & My.Settings.Empresa & ".OCRD T0 INNER JOIN " & My.Settings.Empresa & ".OCPR T1 ON T0.""CardCode"" = T1.""CardCode"" WHERE T0.""CardCode"" =  '" & CardCode & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Contacto = ds.Tables(0).Rows(0).Item(0).ToString()
            End If
            Return Contacto
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetPrecioProveedor(ByVal CardCode As String, ByVal ItemCode As String) As String
        Try
            Dim Precio As String
            Dim sql As String = "SELECT T0.""ItemCode"",T1.""ItemName"", T2.""CardCode"", T2.""CardName"", T0.""Price"", T0.""PriceList"" FROM " & My.Settings.Empresa & ".ITM1 T0 INNER JOIN " & My.Settings.Empresa & ".OITM T1 ON T0.""ItemCode"" = T1.""ItemCode"" INNER JOIN " & My.Settings.Empresa & ".OCRD T2 ON T0.""PriceList"" = T2.""ListNum"" where T2.""CardCode"" = '" & CardCode & "' and T0.""ItemCode"" = '" & ItemCode & "' "
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Precio = ds.Tables(0).Rows(0).Item("Price").ToString()
            End If
            Return Precio
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetPrecioLista(ByVal ItemCode As String) As String
        Try
            Dim Precio As String
            Dim sql As String = "SELECT T0.""ItemCode"", cast(T0.""Price"" as Decimal(5,2)) as ""Price"" FROM " & My.Settings.Empresa & ".ITM1 T0 where T0.""PriceList"" = 1 and T0.""ItemCode"" = '" & ItemCode & "' "
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Precio = ds.Tables(0).Rows(0).Item("Price").ToString()
            End If
            Return Precio
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetMonedaLista(ByVal ItemCode As String) As String
        Try
            Dim Moneda As String
            Dim sql As String = "SELECT T0.""ItemCode"", T0.""Currency"" FROM " & My.Settings.Empresa & ".ITM1 T0 where T0.""PriceList"" = 1 and T0.""ItemCode"" = '" & ItemCode & "' "
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Moneda = ds.Tables(0).Rows(0).Item("Currency").ToString()
            End If
            Return Moneda
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetCanrtidadPorPaquete(ByVal ItemCode As String) As String
        Try
            Dim CantidadXPaquete As String
            Dim sql As String = "SELECT ifnull((T0.""PurPackUn"" * T0.""U_CajaporPallet""),1) as PurPackUn FROM " & My.Settings.Empresa & ".OITM T0 WHERE T0.""ItemCode"" = '" & ItemCode & "' "
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                CantidadXPaquete = ds.Tables(0).Rows(0).Item("PurPackUn").ToString()
            End If
            Return CantidadXPaquete
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetCantidadContenedor(ByVal Grupo As String) As Integer
        Try
            Dim CantidadContenedor As Integer
            Dim sql As String = "SELECT T0.""U_Capacidad"" FROM " & My.Settings.Empresa & ".""@GROUPTEKNO"" T0 WHERE T0.""Code"" =  '" & Grupo & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                CantidadContenedor = ds.Tables(0).Rows(0).Item(0)
            End If
            Return CantidadContenedor
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetMandatoryContenedor(ByVal Grupo As String) As Integer
        Try
            Dim MandatoryContenedor As Integer
            Dim sql As String = "SELECT T0.""U_Mandatory"" FROM " & My.Settings.Empresa & ".""@GROUPTEKNO"" T0 WHERE T0.""Code"" =  '" & Grupo & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                MandatoryContenedor = ds.Tables(0).Rows(0).Item(0)
            End If
            Return MandatoryContenedor
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetMaximoContenedor(ByVal Grupo As String) As Integer
        Try
            Dim Maximo As Integer = 0
            Dim sql As String = "SELECT T0.""U_Maximo"" FROM " & My.Settings.Empresa & ".""@GROUPTEKNO"" T0 WHERE T0.""Code"" =  '" & Grupo & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Maximo = ds.Tables(0).Rows(0).Item(0)
            End If
            Return Maximo
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetMinimoContenedor(ByVal Grupo As String) As Integer
        Try
            Dim Minimo As Integer = 0
            Dim sql As String = "SELECT T0.""U_Minimo"" FROM " & My.Settings.Empresa & ".""@GROUPTEKNO"" T0 WHERE T0.""Code"" =  '" & Grupo & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Minimo = ds.Tables(0).Rows(0).Item(0)
            End If
            Return Minimo
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function GetDocNumPedido(ByVal DocEntry As Integer) As Integer
        Try
            Dim DocNum As Integer = 0
            Dim sql As String = "SELECT T0.""DocNum"" FROM " & My.Settings.Empresa & ".""OPOR"" T0 WHERE T0.""DocEntry"" =  " & DocEntry & ""
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                DocNum = ds.Tables(0).Rows(0).Item(0)
            End If
            Return DocNum
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function CreateTemp()
        Try

            Dim sql As String = "CREATE COLUMN TABLE " & My.Settings.Empresa & ".TEMP_SALDO_FIN (ID bigint NOT NULL primary key GENERATED BY DEFAULT AS IDENTITY,NoPedido integer,Proveedor nvarchar(20),Codigo nvarchar(50),Articulo nvarchar(150),Cantidad integer,Precio nvarchar(50),Capacidad integer,Grupo nvarchar(100),Estado nvarchar(100))"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function GetCapacidad(ByVal Grupo As String) As Integer
        Try
            Dim Capacidad As Integer
            Dim sql As String = "Select ""U_Capacidad"" from " & My.Settings.Empresa & ".""@GROUPTEKNO"" where ""Code""='" & Grupo & "'"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Capacidad = ds.Tables(0).Rows(0).Item(0)
            End If
            Return Capacidad
        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function PushTemp(ByVal Proveedor As String, ByVal Codigo As String, ByVal Articulo As String, ByVal Cantidad As Integer, ByVal Precio As String, ByVal Capacidad As Integer, ByVal Grupo As String, ByVal Estado As String)
        Try

            Dim sql As String = "Insert Into " & My.Settings.Empresa & ".TEMP_SALDO_FIN (Proveedor,Codigo,Articulo,Cantidad,Precio,Capacidad,Grupo,Estado) values('" & Proveedor & "','" & Codigo & "','" & Articulo & "'," & Cantidad & ",'" & Precio & "'," & Capacidad & ",'" & Grupo & "','" & Estado & "')"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function


    Public Function GetPedido()

        Try
            Dim Cantidad, Capacidad, Id As Integer
            Dim sql As String = "Select * from " & My.Settings.Empresa & ".TEMP_SALDO_FIN order by ""CAPACIDAD"",""CANTIDAD"",""ID"""
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)

            Dim NoPedido = 0

            If ds.Tables(0).Rows.Count > 0 Then

                For i = 0 To ds.Tables(0).Rows.Count - 1

                    Cantidad = ds.Tables(0).Rows(i).Item("CANTIDAD")
                    Capacidad = ds.Tables(0).Rows(i).Item("CAPACIDAD")
                    Id = ds.Tables(0).Rows(i).Item("ID")

                    If Cantidad / Capacidad = 1 Then

                        NoPedido = NoPedido + 1
                        PushPedido(NoPedido, Id, 0)

                    Else

                        Dim sql3 As String = "Select * from " & My.Settings.Empresa & ".TEMP_SALDO_FIN where ""NOPEDIDO"" is null and ""ID""=" & Id
                        Dim ds3 As DataSet
                        ds3 = AccesoDBHANA.GetConexion.ejecutarQuery(sql3)

                        If ds3.Tables(0).Rows.Count > 0 Then

                            Dim y = 0
                            Dim sql2 As String = "Select * from " & My.Settings.Empresa & ".TEMP_SALDO_FIN where ""NOPEDIDO"" is null and ""ID""<>" & Id & " and ""CANTIDAD""<" & Capacidad & " and ""CAPACIDAD""=" & Capacidad & " order by ""CAPACIDAD"",""ID"""
                            Dim ds2 As DataSet
                            ds2 = AccesoDBHANA.GetConexion.ejecutarQuery(sql2)

                            If ds.Tables(0).Rows(i).Item("GRUPO") = "KAINDL-22" Or ds.Tables(0).Rows(i).Item("GRUPO") = "KAINDL-20" Or ds.Tables(0).Rows(i).Item("GRUPO") = "KAINDL-33" Then

                                While (y <= ds2.Tables(0).Rows.Count - 1)

                                    Cantidad = ds.Tables(0).Rows(i).Item("CANTIDAD") + ds2.Tables(0).Rows(y).Item("CANTIDAD")
                                    Capacidad = ds.Tables(0).Rows(i).Item("CAPACIDAD")

                                    If Cantidad / Capacidad = 1 Then

                                        NoPedido = NoPedido + 1
                                        PushPedido(NoPedido, Id, ds2.Tables(0).Rows(y).Item("ID"))
                                        y = ds2.Tables(0).Rows.Count

                                    End If

                                    y = y + 1

                                End While

                            Else

                                Cantidad = ds.Tables(0).Rows(i).Item("CANTIDAD")
                                Dim arreglo(ds2.Tables(0).Rows.Count) As Integer

                                While (y <= ds2.Tables(0).Rows.Count - 1)

                                    Cantidad = Cantidad + ds2.Tables(0).Rows(y).Item("CANTIDAD")
                                    Capacidad = ds.Tables(0).Rows(i).Item("CAPACIDAD")
                                    arreglo(y) = ds2.Tables(0).Rows(y).Item("ID")

                                    If Cantidad / Capacidad = 1 Then

                                        NoPedido = NoPedido + 1
                                        PushPedido(NoPedido, Id, 0)
                                        For l = 0 To ds2.Tables(0).Rows.Count - 1

                                            If arreglo(l) <> 0 Then

                                                PushPedido(NoPedido, arreglo(l), 0)

                                            End If

                                        Next
                                        y = ds2.Tables(0).Rows.Count

                                    End If

                                    y = y + 1

                                End While

                            End If


                        End If

                        End If

                Next

            End If


        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function


    Public Function PushPedido(ByVal NoPedido As Integer, ByVal Id1 As Integer, ByVal Id2 As Integer)

        Try

            Dim sql As String = "Update " & My.Settings.Empresa & ".TEMP_SALDO_FIN set ""NOPEDIDO""=" & NoPedido & " where ""ID""=" & Id1
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)

            If Id2 <> 0 Then
                Dim sql2 As String = "Update " & My.Settings.Empresa & ".TEMP_SALDO_FIN set ""NOPEDIDO""=" & NoPedido & " where ""ID""=" & Id2
                ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql2)
            End If

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function


    Public Function DropTemp()

        Try

            Dim sql As String = "DROP TABLE " & My.Settings.Empresa & ".TEMP_SALDO_FIN"
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)

        Catch ex As System.Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

End Class
