Imports System.ComponentModel
Imports System.IO

Public Class Form1
    'PEUT ETRE AU DEBUT ON VA FAIRE EN SORTE QUE LE KAMIKAZE NE PUISSE BOUGER QUE DANS LES ESPACES VIDES
    'MAIS PLUSTARD POUR UN NIVEAU DE DIFFICULTE PLUS ELEVES ALORS LE KAMIKAZE POURRA SE DEPLACER A TRAVERS LES CASES SANS ETRE LIMITES
    'CONSERVE LA COPIE RECENTE4, IL FAUT PLUSIEURS ENEMIS , PLUSIEURS KAMIKAZES RAJOUTE EN .


    Private Sub Form1_KeyDown(sender As Object, evenement As KeyEventArgs) Handles Me.KeyDown
        If (onAouvertLesReglages) Then 'ICI ON DONNE LE FOCUS A LA FENETRE DE REGLAGES , LORSQUE LE TIMER S'EST ARRETER OU QUE LE PANZERJOY A PERDU.
            Reglages.Focus()
            Scores.Focus()
            windowDifficulte.Focus()
            Tutorials.Focus()
        Else
            Me.Focus()
        End If


        If (evenement.KeyCode = Keys.Right Or evenement.KeyCode = Keys.D) Then
            mouvementDeLaLimite1 = "droite"
        ElseIf (evenement.KeyCode = Keys.Left Or evenement.KeyCode = Keys.Q Or evenement.KeyCode = Keys.A)
            mouvementDeLaLimite1 = "gauche"
        ElseIf (evenement.KeyCode = Keys.Down Or evenement.KeyCode = Keys.S)
            mouvementDeLaLimite1 = "bas"
        ElseIf (evenement.KeyCode = Keys.Up Or evenement.KeyCode = Keys.Z Or evenement.KeyCode = Keys.W)
            mouvementDeLaLimite1 = "haut"
        End If

        limiterLesDeplacementsDuPanzerJoySurLespaceAutoriser()

        If (evenement.KeyCode = Keys.Right Or evenement.KeyCode = Keys.D) Then
            If (deplacerLePanzerJoyaDroite) Then
                deplacerPanzerJoyVersDroite()
            End If
        ElseIf (evenement.KeyCode = Keys.Left Or evenement.KeyCode = Keys.Q Or evenement.KeyCode = Keys.A)
            If (deplacerLePanzerJoyAGauche) Then
                deplacerPanzerJoyVersGauche()
            End If
        ElseIf (evenement.KeyCode = Keys.Down Or evenement.KeyCode = Keys.S)
            If (deplacerLePanzerJoyEnBas) Then
                deplacerPanzerJoyVersBas()
            End If
        ElseIf (evenement.KeyCode = Keys.Up Or evenement.KeyCode = Keys.Z Or evenement.KeyCode = Keys.W)
            If (deplacerLePanzerJoyEnHaut) Then
                deplacerPanzerJoyVersHaut()
            End If
        End If

        If (onPeutTirerDeNouveau) Then
            If (evenement.KeyCode = Keys.NumPad3) Then
                etat1 = 1
                continuerLeTirDeLaBalleAllantADroite = True
                activerLeCurseurDroit = True
                desactiverCurseurCarDepasseToutesLimites = False
                TimerDeplacementDroitBalle().Start()
            ElseIf (evenement.KeyCode = Keys.NumPad2)
                etat3 = 1
                continuerLeTirDeLaBalleVersLeBas = True
                activerLeCurseurBas = True
                desactiverCurseurCarDepasseToutesLimites = False
                TimerDeplacementVersLeBasDeLaBalle().Start()
            ElseIf (evenement.KeyCode = Keys.NumPad1)
                etat2 = 1
                continuerLeTirDeLaBalleAllantAGauche = True
                activerLeCurseurGauche = True
                desactiverCurseurCarDepasseToutesLimites = False
                TimerDeplacementGaucheBalle().Start()
            ElseIf (evenement.KeyCode = Keys.NumPad5)
                etat4 = 1
                continuerLeTirDeLaBalleVersLeHaut = True
                activerLeCurseurHaut = True
                desactiverCurseurCarDepasseToutesLimites = False
                TimerDeplacementVersLeHautDeLaBalle.Start()
            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cheminDaccesSansLeNomDuFichier As String = Application.StartupPath

        'listeDeTimers.Add(TimerDeplacementDroitBalle)
        'listeDeTimers.Add(TimerDeplacementGaucheBalle)
        'listeDeTimers.Add(TimerDeplacementVersLeBasDeLaBalle)
        'listeDeTimers.Add(TimerDeplacementVersLeHautDeLaBalle)
        'listeDeTimers.Add(leKamikazeAttaqueParL_Horizontale)
        'listeDeTimers.Add(leKamikazeAttaqueParLaVerticale)
        'listeDeTimers.Add(leKamikaze5AttaqueParL_Horizontale)
        'listeDeTimers.Add(leKamikaze5AttaqueParLaVerticale)
        'listeDeTimers.Add(leKamikaze4AttaqueParL_Horizontale)
        'listeDeTimers.Add(leKamikaze4AttaqueParLaVerticale)
        'listeDeTimers.Add(leKamikaze3AttaqueParL_Horizontale)
        'listeDeTimers.Add(leKamikaze3AttaqueParLaVerticale)
        'listeDeTimers.Add(leKamikaze2AttaqueParL_Horizontale)
        'listeDeTimers.Add(leKamikaze2AttaqueParLaVerticale)
        'listeDeTimers.Add(diminuerLeTempsDeSurvie)
        'listeDeTimers.Add(monterOuDescendrePanneau)

        'On a trouver une methode , on faire jouer la musique dans une autre fenêtre , et on va lancer l'executable à partir de cette fenêtre ci .
        'Process start.
        'Process stop .
        'My.Computer.Audio.Play("C:\Users\ARMAND COLLINS MBA\Desktop\Taken_Ball_Trap\Taken_Ball_Trap\bin\Debug\niveauNormal.wav")
        'Shell("C:\Users\ARMAND COLLINS MBA\Desktop\Taken_Ball_Trap\Taken_Ball_Trap\bin\Debug\jouerLaMusique.exe")
        'System.Diagnostics.Process.Start("C:\Users\ARMAND COLLINS MBA\Desktop\Taken_Ball_Trap\Taken_Ball_Trap\bin\Debug\jouerLaMusique.exe")

        '##
        'Cette ligne permet de creer ou d'ouvrir le fichier=cheminAccesMusiqueNiveauNormal.txt, dans lequel on aura mis le chemin d'acces à la musique du niveau normal, pour que
        'La fentre jouerLaMusique lorsqu'elle va se load , alors elle ouvrira ce fichier et ensuite recupèrera le chemin d'accès de la musique
        'Et enfin elle jouera la musique.Evidement tout ceci lorsque le processus d'ouverture de la fenetre jouerLaMUsique sera lancé. 
        Try
            Dim locationMusiqueNiveauNormal As FileStream = New IO.FileStream("cheminAccesMusiqueNiveauNormal.txt", IO.FileMode.OpenOrCreate)
            locationMusiqueNiveauNormal.Dispose()
            Dim locationMusiqueNiveauMoyen As FileStream = New IO.FileStream("cheminAccesMusiqueNiveauMoyen.txt", IO.FileMode.OpenOrCreate)
            locationMusiqueNiveauMoyen.Dispose()
            Dim locationMusiqueNiveauElever As FileStream = New IO.FileStream("cheminAccesMusiqueNiveauElever.txt", IO.FileMode.OpenOrCreate)
            locationMusiqueNiveauElever.Dispose()
            Dim locationMusiqueNiveauImpossible As FileStream = New IO.FileStream("cheminAccesMusiqueNiveauImpossible.txt", IO.FileMode.OpenOrCreate)
            locationMusiqueNiveauImpossible.Dispose()
            'Dim locationDeExecutableDesMusiquesDuJeu As FileStream = New IO.FileStream("cheminAccesDeExecutableDesMusiquesDuJeu.txt", IO.FileMode.OpenOrCreate)
            'locationDeExecutableDesMusiquesDuJeu.Dispose()
            IO.File.WriteAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt", cheminDaccesSansLeNomDuFichier)
        Catch ex As Exception
            MsgBox("Desolé une erreur s'est produite :Erreur sur les chemins d'accès.", vbExclamation)
            Me.Dispose()
        End Try

        cheminAccesDeExecutableDesMusiquesDuJeu = IO.File.ReadAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt")
        '##
        'System.Diagnostics.Process.Start("C:\Users\ARMAND COLLINS MBA\Desktop\Taken_Ball_Trap\Taken_Ball_Trap\bin\Debug\jouerLaMusique.exe")
        jouerOuArreterLaMusiqueDuNiveauNormal(True)
        'jouerOuArreterLaMusiqueDuNiveauMoyen(True)
        'jouerOuArreterLaMusiqueDuNiveauElever(True)
        'jouerOuArreterLaMusiqueDuNiveauImpossible(True)

        copieDuPointBonus = bonus.Location
        'tableau2DesCasesDeLaCarte(0) = case1.Location
        For compteur = 0 To 119
            tableau2DesCasesDeLaCarte(compteur) = tableauDesCasesDeLaCarte(compteur).Location
        Next

        diminuerLeTempsDeSurvie.Start()
        'ICI ON CREE OU OUVRE DES FICHIERS QUI VONT NOUS PERMETTRE DE STOCKER LES CHEMINS D'ACESS VERS LES MUSIQUES DU JEU
        'fichierSonore1 = New IO.FileStream("fichierSonore1.txt", IO.FileMode.OpenOrCreate)
        'fichierSonore1.Dispose()
        File.WriteAllText("fichierSonore1.txt", cheminDaccesSansLeNomDuFichier + "\sonMouvementKamikaze.wav")
        sonProduitParImpactDuKamikaze = IO.File.ReadAllText("fichierSonore1.txt")
        '################################
        'fichierSonore2 = New IO.FileStream("fichierSonore2.txt", IO.FileMode.OpenOrCreate)
        'fichierSonore2.Dispose()
        File.WriteAllText("fichierSonore2.txt", cheminDaccesSansLeNomDuFichier + "\musiqueBaretteDeVie.wav")
        sonProduitParRecuperationDeBaretteDeVie = IO.File.ReadAllText("fichierSonore2.txt")
        '################################


        fichierDeScore = New IO.FileStream("monScore.txt", IO.FileMode.OpenOrCreate)
        fichierDeScore.Dispose()


        Try
            monScore = IO.File.ReadAllText(PATH)
        Catch ex As InvalidCastException
            monScore = 0
            fichierDeScore.Dispose()
        End Try


        'positionnerAleatoirementLePanzerJoyAuDebutDuJeu()

        positionnerLesBarettesDeVieAuDebutDuJeu()
        baretteDeVie6.Location = pointQuelquonque
        Label5.Text = "Largeur : " & Width & "Hauteur : " & Height
        positionDuPanneauDesItems.X = 0
        positionDuPanneauDesItems.Y = 730
        PanneauDesItems.Location = positionDuPanneauDesItems
        'case1.Hide()

        deplacerLeCurseurVersLaDroite()

        For Each elmts In tableauDesCasesDeLaCarte
            elmts.Text = ""
        Next

        positionnerLesKamikazesAuDebutDuJeu(enemi5)
        positionnerLesKamikazesAuDebutDuJeu(enemi6)
        positionnerLesKamikazesAuDebutDuJeu(enemi4)
        positionnerLesKamikazesAuDebutDuJeu(enemi3)
        positionnerLesKamikazesAuDebutDuJeu(enemi2)

        'unPoint2 = case46.Location 'FAIRE UNE SELECTION ALEATOIRE DE POSITION DU KAMIKAZE ICI OUN MEME DES KAMIKAZES
        'unPoint2.Y += 39 '39
        ''unPoint2.X += 129
        'unPoint2.X += 39
        'enemi4.Location = unPoint2

        'unPoint2 = case50.Location 'FAIRE UNE SELECTION ALEATOIRE DE POSITION DU KAMIKAZE ICI OUN MEME DES KAMIKAZES
        'unPoint2.Y += 39 '39
        ''unPoint2.X += 129
        'unPoint2.X += 39
        'enemi4.Location = unPoint2

        progressBarDesCasesShooter.Maximum = tableauDesCasesDeLaCarte.Length - 1

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
    Private Sub TimerDeplacementDroitBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementDroitBalle.Tick

        If Not (desactiverCurseurCarDepasseToutesLimites) Then
            If (activerLeCurseurDroit) And Not (leCurseurAtilAtteintUneCaseEntirantVersLaDroite(positionLimite1Curseur)) Then ' (positionLimite1Curseur.X <> positionCase10.X) Then
                deplacerLeCurseurVersLaDroite()
            Else
                activerLeCurseurDroit = False
            End If
            tirerLaBalleVersLaDroite()
        End If
    End Sub
    Private Sub TimerDeplacementGaucheBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementGaucheBalle.Tick

        Dim positionCase1 As Point = case46.Location
        If Not (desactiverCurseurCarDepasseToutesLimites) Then
            If (activerLeCurseurGauche) And Not (leCurseurAtilAtteintUneCaseEntirantVersLaGauche(positionLimite1Curseur)) Then '(positionLimite1Curseur.X <> positionCase1.X) Then 
                deplacerLeCurseurVersLaGauche()
                Label95.Text = "Abscisse : " & positionLimite1Curseur.X & " Ordonnee : " & positionLimite1Curseur.Y
            Else
                activerLeCurseurGauche = False
                Label95.Text = activerLeCurseurGauche
            End If
            tirerLaBalleVersLaGauche()
        End If

    End Sub
    Private Sub TimerDeplacementVersLeBasDeLaBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementVersLeBasDeLaBalle.Tick

        Dim caseAatteindre As Point = case63.Location
        If Not (desactiverCurseurCarDepasseToutesLimites) Then
            If (activerLeCurseurBas) And Not (leCurseurAtilAtteintUneCaseEntirantVersLeBas(positionLimite1Curseur)) Then
                deplacerLeCurseurVersLeBas()
            Else
                activerLeCurseurBas = False
            End If

            tirerLaBalleVersLeBas()
        End If

    End Sub
    Private Sub TimerDeplacementVersLeHautDeLaBalle_Tick(sender As Object, e As EventArgs) Handles TimerDeplacementVersLeHautDeLaBalle.Tick
        'La PROCEDURE verifierSiLaBalleToucheSaCibleSurLeHaut() est lier à ce timer.
        'En effet  le curseur arretera de se deplacer lorsqu'il aura atteint la case designé comme caseAatteindre. 
        'Donc tant qu'il n'a pas atteint la case en question il s'arrete pas.
        'Lorsqu'il aura atteint la case, ceci signifiera qu'au niveau de la procedure (verifier...) on peut activer la condition
        'qui fera dispararaitre et la case toucher(caseAatteindre) et le curseur et la balle.
        'Donc la condition de la procedure verifier... ne s'activera que si le deplacement du curseur est desactiver.(activerCurseurHaut=False)

        Dim caseAatteindre As Point = case34.Location
        If Not (desactiverCurseurCarDepasseToutesLimites) Then
            'positionLimite1Curseur.Y <> caseAatteindre.Y 
            If (activerLeCurseurHaut) And Not (leCurseurAtilAtteintUneCaseEntirantVersLeHaut(positionLimite1Curseur)) Then
                deplacerLeCurseurVersLeHaut()
            Else
                activerLeCurseurHaut = False
            End If

            tirerLaBalleVersLeHaut()
        End If

    End Sub
    'Private Sub PanneauDesItems_Click(sender As Object, e As EventArgs)
    '    monterOuDescendrePanneau.Start()
    'End Sub
    Private Sub leKamikazeAttaqueParL_HorizontaleTick(sender As Object, e As EventArgs) Handles leKamikazeAttaqueParL_Horizontale.Tick
        'Ici le kamikaze va suivre le panzerJoy sur l'horizontale 
        'mais si le panzerJoy se deplace plustard sur la verticale alors la ConditionI va nous permettre de changer la direction 
        'et de se deplacer sur la verticale en activant le timer de la verticale et en desactivant le timer de l'horizontale.

        leKamikazeAttaqueSurL_horizontale()

        If (enemi6.Location.X < lim3.Location.X) And (enemi6.Location.X > lim4.Location.X) And ((panzerJoy.Location.Y < enemi6.Location.Y) Or (panzerJoy.Location.Y > enemi6.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par le haut ou le bas.
            'ConditionI
            leKamikazeAttaqueParLaVerticale.Start()
            leKamikazeAttaqueParL_Horizontale.Stop()
        End If


    End Sub
    Private Sub leKamikazeAttaqueParLaVerticale_Tick(sender As Object, e As EventArgs) Handles leKamikazeAttaqueParLaVerticale.Tick
        'Ici le kamikaze va suivre le panzerJoy sur l'horizontale 
        'mais si le panzerJoy se deplace plustard sur la verticale alors la ConditionII va nous permettre de changer la direction 
        'et de se deplacer sur la verticale en activant le timer de la verticale et en desactivant le timer de l'horizontale.

        leKamikazeAttaqueSurLaVerticale()
        If (enemi6.Location.Y < lim3.Location.Y) And (enemi6.Location.Y > lim2.Location.Y) And ((panzerJoy.Location.X < enemi6.Location.X) Or (panzerJoy.Location.X > enemi6.Location.X)) Then
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            'ConditionII
            leKamikazeAttaqueParL_Horizontale.Start()
            leKamikazeAttaqueParLaVerticale.Stop()
        End If

    End Sub
    Private Sub leKamikaze5AttaqueParL_Horizontale_Tick(sender As Object, e As EventArgs) Handles leKamikaze5AttaqueParL_Horizontale.Tick

        leKamikaze5AttaqueSurL_horizontale()
        If (enemi5.Location.X < lim3.Location.X) And (enemi5.Location.X > lim4.Location.X) And ((panzerJoy.Location.Y < enemi5.Location.Y) Or (panzerJoy.Location.Y > enemi5.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par le haut ou le bas.
            'ConditionI
            leKamikaze5AttaqueParLaVerticale.Start()
            leKamikaze5AttaqueParL_Horizontale.Stop()
        End If

    End Sub
    Private Sub leKamikaze5AttaqueParLaVerticale_Tick(sender As Object, e As EventArgs) Handles leKamikaze5AttaqueParLaVerticale.Tick

        leKamikaze5AttaqueSurLaVerticale()
        If (enemi5.Location.Y < lim3.Location.Y) And (enemi5.Location.Y > lim2.Location.Y) And ((panzerJoy.Location.X < enemi5.Location.X) Or (panzerJoy.Location.X > enemi5.Location.X)) Then
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            'ConditionII
            leKamikaze5AttaqueParL_Horizontale.Start()
            leKamikaze5AttaqueParLaVerticale.Stop()
        End If

    End Sub

    Private Sub leKamikaze4AttaqueParL_Horizontale_Tick(sender As Object, e As EventArgs) Handles leKamikaze4AttaqueParL_Horizontale.Tick

        leKamikaze4AttaqueSurL_horizontale()
        If (enemi4.Location.X < lim3.Location.X) And (enemi4.Location.X > lim4.Location.X) And ((panzerJoy.Location.Y < enemi4.Location.Y) Or (panzerJoy.Location.Y > enemi4.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par le haut ou le bas.
            'ConditionI
            leKamikaze4AttaqueParLaVerticale.Start()
            leKamikaze4AttaqueParL_Horizontale.Stop()
        End If

    End Sub
    Private Sub leKamikaze4AttaqueParLaVerticale_Tick(sender As Object, e As EventArgs) Handles leKamikaze4AttaqueParLaVerticale.Tick

        leKamikaze4AttaqueSurLaVerticale()
        If (enemi4.Location.Y < lim3.Location.Y) And (enemi4.Location.Y > lim2.Location.Y) And ((panzerJoy.Location.X < enemi4.Location.X) Or (panzerJoy.Location.X > enemi4.Location.X)) Then
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            'ConditionII
            leKamikaze4AttaqueParL_Horizontale.Start()
            leKamikaze4AttaqueParLaVerticale.Stop()
        End If

    End Sub

    Private Sub leKamikaze3AttaqueParL_Horizontale_Tick(sender As Object, e As EventArgs) Handles leKamikaze3AttaqueParL_Horizontale.Tick

        leKamikaze3AttaqueSurL_horizontale()
        If (enemi3.Location.X < lim3.Location.X) And (enemi3.Location.X > lim4.Location.X) And ((panzerJoy.Location.Y < enemi3.Location.Y) Or (panzerJoy.Location.Y > enemi3.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par le haut ou le bas.
            'ConditionI
            leKamikaze3AttaqueParLaVerticale.Start()
            leKamikaze3AttaqueParL_Horizontale.Stop()
        End If

    End Sub

    Private Sub leKamikaze3AttaqueParLaVerticale_Tick(sender As Object, e As EventArgs) Handles leKamikaze3AttaqueParLaVerticale.Tick

        leKamikaze3AttaqueSurLaVerticale()
        If (enemi3.Location.Y < lim3.Location.Y) And (enemi3.Location.Y > lim2.Location.Y) And ((panzerJoy.Location.X < enemi3.Location.X) Or (panzerJoy.Location.X > enemi3.Location.X)) Then
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            'ConditionII
            leKamikaze3AttaqueParL_Horizontale.Start()
            leKamikaze3AttaqueParLaVerticale.Stop()
        End If

    End Sub

    Private Sub leKamikaze2AttaqueParL_Horizontale_Tick(sender As Object, e As EventArgs) Handles leKamikaze2AttaqueParL_Horizontale.Tick

        leKamikaze2AttaqueSurL_horizontale()
        If (enemi2.Location.X < lim3.Location.X) And (enemi2.Location.X > lim4.Location.X) And ((panzerJoy.Location.Y < enemi2.Location.Y) Or (panzerJoy.Location.Y > enemi2.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par le haut ou le bas.
            'ConditionI
            leKamikaze2AttaqueParLaVerticale.Start()
            leKamikaze2AttaqueParL_Horizontale.Stop()
        End If

    End Sub

    Private Sub leKamikaze2AttaqueParLaVerticale_Tick(sender As Object, e As EventArgs) Handles leKamikaze2AttaqueParLaVerticale.Tick

        leKamikaze2AttaqueSurLaVerticale()
        If (enemi2.Location.Y < lim3.Location.Y) And (enemi2.Location.Y > lim2.Location.Y) And ((panzerJoy.Location.X < enemi2.Location.X) Or (panzerJoy.Location.X > enemi2.Location.X)) Then
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            'ConditionII
            leKamikaze2AttaqueParL_Horizontale.Start()
            leKamikaze2AttaqueParLaVerticale.Stop()
        End If

    End Sub

    Private Sub diminuerLeTempsDeSurvie_Tick(sender As Object, e As EventArgs) Handles diminuerLeTempsDeSurvie.Tick
        afficheDeSurvie1.Visible = True
        afficheDeSurvie2.Visible = True
        tempsDeSurvie -= 1
        afficheDeSurvie2.Text = tempsDeSurvie & " s"
        If (tempsDeSurvie = 0) Then
            diminuerLeTempsDeSurvie.Stop()
            ceQuonFaitLorsquonGagne()
            leTempsEstFiniLePanzerJoyPerdSi()
        End If
    End Sub

    Private Sub PanneauDesItems_Click(sender As Object, e As EventArgs) Handles PanneauDesItems.Click
        pointDeVieRestant.ForeColor = Color.Lime
        monterOuDescendrePanneau.Start()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If (onAouvertLesReglages) Then
            Reglages.Focus()
            Scores.Focus()
            windowDifficulte.Focus()
            Tutorials.Focus()
        Else
            Me.Focus()
        End If
    End Sub

    'Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    arreterLaMusiqueEnCours()
    '    'jouerOuArreterLaMusiqueDuNiveauNormal(False)
    '    'jouerOuArreterLaMusiqueDuNiveauMoyen(False)
    '    'jouerOuArreterLaMusiqueDuNiveauElever(False)
    '    'jouerOuArreterLaMusiqueDuNiveauImpossible(False)
    'End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        arreterLaMusiqueEnCours()
    End Sub

    Private Sub bouttonPause_Click(sender As Object, e As EventArgs) Handles bouttonPause.Click
        Select Case etatDuJeu
            Case "Pause"
                etatDuJeu = "Play"
                For Each elmt In listeDeTimers
                    elmt.Stop()
                Next
            Case "Play"
                etatDuJeu = "Pause"
                For Each elmt In listeDeTimers
                    elmt.Start()
                Next
        End Select
    End Sub
End Class

