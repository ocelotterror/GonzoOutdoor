Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ShowMembersStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMembersStripMenuItem.Click
        Me.Hide()
        MemInfoForm.Show()
    End Sub

    
    Private Sub PayOnAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayOnAccountToolStripMenuItem.Click
        Dim memID As Integer = InputBox("Enter MemberID", "Payment", 0)
        Dim da As New OleDbDataAdapter
        Dim connection As New OleDbConnection
        Dim dr As OleDbDataReader
        connection.ConnectionString = My.Settings.ProjectDB1ConnectionString1
        connection.Open()
        Dim str As String
        str = " SELECT * from CUSTOMER WHERE (memID = '" & memID & "')"

        MemInputForm.Show()
        Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
        Dr = cmd.ExecuteReader
        While dr.Read
            MemInputForm.memIDTextBox.Text = dr("memID").ToString
            MemInputForm.memIDTextBox.Enabled = False
            MemInputForm.Label1.Text = "payment amount"
            MemInputForm.billAddress1TextBox.Enabled = False
            MemInputForm.billAddress2TextBox.Enabled = False
            MemInputForm.lnameTextBox.Text = dr("lName").ToString
            MemInputForm.lnameTextBox.Enabled = False
            MemInputForm.fnameTextBox.Text = dr("fname").ToString
            MemInputForm.fnameTextBox.Enabled = False
            MemInputForm.minitialTextBox.Enabled = False
            MemInputForm.cityTextBox.Enabled = False
            MemInputForm.stateTextBox.Enabled = False
            MemInputForm.zipTextBox.Enabled = False
            MemInputForm.phoneTextBox.Enabled = False
            MemInputForm.emailTextBox.Enabled = False
        End While
        Dim pmtamount As Double
        Double.TryParse(MemInputForm.balanceTextbox.Text, pmtamount)
        Call MemInfoForm.chargeCust(pmtamount)
    End Sub

    Private Sub OrderShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderShowToolStripMenuItem.Click
        CustomerOrderInformation.Show()

    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Inventory_directional_screen.Show()

    End Sub
End Class
