Public Class frmMain
    Public dbConnected As Boolean = False

    Private Sub NewGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGridToolStripMenuItem.Click
        Dim gridName As String
        Dim newGridView As frmGridView

        gridName = InputBox("Enter a name for the new Grid:", "Grid Name", "")
        
        If gridName <> "" And Not gridName.Contains("'") And Not gridName.Contains("""") And Not gridName.Contains("%") And Not gridName.Contains(";") Then
            newGridView = New frmGridView
            newGridView.MdiParent = Me
            newGridView.Show()
            newGridView.myGridControl.name = gridName
        ElseIf gridName = "" Then
        Else
            MessageBox.Show("Invalid Input; Grid name contains an invalid character!")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutFleaCircus3000ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutFleaCircus3000ToolStripMenuItem.Click
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Thank You for Playing!")
        End
    End Sub

    Private Sub ConnectToServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItmConnect.Click
        Dim server = InputBox("Please enter the address of the Scoreboard Server:", "Connect to SQL Server...", My.Settings.dbServerName)

        If server <> "" Then
            Dim sqlConnString = "Provider=SQLNCLI11;" _
                              & "Server=" & server & "\SQLEXPRESS;" _
                              & "Database=FLEA_CIRCUS;" _
                              & "DataTypeCompatibility=80;" _
                              & "MARS Connection=True;" _
                              & "User Id=fleacircus;Password=fleacircus;"

            Dim connDb As New ADODB.Connection
            connDb.ConnectionString = sqlConnString
            Dim connectingForm As frmConnecting = New frmConnecting
            Try
                connectingForm.Show(Me)
                connectingForm.prgProgress.Maximum = 2
                connectingForm.prgProgress.Value = 1
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
                Application.DoEvents()

                connDb.Open()
                connectingForm.prgProgress.Value = 2
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
                connectingForm.Hide()
                connectingForm = Nothing

                MessageBox.Show("Connection Successful!")
                My.Settings.dbConnString = sqlConnString
                My.Settings.dbServerName = server
                Me.dbConnected = True
                mnuItmConnect.Enabled = False
                mnuItmDisconnect.Enabled = True

                connDb.Close()
            Catch ex As Exception
                Try
                    connectingForm.Hide()
                    connectingForm = Nothing
                Catch ignored As Exception
                    'Do nothing...
                End Try
                MessageBox.Show(ex.Message)
                MessageBox.Show("ERROR: Unable to connect to the database as entered! " & sqlConnString)
            End Try
            connDb = Nothing
        End If
    End Sub

    Private Sub mnuItmDisconnect_Click(sender As Object, e As EventArgs) Handles mnuItmDisconnect.Click
        Me.dbConnected = False
        mnuItmDisconnect.Enabled = False
        mnuItmConnect.Enabled = True
        MessageBox.Show("Disconnected from Database.")
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        frmHelp.ShowDialog(Me)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuMain.ItemClicked

    End Sub
End Class
