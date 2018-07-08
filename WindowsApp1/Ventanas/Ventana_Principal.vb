﻿Public Class Ventana_Principal

    Public usuario = New Modulo_Usuarios.User("", "", "")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))

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
        dgvP_Alumnos.Esconder_columnas("baja")
        dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
    End Sub

    Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalMaterias
        dgvP_Asignaturas.Esconder_columnas("id_asignatura,baja")
        dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs) Handles btnTareas.Click
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalTareas
        dgvP_Calificaciones.Esconder_columnas("id_calificacion,baja")
        dgvP_Calificaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CALIFICACIONES()))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDocentes.Click
        dgvP_Docentes.Esconder_columnas("baja")
        dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalDocentes
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        dgvP_Usuarios.Esconder_columnas("baja")
        dgvP_Usuarios.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_USUARIOS()))
        Me.tabPrincipal.SelectedTab = Me.tabPrincipalUsuarios
    End Sub

    Private Sub pnlUsuariosBotonCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnUsuariosBotonCrearNuevo.Click
        ventana_crear_usuario.ShowDialog()
    End Sub

    Private Sub btnVentanaPrincipalConfiguracion_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipalConfiguracion.Click
        VentanaConfiguracion.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ventana_crear_alumno.ShowDialog()
    End Sub

    Private Sub btnDocentesCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnDocentesCrearNuevo.Click
        ventana_crear_docente.ShowDialog()
    End Sub

    Private Sub btnAlumnosModificar_Click(sender As Object, e As EventArgs)
        ventana_modificar_alumno.ShowDialog()
    End Sub

    Private Sub btnAlumnosEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDocentesModificar_Click(sender As Object, e As EventArgs) Handles btnDocentesModificar.Click
        ventana_modificar_docente.ShowDialog()
    End Sub

    Private Sub btnVentanaPrincipalInstitutos_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipalInstitutos.Click
        Me.tabPrincipal.SelectedTab = Me.tabpageInstitutos
        dgvP_Institutos.Esconder_columnas("id_instituto,baja")
        dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))

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

    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Ventana_Login.Show()
    End Sub

    Private Sub btn_Grupos_Click(sender As Object, e As EventArgs) Handles btn_Grupos.Click
        dgvP_Grupos.Esconder_columnas("id_grupo")
        dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
        Me.tabPrincipal.SelectedTab = Me.tabpage_Grupos
    End Sub

    Private Sub btnUsuariosBotonEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuariosBotonEliminarUsuario.Click
        If dgvP_Usuarios.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Usuarios.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_USUARIO(fila.Cells("CI").Value()))
                Next

                dgvP_Usuarios.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_USUARIOS()))
            End If

        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnUsuariosModificar_Click(sender As Object, e As EventArgs) Handles btnUsuariosModificar.Click
        If dgvP_Usuarios.Cantidad_Selecciones() = 1 Then
            ventana_modificar_password_usuario.usuario_a_modificar = dgvP_Usuarios.Filas_Seleccionadas().Item(0)
            ventana_modificar_password_usuario.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If
    End Sub

    Private Sub btnAlumnosEliminar_Click_1(sender As Object, e As EventArgs) Handles btnAlumnosEliminar.Click
        If dgvP_Alumnos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Alumnos.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_ALUMNO(fila.Cells("CI").Value()))
                Next

                dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
            End If
        Else
                MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnGrupos_Eliminar_Click(sender As Object, e As EventArgs) Handles btnGrupos_Eliminar.Click
        If dgvP_Grupos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Grupos.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_GRUPO(fila.Cells("id_grupo").Value()))
                Next

                dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnMateriasEliminar_Click(sender As Object, e As EventArgs) Handles btnMateriasEliminar.Click
        If dgvP_Asignaturas.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Asignaturas.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_ASIGNATURA(fila.Cells("id_asignatura").Value()))
                Next

                dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnEliminarCalificaciones_Click(sender As Object, e As EventArgs) Handles btnEliminarCalificaciones.Click
        If dgvP_Calificaciones.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Calificaciones.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_CALIFICACION(fila.Cells("id_calificacion").Value()))
                Next

                dgvP_Calificaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CALIFICACIONES()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnDocentesEliminar_Click(sender As Object, e As EventArgs) Handles btnDocentesEliminar.Click
        If dgvP_Docentes.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Docentes.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_DOCENTE(fila.Cells("CI").Value()))
                Next

                dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnInstitutoEliminar_Click(sender As Object, e As EventArgs) Handles btnInstitutoEliminar.Click
        If dgvP_Institutos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Institutos.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_INSTITUTO(fila.Cells("id_instituto").Value()))
                Next

                dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnVentanaPrincipalOrientaciones_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipalOrientaciones.Click
        Me.tabPrincipal.SelectedTab = Me.tabOrientaciones
        dgvP_Orientaciones.Esconder_columnas("id_orientacion,baja")
        dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
    End Sub

    Private Sub btnOrientacionesEliminar_Click(sender As Object, e As EventArgs) Handles btnOrientacionesEliminar.Click
        If dgvP_Orientaciones.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Orientaciones.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_ORIENTACION(fila.Cells("id_orientacion").Value()))
                Next

                dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        Me.tabPrincipal.SelectedTab = Me.tabCiudades
        dgvP_Ciudades.Esconder_columnas("id_ciudad,baja")
        dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
    End Sub

    Private Sub btnCiudadesEliminar_Click(sender As Object, e As EventArgs) Handles btnCiudadesEliminar.Click
        If dgvP_Ciudades.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgvP_Ciudades.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_CIUDAD(fila.Cells("id_ciudad").Value()))
                Next

                dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CIUDADES()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnAlumnosCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnAlumnosCrearNuevo.Click
        ventana_crear_alumno.ShowDialog()
    End Sub

    Private Sub btnAlumnosModificar_Click_1(sender As Object, e As EventArgs) Handles btnAlumnosModificar.Click
        If Not dgvP_Alumnos.Cantidad_Selecciones() <> 1 Then
            ventana_crear_alumno.Preparar_Ventana_Modificacion(dgvP_Alumnos.Filas_Seleccionadas().Item(0))
            ventana_crear_alumno.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())

        End If
    End Sub
End Class