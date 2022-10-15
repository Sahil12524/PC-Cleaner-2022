Public Class Form2
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Form1.Show()
        PictureBox1.Image.Dispose()
        PictureBox2.Image.Dispose()
        PictureBox3.Image.Dispose()
        PictureBox4.Image.Dispose()
        PictureBox5.Image.Dispose()
        PictureBox6.Image.Dispose()
        Form1.Refresh()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        PictureBox1.Image.Dispose()
        PictureBox2.Image.Dispose()
        PictureBox3.Image.Dispose()
        PictureBox4.Image.Dispose()
        PictureBox5.Image.Dispose()
        PictureBox6.Image.Dispose()
        Form1.Refresh()
    End Sub

End Class