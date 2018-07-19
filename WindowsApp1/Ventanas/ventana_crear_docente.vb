Imports System.Text.RegularExpressions
Public Class ventana_crear_docente
    Private es_modificacion = False
    Private docente As New DataGridViewRow()
    Private CI_original As Integer

    Private Sub ventana_crear_docente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearDocenteCI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtCrearDocentePrimerNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearDocentePrimerApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearDocenteSegundoNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearDocenteSegundoApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearDocenteEmail, TipoValidacion.Solo_Email)
        datepickerCrearDocenteFechaNacimiento.MaxDate = Date.Now
    End Sub

    Private Sub btnCrearDocenteCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCrearDocente_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrearDocente_Aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_DOCENTE(txtCrearDocenteCI.Text, txtCrearDocentePrimerNombre.Text, txtCrearDocenteSegundoNombre.Text, txtCrearDocentePrimerApellido.Text, txtCrearDocenteSegundoApellido.Text, datepickerCrearDocenteFechaNacimiento.Value, txtCrearDocenteEmail.Text, nudCrearDocenteGrado.Value, False))
                Ventana_Principal.dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Docente()
                hacer_consulta(MODIFICAR_ALUMNO(CI_original, docente, True))
                Ventana_Principal.dgvP_Alumnos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_ALUMNOS()))
                Me.Dispose()
            End If
        End If
    End Sub
    Public Sub Preparar_Ventana_Modificacion(al As DataGridViewRow)
        Try
            es_modificacion = True
            docente = al
            CI_original = docente.Cells("CI").Value()
            txtCrearDocenteCI.Text = docente.Cells("CI").Value()
            txtCrearDocentePrimerNombre.Text = docente.Cells("primer_nombre").Value()
            txtCrearDocenteSegundoNombre.Text = docente.Cells("segundo_nombre").Value()
            txtCrearDocentePrimerApellido.Text = docente.Cells("primer_apellido").Value()
            txtCrearDocenteSegundoApellido.Text = docente.Cells("segundo_apellido").Value()
            txtCrearDocenteEmail.Text = docente.Cells("email").Value()
            nudCrearDocenteGrado.Value = docente.Cells("grado").Value()
            datepickerCrearDocenteFechaNacimiento.Value = docente.Cells("fecha_nacimiento").Value()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Docente()

        docente.Cells("CI").Value = txtCrearDocenteCI.Text
        docente.Cells("primer_nombre").Value = txtCrearDocentePrimerNombre.Text
        docente.Cells("segundo_nombre").Value = txtCrearDocenteSegundoNombre.Text
        docente.Cells("primer_apellido").Value = txtCrearDocentePrimerApellido.Text
        docente.Cells("segundo_apellido").Value = txtCrearDocenteSegundoApellido.Text
        docente.Cells("email").Value = txtCrearDocenteEmail.Text
        docente.Cells("grado").Value = nudCrearDocenteGrado.Value
        docente.Cells("fecha_nacimiento").Value = datepickerCrearDocenteFechaNacimiento.Value
    End Sub

    Private Function validar_inputs()

        If Regex.Matches(txtCrearDocenteCI.Text, CEDULA_VALIDA()).Count <> 1 Then
            MsgBox("Debe completar el campo 'CI' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearDocentePrimerNombre.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Nombre' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearDocentePrimerApellido.Text, NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Primer Apellido' correctamente!")
            Return False
        End If

        If Regex.Matches(txtCrearDocenteEmail.Text, EMAIL_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Email' correctamente!")
            Return False
        End If


        'Si ta todo bien ta todo bien
        Return True
    End Function

    Private Sub btnCrearDocenteCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCrearDocenteCancelar.Click
        Ventana_Principal.Show()
        Me.Dispose()
    End Sub
End Class