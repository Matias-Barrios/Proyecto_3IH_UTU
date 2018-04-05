Public Class Ventana_Principal
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maximizarVentana(Me)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        WindowsApp1.Ventana_Login.Show()



    End Sub
End Class