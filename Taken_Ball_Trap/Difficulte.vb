Public Class windowDifficulte
    Private Sub bouttonFermer_Click(sender As Object, e As EventArgs) Handles bouttonFermer.Click
        Reglages.Focus()
        Me.Close()
        Reglages.Show()
    End Sub

    Private Sub niveauNormal_Click(sender As Object, e As EventArgs) Handles niveauNormal.Click
        'DureeDeSurvie = 60
        'vitesseDuCurseur = 10
        'vitesseDesKamikazes = 210
        numeroDeLaMusiqueAJouer = 1
        parametrerLavitesseDesKamikazesDuCurseurEtLeTimer(60, 10, 150)
        Reglages.Focus()
        Reglages.Show()
        Me.Close()
    End Sub

    Private Sub niveauMoyen_Click(sender As Object, e As EventArgs) Handles niveauMoyen.Click
        'DureeDeSurvie = 90
        'vitesseDuCurseur = 40
        'vitesseDesKamikazes = 150
        numeroDeLaMusiqueAJouer = 2
        parametrerLavitesseDesKamikazesDuCurseurEtLeTimer(100, 50, 95)
        Reglages.Focus()
        Reglages.Show()
        Me.Close()
    End Sub

    Private Sub niveauEleve_Click(sender As Object, e As EventArgs) Handles niveauEleve.Click
        'DureeDeSurvie = 100
        'vitesseDuCurseur = 50
        'vitesseDesKamikazes = 90
        numeroDeLaMusiqueAJouer = 3
        parametrerLavitesseDesKamikazesDuCurseurEtLeTimer(120, 70, 70)
        Reglages.Focus()
        Reglages.Show()
        Me.Close()
    End Sub

    Private Sub niveauImpossible_Click(sender As Object, e As EventArgs) Handles niveauImpossible.Click
        'DureeDeSurvie = 120
        'vitesseDuCurseur = 70
        'vitesseDesKamikazes = 40
        numeroDeLaMusiqueAJouer = 4
        parametrerLavitesseDesKamikazesDuCurseurEtLeTimer(150, 90, 40)
        Reglages.Focus()
        Reglages.Show()
        Me.Close()
    End Sub

End Class