Public Class transfer2

    Friend Ch_Clicked_T2 As Boolean = False
    Friend Sv_Clicked_T2 As Boolean = False
    Friend Cr_Clicked_T2 As Boolean = False

    Private Sub Chequing_Button_Click(sender As System.Object, e As System.EventArgs) Handles Chequeing_Button.Click
        Ch_Clicked_T2 = True
        transferAmount.Show()
        transferAmount.Account_type2.Text = "Chequeing"
        Me.Hide()
    End Sub

    Private Sub Saving_Button_Click(sender As System.Object, e As System.EventArgs) Handles Saving_Button.Click
        Sv_Clicked_T2 = True
        transferAmount.Show()
        transferAmount.Account_type2.Text = "Saving"
        Me.Hide()
    End Sub

    Private Sub Credit_Button_Click(sender As System.Object, e As System.EventArgs) Handles Credit_Button.Click
        Cr_Clicked_T2 = True
        transferAmount.Show()
        transferAmount.Account_type2.Text = "Credit"
        Me.Hide()
    End Sub

    Private Sub Back_Button_Click(sender As System.Object, e As System.EventArgs) Handles Back_Button.Click
        transfer1.Show()
        Me.Hide()
    End Sub
End Class