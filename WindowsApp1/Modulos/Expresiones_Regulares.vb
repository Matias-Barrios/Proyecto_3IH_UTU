
Module Expresiones_Regulares
    Public Function PASSWORD_VALIDO() As String
        Return "^(?=.*[0-9])(?=.*[a-zA-Z])(?=^[A-Z])(?=.*[A-Z])(?=.*[#@!]).*$"
    End Function
End Module
