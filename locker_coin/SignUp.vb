Public Class SignUp


    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        If TBUsername.Text.Length > 0 And TBPassword.Text.Length > 0 And TBEmail.Text.Length > 0 Then


            'Login.Users.realusernameProperty = TextBox1.Text.ToString()
            'Login.Users.realPasswordProperty = TextBox2.Text.ToString()

            'Login.Users.addDataUsers(TextBox1.Text.ToString(), TextBox2.Text.ToString())
            SignIn.User.AddUsersDatabase(TBUsername.Text, TBPassword.Text, TBEmail.Text)
            Me.Close()
        Else
            MessageBox.Show("Please Fill In The Form")
        End If
    End Sub
End Class