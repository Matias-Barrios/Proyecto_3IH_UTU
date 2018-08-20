Module Configuraciones
    ' "Driver={IBM INFORMIX ODBC DRIVER (64-bit)};Database=gestion_utu;Host=45.79.7.217;Server=miServidor;Service=50000;Protocol=onsoctcp;UID=" & NOMBRE_USUARIO() & ";PWD=" & CONTRASENIA() & ";Client_Locale=en_US.CP1252;DB_LOCALE=en_US.819;"
    Public Class ConexionODBC
        Public Property Driver As String
        Public Property Ip_servidor As String
        Public Property Host As String
        Public Property ServerInstance As String
        Public Property Servicio As String
        Public Property Protocolo As String
        Public Property LOCALE_Cliente As String
        Public Property LOCALE_DB As String
    End Class

    Public Class Configuracion
        Public Property ConexionODBC As ConexionODBC
    End Class

    Dim Conf_App As Configuracion

    Sub Cargar_Configuracion(archivo As String)

    End Sub

    Function GET_Configuracion() As String
        Return "a"
    End Function


End Module
