Public Class HomeView
    Private Sub HomeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub btnUpdateCheck_Click(sender As Object, e As EventArgs) Handles btnUpdateCheck.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://github.com/Sahil12524/PC-Cleaner-2022/releases", 0, 0, 1)
    End Sub
End Class