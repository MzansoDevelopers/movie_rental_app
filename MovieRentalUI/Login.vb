Public Class Login
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SignUpLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLink.LinkClicked
        'link to sign up form
        Dim signup As New SignUp
        signup.Show()

        Me.Hide() 'Hide the current form.

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'This is to make sure the user enters both username and password
        Dim emailEmpty As Boolean = String.IsNullOrWhiteSpace(txtEmail.Text)
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

    Private Sub pbHidePassword_Click(sender As Object, e As EventArgs) Handles pbHidePassword.Click
        pbHidePassword.Hide()
        pbShowPassword.Show()
        txtPassword.UseSystemPasswordChar = False
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbShowPassword.Click
        pbShowPassword.Hide()
        pbHidePassword.Show()
        txtPassword.UseSystemPasswordChar = True


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    ' This function validates the email format and provides visual feedback
    Private Sub ValidateEmail()
        Dim emailText As String = txtEmail.Text

        If emailText.Contains("@") AndAlso emailText.Contains(".") Then
            txtEmail.BackColor = Color.LightGreen
            lblEmailStatus.Text = "Valid email ✅"
            btnLogin.Enabled = True
        Else
            txtEmail.BackColor = Color.LightCoral
            lblEmailStatus.Text = "Invalid email ❌"
            btnLogin.Enabled = False
        End If

        ' Reset the color when the field is empty
        If emailText = "" Then txtEmail.BackColor = SystemColors.Window

    End Sub

    ' Event handler for text changed event to validate email in real-time
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidateEmail()

    End Sub
End Class
