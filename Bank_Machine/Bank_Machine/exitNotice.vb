Public Class exitNotice
    Dim second As Integer

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer.Interval = 1000
        Timer.Start() 'Timer starts functioning
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        second = second + 1
        If second >= 5 Then
            Timer.Stop() 'Timer stops functioning
            Me.Close()
        End If

    End Sub

    Private Sub Timer_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

    End Sub
End Class