Public Class quickWithdraw

    Friend withdraw20_Clicked As Boolean = False
    Friend withdraw40_Clicked As Boolean = False
    Friend withdraw60_Clicked As Boolean = False
    Friend withdraw80_Clicked As Boolean = False
    Friend withdraw100_Clicked As Boolean = False
    Friend withdraw200_Clicked As Boolean = False


    Private Sub quickWithdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'AMMOUNT_box.Text = AMMOUNT_box.Text & 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

    End Sub

    Private Sub withdraw20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw20.Click
        withdraw20_Clicked = True

        If mainMenu.Chequeing_Amount >= 20 Then
            mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - 20
            withdraw20_Clicked = False
            validWithdrawal.Show()
            Me.Hide()
        Else
            withdraw20_Clicked = False
            invalidWithdrawal.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub withdraw40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw40.Click
        withdraw40_Clicked = True

        If mainMenu.Chequeing_Amount >= 40 Then
            mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - 40
            withdraw40_Clicked = False
            validWithdrawal.Show()
            Me.Hide()
        Else
            withdraw40_Clicked = False
            invalidWithdrawal.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub withdraw60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw60.Click
        withdraw60_Clicked = True

        If mainMenu.Chequeing_Amount >= 60 Then
            mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - 60
            withdraw60_Clicked = False
            validWithdrawal.Show()
            Me.Hide()
        Else
            withdraw60_Clicked = False
            invalidWithdrawal.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub withdraw80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw80.Click
        withdraw80_Clicked = True

        If mainMenu.Chequeing_Amount >= 80 Then
            mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - 80
            withdraw80_Clicked = False
            validWithdrawal.Show()
            Me.Hide()
        Else
            withdraw80_Clicked = False
            invalidWithdrawal.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub withdraw100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw100.Click
        withdraw100_Clicked = True

        If mainMenu.Chequeing_Amount >= 100 Then
            mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - 100
            withdraw100_Clicked = False
            validWithdrawal.Show()
            Me.Hide()
        Else
            withdraw100_Clicked = False
            invalidWithdrawal.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub withdraw200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw200.Click
        withdraw200_Clicked = True

        If mainMenu.Chequeing_Amount >= 200 Then
            mainMenu.Chequeing_Amount = mainMenu.Chequeing_Amount - 200
            withdraw200_Clicked = False
            validWithdrawal.Show()
            Me.Hide()
        Else
            withdraw200_Clicked = False
            invalidWithdrawal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        mainMenu.Show()
        Me.Hide()
    End Sub
End Class