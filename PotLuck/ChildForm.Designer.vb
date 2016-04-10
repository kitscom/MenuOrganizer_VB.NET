<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm

    Inherits System.Windows.Forms.Form

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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.dessertListBox = New System.Windows.Forms.ListBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.saladLabel = New System.Windows.Forms.Label()
        Me.appetizerLabel = New System.Windows.Forms.Label()
        Me.entreeLabel = New System.Windows.Forms.Label()
        Me.dessertLabel = New System.Windows.Forms.Label()
        Me.entreeListBox = New System.Windows.Forms.ListBox()
        Me.saladListBox = New System.Windows.Forms.ListBox()
        Me.appetizerListBox = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.documentSaveToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentSaveAsToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentSaveAsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(71, 94)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(51, 20)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name"
        '
        'dessertListBox
        '
        Me.dessertListBox.AllowDrop = True
        Me.dessertListBox.FormattingEnabled = True
        Me.dessertListBox.ItemHeight = 20
        Me.dessertListBox.Location = New System.Drawing.Point(663, 268)
        Me.dessertListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dessertListBox.Name = "dessertListBox"
        Me.dessertListBox.Size = New System.Drawing.Size(134, 224)
        Me.dessertListBox.TabIndex = 1
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(202, 90)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(203, 26)
        Me.nameTextBox.TabIndex = 2
        '
        'saladLabel
        '
        Me.saladLabel.AutoSize = True
        Me.saladLabel.Location = New System.Drawing.Point(258, 196)
        Me.saladLabel.Name = "saladLabel"
        Me.saladLabel.Size = New System.Drawing.Size(50, 20)
        Me.saladLabel.TabIndex = 3
        Me.saladLabel.Text = "Salad"
        '
        'appetizerLabel
        '
        Me.appetizerLabel.AutoSize = True
        Me.appetizerLabel.Location = New System.Drawing.Point(71, 196)
        Me.appetizerLabel.Name = "appetizerLabel"
        Me.appetizerLabel.Size = New System.Drawing.Size(77, 20)
        Me.appetizerLabel.TabIndex = 4
        Me.appetizerLabel.Text = "Appetizer"
        '
        'entreeLabel
        '
        Me.entreeLabel.AutoSize = True
        Me.entreeLabel.Location = New System.Drawing.Point(438, 196)
        Me.entreeLabel.Name = "entreeLabel"
        Me.entreeLabel.Size = New System.Drawing.Size(57, 20)
        Me.entreeLabel.TabIndex = 5
        Me.entreeLabel.Text = "Entree"
        '
        'dessertLabel
        '
        Me.dessertLabel.AutoSize = True
        Me.dessertLabel.Location = New System.Drawing.Point(659, 196)
        Me.dessertLabel.Name = "dessertLabel"
        Me.dessertLabel.Size = New System.Drawing.Size(65, 20)
        Me.dessertLabel.TabIndex = 6
        Me.dessertLabel.Text = "Dessert"
        '
        'entreeListBox
        '
        Me.entreeListBox.AllowDrop = True
        Me.entreeListBox.FormattingEnabled = True
        Me.entreeListBox.ItemHeight = 20
        Me.entreeListBox.Location = New System.Drawing.Point(441, 268)
        Me.entreeListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.entreeListBox.Name = "entreeListBox"
        Me.entreeListBox.Size = New System.Drawing.Size(134, 224)
        Me.entreeListBox.TabIndex = 7
        '
        'saladListBox
        '
        Me.saladListBox.AllowDrop = True
        Me.saladListBox.FormattingEnabled = True
        Me.saladListBox.ItemHeight = 20
        Me.saladListBox.Location = New System.Drawing.Point(250, 268)
        Me.saladListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.saladListBox.Name = "saladListBox"
        Me.saladListBox.Size = New System.Drawing.Size(134, 224)
        Me.saladListBox.TabIndex = 8
        '
        'appetizerListBox
        '
        Me.appetizerListBox.AllowDrop = True
        Me.appetizerListBox.FormattingEnabled = True
        Me.appetizerListBox.ItemHeight = 20
        Me.appetizerListBox.Location = New System.Drawing.Point(74, 268)
        Me.appetizerListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.appetizerListBox.Name = "appetizerListBox"
        Me.appetizerListBox.Size = New System.Drawing.Size(134, 224)
        Me.appetizerListBox.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(180, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentSaveAsMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 33)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'documentSaveToolStrip
        '
        Me.documentSaveToolStrip.Name = "documentSaveToolStrip"
        Me.documentSaveToolStrip.Size = New System.Drawing.Size(146, 30)
        Me.documentSaveToolStrip.Text = "&Save"
        '
        'DocumentSaveAsToolStrip
        '
        Me.DocumentSaveAsToolStrip.Name = "DocumentSaveAsToolStrip"
        Me.DocumentSaveAsToolStrip.Size = New System.Drawing.Size(146, 30)
        Me.DocumentSaveAsToolStrip.Text = "Save &As"
        '
        'DocumentSaveAsMenuItem
        '
        Me.DocumentSaveAsMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.DocumentSaveAsMenuItem.MergeIndex = 1
        Me.DocumentSaveAsMenuItem.Name = "DocumentSaveAsMenuItem"
        Me.DocumentSaveAsMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.DocumentSaveAsMenuItem.Text = "&Document"
        '
        'ChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 541)
        Me.Controls.Add(Me.appetizerListBox)
        Me.Controls.Add(Me.saladListBox)
        Me.Controls.Add(Me.entreeListBox)
        Me.Controls.Add(Me.dessertLabel)
        Me.Controls.Add(Me.entreeLabel)
        Me.Controls.Add(Me.appetizerLabel)
        Me.Controls.Add(Me.saladLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.dessertListBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChildForm"
        Me.Text = "New Document"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents dessertListBox As System.Windows.Forms.ListBox
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents saladLabel As System.Windows.Forms.Label
    Friend WithEvents appetizerLabel As System.Windows.Forms.Label
    Friend WithEvents entreeLabel As System.Windows.Forms.Label
    Friend WithEvents dessertLabel As System.Windows.Forms.Label
    Friend WithEvents entreeListBox As System.Windows.Forms.ListBox
    Friend WithEvents saladListBox As System.Windows.Forms.ListBox
    Friend WithEvents appetizerListBox As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents documentSaveToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentSaveAsToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentSaveAsMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
