<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Sewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewSewa = New System.Windows.Forms.DataGridView()
        Me.MenuStripDataSewa = New System.Windows.Forms.MenuStrip()
        Me.LockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripDataSewa.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewSewa
        '
        Me.DataGridViewSewa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSewa.Location = New System.Drawing.Point(12, 42)
        Me.DataGridViewSewa.Name = "DataGridViewSewa"
        Me.DataGridViewSewa.Size = New System.Drawing.Size(479, 251)
        Me.DataGridViewSewa.TabIndex = 1
        '
        'MenuStripDataSewa
        '
        Me.MenuStripDataSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStripDataSewa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuStripDataSewa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripDataSewa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockerToolStripMenuItem})
        Me.MenuStripDataSewa.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripDataSewa.Name = "MenuStripDataSewa"
        Me.MenuStripDataSewa.Size = New System.Drawing.Size(504, 25)
        Me.MenuStripDataSewa.TabIndex = 2
        Me.MenuStripDataSewa.Text = "MenuStrip1"
        '
        'LockerToolStripMenuItem
        '
        Me.LockerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.LockerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LockerToolStripMenuItem.Name = "LockerToolStripMenuItem"
        Me.LockerToolStripMenuItem.Size = New System.Drawing.Size(51, 21)
        Me.LockerToolStripMenuItem.Text = "Sewa"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TambahToolStripMenuItem.Text = "Sewa"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditToolStripMenuItem.Text = "Take Out"
        '
        'Data_Sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 304)
        Me.Controls.Add(Me.MenuStripDataSewa)
        Me.Controls.Add(Me.DataGridViewSewa)
        Me.Name = "Data_Sewa"
        Me.Text = "Data_Sewa"
        CType(Me.DataGridViewSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripDataSewa.ResumeLayout(False)
        Me.MenuStripDataSewa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewSewa As DataGridView
    Friend WithEvents MenuStripDataSewa As MenuStrip
    Friend WithEvents LockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
