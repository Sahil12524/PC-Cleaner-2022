Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class MainPage

    'Dim rs As New Resizer

    'Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'rs.FindAllControls(Me)
    'End Sub

    'Private Sub MainPage_Resize(sender As Object, e As EventArgs) Handles Me.Resize, MyBase.LocationChanged
    'rs.ResizeAllControls(Me)
    'End Sub
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(HomeView)
        Me.Size = New Size(1200, 680)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel8.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel8.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub MainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub MainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        switchPanel(HomeView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnBasicTools_Click(sender As Object, e As EventArgs) Handles btnBasicTools.Click
        switchPanel(BasicToolsView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnNetTools_Click(sender As Object, e As EventArgs) Handles btnNetTools.Click
        switchPanel(NetToolsView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnWhatsNew_Click(sender As Object, e As EventArgs) Handles btnWhatsNew.Click
        switchPanel(WhatsNewView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnOtherOptions_Click(sender As Object, e As EventArgs) Handles btnOtherOptions.Click
        switchPanel(OtherOptionsView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnGameOptimization_Click(sender As Object, e As EventArgs) Handles btnGameOptimization.Click
        switchPanel(GamesOptimizationView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnPowerOptions_Click(sender As Object, e As EventArgs) Handles btnPowerOptions.Click
        switchPanel(PowerOptionsView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        switchPanel(AboutView)
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub btnMoreInfo_Click(sender As Object, e As EventArgs) Handles btnMoreInfo.Click
        If Me.Size = New Size(606, 680) Then
            btnMoreInfo.Text = ">"
            Me.Size = New Size(1200, 680)
        Else
            btnMoreInfo.Text = "<"
            Me.Size = New Size(606, 680)
        End If
    End Sub
End Class
