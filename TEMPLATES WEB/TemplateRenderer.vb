Public Class TemplateRenderer

    Public Property Style As String = ""
    Public Property Body As String = ""

    Public Sub Reset()
        Me.Style = ""
        Me.Body = ""
    End Sub

    Public Function Head() As String
        Dim tmpStr As String = ""
        tmpStr &= "<!DOCTYPE html>" & vbCrLf
        tmpStr &= "<html lang=""es"">" & vbCrLf
        tmpStr &= "<head>" & vbCrLf
        tmpStr &= "<meta charset=""utf-8"">" & vbCrLf
        tmpStr &= "<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">" & vbCrLf
        tmpStr &= "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">" & vbCrLf
        tmpStr &= "<style>" & vbCrLf
        tmpStr &= Me.Style
        tmpStr &= "</style>" & vbCrLf
        tmpStr &= "</head>" & vbCrLf
        Return tmpStr
    End Function

    Public Function Render() As String
        Dim tmpStr As String = ""
        tmpStr &= Me.Head
        tmpStr &= "<body>" & vbCrLf
        tmpStr &= Me.Body
        tmpStr &= "</body>" & vbCrLf
        tmpStr &= "</html>" & vbCrLf
        Return tmpStr
    End Function


End Class
