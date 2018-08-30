Public Class Invitado


    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click


        dvg_invitado.DataSource = hacer_consulta(CONSULTAS_INVITADOSALUMNOS(txtalumnosci))

    End Sub
End Class