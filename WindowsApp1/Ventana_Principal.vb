Public Class Ventana_Principal

    Public usuario = New Modulo_Usuarios.User("", "", "")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maximizarVentana(Me)
        Dim pnt = Me.PointToScreen(New Point(0, 0))
        Me.pnlUsuario_logueado.Location = New Point(Me.Width - (Me.pnlUsuario_logueado.Width + porcentajeAncho(Me.pnlUsuario_logueado, 5)), 0 + (porcentajeAlto(Me.pnlUsuario_logueado, 5)))
        Me.btnLogoff.Location = New Point(Me.Width - (Me.btnLogoff.Width + (Me.btnLogoff.Width * 5 / 100)), Me.Height - (Me.btnLogoff.Height + (Me.btnLogoff.Height * 5 / 100)))
        Me.b_lblRol_fijo.border_thickness = 2
        Me.b_lblusuarioLogueado_nombre.border_thickness = 2
        Me.b_lblNombreUsuario_Dinamico.Text = Me.usuario.Name
        Me.b_lblRol_Dinamico.Text = Me.usuario.Rol
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        WindowsApp1.Ventana_Login.Show()

    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        LogOff()
    End Sub

End Class