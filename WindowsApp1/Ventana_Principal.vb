Public Class Ventana_Principal
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maximizarVentana(Me)
        Me.btnLogoff.Location = New Point(Me.Width - (Me.btnLogoff.Width + (Me.btnLogoff.Width * 5 / 100)), Me.Height - (Me.btnLogoff.Height + (Me.btnLogoff.Height * 5 / 100)))
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        WindowsApp1.Ventana_Login.Show()

    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        LogOff()
    End Sub
End Class