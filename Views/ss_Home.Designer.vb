<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ss_Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.RichTextBox4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 514)
        Me.Panel4.TabIndex = 3
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.MediumPurple
        Me.RichTextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox4.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox4.ForeColor = System.Drawing.Color.White
        Me.RichTextBox4.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(800, 514)
        Me.RichTextBox4.TabIndex = 0
        Me.RichTextBox4.Text = "Hello, Welcome to Screenshot Way Instructions." & Global.Microsoft.VisualBasic.ChrW(10) & "I hope this guide will make every " &
    "thing easy for you to setup on your own." & Global.Microsoft.VisualBasic.ChrW(10) & "Please use these instructions wisely."
        '
        'ss_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 514)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "ss_Home"
        Me.Text = "ss_Home"
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RichTextBox4 As RichTextBox
End Class
