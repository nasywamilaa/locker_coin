<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitor_Locker
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStripMonitorLocker = New System.Windows.Forms.MenuStrip()
        Me.LockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripMonitorLocker.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(479, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStripMonitorLocker
        '
        Me.MenuStripMonitorLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStripMonitorLocker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuStripMonitorLocker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripMonitorLocker.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockerToolStripMenuItem})
        Me.MenuStripMonitorLocker.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMonitorLocker.Name = "MenuStripMonitorLocker"
        Me.MenuStripMonitorLocker.Size = New System.Drawing.Size(503, 25)
        Me.MenuStripMonitorLocker.TabIndex = 1
        Me.MenuStripMonitorLocker.Text = "MenuStrip1"
        '
        'LockerToolStripMenuItem
        '
        Me.LockerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.LockerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LockerToolStripMenuItem.Name = "LockerToolStripMenuItem"
        Me.LockerToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.LockerToolStripMenuItem.Text = "Locker"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TambahToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Monitor_Locker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 337)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStripMonitorLocker)
        Me.MainMenuStrip = Me.MenuStripMonitorLocker
        Me.Name = "Monitor_Locker"
        Me.Text = "Monitor_Locker"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripMonitorLocker.ResumeLayout(False)
        Me.MenuStripMonitorLocker.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStripMonitorLocker As MenuStrip
    Friend WithEvents LockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
End Class
