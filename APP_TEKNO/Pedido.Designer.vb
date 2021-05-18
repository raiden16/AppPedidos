<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.Seleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.noPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proyecto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnsCambiarPedido = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarNoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGeneraPedido = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRefresPrecio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnsCambiarPedido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccion, Me.noPedido, Me.Proveedor, Me.Codigo, Me.Articulo, Me.Cantidad, Me.precio, Me.Estado, Me.grupo, Me.comentarios, Me.proyecto, Me.referencia})
        Me.dgvPedidos.ContextMenuStrip = Me.cmnsCambiarPedido
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPedidos.Location = New System.Drawing.Point(14, 194)
        Me.dgvPedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.Size = New System.Drawing.Size(1003, 296)
        Me.dgvPedidos.TabIndex = 0
        '
        'Seleccion
        '
        Me.Seleccion.HeaderText = "Seleccion"
        Me.Seleccion.Name = "Seleccion"
        '
        'noPedido
        '
        Me.noPedido.HeaderText = "No. Pedido"
        Me.noPedido.Name = "noPedido"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 65
        '
        'Articulo
        '
        Me.Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Width = 67
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = False
        '
        'grupo
        '
        Me.grupo.HeaderText = "Grupo"
        Me.grupo.Name = "grupo"
        Me.grupo.ReadOnly = True
        '
        'comentarios
        '
        Me.comentarios.HeaderText = "Comentarios"
        Me.comentarios.Name = "comentarios"
        '
        'proyecto
        '
        Me.proyecto.HeaderText = "Proyecto"
        Me.proyecto.Name = "proyecto"
        '
        'referencia
        '
        Me.referencia.HeaderText = "Referencia"
        Me.referencia.Name = "referencia"
        Me.referencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.referencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cmnsCambiarPedido
        '
        Me.cmnsCambiarPedido.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmnsCambiarPedido.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarNoPedidoToolStripMenuItem})
        Me.cmnsCambiarPedido.Name = "cmnsCambiarPedido"
        Me.cmnsCambiarPedido.Size = New System.Drawing.Size(182, 26)
        '
        'CambiarNoPedidoToolStripMenuItem
        '
        Me.CambiarNoPedidoToolStripMenuItem.Name = "CambiarNoPedidoToolStripMenuItem"
        Me.CambiarNoPedidoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CambiarNoPedidoToolStripMenuItem.Text = "Cambiar No. Pedido"
        '
        'btnGeneraPedido
        '
        Me.btnGeneraPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGeneraPedido.Location = New System.Drawing.Point(807, 493)
        Me.btnGeneraPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGeneraPedido.Name = "btnGeneraPedido"
        Me.btnGeneraPedido.Size = New System.Drawing.Size(103, 23)
        Me.btnGeneraPedido.TabIndex = 1
        Me.btnGeneraPedido.Text = "Generar Pedidos"
        Me.btnGeneraPedido.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(14, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 67)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PEDIDOS"
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.Location = New System.Drawing.Point(14, 495)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(65, 31)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "<---"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.APP_TEKNO.My.Resources.Resources.sap2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(922, 493)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(97, 23)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.APP_TEKNO.My.Resources.Resources.Importa1
        Me.PictureBox1.Location = New System.Drawing.Point(692, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 185)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnRefresPrecio
        '
        Me.btnRefresPrecio.Location = New System.Drawing.Point(14, 166)
        Me.btnRefresPrecio.Name = "btnRefresPrecio"
        Me.btnRefresPrecio.Size = New System.Drawing.Size(119, 23)
        Me.btnRefresPrecio.TabIndex = 11
        Me.btnRefresPrecio.Text = "Refrescar Precio"
        Me.btnRefresPrecio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Location = New System.Drawing.Point(84, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Eliminar Linea"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1028, 535)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRefresPrecio)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGeneraPedido)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnsCambiarPedido.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents btnGeneraPedido As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents cmnsCambiarPedido As ContextMenuStrip
    Friend WithEvents CambiarNoPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Seleccion As DataGridViewCheckBoxColumn
    Friend WithEvents noPedido As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents grupo As DataGridViewTextBoxColumn
    Friend WithEvents comentarios As DataGridViewTextBoxColumn
    Friend WithEvents proyecto As DataGridViewCheckBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresPrecio As Button
    Friend WithEvents Button1 As Button
End Class
