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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"pk", "pk, auto:1/1, !NULL"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("pkfield")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"string", "string, max | string, lenght:11"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("byte")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("int")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("long")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("money")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("percent")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("date")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("timestamp")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("bool")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("img")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModulos))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.splMain = New System.Windows.Forms.SplitContainer()
        Me.spltCode = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCode = New System.Windows.Forms.RichTextBox()
        Me.mnuCode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.toolbarMain = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnAbrirArchivo = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnOutput = New System.Windows.Forms.ToolStripButton()
        Me.btnFullscreen = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefrescarBrowser = New System.Windows.Forms.ToolStripButton()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        CType(Me.spltCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltCode.Panel1.SuspendLayout()
        Me.spltCode.Panel2.SuspendLayout()
        Me.spltCode.SuspendLayout()
        Me.mnuCode.SuspendLayout()
        Me.toolbarMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.splMain)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(768, 425)
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
        Me.splMain.Panel1.Controls.Add(Me.spltCode)
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.splMain.Panel2.Controls.Add(Me.txtOutput)
        Me.splMain.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.splMain.Size = New System.Drawing.Size(768, 425)
        Me.splMain.SplitterDistance = 378
        Me.splMain.TabIndex = 0
        '
        'spltCode
        '
        Me.spltCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spltCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltCode.Location = New System.Drawing.Point(0, 0)
        Me.spltCode.Name = "spltCode"
        '
        'spltCode.Panel1
        '
        Me.spltCode.Panel1.Controls.Add(Me.ListView1)
        Me.spltCode.Panel1Collapsed = True
        '
        'spltCode.Panel2
        '
        Me.spltCode.Panel2.Controls.Add(Me.txtCode)
        Me.spltCode.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.spltCode.Size = New System.Drawing.Size(378, 425)
        Me.spltCode.SplitterDistance = 127
        Me.spltCode.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(125, 98)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Propiedad"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ejemplo"
        Me.ColumnHeader2.Width = 150
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode.ContextMenuStrip = Me.mnuCode
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Hack", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(5, 5)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtCode.Size = New System.Drawing.Size(366, 413)
        Me.txtCode.TabIndex = 4
        Me.txtCode.Text = ""
        '
        'mnuCode
        '
        Me.mnuCode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem})
        Me.mnuCode.Name = "mnuCode"
        Me.mnuCode.Size = New System.Drawing.Size(152, 70)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
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
        Me.txtOutput.Size = New System.Drawing.Size(374, 413)
        Me.txtOutput.TabIndex = 3
        Me.txtOutput.Text = ""
        '
        'toolbarMain
        '
        Me.toolbarMain.Dock = System.Windows.Forms.DockStyle.None
        Me.toolbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.btnAbrirArchivo, Me.GuardarToolStripButton, Me.toolStripSeparator, Me.btnOutput, Me.btnFullscreen, Me.toolStripSeparator1, Me.btnRefrescarBrowser})
        Me.toolbarMain.Location = New System.Drawing.Point(0, 3)
        Me.toolbarMain.Name = "toolbarMain"
        Me.toolbarMain.Size = New System.Drawing.Size(32, 180)
        Me.toolbarMain.TabIndex = 1
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
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(30, 6)
        '
        'btnOutput
        '
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
        Me.btnRefrescarBrowser.CheckOnClick = True
        Me.btnRefrescarBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefrescarBrowser.Image = CType(resources.GetObject("btnRefrescarBrowser.Image"), System.Drawing.Image)
        Me.btnRefrescarBrowser.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btnRefrescarBrowser.Name = "btnRefrescarBrowser"
        Me.btnRefrescarBrowser.Size = New System.Drawing.Size(30, 20)
        Me.btnRefrescarBrowser.Text = "Refrescar el navegador"
        '
        'saveFile
        '
        Me.saveFile.Filter = "All files|*.*"
        Me.saveFile.Title = "Save file"
        '
        'openFile
        '
        Me.openFile.Filter = "All Files|*.*"
        Me.openFile.Title = "Open file"
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
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel2.ResumeLayout(False)
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.spltCode.Panel1.ResumeLayout(False)
        Me.spltCode.Panel2.ResumeLayout(False)
        CType(Me.spltCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltCode.ResumeLayout(False)
        Me.mnuCode.ResumeLayout(False)
        Me.toolbarMain.ResumeLayout(False)
        Me.toolbarMain.PerformLayout()
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
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents spltCode As SplitContainer
    Friend WithEvents txtCode As RichTextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents mnuCode As ContextMenuStrip
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveFile As SaveFileDialog
    Friend WithEvents openFile As OpenFileDialog
End Class
