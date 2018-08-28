Public Class Ventana_Login



    Private usersList As New List(Of User)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        USUARIO_LOGUEADO = Usuario_Existente(Me.txtNombreUsuario.Text.Trim(), Me.txtPassword.Text.Trim())
        If USUARIO_LOGUEADO IsNot Nothing Then
            Ventana_Principal.b_lblRol_Dinamico.Text = USUARIO_LOGUEADO.tipo
            Ventana_Principal.b_lblNombreUsuario_Dinamico.Text = USUARIO_LOGUEADO.primer_nombre & " " & USUARIO_LOGUEADO.primer_apellido
            Me.Hide()
            Console.WriteLine("El usuario logueado es : " + USUARIO_LOGUEADO.tipo)
            Modulo_Comportamiento_Ventanas.verificarRol(USUARIO_LOGUEADO.tipo)
            Ventana_Principal.ShowDialog()
        Else
            MsgBox("Su nombre de usuario o contraseña es incorrecto", 0, "Error de autenticacion")
        End If

    End Sub

    Private Sub Cerra_Ventana(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        Ventana_Bienvenida.Show()
    End Sub
End Class
