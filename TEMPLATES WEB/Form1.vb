﻿Public Class frmWeb
    Public Property archivoCargado As Boolean = False
    Public Property archivoPath As String = ""


    Private Sub btnFullscreen_Click(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        If btnFullscreen.Checked Then
            spltMain.Panel1Collapsed = True
        Else
            spltMain.Panel1Collapsed = False
        End If
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        If Not Me.archivoCargado Then

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
            spltCode.Panel2Collapsed = False
        Else
            spltCode.Panel2Collapsed = True
        End If
    End Sub

    Private Sub btnStyle_Click(sender As Object, e As EventArgs) Handles btnStyle.Click
        ' Colapsar el editor CSS
        If btnStyle.Checked Then
            spltCode.Panel1Collapsed = False
        Else
            spltCode.Panel1Collapsed = True
        End If
    End Sub
End Class