Public Class Rental
    Private _rentalID As Integer
    Private _user As User
    Private _movie As Movie
    Private _rentalDate As Date
    Private _returnDate As Date?
    Private _status As String
    Private _paymentStatus As String

    ' Constructor
    Public Sub New(rentalID As Integer, user As User, movie As Movie, rentalDate As Date, Optional returnDate As Date? = Nothing)
        _rentalID = rentalID
        _user = user
        _movie = movie
        _rentalDate = rentalDate
        _returnDate = returnDate
        _status = "Rented"
        _paymentStatus = "Pending"
    End Sub

    ' Properties
    Public Property RentalID As Integer
        Get
            Return _rentalID
        End Get
        Set(value As Integer)
            _rentalID = value
        End Set
    End Property

    Public Property User As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

    Public Property Movie As Movie
        Get
            Return _movie
        End Get
        Set(value As Movie)
            _movie = value
        End Set
    End Property

    Public Property RentalDate As Date
        Get
            Return _rentalDate
        End Get
        Set(value As Date)
            _rentalDate = value
        End Set
    End Property

    Public Property ReturnDate As Date?
        Get
            Return _returnDate
        End Get
        Set(value As Date?)
            _returnDate = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property PaymentStatus As String
        Get
            Return _paymentStatus
        End Get
        Set(value As String)
            _paymentStatus = value
        End Set
    End Property

    ' Example: return movie
    Public Sub ReturnMovie()
        _status = "Returned"
        _returnDate = Date.Now
    End Sub
End Class
