Public Class ventana_crear_alumno
    Private Sub ventana_crear_alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearAlumnoCI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtCrearAlumnoPrimerNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoSegundoNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoPrimerApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoSegundoApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearAlumnoEmail, TipoValidacion.Solo_Email)
    End Sub

    Private Sub btnVentanaConfiguracionCancel_Click(sender As Object, e As EventArgs) Handles btnCrearAlumnoCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnVentanaConfiguracionOK_Click(sender As Object, e As EventArgs) Handles btnCrearAlumnoAceptar.Click
        If validar_inputs() Then
            ' TODO - Aca va el codigo que crea un nuevo usuario en al BD de tipo Alumno
        End If
    End Sub

    Private Function validar_inputs()
        If Not txtCrearAlumnoCI.Text Like "^[0-9]{10}$" Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If
        If Not txtCrearAlumnoCI.Text Like "^[a-zA-Z ]+$" Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If
        'Si ta todo bien ta todo bien
        Return True
    End Function
End Class