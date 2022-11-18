Public Class ssInstructions

    Private Sub ssInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(ss_Home)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub ssInstructions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        MainPage.Show()
        'PictureBox1.Image.Dispose()
        'PictureBox2.Image.Dispose()
        'PictureBox3.Image.Dispose()
        'PictureBox4.Image.Dispose()
        'PictureBox5.Image.Dispose()
        'PictureBox6.Image.Dispose()
        MainPage.Refresh()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub ssInstructions_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        'PictureBox1.Image.Dispose()
        'PictureBox2.Image.Dispose()
        'PictureBox3.Image.Dispose()
        'PictureBox4.Image.Dispose()
        'PictureBox5.Image.Dispose()
        'PictureBox6.Image.Dispose()
        MainPage.Refresh()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ss_Home.Close()
        ss_ISLC_Setup.Dispose()
        ss_ISLC_Setup.Close()
        switchPanel(ss_Home)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(ss_ISLC_Setup)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(ss_Game_Mode)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

End Class