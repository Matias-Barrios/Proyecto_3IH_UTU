Public Class ventana_ver_alumnado
    Private Sub btnver_alumnado_aceptar_Click(sender As Object, e As EventArgs) Handles btnver_alumnado_aceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCrearAsignaturaCancelar_Click(sender As Object, e As EventArgs) Handles btnCrearAsignaturaCancelar.Click
        If dgvP_ver_alumnado.Cantidad_Selecciones() > 0 Then
            If MessageBox.Show(SEGURO_DESVINCULAR(), "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                For Each fila In dgvP_ver_alumnado.Filas_Seleccionadas()
                    hacer_consulta(CONSULTAS_DESVINCULAR_ALUMNO_GRUPO(fila.Cells("CI").Value()))
                Next
                dgvP_ver_alumnado.Cargar_datos(hacer_consulta(CONSULTAS_ALUMNOS_POR_GRUPO(Ventana_Principal.dgvP_Grupos.Filas_Seleccionadas().Item(0).Cells("id_grupo").Value())))
            End If
        Else
            MsgBox(SELECCIONE_AL_MENOS_UNO())
        End If
    End Sub
End Class