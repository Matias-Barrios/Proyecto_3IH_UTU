Public Class Ventana_Principal


    Public usuario = vbNull
    Private Sub Precarga(tipo As String)
        If tipo = "Admin" Then
            dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
            dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
            dgvP_Calificaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CALIFICACIONES()))
            dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))
            dgvP_Usuarios.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_USUARIOS()))
            dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))
            dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
            dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CIUDADES()))
            dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
            dgv_Admins_Administrativos.Cargar_datos(hacer_consulta(CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS()))
            dgvP_Historial.Cargar_datos(Decodificar_Historial(hacer_consulta(CONSULTA_SELECT_HISTORIAL())))
        ElseIf tipo = "Docente" Then
            Me.tabPrincipal.SelectedTab = Me.tabPrincipalTareas
        ElseIf tipo = "Administrativo" Then
            dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
            dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
            dgvP_Calificaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CALIFICACIONES()))
            dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))
            dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))
            dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
            dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
            dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
        End If



    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Precarga(USUARIO_LOGUEADO.tipo)
        cboInstituto.DataSource = hacer_consulta(CONSULTAS_SELECT_INSTITUTOS_CALIFICACIONES_COMBOBOX())
        cboInstituto.DisplayMember = "nombre"
        maximizarVentana(Me)
        Rellenar_Control(lst_Agregar_grupo, CONSULTAS_TODOS_LOS_GRUPOS())
        lst_Agregar_grupo.DisplayMember = "Grupo"
        Rellenar_Control(listDocenteAsignarGrupo, CONSULTAS_TODOS_LOS_GRUPOS)
        listDocenteAsignarGrupo.DisplayMember = "Grupo"
        Rellenar_Control(listAsignaturasDocente, CONSULTAS_TODOS_LAS_ASIGNATURAS)
        listAsignaturasDocente.DisplayMember = "Asignatura"
        lstGrupos_vinc_Orientaciones.DataSource = hacer_consulta(CONSULTAS_TODAS_LAS_ORIENTACIONES())
        lstGrupos_vinc_Orientaciones.DisplayMember = "nombre_orientacion"

        Me.b_lblusuarioLogueado_nombre.border_thickness = 2
        Me.b_lblNombreUsuario_Dinamico.outline_color = Color.White
        Me.b_lblNombreUsuario_Dinamico.border_thickness = 3
        Me.b_lblNombreUsuario_Dinamico.Text = Modulo_Usuarios.USUARIO_LOGUEADO.primer_nombre & " " & Modulo_Usuarios.USUARIO_LOGUEADO.primer_apellido
        Me.b_lblRol_Dinamico.Text = Modulo_Usuarios.USUARIO_LOGUEADO.tipo
        Me.b_lblRol_Dinamico.border_thickness = 3
        Me.b_lblRol_Dinamico.outline_color = Color.White
        Me.tabPrincipal.Appearance = TabAppearance.FlatButtons
        Me.tabPrincipal.ItemSize = New Size(0, 1)
        Me.tabPrincipal.SizeMode = TabSizeMode.Fixed
        AddHandler Control_impresion.PrintPage, AddressOf Impresion.Imprimir
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        WindowsApp1.Ventana_Login.txtNombreUsuario.Text = ""
        WindowsApp1.Ventana_Login.txtPassword.Text = ""
        WindowsApp1.Ventana_Login.Show()
    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        LogOff()
    End Sub

    Private Sub btnVentanaPrincipalOrientaciones_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipalOrientaciones.Click
        Me.tabPrincipal.SelectedTab = Me.tabOrientaciones
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
        ventana_crear_usuario.ShowDialog()
    End Sub

    Private Sub btnVentanaPrincipalConfiguracion_Click(sender As Object, e As EventArgs)
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
    End Sub

    Private Sub btnCrearCalificaciones_Click(sender As Object, e As EventArgs) Handles btnCrearCalificaciones.Click
        ventana_crear_calificaciones.ShowDialog()



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

                dgvP_Calificaciones.Cargar_datos(hacer_consulta(COMBOBOX_CALIFICACIONES_COMPLETA(cboAsignatura, cboInstituto, cboGrupo)))
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

    Private Sub btnGrupos_Agregar_Click(sender As Object, e As EventArgs) Handles btnGrupos_Agregar.Click
        ventana_crear_grupo.Show()
    End Sub

    Private Sub btn_Grupos_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Grupos_Modificar.Click
        If Not dgvP_Grupos.Cantidad_Selecciones() <> 1 Then
            ventana_crear_grupo.Preparar_Ventana_Modificacion(dgvP_Grupos.Filas_Seleccionadas().Item(0))
            ventana_crear_grupo.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())

        End If
    End Sub

    Private Sub btnMateriasModificar_Click(sender As Object, e As EventArgs) Handles btnMateriasModificar.Click
        If Not dgvP_Asignaturas.Cantidad_Selecciones() <> 1 Then
            ventana_crear_asignatura.Preparar_Ventana_Modificacion(dgvP_Asignaturas.Filas_Seleccionadas().Item(0))
            ventana_crear_asignatura.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())

        End If
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged


        cboAsignatura.DataSource = hacer_consulta(COMBOBOX_CALIFICACIONES_GRUPO(cboGrupo, cboInstituto))
        cboAsignatura.DisplayMember = "nombre_asignatura"


    End Sub

    Private Sub cboAsignatura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAsignatura.SelectedIndexChanged


    End Sub

    Private Sub cboInstituto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstituto.SelectedIndexChanged


        cboGrupo.DataSource = hacer_consulta(COMBOBOX_CALIFICACIONES_INSTITUTO(cboInstituto))
        cboGrupo.DisplayMember = "nombre_grupo"


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        dgvP_Calificaciones.Cargar_datos(hacer_consulta(COMBOBOX_CALIFICACIONES_COMPLETA(cboAsignatura, cboInstituto, cboGrupo)))


    End Sub

    Private Sub btnVentanaPrincipal_Admins_Administrativos_Click(sender As Object, e As EventArgs) Handles btnVentanaPrincipal_Admins_Administrativos.Click
        Me.tabPrincipal.SelectedTab = Me.tabAdmins

    End Sub

    Private Sub btnAdmins_Crear_Click(sender As Object, e As EventArgs) Handles btnAdmins_Crear.Click
        ventana_crear_admin.ShowDialog()
    End Sub

    Private Sub btnAdmins_Eliminar_Click(sender As Object, e As EventArgs) Handles btnAdmins_Eliminar.Click
        If dgv_Admins_Administrativos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show("Seguro?", SEGURO_ELIMINAR(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                For Each fila In dgv_Admins_Administrativos.Filas_Seleccionadas()
                    hacer_consulta(BAJA_LOGICA_ADMIN(fila.Cells("CI").Value()))
                Next

                dgv_Admins_Administrativos.Cargar_datos(hacer_consulta(CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())

        End If
    End Sub

    Private Sub btnAdmins_Modificar_Click(sender As Object, e As EventArgs) Handles btnAdmins_Modificar.Click
        If Not dgv_Admins_Administrativos.Cantidad_Selecciones() <> 1 Then
            ventana_crear_admin.Preparar_Ventana_Modificacion(dgv_Admins_Administrativos.Filas_Seleccionadas().Item(0))
            ventana_crear_admin.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())

        End If
    End Sub

    Private Sub btn_alumnos_Refrescar_Click(sender As Object, e As EventArgs) Handles btn_alumnos_Refrescar.Click
        dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
    End Sub

    Private Sub btn_agregar_a_un_grupo_Click(sender As Object, e As EventArgs) Handles btn_agregar_a_un_grupo.Click
        If dgvP_Alumnos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show(SEGURO_ASIGNAR_GRUPO(), "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                For Each fila In dgvP_Alumnos.Filas_Seleccionadas()
                    If IsDBNull(fila.Cells("Grupo").Value()) Then
                        hacer_consulta(CONSULTAS_ASIGNAR_ALUMNO_GRUPO(fila.Cells("CI").Value(), lst_Agregar_grupo.SelectedItem().Item("id_grupo"), lst_Agregar_grupo.SelectedItem().Item("foranea_id_instituto")))
                    Else
                        hacer_consulta(CONSULTAS_MODIFICAR_ASIGNACION_ALUMNO_GRUPO(fila.Cells("CI").Value(), lst_Agregar_grupo.SelectedItem().Item("id_grupo"), lst_Agregar_grupo.SelectedItem().Item("foranea_id_instituto")))
                    End If
                Next

                dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))

            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())
        End If
    End Sub

    Private Sub btnDesvincular_Click(sender As Object, e As EventArgs) Handles btnDesvincular.Click
        If dgvP_Alumnos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show(SEGURO_DESVINCULAR(), "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                For Each fila In dgvP_Alumnos.Filas_Seleccionadas()
                    If Not IsDBNull(fila.Cells("Grupo").Value()) Then
                        hacer_consulta(CONSULTAS_DESVINCULAR_ALUMNO_GRUPO(fila.Cells("CI").Value()))

                    End If
                Next

                dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))

            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())
        End If
    End Sub

    Private Sub btnVincularAGrupoDocente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If dgvP_Docentes.Cantidad_Selecciones() = 1 Then
            If MessageBox.Show(SEGURO_ASIGNAR_GRUPO(), "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                For Each fila In dgvP_Docentes.Filas_Seleccionadas()
                    hacer_consulta(CONSULTAS_VINCULAR_DOCENTE_A_GRUPO(fila.Cells("CI").Value(), listAsignaturasDocente.SelectedItem().Item("id_asignatura"), listDocenteAsignarGrupo.SelectedItem().Item("id_grupo"), listDocenteAsignarGrupo.SelectedItem().Item("foranea_id_instituto")))
                Next

                dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))

            End If
        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_ver_grupos_asignados_docente.Click
        If dgvP_Docentes.Cantidad_Selecciones() = 1 Then

            For Each fila In dgvP_Docentes.Filas_Seleccionadas()
                ventana_ver_grupos_docente.lbl_nombre_docente.Text = fila.Cells("nombre_completo").Value()
                ventana_ver_grupos_docente.txt_ver_cedula_docente.Text = fila.Cells("CI").Value()
                ventana_ver_grupos_docente.chk_grupos_asignados_docente.DataSource = hacer_consulta(CONSULTA_GRUPOS_ASIGNADOS_DOCENTE(fila.Cells("CI").Value()))
                ventana_ver_grupos_docente.chk_grupos_asignados_docente.DisplayMember = "Asignacion"
                'hacer_consulta(CONSULTAS_VINCULAR_DOCENTE_A_GRUPO(fila.Cells("CI").Value(), listAsignaturasDocente.SelectedItem().Item("id_asignatura"), listDocenteAsignarGrupo.SelectedItem().Item("id_grupo"), listDocenteAsignarGrupo.SelectedItem().Item("foranea_id_instituto")))
                ventana_ver_grupos_docente.ShowDialog()

                dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))
            Next

        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Impresion.Apuntar_Impresion(dgvP_Grupos.Obtener_datos_totales())
        Control_impresion.Print()
    End Sub

    Private Sub btnVincular_a_Orientacion_Click(sender As Object, e As EventArgs) Handles btnVincular_a_Orientacion.Click
        If dgvP_Grupos.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show(SEGURO_ASIGNAR_GRUPO_A_ORIENTACION(), "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                For Each fila In dgvP_Grupos.Filas_Seleccionadas()
                    hacer_consulta(CONSULTAS_ASIGNAR_GRUPO_A_ORIENTACION(fila.Cells("id_grupo").Value(), lstGrupos_vinc_Orientaciones.SelectedItem().Item("id_orientacion")))
                Next
                dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())
        End If
    End Sub

    Private Sub btnImprimirOrientaciones_Click(sender As Object, e As EventArgs) Handles btnImprimirOrientaciones.Click

    End Sub

    Private Sub btnUsuariosImprimir_Click(sender As Object, e As EventArgs) Handles btnUsuariosImprimir.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btn_admins_Refrescar.Click
        dgv_Admins_Administrativos.Cargar_datos(hacer_consulta(CONSULTA_SELECT_ADMINS_ADMINISTRATIVOS()))
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub btn_Grupos_refrescar_Click(sender As Object, e As EventArgs) Handles btn_Grupos_refrescar.Click
        dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
    End Sub

    Private Sub btn_Asignaturas_refrescar_Click(sender As Object, e As EventArgs) Handles btn_Asignaturas_refrescar.Click
        dgvP_Asignaturas.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ASIGNATURAS()))
    End Sub

    Private Sub btn_refrescar_Calificaciones_Click(sender As Object, e As EventArgs) Handles btn_refrescar_Calificaciones.Click
        If USUARIO_LOGUEADO.Rol = "Docente" Then
            dgvP_Calificaciones.Cargar_datos(hacer_consulta(COMBOBOX_CALIFICACIONES_COMPLETA(cboAsignatura, cboInstituto, cboGrupo)))
        End If
        If USUARIO_LOGUEADO.Rol = "Admin" Then
            dgvP_Calificaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CALIFICACIONES()))

        End If
    End Sub

    Private Sub btn_Docentes_refrescar_Click(sender As Object, e As EventArgs) Handles btn_Docentes_refrescar.Click
        dgvP_Docentes.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_DOCENTES()))
    End Sub

    Private Sub btn_usuarios_refrescar_Click(sender As Object, e As EventArgs) Handles btn_usuarios_refrescar.Click
        dgvP_Usuarios.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_USUARIOS()))
    End Sub

    Private Sub btn_Institutos_refrescar_Click(sender As Object, e As EventArgs) Handles btn_Institutos_refrescar.Click
        dgvP_Institutos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_INSTITUTOS()))
    End Sub

    Private Sub btn_orientacion_refrescar_Click(sender As Object, e As EventArgs) Handles btn_orientacion_refrescar.Click
        dgvP_Orientaciones.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES()))
    End Sub

    Private Sub btnCiudades_Refrescar_Click(sender As Object, e As EventArgs) Handles btnCiudades_Refrescar.Click
        dgvP_Ciudades.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_CIUDADES()))
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvP_Grupos.Cantidad_Selecciones() = 1 Then

            ventana_ver_alumnado.lbl_ver_alumnado.Text = dgvP_Grupos.Filas_Seleccionadas().Item(0).Cells("nombre_grupo").Value().ToString() & " - " & dgvP_Grupos.Filas_Seleccionadas().Item(0).Cells("nombre").Value().ToString()
            ventana_ver_alumnado.dgvP_ver_alumnado.Cargar_datos(hacer_consulta(CONSULTAS_ALUMNOS_POR_GRUPO(dgvP_Grupos.Filas_Seleccionadas().Item(0).Cells("id_grupo").Value())))
            ventana_ver_alumnado.ShowDialog()
            dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))


        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If dgvP_Alumnos.Cantidad_Selecciones() = 1 Then
            ventana_ver_calificaciones.lbl_nombre_alumno.Text = dgvP_Alumnos.Filas_Seleccionadas().Item(0).Cells("nombre_completo").Value().ToString()
            ventana_ver_calificaciones.dgvP_ver_notas_alumno.Cargar_datos(hacer_consulta(CONSULTAS_NOTAS_DE_ALUMNO_POR_MATERIA(dgvP_Alumnos.Filas_Seleccionadas().Item(0).Cells("CI").Value())))
            ventana_ver_calificaciones.ShowDialog()
            dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If
    End Sub

    Private Sub btnTabHistorial_Click(sender As Object, e As EventArgs) Handles btnTabHistorial.Click
        Me.tabPrincipal.SelectedTab = Me.tabHistorial
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        dgvP_Historial.Cargar_datos(hacer_consulta(CONSULTA_SELECT_HISTORIAL()))
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvP_Historial.Cantidad_Selecciones() = 1 Then
            ventana_historial.lbl_info.Text = dgvP_Historial.Filas_Seleccionadas().Item(0).Cells("foranea_CI_Persona").Value() & " a las " & dgvP_Historial.Filas_Seleccionadas().Item(0).Cells("fecha_hora").Value() & " desde " & dgvP_Historial.Filas_Seleccionadas().Item(0).Cells("IP").Value()
            ventana_historial.rch_query.Text = dgvP_Historial.Filas_Seleccionadas().Item(0).Cells("query").Value()
            ventana_historial.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If
    End Sub

    Private Sub ver_grupos_Click(sender As Object, e As EventArgs) Handles ver_grupos.Click
        If dgvP_Docentes.Cantidad_Selecciones() = 1 Then
            ventana_ver_grupos.lstGruposDeDocente.DataSource = hacer_consulta(GRUPOS_DEL_DOCENTE(dgvP_Docentes.Filas_Seleccionadas().Item(0).Cells("CI").Value()))
            ventana_ver_grupos.lstGruposDeDocente.DisplayMember = "Grupo"
            ventana_ver_grupos.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.tabPrincipal.SelectedTab = Me.tabCarambula
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_carambula_1.Click
        dgvP_carambula_1.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_1()))
    End Sub

    Private Sub btn_carambula_2_Click(sender As Object, e As EventArgs) Handles btn_carambula_2.Click
        dgvp_carambula_2.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_2()))
    End Sub

    Private Sub btn_carambula_3_Click(sender As Object, e As EventArgs) Handles btn_carambula_3.Click
        dgvp_carambula_3.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_3()))
    End Sub

    Private Sub btn_carambula_4_Click(sender As Object, e As EventArgs) Handles btn_carambula_4.Click
        dgvp_carambula_4.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_4()))
    End Sub

    Private Sub btn_carambula_5_Click(sender As Object, e As EventArgs) Handles btn_carambula_5.Click
        dgvp_carambula_5.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_5()))
    End Sub

    Private Sub btn_carambula_6_Click(sender As Object, e As EventArgs) Handles btn_carambula_6.Click
        dgvp_carambula_6.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_6()))
    End Sub

    Private Sub btn_carambula_7_Click(sender As Object, e As EventArgs) Handles btn_carambula_7.Click
        dgvp_carambula_7.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_7()))
    End Sub

    Private Sub btn_carambula_8_Click(sender As Object, e As EventArgs) Handles btn_carambula_8.Click
        dgvp_carambula_8.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_8()))
    End Sub

    Private Sub btn_carambula_9_Click(sender As Object, e As EventArgs) Handles btn_carambula_9.Click
        dgvp_carambula_9.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_9()))
    End Sub

    Private Sub btn_carambula_10_Click(sender As Object, e As EventArgs) Handles btn_carambula_10.Click
        dgvp_carambula_10.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_10()))
    End Sub

    Private Sub btn_carambula_11_Click(sender As Object, e As EventArgs) Handles btn_carambula_11.Click
        dgvp_carambula_11.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_11()))
    End Sub

    Private Sub btn_carambula_12_Click(sender As Object, e As EventArgs) Handles btn_carambula_12.Click
        dgvp_carambula_12.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_12()))
    End Sub

    Private Sub btn_carambula_13_Click(sender As Object, e As EventArgs) Handles btn_carambula_13.Click
        dgvp_carambula_13.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_13()))
    End Sub

    Private Sub btn_carambula_14_Click(sender As Object, e As EventArgs) Handles btn_carambula_14.Click
        dgvp_carambula_14.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_14()))
    End Sub
    Private Sub btn_carambula_15_Click(sender As Object, e As EventArgs) Handles btn_carambula_15.Click
        dgvp_carambula_15.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_15()))
    End Sub
    Private Sub btn_carambula_16_Click(sender As Object, e As EventArgs) Handles btn_carambula_16.Click
        dgvp_carambula_16.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_16()))
    End Sub

    Private Sub btn_carambula_17_Click(sender As Object, e As EventArgs) Handles btn_carambula_17.Click
        dgvp_carambula_17.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_17()))
    End Sub

    Private Sub btn_carambula_18_Click(sender As Object, e As EventArgs) Handles btn_carambula_18.Click
        dgvp_carambula_18.Cargar_datos(hacer_consulta(CONSULTAS_CARAMBULA_18()))
    End Sub

    Private Sub btnCiudadesCrear_Click(sender As Object, e As EventArgs) Handles btnCiudadesCrear.Click
        ventana_crear_ciudades.ShowDialog()
    End Sub

    Private Sub btnCiudadesModificar_Click(sender As Object, e As EventArgs) Handles btnCiudadesModificar.Click
        If Not dgvP_Ciudades.Cantidad_Selecciones() <> 1 Then
            ventana_crear_ciudades.Preparar_Ventana_Modificacion(dgvP_Ciudades.Filas_Seleccionadas().Item(0))
            ventana_crear_ciudades.ShowDialog()
        Else
            MsgBox(SELECCIONE_SOLO_UNO())

        End If
    End Sub
End Class