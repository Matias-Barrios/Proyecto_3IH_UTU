Imports System.Text.RegularExpressions

Public Class ventana_crear_grupo
    Private es_modificacion = False
    Private elGrupo As DataGridViewRow
    Private id_grupo_original As Integer


    Private Sub btnCrearGrupo_Cancelar_Click(sender As Object, e As EventArgs) Handles btnCrearGrupo_Cancelar.Click
        Ventana_Principal.Show()
        Me.Dispose()
    End Sub

    Private Sub CrearGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtCrearGrupoNombre, TipoValidacion.Solo_numeros_letras_mayusculas_sin_espacio)
        lstCrearGrupo_Turno.SelectedIndex = 0
        lstCrearGrupo_Instituto.DataSource = hacer_consulta(CONSULTAS_SELECT_INSTITUTOS_PARA_LISTBOX())
        lstCrearGrupo_Instituto.DisplayMember = "nombre"
        lstCrearGrupo_Orientacion.DataSource = hacer_consulta(CONSULTAS_SELECT_ORIENTACIONES_PARA_LISTBOX())
        lstCrearGrupo_Orientacion.DisplayMember = "nombre_orientacion"
        If es_modificacion Then
            lstCrearGrupo_Instituto.SetSelected(lstCrearGrupo_Instituto.FindString(elGrupo.Cells("nombre").Value()), True)
        End If

    End Sub

    Private Sub btnCrearGrupo_Aceptar_Click(sender As Object, e As EventArgs) Handles btnCrearGrupo_Aceptar.Click
        If Not es_modificacion Then
            If validar_inputs() Then
                hacer_consulta(CREAR_GRUPO(txtCrearGrupoNombre.Text, lstCrearGrupo_Turno.SelectedItem.ToString(), lstCrearGrupo_Instituto.SelectedItem.Item("id_instituto"), lstCrearGrupo_Orientacion.SelectedItem.Item("id_orientacion")))
                Ventana_Principal.dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
                Me.Dispose()
            End If
        Else
            If validar_inputs() Then
                Preparar_Grupo()
                hacer_consulta(MODIFICAR_GRUPO(id_grupo_original, elGrupo, lstCrearGrupo_Instituto.SelectedItem.Item("id_instituto"), lstCrearGrupo_Orientacion.SelectedItem.Item("id_orientacion")))
                Ventana_Principal.dgvP_Grupos.Cargar_datos(hacer_consulta(CONSULTAS_SELECT_GRUPOS()))
                Me.Dispose()
            End If
        End If

    End Sub
    Public Sub Preparar_Ventana_Modificacion(grupo As DataGridViewRow)
        Try
            es_modificacion = True
            elGrupo = grupo
            id_grupo_original = grupo.Cells("id_grupo").Value()
            txtCrearGrupoNombre.Text = grupo.Cells("nombre_grupo").Value()



        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub Preparar_Grupo()
        elGrupo.Cells("nombre_grupo").Value = txtCrearGrupoNombre.Text
    End Sub

    Private Function validar_inputs()

        If Regex.Matches(txtCrearGrupoNombre.Text, GRUPO_NOMBRE_VALIDO()).Count <> 1 Then
            MsgBox("Debe completar el campo 'Nombre grupo' correctamente!")
            Return False
        End If

        'Si ta todo bien ta todo bien
        Return True
    End Function

End Class