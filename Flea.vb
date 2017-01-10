Public Class Flea
    Private fleaId As Integer
    Private history As New Collection

    Public Sub New(id As Integer, startingLocation As Point)
        fleaId = id
        history.Add(startingLocation)
    End Sub

    Public Sub addLocation(location As Point)
        history.Add(location)
    End Sub

    ReadOnly Property locationHistory() As Collection
        Get
            Return history
        End Get
    End Property

    Public Function getFleaId() As Integer
        Return fleaId
    End Function
End Class
