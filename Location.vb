Public Class Location
    Private xLocation As Integer
    Private yLocation As Integer

    Property x() As Integer
        Get
            Return xLocation
        End Get
        Set(value As Integer)
            xLocation = value
        End Set
    End Property

    Property y() As Integer
        Get
            Return yLocation
        End Get
        Set(value As Integer)
            yLocation = value
        End Set
    End Property
End Class
