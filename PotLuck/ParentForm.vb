'Project: MenuOrganizer
'Programmer: Amanda Henry
'Date: July 2014
'Description: A textbox allows user to enter names, then drag n drop name into a listBox. Contents may be saved to a file.
'             ToolStrip bar and status bar are included. User may drag and drop any items from any listbox. Parent and child forms have been created.
'             User may create a new form. Mdi Project that uses shortcuts to the menuItems. Date and Time added to status bar.
Option Strict On
Imports System.IO, Microsoft.VisualBasic.FileIO

Public Class ParentForm
    Private isDirtyBoolean As Boolean
    Private childOneCountInteger As Integer = 0I
    Private fileNameString As String = ""
    Private fileNameString2 As String = ""

    Private readFileStreamReader As StreamReader
    Private writeFileStreamWriter As StreamWriter

    Private Function makeChild() As ChildForm

        Dim aChildForm As New ChildForm()
        Try
            aChildForm.MdiParent = Me
            childOneCountInteger += 1
            aChildForm.Text = "Document" & childOneCountInteger.ToString()

            Return aChildForm

        Catch ex As Exception

        End Try
        aChildForm.MdiParent = Me
        childOneCountInteger += 1
        aChildForm.Text = "Document" & childOneCountInteger.ToString()

        Return aChildForm

    End Function

    Private Sub mmuFileOpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuFileOpenMenuItem.Click, openToolStripButton.Click
        'call the load method
        loadItems()
    End Sub
   
    Private Sub loadItems()
        'set up and display open file dialog
        Dim responseDialogResult As DialogResult
        Dim aChildForm As ChildForm
        With OpenFileDialog1
            .InitialDirectory = Directory.GetCurrentDirectory
            .FileName = "*.txt"
            .Title = "Select File"
            responseDialogResult = .ShowDialog
        End With

        ' make sure user didn't click on cancel
        If responseDialogResult <> DialogResult.Cancel Then
            'open file
            fileNameString = OpenFileDialog1.FileName

            aChildForm = makeChild()
            aChildForm.openFile(fileNameString)
            aChildForm.Text = Path.GetFileName(fileNameString)
            aChildForm.Show()
            isDirtyBoolean = False

            mmuFileSaveAsMenuItem.Enabled = True
            mmuFileSaveMenuItem.Enabled = True
            mmuFileClearMenuItem.Enabled = True

        End If

        If responseDialogResult = DialogResult.Cancel Then
            mmuFileSaveAsMenuItem.Enabled = False
            mmuFileSaveMenuItem.Enabled = False
            mmuFileClearMenuItem.Enabled = False
        Else
            '   MessageBox.Show("Just not working")
        End If

    End Sub
   
    Private Sub SaveListsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuFileSaveMenuItem.Click, saveToolStripButton.Click

        'make a child form
        Dim aChildForm As ChildForm

        aChildForm = CType(Me.ActiveMdiChild, ChildForm)
        aChildForm.SaveToolStripMenuItem_Click(Nothing, Nothing)

    End Sub
    Private Sub SaveAsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveAsToolStripButton.Click, mmuFileSaveAsMenuItem.Click
        'call the save from the child form

        Dim aChildForm As ChildForm
        aChildForm = CType(Me.ActiveMdiChild, ChildForm)
        aChildForm.SaveAsToolStrip_Click(Nothing, Nothing)
        'ToolTip1.SetToolTip(TextBox1, "This field is required.") 

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuFileNewMenuItem.Click, newToolStripButton.Click
        'make a new ChildForm
        Dim aChildForm As ChildForm
        aChildForm = makeChild()
        aChildForm.Show()

        mmuFileSaveAsMenuItem.Enabled = True
        mmuFileSaveMenuItem.Enabled = True
        mmuFileClearMenuItem.Enabled = True
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuFileClearMenuItem.Click, clearToolStripButton.Click
        'determine if user wants to clear lists

        Dim aChildForm As ChildForm
        aChildForm = CType(Me.ActiveMdiChild, ChildForm)

        Dim responseDialogResult As DialogResult
        responseDialogResult = MessageBox.Show("Please confirm that you want to clear the lists.", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If responseDialogResult = DialogResult.Yes Then

            aChildForm.clearLists()
            isDirtyBoolean = True
        End If
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuFilePrintPreviewMenuItem.Click, printPreviewToolStripButton.Click
        'Print the form on the printer
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmuFileExitMenuItem.Click, exitToolStripButton.Click
        'close program
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'assign the dateTime structure with Now property

        TodayToolStripStatusLabel.Text = Now.ToLongTimeString
        timeOfTodayToolStripStatusLabel.Text = Now.ToShortDateString
    End Sub
   
    Private Sub TileWindowsHorizontallyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileWindowsHorizontallyToolStripMenuItem.Click
        'set layout
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileWindowsVerticallyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileWindowsVerticallyToolStripMenuItem.Click
        'set layout
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeWindowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CascadeWindowsToolStripMenuItem.Click
        'set layout
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub ParentForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'disable controls on load
        mmuFileSaveAsMenuItem.Enabled = False
        mmuFileSaveMenuItem.Enabled = False
        mmuFileClearMenuItem.Enabled = False
    End Sub
End Class