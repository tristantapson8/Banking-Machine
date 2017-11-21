Public Class cashMain


    'Main Screen
    Private Sub AOS_Click(sender As System.Object, e As System.EventArgs) Handles AOS.Click
        mainMenu.Show()
        Me.Hide()
        Button1.Visible = True
    End Sub

    'Cash 
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
    End Sub
End Class