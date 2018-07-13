Imports System.Text.RegularExpressions
Public Class DGVPaginado
    Private todos_los_datos = New DataTable
    Private total As Integer = 0
    Private pagina As Integer = 0
    Private maximo_paginas As Integer = 0
    Private items_por_pagina As Integer = 50
    Dim columnas_escondidas As New List(Of String)
    Private filtro As String = ""
    Private columnas As DataGridViewColumnCollection

    Public Sub Cargar_datos(dt As DataTable)
        If dt.Rows.Count() <> 0 Then
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
        Else
            btn_Prev.Enabled = True
        End If

        If pagina = (maximo_paginas - 1) Then
            btn_Siguiente.Enabled = False
        Else
            btn_Siguiente.Enabled = True
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

    Private Sub dgv_Vista_CellContentClick(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv_Vista.DataBindingComplete
        For Each columna In columnas_escondidas
            Try
                dgv_Vista.Columns(columna).Visible = False
            Catch ex As Exception
                MsgBox("Error ocultando columna : " & columna & "  " & ex.ToString())
            End Try
        Next
        columnas = dgv_Vista.Columns
    End Sub
    Public Sub Esconder_columnas(columnas As String)
        If Not Regex.Match(columnas, ESCONDER_COLUMNAS_INPUT_VALIDO()).Success Then
            MsgBox("No se pudieron esconder las columnas. El input tiene un formato invalido : " & columnas)
        Else
            For Each column In columnas.Split(",")
                columnas_escondidas.Add(column)
            Next
        End If
    End Sub
    Public Sub Mostrar_Columnas(columnas As String)
        columnas_escondidas.Clear()
    End Sub
    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        pagina = 0
        filtro = ""
        'Console.WriteLine("Columnas : " & columnas.DisplayedColumnCount(False))
        If Not String.IsNullOrEmpty(txtFiltro.Text) Then
            For Each column In columnas
                If Type.GetTypeCode(column.ValueType) = TypeCode.Int32 And Regex.Match(Trim(txtFiltro.Text), "^[0-9]+$").Success Then

                    filtro = filtro & " " & column.Name() & " = " & txtFiltro.Text & " OR"
                End If
                If Type.GetTypeCode(column.ValueType) = TypeCode.String Then

                    filtro = filtro & " " & column.Name() & " LIKE '*" & txtFiltro.Text & "*' OR"
                End If

            Next
            Dim rgx As New Regex(" OR$")
            filtro = rgx.Replace(filtro, "")
            Console.WriteLine("Filtro " & filtro)
            Me.dgv_Vista.DataSource = Split(todos_los_datos)
        Else
            filtro = ""
            Me.dgv_Vista.DataSource = Split(todos_los_datos)
        End If
    End Sub
End Class
