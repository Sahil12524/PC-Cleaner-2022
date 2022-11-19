Public Class BasicToolsView
    Private Sub BasicToolsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TempRemoveBtn_Click(sender As Object, e As EventArgs) Handles TempRemoveBtn.Click
        Process.Start("bin/cleanscript.bat")
    End Sub

    Private Sub WindowsUpdateCacheBtn_Click(sender As Object, e As EventArgs) Handles WindowsUpdateCacheBtn.Click
        Process.Start("bin/WindowsUpdateCacheRemove.bat")
    End Sub

    Private Sub CheckDiskErrorBtn_Click(sender As Object, e As EventArgs) Handles CheckDiskErrorBtn.Click
        Process.Start("bin/CheckDiskError.bat")
    End Sub

    Private Sub SSDTrimBtn_Click(sender As Object, e As EventArgs) Handles SSDTrimBtn.Click
        Process.Start("bin/SSDOPTIMIZE.bat")
    End Sub

End Class