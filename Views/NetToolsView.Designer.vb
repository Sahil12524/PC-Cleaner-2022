<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetToolsView
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPacketLossTester = New System.Windows.Forms.Button()
        Me.NetDisableBtn = New System.Windows.Forms.Button()
        Me.FlushDnsBtn = New System.Windows.Forms.Button()
        Me.NetEnableBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnPacketLossTester, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NetDisableBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlushDnsBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NetEnableBtn, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 55)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 395)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'btnPacketLossTester
        '
        Me.btnPacketLossTester.AutoEllipsis = True
        Me.btnPacketLossTester.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPacketLossTester.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPacketLossTester.Location = New System.Drawing.Point(403, 200)
        Me.btnPacketLossTester.Name = "btnPacketLossTester"
        Me.btnPacketLossTester.Size = New System.Drawing.Size(394, 192)
        Me.btnPacketLossTester.TabIndex = 7
        Me.btnPacketLossTester.Text = "Packet Loss Tester"
        Me.btnPacketLossTester.UseVisualStyleBackColor = True
        '
        'NetDisableBtn
        '
        Me.NetDisableBtn.AutoEllipsis = True
        Me.NetDisableBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetDisableBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NetDisableBtn.Location = New System.Drawing.Point(3, 3)
        Me.NetDisableBtn.Name = "NetDisableBtn"
        Me.NetDisableBtn.Size = New System.Drawing.Size(394, 191)
        Me.NetDisableBtn.TabIndex = 4
        Me.NetDisableBtn.Text = "Disable Net"
        Me.NetDisableBtn.UseVisualStyleBackColor = True
        '
        'FlushDnsBtn
        '
        Me.FlushDnsBtn.AutoEllipsis = True
        Me.FlushDnsBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlushDnsBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FlushDnsBtn.Location = New System.Drawing.Point(403, 3)
        Me.FlushDnsBtn.Name = "FlushDnsBtn"
        Me.FlushDnsBtn.Size = New System.Drawing.Size(394, 191)
        Me.FlushDnsBtn.TabIndex = 5
        Me.FlushDnsBtn.Text = "Flush DNS"
        Me.FlushDnsBtn.UseVisualStyleBackColor = True
        '
        'NetEnableBtn
        '
        Me.NetEnableBtn.AutoEllipsis = True
        Me.NetEnableBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetEnableBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NetEnableBtn.Location = New System.Drawing.Point(3, 200)
        Me.NetEnableBtn.Name = "NetEnableBtn"
        Me.NetEnableBtn.Size = New System.Drawing.Size(394, 192)
        Me.NetEnableBtn.TabIndex = 6
        Me.NetEnableBtn.Text = "Enable Net"
        Me.NetEnableBtn.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(146, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Net Tools"
        '
        'NetToolsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NetToolsView"
        Me.Text = "NetToolsView"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnPacketLossTester As Button
    Friend WithEvents NetDisableBtn As Button
    Friend WithEvents FlushDnsBtn As Button
    Friend WithEvents NetEnableBtn As Button
End Class
