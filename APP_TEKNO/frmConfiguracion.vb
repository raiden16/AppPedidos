Public Class frmConfiguracion
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmpresa.Text = My.Settings.Empresa
        txtConexion.Text = My.Settings.conexionDBHANA
        txtUsuarioHANA.Text = My.Settings.UsuarioHANA
        txtContHANA.Text = My.Settings.PasswordHANA
        txtServidorHANA.Text = My.Settings.ServidorHANA
        txtPuertoServidor.Text = My.Settings.PuertoServidor
        txtServidorLicencias.Text = My.Settings.Licencia
        txtUsuarioSAP.Text = My.Settings.UsuarioSAP
        txtContSAP.Text = My.Settings.PasswordSAP
        txtMesesFiltro.Text = My.Settings.Meses
        txtServidorCorreo.Text = My.Settings.ServidorCorreo
        txtCorreo.Text = My.Settings.UsuarioCorreo
        txtContCorreo.Text = My.Settings.PasswordCorreo
        txtPuertoSalida.Text = My.Settings.PuertoSL
        chbxSSL.Checked = My.Settings.UtilizarSSL
        txtCorreoBitacora.Text = My.Settings.CorreoBitacora
        txtNumPropietario.Text = My.Settings.NumPropietario
        txtCorreoPrueba.Text = My.Settings.CorreoTest
        NupDRojoMin.Value = My.Settings.RangoRojoMin
        NupDRojoMax.Value = My.Settings.RangoRojoMax
        NupDAmarilloMin.Value = My.Settings.RangoAmarilloMin
        NupDAmarilloMax.Value = My.Settings.RangoAmarilloMax
        NupDVerdeMin.Value = My.Settings.RangoVerdeMin
        NupDVerdeMax.Value = My.Settings.RangoVerdeMax
        txtAsuntoCorreo.Text = My.Settings.AsuntoCorreo
        txtSaludoCorreo.Text = My.Settings.SaludoCorreo
        txtCuerpoCorreo.Text = My.Settings.CuerpoCorreo
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            My.Settings.Empresa = txtEmpresa.Text
            My.Settings.conexionDBHANA = txtConexion.Text
            My.Settings.UsuarioHANA = txtUsuarioHANA.Text
            My.Settings.PasswordHANA = txtContHANA.Text
            My.Settings.ServidorHANA = txtServidorHANA.Text
            My.Settings.PuertoServidor = txtPuertoServidor.Text
            My.Settings.Licencia = txtServidorLicencias.Text
            My.Settings.UsuarioSAP = txtUsuarioSAP.Text
            My.Settings.PasswordSAP = txtContSAP.Text
            My.Settings.Meses = txtMesesFiltro.Text
            My.Settings.ServidorCorreo = txtServidorCorreo.Text
            My.Settings.UsuarioCorreo = txtCorreo.Text
            My.Settings.PasswordCorreo = txtContCorreo.Text
            My.Settings.PuertoSL = txtPuertoSalida.Text
            My.Settings.UtilizarSSL = chbxSSL.Checked
            My.Settings.CorreoBitacora = txtCorreoBitacora.Text
            My.Settings.NumPropietario = txtNumPropietario.Text
            My.Settings.CorreoTest = txtCorreoPrueba.Text
            My.Settings.RangoRojoMin = NupDRojoMin.Value.ToString("00.0")
            My.Settings.RangoRojoMax = NupDRojoMax.Value.ToString("00.0")
            My.Settings.RangoAmarilloMin = NupDAmarilloMin.Value.ToString("00.0")
            My.Settings.RangoAmarilloMax = NupDAmarilloMax.Value.ToString("00.0")
            My.Settings.RangoVerdeMin = NupDVerdeMin.Value.ToString("00.0")
            My.Settings.RangoVerdeMax = NupDVerdeMax.Value.ToString("00.0")
            My.Settings.AsuntoCorreo = txtAsuntoCorreo.Text
            My.Settings.SaludoCorreo = txtSaludoCorreo.Text
            My.Settings.CuerpoCorreo = txtCuerpoCorreo.Text
            My.Settings.Save()
            MsgBox("Configuracion guardada con exito")
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar la configuracion: " + ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class