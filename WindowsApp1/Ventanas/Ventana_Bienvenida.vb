Public Class Ventana_Bienvenida
    Private Sub btnIngresarAlSistema_Click(sender As Object, e As EventArgs) Handles btnIngresarAlSistema.Click
        Me.Hide()
        Ventana_Login.ShowDialog()
    End Sub
End Class