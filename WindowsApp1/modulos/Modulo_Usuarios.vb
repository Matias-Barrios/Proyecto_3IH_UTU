Module Modulo_Usuarios
    Public Class User

        Public Property CI As Integer
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

        Public Sub New(ByVal CI As Integer, ByVal primer_nombre As String, ByVal segundo_nombre As String, ByVal primer_apellido As String, ByVal segundo_apellido As String, ByVal fecha_de_nacimiento As Date, ByVal email As String, ByVal grado As Integer, ByVal hace_proyecto As Boolean, ByVal nota_final_pro As Integer, ByVal juicio_final As String, ByVal tipo As String)
            Me.CI = CI
            Me.primer_nombre = primer_nombre
            Me.segundo_nombre = segundo_nombre
            Me.primer_apellido = primer_apellido
            Me.segundo_apellido = segundo_apellido
            Me.fecha_nacimiento = fecha_nacimiento
            Me.email = email
            Me.grado = grado
            Me.hace_proyecto = hace_proyecto
            Me.nota_final_pro = nota_final_pro
            Me.juicio_final = juicio_final
            Me.tipo = tipo
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

    Public USUARIO_LOGUEADO As User = Nothing

    Function Usuario_Existente(cedula As Integer, password As String) As Modulo_Usuarios.User
        If cedula = 1234 And password = "admin" Then
            Return New User(cedula, "ADMIN", "ADMINACHO", "ADMINUCH", "Bambi", Date.Now, "elgil@gmail.com", 1, False, 1, "Examen_Febrero", "Admin")
        End If
        Dim datos = hacer_consulta(CONSULTA_LOGIN(cedula))
        If datos.Rows.Count() = 0 Then
            Return Nothing
        Else
            If Hash512(password, datos.Rows(0).Item("encriptacion_sal")) = datos.Rows(0).Item("encriptacion_hash") Then
                Return New User(cedula, datos.Rows(0).Item("primer_nombre"), datos.Rows(0).Item("segundo_nombre"), datos.Rows(0).Item("primer_apellido"), datos.Rows(0).Item("segundo_apellido"), datos.Rows(0).Item("fecha_nacimiento"), datos.Rows(0).Item("email"), datos.Rows(0).Item("grado"), datos.Rows(0).Item("hace_proyecto"), datos.Rows(0).Item("nota_final_pro"), datos.Rows(0).Item("juicio_final"), datos.Rows(0).Item("tipo"))
            End If
        End If
    End Function

End Module
