Public Class DGVPaginado
    Private total_los_datos = New DataTable
    Private total As Integer = 0
    Private pagina As Integer = 0
    Private maximo_paginas As Integer = 0
    Private items_por_pagina As Integer = 50

    Public Sub Cargar_datos(dt As DataTable)
        total_los_datos = dt
        total = dt.Rows.Count
        maximo_paginas = Math.Ceiling(total / items_por_pagina)
        lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas
        dgv_Vista.DataSource = Split(total_los_datos)
        Habilitar_Botones()
    End Sub

    Private Function Split(dt As DataTable) As DataTable
        lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas
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
End Class
