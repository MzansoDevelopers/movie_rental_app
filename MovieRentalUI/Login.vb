Imports System.data.sqlclient

Public Class Login

Private connString As String = "Data Source=localhost;Initial Catalog=MovieRentalDB;Integrated Security=True"
Private connection As SqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'CREATE A LOGIN PAGE 
      Dim username As String = txtEmail.text.trim()
    Dim password As String = txtPassword.text.trim()

       if txtPassword.text ="" Then
       MessageBox.show("Please enter password")
       else if txtEmail.text="" Then
       MessageBox.show("Please enter email")
       else if checklogin(username,password) then
            MessageBox.show("Login Successful") 
            Dim mainform As New MainForm
            mainform.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong UserName or Password")
            txtEmail.Clear()
            txtPassword.Clear()
            txtEmail.Focus()
            
            
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Do want to exit?", "EXIT", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class
