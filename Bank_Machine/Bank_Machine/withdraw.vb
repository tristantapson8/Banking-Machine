Public Class withdraw

    Friend Ch_Clicked As Boolean = False
    Friend Sv_Clicked As Boolean = False
    Friend Cr_Clicked As Boolean = False

    Private Sub Chequing_Button_Click(sender As System.Object, e As System.EventArgs) Handles Chequeing_Button.Click
        Ch_Clicked = True
        withdrawAmount.Show()
        withdrawAmount.Account_type.Text = "Chequeing"
        Me.Hide()
    End Sub

    Private Sub Saving_Button_Click(sender As System.Object, e As System.EventArgs) Handles Saving_Button.Click
        Sv_Clicked = True
        withdrawAmount.Show()
        withdrawAmount.Account_type.Text = "Saving"
        Me.Hide()
    End Sub

    Private Sub Credit_Button_Click(sender As System.Object, e As System.EventArgs) Handles Credit_Button.Click
        Cr_Clicked = True
        withdrawAmount.Show()
        withdrawAmount.Account_type.Text = "Credit"
        Me.Hide()
    End Sub

    Private Sub Back_Button_Click(sender As System.Object, e As System.EventArgs) Handles Back_Button.Click
        mainMenu.Show()
        Me.Hide()
    End Sub
End Class