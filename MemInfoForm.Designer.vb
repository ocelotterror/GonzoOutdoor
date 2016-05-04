<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemInfoForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemInfoForm))
        Me.memIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnameTextbox = New System.Windows.Forms.TextBox()
        Me.fnameTextbox = New System.Windows.Forms.TextBox()
        Me.minitialTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.billaddress1Textbox = New System.Windows.Forms.TextBox()
        Me.billaddress2Textbox = New System.Windows.Forms.TextBox()
        Me.cityTextbox = New System.Windows.Forms.TextBox()
        Me.stateTextbox = New System.Windows.Forms.TextBox()
        Me.zipTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.phoneTextbox = New System.Windows.Forms.TextBox()
        Me.emailTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.balanceTextbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.custID = New System.Windows.Forms.TextBox()
        Me.chargeButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchForMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'memIDTextbox
        '
        Me.memIDTextbox.Location = New System.Drawing.Point(78, 67)
        Me.memIDTextbox.Name = "memIDTextbox"
        Me.memIDTextbox.ReadOnly = True
        Me.memIDTextbox.Size = New System.Drawing.Size(100, 20)
        Me.memIDTextbox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member ID"
        '
        'lnameTextbox
        '
        Me.lnameTextbox.Location = New System.Drawing.Point(78, 145)
        Me.lnameTextbox.Name = "lnameTextbox"
        Me.lnameTextbox.ReadOnly = True
        Me.lnameTextbox.Size = New System.Drawing.Size(136, 20)
        Me.lnameTextbox.TabIndex = 1
        '
        'fnameTextbox
        '
        Me.fnameTextbox.Location = New System.Drawing.Point(220, 145)
        Me.fnameTextbox.Name = "fnameTextbox"
        Me.fnameTextbox.ReadOnly = True
        Me.fnameTextbox.Size = New System.Drawing.Size(129, 20)
        Me.fnameTextbox.TabIndex = 2
        '
        'minitialTextbox
        '
        Me.minitialTextbox.Location = New System.Drawing.Point(355, 145)
        Me.minitialTextbox.Name = "minitialTextbox"
        Me.minitialTextbox.ReadOnly = True
        Me.minitialTextbox.Size = New System.Drawing.Size(29, 20)
        Me.minitialTextbox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name (last, First, MI)"
        '
        'billaddress1Textbox
        '
        Me.billaddress1Textbox.Location = New System.Drawing.Point(78, 230)
        Me.billaddress1Textbox.Name = "billaddress1Textbox"
        Me.billaddress1Textbox.ReadOnly = True
        Me.billaddress1Textbox.Size = New System.Drawing.Size(306, 20)
        Me.billaddress1Textbox.TabIndex = 6
        '
        'billaddress2Textbox
        '
        Me.billaddress2Textbox.Location = New System.Drawing.Point(78, 256)
        Me.billaddress2Textbox.Name = "billaddress2Textbox"
        Me.billaddress2Textbox.ReadOnly = True
        Me.billaddress2Textbox.Size = New System.Drawing.Size(306, 20)
        Me.billaddress2Textbox.TabIndex = 4
        '
        'cityTextbox
        '
        Me.cityTextbox.Location = New System.Drawing.Point(78, 282)
        Me.cityTextbox.Name = "cityTextbox"
        Me.cityTextbox.ReadOnly = True
        Me.cityTextbox.Size = New System.Drawing.Size(166, 20)
        Me.cityTextbox.TabIndex = 7
        '
        'stateTextbox
        '
        Me.stateTextbox.Location = New System.Drawing.Point(250, 282)
        Me.stateTextbox.Name = "stateTextbox"
        Me.stateTextbox.ReadOnly = True
        Me.stateTextbox.Size = New System.Drawing.Size(28, 20)
        Me.stateTextbox.TabIndex = 8
        '
        'zipTextbox
        '
        Me.zipTextbox.Location = New System.Drawing.Point(284, 282)
        Me.zipTextbox.Name = "zipTextbox"
        Me.zipTextbox.ReadOnly = True
        Me.zipTextbox.Size = New System.Drawing.Size(100, 20)
        Me.zipTextbox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Billing Address"
        '
        'phoneTextbox
        '
        Me.phoneTextbox.Location = New System.Drawing.Point(78, 349)
        Me.phoneTextbox.Name = "phoneTextbox"
        Me.phoneTextbox.ReadOnly = True
        Me.phoneTextbox.Size = New System.Drawing.Size(166, 20)
        Me.phoneTextbox.TabIndex = 3
        '
        'emailTextbox
        '
        Me.emailTextbox.Location = New System.Drawing.Point(81, 416)
        Me.emailTextbox.Name = "emailTextbox"
        Me.emailTextbox.ReadOnly = True
        Me.emailTextbox.Size = New System.Drawing.Size(227, 20)
        Me.emailTextbox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Read"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(184, 478)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(274, 478)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteButton.TabIndex = 20
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(203, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Find"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'balanceTextbox
        '
        Me.balanceTextbox.Location = New System.Drawing.Point(312, 68)
        Me.balanceTextbox.Name = "balanceTextbox"
        Me.balanceTextbox.ReadOnly = True
        Me.balanceTextbox.Size = New System.Drawing.Size(100, 20)
        Me.balanceTextbox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "balance"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(441, 400)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 24
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(441, 478)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 25
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(441, 440)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 26
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(441, 226)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 27
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'custID
        '
        Me.custID.Location = New System.Drawing.Point(397, 12)
        Me.custID.Name = "custID"
        Me.custID.ReadOnly = True
        Me.custID.Size = New System.Drawing.Size(100, 20)
        Me.custID.TabIndex = 28
        '
        'chargeButton
        '
        Me.chargeButton.Location = New System.Drawing.Point(441, 63)
        Me.chargeButton.Name = "chargeButton"
        Me.chargeButton.Size = New System.Drawing.Size(75, 23)
        Me.chargeButton.TabIndex = 29
        Me.chargeButton.Text = "Charge"
        Me.chargeButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchForMemberToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SearchForMemberToolStripMenuItem
        '
        Me.SearchForMemberToolStripMenuItem.Name = "SearchForMemberToolStripMenuItem"
        Me.SearchForMemberToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SearchForMemberToolStripMenuItem.Text = "Search For Member"
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(441, 361)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 31
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'MemInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 534)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.chargeButton)
        Me.Controls.Add(Me.custID)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.balanceTextbox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.emailTextbox)
        Me.Controls.Add(Me.phoneTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.zipTextbox)
        Me.Controls.Add(Me.stateTextbox)
        Me.Controls.Add(Me.cityTextbox)
        Me.Controls.Add(Me.billaddress2Textbox)
        Me.Controls.Add(Me.billaddress1Textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.minitialTextbox)
        Me.Controls.Add(Me.fnameTextbox)
        Me.Controls.Add(Me.lnameTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.memIDTextbox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MemInfoForm"
        Me.Text = "MembersInfo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents memIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lnameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents fnameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents minitialTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents billaddress1Textbox As System.Windows.Forms.TextBox
    Friend WithEvents billaddress2Textbox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextbox As System.Windows.Forms.TextBox
    Friend WithEvents stateTextbox As System.Windows.Forms.TextBox
    Friend WithEvents zipTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents phoneTextbox As System.Windows.Forms.TextBox
    Friend WithEvents emailTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents balanceTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents backButton As Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents custID As System.Windows.Forms.TextBox
    Friend WithEvents chargeButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchForMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchButton As Button
End Class
