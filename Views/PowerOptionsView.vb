Public Class PowerOptionsView
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ShutdownBtn_Click(sender As Object, e As EventArgs) Handles ShutdownBtn.Click
        Process.Start("bin/pcshutdown.bat")
    End Sub

    Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        Process.Start("bin/pcrestart.bat")
    End Sub

    Private Sub AbortBtn_Click(sender As Object, e As EventArgs) Handles AbortBtn.Click
        Process.Start("bin/pcabortpowertask.bat")
    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Want To Logoff your PC?", "Logoff Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Shell("logoff")
        End If
    End Sub
End Class