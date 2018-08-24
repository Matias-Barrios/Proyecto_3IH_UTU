Module Modulo_Usuarios
    Public Class User

        Public Property CI As String
        Public Property primer_nombre As String
        Public Property segundo_nombre As String
        Public Property primer_apellido As String
        Public Property segundo_apellido As String
        Public Property fecha_nacimiento As Date
        Public Property email As String
        Public Property grado As String
        Public Property hace_proyecto As Boolean
        Public Property nota_final_pro As Boolean
        Public Property juicio_final As String
        Public Property tipo As String




        Public Property Password As String
        Public Property Rol As String

        Public Sub New(ByVal name As String, ByVal password As String, ByVal rol As String)
            Me.Name = name
            Me.Password = password
            Me.Rol = rol
        End Sub



    End Class

    Public Function Validar(usersList As List(Of User), nombre As String, password As String) As Boolean

        For Each user As Object In usersList
            If nombre = user.Name() And password = user.Password() Then
                Return True
            End If
        Next

        Return False
    End Function


End Module
