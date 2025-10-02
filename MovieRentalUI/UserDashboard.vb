Public Class UserDashboard
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Form navigation back to login form
        Dim loginForm As New Login
        loginForm.StartPosition = FormStartPosition.CenterScreen
        loginForm.Show()
        Me.Close()
    End Sub
End Class