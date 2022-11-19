<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamesOptimizationView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GamesOptimizationView))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DisableHpetBtn = New System.Windows.Forms.Button()
        Me.ISLCBtn = New System.Windows.Forms.Button()
        Me.btnScreenshotWayInstructions = New System.Windows.Forms.Button()
        Me.btnRestartDWM = New System.Windows.Forms.Button()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 55)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 395)
        Me.SplitContainer1.SplitterDistance = 498
        Me.SplitContainer1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.DisableHpetBtn)
        Me.Panel3.Controls.Add(Me.ISLCBtn)
        Me.Panel3.Controls.Add(Me.btnScreenshotWayInstructions)
        Me.Panel3.Controls.Add(Me.btnRestartDWM)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(498, 395)
        Me.Panel3.TabIndex = 0
        '
        'DisableHpetBtn
        '
        Me.DisableHpetBtn.AutoEllipsis = True
        Me.DisableHpetBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DisableHpetBtn.Location = New System.Drawing.Point(3, 16)
        Me.DisableHpetBtn.Name = "DisableHpetBtn"
        Me.DisableHpetBtn.Size = New System.Drawing.Size(486, 59)
        Me.DisableHpetBtn.TabIndex = 0
        Me.DisableHpetBtn.Text = "Disable HPET"
        Me.DisableHpetBtn.UseVisualStyleBackColor = True
        '
        'ISLCBtn
        '
        Me.ISLCBtn.AutoEllipsis = True
        Me.ISLCBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ISLCBtn.Location = New System.Drawing.Point(3, 81)
        Me.ISLCBtn.Name = "ISLCBtn"
        Me.ISLCBtn.Size = New System.Drawing.Size(486, 59)
        Me.ISLCBtn.TabIndex = 2
        Me.ISLCBtn.Text = "Intelligent Standby list cleaner (ISLC)"
        Me.ISLCBtn.UseVisualStyleBackColor = True
        '
        'btnScreenshotWayInstructions
        '
        Me.btnScreenshotWayInstructions.AutoEllipsis = True
        Me.btnScreenshotWayInstructions.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnScreenshotWayInstructions.Location = New System.Drawing.Point(3, 211)
        Me.btnScreenshotWayInstructions.Name = "btnScreenshotWayInstructions"
        Me.btnScreenshotWayInstructions.Size = New System.Drawing.Size(486, 59)
        Me.btnScreenshotWayInstructions.TabIndex = 1
        Me.btnScreenshotWayInstructions.Text = "Screenshot Way Instructions"
        Me.btnScreenshotWayInstructions.UseVisualStyleBackColor = True
        '
        'btnRestartDWM
        '
        Me.btnRestartDWM.AutoEllipsis = True
        Me.btnRestartDWM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRestartDWM.Location = New System.Drawing.Point(3, 146)
        Me.btnRestartDWM.Name = "btnRestartDWM"
        Me.btnRestartDWM.Size = New System.Drawing.Size(486, 59)
        Me.btnRestartDWM.TabIndex = 3
        Me.btnRestartDWM.Text = "Restart dwm.exe (Desktop Window Manager)"
        Me.btnRestartDWM.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox3.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(298, 395)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 55)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Optimization"
        '
        'GamesOptimizationView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GamesOptimizationView"
        Me.Text = "GamesOptimizationView"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DisableHpetBtn As Button
    Friend WithEvents ISLCBtn As Button
    Friend WithEvents btnScreenshotWayInstructions As Button
    Friend WithEvents btnRestartDWM As Button
    Friend WithEvents RichTextBox3 As RichTextBox
End Class
