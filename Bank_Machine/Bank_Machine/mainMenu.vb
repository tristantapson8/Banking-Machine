Public Class mainMenu

    Friend Chequeing_Amount As Double = 100.0
    Friend Saving_Amount As Double = 100.0
    Friend Credit_Amount As Double = 100.0

    Private Sub Withdraw_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Withdraw_Button.Click
        withdraw.Show()
        Me.Hide()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        deposit.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        transfer1.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        accountInfo.Show()
        accountInfo.chequingAmt.Text = Chequeing_Amount
        accountInfo.savingAmt.Text = Saving_Amount
        accountInfo.creditAmt.Text = Credit_Amount
        Me.Hide()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        exitConfirm.Show()
        Me.Hide()
    End Sub
End Class