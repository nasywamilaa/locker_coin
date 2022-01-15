<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeOut_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TakeOut_Form))
        Me.DGVRent = New System.Windows.Forms.DataGridView()
        Me.TBTime = New System.Windows.Forms.TextBox()
        Me.LBMinusPrice = New System.Windows.Forms.Label()
        Me.LBTotalPrice = New System.Windows.Forms.Label()
        Me.BtnTakeOut = New System.Windows.Forms.Button()
        Me.LBTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVRent
        '
        Me.DGVRent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRent.Location = New System.Drawing.Point(37, 202)
        Me.DGVRent.Name = "DGVRent"
        Me.DGVRent.RowHeadersWidth = 62
        Me.DGVRent.RowTemplate.Height = 28
        Me.DGVRent.Size = New System.Drawing.Size(733, 450)
        Me.DGVRent.TabIndex = 60
        '
        'TBTime
        '
        Me.TBTime.Location = New System.Drawing.Point(924, 213)
        Me.TBTime.Name = "TBTime"
        Me.TBTime.Size = New System.Drawing.Size(203, 26)
        Me.TBTime.TabIndex = 59
        '
        'LBMinusPrice
        '
        Me.LBMinusPrice.Font = New System.Drawing.Font("Geometr212 BkCn BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMinusPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LBMinusPrice.Location = New System.Drawing.Point(926, 271)
        Me.LBMinusPrice.Name = "LBMinusPrice"
        Me.LBMinusPrice.Size = New System.Drawing.Size(184, 40)
        Me.LBMinusPrice.TabIndex = 58
        '
        'LBTotalPrice
        '
        Me.LBTotalPrice.AutoSize = True
        Me.LBTotalPrice.Font = New System.Drawing.Font("Geometr212 BkCn BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LBTotalPrice.Location = New System.Drawing.Point(789, 271)
        Me.LBTotalPrice.Name = "LBTotalPrice"
        Me.LBTotalPrice.Size = New System.Drawing.Size(98, 40)
        Me.LBTotalPrice.TabIndex = 57
        Me.LBTotalPrice.Text = "Total"
        '
        'BtnTakeOut
        '
        Me.BtnTakeOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnTakeOut.Font = New System.Drawing.Font("Geometr212 BkCn BT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTakeOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTakeOut.Location = New System.Drawing.Point(795, 348)
        Me.BtnTakeOut.Name = "BtnTakeOut"
        Me.BtnTakeOut.Size = New System.Drawing.Size(332, 35)
        Me.BtnTakeOut.TabIndex = 56
        Me.BtnTakeOut.Text = "Take Out"
        Me.BtnTakeOut.UseVisualStyleBackColor = False
        '
        'LBTime
        '
        Me.LBTime.AutoSize = True
        Me.LBTime.Font = New System.Drawing.Font("Geometr212 BkCn BT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LBTime.Location = New System.Drawing.Point(789, 200)
        Me.LBTime.Name = "LBTime"
        Me.LBTime.Size = New System.Drawing.Size(95, 40)
        Me.LBTime.TabIndex = 55
        Me.LBTime.Text = "Time"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.locker_coin.My.Resources.Resources.LOCKIE
        Me.PictureBox1.Location = New System.Drawing.Point(37, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'TakeOut_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 679)
        Me.Controls.Add(Me.DGVRent)
        Me.Controls.Add(Me.TBTime)
        Me.Controls.Add(Me.LBMinusPrice)
        Me.Controls.Add(Me.LBTotalPrice)
        Me.Controls.Add(Me.BtnTakeOut)
        Me.Controls.Add(Me.LBTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TakeOut_Form"
        Me.Text = "TakeOut_Form"
        CType(Me.DGVRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVRent As DataGridView
    Friend WithEvents TBTime As TextBox
    Friend WithEvents LBMinusPrice As Label
    Friend WithEvents LBTotalPrice As Label
    Friend WithEvents BtnTakeOut As Button
    Friend WithEvents LBTime As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
