Public Class SignIn
<<<<<<< HEAD

    Public Shared Form_Sewa As Form_Sewa
=======
    Public Shared Sewa As Sewa
>>>>>>> mfahrul-zy
    Public Shared User As User

    Public Sub New()

        User = New User()
<<<<<<< HEAD
        Form_Sewa = New Form_Sewa()
=======
        Sewa = New Sewa()
>>>>>>> mfahrul-zy
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim plainUsername As String = TBusername.Text
        Dim plainPassword As String = TBPassword.Text
<<<<<<< HEAD
        'Dim Encrypted As String = Users.EncryptedData(plainPassword)
        'MessageBox.Show(encrypted)
=======
>>>>>>> mfahrul-zy

        Dim data_user As List(Of String) = User.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            User.realUsernameProperty = data_user(1)
<<<<<<< HEAD
            Form_Sewa.Show()
            Me.Hide()
        Else
            
=======
            Sewa.Show()
            Me.Hide()
        Else

>>>>>>> mfahrul-zy
        End If
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim sign_up = New SignUp()
        sign_up.Show()
    End Sub
<<<<<<< HEAD
=======

    Private Sub LbSignInAdmin_Click(sender As Object, e As EventArgs) Handles LbSignInAdmin.Click
        Dim menu_admin = New Menu_Admin()
        menu_admin.Show()

    End Sub
>>>>>>> mfahrul-zy
End Class