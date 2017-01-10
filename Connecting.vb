Public Class frmConnecting
    Private Sub frmConnecting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Set progressbar to maximum and pause breifly
        prgProgress.Value = prgProgress.Maximum
        Application.DoEvents()
        System.Threading.Thread.Sleep(500)
    End Sub

    Private Sub frmConnecting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prgProgress.Value = 0
    End Sub
End Class