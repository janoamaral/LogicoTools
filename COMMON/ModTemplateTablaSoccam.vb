Module ModTemplateTablaSoccam
    Public Function TemplateTablaSocCam(ByVal nombreTabla As String) As String
        Dim output As String = $"TABLE {nombreTabla}"
        output &= vbCrLf & "id = pk, auto:1/1, !NULL"
        output &= vbCrLf & "deleted = bool"
        output &= vbCrLf & "modificado = timestamp"
        output &= vbCrLf & "END TABLE"
        Return output
    End Function

End Module
