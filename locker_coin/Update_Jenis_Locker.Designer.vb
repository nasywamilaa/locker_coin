<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Jenis_Locker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Jenis_Locker))
        Me.TxtLockerPrice = New System.Windows.Forms.Label()
        Me.TxtLockerName = New System.Windows.Forms.Label()
        Me.TBHarga = New System.Windows.Forms.TextBox()
        Me.TBNamaJenis = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnUpdateJenis = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtLockerPrice
        '
        Me.TxtLockerPrice.AutoSize = True
        Me.TxtLockerPrice.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLockerPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TxtLockerPrice.Location = New System.Drawing.Point(202, 90)
        Me.TxtLockerPrice.Name = "TxtLockerPrice"
        Me.TxtLockerPrice.Size = New System.Drawing.Size(133, 25)
        Me.TxtLockerPrice.TabIndex = 55
        Me.TxtLockerPrice.Text = "Locker Price"
        '
        'TxtLockerName
        '
        Me.TxtLockerName.AutoSize = True
        Me.TxtLockerName.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLockerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TxtLockerName.Location = New System.Drawing.Point(202, 41)
        Me.TxtLockerName.Name = "TxtLockerName"
        Me.TxtLockerName.Size = New System.Drawing.Size(129, 25)
        Me.TxtLockerName.TabIndex = 54
        Me.TxtLockerName.Text = "Locker Type"
        '
        'TBHarga
        '
        Me.TBHarga.Location = New System.Drawing.Point(367, 91)
        Me.TBHarga.Name = "TBHarga"
        Me.TBHarga.Size = New System.Drawing.Size(245, 26)
        Me.TBHarga.TabIndex = 53
        '
        'TBNamaJenis
        '
        Me.TBNamaJenis.Location = New System.Drawing.Point(367, 40)
        Me.TBNamaJenis.Name = "TBNamaJenis"
        Me.TBNamaJenis.Size = New System.Drawing.Size(245, 26)
        Me.TBNamaJenis.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.locker_coin.My.Resources.Resources.LOCKIE
        Me.PictureBox1.Location = New System.Drawing.Point(39, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'BtnUpdateJenis
        '
        Me.BtnUpdateJenis.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnUpdateJenis.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateJenis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUpdateJenis.Location = New System.Drawing.Point(367, 151)
        Me.BtnUpdateJenis.Name = "BtnUpdateJenis"
        Me.BtnUpdateJenis.Size = New System.Drawing.Size(245, 35)
        Me.BtnUpdateJenis.TabIndex = 50
        Me.BtnUpdateJenis.Text = "Update"
        Me.BtnUpdateJenis.UseVisualStyleBackColor = False
        '
        'Update_Jenis_Locker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(646, 227)
        Me.Controls.Add(Me.TxtLockerPrice)
        Me.Controls.Add(Me.TxtLockerName)
        Me.Controls.Add(Me.TBHarga)
        Me.Controls.Add(Me.TBNamaJenis)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnUpdateJenis)
        Me.Name = "Update_Jenis_Locker"
        Me.Text = "Update_Jenis_Locker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtLockerPrice As Label
    Friend WithEvents TxtLockerName As Label
    Friend WithEvents TBHarga As TextBox
    Friend WithEvents TBNamaJenis As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnUpdateJenis As Button
End Class
