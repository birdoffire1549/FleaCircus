Imports System.Math


Public Class GridControl
    Private simmResults As SimmResults
    Private gridName As String

    Private bellRing As Integer

    Private fleaGrid(30, 30) As Collection
    Private visualGrid(30, 30) As Label
    Private associatedForm As frmGridView

    ' /**
    '  * Class Constructor
    '  */
    Public Sub New(ByRef gridForm As frmGridView)
        associatedForm = gridForm
        simmResults = New SimmResults(gridForm)

        ' Intitial setup of visual grid on form
        Dim fleaCount = 0
        For y As Integer = 0 To 29
            For x As Integer = 0 To 29
                fleaCount += 1
                visualGrid(x, y) = New Label
                With visualGrid(x, y)
                    .Width = 20
                    .Height = 20
                    .Location = New Point((x * 21), (y * 21))
                    .BorderStyle = BorderStyle.FixedSingle
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Text = "*"
                    associatedForm.Controls.Add(visualGrid(x, y))
                    fleaGrid(x, y) = New Collection
                    Dim flea As Flea = New Flea(fleaCount, New Point(x, y))
                    associatedForm.fleaTracker.putFlea(flea)
                    fleaGrid(x, y).Add(flea)
                End With
            Next
        Next

        reset()
        Me.bellRingCount = 0
    End Sub

    Property name() As String
        Get
            Return gridName
        End Get
        Set(value As String)
            gridName = value
            associatedForm.Text = "Grid View: " & value
            associatedForm.lblViewingGrid.Text = value
        End Set
    End Property

    ReadOnly Property emptyCellCount() As Integer
        Get
            Return Me.simmResults.emptyCellCount
        End Get
    End Property

    ReadOnly Property filledCellCount() As Integer
        Get
            Return Me.simmResults.fullCellCount
        End Get
    End Property

    ReadOnly Property maxFleasInCell() As Integer
        Get
            Return Me.simmResults.maxFleaCount
        End Get
    End Property

    ReadOnly Property avgFleasInCell() As Integer
        Get
            Return Me.simmResults.avgFleaCount
        End Get
    End Property

    ReadOnly Property furthestDistance() As Integer
        Get
            Return Me.simmResults.furthestDistance
        End Get
    End Property

    ReadOnly Property leastDistance() As Integer
        Get
            Return Me.simmResults.leastDistance
        End Get
    End Property

    Property simmProgress() As Integer
        Get
            Return associatedForm.prgSimmProgress.Value
        End Get
        Set(value As Integer)
            associatedForm.prgSimmProgress.Value = value
        End Set
    End Property

    Property bellRingCount() As Integer
        Get
            Return bellRing
        End Get
        Set(value As Integer)
            bellRing = value
            If value = 0 Then
                associatedForm.txtBellRings.Text = ""
                associatedForm.prgSimmProgress.Maximum = 1
            Else
                associatedForm.prgSimmProgress.Maximum = value
            End If
        End Set
    End Property

    Property simmRunning() As Boolean
        Get
            Return associatedForm.pctFleaJumping.Enabled
        End Get
        Set(value As Boolean)
            associatedForm.pctFleaJumping.Enabled = value
        End Set
    End Property

    ' /* 
    '  * Resets the fleas to their initial places on the visual and number grid
    '  */
    Public Sub reset()
        Dim fleaCounter As Integer = 0
        For y As Integer = 0 To 29
            For x As Integer = 0 To 29
                fleaCounter += 1
                visualGrid(x, y).Text = "*"
                visualGrid(x, y).ForeColor = Color.Black
                fleaGrid(x, y).Clear()
                Dim flea As Flea = New Flea(fleaCounter, New Point(x, y))
                associatedForm.fleaTracker.putFlea(flea)
                fleaGrid(x, y).Add(flea)
            Next
        Next

        simmResults.reset()

        Me.simmProgress = 0
    End Sub

    Function randomVector() As Integer
        Randomize()
        Dim seedInt As Single = (1000 * Rnd(Rnd)) + 1

        Randomize()
        Dim choice As Integer = Int((2 * Rnd(seedInt)) + 1)

        Randomize()
        If choice = Int((2 * Rnd()) + 1) Then
            Return 1
        Else
            Return -1
        End If
    End Function

    ' /**
    '  * Simmulator runs the flea simmulation for the number of bell
    '  * rings given and updates the visualGrid as stats as needed
    '  */n
    Public Sub Simmulator(numberOfBellRings As Integer)
        Me.simmRunning = True

        Me.bellRingCount = numberOfBellRings
        Me.simmProgress = 0

        For rings As Integer = 1 To numberOfBellRings
            Dim tempGrid(30, 30) As Collection
            Me.simmProgress = Me.simmProgress + 1
            Application.DoEvents()

            For y As Integer = 0 To 29
                For x As Integer = 0 To 29
                    For Each flea As Flea In fleaGrid(x, y)
                        'determine flea's jump vector
                        Dim xyChoice As Integer = randomVector() ' Determine if vector is on x or y axis
                        Dim directionChoice As Integer = randomVector()

                        If xyChoice = 1 Then ' Jump will be vector on X-Axis
                            ' Correct jump vector to keep fleas on the grid
                            If x + directionChoice = 30 Or x + directionChoice = -1 Then
                                directionChoice = directionChoice * -1 'Reverses the direction of a bad jump
                            End If

                            Dim newX As Integer = x + directionChoice

                            ' Add new location to flea's history
                            flea.addLocation(New Point(newX, y))

                            ' Ensure collection is setup to receive flea for flea's new location
                            If tempGrid((newX), y) Is Nothing Then
                                tempGrid((newX), y) = New Collection
                            End If

                            ' Add flea to its new locaiton in the tempGrid
                            tempGrid(newX, y).Add(flea)
                        Else ' Jump will be vector on Y-Axis

                            ' Correct jump vector to keep flea on grid
                            If y + directionChoice = 30 Or y + directionChoice = -1 Then
                                directionChoice = directionChoice * -1
                            End If

                            Dim newY As Integer = y + directionChoice

                            ' Add new location to flea's history
                            flea.addLocation(New Point(x, newY))

                            ' Ensure collection is setup to receive flea for flea's new location
                            If tempGrid(x, newY) Is Nothing Then
                                tempGrid(x, newY) = New Collection
                            End If

                            ' Add flea to it's new location of the tempGrid
                            tempGrid(x, newY).Add(flea)
                        End If
                    Next
                Next
            Next

            Dim emptyCount As Integer = 0
            Dim filledCount As Integer = 0
            simmResults.avgFleaCount = 1

            Dim leastDistance As Integer = 0
            Dim firstFlea As Boolean = True

            ' Transfer contents of tempGrid to the primary grid
            For y As Integer = 0 To 29
                For x As Integer = 0 To 29

                    ' Ensure collection is setup to receive flea for flea's new location
                    If tempGrid(x, y) Is Nothing Then
                        tempGrid(x, y) = New Collection
                    End If

                    ' Make the transfer of the flea to primary grid
                    fleaGrid(x, y) = tempGrid(x, y)

                    Dim fleaCount = tempGrid(x, y).Count ' Gets the number of fleas currently in the cell

                    ' Write the appropriate content to the visualGrid based on the flea count for the current cell
                    If fleaCount = 0 Then
                        emptyCount += 1 ' Increment empty count since cell is empty
                        visualGrid(x, y).Text = "" ' Make cell empty to reflect that the flea count is zero
                    Else
                        ' Determine lest and greatest distance metrics
                        For Each flea As Flea In fleaGrid(x, y)
                            Dim originalPoint As Point = flea.locationHistory.Item(1)
                            Dim distance As Integer = (Abs(originalPoint.X - x) + Abs(originalPoint.Y - y))
                            If firstFlea Then
                                leastDistance = distance
                                firstFlea = False
                            ElseIf distance < leastDistance Then
                                leastDistance = distance
                            ElseIf distance > simmResults.furthestDistance Then
                                simmResults.furthestDistance = distance 'Flea broke record for furthest distance
                            End If
                        Next
                        '-------------------------------
                        If fleaCount = 1 Then
                            visualGrid(x, y).Text = "*" ' Show a single flea in the cell
                        Else
                            visualGrid(x, y).Text = fleaCount ' Show the number of fleas when count is greater than one
                        End If
                    End If

                    'Begin gathering simmulation stats
                    If fleaCount > 0 Then
                        filledCount += 1 ' Increment filled cell count because the cell contains at least one flea
                        simmResults.avgFleaCount = (900 / filledCount) ' Determine the average number of fleas per filled cell
                        If tempGrid(x, y).Count > simmResults.maxFleaCount Then
                            simmResults.maxFleaCount = tempGrid(x, y).Count ' New record for max number of fleas in a cell
                        End If
                    End If
                Next
            Next

            simmResults.leastDistance = leastDistance
            simmResults.emptyCellCount = emptyCount
            simmResults.fullCellCount = filledCount

        Next
        Me.simmRunning = False
    End Sub

    ' /**
    '  * Displays a flea on the grid in its original starting position.
    '  * ...used by the cboSelectFlea control to displat the selected 
    '  * flea on the grid in its initial starting position for replay.
    '  */
    Public Sub showFlea(ByRef flea As Flea)
        ' Store starting point for reference
        Dim originalPoint As Point = flea.locationHistory.Item(1)

        ' Cycle through grid clearing all cells and then place flea in appropriate cell
        For y As Integer = 0 To 29
            For x As Integer = 0 To 29
                If originalPoint.X = x And originalPoint.Y = y Then
                    ' Flea's location found so clear of former results and add flea to cell
                    fleaGrid(x, y).Clear()
                    fleaGrid(x, y).Add(flea)
                    visualGrid(x, y).Text = "*"
                Else
                    ' Not flea's location so just clear the location 
                    fleaGrid(x, y).Clear()
                    visualGrid(x, y).Text = ""
                End If
            Next
        Next
    End Sub

    ' /**
    '  * Replays the movement of a single flea on the associated grid
    '  * as was determinded by the last simmulation that was ran.
    '  */
    Public Sub replayFlea(ByRef flea As Flea)
        simmProgress = 0
        Dim lastPosition As Point = flea.locationHistory.Item(1)

        ' Step through each historical point one-by-one to replay movement
        For Each point As Point In flea.locationHistory
            fleaGrid(lastPosition.X, lastPosition.Y).Clear()
            visualGrid(lastPosition.X, lastPosition.Y).Text = ""
            Application.DoEvents() ' Allows the screen to update with grid change
            fleaGrid(point.X, point.Y).Add(flea)
            visualGrid(point.X, point.Y).Text = "*"
            lastPosition = point
            Application.DoEvents() ' Allows the screen to update with grid change
            Threading.Thread.Sleep(1000) ' Sleep for one second between each movement 
            If simmProgress + 1 <= bellRingCount Then
                simmProgress += 1 ' Increment progress meter
            End If
        Next
    End Sub
End Class
