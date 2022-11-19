Public Class NetToolsView
    Private Sub NetToolsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub NetDisableBtn_Click(sender As Object, e As EventArgs) Handles NetDisableBtn.Click
        Shell("ipconfig /release")
    End Sub
    Private Sub FlushDnsBtn_Click(sender As Object, e As EventArgs) Handles FlushDnsBtn.Click
        Shell("ipconfig /flushdns")
    End Sub
    Private Sub NetEnableBtn_Click(sender As Object, e As EventArgs) Handles NetEnableBtn.Click
        Shell("ipconfig /renew")
    End Sub
    Private Sub btnPacketLossTester_Click(sender As Object, e As EventArgs) Handles btnPacketLossTester.Click
        Process.Start("bin/packetlosstester.bat")
    End Sub

End Class