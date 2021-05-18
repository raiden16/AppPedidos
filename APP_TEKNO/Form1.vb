Imports System.ComponentModel

Public Class Form1

    Public dt_Global As New DataTable()
    Public dt_Resp As New DataTable()
    Public RefrescarForm As Integer = 0

    Private Sub columnsGrid_Articulos()


        Dim ItemCode = New DataGridViewTextBoxColumn()
        ItemCode.Name = "Codigo"
        ItemCode.DataPropertyName = "ItemCode"
        ItemCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        ItemCode.Frozen = True
        ItemCode.ReadOnly = True
        'ItemCode.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim ItemName = New DataGridViewTextBoxColumn()
        ItemName.Name = "Articulo"
        ItemName.DataPropertyName = "ItemName"
        ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        ItemName.Frozen = True
        ItemName.ReadOnly = True
        ItemName.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim CardCode = New DataGridViewTextBoxColumn()
        CardCode.Name = "Codigo de Proveedor"
        CardCode.DataPropertyName = "CardCode"
        CardCode.ReadOnly = True
        CardCode.Visible = False
        CardCode.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Estado = New DataGridViewTextBoxColumn()
        Estado.Name = "Estado"
        Estado.DataPropertyName = "Estado"
        Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Estado.ReadOnly = True
        Estado.Visible = False
        Estado.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Pallet = New DataGridViewTextBoxColumn()
        Pallet.Name = "Pallet"
        Pallet.DataPropertyName = "Pallet"
        Pallet.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Pallet.ReadOnly = False
        Pallet.Frozen = True
        Pallet.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Sugerido = New DataGridViewTextBoxColumn()
        Sugerido.Name = "Sugerido"
        Sugerido.DataPropertyName = "Sugerido"
        Sugerido.ReadOnly = True
        Sugerido.Visible = False
        Sugerido.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Faltante = New DataGridViewTextBoxColumn()
        Faltante.Name = "Faltante"
        Faltante.DataPropertyName = "Faltante"
        Faltante.ReadOnly = True
        Faltante.Visible = False
        Faltante.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Actual = New DataGridViewTextBoxColumn()
        Actual.Name = "Actual"
        Actual.DataPropertyName = "Actual"
        Actual.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Actual.ReadOnly = True
        Actual.SortMode = DataGridViewColumnSortMode.NotSortable
        Actual.DefaultCellStyle.Format = "#,##0,00"
        Dim Pedido = New DataGridViewTextBoxColumn()
        Pedido.Name = "Pedido"
        Pedido.DataPropertyName = "Pedido"
        Pedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Pedido.ReadOnly = True
        'Pedido.DefaultCellStyle.Format = "F2"
        Pedido.DefaultCellStyle.Format = "#,##0,00"
        Pedido.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Pendiente = New DataGridViewTextBoxColumn()
        Pendiente.Name = "Pendiente"
        Pendiente.DataPropertyName = "Pendiente"
        Pendiente.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Pendiente.ReadOnly = True
        Pendiente.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Total = New DataGridViewTextBoxColumn()
        Total.Name = "Total"
        Total.DataPropertyName = "Total"
        Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Total.ReadOnly = True
        Total.SortMode = DataGridViewColumnSortMode.NotSortable
        Total.DefaultCellStyle.Format = "#,##0,00"
        Dim Consumo = New DataGridViewTextBoxColumn()
        Consumo.Name = "ConsumoMensual"
        Consumo.DataPropertyName = "ConsumoMensual"
        Consumo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Consumo.ReadOnly = True
        Consumo.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Porcentaje = New DataGridViewTextBoxColumn()
        Porcentaje.Name = "%"
        Porcentaje.DataPropertyName = "Porcentaje"
        Porcentaje.ReadOnly = True
        Porcentaje.Visible = False
        Porcentaje.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim MesesInversionBodega = New DataGridViewTextBoxColumn()
        MesesInversionBodega.Name = "Meses Inversion Bodega"
        MesesInversionBodega.DataPropertyName = "MesesBod"
        MesesInversionBodega.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MesesInversionBodega.ReadOnly = True
        MesesInversionBodega.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim MesesInversionReal = New DataGridViewTextBoxColumn()
        MesesInversionReal.Name = "Meses Inversion Real"
        MesesInversionReal.DataPropertyName = "MesesInv"
        MesesInversionReal.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MesesInversionReal.ReadOnly = True
        MesesInversionReal.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.5, FontStyle.Bold)
        MesesInversionReal.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Custom0 = New DataGridViewTextBoxColumn()
        Custom0.Name = "Semanas"
        Custom0.DataPropertyName = "Custom0"
        Custom0.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Custom0.ReadOnly = True
        Custom0.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Custom1 = New DataGridViewTextBoxColumn()
        Custom1.Name = "Verificacion 1"
        Custom1.DataPropertyName = "Custom1"
        Custom1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Custom1.ReadOnly = True
        Custom1.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Custom2 = New DataGridViewTextBoxColumn()
        Custom2.Name = "Verificacion 2"
        Custom2.DataPropertyName = "Custom2"
        Custom2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Custom2.ReadOnly = True
        Custom2.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Custom3 = New DataGridViewTextBoxColumn()
        Custom3.Name = "Verificacion 3"
        Custom3.DataPropertyName = "Custom3"
        Custom3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Custom3.ReadOnly = True
        Custom3.SortMode = DataGridViewColumnSortMode.NotSortable


        Dim Precio = New DataGridViewTextBoxColumn()
        Precio.Name = "Precio"
        Precio.DataPropertyName = "Precio"
        'Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Precio.ReadOnly = True
        Precio.Visible = False
        Precio.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim GrupoTekno = New DataGridViewTextBoxColumn()
        GrupoTekno.Name = "U_GroupTekno"
        GrupoTekno.DataPropertyName = "U_GroupTekno"
        GrupoTekno.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrupoTekno.ReadOnly = True
        GrupoTekno.Frozen = True
        GrupoTekno.Visible = True
        GrupoTekno.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim CantidadPaquete = New DataGridViewTextBoxColumn()
        CantidadPaquete.Name = "CantidadPaquete"
        CantidadPaquete.DataPropertyName = "CantidadPaquete"
        CantidadPaquete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        CantidadPaquete.ReadOnly = True
        CantidadPaquete.Visible = False
        CantidadPaquete.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim CajaPallet = New DataGridViewTextBoxColumn()
        CajaPallet.Name = "CajaPallet"
        CajaPallet.DataPropertyName = "CajaPallet"
        CajaPallet.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        CajaPallet.ReadOnly = True
        CajaPallet.Visible = False
        CajaPallet.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim NoPedido = New DataGridViewTextBoxColumn()
        NoPedido.Name = "NoPedido"
        NoPedido.DataPropertyName = "NoPedido"
        NoPedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        NoPedido.ReadOnly = True
        'NoPedido.Visible = False
        NoPedido.SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Cond = New DataGridViewCheckBoxColumn()
        Cond.Name = "Cond"
        Cond.DataPropertyName = "Cond"
        Cond.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Cond.ReadOnly = True
        'Cond.Visible = False
        Cond.SortMode = DataGridViewColumnSortMode.NotSortable

        dt_articulos.Columns.Add(GrupoTekno)
        dt_articulos.Columns.Add(ItemCode)
        dt_articulos.Columns.Add(ItemName)
        dt_articulos.Columns.Add(CardCode)
        dt_articulos.Columns.Add(Estado)
        dt_articulos.Columns.Add(Pallet)
        dt_articulos.Columns.Add(Sugerido)
        dt_articulos.Columns.Add(Faltante)
        dt_articulos.Columns.Add(Actual)
        dt_articulos.Columns.Add(Pedido)
        dt_articulos.Columns.Add(Pendiente)
        dt_articulos.Columns.Add(Total)
        dt_articulos.Columns.Add(Consumo)
        dt_articulos.Columns.Add(Porcentaje)
        dt_articulos.Columns.Add(MesesInversionBodega)
        dt_articulos.Columns.Add(MesesInversionReal)
        dt_articulos.Columns.Add(Custom0)
        dt_articulos.Columns.Add(Custom1)
        dt_articulos.Columns.Add(Custom2)
        dt_articulos.Columns.Add(Custom3)
        dt_articulos.Columns.Add(Precio)
        dt_articulos.Columns.Add(CantidadPaquete)
        dt_articulos.Columns.Add(CajaPallet)
        dt_articulos.Columns.Add(NoPedido)
        dt_articulos.Columns.Add(Cond)

    End Sub

    Private Sub btn_cargar(sender As Object, e As EventArgs) Handles Button1.Click

        If noPedido_ > 0 Then
            noPedido_ = 0
        End If

        If (ComboProvedor.SelectedValue().Equals("0")) Then
            MsgBox("Porfavor seleccione un Proveedor")
        Else
            dt_articulos.DataSource = Nothing
            dt_articulos.Columns.Clear()
            dt_articulos.Rows.Clear()

            Dim obj As New LogicHana()
            dt_articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Dim proveedor As String
            proveedor = ComboProvedor.SelectedValue()
            Dim fecha1 = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            Dim fecha2 = DateTimePicker2.Value.ToString("yyyy-MM-dd")


            dt_Global = obj.getArticulos(proveedor, fecha1, fecha2)
            dt_Resp = obj.getArticulos(proveedor, fecha1, fecha2)
            If (dt_Global.Rows.Count > 0) Then
                columnsGrid_Articulos()
                dt_articulos.DataSource = dt_Global
                'dt_articulos.Sort(dt_articulos.Columns("U_GroupTekno"), ListSortDirection.Ascending)
                'PintarLineas()
            End If
        End If

    End Sub

    Sub PintarLineas(ByVal accion As Integer)

        If accion = 1 Then
            Dim MesesInvReal As String
            For Each r As DataGridViewRow In dt_articulos.Rows

                MesesInvReal = CDbl(r.Cells("Meses Inversion Real").Value).ToString("00.0")
                Dim celda As DataGridViewCell = r.Cells.Item("Meses Inversion Real")


                If (MesesInvReal <= My.Settings.RangoRojoMin And MesesInvReal <= My.Settings.RangoRojoMax) Then
                    celda.Style.BackColor = Color.Red
                    'r.DefaultCellStyle.BackColor = Color.Red
                ElseIf (MesesInvReal >= My.Settings.RangoRojoMin And MesesInvReal <= My.Settings.RangoRojoMax) Then
                    celda.Style.BackColor = Color.Red
                    'r.DefaultCellStyle.BackColor = Color.Red
                ElseIf (MesesInvReal >= My.Settings.RangoAmarilloMin And MesesInvReal <= My.Settings.RangoAmarilloMax) Then
                    celda.Style.BackColor = Color.Yellow
                    'r.DefaultCellStyle.BackColor = Color.Yellow
                ElseIf (MesesInvReal >= My.Settings.RangoVerdeMin And MesesInvReal <= My.Settings.RangoVerdeMax) Then
                    celda.Style.BackColor = Color.LightGreen
                    'r.DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        ElseIf accion = 0 Then
            For Each r As DataGridViewRow In dt_articulos.Rows
                Dim celda As DataGridViewCell = r.Cells.Item("Meses Inversion Real")
                celda.Style.BackColor = Color.White
                r.DefaultCellStyle.BackColor = Color.White
            Next
        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarProveedor()
            DateTimePicker1.Value = Now.AddMonths(-My.Settings.Meses)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cargarProveedor()
        Dim dt = New DataTable()
        Dim obj As New MethodHana()
        dt = obj.getProveedor()
        Dim dr = dt.NewRow()
        dr("CardCode") = "0"
        dr("CardName") = "Seleccione un Proveedor"
        dt.Rows.InsertAt(dr, 0)
        ComboProvedor.DataSource = dt
        ComboProvedor.DisplayMember = "CardName"
        ComboProvedor.ValueMember = "CardCode"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Where is the try????
        Try
            Dim total = 0
            Dim obj As New MethodHana()
            Dim residuofinal As Integer
            Dim VV1 = 22
            Dim VV2 = 12
            Dim VV3 = 11
            Dim VV4 = 10
            If (dt_articulos.Rows.Count > 0) Then
                For Each r As DataGridViewRow In dt_articulos.Rows
                    If (r.Cells("Pallet").Value.ToString().Trim() <> "") Then
                        total = total + Int32.Parse(r.Cells("Pallet").Value)
                    End If
                Next
                If (total = 0) Then
                    MsgBox("No se ha ingresado ningun Pallet para los Pedidos")
                    Exit Sub
                End If

                For Each r As DataGridViewRow In dt_articulos.Rows
                    If (r.Cells("Pallet").Value.ToString().Trim() <> "" And r.Cells("U_GroupTekno").Value.ToString().Trim() = "") Then
                        MsgBox("El articulo: " + r.Cells("Codigo").Value.ToString() + " no tiene asignado un grupo")
                        Exit Sub
                    End If
                Next


                dt_articulos.Sort(dt_articulos.Columns("U_GroupTekno"), ListSortDirection.Ascending)
                Dim Grupo As String = ""
                Dim TotalGrupo As Integer
                Dim CantidadContenedor As Integer
                For Each r As DataGridViewRow In dt_articulos.Rows
                    If (r.Cells("Pallet").Value.ToString().Trim() <> "" And r.Cells("U_GroupTekno").Value.ToString().Trim() <> "") Then
                        If Grupo = "" Then
                            Grupo = r.Cells("U_GroupTekno").Value.ToString()
                        End If



                        If Grupo <> r.Cells("U_GroupTekno").Value.ToString() Then
                            CantidadContenedor = obj.GetCantidadContenedor(Grupo)
                            If obj.GetMandatoryContenedor(Grupo) = 1 Then
                                Dim residuo = TotalGrupo Mod CantidadContenedor
                                If (residuo <> 0) Then
                                    residuofinal = CantidadContenedor - residuo
                                    If CantidadContenedor = 22 Then
                                        If (residuofinal = VV2 Or residuofinal = VV3 Or residuofinal = VV4 Or residuofinal = 20) Then

                                            MsgBox("Faltan " + (CantidadContenedor - residuo).ToString() + " Pallets del grupo: " + Grupo + ", para generar pedidos completos")
                                            'MsgBox("Faltan Pallets para generar pedidos completos")
                                            Exit Sub
                                        Else

                                            MsgBox("Faltan " + (CantidadContenedor - residuo).ToString() + " Pallets del grupo: " + Grupo + ", para generar pedidos completos")
                                            'MsgBox("Faltan Pallets para generar pedidos completos")
                                            Exit Sub

                                        End If
                                    Else

                                        MsgBox("Faltan " + (CantidadContenedor - residuo).ToString() + " Pallets del grupo: " + Grupo + ", para generar pedidos completos")
                                        'MsgBox("Faltan Pallets para generar pedidos completos")
                                        Exit Sub

                                    End If
                                Else
                                End If
                            End If
                            Grupo = r.Cells("U_GroupTekno").Value.ToString()
                            TotalGrupo = Int32.Parse(r.Cells("Pallet").Value)
                        Else
                            TotalGrupo = TotalGrupo + Int32.Parse(r.Cells("Pallet").Value)
                        End If



                    End If
                Next

                If obj.GetMandatoryContenedor(Grupo) = 1 Then
                    CantidadContenedor = obj.GetCantidadContenedor(Grupo)
                    Dim residuo = TotalGrupo Mod obj.GetCantidadContenedor(Grupo)
                    If (residuo <> 0) Then
                        residuofinal = CantidadContenedor - residuo
                        If CantidadContenedor = 22 Then
                            If (residuofinal = VV2 Or residuofinal = VV3 Or residuofinal = VV4 Or residuofinal = 20) Then
                                MsgBox("Faltan " + (CantidadContenedor - residuo).ToString() + " Pallets del grupo: " + Grupo + ", para generar pedidos completos")
                                'MsgBox("Faltan Pallets para generar pedidos completos")
                                Exit Sub
                            Else
                                MsgBox("Faltan " + (CantidadContenedor - residuo).ToString() + " Pallets del grupo: " + Grupo + ", para generar pedidos completos")
                                'MsgBox("Faltan Pallets para generar pedidos completos")
                                Exit Sub
                            End If
                        Else

                            MsgBox("Faltan " + (CantidadContenedor - residuo).ToString() + " Pallets del grupo: " + Grupo + ", para generar pedidos completos")
                            'MsgBox("Faltan Pallets para generar pedidos completos")
                            Exit Sub

                        End If
                    Else
                    End If
                End If



                For Each r As DataGridViewRow In dt_articulos.Rows

                    Dim capacidad, resto As Integer
                    capacidad = obj.GetCapacidad(r.Cells("U_GroupTekno").Value)

                    If capacidad = "22" Then

                        If r.Cells("Pallet").Value.ToString().Trim() <> "" Then

                            If r.Cells("Pallet").Value > 22 Then

                                Dim caso1, caso2, caso3, caso4 As Double
                                Dim caso1I, caso2I, caso3I, caso4I, faltante1, faltante2 As Integer
                                Dim decimales1, decimales2, decimales3, decimales4 As Double
                                Dim cantidad = r.Cells("Pallet").Value
                                Dim cantidad2 = r.Cells("Pallet").Value

                                caso1 = cantidad / VV1
                                caso2 = cantidad / VV2
                                caso3 = cantidad / VV3
                                caso4 = cantidad / VV4

                                caso1I = cantidad / VV1
                                caso2I = cantidad / VV2
                                caso3I = cantidad / VV3
                                caso4I = cantidad / VV4

                                decimales1 = caso1 - caso1I
                                decimales2 = caso2 - caso2I
                                decimales3 = caso3 - caso3I
                                decimales4 = caso4 - caso4I

                                If decimales1 <> 0 And decimales2 <> 0 And decimales3 <> 0 And decimales4 <> 0 Then

                                    While (cantidad2 > capacidad)

                                        resto = cantidad2 - capacidad
                                        cantidad2 = cantidad2 - capacidad

                                    End While

                                    If (resto <> VV1 And resto <> VV2 And resto <> VV3 And resto <> VV4) Then

                                        caso1I = caso1I + 1
                                        caso2I = caso2I + 1

                                        faltante1 = (caso1I * VV1) - cantidad
                                        faltante2 = (caso2I * VV3) - cantidad

                                        If faltante2 < faltante1 Then

                                            MsgBox("El articulo " & r.Cells("Codigo").Value & " con cantidad de " & r.Cells("Pallet").Value & " no es un multiplo de los valores validos, favor de agregarle " & faltante2)
                                            Exit Sub

                                        Else

                                            MsgBox("El articulo " & r.Cells("Codigo").Value & " con cantidad de " & r.Cells("Pallet").Value & " no es un multiplo de los valores validos, favor de agregarle " & faltante1)
                                            Exit Sub

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                Next


                dt_articulos.Sort(dt_articulos.Columns("NoPedido"), ListSortDirection.Ascending)

                    Me.Hide()
                    Pedido.DataGrid = dt_articulos
                    Pedido.Show()
                Else
                    MsgBox("No se ha seleccionado ningun Pallet para los Pedidos")
            End If
        Catch ex As Exception

            MsgBox("Error en Boton Pedido: " & ex.Message)

        End Try
    End Sub

    Private Sub dt_articulos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dt_articulos.CellFormatting
        Try
            If ((e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 11) And e.RowIndex <> dt_articulos.NewRowIndex) Then



                Dim d = Double.Parse(e.Value.ToString())

                e.Value = d.ToString("N2")
            End If

        Catch ex As Exception

        End Try



    End Sub



    Dim Verifica As Integer = 0


    Private Sub dt_articulos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dt_articulos.CellValueChanged


    End Sub

    Private Sub dt_articulos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dt_articulos.CellBeginEdit
        If e.ColumnIndex = 5 Then
            'MsgBox("Detected First Column" & dt_articulos.Rows(e.RowIndex).Cells("Pallet").Value)
            'End If

            If dt_articulos.Rows(e.RowIndex).Cells("Pallet").Value <> "" Then
                For Each r As DataGridViewRow In dt_articulos.Rows
                    If (r.Cells("NoPedido").Value.ToString() = dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value And r.Cells("Cond").Value = 1 And e.RowIndex <> r.Index) Then
                        r.Cells("Cond").Value = False
                        dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 0
                        dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = 0
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Dim noPedido_ As Integer = 0

    Function CantidadAcumPedGrup(ByVal Grupo As String, ByVal Index As Integer, ByVal NPedido As Integer) As Integer
        Dim Cant As Integer
        For Each r As DataGridViewRow In dt_articulos.Rows
            'If r.Index = 23 Then
            '    MsgBox("Aqui")
            'End If
            If (r.Cells("U_GroupTekno").Value.ToString() <> "" And r.Cells("Pallet").Value.ToString() <> "" And r.Cells("U_GroupTekno").Value.ToString() = Grupo And r.Cells("Cond").Value = Nothing And r.Cells("NoPedido").Value = NPedido And Index <> r.Index) Then

                Cant = Cant + Integer.Parse(r.Cells("Pallet").Value)

            End If
        Next
        Return Cant
    End Function


    Private Sub dt_articulos_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dt_articulos.CellValidated
        Try

            'dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 0
            'dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = False

            Dim Pallet = dt_articulos.Rows(e.RowIndex).Cells("Pallet").Value.ToString()
            If Pallet = "" Then
                Pallet = 0
            End If

            If RefrescarForm = 0 Then

                If (e.ColumnIndex = 5) Then

                    Dim articulo = dt_articulos.Rows(e.RowIndex).Cells("Codigo").Value.ToString()
                    Dim qry = (From myDataRow In dt_Resp.AsEnumerable() Where myDataRow.Field(Of String)("ItemCode") = articulo)

                    Dim result = qry.CopyToDataTable()
                    Dim row As DataRow = result.Rows(0)

                    dt_articulos.Rows(e.RowIndex).Cells("Pedido").Value = CStr(row("Pedido"))
                    dt_articulos.Rows(e.RowIndex).Cells("Total").Value = CStr(row("Total"))
                    dt_articulos.Rows(e.RowIndex).Cells("Meses Inversion Bodega").Value = CStr(row("MesesBod"))
                    dt_articulos.Rows(e.RowIndex).Cells("Meses Inversion Real").Value = CStr(row("MesesInv"))
                    dt_articulos.Rows(e.RowIndex).Cells("Verificacion 1").Value = CStr(row("Custom1"))
                    dt_articulos.Rows(e.RowIndex).Cells("Verificacion 2").Value = CStr(row("Custom2"))
                    dt_articulos.Rows(e.RowIndex).Cells("Verificacion 3").Value = CStr(row("Custom3"))
                    dt_articulos.Rows(e.RowIndex).Cells("CantidadPaquete").Value = CStr(row("CantidadPaquete"))
                    dt_articulos.Rows(e.RowIndex).Cells("Actual").Value = CStr(row("Actual"))
                    If (IsDBNull(row("CajaPallet")) = True) Then
                        row("CajaPallet") = "0"
                    End If
                    dt_articulos.Rows(e.RowIndex).Cells("CajaPallet").Value = CStr(row("CajaPallet"))
                    dt_articulos.Rows(e.RowIndex).Cells("ConsumoMensual").Value = CStr(row("ConsumoMensual"))



                    ''Dim Pedido = dt_articulos.Rows(e.RowIndex).Cells("Pedido").Value.ToString()
                    Dim Actual = CStr(row("Actual")) 'dt_articulos.Rows(e.RowIndex).Cells("Actual").Value.ToString()
                    Dim Grupo = dt_articulos.Rows(e.RowIndex).Cells("U_GroupTekno").Value.ToString()

                    Dim obj As New MethodHana()

                    Dim Maximo = obj.GetMaximoContenedor(Grupo)
                    Dim Minimo = obj.GetMinimoContenedor(Grupo)

                    If (Integer.Parse(Pallet) < Minimo Or Integer.Parse(Pallet) > Maximo) Then


                        If dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value <> 0 Then
                            For Each r As DataGridViewRow In dt_articulos.Rows
                                If r.Cells("NoPedido").Value = dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value Then
                                    'r.Cells("NoPedido").Value = 0
                                    r.Cells("Cond").Value = False
                                End If
                            Next
                        End If


                        dt_articulos.Rows(e.RowIndex).Cells("Pallet").Value = ""
                        dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 0
                        dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = False
                        Exit Sub
                    Else
                        If (Pallet = "") Then
                            Pallet = "0"
                        End If
                        If (e.ColumnIndex = 5) Then

                            Dim MesesInvAnt = dt_articulos.Rows(e.RowIndex).Cells("Meses Inversion Bodega").Value.ToString()
                            Dim CantidadPaquete = dt_articulos.Rows(e.RowIndex).Cells("CantidadPaquete").Value.ToString()
                            Dim CajasporPallet = dt_articulos.Rows(e.RowIndex).Cells("CajaPallet").Value.ToString()
                            Dim consumoMens = dt_articulos.Rows(e.RowIndex).Cells("ConsumoMensual").Value.ToString()
                            Dim Pedido = dt_articulos.Rows(e.RowIndex).Cells("Pedido").Value.ToString()
                            Dim formulaPallet = 0
                            If (dt_articulos.Rows(e.RowIndex).Cells("U_GroupTekno").Value.ToString().Contains("TAPE")) Then
                                formulaPallet = (Pallet * CantidadPaquete * 1)
                            Else
                                formulaPallet = (Pallet * CantidadPaquete * CajasporPallet)
                            End If

                            Dim total_pedido = Double.Parse(Pedido) + Double.Parse(formulaPallet)
                            ''Double.Parse(Pedido) + Double.Parse(Pallet)
                            dt_articulos.Rows(e.RowIndex).Cells("Pedido").Value = total_pedido.ToString("000.00")
                            dt_articulos.Rows(e.RowIndex).Cells("Total").Value = (Double.Parse(Actual) + total_pedido).ToString("000.00")
                            Dim Total = Double.Parse(Actual) + total_pedido
                            Dim MesesBod As Double = Math.Round(Double.Parse(Total) / Double.Parse(consumoMens), 2, MidpointRounding.ToEven)
                            ' Dim MesesBod = Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Total").Value) / Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("ConsumoMensual").Value)
                            If (Double.IsInfinity(MesesBod) Or Double.IsNaN(MesesBod)) Then
                                MesesBod = 0
                            End If
                            dt_articulos.Rows(e.RowIndex).Cells("Meses Inversion Bodega").Value = MesesBod.ToString()

                            Dim inversionReal = Math.Round((((Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Meses Inversion Bodega").Value) * 4) - Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Semanas").Value)) / 4), 2, MidpointRounding.ToEven)
                            If (Double.IsInfinity(inversionReal) Or Double.IsNaN(inversionReal)) Then
                                inversionReal = 0
                            End If
                            dt_articulos.Rows(e.RowIndex).Cells("Meses Inversion Real").Value = inversionReal

                            Dim verificacion1 = Math.Round((Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Actual").Value) / Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("ConsumoMensual").Value)), 2, MidpointRounding.ToEven)
                            If (Double.IsInfinity(verificacion1) Or Double.IsNaN(verificacion1)) Then
                                verificacion1 = 0
                            End If
                            dt_articulos.Rows(e.RowIndex).Cells("Verificacion 1").Value = verificacion1
                            Dim verificacion2 = Math.Round((Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Pedido").Value) / Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("ConsumoMensual").Value)), 2, MidpointRounding.ToEven)
                            If (Double.IsInfinity(verificacion2) Or Double.IsNaN(verificacion2)) Then
                                verificacion2 = 0
                            End If
                            dt_articulos.Rows(e.RowIndex).Cells("Verificacion 2").Value = verificacion2
                            Dim verificacion3 = Math.Round((Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Verificacion 1").Value) + Double.Parse(dt_articulos.Rows(e.RowIndex).Cells("Verificacion 2").Value)), 2, MidpointRounding.ToEven)
                            If (Double.IsInfinity(verificacion3) Or Double.IsNaN(verificacion3)) Then
                                verificacion3 = 0
                            End If
                            dt_articulos.Rows(e.RowIndex).Cells("Verificacion 3").Value = verificacion3
                        End If
                    End If

                    'If dt_articulos.Rows(e.RowIndex).Cells("Pallet").Value.ToString() <> "0" Then
                    '    dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 1
                    '    dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = True

                    'End If

                    If Pallet = 0 Then
                        dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 0
                        dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = False
                    Else
                        Dim Grupo1 As String
                        Dim obj1 As New MethodHana()
                        Dim CantidadContenedor As Integer
                        Dim MinimoContenedor As Integer
                        'Dim CantidadAcumGrupo As Integer
                        Grupo1 = dt_articulos.Rows(e.RowIndex).Cells("U_GroupTekno").Value.ToString()
                        CantidadContenedor = obj1.GetCantidadContenedor(Grupo1)
                        MinimoContenedor = obj1.GetMinimoContenedor(Grupo1)
                        If (noPedido_ = 0) Then
                            If (Pallet = CantidadContenedor Or (Pallet Mod CantidadContenedor) = 0) Then
                                dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 1
                                dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = True
                                noPedido_ = noPedido_ + 2
                                Exit Sub
                            Else
                                dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = 1
                                noPedido_ = noPedido_ + 2
                            End If
                        Else

                            If (Pallet = CantidadContenedor Or (Pallet Mod CantidadContenedor) = 0) Then
                                dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = noPedido_
                                dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = True
                                noPedido_ = noPedido_ + 1
                                Exit Sub
                            End If

                            For Each r As DataGridViewRow In dt_articulos.Rows
                                If (r.Cells("Pallet").Value <> "" And r.Cells("U_GroupTekno").Value.ToString() = dt_articulos.Rows(e.RowIndex).Cells("U_GroupTekno").Value.ToString() And r.Cells("Cond").Value = False And e.RowIndex <> r.Index And dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = False) Then
                                    If (Integer.Parse(Pallet) + CantidadAcumPedGrup(Grupo1, e.RowIndex, r.Cells("NoPedido").Value)) = CantidadContenedor Then
                                        dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = r.Cells("NoPedido").Value
                                        r.Cells("Cond").Value = True
                                        dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = True
                                        noPedido_ = noPedido_ + 1
                                        Exit Sub
                                    ElseIf (CantidadContenedor - (Integer.Parse(Pallet) + CantidadAcumPedGrup(Grupo1, e.RowIndex, r.Cells("NoPedido").Value))) >= MinimoContenedor Then
                                        dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = r.Cells("NoPedido").Value
                                        noPedido_ = noPedido_ + 1
                                        Exit Sub
                                    ElseIf r.Cells("Pallet").Value > CantidadContenedor And ((r.Cells("Pallet").Value + Integer.Parse(Pallet)) Mod CantidadContenedor) = 0 Then
                                        dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = noPedido_ * 100
                                        r.Cells("NoPedido").Value = noPedido_ * 100
                                        r.Cells("Cond").Value = True
                                        dt_articulos.Rows(e.RowIndex).Cells("Cond").Value = True
                                        noPedido_ = noPedido_ + 1
                                    Else
                                        'dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = noPedido_
                                        'noPedido_ = noPedido_ + 1
                                        'Exit Sub
                                    End If
                                End If
                            Next

                            If dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = "0" Then
                                dt_articulos.Rows(e.RowIndex).Cells("NoPedido").Value = noPedido_
                                noPedido_ = noPedido_ + 1
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("error ", ex.StackTrace)
        End Try
    End Sub

    Private Sub dt_articulos_EditingControlShowing(
        ByVal sender As Object,
        ByVal e As DataGridViewEditingControlShowingEventArgs) _
            Handles dt_articulos.EditingControlShowing

        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub

    Private Sub validar_Keypress(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = dt_articulos.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3  
        If columna = 3 Then

            ' Obtener caracter  
            Dim caracter As Char = e.KeyChar

            ' comprobar si el caracter es un número o el retroceso  
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar  
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConfiguracion.ShowDialog()
    End Sub

    Private Sub dt_articulos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dt_articulos.ColumnHeaderMouseClick
        'PintarLineas()
        If chbxPintar.Checked = True Then
            chbxPintar.Checked = False
        End If
    End Sub

    Private Sub chbxPintar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPintar.CheckedChanged
        If chbxPintar.Checked = True Then
            PintarLineas(1)
        ElseIf chbxPintar.Checked = False Then
            PintarLineas(0)
        End If
    End Sub
End Class
