<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicToolsView
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
        Me.SSDTrimBtn = New System.Windows.Forms.Button()
        Me.WindowsUpdateCacheBtn = New System.Windows.Forms.Button()
        Me.CheckDiskErrorBtn = New System.Windows.Forms.Button()
        Me.TempRemoveBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SSDTrimBtn, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.WindowsUpdateCacheBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckDiskErrorBtn, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TempRemoveBtn, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 55)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 395)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'SSDTrimBtn
        '
        Me.SSDTrimBtn.AutoEllipsis = True
        Me.SSDTrimBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SSDTrimBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SSDTrimBtn.Location = New System.Drawing.Point(403, 200)
        Me.SSDTrimBtn.Name = "SSDTrimBtn"
        Me.SSDTrimBtn.Size = New System.Drawing.Size(394, 192)
        Me.SSDTrimBtn.TabIndex = 3
        Me.SSDTrimBtn.Text = "SSD Trim Only C Drive"
        Me.SSDTrimBtn.UseVisualStyleBackColor = True
        '
        'WindowsUpdateCacheBtn
        '
        Me.WindowsUpdateCacheBtn.AutoEllipsis = True
        Me.WindowsUpdateCacheBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowsUpdateCacheBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WindowsUpdateCacheBtn.Location = New System.Drawing.Point(403, 3)
        Me.WindowsUpdateCacheBtn.Name = "WindowsUpdateCacheBtn"
        Me.WindowsUpdateCacheBtn.Size = New System.Drawing.Size(394, 191)
        Me.WindowsUpdateCacheBtn.TabIndex = 0
        Me.WindowsUpdateCacheBtn.Text = "Windows Update Cache Remove"
        Me.WindowsUpdateCacheBtn.UseVisualStyleBackColor = True
        '
        'CheckDiskErrorBtn
        '
        Me.CheckDiskErrorBtn.AutoEllipsis = True
        Me.CheckDiskErrorBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckDiskErrorBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckDiskErrorBtn.Location = New System.Drawing.Point(3, 200)
        Me.CheckDiskErrorBtn.Name = "CheckDiskErrorBtn"
        Me.CheckDiskErrorBtn.Size = New System.Drawing.Size(394, 192)
        Me.CheckDiskErrorBtn.TabIndex = 2
        Me.CheckDiskErrorBtn.Text = "Check Disk Errors Only C Drive"
        Me.CheckDiskErrorBtn.UseVisualStyleBackColor = True
        '
        'TempRemoveBtn
        '
        Me.TempRemoveBtn.AutoEllipsis = True
        Me.TempRemoveBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TempRemoveBtn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempRemoveBtn.Location = New System.Drawing.Point(3, 3)
        Me.TempRemoveBtn.Name = "TempRemoveBtn"
        Me.TempRemoveBtn.Size = New System.Drawing.Size(394, 191)
        Me.TempRemoveBtn.TabIndex = 4
        Me.TempRemoveBtn.Text = "Temp Files Remove"
        Me.TempRemoveBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 55)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic Tools"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BasicToolsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BasicToolsView"
        Me.Text = "BasicToolsView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SSDTrimBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents WindowsUpdateCacheBtn As Button
    Friend WithEvents CheckDiskErrorBtn As Button
    Friend WithEvents TempRemoveBtn As Button
End Class
