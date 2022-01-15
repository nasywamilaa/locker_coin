<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisLocker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JenisLocker))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtLockerPrice = New System.Windows.Forms.Label()
        Me.TxtLockerName = New System.Windows.Forms.Label()
        Me.TBHarga = New System.Windows.Forms.TextBox()
        Me.TBNamaJenis = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnAddJenis = New System.Windows.Forms.Button()
        Me.BtnUpdateJenis = New System.Windows.Forms.Button()
        Me.DataGridViewJenisLocker = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewJenisLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBack.Location = New System.Drawing.Point(326, 392)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(78, 23)
        Me.BtnBack.TabIndex = 52
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'TxtLockerPrice
        '
        Me.TxtLockerPrice.AutoSize = True
        Me.TxtLockerPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLockerPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TxtLockerPrice.Location = New System.Drawing.Point(125, 46)
        Me.TxtLockerPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtLockerPrice.Name = "TxtLockerPrice"
        Me.TxtLockerPrice.Size = New System.Drawing.Size(99, 17)
        Me.TxtLockerPrice.TabIndex = 51
        Me.TxtLockerPrice.Text = "Locker Price"
        '
        'TxtLockerName
        '
        Me.TxtLockerName.AutoSize = True
        Me.TxtLockerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLockerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TxtLockerName.Location = New System.Drawing.Point(125, 14)
        Me.TxtLockerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtLockerName.Name = "TxtLockerName"
        Me.TxtLockerName.Size = New System.Drawing.Size(103, 17)
        Me.TxtLockerName.TabIndex = 50
        Me.TxtLockerName.Text = "Locker Name"
        '
        'TBHarga
        '
        Me.TBHarga.Location = New System.Drawing.Point(235, 47)
        Me.TBHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.TBHarga.Name = "TBHarga"
        Me.TBHarga.Size = New System.Drawing.Size(165, 20)
        Me.TBHarga.TabIndex = 49
        '
        'TBNamaJenis
        '
        Me.TBNamaJenis.Location = New System.Drawing.Point(235, 14)
        Me.TBNamaJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.TBNamaJenis.Name = "TBNamaJenis"
        Me.TBNamaJenis.Size = New System.Drawing.Size(165, 20)
        Me.TBNamaJenis.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHapus.Location = New System.Drawing.Point(128, 82)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(78, 23)
        Me.BtnHapus.TabIndex = 46
        Me.BtnHapus.Text = "Remove"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnAddJenis
        '
        Me.BtnAddJenis.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnAddJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddJenis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAddJenis.Location = New System.Drawing.Point(320, 82)
        Me.BtnAddJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddJenis.Name = "BtnAddJenis"
        Me.BtnAddJenis.Size = New System.Drawing.Size(78, 23)
        Me.BtnAddJenis.TabIndex = 45
        Me.BtnAddJenis.Text = "Add"
        Me.BtnAddJenis.UseVisualStyleBackColor = False
        '
        'BtnUpdateJenis
        '
        Me.BtnUpdateJenis.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnUpdateJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateJenis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUpdateJenis.Location = New System.Drawing.Point(225, 82)
        Me.BtnUpdateJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateJenis.Name = "BtnUpdateJenis"
        Me.BtnUpdateJenis.Size = New System.Drawing.Size(78, 23)
        Me.BtnUpdateJenis.TabIndex = 44
        Me.BtnUpdateJenis.Text = "Update"
        Me.BtnUpdateJenis.UseVisualStyleBackColor = False
        '
        'DataGridViewJenisLocker
        '
        Me.DataGridViewJenisLocker.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewJenisLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisLocker.Location = New System.Drawing.Point(11, 128)
        Me.DataGridViewJenisLocker.Name = "DataGridViewJenisLocker"
        Me.DataGridViewJenisLocker.RowHeadersWidth = 62
        Me.DataGridViewJenisLocker.Size = New System.Drawing.Size(387, 248)
        Me.DataGridViewJenisLocker.TabIndex = 43
        '
        'JenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(419, 425)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtLockerPrice)
        Me.Controls.Add(Me.TxtLockerName)
        Me.Controls.Add(Me.TBHarga)
        Me.Controls.Add(Me.TBNamaJenis)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnAddJenis)
        Me.Controls.Add(Me.BtnUpdateJenis)
        Me.Controls.Add(Me.DataGridViewJenisLocker)
        Me.Name = "JenisLocker"
        Me.Text = "JenisLocker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewJenisLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtLockerPrice As Label
    Friend WithEvents TxtLockerName As Label
    Friend WithEvents TBHarga As TextBox
    Friend WithEvents TBNamaJenis As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnAddJenis As Button
    Friend WithEvents BtnUpdateJenis As Button
    Friend WithEvents DataGridViewJenisLocker As DataGridView
End Class
