<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtConexion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuarioHANA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContHANA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServidorHANA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPuertoServidor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtServidorLicencias = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuarioSAP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContSAP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMesesFiltro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtServidorCorreo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtContCorreo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPuertoSalida = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCorreoPrueba = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chbxSSL = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNumPropietario = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCorreoBitacora = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NupDVerdeMax = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.NupDVerdeMin = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.NupDAmarilloMax = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.NupDAmarilloMin = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NupDRojoMax = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.NupDRojoMin = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCuerpoCorreo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtAsuntoCorreo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSaludoCorreo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NupDVerdeMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDVerdeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDAmarilloMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDAmarilloMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDRojoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDRojoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(151, 12)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(217, 20)
        Me.txtEmpresa.TabIndex = 0
        '
        'txtConexion
        '
        Me.txtConexion.Location = New System.Drawing.Point(151, 38)
        Me.txtConexion.Name = "txtConexion"
        Me.txtConexion.Size = New System.Drawing.Size(217, 20)
        Me.txtConexion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Conexion HANA:"
        '
        'txtUsuarioHANA
        '
        Me.txtUsuarioHANA.Location = New System.Drawing.Point(151, 64)
        Me.txtUsuarioHANA.Name = "txtUsuarioHANA"
        Me.txtUsuarioHANA.Size = New System.Drawing.Size(217, 20)
        Me.txtUsuarioHANA.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario HANA:"
        '
        'txtContHANA
        '
        Me.txtContHANA.Location = New System.Drawing.Point(151, 90)
        Me.txtContHANA.Name = "txtContHANA"
        Me.txtContHANA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContHANA.Size = New System.Drawing.Size(217, 20)
        Me.txtContHANA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña HANA:"
        '
        'txtServidorHANA
        '
        Me.txtServidorHANA.Location = New System.Drawing.Point(151, 116)
        Me.txtServidorHANA.Name = "txtServidorHANA"
        Me.txtServidorHANA.Size = New System.Drawing.Size(217, 20)
        Me.txtServidorHANA.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Servidor HANA:"
        '
        'txtPuertoServidor
        '
        Me.txtPuertoServidor.Location = New System.Drawing.Point(151, 142)
        Me.txtPuertoServidor.Name = "txtPuertoServidor"
        Me.txtPuertoServidor.Size = New System.Drawing.Size(217, 20)
        Me.txtPuertoServidor.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Purerto Servidor:"
        '
        'txtServidorLicencias
        '
        Me.txtServidorLicencias.Location = New System.Drawing.Point(151, 168)
        Me.txtServidorLicencias.Name = "txtServidorLicencias"
        Me.txtServidorLicencias.Size = New System.Drawing.Size(217, 20)
        Me.txtServidorLicencias.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Servidor Licencias:"
        '
        'txtUsuarioSAP
        '
        Me.txtUsuarioSAP.Location = New System.Drawing.Point(151, 194)
        Me.txtUsuarioSAP.Name = "txtUsuarioSAP"
        Me.txtUsuarioSAP.Size = New System.Drawing.Size(217, 20)
        Me.txtUsuarioSAP.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Usuario SAP:"
        '
        'txtContSAP
        '
        Me.txtContSAP.Location = New System.Drawing.Point(151, 220)
        Me.txtContSAP.Name = "txtContSAP"
        Me.txtContSAP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContSAP.Size = New System.Drawing.Size(217, 20)
        Me.txtContSAP.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Contraseña SAP:"
        '
        'txtMesesFiltro
        '
        Me.txtMesesFiltro.Location = New System.Drawing.Point(151, 246)
        Me.txtMesesFiltro.Name = "txtMesesFiltro"
        Me.txtMesesFiltro.Size = New System.Drawing.Size(217, 20)
        Me.txtMesesFiltro.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Meses Filtro:"
        '
        'txtServidorCorreo
        '
        Me.txtServidorCorreo.Location = New System.Drawing.Point(151, 272)
        Me.txtServidorCorreo.Name = "txtServidorCorreo"
        Me.txtServidorCorreo.Size = New System.Drawing.Size(217, 20)
        Me.txtServidorCorreo.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Servidor Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(151, 298)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(217, 20)
        Me.txtCorreo.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Correo:"
        '
        'txtContCorreo
        '
        Me.txtContCorreo.Location = New System.Drawing.Point(151, 324)
        Me.txtContCorreo.Name = "txtContCorreo"
        Me.txtContCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContCorreo.Size = New System.Drawing.Size(217, 20)
        Me.txtContCorreo.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 327)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Contraseña Correo;"
        '
        'txtPuertoSalida
        '
        Me.txtPuertoSalida.Location = New System.Drawing.Point(151, 350)
        Me.txtPuertoSalida.Name = "txtPuertoSalida"
        Me.txtPuertoSalida.Size = New System.Drawing.Size(217, 20)
        Me.txtPuertoSalida.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Puerto Salida Correo:"
        '
        'txtCorreoPrueba
        '
        Me.txtCorreoPrueba.Location = New System.Drawing.Point(151, 451)
        Me.txtCorreoPrueba.Name = "txtCorreoPrueba"
        Me.txtCorreoPrueba.Size = New System.Drawing.Size(217, 20)
        Me.txtCorreoPrueba.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 454)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Correo de Prueba:"
        '
        'chbxSSL
        '
        Me.chbxSSL.AutoSize = True
        Me.chbxSSL.Location = New System.Drawing.Point(151, 376)
        Me.chbxSSL.Name = "chbxSSL"
        Me.chbxSSL.Size = New System.Drawing.Size(77, 17)
        Me.chbxSSL.TabIndex = 14
        Me.chbxSSL.Text = "Utiliza SSL"
        Me.chbxSSL.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(315, 519)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(396, 519)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(150, 474)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(206, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "NOTA: Si el Correo de Prueba esta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vacio se enviara el correo al proveedor."
        '
        'txtNumPropietario
        '
        Me.txtNumPropietario.Location = New System.Drawing.Point(151, 425)
        Me.txtNumPropietario.Name = "txtNumPropietario"
        Me.txtNumPropietario.Size = New System.Drawing.Size(217, 20)
        Me.txtNumPropietario.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 428)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Num. Emp. Propietario:"
        '
        'txtCorreoBitacora
        '
        Me.txtCorreoBitacora.Location = New System.Drawing.Point(151, 399)
        Me.txtCorreoBitacora.Name = "txtCorreoBitacora"
        Me.txtCorreoBitacora.Size = New System.Drawing.Size(217, 20)
        Me.txtCorreoBitacora.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 402)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Correo Bitacora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.NupDVerdeMax)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.NupDVerdeMin)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.NupDAmarilloMax)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.NupDAmarilloMin)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.NupDRojoMax)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.NupDRojoMin)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(396, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(380, 109)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rangos Meses de Inversion"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(166, 88)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 13)
        Me.Label27.TabIndex = 14
        Me.Label27.Text = "Hasta:"
        '
        'NupDVerdeMax
        '
        Me.NupDVerdeMax.DecimalPlaces = 1
        Me.NupDVerdeMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NupDVerdeMax.Location = New System.Drawing.Point(208, 86)
        Me.NupDVerdeMax.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDVerdeMax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NupDVerdeMax.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NupDVerdeMax.Name = "NupDVerdeMax"
        Me.NupDVerdeMax.Size = New System.Drawing.Size(41, 20)
        Me.NupDVerdeMax.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(81, 88)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "De:"
        '
        'NupDVerdeMin
        '
        Me.NupDVerdeMin.DecimalPlaces = 1
        Me.NupDVerdeMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NupDVerdeMin.Location = New System.Drawing.Point(108, 86)
        Me.NupDVerdeMin.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDVerdeMin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NupDVerdeMin.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NupDVerdeMin.Name = "NupDVerdeMin"
        Me.NupDVerdeMin.Size = New System.Drawing.Size(41, 20)
        Me.NupDVerdeMin.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(166, 58)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(38, 13)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Hasta:"
        '
        'NupDAmarilloMax
        '
        Me.NupDAmarilloMax.DecimalPlaces = 1
        Me.NupDAmarilloMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NupDAmarilloMax.Location = New System.Drawing.Point(208, 57)
        Me.NupDAmarilloMax.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDAmarilloMax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NupDAmarilloMax.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NupDAmarilloMax.Name = "NupDAmarilloMax"
        Me.NupDAmarilloMax.Size = New System.Drawing.Size(41, 20)
        Me.NupDAmarilloMax.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(81, 58)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(24, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "De:"
        '
        'NupDAmarilloMin
        '
        Me.NupDAmarilloMin.DecimalPlaces = 1
        Me.NupDAmarilloMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NupDAmarilloMin.Location = New System.Drawing.Point(108, 57)
        Me.NupDAmarilloMin.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDAmarilloMin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NupDAmarilloMin.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NupDAmarilloMin.Name = "NupDAmarilloMin"
        Me.NupDAmarilloMin.Size = New System.Drawing.Size(41, 20)
        Me.NupDAmarilloMin.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(166, 29)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Hasta:"
        '
        'NupDRojoMax
        '
        Me.NupDRojoMax.DecimalPlaces = 1
        Me.NupDRojoMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NupDRojoMax.Location = New System.Drawing.Point(208, 28)
        Me.NupDRojoMax.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDRojoMax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NupDRojoMax.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NupDRojoMax.Name = "NupDRojoMax"
        Me.NupDRojoMax.Size = New System.Drawing.Size(41, 20)
        Me.NupDRojoMax.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(81, 29)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "De:"
        '
        'NupDRojoMin
        '
        Me.NupDRojoMin.DecimalPlaces = 1
        Me.NupDRojoMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NupDRojoMin.Location = New System.Drawing.Point(108, 28)
        Me.NupDRojoMin.Margin = New System.Windows.Forms.Padding(2)
        Me.NupDRojoMin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NupDRojoMin.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NupDRojoMin.Name = "NupDRojoMin"
        Me.NupDRojoMin.Size = New System.Drawing.Size(41, 20)
        Me.NupDRojoMin.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 88)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Verde:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(20, 58)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Amarillo:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 29)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Rojo:"
        '
        'txtCuerpoCorreo
        '
        Me.txtCuerpoCorreo.Location = New System.Drawing.Point(396, 219)
        Me.txtCuerpoCorreo.Multiline = True
        Me.txtCuerpoCorreo.Name = "txtCuerpoCorreo"
        Me.txtCuerpoCorreo.Size = New System.Drawing.Size(379, 202)
        Me.txtCuerpoCorreo.TabIndex = 21
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(393, 197)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 13)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "Cuerpo del Correo:"
        '
        'txtAsuntoCorreo
        '
        Me.txtAsuntoCorreo.Location = New System.Drawing.Point(480, 142)
        Me.txtAsuntoCorreo.Name = "txtAsuntoCorreo"
        Me.txtAsuntoCorreo.Size = New System.Drawing.Size(295, 20)
        Me.txtAsuntoCorreo.TabIndex = 19
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(393, 145)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 13)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "Asunto Correo:"
        '
        'txtSaludoCorreo
        '
        Me.txtSaludoCorreo.Location = New System.Drawing.Point(480, 168)
        Me.txtSaludoCorreo.Name = "txtSaludoCorreo"
        Me.txtSaludoCorreo.Size = New System.Drawing.Size(295, 20)
        Me.txtSaludoCorreo.TabIndex = 20
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(393, 171)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 13)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = "Saludo Correo:"
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 554)
        Me.Controls.Add(Me.txtSaludoCorreo)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtAsuntoCorreo)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtCuerpoCorreo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCorreoBitacora)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNumPropietario)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chbxSSL)
        Me.Controls.Add(Me.txtCorreoPrueba)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPuertoSalida)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtContCorreo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtServidorCorreo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMesesFiltro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtContSAP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUsuarioSAP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtServidorLicencias)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPuertoServidor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtServidorHANA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContHANA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsuarioHANA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConexion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NupDVerdeMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDVerdeMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDAmarilloMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDAmarilloMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDRojoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDRojoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents txtConexion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuarioHANA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContHANA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtServidorHANA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPuertoServidor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtServidorLicencias As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUsuarioSAP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtContSAP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMesesFiltro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtServidorCorreo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtContCorreo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPuertoSalida As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCorreoPrueba As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chbxSSL As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNumPropietario As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCorreoBitacora As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents NupDVerdeMax As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents NupDVerdeMin As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents NupDAmarilloMax As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents NupDAmarilloMin As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents NupDRojoMax As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents NupDRojoMin As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCuerpoCorreo As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtAsuntoCorreo As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtSaludoCorreo As TextBox
    Friend WithEvents Label30 As Label
End Class
