Public Class OtherOptionsView
    Private Sub OtherOptionsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub btnDiskCleanup_Click(sender As Object, e As EventArgs) Handles btnDiskCleanup.Click
        Shell("cleanmgr.exe")
    End Sub

    Private Sub NeedHelpBtn_Click(sender As Object, e As EventArgs) Handles NeedHelpBtn.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.youtube.com/watch?v=MbC6hH_O6Mg", 0, 0, 1)
    End Sub

    Private Sub btnDskDfrag_Click(sender As Object, e As EventArgs) Handles btnDskDfrag.Click
        Shell("dfrgui.exe")
    End Sub
End Class