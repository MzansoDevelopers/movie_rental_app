Public Class SignUp
    Private Sub LogInLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogInLink.LinkClicked

        Dim login As New Login
        login.Show()

        Me.Hide() 'Hide the current form


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
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
        Dim confirmEmpty As Boolean = String.IsNullOrWhiteSpace(txtConfirmPasswors.Text)

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
End Class