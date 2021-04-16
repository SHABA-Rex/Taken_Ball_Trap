Module lesFonctions

    Friend Sub deplacerPanzerVersLaDroite()

        If (activerUneSeulFois2 = 0) Then
            'Ici on doit bien positionner le canon , les turbos , le corps ,pourqu'ils avancent ou recule, en bref on les bascules vers la droite.
            Form1.corpsDuPanzer.Width = 10
            Form1.corpsDuPanzer.Height = 59

            positionTurbo1DuPanzer = Form1.corpsDuPanzer.Location
            positionTurbo2DuPanzer = positionTurbo1DuPanzer
            positionCanonDuPanzer = positionTurbo1DuPanzer
            positionTurbo2DuPanzer.Y += 49
            positionCanonDuPanzer.Y += 24
            positionTurbo1DuPanzer.X -= 7
            positionTurbo2DuPanzer.X -= 7
            positionCanonDuPanzer.X += 7

            'positionCorpsDuPanzer.X += 6

            verifierSiLeCharTraverseLimiteBasseEnAllantAGaucheOuDroite()
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            activerUneSeulFois = 0 'On peut revenir vers la gauche avec ça.
            activerUneSeulFois3 = 0
            activerUneSeulFois4 = 0
            activerUneSeulFois2 = 1
        End If

        If (Form1.canonPanzer.Location.X < limiteDroite) Then
            positionTurbo1DuPanzer.X += pasDeDeplacementDuPanzer
            positionTurbo2DuPanzer.X += pasDeDeplacementDuPanzer
            positionCanonDuPanzer.X += pasDeDeplacementDuPanzer
            positionCorpsDuPanzer.X += pasDeDeplacementDuPanzer

            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
        End If

    End Sub
    Friend Sub tirerLaBalleVersLaDroite()
        If (positionDeLaBallePanzerJoy.X < limiteDroite) And continuerLeTirDeLaBalleAllantADroite Then
            positionDeLaBallePanzerJoy.X += 5
            Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLaDroite()
        End If
    End Sub
    Public Sub tirerLaBalleVersLaGauche()
        If (positionDeLaBallePanzerJoy.X > 0) And continuerLeTirDeLaBalleAllantAGauche Then
            positionDeLaBallePanzerJoy.X -= 5
            Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLaGauche()
        End If
    End Sub
    Friend Sub tirerLaBalleVersLeBas()
        If (positionDeLaBallePanzerJoy.Y < limiteBas + 43) And continuerLeTirDeLaBalleVersLeBas Then
            positionDeLaBallePanzerJoy.Y += 5
            Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLeBas()
        End If
    End Sub
    Friend Sub tirerLaBalleVersLeHaut()
        If (positionDeLaBallePanzerJoy.Y > 0) And continuerLeTirDeLaBalleVersLeHaut Then
            positionDeLaBallePanzerJoy.Y -= 5
            Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLeHaut()
        End If
    End Sub

    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaDroite()
        positionLimite1Curseur.X += 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionDeLaBallePanzerJoy.X += 90 'pasDeDeplacementDuPanzer
        positionBaliseBalle.X += 90 'pasDeDeplacementDuPanzer

        positionBalise1Limite1Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.X += 90 'pasDeDeplacementDuPanzer

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
        Form1.baliseBallePanzerJoy.Location = positionBaliseBalle

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur

        Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeBas()
        positionLimite1Curseur.Y += 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionDeLaBallePanzerJoy.Y += 90 'pasDeDeplacementDuPanzer
        positionBaliseBalle.Y += 90 'pasDeDeplacementDuPanzer

        positionBalise1Limite1Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.Y += 90 'pasDeDeplacementDuPanzer

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
        Form1.baliseBallePanzerJoy.Location = positionBaliseBalle

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur

        Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeHaut()
        positionLimite1Curseur.Y -= 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionDeLaBallePanzerJoy.Y -= 90 'pasDeDeplacementDuPanzer
        positionBaliseBalle.Y -= 90 'pasDeDeplacementDuPanzer

        positionBalise1Limite1Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.Y -= 90 'pasDeDeplacementDuPanzer

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
        Form1.baliseBallePanzerJoy.Location = positionBaliseBalle

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur

        Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaGauche()
        positionLimite1Curseur.X -= 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionDeLaBallePanzerJoy.X -= 90 'pasDeDeplacementDuPanzer
        positionBaliseBalle.X -= 90 'pasDeDeplacementDuPanzer

        positionBalise1Limite1Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.X -= 90 'pasDeDeplacementDuPanzer

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
        Form1.baliseBallePanzerJoy.Location = positionBaliseBalle

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur

        Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Friend Sub deplacerPanzerJoyVersDroite()

        If (Form1.lim2.Location.X < limiteDroite) Then

            positionLim1.X += pasDeDeplacementDuPanzer
            positionLim2.X += pasDeDeplacementDuPanzer
            positionLim3.X += pasDeDeplacementDuPanzer
            positionLim4.X += pasDeDeplacementDuPanzer
            positionDuPanzerJoy.X += pasDeDeplacementDuPanzer
            leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaDroite()

            If (positionLim1.Y < positionPointABouffer.Y) And (positionLim2.Y < positionPointABouffer.Y) And (positionLim3.Y > positionPointABouffer.Y) And (positionLim4.Y > positionPointABouffer.Y) And (positionLim1.X < positionPointABouffer.X) And (positionLim2.X > positionPointABouffer.X) And (positionLim3.X > positionPointABouffer.X) And (positionLim4.X < positionPointABouffer.X) Then
                Form1.Label46.Text = "Le point rouge est depasser"
            Else
                Form1.Label46.Text = "Rien"
            End If
            'deplacerLeCurseurVersLaDroite()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4

        End If

    End Sub
    Friend Sub deplacerPanzerJoyVersGauche()
        If (Form1.lim1.Location.X > limiteHautEtGauche) Then

            positionLim1.X -= pasDeDeplacementDuPanzer
            positionLim2.X -= pasDeDeplacementDuPanzer
            positionLim3.X -= pasDeDeplacementDuPanzer
            positionLim4.X -= pasDeDeplacementDuPanzer
            positionDuPanzerJoy.X -= pasDeDeplacementDuPanzer
            leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaGauche()

            If (positionLim1.Y < positionPointABouffer.Y) And (positionLim2.Y < positionPointABouffer.Y) And (positionLim3.Y > positionPointABouffer.Y) And (positionLim4.Y > positionPointABouffer.Y) And (positionLim1.X < positionPointABouffer.X) And (positionLim2.X > positionPointABouffer.X) And (positionLim3.X > positionPointABouffer.X) And (positionLim4.X < positionPointABouffer.X) Then
                Form1.Label46.Text = "Le point rouge est depasser"
            Else
                Form1.Label46.Text = "Rien"
            End If

            'deplacerLeCurseurVersLaGauche()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4

        End If
    End Sub
    Friend Sub deplacerPanzerJoyVersHaut()
        If (Form1.lim1.Location.Y > limiteHautEtGauche) Then
            positionLim1.Y -= pasDeDeplacementDuPanzer
            positionLim2.Y -= pasDeDeplacementDuPanzer
            positionLim3.Y -= pasDeDeplacementDuPanzer
            positionLim4.Y -= pasDeDeplacementDuPanzer
            positionDuPanzerJoy.Y -= pasDeDeplacementDuPanzer
            positionPointABouffer = Form1.pointABouffer.Location
            leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeHaut()

            If (positionLim1.Y < positionPointABouffer.Y) And (positionLim2.Y < positionPointABouffer.Y) And (positionLim3.Y > positionPointABouffer.Y) And (positionLim4.Y > positionPointABouffer.Y) And (positionLim1.X < positionPointABouffer.X) And (positionLim2.X > positionPointABouffer.X) And (positionLim3.X > positionPointABouffer.X) And (positionLim4.X < positionPointABouffer.X) Then
                Form1.Label46.Text = "Le point rouge est depasser"
            Else
                Form1.Label46.Text = "Rien"
            End If
            'deplacerLeCurseurVersLeHaut()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4
        End If

    End Sub
    Friend Sub deplacerPanzerJoyVersBas()

        If (Form1.lim4.Location.Y < limiteBas) Then
            positionLim1.Y += pasDeDeplacementDuPanzer
            positionLim2.Y += pasDeDeplacementDuPanzer
            positionLim3.Y += pasDeDeplacementDuPanzer
            positionLim4.Y += pasDeDeplacementDuPanzer
            positionDuPanzerJoy.Y += pasDeDeplacementDuPanzer
            leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeBas()

            If (positionLim1.Y < positionPointABouffer.Y) And (positionLim2.Y < positionPointABouffer.Y) And (positionLim3.Y > positionPointABouffer.Y) And (positionLim4.Y > positionPointABouffer.Y) And (positionLim1.X < positionPointABouffer.X) And (positionLim2.X > positionPointABouffer.X) And (positionLim3.X > positionPointABouffer.X) And (positionLim4.X < positionPointABouffer.X) Then
                Form1.Label46.Text = "Le point rouge est depasser"
            Else
                Form1.Label46.Text = "Rien"
            End If

            'deplacerLeCurseurVersLeBas()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4
        End If

    End Sub

    Friend Sub deplacerLeCurseurVersLaDroite()
        If (cadencer = 1) Then
            positionLimite1Curseur.X += 79 '92
            positionLimite4Curseur.X += 79
            positionLimite2Curseur.X += 90
            positionLimite3Curseur.X += 90
            deplacerLeCurseurVersLaGauche()
            cadencer = 2
        ElseIf (cadencer = 2) Then
            positionLimite1Curseur.X += 90 '92
            positionLimite4Curseur.X += 90
            positionLimite2Curseur.X += 90
            positionLimite3Curseur.X += 90
            nvlVal = positionLimite1Curseur.X '+ 11
            If (nvlVal = Form1.case2.Location.X) Or (nvlVal = Form1.case5.Location.X) Then
                Form1.Label46.Text = "On a toucher le point"
            End If
            'cadencer = 1 51 46
        End If


        'positionLimite2Curseur.X += 
        'positionLimite3Curseur.X +=
        'positionLimite4Curseur.X += 
        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
    End Sub
    Friend Sub deplacerLeCurseurVersLaGauche()
        If (cadencer2 = 1) Then
            positionLimite1Curseur.X -= 79 '92
            positionLimite4Curseur.X -= 79
            positionLimite2Curseur.X -= 90
            positionLimite3Curseur.X -= 90
            cadencer2 = 2
        ElseIf (cadencer2 = 2) Then
            positionLimite1Curseur.X -= 90 '92
            positionLimite4Curseur.X -= 90
            positionLimite2Curseur.X -= 90
            positionLimite3Curseur.X -= 90
            nvlVal = positionLimite1Curseur.X
            If (nvlVal = Form1.case2.Location.X) Or (nvlVal = Form1.case5.Location.X) Then
                Form1.Label46.Text = "On a toucher le point"
            End If
            'cadencer = 1 51 46
        End If

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
    End Sub
    Friend Sub deplacerLeCurseurVersLeBas()
        If (cadencer3 = 1) Then
            'positionLimite1Curseur.Y += 90
            'positionLimite2Curseur.Y += 90
            'positionLimite4Curseur.Y += 90
            'positionLimite3Curseur.Y += 90
            'positionLimite1Curseur.Y += 79 '92
            'positionLimite2Curseur.Y += 79
            'positionLimite4Curseur.Y += 90
            'positionLimite3Curseur.Y += 90
            'positionLimite1Curseur.Y -= 79 '92
            'positionLimite2Curseur.Y -= 79
            'positionLimite4Curseur.Y -= 90
            'positionLimite3Curseur.Y -= 90
            ''nvlVal = positionLimite1Curseur.Y , Si jamais il y'a une erreur sur les deplacements du curseur alors essaye de mettre cette instruction. 
            'deplacerLeCurseurVersLeHaut()
            'deplacerLeCurseurVersLaGauche()
            cadencer3 = 2
        ElseIf (cadencer3 = 2) Then
            positionLimite1Curseur.Y += 90 '92
            positionLimite4Curseur.Y += 90
            positionLimite2Curseur.Y += 90
            positionLimite3Curseur.Y += 90
            nvlVal = positionLimite1Curseur.Y '+ 11
            If (nvlVal = Form1.case19.Location.Y) Then 'Or (nvlVal = Form1.Label75.Location.Y) Then
                Form1.Label46.Text = "On a toucher le point"
            End If
            'cadencer = 1 51 46
        End If

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur

    End Sub
    Friend Sub deplacerLeCurseurVersLeHaut()
        If (cadencer4 = 1) Then
            positionLimite1Curseur.Y -= 90 '92
            positionLimite2Curseur.Y -= 90
            positionLimite4Curseur.Y -= 90
            positionLimite3Curseur.Y -= 90
            nvlVal = positionLimite1Curseur.Y 'Ceci permet de faire disparatitre le curseur. Ici il est tres important.Ne l'enleve pas.
            'deplacerLeCurseurVersLaGauche()
            cadencer4 = 2
        ElseIf (cadencer4 = 2) Then

            positionLimite1Curseur.Y -= 90 '92
            positionLimite4Curseur.Y -= 90
            positionLimite2Curseur.Y -= 90
            positionLimite3Curseur.Y -= 90
            nvlVal = positionLimite1Curseur.Y '+ 11
            If (nvlVal = Form1.case4.Location.Y) Then 'Or (nvlVal = Form1.Label75.Location.Y) Then
                Form1.Label46.Text = "On a toucher le point"
            End If
            'cadencer = 1 51 46
        End If

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur
    End Sub
    Friend Sub deplacerVersLaGauche()

        If (activerUneSeulFois = 0) Then
            'Ici on doit bien positionner le canon , les turbos pourqu'il avance, en bref on les bascules vers la gauche.
            Form1.corpsDuPanzer.Width = 10
            Form1.corpsDuPanzer.Height = 59

            positionTurbo1DuPanzer = Form1.corpsDuPanzer.Location
            positionTurbo2DuPanzer = positionTurbo1DuPanzer
            positionCanonDuPanzer = positionTurbo1DuPanzer
            positionTurbo2DuPanzer.Y += 49
            positionCanonDuPanzer.Y += 24
            positionTurbo1DuPanzer.X += 7
            positionTurbo2DuPanzer.X += 7
            positionCanonDuPanzer.X -= 7

            'positionCorpsDuPanzer.X -= 6
            verifierSiLeCharTraverseLimiteBasseEnAllantAGaucheOuDroite()
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            activerUneSeulFois2 = 0 'On peut revenir vers la droite avec ça.
            activerUneSeulFois = 1
            activerUneSeulFois2 = 0
            activerUneSeulFois3 = 0
            activerUneSeulFois4 = 0
        End If

        If (Form1.canonPanzer.Location.X > limiteHautEtGauche) Then
            positionTurbo1DuPanzer.X -= pasDeDeplacementDuPanzer
            positionTurbo2DuPanzer.X -= pasDeDeplacementDuPanzer
            positionCanonDuPanzer.X -= pasDeDeplacementDuPanzer
            positionCorpsDuPanzer.X -= pasDeDeplacementDuPanzer

            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
        End If
    End Sub
    Friend Sub deplacerVersLeBas()

        If (activerUneSeulFois3 = 0) Then
            Form1.corpsDuPanzer.Width = 59
            Form1.corpsDuPanzer.Height = 10
            'positionCorpsDuPanzer.Y += 59
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
            positionTurbo2DuPanzer = Form1.corpsDuPanzer.Location
            positionTurbo2DuPanzer.Y -= 7
            positionTurbo1DuPanzer = positionTurbo2DuPanzer
            positionTurbo1DuPanzer.X += 49
            positionCanonDuPanzer = positionTurbo2DuPanzer
            positionCanonDuPanzer.X += 24
            positionCanonDuPanzer.Y += 12
            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.canonPanzer.Location = positionCanonDuPanzer
            activerUneSeulFois = 0
            activerUneSeulFois2 = 0
            activerUneSeulFois4 = 0
            activerUneSeulFois3 = 1
        End If

        If (Form1.canonPanzer.Location.Y < limiteBas) Then
            positionTurbo1DuPanzer.Y += pasDeDeplacementDuPanzer
            positionTurbo2DuPanzer.Y += pasDeDeplacementDuPanzer
            positionCanonDuPanzer.Y += pasDeDeplacementDuPanzer
            positionCorpsDuPanzer.Y += pasDeDeplacementDuPanzer

            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
        End If

    End Sub
    Friend Sub deplacerVersLeHaut()
        If (activerUneSeulFois4 = 0) Then
            Form1.corpsDuPanzer.Width = 59
            Form1.corpsDuPanzer.Height = 10

            positionTurbo2DuPanzer = Form1.corpsDuPanzer.Location
            positionTurbo1DuPanzer = positionTurbo2DuPanzer
            positionCanonDuPanzer = positionTurbo2DuPanzer
            positionTurbo1DuPanzer.Y += 8
            positionTurbo2DuPanzer.Y += 8
            positionCanonDuPanzer.X += 24
            positionCanonDuPanzer.Y -= 4
            positionTurbo2DuPanzer.X += 49
            positionCorpsDuPanzer.Y += 3
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
            verifierSiLeCharTraverseLimiteDroiteEnMontant()
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            activerUneSeulFois = 0
            activerUneSeulFois2 = 0
            activerUneSeulFois3 = 0
            activerUneSeulFois4 = 1
        End If

        If (Form1.canonPanzer.Location.Y > limiteHautEtGauche) Then
            positionTurbo1DuPanzer.Y -= pasDeDeplacementDuPanzer
            positionTurbo2DuPanzer.Y -= pasDeDeplacementDuPanzer
            positionCanonDuPanzer.Y -= pasDeDeplacementDuPanzer
            positionCorpsDuPanzer.Y -= pasDeDeplacementDuPanzer

            Form1.turbo1Panzer.Location = positionTurbo1DuPanzer
            Form1.turbo2Panzer.Location = positionTurbo2DuPanzer
            Form1.canonPanzer.Location = positionCanonDuPanzer
            Form1.corpsDuPanzer.Location = positionCorpsDuPanzer
        End If
    End Sub

    Friend Sub verifierSiLeCharTraverseLimiteDroiteEnMontant()

        If (positionCanonDuPanzer.X > limiteDroite And positionCorpsDuPanzer.X > limiteDroite And positionTurbo1DuPanzer.X > limiteDroite And positionTurbo2DuPanzer.X > limiteDroite) Then
            positionCorpsDuPanzer.X -= 49
            positionCanonDuPanzer.X -= 49
            positionTurbo1DuPanzer.X -= 49
            positionTurbo2DuPanzer.X -= 49
        ElseIf (positionCanonDuPanzer.X > limiteDroite And positionTurbo2DuPanzer.X > limiteDroite)
            positionCorpsDuPanzer.X -= 45
            positionCanonDuPanzer.X -= 45
            positionTurbo1DuPanzer.X -= 45
            positionTurbo2DuPanzer.X -= 45
        ElseIf (positionTurbo2DuPanzer.X > limiteDroite)
            positionCorpsDuPanzer.X -= 25
            positionCanonDuPanzer.X -= 25
            positionTurbo1DuPanzer.X -= 25
            positionTurbo2DuPanzer.X -= 25
        End If
    End Sub
    Friend Sub verifierSiLeCharTraverseLimiteBasseEnAllantAGaucheOuDroite()
        If (positionCanonDuPanzer.Y > limiteBas And positionCorpsDuPanzer.Y > limiteBas And positionTurbo1DuPanzer.Y > limiteBas And positionTurbo2DuPanzer.Y > limiteBas) Then
            positionCorpsDuPanzer.Y -= 49
            positionCanonDuPanzer.Y -= 49
            positionTurbo1DuPanzer.Y -= 49
            positionTurbo2DuPanzer.Y -= 49
        ElseIf (positionCanonDuPanzer.Y > limiteBas And positionTurbo2DuPanzer.Y > limiteBas)
            positionCorpsDuPanzer.Y -= 45
            positionCanonDuPanzer.Y -= 45
            positionTurbo1DuPanzer.Y -= 45
            positionTurbo2DuPanzer.Y -= 45
        ElseIf (positionTurbo2DuPanzer.Y > limiteBas)
            positionCorpsDuPanzer.Y -= 20
            positionCanonDuPanzer.Y -= 20
            positionTurbo1DuPanzer.Y -= 20
            positionTurbo2DuPanzer.Y -= 20
        End If
    End Sub
    Friend Sub faireMonterOuDescendrePanneauDesItems()

        If (statutDuPanneauDesItems = "fermer") Then
            directionDuPanneau = "monte"
        ElseIf (statutDuPanneauDesItems = "ouvert") Then
            directionDuPanneau = "descend"
        End If

    End Sub
    Friend Sub lepAnneauNeDoitPasDepasserLeslImites()
        If (Form1.PanneauDesItems.Location.Y = 730) Then

            onArreteLaMonteeOuDescenteDuPanneau = True
            statutDuPanneauDesItems = "fermer"
            activer = False
            Form1.Label5.Text = statutDuPanneauDesItems
            Form1.monterOuDescendrePanneau.Stop()
        ElseIf (Form1.PanneauDesItems.Location.Y = 620) Then

            onArreteLaMonteeOuDescenteDuPanneau = True
            statutDuPanneauDesItems = "ouvert"
            activer = False
            Form1.Label5.Text = statutDuPanneauDesItems
            Form1.monterOuDescendrePanneau.Stop()
        End If
    End Sub

    Friend Sub verifierSiLaBalleToucheSaCibleSurLeHaut()

        Form1.Label47.Text = "ordonnee : " & Form1.case4.Location.Y

        If nvlVal = Form1.case4.Location.Y And (positionDeLaBallePanzerJoy.X > positionLimite4Curseur.X) And (positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            'If (etat3 = 2) Then
            Form1.Label47.Text = "On a toucher la cible."
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location
            positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

            nvlVal = positionLimite1Curseur.Y
            activerLeCurseurHaut = False
            continuerLeTirDeLaBalleVersLeHaut = False
            Form1.TimerDeplacementVersLeHautDeLaBalle.Stop()
            'End If
            'If (etat3 = 2) Then
            'End If
            'etat3 = 2
        Else
            Form1.Label47.Text = ""
        End If
    End Sub
    Friend Sub verifierSiLaBalleToucheSaCibleSurLeBas()

        If nvlVal = Form1.case19.Location.Y And (positionDeLaBallePanzerJoy.X > positionLimite1Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite2Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            'If (etat3 = 2) Then
            Form1.Label47.Text = "On a toucher la cible."
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location
            positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

            nvlVal = positionLimite1Curseur.Y
            activerLeCurseurBas = False
            continuerLeTirDeLaBalleVersLeBas = False
            Form1.TimerDeplacementVersLeBasDeLaBalle.Stop()
            'End If
            'If (etat3 = 2) Then
            'End If
            'etat3 = 2
        Else
            Form1.Label47.Text = ""
        End If
    End Sub
    Friend Sub verifierSiLaBalleToucheSaCibleSurLaDroite()
        'Ici etat represente le fait que les curseurs et la balle sont dans la meme case lorsque etat =1 et à deux ils sont dans les cases differentes
        'Et comme ils sont dans la meme case au debut on desactive le tir droit trop vite c'est, pour ça, qu'on cree la variable etat1, 2,3,4
        If (positionDeLaBallePanzerJoy.X > positionLimite1Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite2Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            If (etat1 = 2) Then
                Form1.Label47.Text = "On a toucher la cible."
                positionLimite1Curseur = Form1.baliseLimite1.Location
                positionLimite2Curseur = Form1.baliseLimite2.Location
                positionLimite3Curseur = Form1.baliseLimit3.Location
                positionLimite4Curseur = Form1.baliseLimite4.Location
                positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

                Form1.lim1Curseur.Location = positionLimite1Curseur
                Form1.lim2Curseur.Location = positionLimite2Curseur
                Form1.lim3Curseur.Location = positionLimite3Curseur
                Form1.lim4Curseur.Location = positionLimite4Curseur
                Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

                Form1.TimerDeplacementDroitBalle.Stop()

            End If

            If (etat1 = 2) Then
                activerLeCurseurDroit = False
                continuerLeTirDeLaBalleAllantADroite = False
            End If

            etat1 = 2

        Else
            Form1.Label47.Text = ""
        End If

    End Sub
    Friend Sub verifierSiLaBalleToucheSaCibleSurLaGauche()

        If (positionDeLaBallePanzerJoy.X > positionLimite1Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite2Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            If (etat2 = 2) Then
                Form1.Label47.Text = "On a toucher la cible."
                positionLimite1Curseur = Form1.baliseLimite1.Location
                positionLimite2Curseur = Form1.baliseLimite2.Location
                positionLimite3Curseur = Form1.baliseLimit3.Location
                positionLimite4Curseur = Form1.baliseLimite4.Location
                positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

                Form1.lim1Curseur.Location = positionLimite1Curseur
                Form1.lim2Curseur.Location = positionLimite2Curseur
                Form1.lim3Curseur.Location = positionLimite3Curseur
                Form1.lim4Curseur.Location = positionLimite4Curseur
                Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

                Form1.TimerDeplacementGaucheBalle.Stop()
            End If

            If (etat2 = 2) Then
                activerLeCurseurGauche = False
                continuerLeTirDeLaBalleAllantAGauche = False
            End If

            etat2 = 2

        Else
            Form1.Label47.Text = ""
        End If

    End Sub


    Friend Sub limiterLesDeplacementsDuPanzerJoySurLespaceAutoriser()

        If (mouvementDeLaLimite1 = "droite") Then
            pos = positionBalise1Limite1Curseur
            pos.X += 90
            If (pos.Equals(Form1.case2.Location)) Then
                deplacerLePanzerJoyaDroite = False
            Else
                deplacerLePanzerJoyaDroite = True
            End If
        ElseIf (mouvementDeLaLimite1 = "bas")
            pos = positionBalise1Limite1Curseur
            pos.Y += 90
            If (pos.Equals(Form1.case16.Location)) Then
                deplacerLePanzerJoyEnBas = False
            Else
                deplacerLePanzerJoyEnBas = True
            End If
        ElseIf (mouvementDeLaLimite1 = "gauche")
            pos = positionLimite1Curseur
            pos.X -= 90
            If (pos.Equals(Form1.case46.Location)) Then
                deplacerLePanzerJoyAGauche = False
            Else
                deplacerLePanzerJoyAGauche = True
            End If
        ElseIf (mouvementDeLaLimite1 = "haut")
            pos = positionLimite1Curseur
            pos.Y -= 90
            If (pos.Equals(Form1.case32.Location)) Then
                deplacerLePanzerJoyEnHaut = False
            Else
                deplacerLePanzerJoyEnHaut = True
            End If
        End If

    End Sub
End Module
