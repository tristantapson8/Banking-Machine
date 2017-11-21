Public Class cashReceipt

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Button13.Visible = False
        If Button10.Visible = False Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Button10.Visible = False
        If Button13.Visible = False Then
            Me.Hide()
        End If
    End Sub

End Class