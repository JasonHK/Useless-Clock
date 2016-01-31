Public Class Main
    Dim Started As Boolean = False
    Dim StudioLogo As Boolean = True

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        '更改焦點至開始暫停按鈕
        StartStopButton.Focus()

        '設定預設圖片
        LogoPictureBox.Image = My.Resources.StudioLogo

        If My.Settings.AutoStart = True Then
            StartStop()
            AutoStart.Checked = True
        ElseIf My.Settings.AutoStart = False Then
            AutoStart.Checked = False
        End If

        If My.Settings.AlwaysTop = True Then
            TopMost = True
            AlwaysTop.Checked = True
        ElseIf My.Settings.AlwaysTop = False Then
            TopMost = False
            AlwaysTop.Checked = False
        End If

    End Sub

    Private Sub AboutProgram_Click(sender As Object, e As EventArgs) Handles AboutProgram.Click

        MsgBox("")

    End Sub

    Sub StartStop()

        '更改按鈕的文字，並且開始或暫停計時器
        If Started = False Then
            Started = True '更改開始設定
            UpdataTimer.Start() '開始計時器
            StartStopButton.Text = "&Stop"
        ElseIf Started = True Then
            Started = False '更改開始設定
            UpdataTimer.Stop() '暫停計時器
            UpdataTimer.Dispose()
            StartStopButton.Text = "&Start"
        Else
            MsgBox("An unknown error occurs!" & Chr(13) & "About to pause the timer.", vbOKOnly & vbCritical, "Error") '嚴重錯誤警告
            Started = False '更改開始設定
            UpdataTimer.Stop() '暫停計時器
            UpdataTimer.Dispose()
            StartStopButton.Text = "&Start"
        End If

    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click

        StartStop()

    End Sub

    Sub Updata() '更新目前時間副程式

        '更新目前時間
        TimeLabel.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")

    End Sub

    Private Sub UpdataTimer_Tick(sender As Object, e As EventArgs) Handles UpdataTimer.Tick

        '更新目前時間副程式
        Updata()

    End Sub

    Private Sub UpdataButton_Click(sender As Object, e As EventArgs) Handles UpdataButton.Click

        '更新目前時間副程式
        Updata()

    End Sub

    Private Sub AutoStart_CheckedChanged(sender As Object, e As EventArgs) Handles AutoStart.CheckedChanged

        If AutoStart.Checked = True Then
            My.Settings.AutoStart = True
        ElseIf AutoStart.Checked = False Then
            My.Settings.AutoStart = False
        End If

    End Sub

    Private Sub AlwaysTop_CheckedChanged(sender As Object, e As EventArgs) Handles AlwaysTop.CheckedChanged

        If AlwaysTop.Checked = True Then
            TopMost = True
            My.Settings.AlwaysTop = True
        ElseIf AlwaysTop.Checked = False Then
            TopMost = False
            My.Settings.AlwaysTop = False
        End If

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

        '按一下後轉換圖片
        If StudioLogo = True Then
            StudioLogo = False '更改設定
            LogoPictureBox.Image = My.Resources.TimeLogo '轉換圖片
        ElseIf StudioLogo = False Then
            StudioLogo = True '更改設定
            LogoPictureBox.Image = My.Resources.StudioLogo '轉換圖片
        End If

    End Sub
End Class