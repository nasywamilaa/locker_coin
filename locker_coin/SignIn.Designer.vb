<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.LbSignInAdmin = New System.Windows.Forms.Label()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.BtnSignIn = New System.Windows.Forms.Button()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbSignInAdmin
        '
        Me.LbSignInAdmin.AutoSize = True
        Me.LbSignInAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSignInAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LbSignInAdmin.Location = New System.Drawing.Point(187, 331)
        Me.LbSignInAdmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbSignInAdmin.Name = "LbSignInAdmin"
        Me.LbSignInAdmin.Size = New System.Drawing.Size(114, 17)
        Me.LbSignInAdmin.TabIndex = 37
        Me.LbSignInAdmin.Text = "Sign In As Admin"
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSignUp.Location = New System.Drawing.Point(112, 289)
        Me.BtnSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(78, 23)
        Me.BtnSignUp.TabIndex = 36
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'BtnSignIn
        '
        Me.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSignIn.Location = New System.Drawing.Point(112, 260)
        Me.BtnSignIn.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(78, 23)
        Me.BtnSignIn.TabIndex = 35
        Me.BtnSignIn.Text = "Sign In"
        Me.BtnSignIn.UseVisualStyleBackColor = False
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(51, 228)
        Me.TBPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(224, 20)
        Me.TBPassword.TabIndex = 34
        '
        'TBusername
        '
        Me.TBusername.Location = New System.Drawing.Point(51, 173)
        Me.TBusername.Margin = New System.Windows.Forms.Padding(2)
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(224, 20)
        Me.TBusername.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(47, 201)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.locker_coin.My.Resources.Resources.WhatsApp_Image_2022_01_02_at_11_04_20
        Me.PictureBox1.Location = New System.Drawing.Point(106, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(323, 376)
        Me.Controls.Add(Me.LbSignInAdmin)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.BtnSignIn)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SignIn"
        Me.Text = "SignIn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbSignInAdmin As Label
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents TBusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
