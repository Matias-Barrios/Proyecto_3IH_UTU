Imports System.Text.RegularExpressions

Public Class ventana_crear_alumno
    Private es_modificacion = False
    Private alumno As DataGridViewRow
    Private CI_original As Integer

    Private Sub ventana_crear_alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearAlumnoCI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtCrearAlumnoPrimerNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoSegundoNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoPrimerApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoSegundoApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoEmail, TipoValidacion.Solo_Email)
        datepickerCrearAlumnoFechaNacimiento.MaxDate = Date.Now
    End Sub


    Private Function validar_inputs()

        If Regex.Matches(txtCrearAlumnoCI.Text, CEDULA_VALIDA()).Count <> 1 Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoPrimerNombre.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoPrimerApellido.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoEmail.Text, EMAIL_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Email' correctamente!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnModificarUsuario_Cancelar_Click(sender As Object, e As EventArgs) Handles btnModificarUsuario_Cancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnModificar_Usuario_Aceptar_Click(sender As Object, e As EventArgs) Handles btnModificar_Usuario_Aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_ALUMNO(txtCrearAlumnoCI.Text, txtCrearAlumnoPrimerNombre.Text, txtCrearAlumnoSegundoNombre.Text, txtCrearAlumnoPrimerApellido.Text, txtCrearAlumnoSegundoApellido.Text, datepickerCrearAlumnoFechaNacimiento.Value(), txtCrearAlumnoEmail.Text, chkHaceProyecto.Checked, True))
                Ventana_Principal.dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Alumno()
                hacer_consulta(MODIFICAR_ALUMNO(CI_original, alumno, True))
                Ventana_Principal.dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
                Me.Dispose()
            End If
        End If

    End Sub
    Public Sub Preparar_Ventana_Modificacion(al As DataGridViewRow)
        Try
            es_modificacion = True
            alumno = al
            CI_original = alumno.Cells("CI").Value()
            txtCrearAlumnoCI.Text = alumno.Cells("CI").Value()
            txtCrearAlumnoPrimerNombre.Text = alumno.Cells("primer_nombre").Value()
            txtCrearAlumnoSegundoNombre.Text = alumno.Cells("segundo_nombre").Value()
            txtCrearAlumnoPrimerApellido.Text = alumno.Cells("primer_apellido").Value()
            txtCrearAlumnoSegundoApellido.Text = alumno.Cells("segundo_apellido").Value()
            txtCrearAlumnoEmail.Text = alumno.Cells("email").Value()
            txtModificarAlumnoJuici_Final.Text = alumno.Cells("juicio_final").Value()
            chkHaceProyecto.Checked = alumno.Cells("hace_proyecto").Value()
            datepickerCrearAlumnoFechaNacimiento.Value = alumno.Cells("fecha_nacimiento").Value()
            pnlAlumnoAtributosModificacion.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Alumno()
        alumno.Cells("CI").Value = txtCrearAlumnoCI.Text
        alumno.Cells("CI").Value = txtCrearAlumnoCI.Text
        alumno.Cells("primer_nombre").Value = txtCrearAlumnoPrimerNombre.Text
        alumno.Cells("segundo_nombre").Value = txtCrearAlumnoSegundoNombre.Text
        alumno.Cells("primer_apellido").Value = txtCrearAlumnoPrimerApellido.Text
        alumno.Cells("segundo_apellido").Value = txtCrearAlumnoSegundoApellido.Text
        alumno.Cells("email").Value = txtCrearAlumnoEmail.Text
        alumno.Cells("juicio_final").Value = txtModificarAlumnoJuici_Final.Text
        alumno.Cells("hace_proyecto").Value = chkHaceProyecto.Checked
        alumno.Cells("fecha_nacimiento").Value = datepickerCrearAlumnoFechaNacimiento.Value
    End Sub



End Class