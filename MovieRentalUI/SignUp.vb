Public Class SignUp
    Private Sub LogInLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogInLink.LinkClicked

        Dim login As New Login
        login.Show()

        Me.Hide() 'Hide the current form


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub chkAgreementWithPolicies_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgreementWithPolicies.CheckedChanged

        If chkAgreementWithPolicies.Checked = False Then
            MessageBox.Show("You must agree to the terms of Movie Rentals before proceeding.", "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Proceed with sign-up logic
        MessageBox.Show("You Successfully agreed to the terms!", "Agreement", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Trim and check each field
        Dim firstNameEmpty As Boolean = String.IsNullOrWhiteSpace(txtFirstname.Text)
        Dim surnameEmpty As Boolean = String.IsNullOrWhiteSpace(txtSurname.Text)
        Dim emailEmpty As Boolean = String.IsNullOrWhiteSpace(txtEmail.Text)
        Dim passwordEmpty As Boolean = String.IsNullOrWhiteSpace(txtPassword.Text)
        Dim confirmEmpty As Boolean = String.IsNullOrWhiteSpace(txtConfirmPassword.Text)

        ' Check if any field is empty
        If firstNameEmpty OrElse surnameEmpty OrElse emailEmpty OrElse passwordEmpty OrElse confirmEmpty Then
            MessageBox.Show("Please fill in all required fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Form navigation back to login form
        Dim loginForm As New Login
        loginForm.StartPosition = FormStartPosition.CenterScreen
        loginForm.Show()
        Me.Close()

    End Sub
    Private Sub pbHidePassword_Click(sender As Object, e As EventArgs) Handles pbHidePassword.Click
        pbHidePassword.Hide()
        pbShowPassword.Show()
        txtPassword.UseSystemPasswordChar = False
    End Sub


    Private Sub pbShowPassword_Click(sender As Object, e As EventArgs) Handles pbShowPassword.Click

        pbShowPassword.Hide()
        pbHidePassword.Show()
        txtPassword.UseSystemPasswordChar = True

    End Sub


    Private Sub pbHideConfirmPassword_Click(sender As Object, e As EventArgs) Handles pbHideConfirmPassword.Click
        pbHideConfirmPassword.Hide()
        pbShowConfirmPassword.Show()
        txtConfirmPassword.UseSystemPasswordChar = False
    End Sub


    Private Sub pbShowConfirmPassword_Click(sender As Object, e As EventArgs) Handles pbShowConfirmPassword.Click

        pbHideConfirmPassword.Hide()
        pbHideConfirmPassword.Show()
        txtConfirmPassword.UseSystemPasswordChar = True


    End Sub
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    ' This function checks if Name and surname are long enough to be valid and provides visual feedback
    Private Sub ValidateNameFields()
        Dim firstNameValid As Boolean = txtFirstname.Text.Length > 2
        Dim surnameValid As Boolean = txtSurname.Text.Length > 2

        ' Visual feedback
        txtFirstname.BackColor = If(firstNameValid, Color.LightGreen, Color.LightCoral)
        txtSurname.BackColor = If(surnameValid, Color.LightGreen, Color.LightCoral)


        ' Enable SignUp only if all validations pass
        btnSignUp.Enabled = firstNameValid AndAlso surnameValid

        'Name status lable update
        lblNameStatus.Text = If(firstNameValid AndAlso surnameValid, "Name looks good ✅", "Name too short ❌")

        ' Reset the color when fields are empty
        If txtFirstname.Text = "" Then txtFirstname.BackColor = SystemColors.Window
    End Sub

    'Event handler for text changed event to validate Surname in real-time
    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        ValidateNameFields()
        UpdateSignUpButtonState()
    End Sub

    ' This function validates the email format and provides visual feedback
    Private Sub ValidateEmail()
        Dim emailText As String = txtEmail.Text

        If emailText.Contains("@") AndAlso emailText.Contains(".") Then
            txtEmail.BackColor = Color.LightGreen
            lblEmailStatus.Text = "Valid email ✅"
            btnSignUp.Enabled = True
        Else
            txtEmail.BackColor = Color.LightCoral
            lblEmailStatus.Text = "Invalid email ❌"
            btnSignUp.Enabled = False
        End If

        ' Reset the color when the field is empty
        If emailText = "" Then txtEmail.BackColor = SystemColors.Window

    End Sub

    ' Event handler for text changed event to validate email in real-time
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidateEmail()
        UpdateSignUpButtonState()
    End Sub

    ' This function validates if the passwords match and provides visual feedback
    Private Sub ValidatePasswords()
        Dim enteredPassword As String = txtPassword.Text
        Dim confirmedPassword As String = txtConfirmPassword.Text

        'This if statement changes the background color of the confirm password field based on whether the passwords match
        If enteredPassword = confirmedPassword Then
            txtConfirmPassword.BackColor = Color.LightGreen
        Else
            txtConfirmPassword.BackColor = Color.FromArgb(255, 128, 128)
        End If

        'This if statement reset the color when both fields are empty,
        If enteredPassword = "" And confirmedPassword = "" Then
            txtConfirmPassword.BackColor = SystemColors.Window
        End If

        ' This is for the label to show if passwords match or not
        lblPasswordStatus.Text = If(txtPassword.Text = txtConfirmPassword.Text, "Passwords match ✅", "Passwords do not match ❌")


    End Sub

    ' Event handlers() For text changed events To validate passwords In real-time
    Private Sub txtConfirmPasswors_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        ValidatePasswords()
        UpdateSignUpButtonState()

    End Sub

    'disable the signup button for every filed that's not met
    Private Sub UpdateSignUpButtonState()
        Dim firstNameValid As Boolean = txtFirstname.Text.Length > 2
        Dim surnameValid As Boolean = txtSurname.Text.Length > 2
        Dim emailValid As Boolean = txtEmail.Text.Contains("@") AndAlso txtEmail.Text.Contains(".")
        Dim passwordsMatch As Boolean = txtPassword.Text = txtConfirmPassword.Text

        btnSignUp.Enabled = firstNameValid AndAlso surnameValid AndAlso emailValid AndAlso passwordsMatch
    End Sub
End Class


