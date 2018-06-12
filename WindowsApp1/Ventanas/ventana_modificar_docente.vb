Imports System.Text.RegularExpressions

Public Class ventana_modificar_docente


    Private Function validar_inputs()

        If Regex.Matches(txtModificarDocenteCI.Text, "^[0-9]{10}$").Count <> 1 Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If

        If Regex.Matches(txtModificarDocenteNombre.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If


        If Regex.Matches(txtModificarDocenteApellido.Text, "^[a-zA-Z][a-zA-Z ]+$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Apellido' correctamente!")
            Return False
        End If


        If Regex.Matches(txtModificarDocenteEmail.Text, "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$").Count <> 1 Then
            MsgBox("Debe completar el campo 'Email' correctamente!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnModificarDocenteAceptar_Click(sender As Object, e As EventArgs) Handles btnModificarDocenteAceptar.Click
        If validar_inputs() Then
            ' TODO - Aca va el codigo que crea un nuevo usuario en al BD de tipo Alumno
        End If
    End Sub

    Private Sub ventana_modificar_docente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtModificarDocenteCI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtModificarDocenteNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtModificarDocenteApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtModificarDocenteEmail, TipoValidacion.Solo_Email)
        datepickerModificarDocenteFechaNacimiento.MaxDate = Date.Now
    End Sub

    Private Sub btnModificarDocenteCancelar_Click(sender As Object, e As EventArgs) Handles btnModificarDocenteCancelar.Click
        Me.Close()
    End Sub


End Class