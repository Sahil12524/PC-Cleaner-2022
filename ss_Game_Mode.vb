Public Class ss_Game_Mode
    Private Sub ss_Game_Mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ss_Game_Mode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ss_Game_Mode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub
End Class