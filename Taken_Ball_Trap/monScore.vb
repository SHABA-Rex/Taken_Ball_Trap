Public Class Scores
    Private Sub bouttonFermer_Click(sender As Object, e As EventArgs) Handles bouttonFermer.Click
        Reglages.Focus()
        Me.Close()
        Reglages.Show()
    End Sub
End Class