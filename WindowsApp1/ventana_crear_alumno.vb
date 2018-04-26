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

    Private Sub btnCrearAlumnoCancelar_Click(sender As Object, e As EventArgs) Handles btnCrearAlumnoCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCrearAlumnoAceptar_Click(sender As Object, e As EventArgs) Handles btnCrearAlumnoAceptar.Click
        If validar_inputs() Then
            ' TODO - Aca va el codigo que crea un nuevo usuario en al BD de tipo Alumno
        End If
    End Sub

    Private Function validar_inputs()

        If Regex.Matches(txtCrearAlumnoCI.Text, "^[0-9]{10}$").Count <> 1 Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoPrimerNombre.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoSegundoNombre.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Segundo Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoPrimerApellido.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoSegundoApellido.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Segundo Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearAlumnoEmail.Text, "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Email' correctamente!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function
End Class