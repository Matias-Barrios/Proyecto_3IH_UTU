Module Impresion

    Dim DataGridView_to_Print As DataGridView = Nothing

    Public Sub Imprimir(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim bm As New Bitmap(DataGridView_to_Print.Width, DataGridView_to_Print.Height)
        DataGridView_to_Print.DrawToBitmap(bm, New Rectangle(0, 0, DataGridView_to_Print.Width, DataGridView_to_Print.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Public Sub Apuntar_Impresion(data_table As DataTable)
        DataGridView_to_Print.DataSource = data_table
    End Sub

End Module
