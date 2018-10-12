Public Class Invitado

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        WindowsApp1.Ventana_Bienvenida.Show()
    End Sub

    Private Sub Invitado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtalumnosci, TipoValidacion.Solo_cedulas)
    End Sub

    Private Sub btnconsultar_Click_1(sender As Object, e As EventArgs) Handles btnconsultar.Click
        If Persona_Existe(Val(txtalumnosci.Text)) Then
            DgvCalificacion.Cargar_datos(hacer_consulta(CONSULTAS_INVITADOSALUMNOS(txtalumnosci)))
            lblvalornotapro.Text = hacer_consulta(CONSULTA_PROMEDIO_FINAL_PROYECTO(txtalumnosci)).Rows(0).Item(0)
            lblnotafinalaprobacion.Text = hacer_consulta(CONSULTA_PROMEDIO_FINAL_ASIGNATURA(txtalumnosci)).Rows(0).Item(0)
        Else
            MsgBox("Parece que esa persona no existe!")
        End If


    End Sub

End Class