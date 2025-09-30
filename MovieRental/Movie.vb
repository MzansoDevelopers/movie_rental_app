Imports Microsoft.VisualBasic

Public Class Movie
    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    Private _genre As String
    Public Property Genre() As String
        Get
            Return _genre
        End Get
        Set(ByVal value As String)
            _genre = value
        End Set
    End Property
    Private _releaseYear As Integer
    Public Property ReleaseYear() As Integer
        Get
            Return _releaseYear
        End Get
        Set(ByVal value As Integer)
            _releaseYear = value
        End Set
    End Property
    Private _rating As String
    Public Property Rating() As String
        Get
            Return _rating
        End Get
        Set(ByVal value As String)
            _rating = value
        End Set
    End Property
    Private _availabilityStatus As Boolean
    Public Property AvailabilityStatus() As Boolean
        Get
            Return _availabilityStatus
        End Get
        Set(ByVal value As Boolean)
            _availabilityStatus = value
        End Set
    End Property
    Private _rentalPrice As Decimal
    Public Property RentalPrice() As Decimal
        Get
            Return _rentalPrice
        End Get
        Set(ByVal value As Decimal)
            _rentalPrice = value
        End Set
    End Property
    ' Constructor to initialize a movie object with all properties.
    Public Sub New(title As String, genre As String, releaseYear As Integer, rating As String, availabilityStatus As Boolean, rentalPrice As Decimal)
        _title = title
        _genre = genre
        _releaseYear = releaseYear
        _rating = rating
        _availabilityStatus = availabilityStatus
        _rentalPrice = rentalPrice
    End Sub
    ' Method to display movie details.
    Public Function DisplayMovieDetails() As String
        Return $"Title: {_title}, Genre: {_genre}, Release Year: {_releaseYear}, Rating: {_rating}, Available: {_availabilityStatus}, Rental Price: {_rentalPrice:C}"
    End Function

End Class
