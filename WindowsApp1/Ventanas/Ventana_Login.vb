Public Class Ventana_Login



    Private usersList As New List(Of User)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersList.Add(New User("Matias", "1234", "admin"))
        usersList.Add(New User("Gimena", "1234", "user"))
        usersList.Add(New User("christian", "1234", "user"))
        btnLogin.Enabled = False
        centrarVentana(Me)
        removerMarco(Ventana_Principal)
        Me.b_lblNombreUsuario.border_thickness = 4
        Me.b_lblPassword.border_thickness = 4
        Adherir_Validacion(txtNombreUsuario, TipoValidacion.Solo_username)
        Adherir_Validacion(txtPassword, TipoValidacion.Solo_password)
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
        Try
            Ventana_Principal.usuario = Validar(usersList, Me.txtNombreUsuario.Text, Me.txtPassword.Text)
            Me.Hide()
            Ventana_Principal.ShowDialog()
        Catch ex As Exception
            MsgBox("Either your username or your password is incorrect", 0, "Authentication error")
        End Try
    End Sub

    Private Sub Cerra_Ventana(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        Ventana_Bienvenida.Show()
    End Sub 'Form1_Closing
End Class 'Form1
