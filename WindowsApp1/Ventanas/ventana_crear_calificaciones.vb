
Public Class ventana_crear_calificaciones

        Private Sub ventana_crear_calificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            Dim hola = Consultas.uno
            Dim pepe = Consultas.dos
            Dim cacho = Consultas.tres
        chkCrearCalificacion_Asignar_A.DataSource = hacer_consulta(CONSULTAS_SELECT_ALUMNOS_CREAR_CALIFICACIONES_LISTBOX())
        chkCrearCalificacion_Asignar_A.DisplayMember = "nombre_alumno"

        End Sub


        Public Function CONSULTAS_SELECT_ALUMNOS_CREAR_CALIFICACIONES_LISTBOX() As String


        Dim query As String = "select foranea_ci_alumno,
        (select Personas.primer_nombre || ' ' || Personas.primer_apellido from Personas where Personas.CI = foranea_ci_alumno) AS nombre_alumno
        from relacion_alumno_asignatura_grupos
        where foranea_id_grupo = " & dos & "
        And foranea_id_asignatura = " & tres & "
        And foranea_id_instituto = " & uno
        Console.WriteLine("Calificacion Alumnos: " & query)
        Return query
    End Function

        Private Function Validar() As Boolean
            If String.IsNullOrEmpty(txtCrearCalificaciones_Nombre_Descriptivo.Text.Trim()) Then
                MsgBox("Debe ingresar un valor a nombre descriptivo!")
                Return False
            End If
            Return True
        End Function

        Private Sub btnCrearCalificacion_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrearCalificacion_Aceptar.Click
            If Validar() Then
                For Each alumno In chkCrearCalificacion_Asignar_A.CheckedItems

                    hacer_consulta(CREAR_CALIFICACION(USUARIO_LOGUEADO.CI, alumno.Row.Item("foranea_ci_alumno"), Ventana_Principal.cboAsignatura.SelectedItem.Row.Item("id_asignatura"), Ventana_Principal.cboGrupo.SelectedItem.Row.Item("id_grupo"), Ventana_Principal.cboInstituto.SelectedItem.Row.Item("id_instituto"), txtCrearCalificaciones_Nombre_Descriptivo.Text.Trim(), lstCrearCalificacion_tipo.SelectedItem, Now.Date, rchCrearCalificacion_Comentario.Text.Trim(), nudCrearCalificacion_Nota.Value(), True))
                Next

                MsgBox(MENSAJE_EXITO)

            Ventana_Principal.dgvP_Calificaciones.Cargar_datos(hacer_consulta(COMBOBOX_CALIFICACIONES_COMPLETA(Ventana_Principal.cboAsignatura, Ventana_Principal.cboInstituto, Ventana_Principal.cboGrupo)))
            Me.Dispose()
        End If
        End Sub

        Private Sub btnCrearCalificacion_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCrearCalificacion_Cancelar.Click
            Me.Dispose()
        End Sub
    End Class
