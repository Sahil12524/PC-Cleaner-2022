Public Class AboutView
    Private Sub AboutView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub pbDonate_Click(sender As Object, e As EventArgs) Handles pbDonate.Click
        Process.Start("bin/Donation.bat")
    End Sub

    Private Sub pbYTSubscribe_Click(sender As Object, e As EventArgs) Handles pbYTSubscribe.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.youtube.com/channel/UCJaYH5KX_21lWfX2Ag3-ocg?sub_confirmation=1", 0, 0, 1)
    End Sub
End Class