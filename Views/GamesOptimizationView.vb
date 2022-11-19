Public Class GamesOptimizationView
    Private Sub GamesOptimizationView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DisableHpetBtn_Click(sender As Object, e As EventArgs) Handles DisableHpetBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Are Running This For First Time and Never Used This Button Before?", "Hpet Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Process.Start("bin/disablehpet.bat")
        End If
    End Sub

    Private Sub ISLCBtn_Click(sender As Object, e As EventArgs) Handles ISLCBtn.Click
        Process.Start("bin/ISLC v1.0.2.8/Intelligent standby list cleaner ISLC.exe")
    End Sub

    Private Sub btnScreenshotWayInstructions_Click(sender As Object, e As EventArgs) Handles btnScreenshotWayInstructions.Click
        MainPage.Hide()
        ssInstructions.Show()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnRestartDWM_Click(sender As Object, e As EventArgs) Handles btnRestartDWM.Click
        Process.Start("bin/restart_DWM.bat")
    End Sub
End Class