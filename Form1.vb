Public Class frmWeb
    Private Sub btnCodeeditor_Click(sender As Object, e As EventArgs) Handles btnCodeeditor.Click
        ' Colapsar el editor HTML
        If btnCodeeditor.Checked Then
            spltCode.Panel2Collapsed = False
        Else
            spltCode.Panel2Collapsed = True
        End If
    End Sub

    Private Sub btnStyleEditor_Click(sender As Object, e As EventArgs) Handles btnStyleEditor.Click
        ' Colapsar el editor CSS
        If btnStyleEditor.Checked Then
            spltCode.Panel1Collapsed = False
        Else
            spltCode.Panel1Collapsed = True
        End If
    End Sub

    Private Sub btnFullscreen_Click(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        If btnFullscreen.Checked Then
            spltMain.Panel1Collapsed = True
        Else
            spltMain.Panel1Collapsed = False
        End If
    End Sub
End Class
