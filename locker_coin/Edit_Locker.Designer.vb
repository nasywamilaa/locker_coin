<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Locker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Locker))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHilang = New System.Windows.Forms.Button()
        Me.BtnUpdateLocker = New System.Windows.Forms.Button()
        Me.DataGridViewUpdateLoker = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewUpdateLoker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBack.Location = New System.Drawing.Point(260, 395)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(78, 23)
        Me.BtnBack.TabIndex = 52
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'BtnHilang
        '
        Me.BtnHilang.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnHilang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHilang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHilang.Location = New System.Drawing.Point(164, 89)
        Me.BtnHilang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHilang.Name = "BtnHilang"
        Me.BtnHilang.Size = New System.Drawing.Size(78, 23)
        Me.BtnHilang.TabIndex = 50
        Me.BtnHilang.Text = "Remove"
        Me.BtnHilang.UseVisualStyleBackColor = False
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(260, 89)
        Me.BtnUpdateLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(78, 23)
        Me.BtnUpdateLocker.TabIndex = 49
        Me.BtnUpdateLocker.Text = "Update"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = False
        '
        'DataGridViewUpdateLoker
        '
        Me.DataGridViewUpdateLoker.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewUpdateLoker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUpdateLoker.Location = New System.Drawing.Point(12, 117)
        Me.DataGridViewUpdateLoker.Name = "DataGridViewUpdateLoker"
        Me.DataGridViewUpdateLoker.RowHeadersWidth = 62
        Me.DataGridViewUpdateLoker.Size = New System.Drawing.Size(327, 248)
        Me.DataGridViewUpdateLoker.TabIndex = 48
        '
        'Edit_Locker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(396, 431)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnHilang)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.Controls.Add(Me.DataGridViewUpdateLoker)
        Me.Name = "Edit_Locker"
        Me.Text = "Edit_Locker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewUpdateLoker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnHilang As Button
    Friend WithEvents BtnUpdateLocker As Button
    Friend WithEvents DataGridViewUpdateLoker As DataGridView
End Class
