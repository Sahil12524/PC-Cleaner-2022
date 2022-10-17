Public Class ss_Home
    Private Sub ss_Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RichTextBox4.Dispose()
        RichTextBox4.Text.DefaultIfEmpty
        Me.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ss_Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RichTextBox4.Dispose()
        RichTextBox4.Text.DefaultIfEmpty
        Me.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ss_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub
End Class