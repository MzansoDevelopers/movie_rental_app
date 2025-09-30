Public Class Login
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SignUpLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLink.LinkClicked
        'link to sign up form
        Dim signup As New SignUp
        signup.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'This is to make sure the user enters both username and password
        Dim emailEmpty As Boolean = String.IsNullOrWhiteSpace(txtEmailAddress.Text)
        Dim passwordEmpty As Boolean = String.IsNullOrWhiteSpace(txtPassword.Text)

        If emailEmpty AndAlso passwordEmpty Then
            MessageBox.Show("Please enter both your email address and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf emailEmpty Then
            MessageBox.Show("Please enter your email address.", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf passwordEmpty Then
            MessageBox.Show("Please enter your password.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Proceed with login logic if all fields are filled
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

End Class