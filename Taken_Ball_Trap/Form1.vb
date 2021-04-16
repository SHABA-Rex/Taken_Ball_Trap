Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, evenement As KeyEventArgs) Handles Me.KeyDown

        If (evenement.KeyCode = Keys.Right) Then
            mouvementDeLaLimite1 = "droite"
        ElseIf (evenement.KeyCode = Keys.Left)
            mouvementDeLaLimite1 = "gauche"
        ElseIf (evenement.KeyCode = Keys.Down)
            mouvementDeLaLimite1 = "bas"
        ElseIf (evenement.KeyCode = Keys.Up)
            mouvementDeLaLimite1 = "haut"
        End If

        limiterLesDeplacementsDuPanzerJoySurLespaceAutoriser()


        If (evenement.KeyCode = Keys.Right) Then
            If (deplacerLePanzerJoyaDroite) Then
                deplacerPanzerJoyVersDroite()
            End If
        ElseIf (evenement.KeyCode = Keys.Left)
            If (deplacerLePanzerJoyAGauche) Then
                deplacerPanzerJoyVersGauche()
            End If
        ElseIf (evenement.KeyCode = Keys.Down)
            If (deplacerLePanzerJoyEnBas) Then
                deplacerPanzerJoyVersBas()
            End If
        ElseIf (evenement.KeyCode = Keys.Up)
            If (deplacerLePanzerJoyEnHaut) Then
                deplacerPanzerJoyVersHaut()
            End If
        End If

        If (evenement.KeyCode = Keys.NumPad3) Then
            etat1 = 1
            continuerLeTirDeLaBalleAllantADroite = True
            activerLeCurseurDroit = True
            TimerDeplacementDroitBalle().Start()
        ElseIf (evenement.KeyCode = Keys.NumPad2)
            etat3 = 1
            continuerLeTirDeLaBalleVersLeBas = True
            activerLeCurseurBas = True
            TimerDeplacementVersLeBasDeLaBalle().Start()
        ElseIf (evenement.KeyCode = Keys.NumPad1)
            etat2 = 1
            continuerLeTirDeLaBalleAllantAGauche = True
            activerLeCurseurGauche = True
            TimerDeplacementGaucheBalle().Start()
        ElseIf (evenement.KeyCode = Keys.NumPad5)
            etat4 = 1
            continuerLeTirDeLaBalleVersLeHaut = True
            activerLeCurseurHaut = True
            TimerDeplacementVersLeHautDeLaBalle.Start()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Largeur : " & Width & "Hauteur : " & Height
        positionDuPanneauDesItems.X = 0
        positionDuPanneauDesItems.Y = 730
        PanneauDesItems.Location = positionDuPanneauDesItems
        case1.Hide()
        deplacerLeCurseurVersLaDroite()

        'deplacerLeCurseurVersLaGauche()
    End Sub

    Private Sub monterOuDescendrePanneau_Tick(sender As Object, e As EventArgs) Handles monterOuDescendrePanneau.Tick
        faireMonterOuDescendrePanneauDesItems()
        Label26.Text = directionDuPanneau

        If (directionDuPanneau = "descend") Then
            positionDuPanneauDesItems.Y += 10
            PanneauDesItems.Location = positionDuPanneauDesItems
            activer = False
        ElseIf (directionDuPanneau = "monte") Then
            positionDuPanneauDesItems.Y -= 10
            PanneauDesItems.Location = positionDuPanneauDesItems
            activer = False
        End If

        lepAnneauNeDoitPasDepasserLeslImites()

    End Sub

    Private Sub PanneauDesItems_Click(sender As Object, e As EventArgs) Handles PanneauDesItems.Click
        monterOuDescendrePanneau.Start()
    End Sub

    Private Sub TimerDeplacementDroitBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementDroitBalle.Tick

        Dim positionCase10 As Point = case5.Location
        tirerLaBalleVersLaDroite()


        If (activerLeCurseurDroit) And (positionLimite1Curseur.X <> positionCase10.X) Then
            deplacerLeCurseurVersLaDroite()
        Else
            activerLeCurseurDroit = False
        End If

    End Sub

    Private Sub TimerDeplacementGaucheBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementGaucheBalle.Tick

        Dim positionCase1 As Point = case16.Location
        tirerLaBalleVersLaGauche()

        If (activerLeCurseurGauche) And (positionLimite1Curseur.X <> positionCase1.X) Then
            deplacerLeCurseurVersLaGauche()
        Else
            activerLeCurseurGauche = False
        End If
    End Sub

    Private Sub TimerDeplacementVersLeBasDeLaBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementVersLeBasDeLaBalle.Tick

        tirerLaBalleVersLeBas()

        Dim caseAatteindre As Point = case19.Location

        If (activerLeCurseurBas) And (positionLimite1Curseur.Y <> caseAatteindre.Y) Then
            deplacerLeCurseurVersLeBas()
        Else
            activerLeCurseurBas = False
        End If

    End Sub

    Private Sub TimerDeplacementVersLeHautDeLaBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementVersLeHautDeLaBalle.Tick

        tirerLaBalleVersLeHaut()

        Dim caseAatteindre As Point = case4.Location

        If (activerLeCurseurHaut) And (positionLimite1Curseur.Y <> caseAatteindre.Y) Then
            deplacerLeCurseurVersLeHaut()
        Else
            activerLeCurseurHaut = False
        End If
    End Sub
End Class

