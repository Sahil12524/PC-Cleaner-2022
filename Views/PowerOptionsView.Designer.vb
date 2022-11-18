<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerOptionsView
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.ShutdownBtn = New System.Windows.Forms.Button()
        Me.AbortBtn = New System.Windows.Forms.Button()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnLogOff, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ShutdownBtn, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.AbortBtn, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RestartBtn, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 55)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(800, 395)
        Me.TableLayoutPanel3.TabIndex = 20
        '
        'btnLogOff
        '
        Me.btnLogOff.AutoEllipsis = True
        Me.btnLogOff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogOff.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogOff.Location = New System.Drawing.Point(403, 200)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(394, 192)
        Me.btnLogOff.TabIndex = 10
        Me.btnLogOff.Text = "Log Off (Quick Restart)"
        Me.btnLogOff.UseVisualStyleBackColor = True
        '
        'ShutdownBtn
        '
        Me.ShutdownBtn.AutoEllipsis = True
        Me.ShutdownBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShutdownBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShutdownBtn.Location = New System.Drawing.Point(3, 3)
        Me.ShutdownBtn.Name = "ShutdownBtn"
        Me.ShutdownBtn.Size = New System.Drawing.Size(394, 191)
        Me.ShutdownBtn.TabIndex = 7
        Me.ShutdownBtn.Text = "Shutdown"
        Me.ShutdownBtn.UseVisualStyleBackColor = True
        '
        'AbortBtn
        '
        Me.AbortBtn.AutoEllipsis = True
        Me.AbortBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AbortBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AbortBtn.Location = New System.Drawing.Point(3, 200)
        Me.AbortBtn.Name = "AbortBtn"
        Me.AbortBtn.Size = New System.Drawing.Size(394, 192)
        Me.AbortBtn.TabIndex = 9
        Me.AbortBtn.Text = "Abort Shutdown or Restart"
        Me.AbortBtn.UseVisualStyleBackColor = True
        '
        'RestartBtn
        '
        Me.RestartBtn.AutoEllipsis = True
        Me.RestartBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RestartBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RestartBtn.Location = New System.Drawing.Point(403, 3)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(394, 191)
        Me.RestartBtn.TabIndex = 8
        Me.RestartBtn.Text = "Restart"
        Me.RestartBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 55)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Power Options"
        '
        'PowerOptionsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PowerOptionsView"
        Me.Text = "PowerOptionsView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnLogOff As Button
    Friend WithEvents ShutdownBtn As Button
    Friend WithEvents AbortBtn As Button
    Friend WithEvents RestartBtn As Button
End Class
