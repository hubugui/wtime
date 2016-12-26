Public Class WTimeForm

    Protected totalSecond As VariantType
    Protected count As Integer
    Protected timeString As String

    Protected timeViewSetFlag As Integer

    Protected thisText As String

    Private Sub timer_begin()
        If IsNumeric(periodText.Text) Then
            totalSecond = periodText.Text
            If totalSecond > 0 Then
                count = -1

                progressBar.Maximum = totalSecond
                progressBar.Minimum = 0
                progressBar.Value = 0

                timeViewSetFlag = 1
            End If
        End If
    End Sub

    Private Sub display_title()
        Dim ddd As Double
        Dim eee As Double

        Dim fff As String
        Dim ggg As String

        ddd = count / 60
        eee = count Mod 60

        ddd = Fix(ddd)
        eee = Fix(eee)

        fff = Convert.ToInt32(ddd)
        If fff.Length < 2 Then
            fff = "0" + fff
        End If
        ggg = Convert.ToInt32(eee)
        If ggg.Length < 2 Then
            ggg = "0" + ggg
        End If

        minuteView.Text = fff + ":" + ggg
    End Sub

    Private Sub timer_period()
        count = count + 1

        If (count > totalSecond) Then
            count = 1
            progressBar.Value = 0
        End If

        If count < 10 Then
            timeString = "00" + count.ToString
        ElseIf count < 100 Then
            timeString = "0" + count.ToString
        Else
            timeString = count.ToString
        End If

        timeView.Text = timeString
        If (count > 0) Then
            progressBar.Value = count
        End If

        ' update GUI minute format
        display_title()
    End Sub

    Private Sub timeViewChange()
        If IsNumeric(timeView.Text) Then
            If timeView.Text - 1 < totalSecond Then
                count = timeView.Text - 1
                timer_period()

                periodText.Focus()
                periodText.Select(0, periodText.TextLength)
                timeViewSetFlag = 1
            End If
        End If
    End Sub

    Private Sub wTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wTimer.Tick
        If timeViewSetFlag = 1 Then
            timer_period()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        timer_begin()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timer_begin()
        thisText = Text
    End Sub

    Private Sub periodText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles periodText.KeyDown
        If e.KeyCode = Keys.Enter Then
            timer_begin()
        End If
    End Sub

    Private Sub timeView_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeView.GotFocus
        timeViewSetFlag = 0
    End Sub

    Private Sub timeView_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles timeView.KeyPress
        If e.KeyChar < "0"c Or e.KeyChar > "9"c Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub timeView_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeView.Leave
        timeViewChange()
    End Sub

    Private Sub TopMostMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopMostMenu.Click
        If Me.TopMost Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub periodText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles periodText.KeyPress
        If e.KeyChar < "0"c Or e.KeyChar > "9"c Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub AboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMenuItem.Click        
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Version 0.1"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.OkOnly
        title = "关于"
        response = MsgBox(msg, style, title)
    End Sub
End Class
