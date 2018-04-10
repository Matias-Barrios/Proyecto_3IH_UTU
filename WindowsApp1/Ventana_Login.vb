Public Class Ventana_Login



    Private usersList As New List(Of User)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersList.Add(New User("Matias", "1234", "admin"))
        usersList.Add(New User("Gimena", "1234", "user"))
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
            Ventana_Principal.Show()
        Catch ex As Exception
            MsgBox("Either your username or your password is incorrect", 0, "Authentication error")
        End Try
    End Sub
    ' Esto hace que la ventana sea inamovible. Lo comento aca pero si despues lo queremos usar lo descomentamos
    '
    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    Const WM_NCLBUTTONDOWN As Integer = 161
    '    Const WM_SYSCOMMAND As Integer = 274
    '    Const HTCAPTION As Integer = 2
    '    Const SC_MOVE As Integer = 61456

    '    If (m.Msg = WM_SYSCOMMAND) And (m.WParam.ToInt32() = SC_MOVE) Then
    '        Return
    '    End If

    '    If (m.Msg = WM_NCLBUTTONDOWN) And (m.WParam.ToInt32() = HTCAPTION) Then
    '        Return
    '    End If

    '    MyBase.WndProc(m)
    'End Sub
End Class
