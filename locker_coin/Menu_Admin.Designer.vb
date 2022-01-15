<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Admin
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonUpdateLocker = New System.Windows.Forms.Button()
        Me.LbClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTambahJenisLocker = New System.Windows.Forms.Button()
        Me.ButtonDataSewa = New System.Windows.Forms.Button()
        Me.ButtonAddLocker = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(98, 35)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'ButtonUpdateLocker
        '
        Me.ButtonUpdateLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ButtonUpdateLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateLocker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonUpdateLocker.Location = New System.Drawing.Point(79, 220)
        Me.ButtonUpdateLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUpdateLocker.Name = "ButtonUpdateLocker"
        Me.ButtonUpdateLocker.Size = New System.Drawing.Size(120, 23)
        Me.ButtonUpdateLocker.TabIndex = 54
        Me.ButtonUpdateLocker.Text = "Edit Locker"
        Me.ButtonUpdateLocker.UseVisualStyleBackColor = False
        '
        'LbClose
        '
        Me.LbClose.AutoSize = True
        Me.LbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbClose.Location = New System.Drawing.Point(222, 358)
        Me.LbClose.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbClose.Name = "LbClose"
        Me.LbClose.Size = New System.Drawing.Size(48, 17)
        Me.LbClose.TabIndex = 53
        Me.LbClose.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Welcome To Lockie "
        '
        'ButtonTambahJenisLocker
        '
        Me.ButtonTambahJenisLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ButtonTambahJenisLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambahJenisLocker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonTambahJenisLocker.Location = New System.Drawing.Point(79, 264)
        Me.ButtonTambahJenisLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTambahJenisLocker.Name = "ButtonTambahJenisLocker"
        Me.ButtonTambahJenisLocker.Size = New System.Drawing.Size(120, 23)
        Me.ButtonTambahJenisLocker.TabIndex = 51
        Me.ButtonTambahJenisLocker.Text = "Add Locker Type "
        Me.ButtonTambahJenisLocker.UseVisualStyleBackColor = False
        '
        'ButtonDataSewa
        '
        Me.ButtonDataSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ButtonDataSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDataSewa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDataSewa.Location = New System.Drawing.Point(79, 310)
        Me.ButtonDataSewa.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDataSewa.Name = "ButtonDataSewa"
        Me.ButtonDataSewa.Size = New System.Drawing.Size(120, 23)
        Me.ButtonDataSewa.TabIndex = 50
        Me.ButtonDataSewa.Text = "Rent Data Locker"
        Me.ButtonDataSewa.UseVisualStyleBackColor = False
        '
        'ButtonAddLocker
        '
        Me.ButtonAddLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ButtonAddLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddLocker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddLocker.Location = New System.Drawing.Point(79, 173)
        Me.ButtonAddLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAddLocker.Name = "ButtonAddLocker"
        Me.ButtonAddLocker.Size = New System.Drawing.Size(120, 23)
        Me.ButtonAddLocker.TabIndex = 49
        Me.ButtonAddLocker.Text = "Add Locker"
        Me.ButtonAddLocker.UseVisualStyleBackColor = False
        '
        'Menu_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(285, 396)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonUpdateLocker)
        Me.Controls.Add(Me.LbClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonTambahJenisLocker)
        Me.Controls.Add(Me.ButtonDataSewa)
        Me.Controls.Add(Me.ButtonAddLocker)
        Me.Name = "Menu_Admin"
        Me.Text = "Menu_Admin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonUpdateLocker As Button
    Friend WithEvents LbClose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonTambahJenisLocker As Button
    Friend WithEvents ButtonDataSewa As Button
    Friend WithEvents ButtonAddLocker As Button
End Class
