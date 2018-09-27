Imports System.Text.RegularExpressions
Imports Validar_Entradas
Public Class DGVPaginado
    Private todos_los_datos = New DataTable
    Private total As Integer = 0
    Private pagina As Integer = 0
    Private maximo_paginas As Integer = 0
    Private items_por_pagina As Integer = 50

    Private filtro_tmp As String = ""
    Private filtro As String = ""


    Public Sub Cargar_datos(dt As DataTable)
        Adherir_Validacion(txtFiltro, TipoValidacion.Solo_numeros_o_letras)
        filtro_tmp = ""
        filtro = ""
        If dt.Rows.Count() <> 0 Then

            If dt.Rows.Count() <= items_por_pagina Then

                pnl_controles.Visible = False

            Else

                pnl_controles.Visible = True

            End If
            todos_los_datos = dt
            total = dt.Rows.Count
            maximo_paginas = Math.Ceiling(total / items_por_pagina)
            lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas & " Total de rows : " & total
            dgv_Vista.DataSource = Split(todos_los_datos)
            btn_Prev.Enabled = False
            btn_Siguiente.Enabled = True
            btn_UltimaPagina.Enabled = True
            btn_Primera.Enabled = True
            Habilitar_Botones()
            For Each column In dgv_Vista.Columns
                If Type.GetTypeCode(column.ValueType) = TypeCode.Int32 Then
                    filtro_tmp = filtro_tmp & "  Convert(" & column.Name() & ", 'System.String') " & " LIKE " & "'*XXXXXXELFILTROVAAQUIELFILTROVAAQUIELFILTROVAAQUIELFILTROVAAQUIXXXXXXX*'" & " OR"
                End If
                If Type.GetTypeCode(column.ValueType) = TypeCode.String Then
                    filtro_tmp = filtro_tmp & " " & column.Name() & " LIKE '*" & "XXXXXXELFILTROVAAQUIELFILTROVAAQUIELFILTROVAAQUIELFILTROVAAQUIXXXXXXX" & "*' OR"
                End If

            Next
            Dim rgx As New Regex(" OR$")
            filtro_tmp = rgx.Replace(filtro_tmp, "")

        Else
            btn_Prev.Enabled = False
            btn_Siguiente.Enabled = False
            btn_UltimaPagina.Enabled = False
            btn_Primera.Enabled = False
        End If


    End Sub

    Private Function Split(dt As DataTable) As DataTable

        Dim data_tmp = New DataTable
        If dt.Select(filtro).Count = 0 Then
            total = 0
            maximo_paginas = 0
            lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas & " Total de rows : " & total
            Habilitar_Botones()
            Return (New DataTable)
        Else
            data_tmp = dt.Select(filtro).Skip(items_por_pagina * pagina).Take(items_por_pagina).CopyToDataTable()
            total = dt.Select(filtro).Count
            maximo_paginas = Math.Ceiling(total / items_por_pagina)
            Habilitar_Botones()
            lbl_vista_numeracion.Text = (pagina + 1) & "/" & maximo_paginas & " Total de rows : " & total
            Return data_tmp
        End If
    End Function


    Private Sub Habilitar_Botones()

        If pagina = 0 Then
            btn_Prev.Enabled = False
            btn_Primera.Enabled = False
        Else
            btn_Prev.Enabled = True
            btn_Primera.Enabled = True
        End If

        If pagina = (maximo_paginas - 1) Then
            btn_Siguiente.Enabled = False
            btn_UltimaPagina.Enabled = False
        Else
            btn_Siguiente.Enabled = True
            btn_UltimaPagina.Enabled = True
        End If
        If total = 0 Then
            btn_Prev.Enabled = False
            btn_Siguiente.Enabled = False
            btn_UltimaPagina.Enabled = False
            btn_Primera.Enabled = False
        End If


    End Sub

    Private Sub btn_Primera_Click_1(sender As Object, e As EventArgs) Handles btn_Primera.Click
        pagina = 0
        dgv_Vista.DataSource = Split(todos_los_datos)
    End Sub

    Private Sub btn_UltimaPagina_Click(sender As Object, e As EventArgs) Handles btn_UltimaPagina.Click
        pagina = maximo_paginas - 1
        dgv_Vista.DataSource = Split(todos_los_datos)
    End Sub

    Private Sub btn_Prev_Click(sender As Object, e As EventArgs) Handles btn_Prev.Click
        pagina = pagina - 1
        dgv_Vista.DataSource = Split(todos_los_datos)
    End Sub

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        pagina = pagina + 1
        dgv_Vista.DataSource = Split(todos_los_datos)
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


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        pagina = 0
        If Not String.IsNullOrEmpty(txtFiltro.Text) Then
            Dim rgx As New Regex("XXXXXXELFILTROVAAQUIELFILTROVAAQUIELFILTROVAAQUIELFILTROVAAQUIXXXXXXX")
            filtro = rgx.Replace(filtro_tmp, txtFiltro.Text)
            Me.dgv_Vista.DataSource = Split(todos_los_datos)
        Else
            filtro = ""
            Me.dgv_Vista.DataSource = Split(todos_los_datos)
        End If
    End Sub

    Public Function Obtener_datos_totales() As DataTable
        Return todos_los_datos
    End Function

End Class
