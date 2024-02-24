Public Class MathProblemDisplayer
    Private Sub BtnAnswer_Click(sender As Object, e As EventArgs) Handles BtnAnswer.Click
        Label1.Text = "99 + 1986 = 2085"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Label1.Text = "99 + 1986 = ??"
    End Sub
End Class

