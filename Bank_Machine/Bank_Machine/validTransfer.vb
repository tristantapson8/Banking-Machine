Public Class validTransfer

    Private Sub Withdraw_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Withdraw_Button.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        receipt.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
    End Sub
End Class