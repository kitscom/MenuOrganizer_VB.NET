'Program: Browser
'Programmer: Amanda Henry
'Date: July, 2014
'Description: Child form has save menuStrip item. A textbox allows user to enter names, then drag n drop name into a listBox. Contents may be saved to a file.
'             Contains methods to read and write data.
Option Strict On

Imports System.IO
Imports System.Windows

Public Class ChildForm
    Private aChildForm As ChildForm
    Private fileNameString As String = ""

    Private isDirtyBoolean As Boolean
    Public writeFileStreamWriter As StreamWriter

    Private childOneCountInteger As Integer = 0I

    Private draggingFrom As Forms.ListBox = Nothing
    Private readFileStreamReader As StreamReader
    Dim newCopy As String

    Private Sub nameTextBox_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nameTextBox.MouseDown
        'select contents, invoke drag/drop

        If e.Button = Windows.Forms.MouseButtons.Left Then
            With nameTextBox
                .SelectAll()
                draggingFrom = Nothing

                .DoDragDrop(.SelectedText, DragDropEffects.Move)
            End With

        End If
    End Sub

    Private Sub listBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles appetizerListBox.MouseDown, entreeListBox.MouseDown, saladListBox.MouseDown, dessertListBox.MouseDown
        'Private Sub listBox_Clicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles appetizerListBox.Click, entreeListBox.Click, saladListBox.Click, dessertListBox.Click
        'select contents, invoke drag/drop
        Dim senderListBox As Forms.ListBox = CType(sender, Forms.ListBox)

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                With senderListBox
                    draggingFrom = senderListBox
                    .DoDragDrop(.SelectedIndex, DragDropEffects.Move)
                End With
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub itemListBox_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles saladListBox.DragDrop, appetizerListBox.DragDrop, entreeListBox.DragDrop, dessertListBox.DragDrop
        'add item to list box
        Dim senderListBox As Forms.ListBox = CType(sender, Forms.ListBox)

        If draggingFrom Is Nothing Then
            senderListBox.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
            reset()
        ElseIf Not draggingFrom Is senderListBox Then
            Dim index As Integer = CInt(e.Data.GetData(Type.GetType("System.Int32")))
            moveItem(senderListBox, index)
        End If
    End Sub

    Private Sub moveItem(ByRef senderListBox As Forms.ListBox, ByVal index As Integer)
        If index <> -1 Then
            senderListBox.Items.Add(draggingFrom.Items(index))
            draggingFrom.Items.RemoveAt(index)
        End If
        isDirtyBoolean = True
        draggingFrom = Nothing

    End Sub
    Private Sub ListBox_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles appetizerListBox.DragEnter, saladListBox.DragEnter, entreeListBox.DragEnter, dessertListBox.DragEnter

        'set the dragDrop effect
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub nameTextBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.MouseEnter
        'set mouse pointer to give feedback that drag is legal

        With nameTextBox
            If .Text <> "" Then
                .SelectAll()
                .Cursor = Cursors.Arrow
            Else
                .Cursor = Cursors.IBeam
            End If
        End With
    End Sub
    Private Sub appetizerListBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles appetizerListBox.MouseEnter
        'set mouse pointer to give feedback that drag is legal
        Dim i As Integer
        With appetizerListBox
            If .Text <> "" Then
                For i = 0 To Me.appetizerListBox.Items.Count - 1
                Next i
                .Cursor = Cursors.Arrow
            Else
                .Cursor = Cursors.IBeam
            End If
        End With
    End Sub
    Private Sub reset()
        'clear textBox and set Boolean
        nameTextBox.Clear()
        isDirtyBoolean = True
    End Sub
   
    Public Sub openFile(ByVal incomingFileNameString As String)
        'call parseData method to load new file chosen

        fileNameString = incomingFileNameString
        parseData()

    End Sub
    Public Sub parseData()
        Dim responseDialogResult As DialogResult
        If responseDialogResult = DialogResult.Cancel Then
            MessageBox.Show("User clicked clance")
            readFileStreamReader.Close()
            Return
        End If
        'read in the file
        Dim oneCourseString As String
        Dim foodsString As String
        Dim foodArrayString() As String

        Try
            readFileStreamReader = New StreamReader(fileNameString)

            oneCourseString = readFileStreamReader.ReadLine
            foodsString = oneCourseString.Split(":".ToCharArray)(1) 'split makes an array out of a string based on a delimiter, 0 index = "Appetizers" before ':', index 1 = all the rest
            foodArrayString = foodsString.Split(",".ToCharArray) 'assign the data to the food array
            'loop through the list and read a line in
            For foodCount As Integer = 0 To foodArrayString.Length - 1
                appetizerListBox.Items.Add(foodArrayString(foodCount))
            Next foodCount

            oneCourseString = readFileStreamReader.ReadLine
            foodsString = oneCourseString.Split(":".ToCharArray)(1)
            foodArrayString = foodsString.Split(",".ToCharArray)

            For foodCount As Integer = 0 To foodArrayString.Length - 1
                saladListBox.Items.Add(foodArrayString(foodCount))
            Next foodCount

            oneCourseString = readFileStreamReader.ReadLine
            foodsString = oneCourseString.Split(":".ToCharArray)(1)
            foodArrayString = foodsString.Split(",".ToCharArray)

            For foodCount As Integer = 0 To foodArrayString.Length - 1
                entreeListBox.Items.Add(foodArrayString(foodCount))
            Next foodCount

            oneCourseString = readFileStreamReader.ReadLine
            foodsString = oneCourseString.Split(":".ToCharArray)(1)
            foodArrayString = foodsString.Split(",".ToCharArray)

            For foodCount As Integer = 0 To foodArrayString.Length - 1
                dessertListBox.Items.Add(foodArrayString(foodCount))
            Next foodCount

            'close the reader
            readFileStreamReader.Close()
        Catch ex As Exception
           
        End Try
    End Sub

    Public Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles documentSaveToolStrip.Click

        If fileNameString = "" Then
            SaveAsToolStrip_Click(Nothing, Nothing)
        Else
            saveItems()
        End If
      
    End Sub
  
    Public Sub SaveAsToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentSaveAsToolStrip.Click
        'save the form as something other than what it was
        Dim responseDialogResult As DialogResult


        SaveFileDialog1.DefaultExt = "txt"

        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        responseDialogResult = SaveFileDialog1.ShowDialog()
       
        If responseDialogResult = DialogResult.Cancel Then
            Return
           
        End If

        fileNameString = SaveFileDialog1.FileName
        saveItems()
        'name the form the saved name
        Me.Text = Path.GetFileName(fileNameString)
       

    End Sub

    Public Sub saveItems()

        Try      'open the file
            writeFileStreamWriter = New StreamWriter(fileNameString, False)

            Dim appItemsInteger, saladItemsInteger, entreeItemsInteger, dessertItemsInteger As Integer
            Dim appLineString, saladLineString, entreeLineString, dessertLineString As String

            'save the list items in a file
            appItemsInteger = appetizerListBox.Items.Count - 1
            saladItemsInteger = saladListBox.Items.Count - 1
            entreeItemsInteger = entreeListBox.Items.Count - 1
            dessertItemsInteger = dessertListBox.Items.Count - 1

            appLineString = "Appetizers:"
            For appInteger As Integer = 0 To appItemsInteger
                appLineString += appetizerListBox.Items(appInteger).ToString & ","
            Next
            appLineString = appLineString.Trim(CChar(",")) ' trim that last comma
            writeFileStreamWriter.WriteLine(appLineString)

            saladLineString = "Salads:"
            For saladInteger As Integer = 0 To saladItemsInteger
                saladLineString += saladListBox.Items(saladInteger).ToString & ","
            Next
            saladLineString = saladLineString.Trim(CChar(","))
            writeFileStreamWriter.WriteLine(saladLineString)

            entreeLineString = "Entrées:"
            For entreeInteger As Integer = 0 To entreeItemsInteger
                entreeLineString += entreeListBox.Items(entreeInteger).ToString & ","
            Next
            entreeLineString = entreeLineString.Trim(CChar(","))
            writeFileStreamWriter.WriteLine(entreeLineString)

            dessertLineString = "Desserts:"
            For dessertInteger As Integer = 0 To dessertItemsInteger
                dessertLineString += dessertListBox.Items(dessertInteger).ToString & ","
            Next
            dessertLineString = dessertLineString.Trim(CChar(","))
            writeFileStreamWriter.WriteLine(dessertLineString)

            writeFileStreamWriter.Close()
            isDirtyBoolean = False

        Catch ex As Exception
            MessageBox.Show("Please open a file for writing.")

        End Try
    End Sub
    Public Sub clearLists()
        Try
            Me.appetizerListBox.Items.Clear()
            Me.saladListBox.Items.Clear()
            Me.entreeListBox.Items.Clear()
            Me.dessertListBox.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Exception: " & ex.Message)
        End Try
        'method to clear contents of listBox      
        isDirtyBoolean = True
    End Sub

    Private Sub form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'determine if form data has changed
        Dim responseDialogResult As DialogResult
        Dim messageString As String = ("Text has changed. Save modified text?")

        If isDirtyBoolean Then
            responseDialogResult = MessageBox.Show(messageString, "Text has Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If responseDialogResult = DialogResult.Yes Then
                'save the new file
                SaveToolStripMenuItem_Click(Nothing, Nothing)
            ElseIf responseDialogResult = DialogResult.Cancel Then
                e.Cancel = True

            End If
        End If
    End Sub

   
End Class