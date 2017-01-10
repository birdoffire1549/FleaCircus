Public Class FleaTracker
    Private fleaArray(899) As Flea

    Public Sub putFlea(ByRef flea As Flea)
        fleaArray(flea.getFleaId - 1) = flea
    End Sub

    Public Function getFlea(index As Integer) As Flea
        Return fleaArray(index)
    End Function
End Class
