Public Class ventana_ver_grupos_docente
    Private Sub btn_ver_grupos_docente_aceptar_Click(sender As Object, e As EventArgs) Handles btn_ver_grupos_docente_aceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btn_ver_grupos_docente_cancelar_Click(sender As Object, e As EventArgs) Handles btn_ver_grupos_docente_cancelar.Click
        For Each seleccionado In chk_grupos_asignados_docente.CheckedItems
            hacer_consulta(CONSULTAS_DESVINCULAR_DOCENTE_GRUPO(seleccionado.Item("Instituto"), seleccionado.Item("foranea_id_grupo"), seleccionado.Item("foranea_id_asignatura")))
        Next
        chk_grupos_asignados_docente.DataSource = hacer_consulta(CONSULTA_GRUPOS_ASIGNADOS_DOCENTE(Val(txt_ver_cedula_docente.Text())))
        chk_grupos_asignados_docente.DisplayMember = "Asignacion"
    End Sub
End Class