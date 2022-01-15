<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKembali
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
        Me.DGVTakeOut = New System.Windows.Forms.DataGridView()
        CType(Me.DGVTakeOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnKembali.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKembali.Location = New System.Drawing.Point(503, 472)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(179, 35)
        Me.BtnKembali.TabIndex = 52
        Me.BtnKembali.Text = "Back"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'DGVTakeOut
        '
        Me.DGVTakeOut.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVTakeOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTakeOut.Location = New System.Drawing.Point(33, 38)
        Me.DGVTakeOut.Name = "DGVTakeOut"
        Me.DGVTakeOut.RowHeadersWidth = 62
        Me.DGVTakeOut.RowTemplate.Height = 28
        Me.DGVTakeOut.Size = New System.Drawing.Size(646, 422)
        Me.DGVTakeOut.TabIndex = 51
        '
        'DataKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(731, 544)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.DGVTakeOut)
        Me.Name = "DataKembali"
        Me.Text = "DataKembali"
        CType(Me.DGVTakeOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents DGVTakeOut As DataGridView
End Class
