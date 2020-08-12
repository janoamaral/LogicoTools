<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWeb
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeb))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.spltMain = New System.Windows.Forms.SplitContainer()
        Me.spltCode = New System.Windows.Forms.SplitContainer()
        Me.rtfCode = New System.Windows.Forms.RichTextBox()
        Me.mnuEditar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtfCSS = New System.Windows.Forms.RichTextBox()
        Me.splOutput = New System.Windows.Forms.SplitContainer()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.rtfTemplate = New System.Windows.Forms.RichTextBox()
        Me.toolbarMain = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnAbrirArchivo = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCode = New System.Windows.Forms.ToolStripButton()
        Me.btnStyle = New System.Windows.Forms.ToolStripButton()
        Me.btnOutput = New System.Windows.Forms.ToolStripButton()
        Me.btnFullscreen = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefrescarBrowser = New System.Windows.Forms.ToolStripButton()
        Me.oDiag = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltMain.Panel1.SuspendLayout()
        Me.spltMain.Panel2.SuspendLayout()
        Me.spltMain.SuspendLayout()
        CType(Me.spltCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltCode.Panel1.SuspendLayout()
        Me.spltCode.Panel2.SuspendLayout()
        Me.spltCode.SuspendLayout()
        Me.mnuEditar.SuspendLayout()
        CType(Me.splOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splOutput.Panel1.SuspendLayout()
        Me.splOutput.Panel2.SuspendLayout()
        Me.splOutput.SuspendLayout()
        Me.toolbarMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.spltMain)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(768, 494)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.Controls.Add(Me.toolbarMain)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 494)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'spltMain
        '
        Me.spltMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spltMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltMain.Location = New System.Drawing.Point(0, 0)
        Me.spltMain.Name = "spltMain"
        '
        'spltMain.Panel1
        '
        Me.spltMain.Panel1.Controls.Add(Me.spltCode)
        '
        'spltMain.Panel2
        '
        Me.spltMain.Panel2.Controls.Add(Me.splOutput)
        Me.spltMain.Size = New System.Drawing.Size(768, 494)
        Me.spltMain.SplitterDistance = 379
        Me.spltMain.TabIndex = 0
        '
        'spltCode
        '
        Me.spltCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spltCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltCode.Location = New System.Drawing.Point(0, 0)
        Me.spltCode.Name = "spltCode"
        Me.spltCode.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltCode.Panel1
        '
        Me.spltCode.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.spltCode.Panel1.Controls.Add(Me.rtfCode)
        Me.spltCode.Panel1.Padding = New System.Windows.Forms.Padding(8)
        '
        'spltCode.Panel2
        '
        Me.spltCode.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.spltCode.Panel2.Controls.Add(Me.rtfCSS)
        Me.spltCode.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.spltCode.Size = New System.Drawing.Size(379, 494)
        Me.spltCode.SplitterDistance = 236
        Me.spltCode.TabIndex = 0
        '
        'rtfCode
        '
        Me.rtfCode.AcceptsTab = True
        Me.rtfCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rtfCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfCode.ContextMenuStrip = Me.mnuEditar
        Me.rtfCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfCode.Font = New System.Drawing.Font("JetBrains Mono", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.rtfCode.Location = New System.Drawing.Point(8, 8)
        Me.rtfCode.Name = "rtfCode"
        Me.rtfCode.Size = New System.Drawing.Size(361, 218)
        Me.rtfCode.TabIndex = 2
        Me.rtfCode.Tag = resources.GetString("rtfCode.Tag")
        Me.rtfCode.Text = ""
        Me.rtfCode.WordWrap = False
        '
        'mnuEditar
        '
        Me.mnuEditar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CopiarToolStripMenuItem1, Me.PegarToolStripMenuItem})
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.Size = New System.Drawing.Size(152, 70)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CopiarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem1
        '
        Me.CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        Me.CopiarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.CopiarToolStripMenuItem1.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'rtfCSS
        '
        Me.rtfCSS.AcceptsTab = True
        Me.rtfCSS.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rtfCSS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfCSS.ContextMenuStrip = Me.mnuEditar
        Me.rtfCSS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfCSS.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfCSS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.rtfCSS.Location = New System.Drawing.Point(8, 8)
        Me.rtfCSS.Margin = New System.Windows.Forms.Padding(0)
        Me.rtfCSS.Name = "rtfCSS"
        Me.rtfCSS.Size = New System.Drawing.Size(361, 236)
        Me.rtfCSS.TabIndex = 0
        Me.rtfCSS.Text = ""
        Me.rtfCSS.WordWrap = False
        '
        'splOutput
        '
        Me.splOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splOutput.Location = New System.Drawing.Point(0, 0)
        Me.splOutput.Name = "splOutput"
        '
        'splOutput.Panel1
        '
        Me.splOutput.Panel1.Controls.Add(Me.wb)
        '
        'splOutput.Panel2
        '
        Me.splOutput.Panel2.Controls.Add(Me.rtfTemplate)
        Me.splOutput.Panel2Collapsed = True
        Me.splOutput.Size = New System.Drawing.Size(383, 492)
        Me.splOutput.SplitterDistance = 196
        Me.splOutput.TabIndex = 1
        '
        'wb
        '
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.Location = New System.Drawing.Point(0, 0)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.ScriptErrorsSuppressed = True
        Me.wb.Size = New System.Drawing.Size(383, 492)
        Me.wb.TabIndex = 0
        Me.wb.WebBrowserShortcutsEnabled = False
        '
        'rtfTemplate
        '
        Me.rtfTemplate.AcceptsTab = True
        Me.rtfTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rtfTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfTemplate.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfTemplate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.rtfTemplate.Location = New System.Drawing.Point(0, 0)
        Me.rtfTemplate.Name = "rtfTemplate"
        Me.rtfTemplate.Size = New System.Drawing.Size(96, 100)
        Me.rtfTemplate.TabIndex = 3
        Me.rtfTemplate.Text = ""
        Me.rtfTemplate.WordWrap = False
        '
        'toolbarMain
        '
        Me.toolbarMain.Dock = System.Windows.Forms.DockStyle.None
        Me.toolbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.btnAbrirArchivo, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.btnCode, Me.btnStyle, Me.btnOutput, Me.btnFullscreen, Me.toolStripSeparator1, Me.btnRefrescarBrowser})
        Me.toolbarMain.Location = New System.Drawing.Point(0, 3)
        Me.toolbarMain.Name = "toolbarMain"
        Me.toolbarMain.Size = New System.Drawing.Size(32, 249)
        Me.toolbarMain.TabIndex = 0
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(30, 20)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'btnAbrirArchivo
        '
        Me.btnAbrirArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbrirArchivo.Image = CType(resources.GetObject("btnAbrirArchivo.Image"), System.Drawing.Image)
        Me.btnAbrirArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrirArchivo.Name = "btnAbrirArchivo"
        Me.btnAbrirArchivo.Size = New System.Drawing.Size(30, 20)
        Me.btnAbrirArchivo.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(30, 20)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(30, 20)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(30, 6)
        '
        'btnCode
        '
        Me.btnCode.Checked = True
        Me.btnCode.CheckOnClick = True
        Me.btnCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCode.Image = CType(resources.GetObject("btnCode.Image"), System.Drawing.Image)
        Me.btnCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(30, 20)
        Me.btnCode.Text = "Muestra u oculta el panel CSS"
        '
        'btnStyle
        '
        Me.btnStyle.Checked = True
        Me.btnStyle.CheckOnClick = True
        Me.btnStyle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnStyle.Image = CType(resources.GetObject("btnStyle.Image"), System.Drawing.Image)
        Me.btnStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStyle.Name = "btnStyle"
        Me.btnStyle.Size = New System.Drawing.Size(30, 20)
        Me.btnStyle.Text = "Mostrar u ocultar panel HTML"
        '
        'btnOutput
        '
        Me.btnOutput.CheckOnClick = True
        Me.btnOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOutput.Image = CType(resources.GetObject("btnOutput.Image"), System.Drawing.Image)
        Me.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(30, 20)
        Me.btnOutput.Text = "ToolStripButton1"
        '
        'btnFullscreen
        '
        Me.btnFullscreen.CheckOnClick = True
        Me.btnFullscreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFullscreen.Image = CType(resources.GetObject("btnFullscreen.Image"), System.Drawing.Image)
        Me.btnFullscreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(30, 20)
        Me.btnFullscreen.Text = "Navegador en modo fullscreen"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(30, 6)
        '
        'btnRefrescarBrowser
        '
        Me.btnRefrescarBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefrescarBrowser.Image = CType(resources.GetObject("btnRefrescarBrowser.Image"), System.Drawing.Image)
        Me.btnRefrescarBrowser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefrescarBrowser.Name = "btnRefrescarBrowser"
        Me.btnRefrescarBrowser.Size = New System.Drawing.Size(30, 20)
        Me.btnRefrescarBrowser.Text = "Refrescar el navegador"
        '
        'oDiag
        '
        Me.oDiag.Filter = "All Files|*.*"
        '
        'frmWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWeb"
        Me.Text = "WEB TEMPLATE"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.spltMain.Panel1.ResumeLayout(False)
        Me.spltMain.Panel2.ResumeLayout(False)
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltMain.ResumeLayout(False)
        Me.spltCode.Panel1.ResumeLayout(False)
        Me.spltCode.Panel2.ResumeLayout(False)
        CType(Me.spltCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltCode.ResumeLayout(False)
        Me.mnuEditar.ResumeLayout(False)
        Me.splOutput.Panel1.ResumeLayout(False)
        Me.splOutput.Panel2.ResumeLayout(False)
        CType(Me.splOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splOutput.ResumeLayout(False)
        Me.toolbarMain.ResumeLayout(False)
        Me.toolbarMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents toolbarMain As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents btnAbrirArchivo As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents btnRefrescarBrowser As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents spltMain As SplitContainer
    Friend WithEvents spltCode As SplitContainer
    Friend WithEvents rtfCSS As RichTextBox
    Friend WithEvents wb As WebBrowser
    Friend WithEvents btnStyle As ToolStripButton
    Friend WithEvents btnCode As ToolStripButton
    Friend WithEvents btnFullscreen As ToolStripButton
    Friend WithEvents rtfCode As RichTextBox
    Friend WithEvents splOutput As SplitContainer
    Friend WithEvents rtfTemplate As RichTextBox
    Friend WithEvents btnOutput As ToolStripButton
    Friend WithEvents oDiag As OpenFileDialog
    Friend WithEvents mnuEditar As ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
End Class
