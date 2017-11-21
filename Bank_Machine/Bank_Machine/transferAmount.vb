Public Class transferAmount
    Friend AC_type1 As RichTextBox = Account_type1
    Friend AC_type2 As RichTextBox = Account_type2
    Dim tA As Double

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
        tA = Double.Parse(AMMOUNT_box.Text)
        AMMOUNT_box.Text = ""

        ' --- CHEQUEING ---

        'from chequeing to chequeing
        If transfer1.Ch_Clicked_T1 = True And transfer2.Ch_Clicked_T2 = True Then
            If mainMenu.Chequeing_Amount - tA >= 0 Then
                mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount
                transfer1.Ch_Clicked_T1 = False
                transfer2.Ch_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Chequeing_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        'from chequeing to saving
        If transfer1.Ch_Clicked_T1 = True And transfer2.Sv_Clicked_T2 = True Then
            If mainMenu.Chequeing_Amount - tA >= 0 Then
                mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - tA
                mainMenu.Saving_Amount = mainMenu.Saving_Amount + tA
                transfer1.Ch_Clicked_T1 = False
                transfer2.Sv_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Chequeing_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        'from chequing to credit
        If transfer1.Ch_Clicked_T1 = True And transfer2.Cr_Clicked_T2 = True Then
            If mainMenu.Chequeing_Amount - tA >= 0 Then
                mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - tA
                mainMenu.Credit_Amount = mainMenu.Credit_Amount + tA
                transfer1.Ch_Clicked_T1 = False
                transfer2.Cr_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Chequeing_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        ' --- SAVINGS ---

        'from saving to chequeing
        If transfer1.Sv_Clicked_T1 = True And transfer2.Ch_Clicked_T2 = True Then
            If mainMenu.Saving_Amount - tA >= 0 Then
                mainMenu.Saving_Amount = mainMenu.Saving_Amount - tA
                mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount + tA
                transfer1.Sv_Clicked_T1 = False
                transfer2.Ch_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Saving_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        'from saving to saving
        If transfer1.Sv_Clicked_T1 = True And transfer2.Sv_Clicked_T2 = True Then
            If mainMenu.Saving_Amount - tA >= 0 Then
                mainMenu.Saving_Amount = mainMenu.Saving_Amount
                transfer1.Sv_Clicked_T1 = False
                transfer2.Sv_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Saving_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        'from saving to credit
        If transfer1.Sv_Clicked_T1 = True And transfer2.Cr_Clicked_T2 = True Then
            If mainMenu.Saving_Amount - tA >= 0 Then
                mainMenu.Saving_Amount = mainMenu.Saving_Amount - tA
                mainMenu.Credit_Amount = mainMenu.Credit_Amount + tA
                transfer1.Sv_Clicked_T1 = False
                transfer2.Cr_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Saving_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        ' --- CREDIT --- 

        'from credit to chequeing
        If transfer1.Cr_Clicked_T1 = True And transfer2.Ch_Clicked_T2 = True Then
            If mainMenu.Credit_Amount - tA >= 0 Then
                mainMenu.Credit_Amount = mainMenu.Credit_Amount - tA
                mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount + tA
                transfer1.Cr_Clicked_T1 = False
                transfer2.Ch_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Credit_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        'from credit to saving
        If transfer1.Cr_Clicked_T1 = True And transfer2.Sv_Clicked_T2 = True Then
            If mainMenu.Credit_Amount - tA >= 0 Then
                mainMenu.Credit_Amount = mainMenu.Credit_Amount - tA
                mainMenu.Saving_Amount = mainMenu.Saving_Amount + tA
                transfer1.Cr_Clicked_T1 = False
                transfer2.Sv_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Credit_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If

        'from credit to credit
        If transfer1.Cr_Clicked_T1 = True And transfer2.Cr_Clicked_T2 = True Then
            If mainMenu.Credit_Amount - tA >= 0 Then
                mainMenu.Credit_Amount = mainMenu.Credit_Amount
                transfer1.Cr_Clicked_T1 = False
                transfer2.Cr_Clicked_T2 = False
                validTransfer.Show()
                Me.Hide()
            ElseIf mainMenu.Credit_Amount - tA < 0 Then
                invalidTransfer.Show()
            End If
        End If


        
    End Sub

    Private Sub Back_Button_Click(sender As System.Object, e As System.EventArgs) Handles Back_Button.Click
        transfer2.Show()
        Me.Hide()
    End Sub

    Private Sub No_Button_Click(sender As System.Object, e As System.EventArgs) Handles No_Button.Click
        AMMOUNT_box.Text = ""
    End Sub
   
End Class