<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Remove
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
        Me.LbNamaLocker = New System.Windows.Forms.Label()
        Me.LbLockerName = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbNamaLocker
        '
        Me.LbNamaLocker.AutoSize = True
        Me.LbNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNamaLocker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbNamaLocker.Location = New System.Drawing.Point(11, 35)
        Me.LbNamaLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNamaLocker.Name = "LbNamaLocker"
        Me.LbNamaLocker.Size = New System.Drawing.Size(346, 18)
        Me.LbNamaLocker.TabIndex = 20
        Me.LbNamaLocker.Text = "Are You Sure Want To Remove This Locker?"
        '
        'LbLockerName
        '
        Me.LbLockerName.AutoSize = True
        Me.LbLockerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLockerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbLockerName.Location = New System.Drawing.Point(83, 115)
        Me.LbLockerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbLockerName.Name = "LbLockerName"
        Me.LbLockerName.Size = New System.Drawing.Size(202, 25)
        Me.LbLockerName.TabIndex = 26
        Me.LbLockerName.Text = "Locker Name????"
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRemove.Location = New System.Drawing.Point(76, 193)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(209, 23)
        Me.BtnRemove.TabIndex = 27
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancel.Location = New System.Drawing.Point(76, 232)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(209, 23)
        Me.BtnCancel.TabIndex = 28
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Form_Remove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 310)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LbLockerName)
        Me.Controls.Add(Me.LbNamaLocker)
        Me.ForeColor = System.Drawing.Color.Chocolate
        Me.Name = "Form_Remove"
        Me.Text = "Form_Remove"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNamaLocker As Label
    Friend WithEvents LbLockerName As Label
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnCancel As Button
End Class
