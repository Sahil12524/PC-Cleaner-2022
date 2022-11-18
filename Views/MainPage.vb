Public Class MainPage

    'Dim rs As New Resizer

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'rs.FindAllControls(Me)
    'End Sub

    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize, MyBase.LocationChanged
    'rs.ResizeAllControls(Me)
    'End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Declare Function ShellExecute _
                            Lib "shell32.dll" _
                            Alias "ShellExecuteA" (
                            ByVal hwnd As Long,
                            ByVal lpOperation As String,
                            ByVal lpFile As String,
                            ByVal lpParameters As String,
                            ByVal lpDirectory As String,
                            ByVal nShowCmd As Long) _
                            As Long

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TempRemoveBtn.Click
        Process.Start("bin/cleanscript.bat")
    End Sub

    Private Sub WindowsUpdateCacheBtn_Click(sender As Object, e As EventArgs) Handles WindowsUpdateCacheBtn.Click
        Process.Start("bin/WindowsUpdateCacheRemove.bat")
    End Sub

    Private Sub SSDTrimBtn_Click(sender As Object, e As EventArgs) Handles SSDTrimBtn.Click
        Process.Start("bin/SSDOPTIMIZE.bat")
    End Sub

    Private Sub CheckDiskErrorBtn_Click(sender As Object, e As EventArgs) Handles CheckDiskErrorBtn.Click
        Process.Start("bin/CheckDiskError.bat")
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

    Private Sub btnDiskCleanup_Click(sender As Object, e As EventArgs) Handles btnDiskCleanup.Click
        Shell("cleanmgr.exe")
    End Sub

    Private Sub NeedHelpBtn_Click(sender As Object, e As EventArgs) Handles NeedHelpBtn.Click
        'Process.Start("https://www.youtube.com/watch?v=MbC6hH_O6Mg")
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.youtube.com/watch?v=MbC6hH_O6Mg", 0, 0, 1)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("bin/Donation.bat")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.youtube.com/channel/UCJaYH5KX_21lWfX2Ag3-ocg?sub_confirmation=1", 0, 0, 1)
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

    Private Sub DisableHpetBtn_Click(sender As Object, e As EventArgs) Handles DisableHpetBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Are Running This For First Time and Never Used This Button Before?", "Hpet Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Process.Start("bin/disablehpet.bat")
        End If
    End Sub

    Private Sub ISLCBtn_Click(sender As Object, e As EventArgs) Handles ISLCBtn.Click
        Process.Start("bin/ISLC v1.0.2.8/Intelligent standby list cleaner ISLC.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ssInstructions.Show()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://github.com/Sahil12524/PC-Cleaner-2022/releases", 0, 0, 1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("bin/restart_DWM.bat")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("dfrgui.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub
End Class
