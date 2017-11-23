Public Class enterAccountNum

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 2
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 3
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 4
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 5
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 6
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 7
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 8
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 9
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & 0
    End Sub

    Private Sub ButtonDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDec.Click
        ACCOUNT_box.Text = ACCOUNT_box.Text & "."
    End Sub

    'Clears the PIN entry field
    Private Sub No_Button_Click(sender As System.Object, e As System.EventArgs) Handles No_Button.Click
        ACCOUNT_box.Clear()
    End Sub

    'Goes to main menu if entered pin is correct
    Private Sub Go_Button_Click(sender As System.Object, e As System.EventArgs) Handles Go_Button.Click
        If InStr(1, LCase(ACCOUNT_box.Text), "12345678") <> 0 Then
            enterPin.Show()
            Me.Hide()
        Else
            ACCOUNT_box.Text = "INCORRECT"
        End If
    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        If ACCOUNT_box.Text < " " Then
            ACCOUNT_box.Text = Mid(ACCOUNT_box.Text, 1, Len(ACCOUNT_box.Text) - 1 + 1)
        Else
            ACCOUNT_box.Text = Mid(ACCOUNT_box.Text, 1, Len(ACCOUNT_box.Text) - 1)
        End If
    End Sub
End Class