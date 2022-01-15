<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Locker
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
        Me.BtnCancelRemove = New System.Windows.Forms.Button()
        Me.BtnRemoveLocker = New System.Windows.Forms.Button()
        Me.LbLockerNama = New System.Windows.Forms.Label()
        Me.LbNamaLocker = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelRemove
        '
        Me.BtnCancelRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnCancelRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelRemove.Location = New System.Drawing.Point(93, 238)
        Me.BtnCancelRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelRemove.Name = "BtnCancelRemove"
        Me.BtnCancelRemove.Size = New System.Drawing.Size(209, 23)
        Me.BtnCancelRemove.TabIndex = 44
        Me.BtnCancelRemove.Text = "Cancel"
        Me.BtnCancelRemove.UseVisualStyleBackColor = False
        '
        'BtnRemoveLocker
        '
        Me.BtnRemoveLocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnRemoveLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveLocker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRemoveLocker.Location = New System.Drawing.Point(93, 199)
        Me.BtnRemoveLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemoveLocker.Name = "BtnRemoveLocker"
        Me.BtnRemoveLocker.Size = New System.Drawing.Size(209, 23)
        Me.BtnRemoveLocker.TabIndex = 43
        Me.BtnRemoveLocker.Text = "Remove"
        Me.BtnRemoveLocker.UseVisualStyleBackColor = False
        '
        'LbLockerNama
        '
        Me.LbLockerNama.AutoSize = True
        Me.LbLockerNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLockerNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbLockerNama.Location = New System.Drawing.Point(100, 121)
        Me.LbLockerNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbLockerNama.Name = "LbLockerNama"
        Me.LbLockerNama.Size = New System.Drawing.Size(205, 26)
        Me.LbLockerNama.TabIndex = 42
        Me.LbLockerNama.Text = "Locker Name????"
        '
        'LbNamaLocker
        '
        Me.LbNamaLocker.AutoSize = True
        Me.LbNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNamaLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbNamaLocker.Location = New System.Drawing.Point(28, 41)
        Me.LbNamaLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNamaLocker.Name = "LbNamaLocker"
        Me.LbNamaLocker.Size = New System.Drawing.Size(366, 20)
        Me.LbNamaLocker.TabIndex = 41
        Me.LbNamaLocker.Text = "Are You Sure Want To Remove This Locker?"
        '
        'Delete_Locker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 283)
        Me.Controls.Add(Me.BtnCancelRemove)
        Me.Controls.Add(Me.BtnRemoveLocker)
        Me.Controls.Add(Me.LbLockerNama)
        Me.Controls.Add(Me.LbNamaLocker)
        Me.Name = "Delete_Locker"
        Me.Text = "Delete_Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelRemove As Button
    Friend WithEvents BtnRemoveLocker As Button
    Friend WithEvents LbLockerNama As Label
    Friend WithEvents LbNamaLocker As Label
End Class
