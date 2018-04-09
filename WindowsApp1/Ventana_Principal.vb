Public Class Ventana_Principal

    Public usuario = New Modulo_Usuarios.User("", "", "")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maximizarVentana(Me)
        Me.b_lblRol_fijo.border_thickness = 2
        Me.b_lblusuarioLogueado_nombre.border_thickness = 2
        Me.b_lblNombreUsuario_Dinamico.outline_color = Color.White
        Me.b_lblNombreUsuario_Dinamico.Text = Me.usuario.Name
        Me.b_lblRol_Dinamico.Text = Me.usuario.Rol
        Me.b_lblRol_Dinamico.outline_color = Color.White
        Me.tabPrincipal.Appearance = TabAppearance.FlatButtons
        Me.tabPrincipal.ItemSize = New Size(0, 1)
        Me.tabPrincipal.SizeMode = TabSizeMode.Fixed

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        WindowsApp1.Ventana_Login.Show()
    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        LogOff()
    End Sub

    Private Sub btnAlumnos_Click(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalAlumnos
    End Sub

    Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalMaterias
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs) Handles btnTareas.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalTareas
    End Sub
End Class