<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModulos))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.toolbarMain = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnAbrirArchivo = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnOutput = New System.Windows.Forms.ToolStripButton()
        Me.btnFullscreen = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefrescarBrowser = New System.Windows.Forms.ToolStripButton()
        Me.splMain = New System.Windows.Forms.SplitContainer()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.txtCode = New System.Windows.Forms.RichTextBox()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.toolbarMain.SuspendLayout()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.splMain)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(776, 450)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.Controls.Add(Me.toolbarMain)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'toolbarMain
        '
        Me.toolbarMain.Dock = System.Windows.Forms.DockStyle.None
        Me.toolbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.btnAbrirArchivo, Me.GuardarToolStripButton, Me.toolStripSeparator, Me.btnOutput, Me.btnFullscreen, Me.toolStripSeparator1, Me.btnRefrescarBrowser})
        Me.toolbarMain.Location = New System.Drawing.Point(0, 3)
        Me.toolbarMain.Name = "toolbarMain"
        Me.toolbarMain.Size = New System.Drawing.Size(24, 161)
        Me.toolbarMain.TabIndex = 1
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(22, 20)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'btnAbrirArchivo
        '
        Me.btnAbrirArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbrirArchivo.Image = CType(resources.GetObject("btnAbrirArchivo.Image"), System.Drawing.Image)
        Me.btnAbrirArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrirArchivo.Name = "btnAbrirArchivo"
        Me.btnAbrirArchivo.Size = New System.Drawing.Size(23, 22)
        Me.btnAbrirArchivo.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'btnOutput
        '
        Me.btnOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOutput.Image = CType(resources.GetObject("btnOutput.Image"), System.Drawing.Image)
        Me.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(23, 22)
        Me.btnOutput.Text = "ToolStripButton1"
        '
        'btnFullscreen
        '
        Me.btnFullscreen.CheckOnClick = True
        Me.btnFullscreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFullscreen.Image = CType(resources.GetObject("btnFullscreen.Image"), System.Drawing.Image)
        Me.btnFullscreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(23, 22)
        Me.btnFullscreen.Text = "Navegador en modo fullscreen"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRefrescarBrowser
        '
        Me.btnRefrescarBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefrescarBrowser.Image = CType(resources.GetObject("btnRefrescarBrowser.Image"), System.Drawing.Image)
        Me.btnRefrescarBrowser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefrescarBrowser.Name = "btnRefrescarBrowser"
        Me.btnRefrescarBrowser.Size = New System.Drawing.Size(23, 22)
        Me.btnRefrescarBrowser.Text = "Refrescar el navegador"
        '
        'splMain
        '
        Me.splMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMain.Location = New System.Drawing.Point(0, 0)
        Me.splMain.Name = "splMain"
        '
        'splMain.Panel1
        '
        Me.splMain.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.splMain.Panel1.Controls.Add(Me.txtCode)
        Me.splMain.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.splMain.Panel2.Controls.Add(Me.txtOutput)
        Me.splMain.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.splMain.Size = New System.Drawing.Size(776, 450)
        Me.splMain.SplitterDistance = 383
        Me.splMain.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutput.Font = New System.Drawing.Font("Hack", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtOutput.Location = New System.Drawing.Point(5, 5)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(377, 438)
        Me.txtOutput.TabIndex = 3
        Me.txtOutput.Text = ""
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Hack", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(5, 5)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtCode.Size = New System.Drawing.Size(371, 438)
        Me.txtCode.TabIndex = 3
        Me.txtCode.Text = ""
        '
        'frmModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmModulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clases SocCam"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.toolbarMain.ResumeLayout(False)
        Me.toolbarMain.PerformLayout()
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel2.ResumeLayout(False)
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents toolbarMain As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents btnAbrirArchivo As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents btnOutput As ToolStripButton
    Friend WithEvents btnFullscreen As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnRefrescarBrowser As ToolStripButton
    Friend WithEvents splMain As SplitContainer
    Friend WithEvents txtCode As RichTextBox
    Friend WithEvents txtOutput As RichTextBox
End Class
