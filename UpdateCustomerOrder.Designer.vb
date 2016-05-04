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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fnametb = New System.Windows.Forms.TextBox()
        Me.odsTextBox = New System.Windows.Forms.ComboBox()
        Me.ototTextBox = New System.Windows.Forms.TextBox()
        Me.onumTextBox = New System.Windows.Forms.TextBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        OrdNumLabel.Location = New System.Drawing.Point(28, 36)
        OrdNumLabel.Name = "OrdNumLabel"
        OrdNumLabel.Size = New System.Drawing.Size(52, 13)
        OrdNumLabel.TabIndex = 3
        OrdNumLabel.Text = "Ord Num:"
        '
        'CustIDLabel
        '
        CustIDLabel.AutoSize = True
        CustIDLabel.Location = New System.Drawing.Point(301, -16)
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
        Me.saveButton.TabIndex = 6
        Me.saveButton.Text = "Save Changes"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'cnButton
        '
        Me.cnButton.Location = New System.Drawing.Point(375, 262)
        Me.cnButton.Name = "cnButton"
        Me.cnButton.Size = New System.Drawing.Size(75, 23)
        Me.cnButton.TabIndex = 23
        Me.cnButton.Text = "Close"
        Me.cnButton.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(OrdNumLabel)
        Me.GroupBox1.Controls.Add(CustIDLabel)
        Me.GroupBox1.Controls.Add(Me.onumTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 138)
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
        Me.lnameTb.TabIndex = 2
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
        Me.fnametb.TabIndex = 3
        '
        'odsTextBox
        '
        Me.odsTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.odsTextBox.FormattingEnabled = True
        Me.odsTextBox.Items.AddRange(New Object() {"New", "Active", "Inactive", "Shipped", "Process Return", "Process Exchange"})
        Me.odsTextBox.Location = New System.Drawing.Point(86, 100)
        Me.odsTextBox.Name = "odsTextBox"
        Me.odsTextBox.Size = New System.Drawing.Size(97, 21)
        Me.odsTextBox.TabIndex = 4
        '
        'ototTextBox
        '
        Me.ototTextBox.Location = New System.Drawing.Point(294, 101)
        Me.ototTextBox.Name = "ototTextBox"
        Me.ototTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ototTextBox.TabIndex = 5
        '
        'onumTextBox
        '
        Me.onumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.onumTextBox.Location = New System.Drawing.Point(86, 36)
        Me.onumTextBox.Name = "onumTextBox"
        Me.onumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.onumTextBox.TabIndex = 4
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(232, 15)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(58, 20)
        Me.idTextBox.TabIndex = 1
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(334, 12)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 29
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Customer ID"
        '
        'Order_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 310)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cnButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.idTextBox)
        Me.Name = "Order_Entry"
        Me.Text = "Order_Entry"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents cnButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ototTextBox As System.Windows.Forms.TextBox
    Friend WithEvents idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents onumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents odsTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lnameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fnametb As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
