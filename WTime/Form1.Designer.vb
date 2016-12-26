<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WTimeForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WTimeForm))
        Me.wTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startButton = New System.Windows.Forms.Button
        Me.periodText = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.progressBar = New System.Windows.Forms.ProgressBar
        Me.timeView = New System.Windows.Forms.TextBox
        Me.minuteView = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.TopMostMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'wTimer
        '
        Me.wTimer.Enabled = True
        Me.wTimer.Interval = 1000
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("NSimSun", 13.0!, System.Drawing.FontStyle.Bold)
        Me.startButton.Location = New System.Drawing.Point(284, 11)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(89, 36)
        Me.startButton.TabIndex = 2
        Me.startButton.Text = "开始"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'periodText
        '
        Me.periodText.Font = New System.Drawing.Font("NSimSun", 13.0!, System.Drawing.FontStyle.Bold)
        Me.periodText.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.periodText.Location = New System.Drawing.Point(132, 13)
        Me.periodText.Name = "periodText"
        Me.periodText.Size = New System.Drawing.Size(76, 32)
        Me.periodText.TabIndex = 1
        Me.periodText.Text = "180"
        Me.periodText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NSimSun", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(225, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "秒"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NSimSun", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "循环周期"
        '
        'progressBar
        '
        Me.progressBar.BackColor = System.Drawing.SystemColors.ControlText
        Me.progressBar.ForeColor = System.Drawing.Color.Lime
        Me.progressBar.Location = New System.Drawing.Point(9, 123)
        Me.progressBar.MarqueeAnimationSpeed = 1
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(363, 39)
        Me.progressBar.Step = 1
        Me.progressBar.TabIndex = 3
        '
        'timeView
        '
        Me.timeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeView.BackColor = System.Drawing.SystemColors.WindowText
        Me.timeView.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeView.ForeColor = System.Drawing.Color.Lime
        Me.timeView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.timeView.Location = New System.Drawing.Point(9, 59)
        Me.timeView.Margin = New System.Windows.Forms.Padding(3, 1, 1, 3)
        Me.timeView.Name = "timeView"
        Me.timeView.Size = New System.Drawing.Size(168, 53)
        Me.timeView.TabIndex = 3
        Me.timeView.Text = "000"
        Me.timeView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'minuteView
        '
        Me.minuteView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minuteView.BackColor = System.Drawing.SystemColors.WindowText
        Me.minuteView.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minuteView.ForeColor = System.Drawing.Color.Lime
        Me.minuteView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.minuteView.Location = New System.Drawing.Point(202, 59)
        Me.minuteView.Margin = New System.Windows.Forms.Padding(3, 1, 1, 3)
        Me.minuteView.MinimumSize = New System.Drawing.Size(153, 50)
        Me.minuteView.Name = "minuteView"
        Me.minuteView.ReadOnly = True
        Me.minuteView.Size = New System.Drawing.Size(169, 53)
        Me.minuteView.TabIndex = 5
        Me.minuteView.TabStop = False
        Me.minuteView.Text = "00:00"
        Me.minuteView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.minuteView)
        Me.Panel1.Controls.Add(Me.progressBar)
        Me.Panel1.Controls.Add(Me.timeView)
        Me.Panel1.Controls.Add(Me.startButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.periodText)
        Me.Panel1.Location = New System.Drawing.Point(5, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 170)
        Me.Panel1.TabIndex = 6
        '
        'ToolMenu
        '
        Me.ToolMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopMostMenu})
        Me.ToolMenu.Font = New System.Drawing.Font("NSimSun", 13.0!)
        Me.ToolMenu.Name = "ToolMenu"
        Me.ToolMenu.Size = New System.Drawing.Size(66, 26)
        Me.ToolMenu.Text = "工具"
        '
        'TopMostMenu
        '
        Me.TopMostMenu.AutoToolTip = True
        Me.TopMostMenu.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TopMostMenu.Checked = True
        Me.TopMostMenu.CheckOnClick = True
        Me.TopMostMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TopMostMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TopMostMenu.Name = "TopMostMenu"
        Me.TopMostMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.TopMostMenu.Size = New System.Drawing.Size(244, 26)
        Me.TopMostMenu.Text = "总在最前"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolMenu, Me.帮助ToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(393, 30)
        Me.MenuStrip.TabIndex = 8
        Me.MenuStrip.Text = "MenuStrip1"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenuItem})
        Me.帮助ToolStripMenuItem.Font = New System.Drawing.Font("SimSun", 13.0!)
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(66, 26)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AboutMenuItem.Text = "关于"
        '
        'WTimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(393, 203)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "WTimeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计时器 Ver0.1"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents wTimer As System.Windows.Forms.Timer
    Friend WithEvents startButton As System.Windows.Forms.Button
    Friend WithEvents periodText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents timeView As System.Windows.Forms.TextBox
    Friend WithEvents minuteView As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopMostMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
