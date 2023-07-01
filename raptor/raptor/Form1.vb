Public Class Form1
    Dim stay_loggedin As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.stay_logged_in = False Then
            My.Settings.Logged_in = False
            My.Settings.Save()
        End If
        LoginForm1.ShowDialog()
        If My.Settings.Logged_in = False Then
            Me.Close()
        ElseIf My.Settings.Logged_in = True Then
            Threading.Thread.Sleep(1000)
        End If
        ProgressBar1.Visible = False
        MsgBox("press OK Label to show progress bar")
    End Sub
    Private Sub Button1Click(Sender As Object, e As EventArgs) Handles Button1.Click
        SetLoginForm.ShowDialog()
    End Sub
    Private Sub Button2Click(Sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.user_name = My.Settings.deafult_name And My.Settings.password = My.Settings.deafult_password Then
            MsgBox("You need to change the password.", MsgBoxStyle.Critical, "Information")
            SetLoginForm.ShowDialog()
        Else
            Label1.Visible = False
            ProgressBar1.Value = 30
            Threading.Thread.Sleep(1000)
            ProgressBar1.Value = 50
            Threading.Thread.Sleep(1000)
            ProgressBar1.Value = 90
            Threading.Thread.Sleep(1000)
            ProgressBar1.Value = 99
            Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 100
            Threading.Thread.Sleep(1000)
            Label1.Visible = True
            ProgressBar1.Value = 0
            'Form2.Show
        End If
    End Sub
    Private Sub Button3Click(Sender As Object, e As EventArgs) Handles Button3.Click
        If My.Settings.user_name = My.Settings.deafult_name And My.Settings.password = My.Settings.deafult_password Then
            MsgBox("You need to change the password.", MsgBoxStyle.Critical, "Information")
            SetLoginForm.ShowDialog()
        Else
            Label1.Visible = False
            ProgressBar1.Value = 30
            Threading.Thread.Sleep(1000)
            ProgressBar1.Value = 50
            Threading.Thread.Sleep(1000)
            ProgressBar1.Value = 90
            Threading.Thread.Sleep(1000)
            ProgressBar1.Value = 99
            Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 100
            Threading.Thread.Sleep(1000)
            Label1.Visible = True
            ProgressBar1.Value = 0
            If My.Settings.stay_logged_in = True Then
                My.Settings.stay_logged_in = False
                MsgBox("Stay logged in is set to FALSE")
            ElseIf My.Settings.stay_logged_in = False Then
                My.Settings.stay_logged_in = True
                MsgBox("Stay logged in is set to TRUE")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.user_name = My.Settings.deafult_name And My.Settings.password = My.Settings.deafult_password Then
            MsgBox("You need to change the password.", MsgBoxStyle.Critical, "Information")
            SetLoginForm.ShowDialog()
        Else
            AboutBox1.ShowDialog()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If ProgressBar1.Visible = True Then
            ProgressBar1.Visible = False
        Else
            ProgressBar1.Visible = True
        End If
    End Sub
End Class