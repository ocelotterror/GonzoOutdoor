<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GonzoOutdoorSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GonzoOutdoorSystem))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMembersStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayOnAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMembersStripMenuItem, Me.FindMembersToolStripMenuItem, Me.PayOnAccountToolStripMenuItem, Me.OrderShowToolStripMenuItem, Me.InventoryToolStripMenuItem})
        Me.ToolsMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(150, 21)
        Me.ToolsMenu.Text = "&GonzoOutdoor Menu"
        '
        'ShowMembersStripMenuItem
        '
        Me.ShowMembersStripMenuItem.Name = "ShowMembersStripMenuItem"
        Me.ShowMembersStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ShowMembersStripMenuItem.Text = "&ShowMembers"
        '
        'FindMembersToolStripMenuItem
        '
        Me.FindMembersToolStripMenuItem.Name = "FindMembersToolStripMenuItem"
        Me.FindMembersToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FindMembersToolStripMenuItem.Text = "Find Members"
        '
        'PayOnAccountToolStripMenuItem
        '
        Me.PayOnAccountToolStripMenuItem.Name = "PayOnAccountToolStripMenuItem"
        Me.PayOnAccountToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PayOnAccountToolStripMenuItem.Text = "Pay on account"
        '
        'OrderShowToolStripMenuItem
        '
        Me.OrderShowToolStripMenuItem.Name = "OrderShowToolStripMenuItem"
        Me.OrderShowToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OrderShowToolStripMenuItem.Text = "Order Show"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'GonzoOutdoorSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "GonzoOutdoorSystem"
        Me.Text = "Gonzo Outdor Software"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowMembersStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindMembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayOnAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
