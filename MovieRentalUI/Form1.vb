Imports System.Windows.Forms

Public Class Form1
	Private users As New Users()

	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		Dim username As String = txtEmail.Text.Trim()
		Dim password As String = txtPassword.Text.Trim()

		If password = "" Then
			MessageBox.Show("Please enter password")
		ElseIf username = "" Then
			MessageBox.Show("Please enter email")
		ElseIf CheckLogin(username, password) Then
			MessageBox.Show("Login Successful")
			Dim mainform As New MainForm()
			mainform.Show()
			Me.Hide()
		Else
			MessageBox.Show("Wrong UserName or Password")
			txtEmail.Clear()
			txtPassword.Clear()
		End If
	End Sub

	' Checks login credentials using the Users class
	Private Function CheckLogin(username As String, password As String) As Boolean
		For Each user As User In users.GetAllUsers()
			If user IsNot Nothing AndAlso user.Email = username AndAlso user.Password = password Then
				Return True
			End If
		Next
		Return False
	End Function
End Class
