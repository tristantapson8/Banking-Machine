Public Class exitNotice
    Dim second As Integer

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start() 'Timer starts functioning
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        second = second + 1
        If second >= 5 Then
            Timer1.Stop() 'Timer stops functioning
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class