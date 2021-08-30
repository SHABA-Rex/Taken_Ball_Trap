Imports System.IO
Public Class Reglages
    Private Sub accederAuScore_Click(sender As Object, e As EventArgs) Handles accederAuScore.Click
        Scores.labelMonScore.Text = IO.File.ReadAllText(PATH)
        fichierDeScore.Dispose()
        Me.Hide()
        Scores.Focus()
        Scores.Show()
    End Sub

    Private Sub difficulte_Click(sender As Object, e As EventArgs) Handles difficulte.Click
        Me.Hide()
        windowDifficulte.Focus()
        windowDifficulte.Show()
    End Sub

    Private Sub continuer_Click(sender As Object, e As EventArgs) Handles continuer.Click
        Me.Close()
        musiqueChoisieEnFonctionDuNiveauDuJeu()
        uneSeulefois = 1 'Pour permettre de faire reapparaitre le point bonus , lorsqu'on aura shooter toutes les cases.
        onAouvertLesReglages = False 'Cette variable va nous permettre de donner le focus a la fenetre des reglages, toute la duree pendant laquelle cette fenetre sera ouverte. 
        Form1.bonus.Location = copieDuPointBonus 'Repositionner le point bonus.
        Form1.bonus.Hide()

        'Recommençons le timer :
        tempsDeSurvie = DureeDeSurvie
        Form1.diminuerLeTempsDeSurvie.Start()

        For compteur = 0 To 119
            'ICI ON REPOSITIONNE LES CASES DANS L'ESPACE DE JEU.
            If (tableauDesCasesDeLaCarte(compteur).Location.Equals(pointQuelquonque)) Then
                tableauDesCasesDeLaCarte(compteur).Location = tableau2DesCasesDeLaCarte(compteur)
                tableauDesCasesDeLaCarte(compteur).Show()
            End If
        Next

        'Repositioner les kamikazes, et on reinitialise le nombre d'enemis restants.
        positionnerLesKamikazesAuDebutDuJeu(Form1.enemi5)
        positionnerLesKamikazesAuDebutDuJeu(Form1.enemi6)
        positionnerLesKamikazesAuDebutDuJeu(Form1.enemi4)
        positionnerLesKamikazesAuDebutDuJeu(Form1.enemi3)
        positionnerLesKamikazesAuDebutDuJeu(Form1.enemi2)
        EnemisRestant = 5
        Form1.nombreDenemiRestant.Text = EnemisRestant
        Form1.progressBarDesCasesShooter.Value = 0
        'Repositioner les barettes de vie ,  reinitialiser le nombre de barettes vie restantes, reinitialiser la progressBar de vie du panzerJoy
        positionnerLesBarettesDeVieAuDebutDuJeu()
        Form1.healthPointBar.Value = 0
        Form1.pointDeVieRestant.Text = "0%"
        barretteDeVieRestante = 5
        Form1.nombreDeBarreDeVieRestante.Text = barretteDeVieRestante
        'Repositioner barette de bonus 
        uneSeulefois2 = True
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Me.Close()
        Tutorials.Focus()
        Tutorials.Show()
        onAouvertLesReglages = True
    End Sub

    Private Sub help_MouseHover(sender As Object, e As EventArgs) Handles help.MouseHover
        helpLabel.Show()
    End Sub

    Private Sub help_MouseLeave(sender As Object, e As EventArgs) Handles help.MouseLeave
        helpLabel.Hide()
    End Sub
End Class