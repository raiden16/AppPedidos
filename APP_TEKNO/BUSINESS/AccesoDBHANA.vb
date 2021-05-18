Public NotInheritable Class AccesoDBHANA

    Private Shared Instance As ConexionHana

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetConexion As ConexionHana
        Get
            If Instance Is Nothing Then
                Instance = New ConexionHana()
            End If
            Return Instance
        End Get
    End Property

End Class