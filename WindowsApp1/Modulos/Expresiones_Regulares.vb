
Module Expresiones_Regulares
    Public Function PASSWORD_VALIDO() As String
        Return "^(?=.*[0-9])(?=.*[a-zA-Z])(?=^[A-Z])(?=.*[A-Z])(?=.*[#@!]).*$"
    End Function
    Public Function ESCONDER_COLUMNAS_INPUT_VALIDO() As String
        Return "^[a-zA-Z_,]+$"
    End Function


End Module
