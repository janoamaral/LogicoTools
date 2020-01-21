Public Class frmWeb
    Public Property archivoCargado As Boolean = False
    Public Property archivoPath As String = ""
    Public Property Renderer As New TemplateRenderer()


    Private Sub RefrescarNavegador()
        Renderer.Style = rtfCSS.Text
        Renderer.Body = rtfCode.Text
        wb.DocumentText = Renderer.Render
    End Sub

    Private Sub btnFullscreen_Click(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        If btnFullscreen.Checked Then
            spltMain.Panel1Collapsed = True
        Else
            spltMain.Panel1Collapsed = False
        End If
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        If Not Me.archivoCargado Then
            Renderer.Reset()
            rtfCode.Clear()
            rtfCSS.Clear()
            rtfTemplate.Clear()
            Dim tmpStr As String = ""
            tmpStr &= "* {" & vbCrLf
            tmpStr &= "margin: 0;" & vbCrLf
            tmpStr &= "padding: 0;" & vbCrLf
            tmpStr &= "font-family: Arial, sans-serif;" & vbCrLf
            tmpStr &= "}" & vbCrLf
            rtfCSS.Text = tmpStr
            RefrescarNavegador()
        End If
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        If btnOutput.Checked Then
            splOutput.Panel2Collapsed = False
            splOutput.Panel1Collapsed = True
        Else
            splOutput.Panel2Collapsed = True
            splOutput.Panel1Collapsed = False
        End If
    End Sub

    Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
        ' Colapsar el editor HTML
        If btnCode.Checked Then
            spltCode.Panel1Collapsed = False
        Else
            spltCode.Panel1Collapsed = True
        End If
    End Sub

    Private Sub btnStyle_Click(sender As Object, e As EventArgs) Handles btnStyle.Click
        ' Colapsar el editor CSS
        If btnStyle.Checked Then
            spltCode.Panel2Collapsed = False
        Else
            spltCode.Panel2Collapsed = True
        End If
    End Sub

    Private Sub rtfCSS_KeyUp(sender As Object, e As KeyEventArgs) Handles rtfCSS.KeyUp
        Debug.Print(e.KeyValue)
        Select Case e.KeyValue
            ' Refrescar en Enter, } o ;
            Case 13, 191, 188
                ' Si es coma salir inmediatamente
                If e.KeyValue = 188 And Not e.Modifiers = Keys.Shift Then Exit Sub

                ' TODO: Si la última tecla fue ";" y se presiono ENTER, no volver a refrescar
                RefrescarNavegador()
            Case 222
                ' Cerrar la llave y posicionarse en el medio
                rtfCSS.SuspendLayout()
                rtfCSS.SelectedText = vbCrLf + vbCrLf + "}"
                rtfCSS.SelectionStart = rtfCSS.SelectionStart - 2
                rtfCSS.SelectionLength = 0
                rtfCSS.ResumeLayout()
            Case 122
                btnFullscreen.Checked = Not btnFullscreen.Checked
                If btnFullscreen.Checked Then
                    spltMain.Panel1Collapsed = True
                Else
                    spltMain.Panel1Collapsed = False
                End If
        End Select
    End Sub

    Private Sub rtfCode_KeyUp(sender As Object, e As KeyEventArgs) Handles rtfCode.KeyUp
        If e.KeyCode = Keys.F5 Then
            RefrescarNavegador()
        End If

        Select Case e.KeyValue
            Case 13
                RefrescarNavegador()
            Case 122
                btnFullscreen.Checked = Not btnFullscreen.Checked
                If btnFullscreen.Checked Then
                    spltMain.Panel1Collapsed = True
                Else
                    spltMain.Panel1Collapsed = False
                End If

        End Select
    End Sub

    Private Sub AbrirToolStripButton_Click(sender As Object, e As EventArgs) Handles btnAbrirArchivo.Click

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        If rtfCode.Focused Then
            rtfCode.Cut()
            Exit Sub
        End If
        If rtfCSS.Focused Then
            rtfCSS.Cut()
            Exit Sub
        End If
        If rtfTemplate.Focused Then
            rtfTemplate.Cut()
            Exit Sub
        End If
    End Sub

    Private Sub CopiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem1.Click
        If rtfCode.Focused Then
            rtfCode.Copy()
            Exit Sub
        End If
        If rtfCSS.Focused Then
            rtfCSS.Copy()
            Exit Sub
        End If
        If rtfTemplate.Focused Then
            rtfTemplate.Copy()
            Exit Sub
        End If
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        If rtfCode.Focused Then
            rtfCode.Paste()
            Exit Sub
        End If
        If rtfCSS.Focused Then
            rtfCSS.Paste()
            Exit Sub
        End If
        If rtfTemplate.Focused Then
            rtfTemplate.Paste()
            Exit Sub
        End If
    End Sub

    Private Sub btnRefrescarBrowser_Click(sender As Object, e As EventArgs) Handles btnRefrescarBrowser.Click
        RefrescarNavegador()
    End Sub
End Class
