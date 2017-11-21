Public Class validWithdrawal

    Private Sub Withdraw_Button_Click(sender As System.Object, e As System.EventArgs) Handles Withdraw_Button.Click
        cashMain.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        cashNoReceipt.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        cashReceipt.Show()
        Me.Hide()
    End Sub
End Class