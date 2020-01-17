Imports System.Windows.Forms

Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        frmWeb.MdiParent = Me
        frmWeb.Show()
    End Sub

    Private Sub mnuDarkMode_Click(sender As Object, e As EventArgs) Handles mnuDarkMode.Click
        Dim bgColor As Color
        Dim fgColor As Color
        If mnuDarkMode.Checked Then
            bgColor = Color.FromArgb(26, 27, 30)
            fgColor = Color.White
        Else
            bgColor = Color.FromArgb(247, 247, 247)
            fgColor = Color.FromArgb(70, 70, 70)
        End If

        frmWeb.rtfCode.BackColor = bgColor
        frmWeb.rtfCSS.BackColor = bgColor
        frmWeb.rtfTemplate.BackColor = bgColor
        frmWeb.spltCode.Panel1.BackColor = bgColor
        frmWeb.spltCode.Panel2.BackColor = bgColor

        frmWeb.rtfCode.ForeColor = fgColor
        frmWeb.rtfCSS.ForeColor = fgColor
        frmWeb.rtfTemplate.ForeColor = fgColor
        frmWeb.spltCode.Panel1.ForeColor = fgColor
        frmWeb.spltCode.Panel2.ForeColor = fgColor
    End Sub
End Class
