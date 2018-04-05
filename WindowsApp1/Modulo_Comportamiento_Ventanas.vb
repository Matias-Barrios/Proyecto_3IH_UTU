Module Modulo_Comportamiento_Ventanas
    Public Sub centrarVentana(ventana As Form)
        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim x As Integer = boundWidth - ventana.Width
        Dim y As Integer = boundHeight - ventana.Height
        ventana.Location = New Point(x / 2, y / 2)
    End Sub
    Public Sub maximizarVentana(ventana As Form)
        ventana.WindowState = FormWindowState.Maximized
    End Sub
    Public Sub minimizarVentana(ventana As Form)
        ventana.WindowState = FormWindowState.Minimized
    End Sub
End Module
