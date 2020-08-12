Public Class frmModulos
    Public Property currentFile As String = ""
    Public Property fileIsLoaded As Boolean = False

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim soccam As New ClaseSoccam With {
            .code = txtCode.Text
        }
        soccam.GenerarClase()
        txtOutput.Text = soccam.output
    End Sub

    Private Sub btnRefrescarBrowser_Click(sender As Object, e As EventArgs) Handles btnRefrescarBrowser.Click
        If btnRefrescarBrowser.Checked Then
            spltCode.Panel1Collapsed = False
        Else
            spltCode.Panel1Collapsed = True
        End If
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        Dim res As String = InputBox("Nombre de la tabla", "Template Tabla SocCam")
        If res.Trim.Length > 0 Then
            fileIsLoaded = False
            currentFile = ""
            txtCode.Text = TemplateTablaSocCam(res)
            frmPrincipal.txtStatusLabel.Text = $"UNSAVED ⚠"
        End If
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        txtCode.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        txtCode.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        txtCode.Paste()
    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        If Not fileIsLoaded Then
            If saveFile.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtCode.Text, False)
                fileIsLoaded = True
                currentFile = saveFile.FileName
                frmPrincipal.txtStatusLabel.Text = $"SAVED ▶ {saveFile.FileName}"
            End If
        Else
            My.Computer.FileSystem.WriteAllText(currentFile, txtCode.Text, False)
            frmPrincipal.txtStatusLabel.Text = $"SAVED ▶ {saveFile.FileName}"
        End If
    End Sub

    Private Sub btnAbrirArchivo_Click(sender As Object, e As EventArgs) Handles btnAbrirArchivo.Click
        If openFile.ShowDialog = DialogResult.OK Then
            txtCode.Text = My.Computer.FileSystem.ReadAllText(openFile.FileName)
            fileIsLoaded = True
            currentFile = saveFile.FileName
            frmPrincipal.txtStatusLabel.Text = $"LOADED ▶ {saveFile.FileName}"
        End If
    End Sub

    Private Sub frmModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmModulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmPrincipal.txtStatusLabel.Text = $""
    End Sub
End Class