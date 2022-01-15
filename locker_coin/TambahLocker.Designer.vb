<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahLocker
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
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.lbLockerTypeName = New System.Windows.Forms.Label()
        Me.TBLoc = New System.Windows.Forms.TextBox()
        Me.TBLockerName = New System.Windows.Forms.TextBox()
        Me.LBLockerType = New System.Windows.Forms.Label()
        Me.LbLokasiLocker = New System.Windows.Forms.Label()
        Me.LbNamaLocker = New System.Windows.Forms.Label()
        Me.DataGridViewLocker = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKembali.Location = New System.Drawing.Point(367, 344)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(119, 23)
        Me.BtnKembali.TabIndex = 61
        Me.BtnKembali.Text = "Back"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAdd.Location = New System.Drawing.Point(277, 306)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(209, 23)
        Me.BtnAdd.TabIndex = 60
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'lbLockerTypeName
        '
        Me.lbLockerTypeName.AutoSize = True
        Me.lbLockerTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLockerTypeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbLockerTypeName.Location = New System.Drawing.Point(306, 243)
        Me.lbLockerTypeName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbLockerTypeName.Name = "lbLockerTypeName"
        Me.lbLockerTypeName.Size = New System.Drawing.Size(141, 26)
        Me.lbLockerTypeName.TabIndex = 59
        Me.lbLockerTypeName.Text = "Locker Type"
        '
        'TBLoc
        '
        Me.TBLoc.Location = New System.Drawing.Point(277, 138)
        Me.TBLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.TBLoc.Name = "TBLoc"
        Me.TBLoc.Size = New System.Drawing.Size(209, 20)
        Me.TBLoc.TabIndex = 58
        '
        'TBLockerName
        '
        Me.TBLockerName.Location = New System.Drawing.Point(277, 53)
        Me.TBLockerName.Margin = New System.Windows.Forms.Padding(2)
        Me.TBLockerName.Name = "TBLockerName"
        Me.TBLockerName.Size = New System.Drawing.Size(209, 20)
        Me.TBLockerName.TabIndex = 57
        '
        'LBLockerType
        '
        Me.LBLockerType.AutoSize = True
        Me.LBLockerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLockerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LBLockerType.Location = New System.Drawing.Point(273, 192)
        Me.LBLockerType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLockerType.Name = "LBLockerType"
        Me.LBLockerType.Size = New System.Drawing.Size(106, 20)
        Me.LBLockerType.TabIndex = 56
        Me.LBLockerType.Text = "Locker Type"
        '
        'LbLokasiLocker
        '
        Me.LbLokasiLocker.AutoSize = True
        Me.LbLokasiLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLokasiLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbLokasiLocker.Location = New System.Drawing.Point(273, 104)
        Me.LbLokasiLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbLokasiLocker.Name = "LbLokasiLocker"
        Me.LbLokasiLocker.Size = New System.Drawing.Size(137, 20)
        Me.LbLokasiLocker.TabIndex = 55
        Me.LbLokasiLocker.Text = "Locker Location"
        '
        'LbNamaLocker
        '
        Me.LbNamaLocker.AutoSize = True
        Me.LbNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNamaLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbNamaLocker.Location = New System.Drawing.Point(273, 21)
        Me.LbNamaLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNamaLocker.Name = "LbNamaLocker"
        Me.LbNamaLocker.Size = New System.Drawing.Size(114, 20)
        Me.LbNamaLocker.TabIndex = 54
        Me.LbNamaLocker.Text = "Locker Name"
        '
        'DataGridViewLocker
        '
        Me.DataGridViewLocker.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLocker.Location = New System.Drawing.Point(11, 5)
        Me.DataGridViewLocker.Name = "DataGridViewLocker"
        Me.DataGridViewLocker.RowHeadersWidth = 62
        Me.DataGridViewLocker.Size = New System.Drawing.Size(240, 298)
        Me.DataGridViewLocker.TabIndex = 53
        '
        'TambahLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(497, 373)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.lbLockerTypeName)
        Me.Controls.Add(Me.TBLoc)
        Me.Controls.Add(Me.TBLockerName)
        Me.Controls.Add(Me.LBLockerType)
        Me.Controls.Add(Me.LbLokasiLocker)
        Me.Controls.Add(Me.LbNamaLocker)
        Me.Controls.Add(Me.DataGridViewLocker)
        Me.Name = "TambahLocker"
        Me.Text = "Tambah_Locker"
        CType(Me.DataGridViewLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents lbLockerTypeName As Label
    Friend WithEvents TBLoc As TextBox
    Friend WithEvents TBLockerName As TextBox
    Friend WithEvents LBLockerType As Label
    Friend WithEvents LbLokasiLocker As Label
    Friend WithEvents LbNamaLocker As Label
    Friend WithEvents DataGridViewLocker As DataGridView
End Class
