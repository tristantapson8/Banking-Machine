Public Class enterPin

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PIN_box.Text = PIN_box.Text & 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PIN_box.Text = PIN_box.Text & 2
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PIN_box.Text = PIN_box.Text & 3
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        PIN_box.Text = PIN_box.Text & 4
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PIN_box.Text = PIN_box.Text & 5
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        PIN_box.Text = PIN_box.Text & 6
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        PIN_box.Text = PIN_box.Text & 7
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        PIN_box.Text = PIN_box.Text & 8
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        PIN_box.Text = PIN_box.Text & 9
    End Sub

    Private Sub PIN_box_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    'Clears the PIN entry field
    Private Sub No_Button_Click(sender As System.Object, e As System.EventArgs) Handles No_Button.Click
        PIN_box.Clear()
    End Sub

    'Goes to main menu if entered pin is correct
    Private Sub Go_Button_Click(sender As System.Object, e As System.EventArgs) Handles Go_Button.Click
        If InStr(1, LCase(PIN_box.Text), "1234") <> 0 Then
            mainMenu.Show()
            Me.Hide()
        Else
            PIN_box.Text = "INCORRECT"
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click

    End Sub
End Class