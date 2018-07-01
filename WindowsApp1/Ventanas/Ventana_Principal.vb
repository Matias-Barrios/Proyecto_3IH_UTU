Public Class Ventana_Principal

    Public usuario = New Modulo_Usuarios.User("", "", "")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        maximizarVentana(Me)
        Me.b_lblRol_fijo.border_thickness = 2
        Me.b_lblusuarioLogueado_nombre.border_thickness = 2
        Me.b_lblNombreUsuario_Dinamico.outline_color = Color.White
        Me.b_lblNombreUsuario_Dinamico.border_thickness = 3
        Me.b_lblNombreUsuario_Dinamico.Text = Me.usuario.Name
        Me.b_lblRol_Dinamico.Text = Me.usuario.Rol
        Me.b_lblRol_Dinamico.border_thickness = 3
        Me.b_lblRol_Dinamico.outline_color = Color.White
        Me.tabPrincipal.Appearance = TabAppearance.FlatButtons
        Me.tabPrincipal.ItemSize = New Size(0, 1)
        Me.tabPrincipal.SizeMode = TabSizeMode.Fixed

        Me.tabCalificaciones_Vista.Appearance = TabAppearance.FlatButtons
        Me.tabCalificaciones_Vista.ItemSize = New Size(0, 1)
        Me.tabCalificaciones_Vista.SizeMode = TabSizeMode.Fixed


        Adherir_Validacion(txtAlumnosFiltrarCedula, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtAlumnosFiltrarNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(pnlUsuariosFiltroNombreUsuario, TipoValidacion.Solo_username)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDocentes.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalDocentes
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalUsuarios
    End Sub

    Private Sub pnlUsuariosBotonCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnUsuariosBotonCrearNuevo.Click

    End Sub

    Private Sub btnVentanaPrincipalConfiguracion_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipalConfiguracion.Click
        VentanaConfiguracion.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAlumnosCrearNuevo.Click
        ventana_crear_alumno.ShowDialog()
    End Sub

    Private Sub btnDocentesCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnDocentesCrearNuevo.Click
        ventana_crear_docente.ShowDialog()
    End Sub

    Private Sub btnAlumnosModificar_Click(sender As Object, e As EventArgs) Handles btnAlumnosModificar.Click
        ventana_modificar_alumno.ShowDialog()
    End Sub

    Private Sub btnAlumnosEliminar_Click(sender As Object, e As EventArgs) Handles btnAlumnosEliminar.Click

    End Sub

    Private Sub btnDocentesModificar_Click(sender As Object, e As EventArgs) Handles btnDocentesModificar.Click
        ventana_modificar_docente.ShowDialog()
    End Sub

    Private Sub btnVentanaPrincipalInstitutos_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipalInstitutos.Click
        Me.tabPrincipal.SelectedTab = Me.tabpageInstitutos
    End Sub

    Private Sub btnCrearCalificaciones_Click(sender As Object, e As EventArgs) Handles btnCrearCalificaciones.Click
        ventana_crear_calificaciones.ShowDialog()
    End Sub

    Private Sub tabPrincipalTareas_Click(sender As Object, e As EventArgs) Handles tabPrincipalTareas.Click

    End Sub

    Private Sub rdioCalificaciones_Ver_Por_Calificacion_CheckedChanged(sender As Object, e As EventArgs) Handles rdioCalificaciones_Ver_Por_Calificacion.CheckedChanged

        Me.tabCalificaciones_Vista.SelectedTab = Me.tabCalificaciones_Vista_Por_Calificacion

    End Sub

    Private Sub rdioCalificaciones_Ver_Por_Alumno_CheckedChanged(sender As Object, e As EventArgs) Handles rdioCalificaciones_Ver_Por_Alumno.CheckedChanged

        Me.tabCalificaciones_Vista.SelectedTab = Me.tabCalificaiones_Vista_Alumnos

    End Sub

    Private Sub btnMateriasCrear_Click(sender As Object, e As EventArgs) Handles btnMateriasCrear.Click
        ventana_crear_asignatura.ShowDialog()
    End Sub

    Private Sub btnInstitutoCrear_Click(sender As Object, e As EventArgs) Handles btnInstitutoCrear.Click
        ventana_crear_institutos.ShowDialog()
    End Sub
End Class