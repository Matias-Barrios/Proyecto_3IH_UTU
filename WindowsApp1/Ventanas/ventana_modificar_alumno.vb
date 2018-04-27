Imports System.Text.RegularExpressions

Public Class ventana_modificar_alumno

    Private Sub btnModificarAlumnoAceptar_Click(sender As Object, e As EventArgs) Handles btnModificarAlumnoAceptar.Click
        If validar_inputs() Then
            ' TODO - Aca va el codigo que crea un nuevo usuario en al BD de tipo Alumno
        End If
    End Sub

    Private Function validar_inputs()

        If Regex.Matches(txtModificarAlumnoCI.Text, "^[0-9]{10}$").Count <> 1 Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If

        If Regex.Matches(txtModificarAlumnoPrimerNombre.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtModificarAlumnoSegundoNombre.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Segundo Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtModificarAlumnoPrimerApellido.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtModificarAlumnoSegundoApellido.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Segundo Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtModificarAlumnoEmail.Text, "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Email' correctamente!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnModificarAlumnoCancelar_Click(sender As Object, e As EventArgs) Handles btnModificarAlumnoCancelar.Click
        Me.Close()
    End Sub

    Private Sub ventana_modificar_alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtModificarAlumnoCI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtModificarAlumnoPrimerNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtModificarAlumnoSegundoNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtModificarAlumnoPrimerApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtModificarAlumnoSegundoApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtModificarAlumnoEmail, TipoValidacion.Solo_Email)
        datepickerModificarAlumnoFechaNacimiento.MaxDate = Date.Now
    End Sub
End Class