' Extends user functionality but with extra admin-specific methods

Public Class Admin
    Private username As String
    Private password As String

    ' Constructor
    Public Sub New(u As String, p As String)
        username = u
        password = p
    End Sub


    ' Method: viewUserActivity (PRIVATE)
    ' Reads and displays all registered users (admin-only)

    Private Sub viewUserActivity()
        Dim filePath As String = "users.txt"

        If File.Exists(filePath) Then
            Dim allLines() As String = File.ReadAllLines(filePath)
            For Each line As String In allLines
                Console.WriteLine(line) ' Display user details
            Next
        End If
    End Sub


    ' Method: UpdateUserDebt (PRIVATE)
    ' Placeholder: Could be linked with rentals

    Private Sub UpdateUserDebt()
        ' Code here to update debts in the text file or another file
    End Sub


    ' Method: viewUserAmntDue (PUBLIC)
    ' Placeholder: Could fetch debt amount for a given user

    Public Sub viewUserAmntDue()
        ' Example: read from debt file
        Console.WriteLine("This would show the amount a user owes.")
    End Sub


    ' Method: login (for Admin)
    ' Admin can log in using same users file or separate file

    Public Function login(u As String, p As String) As Boolean
        Dim filePath As String = "users.txt"

        If File.Exists(filePath) Then
            Dim allLines() As String = File.ReadAllLines(filePath)

            For Each line As String In allLines
                Dim parts() As String = line.Split(","c)
                If parts(0) = u AndAlso parts(1) = p Then
                    ' Extra rule: only allow login if email = "admin@system.com"
                    If parts(2).ToLower() = "admin@system.com" Then
                        Return True
                    End If
                End If
            Next
        End If

        Return False
    End Function
End Class
