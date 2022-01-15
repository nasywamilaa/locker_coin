<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sewa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sewa))
        Me.BtnRent = New System.Windows.Forms.Button()
        Me.lbtotalbiaya = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnFinishRent = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVLocker = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBDuration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRent
        '
        Me.BtnRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnRent.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRent.Location = New System.Drawing.Point(807, 435)
        Me.BtnRent.Name = "BtnRent"
        Me.BtnRent.Size = New System.Drawing.Size(282, 35)
        Me.BtnRent.TabIndex = 68
        Me.BtnRent.Text = "Rent"
        Me.BtnRent.UseVisualStyleBackColor = False
        '
        'lbtotalbiaya
        '
        Me.lbtotalbiaya.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotalbiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbtotalbiaya.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbtotalbiaya.Location = New System.Drawing.Point(931, 384)
        Me.lbtotalbiaya.Name = "lbtotalbiaya"
        Me.lbtotalbiaya.Size = New System.Drawing.Size(158, 25)
        Me.lbtotalbiaya.TabIndex = 67
        Me.lbtotalbiaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnTutup.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTutup.Location = New System.Drawing.Point(996, 526)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(93, 35)
        Me.BtnTutup.TabIndex = 66
        Me.BtnTutup.Text = "Close"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'BtnFinishRent
        '
        Me.BtnFinishRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnFinishRent.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinishRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnFinishRent.Location = New System.Drawing.Point(807, 476)
        Me.BtnFinishRent.Name = "BtnFinishRent"
        Me.BtnFinishRent.Size = New System.Drawing.Size(282, 35)
        Me.BtnFinishRent.TabIndex = 65
        Me.BtnFinishRent.Text = "Finish Rent"
        Me.BtnFinishRent.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Geometr212 BkCn BT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(34, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 27)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Locker"
        '
        'LblHarga
        '
        Me.LblHarga.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LblHarga.Location = New System.Drawing.Point(972, 349)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(117, 25)
        Me.LblHarga.TabIndex = 63
        Me.LblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(802, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Price"
        '
        'DGVLocker
        '
        Me.DGVLocker.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLocker.Location = New System.Drawing.Point(34, 223)
        Me.DGVLocker.Name = "DGVLocker"
        Me.DGVLocker.RowHeadersWidth = 62
        Me.DGVLocker.RowTemplate.Height = 28
        Me.DGVLocker.Size = New System.Drawing.Size(744, 338)
        Me.DGVLocker.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Geometr212 BkCn BT", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(804, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "*Hours"
        '
        'TBDuration
        '
        Me.TBDuration.BackColor = System.Drawing.Color.White
        Me.TBDuration.Location = New System.Drawing.Point(807, 272)
        Me.TBDuration.Name = "TBDuration"
        Me.TBDuration.Size = New System.Drawing.Size(282, 26)
        Me.TBDuration.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Geometr212 BkCn BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(802, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Duration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Geometr212 BkCn BT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(203, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 35)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Welcome To Lockie "
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.locker_coin.My.Resources.Resources.LOCKIE
        Me.PictureBox1.Location = New System.Drawing.Point(34, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1132, 603)
        Me.Controls.Add(Me.BtnRent)
        Me.Controls.Add(Me.lbtotalbiaya)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnFinishRent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVLocker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBDuration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Sewa"
        Me.Text = "Sewa"
        CType(Me.DGVLocker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRent As Button
    Friend WithEvents lbtotalbiaya As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnFinishRent As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LblHarga As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVLocker As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TBDuration As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
