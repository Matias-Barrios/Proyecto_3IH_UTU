Module Modulo_Comportamiento_Ventanas

    Public Sub verificarRol(rol As String)
        If rol = "Admin" Then
            Ventana_Principal.pnlCalificaciones_Comboboxes.Visible = False
        End If
        If rol = "Administrativo" Then
            Ventana_Principal.btnUsuarios.Visible = False
            Ventana_Principal.btnTareas.Visible = False
            Ventana_Principal.btnTabHistorial.Visible = False
        End If

        If rol = "Docente" Then
            Ventana_Principal.btnMaterias.Visible = False
            Ventana_Principal.btn_Grupos.Visible = False
            Ventana_Principal.btnDocentes.Visible = False
            Ventana_Principal.btnVentanaPrincipalInstitutos.Visible = False
            Ventana_Principal.btnVentanaPrincipalOrientaciones.Visible = False
            Ventana_Principal.btnCiudad.Visible = False
            Ventana_Principal.btnUsuarios.Visible = False
            Ventana_Principal.btnAlumnos.Visible = False
            Ventana_Principal.btnTareas.Location = New Point(12, 101)
            Ventana_Principal.btnTabHistorial.Visible = False
            Ventana_Principal.btnVentanaPrincipal_Admins_Administrativos.Visible = False
        End If

    End Sub
    Public Function Decodificar_Historial(hist As DataTable)
        For Each row In hist.Rows
            row.Item("query") = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(row.Item("query")))
        Next
        Return hist
    End Function
    Public Sub Rellenar_Control(un_control As Object, query As String)
        un_control.DataSource = hacer_consulta(query)
    End Sub

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
    Public Sub removerMarco(ventana As Form)
        ventana.FormBorderStyle = FormBorderStyle.None
    End Sub
    Public Function porcentajeAncho(ventana As Object, porcentaje As Integer)
        Return ((ventana.Width * porcentaje) / 100)
    End Function
    Public Function porcentajeAlto(ventana As Object, porcentaje As Integer)
        Return ((ventana.Height * porcentaje) / 100)
    End Function
    Public Sub LogOff()
        WindowsApp1.Ventana_Login.txtNombreUsuario.Text = ""
        WindowsApp1.Ventana_Login.txtPassword.Text = ""
        WindowsApp1.Ventana_Principal.Dispose()
        WindowsApp1.Ventana_Login.Show()
    End Sub
    Public Sub Esconder_todos_los_paneles(ventana As Object)
        ventana.pnlAlumnos.Hide()
        ventana.pnlMaterias.Hide()
    End Sub

End Module
