Public Class Ventana_Login



    Private usersList As New List(Of User)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersList.Add(New User("Matias", "Barrios"))
        usersList.Add(New User("Gimena", "Barrios"))
        btnLogin.Enabled = False
        centrarVentana(Me)
        removerMarco(Ventana_Principal)
        'lblNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle



    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged


        If txtNombreUsuario.Text = "" Or txtPassword.Text = "" Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged


        If txtNombreUsuario.Text = "" Or txtPassword.Text = "" Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Validar(usersList, Me.txtNombreUsuario.Text, Me.txtPassword.Text) Then
            Ventana_Principal.Show()
            Me.Hide()
        Else
            MsgBox("Either your username or your password is incorrect", 0, "Authentication error")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class
