Public Class Movie
    Private _movieID As Integer
    Private _title As String
    Private _description As String
    Private _movieType As String
    Private _available As Boolean

    ' Constructor
    Public Sub New(movieID As Integer, title As String, description As String, movieType As String, available As Boolean)
        _movieID = movieID
        _title = title
        _description = description
        _movieType = movieType
        _available = available
    End Sub

    ' Properties
    Public Property MovieID As Integer
        Get
            Return _movieID
        End Get
        Set(value As Integer)
            _movieID = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property MovieType As String
        Get
            Return _movieType
        End Get
        Set(value As String)
            _movieType = value
        End Set
    End Property

    Public Property Available As Boolean
        Get
            Return _available
        End Get
        Set(value As Boolean)
            _available = value
        End Set
    End Property
End Class
