Public Class VentanaConfiguracion
    Private Sub VentanaConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtVentanaConfiguracionIPServidor, TipoValidacion.Solo_IP)
        Adherir_Validacion(txtVentanaCondiguracionPuerto, TipoValidacion.Solo_digitos)
    End Sub

    Private Sub btnVentanaConfiguracionCancel_Click(sender As Object, e As EventArgs) Handles btnVentanaConfiguracionCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnVentanaConfiguracionOK_Click(sender As Object, e As EventArgs) Handles btnVentanaConfiguracionOK.Click
        ' Updatear las variables de la aplicacio y recrear el objeto que conecta a la BD
        ' TODO
        Me.Hide()
    End Sub


End Class