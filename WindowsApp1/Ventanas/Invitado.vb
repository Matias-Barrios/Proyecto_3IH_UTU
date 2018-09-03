Public Class Invitado

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        WindowsApp1.Ventana_Bienvenida.Show()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click


        DgvCalificacion.Cargar_datos(hacer_consulta(CONSULTAS_INVITADOSALUMNOS(txtalumnosci)))

        lblvalornotapro.Text = hacer_consulta(CONSULTA_PROMEDIO_FINAL_PROYECTO(txtalumnosci)).Rows(0).Item(0)
        lblnotafinalaprobacion.Text = hacer_consulta(CONSULTA_PROMEDIO_FINAL_ASIGNATURA(txtalumnosci)).Rows(0).Item(0)

    End Sub




End Class