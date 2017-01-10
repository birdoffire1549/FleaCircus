Public Class frmGridView
    Public myGridControl As GridControl
    Public fleaTracker As New FleaTracker

    Private Sub resetForm()
        'Reset form objects that need resetted
        txtBellRings.Text = ""

        pctFleaJumping.Enabled = False
        prgSimmProgress.Value = 0
    End Sub

    Private Sub frmGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the Select Flea Combo
        For i As Integer = 1 To (900)
            Me.cboSelectFlea.Items.Add("Flea " & i)
        Next
        'Create a GridControl object for this form
        myGridControl = New GridControl(Me)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset everything to it's initial settings
        cboSelectFlea.Text = ""
        lblTracking.Enabled = False
        cboSelectFlea.Enabled = False
        btnReplayMovement.Enabled = False
        btnSaveAndView.Enabled = False

        myGridControl.reset()
        txtBellRings.Focus()
        txtBellRings.SelectAll()
    End Sub

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        btnBegin.Enabled = False
        btnReset.Enabled = False
        btnSaveAndView.Enabled = False

        cboSelectFlea.Text = ""
        lblTracking.Enabled = False
        cboSelectFlea.Enabled = False
        btnReplayMovement.Enabled = False

        If (Not isValidBellRings(txtBellRings.Text)) Then
            MessageBox.Show("The number of bell rings you entered was invalid! Must be an integer from 1 to 100,000.")
        Else
            myGridControl.reset()
            myGridControl.Simmulator(Val(txtBellRings.Text))
            txtBellRings.Focus()
            txtBellRings.SelectAll()
        End If

        lblTracking.Enabled = True
        cboSelectFlea.Enabled = True
        Dim parent As frmMain = Me.ParentForm
        If parent.dbConnected Then
            btnSaveAndView.Enabled = True
        End If

        btnBegin.Enabled = True
        btnReset.Enabled = True
    End Sub

    Private Sub txtBellRings_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBellRings.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnBegin_Click(txtBellRings, e)
        End If
    End Sub

    Private Sub cboSelectFlea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectFlea.SelectedIndexChanged
        Dim flea As Flea = fleaTracker.getFlea(cboSelectFlea.SelectedIndex)
        myGridControl.showFlea(flea)
        btnReplayMovement.Enabled = True
    End Sub

    Private Sub btnReplayMovement_Click(sender As Object, e As EventArgs) Handles btnReplayMovement.Click
        btnBegin.Enabled = False
        btnReset.Enabled = False
        cboSelectFlea.Enabled = False
        Dim currentState = btnSaveAndView.Enabled
        btnSaveAndView.Enabled = False

        btnReplayMovement.Enabled = False
        Dim flea As Flea = fleaTracker.getFlea(cboSelectFlea.SelectedIndex)
        myGridControl.replayFlea(flea)

        btnBegin.Enabled = True
        btnReset.Enabled = True
        cboSelectFlea.Enabled = True
        btnSaveAndView.Enabled = currentState
    End Sub

    Private Sub btnSaveAndView_Click(sender As Object, e As EventArgs) Handles btnSaveAndView.Click
        btnSaveAndView.Enabled = False
        Dim frmConn As frmConnecting = New frmConnecting
        frmConn.Show(Me)
        frmConn.prgProgress.Maximum = 4

        frmConn.prgProgress.Value = 1
        Application.DoEvents()

        Dim connString = My.Settings.dbConnString
        Dim sqlStatement As String = "INSERT INTO STATS (GRID_NAME, BELL_RINGS, EMPTY_CELLS, FILLED_CELLS, MAX_FIC, AVERAGE_FPC, FURTHEST_DISTANCE, LEAST_DISTANCE) " & _
                                     "VALUES (" & _
                                                "'" & Me.myGridControl.name & "'," & _
                                                Me.myGridControl.bellRingCount & "," & _
                                                Me.myGridControl.emptyCellCount & "," & _
                                                Me.myGridControl.filledCellCount & "," & _
                                                Me.myGridControl.maxFleasInCell & "," & _
                                                Me.myGridControl.avgFleasInCell & "," & _
                                                Me.myGridControl.furthestDistance & "," & _
                                                Me.myGridControl.leastDistance & _
                                     ")"
        Dim connDb As New ADODB.Connection
        connDb.ConnectionString = connString

        frmConn.prgProgress.Value = 2
        System.Threading.Thread.Sleep(1000)

        Try
            connDb.Open()

            frmConn.prgProgress.Value = 3
            connDb.Execute(sqlStatement)
            System.Threading.Thread.Sleep(1000)
            frmConn.prgProgress.Value = 4
            frmConn.Close()
            frmScoreBoard.MdiParent = Me.ParentForm
            frmScoreBoard.Show()
            frmScoreBoard.ScoreBoard_Load(myGridControl.bellRingCount)
        Catch ex As Exception
            frmConn.Close()
            MessageBox.Show("ERROR: unable to connect the database!")
        End Try

        Try
            connDb.Close()
        Catch ex As Exception
            'Do nothing...
        End Try

        connDb = Nothing
        frmConn.Close()
        frmConn = Nothing
    End Sub
End Class