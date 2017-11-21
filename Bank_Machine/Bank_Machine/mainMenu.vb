Public Class mainMenu

    Friend Chequeing_Amount As Double = 100.0
    Friend Saving_Amount As Double = 100.0
    Friend Credit_Amount As Double = 100.0

    Private Sub Withdraw_Button_Click(sender As System.Object, e As System.EventArgs) Handles Withdraw_Button.Click
        withdraw.Show()
        Me.Hide()
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        deposit.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        transfer1.Show()
        Me.Hide()
    End Sub
End Class