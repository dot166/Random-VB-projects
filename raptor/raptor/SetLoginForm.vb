Public Class SetLoginForm
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        My.Settings.user_name = UsernameTextBox.Text
        My.Settings.password = PasswordTextBox.Text
        My.Settings.Save()
        Me.Close()
    End Sub
End Class
