Public Class LoginForm1
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.user_name = My.Settings.deafult_name And My.Settings.password = My.Settings.deafult_password Then
            SetLoginForm.ShowDialog()
        End If
        If My.Settings.Logged_in = True Then
            Me.Close()
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = My.Settings.user_name And PasswordTextBox.Text = My.Settings.password Then
            My.Settings.Logged_in = True
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("Sorry, The Username or Password was incorrect.", MsgBoxStyle.Critical, "Information")
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
