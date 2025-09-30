Public Class User

    'Knox add variables
    'Nkosinathi add  con

    Public Sub New()

    Public Class User
        ' Private fields to store user data
        Private _username As String
        Private _password As String
        Private _email As String
        Private _phoneNumber As String
        Private _registerDate As Date

        ' Create account by storing user info
        Private Sub createAcc(username As String, password As String, email As String, phoneNumber As String, registerDate As Date)
            _username = username
            _password = password
            _email = email
            _phoneNumber = phoneNumber
            _registerDate = registerDate
        End Sub

        ' Save email and password to a text file note database not yet ready
        Public Sub SaveCredentialsToFile(filePath As String)
            Dim line As String = _email & "," & _password
            System.IO.File.AppendAllText(filePath, line & Environment.NewLine)
        End Sub

        ' Check if email and password exist in the text file
        Public Shared Function CheckCredentialsFromFile(email As String, password As String, filePath As String) As Boolean
            If Not System.IO.File.Exists(filePath) Then Return False
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)
            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                If parts.Length = 2 AndAlso parts(0) = email AndAlso parts(1) = password Then
                    Return True
                End If
            Next
            Return False
        End Function

        ' Update account info (example: update email and phone)
        Private Sub updateAcc(Optional email As String = Nothing, Optional phoneNumber As String = Nothing)
            If email IsNot Nothing Then
                _email = email
            End If
            If phoneNumber IsNot Nothing Then
                _phoneNumber = phoneNumber
            End If
        End Sub
    End Class
