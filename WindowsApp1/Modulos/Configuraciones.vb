Imports System.IO
Imports Newtonsoft.Json

Module Configuraciones
    ' 
    Public Class ConexionODBC
        Public Property Driver As String
        Public Property Database As String
        Public Property Host As String
        Public Property ServerInstance As String
        Public Property Servicio As String
        Public Property Protocolo As String
        Public Property LOCALE_Cliente As String
        Public Property LOCALE_DB As String
        Public Property ENV_USERNAME As String
        Public Property ENV_PASSWORD As String

    End Class

    Public Class Configuracion
        Public Property ConexionODBC As ConexionODBC
    End Class

    Dim Conf_App As Configuracion

    Sub Cargar_Configuracion(archivo As String)
        Try
            Conf_App = JsonConvert.DeserializeObject(Of Configuracion)(File.ReadAllText(archivo))
        Catch ex As Exception
            MsgBox(ex.ToString())
            Environment.Exit(6)
        End Try

    End Sub

    Function GET_Configuracion_ODBC() As String
        Return "Driver=" & Conf_App.ConexionODBC.Driver &
               ";Database=" & Conf_App.ConexionODBC.Database &
               ";Host=" & Conf_App.ConexionODBC.Host &
               ";Server=" & Conf_App.ConexionODBC.ServerInstance &
               ";Service=" & Conf_App.ConexionODBC.Servicio &
               ";Protocol=" & Conf_App.ConexionODBC.Protocolo &
               ";UID=" & NOMBRE_USUARIO(Conf_App.ConexionODBC.ENV_USERNAME) &
               ";PWD=" & CONTRASENIA(Conf_App.ConexionODBC.ENV_PASSWORD) &
               ";Client_Locale=" & Conf_App.ConexionODBC.LOCALE_Cliente &
               ";DB_LOCALE=" & Conf_App.ConexionODBC.LOCALE_DB & ";"
    End Function


End Module
