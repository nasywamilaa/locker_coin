<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remove
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.LbNamaLocker = New System.Windows.Forms.Label()
        Me.LbLockerName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancel.Location = New System.Drawing.Point(194, 342)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(314, 35)
        Me.BtnCancel.TabIndex = 43
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRemove.Location = New System.Drawing.Point(194, 282)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(314, 35)
        Me.BtnRemove.TabIndex = 42
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'LbNamaLocker
        '
        Me.LbNamaLocker.AutoSize = True
        Me.LbNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNamaLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbNamaLocker.Location = New System.Drawing.Point(75, 42)
        Me.LbNamaLocker.Name = "LbNamaLocker"
        Me.LbNamaLocker.Size = New System.Drawing.Size(598, 29)
        Me.LbNamaLocker.TabIndex = 41
        Me.LbNamaLocker.Text = "Are You Sure Want To Remove This Locker Type?"
        '
        'LbLockerName
        '
        Me.LbLockerName.AutoSize = True
        Me.LbLockerName.Font = New System.Drawing.Font("Geometr212 BkCn BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLockerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbLockerName.Location = New System.Drawing.Point(325, 162)
        Me.LbLockerName.Name = "LbLockerName"
        Me.LbLockerName.Size = New System.Drawing.Size(90, 30)
        Me.LbLockerName.TabIndex = 44
        Me.LbLockerName.Text = "Label1"
        '
        'Remove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(748, 414)
        Me.Controls.Add(Me.LbLockerName)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LbNamaLocker)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Remove"
        Me.Text = "Remove"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents LbNamaLocker As Label
    Friend WithEvents LbLockerName As Label
End Class
