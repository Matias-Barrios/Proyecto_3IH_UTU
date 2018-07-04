Imports System.Data.Odbc

Module InformixConexion
    Dim conexionODBC As New OdbcConnection

    Public Sub conectar(conn_strin As String)
        conexionODBC.ConnectionString = conn_strin
        Try
            conexionODBC.Open()
            Console.WriteLine("Conectado a Informix")
        Catch ex As OdbcException
            MsgBox(ex.ToString())
        End Try

    End Sub

    Public Sub cerrar_conexion()
        Console.WriteLine("Cerrando conexion!")
        conexionODBC.Close()
    End Sub
    Public Function hacer_consulta(query As String) As DataTable
        Try

            Dim dt As New DataTable()
            Dim da As OdbcDataAdapter = New OdbcDataAdapter(query, conexionODBC)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No se encontraron registros para : " + query)
            End If
            Return dt
        Catch ex As Exception
            MsgBox("Se ha producido una excepcion realizando la consulta : " + ex.ToString())

            Return New DataTable().Rows.Add({}).Table()

        End Try
        Return New DataTable
    End Function

    Public Function NOMBRE_USUARIO() As String
        Return Environment.GetEnvironmentVariable("GESTION_USERNAME")
    End Function

    Public Function CONTRASENIA() As String
        Return Environment.GetEnvironmentVariable("GESTION_PASSWORD")
    End Function


End Module
