Public Class DGVPaginado
    Private total_los_datos = New DataTable
    Private total As Integer = 0
    Private pagina As Integer = 0
    Private maximo_paginas As Integer = 0
    Private items_por_pagina As Integer = 50

    Public Sub Cargar_datos(dt As DataTable)
        If dt.Rows.Count() <> 0 Then
            total_los_datos = dt
            total = dt.Rows.Count
            maximo_paginas = Math.Ceiling(total / items_por_pagina)
            lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas & " Total de rows : " & total
            dgv_Vista.DataSource = Split(total_los_datos)
            btn_Prev.Enabled = False
            btn_Siguiente.Enabled = True
            btn_UltimaPagina.Enabled = True
            btn_Primera.Enabled = True
            Habilitar_Botones()
        Else
            btn_Prev.Enabled = False
            btn_Siguiente.Enabled = False
            btn_UltimaPagina.Enabled = False
            btn_Primera.Enabled = False
        End If

    End Sub

    Private Function Split(dt As DataTable) As DataTable
        lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas & " Total de rows : " & total
        Habilitar_Botones()
        Return dt.Select.Skip(items_por_pagina * pagina).Take(items_por_pagina).CopyToDataTable()

    End Function


    Private Sub Habilitar_Botones()
        If pagina = 0 Then
            btn_Prev.Enabled = False
        Else
            btn_Prev.Enabled = True
        End If

        If pagina = (maximo_paginas - 1) Then
            btn_Siguiente.Enabled = False
        Else
            btn_Siguiente.Enabled = True
        End If
    End Sub

    Private Sub btn_Primera_Click_1(sender As Object, e As EventArgs) Handles btn_Primera.Click
        pagina = 0
        dgv_Vista.DataSource = Split(total_los_datos)
    End Sub

    Private Sub btn_UltimaPagina_Click(sender As Object, e As EventArgs) Handles btn_UltimaPagina.Click
        pagina = maximo_paginas - 1
        dgv_Vista.DataSource = Split(total_los_datos)
    End Sub

    Private Sub btn_Prev_Click(sender As Object, e As EventArgs) Handles btn_Prev.Click
        pagina = pagina - 1
        dgv_Vista.DataSource = Split(total_los_datos)
    End Sub

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        pagina = pagina + 1
        dgv_Vista.DataSource = Split(total_los_datos)
    End Sub
    Public Function Filas_Seleccionadas() As DataGridViewSelectedRowCollection
        Return dgv_Vista.SelectedRows()
    End Function
    Public Sub Set_MultiSelect(opcion As Boolean)
        dgv_Vista.MultiSelect = opcion
    End Sub

    Public Function Cantidad_Selecciones() As Integer
        Return dgv_Vista.Rows.GetRowCount(DataGridViewElementStates.Selected)
    End Function


End Class
