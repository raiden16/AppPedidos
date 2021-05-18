Imports System.ComponentModel
Imports System.IO

Public Class Pedido
    Dim table As New DataTable
    Dim prov As String
    Public DataGrid As New DataGridView
    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableTemp()
        'cargar_Pedido()
        'NumeroPedidos()
        dgvPedidos.Columns("seleccion").ReadOnly = False
        dgvPedidos.Columns("proyecto").ReadOnly = False
        dgvPedidos.Columns(1).ReadOnly = True
        dgvPedidos.Columns(2).ReadOnly = True
        dgvPedidos.Columns(3).ReadOnly = True
        dgvPedidos.Columns(4).ReadOnly = True
        dgvPedidos.Columns(5).ReadOnly = True
        dgvPedidos.Columns(6).ReadOnly = True
        dgvPedidos.Columns(7).ReadOnly = True
        dgvPedidos.Columns(8).ReadOnly = True
    End Sub

    Private Sub cargar_Pedido()
        Try
            Dim result As New DataTable

            table.Columns.Add("Cantidad", GetType(String))
            table.Columns.Add("Articulo", GetType(String))

            For Each r As DataGridViewRow In DataGrid.Rows
                If (r.Cells("Pallet").Value <> Nothing And r.Cells("Pallet").Value <> "") Then

                    'If (r.Cells("Pallet").Value = 44) Then
                    '    prov = r.Cells("Codigo de Proveedor").Value
                    '    dgvPedidos.Rows.Add(False, "", r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, "22", r.Cells("Precio").Value, r.Cells("Estado").Value)
                    '    dgvPedidos.Rows.Add(False, "", r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, "22", r.Cells("Precio").Value, r.Cells("Estado").Value)
                    '    Dim articulo = r.Cells("Codigo").Value & "-" & r.Cells("Articulo").Value
                    '    table.Rows.Add(22, articulo)
                    '    table.Rows.Add(22, articulo)
                    'Else
                    prov = r.Cells("Codigo de Proveedor").Value
                    dgvPedidos.Rows.Add(False, "", r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, r.Cells("Pallet").Value, r.Cells("Precio").Value, r.Cells("Estado").Value, r.Cells("U_GroupTekno").Value)
                    Dim articulo = r.Cells("Codigo").Value & "-" & r.Cells("Articulo").Value
                    table.Rows.Add(r.Cells("Pallet").Value, articulo)
                    'End If
                End If
            Next
            'Comentario.DataSource = table
        Catch ex As Exception

        End Try

    End Sub

    Sub TableTemp()

        Dim resto, cantidad1, cantidad2, capacidad As Integer
        Dim group, estate As String
        Dim obj As New MethodHana()
        Dim pedido = 1
        Dim caso1, caso2, caso3, caso4 As Double
        Dim caso1I, caso2I, caso3I, caso4I As Integer
        Dim decimales1, decimales2, decimales3, decimales4 As Double
        Dim VV1 = 22
        Dim VV2 = 12
        Dim VV3 = 11
        Dim VV4 = 10

        Try

            ''Funcion Crear Tabla temp
            obj.CreateTemp()

            For Each r As DataGridViewRow In DataGrid.Rows

                If (r.Cells("Pallet").Value <> Nothing And r.Cells("Pallet").Value <> "") Then


                    prov = r.Cells("Codigo de Proveedor").Value
                    cantidad1 = r.Cells("Pallet").Value
                    'MsgBox(r.Cells("Codigo").Value & " " & cantidad1)
                    capacidad = obj.GetCapacidad(r.Cells("U_GroupTekno").Value)
                    group = r.Cells("U_GroupTekno").Value
                    cantidad2 = r.Cells("Pallet").Value
                    estate = r.Cells("Estado").Value


                    If capacidad = 22 Then

                        If (cantidad2 <= capacidad And (cantidad2 = VV1 Or cantidad2 = VV2 Or cantidad2 = VV3 Or cantidad2 = VV4)) Then

                            ''funcion llenar tabla temp
                            obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, cantidad2, r.Cells("Precio").Value, capacidad, group, estate)

                        Else

                            caso1 = cantidad1 / VV1
                            caso2 = cantidad1 / VV2
                            caso3 = cantidad1 / VV3
                            caso4 = cantidad1 / VV4

                            caso1I = cantidad1 / VV1
                            caso2I = cantidad1 / VV2
                            caso3I = cantidad1 / VV3
                            caso4I = cantidad1 / VV4

                            decimales1 = caso1 - caso1I
                            decimales2 = caso2 - caso2I
                            decimales3 = caso3 - caso3I
                            decimales4 = caso4 - caso4I

                            If decimales1 = 0 Then

                                For i = 0 To caso1I - 1

                                    obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, VV1, r.Cells("Precio").Value, capacidad, group, estate)

                                Next

                                decimales2 = 0.1
                                decimales3 = 0.1
                                decimales4 = 0.1


                            ElseIf decimales2 = 0 Then

                                For i = 0 To caso2I - 1

                                    obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, VV2, r.Cells("Precio").Value, capacidad, group, estate)

                                Next

                                decimales3 = 0.1
                                decimales4 = 0.1


                            ElseIf decimales3 = 0 Then

                                Dim residuo = caso3I Mod 2

                                If residuo = 0 Then

                                    caso3I = caso3I / 2

                                    For i = 0 To caso3I - 1

                                        obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, VV1, r.Cells("Precio").Value, capacidad, group, estate)

                                    Next

                                Else

                                    caso3I = caso3I - 1
                                    caso3I = caso3I / 2

                                    For i = 0 To caso3I - 1

                                        obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, VV1, r.Cells("Precio").Value, capacidad, group, estate)

                                    Next

                                    obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, VV3, r.Cells("Precio").Value, capacidad, group, estate)

                                End If

                                decimales4 = 0.1


                            ElseIf decimales4 = 0 Then

                                For i = 0 To caso4I - 1

                                    obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, VV4, r.Cells("Precio").Value, capacidad, group, estate)

                                Next

                            Else

                                While (cantidad1 > capacidad)

                                    resto = cantidad1 - capacidad
                                    ''funcion llenar tabla temp
                                    obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, capacidad, r.Cells("Precio").Value, capacidad, group, estate)

                                    If resto <= capacidad And resto > 0 Then
                                        'cantidad2 <= capacidad And (cantidad2 = VV1 Or cantidad2 = VV2 Or cantidad2 = VV3 Or cantidad2 = VV4)

                                        ''funcion llenar tabla temp
                                        obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, resto, r.Cells("Precio").Value, capacidad, group, estate)

                                    End If

                                    cantidad1 = cantidad1 - capacidad

                                End While

                            End If

                        End If

                    Else

                        While (cantidad1 > capacidad)

                            resto = cantidad1 - capacidad
                            ''funcion llenar tabla temp
                            obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, capacidad, r.Cells("Precio").Value, capacidad, group, estate)

                            If resto <= capacidad And resto > 0 Then

                                ''funcion llenar tabla temp
                                obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, resto, r.Cells("Precio").Value, capacidad, group, estate)

                            End If

                            cantidad1 = cantidad1 - capacidad

                        End While

                        While (cantidad2 <= capacidad And cantidad2 > 0)

                            ''funcion llenar tabla temp
                            obj.PushTemp(r.Cells("Codigo de Proveedor").Value, r.Cells("Codigo").Value, r.Cells("Articulo").Value, cantidad2, r.Cells("Precio").Value, capacidad, group, estate)
                            cantidad2 = 0

                        End While

                    End If

                End If

            Next

            ''funcion agregar pedido y acomodo
            obj.GetPedido()

            ''Funcion extraer tabla temp con pedidos y cantidades
            Dim sql As String = "Select * from " & My.Settings.Empresa & ".TEMP_SALDO_FIN order by ""NOPEDIDO"",""CANTIDAD"""
            Dim ds As DataSet
            ds = AccesoDBHANA.GetConexion.ejecutarQuery(sql)

            If ds.Tables(0).Rows.Count > 0 Then

                For i = 0 To ds.Tables(0).Rows.Count - 1

                    dgvPedidos.Rows.Add(False, ds.Tables(0).Rows(i).Item("NOPEDIDO").ToString, ds.Tables(0).Rows(i).Item("PROVEEDOR").ToString, ds.Tables(0).Rows(i).Item("CODIGO").ToString, ds.Tables(0).Rows(i).Item("ARTICULO").ToString, ds.Tables(0).Rows(i).Item("CANTIDAD").ToString, ds.Tables(0).Rows(i).Item("PRECIO").ToString, ds.Tables(0).Rows(i).Item("ESTADO").ToString, ds.Tables(0).Rows(i).Item("GRUPO").ToString)

                Next

            End If

            ''Funcion borrar tabla temp
            obj.DropTemp()

        Catch ex As Exception

            MessageBox.Show("Error en la tabla temporal: " + ex.Message)
            ''Funcion borrar tabla temp
            obj.DropTemp()

        End Try

    End Sub


    Sub NumeroPedidos()
        Dim NPedido As Integer = 1
        Dim Cantidad As Integer = 0
        Dim celdas As Integer = 0
        Dim obj As New MethodHana()
        Do While celdas < dgvPedidos.Rows.Count
            For Each r As DataGridViewRow In dgvPedidos.Rows
                If (r.Cells("noPedido").Value.ToString() = "" Or r.Cells("noPedido").Value.ToString() = "0") Then
                    If (Cantidad = 0) Then
                        Cantidad = r.Cells("Cantidad").Value
                        r.Cells("noPedido").Value = NPedido
                        celdas += 1
                        If (Cantidad = obj.GetCantidadContenedor(r.Cells("Grupo").Value)) Then
                            Cantidad = 0
                            NPedido += 1
                        ElseIf (Cantidad > obj.GetCantidadContenedor(r.Cells("Grupo").Value)) Then
                            r.Cells("Cantidad").Value = obj.GetCantidadContenedor(r.Cells("Grupo").Value)
                            r.Cells("noPedido").Value = NPedido

                            'If ((Cantidad - (obj.GetCantidadContenedor(r.Cells("Grupo").Value))) <= (obj.GetMinimoContenedor(r.Cells("Grupo").Value))) Then
                            '    MsgBox("Existen Articulos por debajo del minimo, del Grupo: " + r.Cells("Grupo").Value + ", verifique la informacion ingresada")
                            '    Me.Dispose()
                            '    Form1.RefrescarForm = 0
                            '    Form1.Show()
                            'End If

                            dgvPedidos.Rows.Add(CloneWithValues(r, (Cantidad - (obj.GetCantidadContenedor(r.Cells("Grupo").Value))), 0))
                            Cantidad = 0
                            NPedido += 1
                        End If
                    Else
                        If ((Cantidad + r.Cells("Cantidad").Value) / obj.GetCantidadContenedor(r.Cells("Grupo").Value)) = 1 Then 'cambio
                            r.Cells("noPedido").Value = NPedido
                            r.Cells("comentarios").Style.ForeColor = Color.White
                            r.Cells("referencia").Style.ForeColor = Color.White
                            NPedido += 1
                            celdas += 1
                            Cantidad = 0
                        ElseIf ((Cantidad + r.Cells("Cantidad").Value) / obj.GetCantidadContenedor(r.Cells("Grupo").Value)) > 1 Then
                            r.Cells("noPedido").Value = NPedido
                            r.Cells("comentarios").Style.ForeColor = Color.White
                            r.Cells("referencia").Style.ForeColor = Color.White
                            NPedido += 1
                            celdas += 2
                            'If (obj.GetCantidadContenedor(r.Cells("Grupo").Value) - Cantidad < (obj.GetMinimoContenedor(r.Cells("Grupo").Value)) Or (r.Cells("Cantidad").Value - (obj.GetCantidadContenedor(r.Cells("Grupo").Value) - Cantidad)) < (obj.GetMinimoContenedor(r.Cells("Grupo").Value))) Then
                            '    MsgBox("Existen Articulos por debajo del minimo, del Grupo: " + r.Cells("Grupo").Value + ", verifique la informacion ingresada")
                            '    Me.Dispose()
                            '    Form1.RefrescarForm = 0
                            '    Form1.Show()
                            'End If
                            dgvPedidos.Rows.Add(CloneWithValues(r, (r.Cells("Cantidad").Value - (obj.GetCantidadContenedor(r.Cells("Grupo").Value) - Cantidad)), 0))
                            r.Cells("Cantidad").Value = obj.GetCantidadContenedor(r.Cells("Grupo").Value) - Cantidad
                            Cantidad = (Cantidad + r.Cells("Cantidad").Value) - obj.GetCantidadContenedor(r.Cells("Grupo").Value)
                            dgvPedidos.Sort(dgvPedidos.Columns(8), ListSortDirection.Ascending)
                        ElseIf ((Cantidad + r.Cells("Cantidad").Value) / obj.GetCantidadContenedor(r.Cells("Grupo").Value)) < 1 Then 'cambio
                            r.Cells("noPedido").Value = NPedido
                            r.Cells("comentarios").Style.ForeColor = Color.White
                            r.Cells("referencia").Style.ForeColor = Color.White
                            celdas += 1
                            Cantidad = (Cantidad + r.Cells("Cantidad").Value)
                        End If
                    End If
                End If
            Next
        Loop
        dgvPedidos.Sort(dgvPedidos.Columns(1), ListSortDirection.Ascending)
    End Sub

    Public Function CloneWithValues(ByVal row As DataGridViewRow, ByVal cantidad As String, ByVal pedido As Integer) _
    As DataGridViewRow

        CloneWithValues = CType(row.Clone(), DataGridViewRow)
        For index As Int32 = 0 To row.Cells.Count - 1
            If index = 1 Then
                CloneWithValues.Cells(index).Value = pedido
            ElseIf index = 5 Then
                CloneWithValues.Cells(index).Value = cantidad
            Else
                CloneWithValues.Cells(index).Value = row.Cells(index).Value
            End If

        Next

    End Function

    Public Verificacion As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGeneraPedido.Click
        Try
            Dim total = 0
            Dim proyecto As String
            Dim objeto As New MethodHana()
            btnGeneraPedido.Enabled = False

            For Each r As DataGridViewRow In dgvPedidos.Rows

                Dim Cantidad As Integer = 0
                If Cantidad = 0 Then
                    Cantidad = r.Cells("Cantidad").Value
                End If
                If ((Cantidad) < (objeto.GetMinimoContenedor(r.Cells("Grupo").Value))) Then
                    MsgBox("Existen Articulos por debajo del minimo, del Grupo: " + r.Cells("Grupo").Value + ", verifique la informacion ingresada")
                    Exit Sub
                End If


                If (r.Cells(0).Value = True) Then
                    total = total + Int32.Parse(r.Cells("Cantidad").Value)
                End If

                If (r.Cells("proyecto").Value = True And r.Cells("referencia").Value = "") Then
                    MsgBox("Ingrese un numero de referencia")
                    btnGeneraPedido.Enabled = True
                    Exit Sub
                End If
            Next
            'Dim residuo = total Mod 22
            'If (residuo <> 0) Then
            '    MsgBox("No es posible generar el pedido porfavor verifique su informacion")
            'Else

            If total = 0 Then
                MsgBox("Seleccione los pedidos a generar")
                btnGeneraPedido.Enabled = True
                Exit Sub
            End If




            Dim obj As New LogicHana()
            Dim obj2 As New MethodHana()
            Dim result = obj.generar_pedido(dgvPedidos, prov)
            Dim E_Mail As String
            Dim contacto As String
            If (result = "True") Then

                E_Mail = obj2.GetEmailProveedor(prov)
                contacto = obj2.GetPersonaContProveedor(prov)

                If My.Settings.CorreoTest = String.Empty Then
                    enviarCorreo(E_Mail, contacto)
                Else
                    enviarCorreo(My.Settings.CorreoTest, contacto)
                End If

                If Enviado = 1 Then
                    Dim archivos() As String = Directory.GetFiles("c:\Reporte\Temp\")
                    For Each archivo In archivos
                        My.Computer.FileSystem.MoveFile(archivo, "C:\Reporte\" + archivo.Substring(16))
                    Next
                End If

                MsgBox("El pedido fue generado correctamente")

                For Row As Integer = Me.dgvPedidos.Rows.Count - 1 To 0 Step -1
                    If (dgvPedidos.Rows(Row).Cells(0).Value = True) Then
                        dgvPedidos.Rows.RemoveAt(Row)
                    End If
                Next

                'dgvPedidos.DataSource = Nothing
                'dgvPedidos.Rows.Clear()


                Verificacion = 1
                btnGeneraPedido.Enabled = True
            Else
                MsgBox("El pedido fue generado incorrectamente")
                btnGeneraPedido.Enabled = True
            End If

            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
            btnGeneraPedido.Enabled = True

        End Try

    End Sub


    Dim Enviado As Integer = 0

    Public Sub enviarCorreo(ByVal U_Correo As String, ByVal Contacto As String)
        Try
            Dim SMTP As String = My.Settings.ServidorCorreo 'lc_ServidorSMTP
            Dim Usuario As String = My.Settings.UsuarioCorreo 'lc_UsuarioCorreo
            Dim Contraseña As String = My.Settings.PasswordCorreo 'lc_ContraseñaCorreo
            Dim Puerto As Integer = CInt(My.Settings.PuertoSL)
            Dim correo As New System.Net.Mail.MailMessage()
            correo.From = New System.Net.Mail.MailAddress(Usuario)
            correo.Subject = My.Settings.AsuntoCorreo
            correo.Body = My.Settings.SaludoCorreo + " " + Contacto + vbCrLf + My.Settings.CuerpoCorreo
            correo.To.Add(U_Correo)
            correo.Bcc.Add(My.Settings.CorreoBitacora)
            Dim Servidor As New System.Net.Mail.SmtpClient
            Servidor.Host = SMTP
            Servidor.Port = Puerto
            'Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(U_Path)

            Dim archivos() As String = Directory.GetFiles("c:\Reporte\Temp\")

            For Each archivo In archivos

                Dim archivoAdjunto As New System.Net.Mail.Attachment(archivo)
                correo.Attachments.Add(archivoAdjunto)

            Next

            'correo.Attachments.Add(archivo)
            If My.Settings.UtilizarSSL Then 'SSL certificado de seguridad
                Servidor.EnableSsl = True
            Else
                Servidor.EnableSsl = False
            End If
            Servidor.Credentials = New System.Net.NetworkCredential(Usuario, Contraseña)
            Servidor.Send(correo)
            correo.Attachments.Dispose()
            Enviado = 1
        Catch ex As Exception
            MsgBox("Error al enviar correo:" & ex.Message)
            Enviado = 0
        End Try
    End Sub


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click


        dgvPedidos.DataSource = Nothing
        dgvPedidos.Rows.Clear()

        If Verificacion = 0 Then
            Me.Dispose()
            Form1.RefrescarForm = 0
            Form1.Show()
        Else
            Me.Dispose()
            Form1.RefrescarForm = 1
            Form1.dt_Global = Nothing
            Form1.dt_Resp = Nothing
            Form1.ComboProvedor.Refresh()
            Form1.dt_articulos.DataSource = Form1.dt_Global
            Form1.Show()
            Verificacion = 0
        End If


    End Sub

    Private Sub dgvPedidos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvPedidos.CellValidating

    End Sub

    Private Sub dgvPedidos_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellValidated
        Try

            If (e.ColumnIndex = 0) Then
                For Each r As DataGridViewRow In dgvPedidos.Rows
                    If (r.Cells("noPedido").Value = dgvPedidos.Rows(e.RowIndex).Cells("noPedido").Value) Then
                        r.Cells(0).Value = dgvPedidos.Rows(e.RowIndex).Cells(0).Value
                    End If
                Next
            End If
            If (e.ColumnIndex = 10) Then
                If (dgvPedidos.Rows(e.RowIndex).Cells("proyecto").Value) Then
                    dgvPedidos.Rows(e.RowIndex).Cells("referencia").ReadOnly = False
                Else
                    dgvPedidos.Rows(e.RowIndex).Cells("referencia").ReadOnly = True
                    dgvPedidos.Rows(e.RowIndex).Cells("referencia").Value = ""
                End If
                For Each r As DataGridViewRow In dgvPedidos.Rows
                    If (r.Cells("noPedido").Value = dgvPedidos.Rows(e.RowIndex).Cells("noPedido").Value) Then
                        r.Cells("proyecto").Value = dgvPedidos.Rows(e.RowIndex).Cells("proyecto").Value
                    End If
                Next
            End If
            If (e.ColumnIndex = 9) Then
                For Each r As DataGridViewRow In dgvPedidos.Rows
                    If (r.Cells("noPedido").Value = dgvPedidos.Rows(e.RowIndex).Cells("noPedido").Value) Then
                        r.Cells("comentarios").Value = dgvPedidos.Rows(e.RowIndex).Cells("comentarios").Value
                    End If
                Next
            End If
            If (e.ColumnIndex = 11) Then
                For Each r As DataGridViewRow In dgvPedidos.Rows
                    If (r.Cells("noPedido").Value = dgvPedidos.Rows(e.RowIndex).Cells("noPedido").Value) Then
                        r.Cells("referencia").Value = dgvPedidos.Rows(e.RowIndex).Cells("referencia").Value
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvPedidos_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPedidos.ColumnHeaderMouseDoubleClick
        If (e.ColumnIndex = 0) Then
            For Each r As DataGridViewRow In dgvPedidos.Rows
                If (r.Cells("seleccion").Value) Then
                    r.Cells("seleccion").Value = False
                ElseIf (r.Cells("seleccion").Value = False) Then
                    r.Cells("seleccion").Value = True
                End If
            Next
            dgvPedidos.Refresh()
        End If
    End Sub

    Private Sub CambiarNoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarNoPedidoToolStripMenuItem.Click

        ClonarDGV(frmCambiarPedido.dgvCambio, dgvPedidos.Rows(dgvPedidos.CurrentRow.Index).Cells("Cantidad").Value, dgvPedidos.CurrentRow.Index)

        frmCambiarPedido.indice = dgvPedidos.CurrentRow.Index
        frmCambiarPedido.pedidoAnt = dgvPedidos.Rows(dgvPedidos.CurrentRow.Index).Cells("noPedido").Value.ToString()
        frmCambiarPedido.Label1.Text = frmCambiarPedido.Label1.Text + " " + dgvPedidos.Rows(dgvPedidos.CurrentRow.Index).Cells("Codigo").Value.ToString()
        frmCambiarPedido.Label2.Text = frmCambiarPedido.Label2.Text + " " + dgvPedidos.Rows(dgvPedidos.CurrentRow.Index).Cells("articulo").Value.ToString()
        frmCambiarPedido.ShowDialog()
    End Sub


    Sub ClonarDGV(ByVal dgv2 As DataGridView, ByVal Cantidad As String, ByVal indice As Integer)

        Dim Valores() As String = {}

        ReDim Valores(dgvPedidos.ColumnCount)

        Dim Ndx As Integer = 0

        If (dgv2.Columns.Count = 0) Then
            For Each dgvcl As DataGridViewColumn In dgvPedidos.Columns
                dgv2.Columns.Add(dgvcl.Name, dgvcl.HeaderText)
            Next
        End If

        For Each row As DataGridViewRow In dgvPedidos.Rows
            If row.Cells("Cantidad").Value = Cantidad And row.Index <> indice Then
                For Ndx = 0 To dgvPedidos.ColumnCount - 1
                    If (Ndx = 0) Then
                        Valores(Ndx) = row.Index
                    Else
                        If (IsDBNull(row.Cells(Ndx).Value)) Then
                            Valores(Ndx) = ""
                        Else
                            Valores(Ndx) = row.Cells(Ndx).Value
                        End If
                    End If
                Next
                dgv2.Rows.Add(Valores)
            End If
        Next
    End Sub

    Private Sub btnRefresPrecio_Click(sender As Object, e As EventArgs) Handles btnRefresPrecio.Click
        Dim obj As New MethodHana()
        For Each r As DataGridViewRow In dgvPedidos.Rows
            r.Cells("precio").Value = obj.GetPrecioLista(r.Cells("codigo").Value) + obj.GetMonedaLista(r.Cells("codigo").Value)
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            For Each r As DataGridViewRow In dgvPedidos.SelectedRows
                Dim result = MessageBox.Show("¿Estas seguro de eliminar la linea del pedido?", "Elimar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    dgvPedidos.Rows.Remove(r)
                    btnGeneraPedido.Enabled = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error en la eliminaciòn de la linea: " + ex.Message)
        End Try
    End Sub

End Class