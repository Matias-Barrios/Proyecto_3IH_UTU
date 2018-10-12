Public Class ventana_ver_grupos
    Private Sub lstGruposDeDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGruposDeDocente.SelectedIndexChanged
        dgvP_alumnos_del_grupo.Cargar_datos(hacer_consulta(CONSULTAS_ALUMNOS_POR_GRUPO(lstGruposDeDocente.SelectedItem("Id"))))
    End Sub
End Class