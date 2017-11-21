Public Class startScreen


    'Click anywhere on screen to enter pin
    Private Sub AOS_Click(sender As System.Object, e As System.EventArgs) Handles AOS.Click
        enterAccountNum.Show()
        Me.Hide()

    End Sub

    'Swipe card to continue
    Private Sub Swipe_Slot_Click(sender As System.Object, e As System.EventArgs) Handles Swipe_Slot.Click
        enterPin.Show()
        Me.Hide()
    End Sub
End Class