Public Class exitConfirm

    Private Sub yesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesButton.Click
        exitNotice.Show()
        Me.Hide()
    End Sub

    Private Sub noButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub
End Class