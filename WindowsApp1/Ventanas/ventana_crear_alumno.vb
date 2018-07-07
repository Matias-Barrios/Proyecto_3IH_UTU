Imports System.Text.RegularExpressions

Public Class ventana_crear_alumno
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
        If validar_inputs() Then
            hacer_consulta(CREAR_ALUMNO(txtCrearAlumnoCI.Text, txtCrearAlumnoPrimerNombre.Text, txtCrearAlumnoSegundoNombre.Text, txtCrearAlumnoPrimerApellido.Text, txtCrearAlumnoSegundoApellido.Text, datepickerCrearAlumnoFechaNacimiento.Value(), txtCrearAlumnoEmail.Text, chkHaceProyecto.Checked, True))
            Me.Dispose()
            Ventana_Principal.dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
        End If
    End Sub

End Class