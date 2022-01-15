<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konfirm_Tambah_Jenis
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
        Me.lbLocLocation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbLockerLocation = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LbLockerName = New System.Windows.Forms.Label()
        Me.LblockerNO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbLocLocation
        '
        Me.lbLocLocation.AutoSize = True
        Me.lbLocLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLocLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbLocLocation.Location = New System.Drawing.Point(43, 156)
        Me.lbLocLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbLocLocation.Name = "lbLocLocation"
        Me.lbLocLocation.Size = New System.Drawing.Size(130, 18)
        Me.lbLocLocation.TabIndex = 53
        Me.lbLocLocation.Text = "Locker Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(43, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Locker Number"
        '
        'LbLockerLocation
        '
        Me.LbLockerLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLockerLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbLockerLocation.Location = New System.Drawing.Point(184, 156)
        Me.LbLockerLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbLockerLocation.Name = "LbLockerLocation"
        Me.LbLockerLocation.Size = New System.Drawing.Size(169, 19)
        Me.LbLockerLocation.TabIndex = 51
        Me.LbLockerLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAdd.Location = New System.Drawing.Point(79, 210)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(209, 23)
        Me.BtnAdd.TabIndex = 50
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'LbLockerName
        '
        Me.LbLockerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLockerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbLockerName.Location = New System.Drawing.Point(184, 115)
        Me.LbLockerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbLockerName.Name = "LbLockerName"
        Me.LbLockerName.Size = New System.Drawing.Size(148, 19)
        Me.LbLockerName.TabIndex = 49
        Me.LbLockerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblockerNO
        '
        Me.LblockerNO.AutoSize = True
        Me.LblockerNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblockerNO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LblockerNO.Location = New System.Drawing.Point(41, 54)
        Me.LblockerNO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblockerNO.Name = "LblockerNO"
        Me.LblockerNO.Size = New System.Drawing.Size(312, 18)
        Me.LblockerNO.TabIndex = 48
        Me.LblockerNO.Text = "Are You Sure Want To Add This Locker?"
        '
        'Konfirm_Tambah_Jenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 275)
        Me.Controls.Add(Me.lbLocLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbLockerLocation)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LbLockerName)
        Me.Controls.Add(Me.LblockerNO)
        Me.Name = "Konfirm_Tambah_Jenis"
        Me.Text = "Konfirm_Tambah_Jenis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLocLocation As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbLockerLocation As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LbLockerName As Label
    Friend WithEvents LblockerNO As Label
End Class
