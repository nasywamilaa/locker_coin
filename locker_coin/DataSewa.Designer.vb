<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSewa
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
        Me.MenuStripDataSewa = New System.Windows.Forms.MenuStrip()
        Me.LockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.DataGridViewSewa = New System.Windows.Forms.DataGridView()
        Me.MenuStripDataSewa.SuspendLayout()
        CType(Me.DataGridViewSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripDataSewa
        '
        Me.MenuStripDataSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStripDataSewa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuStripDataSewa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripDataSewa.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStripDataSewa.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStripDataSewa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockerToolStripMenuItem})
        Me.MenuStripDataSewa.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripDataSewa.Name = "MenuStripDataSewa"
        Me.MenuStripDataSewa.Size = New System.Drawing.Size(749, 33)
        Me.MenuStripDataSewa.TabIndex = 53
        Me.MenuStripDataSewa.Text = "MenuStrip1"
        '
        'LockerToolStripMenuItem
        '
        Me.LockerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.LockerToolStripMenuItem.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LockerToolStripMenuItem.Name = "LockerToolStripMenuItem"
        Me.LockerToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.LockerToolStripMenuItem.Text = "Rent"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(201, 34)
        Me.EditToolStripMenuItem.Text = "Take Out"
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnKembali.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKembali.Location = New System.Drawing.Point(552, 460)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(179, 35)
        Me.BtnKembali.TabIndex = 54
        Me.BtnKembali.Text = "Back"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'DataGridViewSewa
        '
        Me.DataGridViewSewa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSewa.Location = New System.Drawing.Point(13, 66)
        Me.DataGridViewSewa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridViewSewa.Name = "DataGridViewSewa"
        Me.DataGridViewSewa.RowHeadersWidth = 62
        Me.DataGridViewSewa.Size = New System.Drawing.Size(718, 386)
        Me.DataGridViewSewa.TabIndex = 52
        '
        'DataSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(749, 516)
        Me.Controls.Add(Me.MenuStripDataSewa)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.DataGridViewSewa)
        Me.Name = "DataSewa"
        Me.Text = "DataSewa"
        Me.MenuStripDataSewa.ResumeLayout(False)
        Me.MenuStripDataSewa.PerformLayout()
        CType(Me.DataGridViewSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripDataSewa As MenuStrip
    Friend WithEvents LockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnKembali As Button
    Friend WithEvents DataGridViewSewa As DataGridView
End Class
