<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomerOrder
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
        Me.cnButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fnametb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnameTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.onumTextBox = New System.Windows.Forms.TextBox()
        Me.ordsTb = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cnButton
        '
        Me.cnButton.Location = New System.Drawing.Point(183, 165)
        Me.cnButton.Name = "cnButton"
        Me.cnButton.Size = New System.Drawing.Size(75, 23)
        Me.cnButton.TabIndex = 43
        Me.cnButton.Text = "Exit"
        Me.cnButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(11, 165)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 42
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "First Name"
        '
        'fnametb
        '
        Me.fnametb.Location = New System.Drawing.Point(11, 66)
        Me.fnametb.Name = "fnametb"
        Me.fnametb.Size = New System.Drawing.Size(82, 20)
        Me.fnametb.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = " Last Name"
        '
        'lnameTb
        '
        Me.lnameTb.Location = New System.Drawing.Point(183, 65)
        Me.lnameTb.Name = "lnameTb"
        Me.lnameTb.Size = New System.Drawing.Size(82, 20)
        Me.lnameTb.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Order Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Order Total"
        '
        'totalTb
        '
        Me.totalTb.Location = New System.Drawing.Point(11, 139)
        Me.totalTb.Name = "totalTb"
        Me.totalTb.Size = New System.Drawing.Size(69, 20)
        Me.totalTb.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = " Customer ID:"
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(186, 25)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(82, 20)
        Me.idTextBox.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Order Number"
        '
        'onumTextBox
        '
        Me.onumTextBox.Location = New System.Drawing.Point(14, 26)
        Me.onumTextBox.Name = "onumTextBox"
        Me.onumTextBox.Size = New System.Drawing.Size(82, 20)
        Me.onumTextBox.TabIndex = 60
        '
        'ordsTb
        '
        Me.ordsTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ordsTb.FormattingEnabled = True
        Me.ordsTb.Items.AddRange(New Object() {"Active", "Inactive", "Pending"})
        Me.ordsTb.Location = New System.Drawing.Point(171, 139)
        Me.ordsTb.Name = "ordsTb"
        Me.ordsTb.Size = New System.Drawing.Size(97, 21)
        Me.ordsTb.TabIndex = 65
        '
        'NewCustomerOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 287)
        Me.Controls.Add(Me.ordsTb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.onumTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lnameTb)
        Me.Controls.Add(Me.cnButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fnametb)
        Me.Name = "NewCustomerOrder"
        Me.Text = "NewCustomerOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cnButton As System.Windows.Forms.Button
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fnametb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lnameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totalTb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents onumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ordsTb As System.Windows.Forms.ComboBox
End Class
