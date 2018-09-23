Module Mensajes_Al_Usuario
    Public Function SELECCIONE_AL_MENOS_UNO() As String
        Return "Seleccione al menos un item"
    End Function
    Public Function MENSAJE_EXITO() As String
        Return "La operacion fue realizada con exito"
    End Function
    Public Function SEGURO_ELIMINAR() As String
        Return "Seguro que quiere dar de baja los elementos seleccionados?"
    End Function
    Public Function SEGURO_ASIGNAR() As String
        Return "Seguro que quiere asignar a las personas sleccionados a el grupo ?"
    End Function
    Public Function SELECCIONE_SOLO_UNO() As String
        Return "Debe seleccionar UN solo item"
    End Function
    Public Function PRODUCIDO_EXCEPCION_CONSULTA() As String
        Return "Se ha producido un error realizando la operacion"
    End Function
End Module
