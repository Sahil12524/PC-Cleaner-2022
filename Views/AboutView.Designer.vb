<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutView))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbDonate = New System.Windows.Forms.PictureBox()
        Me.pbYTSubscribe = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.pbDonate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbYTSubscribe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 595)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoScroll = True
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.RichTextBox1, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1047, 595)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoScroll = True
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.pbDonate, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.pbYTSubscribe, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.PictureBox4, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.81818!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(517, 589)
        Me.TableLayoutPanel7.TabIndex = 9
        '
        'pbDonate
        '
        Me.pbDonate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbDonate.Image = Global.PC_Cleaner_2022.My.Resources.Resources.PayPal_Donate_Button_Transparent
        Me.pbDonate.Location = New System.Drawing.Point(3, 199)
        Me.pbDonate.Name = "pbDonate"
        Me.pbDonate.Size = New System.Drawing.Size(511, 229)
        Me.pbDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDonate.TabIndex = 7
        Me.pbDonate.TabStop = False
        '
        'pbYTSubscribe
        '
        Me.pbYTSubscribe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbYTSubscribe.Image = Global.PC_Cleaner_2022.My.Resources.Resources.subscribe_PNG29
        Me.pbYTSubscribe.Location = New System.Drawing.Point(3, 434)
        Me.pbYTSubscribe.Name = "pbYTSubscribe"
        Me.pbYTSubscribe.Size = New System.Drawing.Size(511, 152)
        Me.pbYTSubscribe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbYTSubscribe.TabIndex = 5
        Me.pbYTSubscribe.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.PC_Cleaner_2022.My.Resources.Resources.cleaning_broom
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(511, 190)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox1.Location = New System.Drawing.Point(526, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(518, 589)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 55)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1047, 650)
        Me.Panel3.TabIndex = 2
        '
        'AboutView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 650)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Name = "AboutView"
        Me.Text = "AboutView"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.pbDonate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbYTSubscribe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents pbDonate As PictureBox
    Friend WithEvents pbYTSubscribe As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel3 As Panel
End Class
