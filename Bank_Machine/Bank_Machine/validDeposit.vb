﻿Public Class validDeposit

    Private Sub Withdraw_Button_Click(sender As System.Object, e As System.EventArgs) Handles Withdraw_Button.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Receipt.Show()
        Me.Hide()
    End Sub
End Class