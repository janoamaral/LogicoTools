Public Class frmModulos
    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim soccam As New ClaseSoccam With {
            .code = txtCode.Text
        }
        soccam.GenerarClase()
        txtOutput.Text = soccam.output
    End Sub
End Class