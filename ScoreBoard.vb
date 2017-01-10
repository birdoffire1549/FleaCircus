Public Class frmScoreBoard
    Public Sub ScoreBoard_Load(bellRings As Integer)
        Application.DoEvents()

        Dim sqlTopEmptyCells = "SELECT TOP 5 * FROM FLEA_CIRCUS..STATS WHERE BELL_RINGS = " & bellRings & " ORDER BY EMPTY_CELLS DESC, INSERT_DT DESC;"
        Dim sqlTopFilledCells = "SELECT TOP 5 * FROM FLEA_CIRCUS..STATS WHERE BELL_RINGS = " & bellRings & " ORDER BY FILLED_CELLS DESC, INSERT_DT DESC;"
        Dim sqlTopMaxFleasInCell = "SELECT TOP 5 * FROM FLEA_CIRCUS..STATS WHERE BELL_RINGS = " & bellRings & " ORDER BY MAX_FIC DESC, INSERT_DT DESC;"
        Dim sqlTopAverageFleasPerCell = "SELECT TOP 5 * FROM FLEA_CIRCUS..STATS WHERE BELL_RINGS = " & bellRings & " ORDER BY AVERAGE_FPC DESC, INSERT_DT DESC;"
        Dim sqlTopFurthestDistance = "SELECT TOP 5 * FROM FLEA_CIRCUS..STATS WHERE BELL_RINGS = " & bellRings & " ORDER BY FURTHEST_DISTANCE DESC, INSERT_DT DESC;"
        Dim sqlTopLeastDistance = "SELECT TOP 5 * FROM FLEA_CIRCUS..STATS WHERE BELL_RINGS = " & bellRings & " ORDER BY LEAST_DISTANCE ASC, INSERT_DT DESC;"

        Dim connString = My.Settings.dbConnString

        Dim connDb As New ADODB.Connection
        connDb.ConnectionString = connString

        Dim rSet As ADODB.Recordset

        Try
            connDb.Open()
            'Top Empty Cells
            rSet = New ADODB.Recordset
            rSet.Open(sqlTopEmptyCells, connDb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            With rSet
                If Not (.BOF And .EOF) Then
                    .MoveFirst()
                    Do While Not .EOF
                        lstEmpty.Items.Add(.Fields.Item("INSERT_DT").Value & "  -  " & .Fields.Item("GRID_NAME").Value & ":    " & .Fields.Item("EMPTY_CELLS").Value)
                        .MoveNext()
                    Loop
                End If
            End With
            rSet.Close()
            rSet = Nothing

            'Top Filled Cells
            rSet = New ADODB.Recordset
            rSet.Open(sqlTopFilledCells, connDb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            With rSet
                If Not (.BOF And .EOF) Then
                    .MoveFirst()
                    Do While Not .EOF
                        lstFilled.Items.Add(.Fields.Item("INSERT_DT").Value & "  -  " & .Fields.Item("GRID_NAME").Value & ":    " & .Fields.Item("Filled_CELLS").Value)
                        .MoveNext()
                    Loop
                End If
            End With
            rSet.Close()
            rSet = Nothing

            'Max Fleas in a cell
            rSet = New ADODB.Recordset
            rSet.Open(sqlTopMaxFleasInCell, connDb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            With rSet
                If Not (.BOF And .EOF) Then
                    .MoveFirst()
                    Do While Not .EOF
                        lstMax.Items.Add(.Fields.Item("INSERT_DT").Value & "  -  " & .Fields.Item("GRID_NAME").Value & ":    " & .Fields.Item("MAX_FIC").Value)
                        .MoveNext()
                    Loop
                End If
            End With
            rSet.Close()
            rSet = Nothing

            'Average Fleas in a cell
            rSet = New ADODB.Recordset
            rSet.Open(sqlTopAverageFleasPerCell, connDb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            With rSet
                If Not (.BOF And .EOF) Then
                    .MoveFirst()
                    Do While Not .EOF
                        lstAverage.Items.Add(.Fields.Item("INSERT_DT").Value & "  -  " & .Fields.Item("GRID_NAME").Value & ":    " & .Fields.Item("AVERAGE_FPC").Value)
                        .MoveNext()
                    Loop
                End If
            End With
            rSet.Close()
            rSet = Nothing

            'Furthest Distance
            rSet = New ADODB.Recordset
            rSet.Open(sqlTopFurthestDistance, connDb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            With rSet
                If Not (.BOF And .EOF) Then
                    .MoveFirst()
                    Do While Not .EOF
                        lstFurthest.Items.Add(.Fields.Item("INSERT_DT").Value & "  -  " & .Fields.Item("GRID_NAME").Value & ":    " & .Fields.Item("FURTHEST_DISTANCE").Value)
                        .MoveNext()
                    Loop
                End If
            End With
            rSet.Close()
            rSet = Nothing

            'Least Distance
            rSet = New ADODB.Recordset
            rSet.Open(sqlTopLeastDistance, connDb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            With rSet
                If Not (.BOF And .EOF) Then
                    .MoveFirst()
                    Do While Not .EOF
                        lstLeast.Items.Add(.Fields.Item("INSERT_DT").Value & "  -  " & .Fields.Item("GRID_NAME").Value & ":    " & .Fields.Item("LEAST_DISTANCE").Value)
                        .MoveNext()
                    Loop
                End If
            End With
            rSet.Close()
            rSet = Nothing

        Catch ex As Exception
            MessageBox.Show("ERROR: Unable to pull stats from the database at this time.")
            Me.Close()
        End Try

        Try
            connDb.Close()
        Catch ex As Exception
            'Do nothing
        End Try

        connDb = Nothing
    End Sub

    Private Sub frmScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class