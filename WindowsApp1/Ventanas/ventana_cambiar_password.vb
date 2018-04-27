Public Class VentanaCambiarPassword
    Private Sub VentanaCambiarPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtVentanaCambiarPasswordContraseñaActual, TipoValidacion.Solo_password)
        Adherir_Validacion(txtVentanaCambiarPasswordNuevo, TipoValidacion.Solo_password)
        Adherir_Validacion(txtVentanaCambiarPasswordNuevoRepetido, TipoValidacion.Solo_password)
    End Sub

    Private Sub btnVentanaCambiarPasswordCancel_Click(sender As Object, e As EventArgs) Handles btnVentanaCambiarPasswordCancel.Click
        Me.Close()
    End Sub

    Private Sub btnVentanaCambiarPasswordOK_Click(sender As Object, e As EventArgs) Handles btnVentanaCambiarPasswordOK.Click
        ' Aca hay que validar si el password acutal es correct de nuevo, y despues actualiszar acordemente.
        ' TODO
        Me.Close()
    End Sub
End Class