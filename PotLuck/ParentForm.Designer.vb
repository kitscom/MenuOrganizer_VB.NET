<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
    Inherits System.Windows.Forms.Form
    '  Inherits BaseForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentForm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFileNewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFileOpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFileClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFilePrintPreviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFileSaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFileSaveAsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmuFileExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileWindowsHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileWindowsVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.clearToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.printPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.saveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.exitToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timeOfTodayToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateOfTodayToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateTodayToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TodayToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1133, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mmuFileNewMenuItem, Me.mmuFileOpenMenuItem, Me.mmuFileClearMenuItem, Me.mmuFilePrintPreviewMenuItem, Me.mmuFileSaveMenuItem, Me.mmuFileSaveAsMenuItem, Me.mmuFileExitMenuItem})
        Me.FileToolStripMenuItem.MergeIndex = 0
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mmuFileNewMenuItem
        '
        Me.mmuFileNewMenuItem.Name = "mmuFileNewMenuItem"
        Me.mmuFileNewMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFileNewMenuItem.Text = "&New"
        '
        'mmuFileOpenMenuItem
        '
        Me.mmuFileOpenMenuItem.Name = "mmuFileOpenMenuItem"
        Me.mmuFileOpenMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFileOpenMenuItem.Text = "&Open"
        '
        'mmuFileClearMenuItem
        '
        Me.mmuFileClearMenuItem.Name = "mmuFileClearMenuItem"
        Me.mmuFileClearMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFileClearMenuItem.Text = "&Clear"
        '
        'mmuFilePrintPreviewMenuItem
        '
        Me.mmuFilePrintPreviewMenuItem.Name = "mmuFilePrintPreviewMenuItem"
        Me.mmuFilePrintPreviewMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFilePrintPreviewMenuItem.Text = "&Print Preview"
        '
        'mmuFileSaveMenuItem
        '
        Me.mmuFileSaveMenuItem.Name = "mmuFileSaveMenuItem"
        Me.mmuFileSaveMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFileSaveMenuItem.Text = "&Save"
        '
        'mmuFileSaveAsMenuItem
        '
        Me.mmuFileSaveAsMenuItem.Name = "mmuFileSaveAsMenuItem"
        Me.mmuFileSaveAsMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFileSaveAsMenuItem.Text = "Save &As"
        Me.mmuFileSaveAsMenuItem.ToolTipText = "Save As"
        '
        'mmuFileExitMenuItem
        '
        Me.mmuFileExitMenuItem.Name = "mmuFileExitMenuItem"
        Me.mmuFileExitMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.mmuFileExitMenuItem.Text = "E&xit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileWindowsHorizontallyToolStripMenuItem, Me.TileWindowsVerticallyToolStripMenuItem, Me.CascadeWindowsToolStripMenuItem})
        Me.WindowToolStripMenuItem.MergeIndex = 2
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'TileWindowsHorizontallyToolStripMenuItem
        '
        Me.TileWindowsHorizontallyToolStripMenuItem.Name = "TileWindowsHorizontallyToolStripMenuItem"
        Me.TileWindowsHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.TileWindowsHorizontallyToolStripMenuItem.Text = "Tile Windows &Horizontally"
        '
        'TileWindowsVerticallyToolStripMenuItem
        '
        Me.TileWindowsVerticallyToolStripMenuItem.Name = "TileWindowsVerticallyToolStripMenuItem"
        Me.TileWindowsVerticallyToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.TileWindowsVerticallyToolStripMenuItem.Text = "Tile Windows &Vertically"
        '
        'CascadeWindowsToolStripMenuItem
        '
        Me.CascadeWindowsToolStripMenuItem.Name = "CascadeWindowsToolStripMenuItem"
        Me.CascadeWindowsToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.CascadeWindowsToolStripMenuItem.Text = " &Cascade Windows"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.clearToolStripButton, Me.printPreviewToolStripButton, Me.saveToolStripButton, Me.saveAsToolStripButton, Me.exitToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1133, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.newToolStripButton.ToolTipText = "New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.openToolStripButton.Text = "Open"
        '
        'clearToolStripButton
        '
        Me.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.clearToolStripButton.Image = CType(resources.GetObject("clearToolStripButton.Image"), System.Drawing.Image)
        Me.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.clearToolStripButton.Name = "clearToolStripButton"
        Me.clearToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.clearToolStripButton.ToolTipText = "Clear"
        '
        'printPreviewToolStripButton
        '
        Me.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printPreviewToolStripButton.Image = CType(resources.GetObject("printPreviewToolStripButton.Image"), System.Drawing.Image)
        Me.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripButton.Name = "printPreviewToolStripButton"
        Me.printPreviewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printPreviewToolStripButton.Text = "Print Preview"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.ToolTipText = "Save"
        '
        'saveAsToolStripButton
        '
        Me.saveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveAsToolStripButton.Image = CType(resources.GetObject("saveAsToolStripButton.Image"), System.Drawing.Image)
        Me.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveAsToolStripButton.Name = "saveAsToolStripButton"
        Me.saveAsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveAsToolStripButton.ToolTipText = "Save As"
        '
        'exitToolStripButton
        '
        Me.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.exitToolStripButton.Image = CType(resources.GetObject("exitToolStripButton.Image"), System.Drawing.Image)
        Me.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.exitToolStripButton.Name = "exitToolStripButton"
        Me.exitToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.exitToolStripButton.ToolTipText = "Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dateToolStripStatusLabel, Me.timeToolStripStatusLabel, Me.timeOfTodayToolStripStatusLabel, Me.dateOfTodayToolStripStatusLabel, Me.dateTodayToolStripStatusLabel1, Me.TodayToolStripStatusLabel, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 649)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(16, 0, 1, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1133, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dateToolStripStatusLabel
        '
        Me.dateToolStripStatusLabel.Name = "dateToolStripStatusLabel"
        Me.dateToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        '
        'timeToolStripStatusLabel
        '
        Me.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel"
        Me.timeToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        '
        'timeOfTodayToolStripStatusLabel
        '
        Me.timeOfTodayToolStripStatusLabel.Name = "timeOfTodayToolStripStatusLabel"
        Me.timeOfTodayToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.timeOfTodayToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        '
        'dateOfTodayToolStripStatusLabel
        '
        Me.dateOfTodayToolStripStatusLabel.MergeIndex = 0
        Me.dateOfTodayToolStripStatusLabel.Name = "dateOfTodayToolStripStatusLabel"
        Me.dateOfTodayToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        '
        'dateTodayToolStripStatusLabel1
        '
        Me.dateTodayToolStripStatusLabel1.Name = "dateTodayToolStripStatusLabel1"
        Me.dateTodayToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dateTodayToolStripStatusLabel1.Size = New System.Drawing.Size(0, 0)
        '
        'TodayToolStripStatusLabel
        '
        Me.TodayToolStripStatusLabel.Name = "TodayToolStripStatusLabel"
        Me.TodayToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TodayToolStripStatusLabel.Size = New System.Drawing.Size(0, 0)
        Me.TodayToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 0)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1133, 671)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ParentForm"
        Me.Text = "Menu Organizer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFileNewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFileOpenMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFileClearMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFilePrintPreviewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFileSaveMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFileSaveAsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmuFileExitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents clearToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveAsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents exitToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents dateToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timeOfTodayToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dateOfTodayToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dateTodayToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TodayToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileWindowsHorizontallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileWindowsVerticallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
