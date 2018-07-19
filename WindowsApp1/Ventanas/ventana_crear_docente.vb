Public Class ventana_crear_docente
    Private Sub ventana_crear_docente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearDocenteCI, TipoValidacion.Solo_cedulas)
        Adherir_Validacion(txtCrearDocenteNombre, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearDocenteApellido, TipoValidacion.Solo_nombres)
        Adherir_Validacion(txtCrearDocenteEmail, TipoValidacion.Solo_Email)
        datepickerCrearDocenteFechaNacimiento.MaxDate = Date.Now
    End Sub

    Private Sub btnCrearDocenteCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


End Class