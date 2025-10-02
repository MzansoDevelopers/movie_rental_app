Imports Microsoft.VisualBasic

Public Class RentalClass

    Private _rentalID As String
    Public Property RentalID() As String
        Get
            Return RentalID
        End Get
        Set(ByVal value As String)
            RentalID = value
        End Set
    End Property

    Private _moviesRented As String
    Public Property MoviesRented() As String
        Get
            Return MoviesRented
        End Get
        Set(ByVal value As String)
            MoviesRented = value
        End Set
    End Property

    Private _rentalStartDate As Date
    Public Property RentalStartDate() As Date
        Get
            Return RentalStartDate
        End Get
        Set(ByVal value As Date)
            RentalStartDate = value
        End Set
    End Property

    Private _rentalEndDate As Date
    Public Property RentalEndDate() As Date
        Get
            Return RentalEndDate
        End Get
        Set(ByVal value As Date)
            RentalEndDate = value
        End Set
    End Property

    Private _costOfRental As Decimal
    Public Property CostOfRental() As Decimal
        Get
            Return CostOfRental
        End Get
        Set(ByVal value As Decimal)
            CostOfRental = value
        End Set
    End Property

    Private _amountOfMoviesRented As Integer
    Public Property AmountOfMoviesRented() As Integer
        Get
            Return AmountOfMoviesRented
        End Get
        Set(ByVal value As Integer)
            AmountOfMoviesRented = value
        End Set
    End Property

    Private _numOfMoviesRented As Integer
    Public Property NumOfMoviesRented() As Integer
        Get
            Return _numOfMoviesRented
        End Get
        Set(ByVal value As Integer)
            _numOfMoviesRented = value
        End Set
    End Property

    Private _numWeeksOfRental As Integer
    Public Property NumWeeksOfRental() As Integer
        Get
            Return NumWeeksOfRental
        End Get
        Set(ByVal value As Integer)
            NumWeeksOfRental = value
        End Set
    End Property

    Public Sub New()
        ' Set each private field to the value passed in
        _rentalID = ""
        _moviesRented = ""
        _rentalStartDate = ""
        _rentalEndDate = ""
        _costOfRental = 0
        _amountOfMoviesRented = 0
        _numOfMoviesRented = 0
        _numWeeksOfRental = 0
    End Sub

    Public Sub New(ByVal rentalID As String, ByVal moviesRented As String, ByVal rentalStartDate As Date, ByVal rentalEndDate As Date, ByVal costOfRental As Decimal, ByVal amountOfMoviesRented As Integer, ByVal numOfMoviesRented As Integer, ByVal numWeeksOfRental As Integer)
        ' assigning parameters
        Me.RentalID = rentalID
        Me.MoviesRented = moviesRented
        Me.RentalStartDate = rentalStartDate
        Me.RentalEndDate = rentalEndDate
        Me.CostOfRental = costOfRental
        Me.AmountOfMoviesRented = amountOfMoviesRented
        Me._numOfMoviesRented = numOfMoviesRented
        Me.NumWeeksOfRental = numWeeksOfRental
    End Sub

    Public Function CalcAmountDue() As Decimal


        Dim totalDue As Decimal = 0
        Dim daysOverDue As Date
        Dim lateFee As Decimal
        Dim currentDate As DateTime.Now

        'We first check if the end of movie rental date has passed or what by subtracting rentalEndDate from currentDate?
        'If it has passed then then to the total that is suppose to be due we gonna add 10's, depending on how days have passed
        'If current date has not passed rental date then we won't add any fees
        If currentDate > _rentalEndDate Then
            daysOverDue = (currentDate - _rentalEndDate) 'We need to change this to days because we will be charging based on days.
            If daysOverDue > 0 Then
                lateFee = daysOverDue * 10
                totalDue = _costOfRental + lateFee
            Else
                totalDue = _costOfRental
            End If
        Else
            totalDue = _costOfRental
        End If
        Return totalDue
    End Function

    Public Function CalcNumMoviesRented() As Integer
        ' We return the value stored in movies rented
        Return _amountOfMoviesRented
    End Function

    Public Function CalcNumWeeks(ByVal startDate As Date, ByVal endDate As Date) As Integer
        ' here we want to get number of weeks hence each rental last for 5 weeks
        ' We get the difference between start date and the ending date
        Dim dateDifference As TimeSpan
        Dim totalDays As Integer

        dateDifference = endDate - startDate
        totalDays = dateDifference.Days  ' here we make the difference to be in days

        _numWeeksOfRental = totalDays \ 7 ' In a week there are 7 days, so we divide by it to get number of weeks and we return it at the end

        Return _numWeeksOfRental
    End Function


End Class
