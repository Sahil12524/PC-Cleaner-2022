Public Class ss_ISLC_Setup
    Private Sub ss_ISLC_Setup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PictureBox8.Image.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ss_ISLC_Setup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PictureBox8.Image.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ss_ISLC_Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub
End Class