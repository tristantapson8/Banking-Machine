﻿Public Class depositAmount

    Friend AC_type As RichTextBox = Account_type
    Dim dA As Double

    Private Sub AMMOUNT_box_TextChanged(sender As System.Object, e As System.EventArgs) Handles AMMOUNT_box.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 2
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 3
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 4
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 5
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 6
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 7
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 8
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        AMMOUNT_box.Text = AMMOUNT_box.Text & 9
    End Sub

    Private Sub Go_Button_Click(sender As System.Object, e As System.EventArgs) Handles Go_Button.Click
        dA = Double.Parse(AMMOUNT_box.Text)
        AMMOUNT_box.Text = ""

        'deposit to chequeing
        If deposit.Ch_Clicked = True Then
            If mainMenu.Chequeing_Amount + dA >= 0 Then
                mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount + dA
                deposit.Ch_Clicked = False
                validDeposit.Show()
                Me.Hide()
            End If
        End If

        'deposit to saving
        If deposit.Sv_Clicked = True Then
            If mainMenu.Saving_Amount + dA >= 0 Then
                mainMenu.Saving_Amount = mainMenu.Saving_Amount + dA
                deposit.Sv_Clicked = False
                validDeposit.Show()
                Me.Hide()
            End If
        End If

        'deposit to credit
        If deposit.Cr_Clicked = True Then
            If mainMenu.Credit_Amount + dA >= 0 Then
                mainMenu.Credit_Amount = mainMenu.Credit_Amount + dA
                deposit.Sv_Clicked = False
                validDeposit.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Back_Button_Click(sender As System.Object, e As System.EventArgs) Handles Back_Button.Click
        deposit.Show()
        Me.Hide()
    End Sub

    Private Sub No_Button_Click(sender As System.Object, e As System.EventArgs) Handles No_Button.Click
        AMMOUNT_box.Text = ""
    End Sub

End Class