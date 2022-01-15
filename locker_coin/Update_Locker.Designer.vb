<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Locker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Locker))
        Me.TxtLockerPrice = New System.Windows.Forms.Label()
        Me.TxtLockerName = New System.Windows.Forms.Label()
        Me.TBHLocLC = New System.Windows.Forms.TextBox()
        Me.TBNamaLC = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnUpdateLocker = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtLockerPrice
        '
        Me.TxtLockerPrice.AutoSize = True
        Me.TxtLockerPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLockerPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TxtLockerPrice.Location = New System.Drawing.Point(129, 57)
        Me.TxtLockerPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtLockerPrice.Name = "TxtLockerPrice"
        Me.TxtLockerPrice.Size = New System.Drawing.Size(124, 17)
        Me.TxtLockerPrice.TabIndex = 61
        Me.TxtLockerPrice.Text = "Locker Location"
        '
        'TxtLockerName
        '
        Me.TxtLockerName.AutoSize = True
        Me.TxtLockerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLockerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TxtLockerName.Location = New System.Drawing.Point(129, 25)
        Me.TxtLockerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtLockerName.Name = "TxtLockerName"
        Me.TxtLockerName.Size = New System.Drawing.Size(103, 17)
        Me.TxtLockerName.TabIndex = 60
        Me.TxtLockerName.Text = "Locker Name"
        '
        'TBHLocLC
        '
        Me.TBHLocLC.Location = New System.Drawing.Point(257, 57)
        Me.TBHLocLC.Margin = New System.Windows.Forms.Padding(2)
        Me.TBHLocLC.Name = "TBHLocLC"
        Me.TBHLocLC.Size = New System.Drawing.Size(165, 20)
        Me.TBHLocLC.TabIndex = 59
        '
        'TBNamaLC
        '
        Me.TBNamaLC.Location = New System.Drawing.Point(257, 24)
        Me.TBNamaLC.Margin = New System.Windows.Forms.Padding(2)
        Me.TBNamaLC.Name = "TBNamaLC"
        Me.TBNamaLC.Size = New System.Drawing.Size(165, 20)
        Me.TBNamaLC.TabIndex = 58
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'BtnUpdateLocker
        '
        Me.BtnUpdateLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnUpdateLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLocker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUpdateLocker.Location = New System.Drawing.Point(257, 99)
        Me.BtnUpdateLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateLocker.Name = "BtnUpdateLocker"
        Me.BtnUpdateLocker.Size = New System.Drawing.Size(165, 23)
        Me.BtnUpdateLocker.TabIndex = 56
        Me.BtnUpdateLocker.Text = "Update"
        Me.BtnUpdateLocker.UseVisualStyleBackColor = False
        '
        'Update_Locker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(433, 178)
        Me.Controls.Add(Me.TxtLockerPrice)
        Me.Controls.Add(Me.TxtLockerName)
        Me.Controls.Add(Me.TBHLocLC)
        Me.Controls.Add(Me.TBNamaLC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnUpdateLocker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Update_Locker"
        Me.Text = "Update_Locker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtLockerPrice As Label
    Friend WithEvents TxtLockerName As Label
    Friend WithEvents TBHLocLC As TextBox
    Friend WithEvents TBNamaLC As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnUpdateLocker As Button
End Class
