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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeb))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.toolbarMain = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.spltMain = New System.Windows.Forms.SplitContainer()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.spltCode = New System.Windows.Forms.SplitContainer()
        Me.btnStyleEditor = New System.Windows.Forms.ToolStripButton()
        Me.btnCodeeditor = New System.Windows.Forms.ToolStripButton()
        Me.rtfCSS = New System.Windows.Forms.RichTextBox()
        Me.btnFullscreen = New System.Windows.Forms.ToolStripButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.toolbarMain.SuspendLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltMain.Panel1.SuspendLayout()
        Me.spltMain.Panel2.SuspendLayout()
        Me.spltMain.SuspendLayout()
        CType(Me.spltCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltCode.Panel1.SuspendLayout()
        Me.spltCode.Panel2.SuspendLayout()
        Me.spltCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.spltMain)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(800, 469)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 494)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.toolbarContainer
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolbarMain)
        '
        'toolbarMain
        '
        Me.toolbarMain.Dock = System.Windows.Forms.DockStyle.None
        Me.toolbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.btnCodeeditor, Me.btnStyleEditor, Me.btnFullscreen, Me.toolStripSeparator1, Me.PegarToolStripButton})
        Me.toolbarMain.Location = New System.Drawing.Point(3, 0)
        Me.toolbarMain.Name = "toolbarMain"
        Me.toolbarMain.Size = New System.Drawing.Size(239, 25)
        Me.toolbarMain.TabIndex = 0
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir"
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
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'PegarToolStripButton
        '
        Me.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), System.Drawing.Image)
        Me.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripButton.Name = "PegarToolStripButton"
        Me.PegarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PegarToolStripButton.Text = "&Pegar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.spltMain.Panel2.Controls.Add(Me.wb)
        Me.spltMain.Size = New System.Drawing.Size(800, 469)
        Me.spltMain.SplitterDistance = 395
        Me.spltMain.TabIndex = 0
        '
        'wb
        '
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.Location = New System.Drawing.Point(0, 0)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(399, 467)
        Me.wb.TabIndex = 0
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
        Me.spltCode.Panel1.Controls.Add(Me.rtfCSS)
        '
        'spltCode.Panel2
        '
        Me.spltCode.Panel2.Controls.Add(Me.RichTextBox1)
        Me.spltCode.Size = New System.Drawing.Size(395, 469)
        Me.spltCode.SplitterDistance = 225
        Me.spltCode.TabIndex = 0
        '
        'btnStyleEditor
        '
        Me.btnStyleEditor.Checked = True
        Me.btnStyleEditor.CheckOnClick = True
        Me.btnStyleEditor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnStyleEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnStyleEditor.Image = CType(resources.GetObject("btnStyleEditor.Image"), System.Drawing.Image)
        Me.btnStyleEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStyleEditor.Name = "btnStyleEditor"
        Me.btnStyleEditor.Size = New System.Drawing.Size(23, 22)
        Me.btnStyleEditor.Text = "ToolStripButton1"
        '
        'btnCodeeditor
        '
        Me.btnCodeeditor.Checked = True
        Me.btnCodeeditor.CheckOnClick = True
        Me.btnCodeeditor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnCodeeditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCodeeditor.Image = CType(resources.GetObject("btnCodeeditor.Image"), System.Drawing.Image)
        Me.btnCodeeditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCodeeditor.Name = "btnCodeeditor"
        Me.btnCodeeditor.Size = New System.Drawing.Size(23, 22)
        Me.btnCodeeditor.Text = "ToolStripButton2"
        '
        'rtfCSS
        '
        Me.rtfCSS.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rtfCSS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfCSS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfCSS.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfCSS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.rtfCSS.Location = New System.Drawing.Point(0, 0)
        Me.rtfCSS.Name = "rtfCSS"
        Me.rtfCSS.Size = New System.Drawing.Size(393, 223)
        Me.rtfCSS.TabIndex = 0
        Me.rtfCSS.Text = ""
        Me.rtfCSS.WordWrap = False
        '
        'btnFullscreen
        '
        Me.btnFullscreen.CheckOnClick = True
        Me.btnFullscreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFullscreen.Image = CType(resources.GetObject("btnFullscreen.Image"), System.Drawing.Image)
        Me.btnFullscreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(23, 22)
        Me.btnFullscreen.Text = "ToolStripButton1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(393, 238)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'frmWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWeb"
        Me.Text = "WEB TEMPLATES"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.toolbarMain.ResumeLayout(False)
        Me.toolbarMain.PerformLayout()
        Me.spltMain.Panel1.ResumeLayout(False)
        Me.spltMain.Panel2.ResumeLayout(False)
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltMain.ResumeLayout(False)
        Me.spltCode.Panel1.ResumeLayout(False)
        Me.spltCode.Panel2.ResumeLayout(False)
        CType(Me.spltCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltCode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents toolbarMain As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents AbrirToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents PegarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents spltMain As SplitContainer
    Friend WithEvents spltCode As SplitContainer
    Friend WithEvents rtfCSS As RichTextBox
    Friend WithEvents wb As WebBrowser
    Friend WithEvents btnCodeeditor As ToolStripButton
    Friend WithEvents btnStyleEditor As ToolStripButton
    Friend WithEvents btnFullscreen As ToolStripButton
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
