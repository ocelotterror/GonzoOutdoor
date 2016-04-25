<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Entry
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
        Dim OrdNumLabel As System.Windows.Forms.Label
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim Order_TotalLabel As System.Windows.Forms.Label
        Dim Order_StatusLabel As System.Windows.Forms.Label
        Me.saveButton = New System.Windows.Forms.Button()
        Me.cnButton = New System.Windows.Forms.Button()
        Me.preButton = New System.Windows.Forms.Button()
        Me.firstButton = New System.Windows.Forms.Button()
        Me.lastButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fnametb = New System.Windows.Forms.TextBox()
        Me.odsTextBox = New System.Windows.Forms.ComboBox()
        Me.ototTextBox = New System.Windows.Forms.TextBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.onumTextBox = New System.Windows.Forms.TextBox()
        OrdNumLabel = New System.Windows.Forms.Label()
        CustIDLabel = New System.Windows.Forms.Label()
        Order_TotalLabel = New System.Windows.Forms.Label()
        Order_StatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrdNumLabel
        '
        OrdNumLabel.AutoSize = True
        OrdNumLabel.Location = New System.Drawing.Point(156, 24)
        OrdNumLabel.Name = "OrdNumLabel"
        OrdNumLabel.Size = New System.Drawing.Size(52, 13)
        OrdNumLabel.TabIndex = 3
        OrdNumLabel.Text = "Ord Num:"
        '
        'CustIDLabel
        '
        CustIDLabel.AutoSize = True
        CustIDLabel.Location = New System.Drawing.Point(102, 19)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(44, 13)
        CustIDLabel.TabIndex = 5
        CustIDLabel.Text = "cust ID:"
        '
        'Order_TotalLabel
        '
        Order_TotalLabel.AutoSize = True
        Order_TotalLabel.Location = New System.Drawing.Point(225, 100)
        Order_TotalLabel.Name = "Order_TotalLabel"
        Order_TotalLabel.Size = New System.Drawing.Size(63, 13)
        Order_TotalLabel.TabIndex = 7
        Order_TotalLabel.Text = "Order Total:"
        '
        'Order_StatusLabel
        '
        Order_StatusLabel.AutoSize = True
        Order_StatusLabel.Location = New System.Drawing.Point(11, 100)
        Order_StatusLabel.Name = "Order_StatusLabel"
        Order_StatusLabel.Size = New System.Drawing.Size(69, 13)
        Order_StatusLabel.TabIndex = 9
        Order_StatusLabel.Text = "Order Status:"
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(61, 262)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 22
        Me.saveButton.Text = "Save Changes"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'cnButton
        '
        Me.cnButton.Location = New System.Drawing.Point(343, 262)
        Me.cnButton.Name = "cnButton"
        Me.cnButton.Size = New System.Drawing.Size(75, 23)
        Me.cnButton.TabIndex = 23
        Me.cnButton.Text = "Cancel"
        Me.cnButton.UseVisualStyleBackColor = True
        '
        'preButton
        '
        Me.preButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.preButton.Location = New System.Drawing.Point(75, 12)
        Me.preButton.Name = "preButton"
        Me.preButton.Size = New System.Drawing.Size(40, 25)
        Me.preButton.TabIndex = 24
        Me.preButton.Text = "<"
        Me.preButton.UseVisualStyleBackColor = True
        '
        'firstButton
        '
        Me.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.firstButton.Location = New System.Drawing.Point(29, 12)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(40, 25)
        Me.firstButton.TabIndex = 25
        Me.firstButton.Text = "First"
        Me.firstButton.UseVisualStyleBackColor = True
        '
        'lastButton
        '
        Me.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lastButton.Location = New System.Drawing.Point(410, 12)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(40, 25)
        Me.lastButton.TabIndex = 26
        Me.lastButton.Text = "Last"
        Me.lastButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextButton.Location = New System.Drawing.Point(355, 12)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(40, 25)
        Me.nextButton.TabIndex = 27
        Me.nextButton.Text = ">"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lnameTb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.fnametb)
        Me.GroupBox1.Controls.Add(Me.odsTextBox)
        Me.GroupBox1.Controls.Add(Order_StatusLabel)
        Me.GroupBox1.Controls.Add(Order_TotalLabel)
        Me.GroupBox1.Controls.Add(Me.ototTextBox)
        Me.GroupBox1.Controls.Add(CustIDLabel)
        Me.GroupBox1.Controls.Add(Me.idTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 195)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modify Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = " Last Name"
        '
        'lnameTb
        '
        Me.lnameTb.Location = New System.Drawing.Point(203, 35)
        Me.lnameTb.Name = "lnameTb"
        Me.lnameTb.Size = New System.Drawing.Size(82, 20)
        Me.lnameTb.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "First Name"
        '
        'fnametb
        '
        Me.fnametb.Location = New System.Drawing.Point(312, 35)
        Me.fnametb.Name = "fnametb"
        Me.fnametb.Size = New System.Drawing.Size(82, 20)
        Me.fnametb.TabIndex = 46
        '
        'odsTextBox
        '
        Me.odsTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.odsTextBox.FormattingEnabled = True
        Me.odsTextBox.Items.AddRange(New Object() {"Active", "Shipped", "Return", "Exchange"})
        Me.odsTextBox.Location = New System.Drawing.Point(86, 100)
        Me.odsTextBox.Name = "odsTextBox"
        Me.odsTextBox.Size = New System.Drawing.Size(97, 21)
        Me.odsTextBox.TabIndex = 29
        '
        'ototTextBox
        '
        Me.ototTextBox.Location = New System.Drawing.Point(294, 101)
        Me.ototTextBox.Name = "ototTextBox"
        Me.ototTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ototTextBox.TabIndex = 8
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(67, 35)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idTextBox.TabIndex = 6
        '
        'onumTextBox
        '
        Me.onumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.onumTextBox.Location = New System.Drawing.Point(214, 24)
        Me.onumTextBox.Name = "onumTextBox"
        Me.onumTextBox.ReadOnly = True
        Me.onumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.onumTextBox.TabIndex = 4
        '
        'Order_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 310)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.lastButton)
        Me.Controls.Add(Me.firstButton)
        Me.Controls.Add(Me.preButton)
        Me.Controls.Add(Me.cnButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(OrdNumLabel)
        Me.Controls.Add(Me.onumTextBox)
        Me.Name = "Order_Entry"
        Me.Text = "Order_Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents cnButton As System.Windows.Forms.Button
    Friend WithEvents preButton As System.Windows.Forms.Button
    Friend WithEvents firstButton As System.Windows.Forms.Button
    Friend WithEvents lastButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ototTextBox As System.Windows.Forms.TextBox
    Friend WithEvents idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents onumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents odsTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lnameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fnametb As System.Windows.Forms.TextBox
End Class
