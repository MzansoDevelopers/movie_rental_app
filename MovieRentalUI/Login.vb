Public Class Login
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class