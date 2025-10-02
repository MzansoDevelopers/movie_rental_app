Public Class Admin
    Private _adminID As Integer
    Private _name As String
    Private _surname As String
    Private _contacts As String
    Private _email As String

    ' Constructor
    Public Sub New(adminID As Integer, name As String, surname As String, contacts As String, email As String)
        _adminID = adminID
        _name = name
        _surname = surname
        _contacts = contacts
        _email = email
    End Sub

    ' Properties
    Public Property AdminID As Integer
        Get
            Return _adminID
        End Get
        Set(value As Integer)
            _adminID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Surname As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Property Contacts As String
        Get
            Return _contacts
        End Get
        Set(value As String)
            _contacts = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    '  manage movies
    Public Sub AddMovie(movie As Movie)
        'code to insert movie into database when database is ready
        Console.WriteLine("Movie added by Admin: " & movie.Title)
    End Sub

   
    ' Reads and displays all registered users (admin-only) on text file later on database
    Private Sub viewUserActivity()
        Dim filePath As String = "users.txt"

        If File.Exists(filePath) Then
            Dim allLines() As String = File.ReadAllLines(filePath)
            For Each line As String In allLines
                Console.WriteLine(line) ' Displaying user details note admin site only
            Next
        End If
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
                    ' Extra rule: only allow login if email = "admin@gmail.com"
                    If parts(2).ToLower() = "admin@gmail.com" Then
                        Return True
                    End If
                End If
            Next
        End If

        Return False
    End Function
End Class
