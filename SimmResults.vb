Public Class SimmResults
    Private emptyCells As Integer
    Private fullCells As Integer
    Private maxFleas As Integer
    Private avgFleas As Decimal
    Private furthest As Integer
    Private least As Integer
    Private missing As Integer
    Private foreign As Integer

    Private associatedForm As frmGridView

    Public Sub New(ByRef gridForm As frmGridView)
        associatedForm = gridForm
    End Sub

    Public Sub reset()
        Me.emptyCellCount = 0
        Me.fullCellCount = 30 * 30
        Me.maxFleaCount = 1
        Me.avgFleaCount = 1
        Me.furthestDistance = 0
        Me.leastDistance = 0
    End Sub

    Property emptyCellCount() As Integer
        Get
            Return emptyCells
        End Get
        Set(value As Integer)
            emptyCells = value
            associatedForm.lblEmptyCells.Text = value
        End Set
    End Property

    Property fullCellCount() As Integer
        Get
            Return fullCells
        End Get
        Set(value As Integer)
            fullCells = value
            associatedForm.lblFilledCells.Text = value
        End Set
    End Property

    Property maxFleaCount() As Integer
        Get
            Return maxFleas
        End Get
        Set(value As Integer)
            maxFleas = value
            associatedForm.lblMaxFleas.Text = value
        End Set
    End Property

    Property avgFleaCount() As Decimal
        Get
            Return avgFleas
        End Get
        Set(value As Decimal)
            avgFleas = value
            associatedForm.lblAverageFleas.Text = value
        End Set
    End Property

    Property furthestDistance() As Integer
        Get
            Return furthest
        End Get
        Set(value As Integer)
            furthest = value
            associatedForm.lblFurthest.Text = value
        End Set
    End Property

    Property leastDistance() As Integer
        Get
            Return least
        End Get
        Set(value As Integer)
            least = value
            associatedForm.lblLeast.Text = value
        End Set
    End Property
End Class
