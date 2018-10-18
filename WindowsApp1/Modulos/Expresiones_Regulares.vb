
Module Expresiones_Regulares
    Public Function PASSWORD_VALIDO() As String
        Return "^(?=.*[0-9])(?=.*[a-zA-Z_])(?=^[A-Z])(?=.*[A-Z])(?=.*[#@!]).*$"
    End Function
    Public Function ESCONDER_COLUMNAS_INPUT_VALIDO() As String
        Return "^[a-zA-Z_,]+$"
    End Function

    Public Function NOMBRE_VALIDO() As String
        Return "^[a-zA-Z][a-zA-Z ]+$"
    End Function

    Public Function EMAIL_VALIDO() As String
        Return "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z_])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$"
    End Function

    Public Function CEDULA_VALIDA() As String
        Return "^[0-9]{8,12}$"
    End Function
    Public Function GRUPO_NOMBRE_VALIDO() As String
        Return "^[1-3][A-Z][A-Z]$"
    End Function
    Public Function CIUDAD_NOMBRE_VALIDO() As String
        Return "^[A-Za-z ]{1,50}$"
    End Function
    Public Function ORIEANTACION_NOMBRE_VALIDO() As String
        Return "^[A-Za-z ]{1,50}$"
    End Function


End Module
