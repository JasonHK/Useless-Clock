<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Separator1 As System.Windows.Forms.ToolStripSeparator
        Dim Separator2 As System.Windows.Forms.ToolStripSeparator
        Dim Separator3 As System.Windows.Forms.ToolStripSeparator
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlwaysTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiniMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartupLaunch = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdataButton = New System.Windows.Forms.Button()
        Me.UpdataTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Separator1
        '
        Separator1.Name = "Separator1"
        Separator1.Size = New System.Drawing.Size(317, 6)
        '
        'Separator2
        '
        Separator2.Name = "Separator2"
        Separator2.Size = New System.Drawing.Size(317, 6)
        '
        'Separator3
        '
        Separator3.Name = "Separator3"
        Separator3.Size = New System.Drawing.Size(317, 6)
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TimeLabel.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(10, 10)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(399, 43)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "YYYY-MM-DD HH:MM:SS"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysTop, Separator1, Me.MiniMode, Separator2, Me.AutoStart, Me.StartupLaunch, Separator3, Me.AboutProgram})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip.ShowCheckMargin = True
        Me.ContextMenuStrip.ShowImageMargin = False
        Me.ContextMenuStrip.Size = New System.Drawing.Size(321, 154)
        '
        'AlwaysTop
        '
        Me.AlwaysTop.CheckOnClick = True
        Me.AlwaysTop.Name = "AlwaysTop"
        Me.AlwaysTop.ShortcutKeyDisplayString = ""
        Me.AlwaysTop.Size = New System.Drawing.Size(320, 22)
        Me.AlwaysTop.Text = "Always on the top"
        '
        'MiniMode
        '
        Me.MiniMode.CheckOnClick = True
        Me.MiniMode.Enabled = False
        Me.MiniMode.Name = "MiniMode"
        Me.MiniMode.Size = New System.Drawing.Size(320, 22)
        Me.MiniMode.Text = "Mini mode (default on bottom right)"
        '
        'AutoStart
        '
        Me.AutoStart.CheckOnClick = True
        Me.AutoStart.Name = "AutoStart"
        Me.AutoStart.Size = New System.Drawing.Size(320, 22)
        Me.AutoStart.Text = "Start the clock when the program launch"
        '
        'StartupLaunch
        '
        Me.StartupLaunch.CheckOnClick = True
        Me.StartupLaunch.Enabled = False
        Me.StartupLaunch.Name = "StartupLaunch"
        Me.StartupLaunch.Size = New System.Drawing.Size(320, 22)
        Me.StartupLaunch.Text = "Launch the program when Windows startup"
        '
        'AboutProgram
        '
        Me.AboutProgram.Name = "AboutProgram"
        Me.AboutProgram.Size = New System.Drawing.Size(320, 22)
        Me.AboutProgram.Text = "About"
        '
        'UpdataButton
        '
        Me.UpdataButton.Location = New System.Drawing.Point(290, 65)
        Me.UpdataButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdataButton.Name = "UpdataButton"
        Me.UpdataButton.Size = New System.Drawing.Size(110, 35)
        Me.UpdataButton.TabIndex = 0
        Me.UpdataButton.Text = "&Update"
        Me.UpdataButton.UseVisualStyleBackColor = True
        '
        'UpdataTimer
        '
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.JasonKwok.Exercise.UselessClock.My.Resources.Resources.StudioLogo
        Me.LogoPictureBox.Location = New System.Drawing.Point(13, 57)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(50, 50)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 2
        Me.LogoPictureBox.TabStop = False
        '
        'StartStopButton
        '
        Me.StartStopButton.Location = New System.Drawing.Point(170, 65)
        Me.StartStopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(110, 35)
        Me.StartStopButton.TabIndex = 0
        Me.StartStopButton.Text = "&Start"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 115)
        Me.Controls.Add(Me.StartStopButton)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.UpdataButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(425, 150)
        Me.MinimumSize = New System.Drawing.Size(425, 150)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Useless Clock"
        Me.TopMost = True
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents UpdataButton As System.Windows.Forms.Button
    Friend WithEvents UpdataTimer As System.Windows.Forms.Timer
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents StartStopButton As System.Windows.Forms.Button
    Friend WithEvents AutoStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartupLaunch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiniMode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip

End Class
