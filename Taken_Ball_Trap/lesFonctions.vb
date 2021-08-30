
Module lesFonctions

    'CE COMMENTAIRE 'LE RETOUR DU CURSEUR SUR LES BALISES. FAIT REFERENCE A : 
    'LE CURSEUR TRAVERSE LES LIMITES DE LA FENETRE QUAND ON LE TIRE.
    'IL FAUT QUE LORSQU'ON TIRE LE CURSEUR, S'IL TRAVERSE LES LIMITES ,ALORS IL DOIT REPRENDRE SA PLACE SUR LES BALISES.

    Friend Sub tirerLaBalleVersLaDroite()
        '(positionDeLaBallePanzerJoy.X < limiteDroite) And
        If continuerLeTirDeLaBalleAllantADroite Then
            'positionDeLaBallePanzerJoy.X += 5
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLaDroite()
        End If
    End Sub
    Public Sub tirerLaBalleVersLaGauche()
        '(positionDeLaBallePanzerJoy.X > 0) And
        If continuerLeTirDeLaBalleAllantAGauche Then
            'positionDeLaBallePanzerJoy.X -= 90
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLaGauche()
        End If
    End Sub
    Friend Sub tirerLaBalleVersLeBas()
        '(positionDeLaBallePanzerJoy.Y < limiteBas + 43) And
        If continuerLeTirDeLaBalleVersLeBas Then
            'positionDeLaBallePanzerJoy.Y += 5
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLeBas()
        End If
    End Sub
    Friend Sub tirerLaBalleVersLeHaut()
        '(positionDeLaBallePanzerJoy.Y > 0) And 
        If continuerLeTirDeLaBalleVersLeHaut Then
            'positionDeLaBallePanzerJoy.Y -= 90
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            verifierSiLaBalleToucheSaCibleSurLeHaut()
        End If
    End Sub

    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaDroite()
        positionLimite1Curseur.X += 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.X += 90 'pasDeDeplacementDuPanzer
        'positionDeLaBallePanzerJoy.X += 90 'pasDeDeplacementDuPanzer
        'positionBaliseBalle.X += 90 'pasDeDeplacementDuPanzer

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur


        'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub lesBalisesBougesAvecLePanzerJoyVersLaDroite()
        positionBalise1Limite1Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.X += 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.X += 90 'pasDeDeplacementDuPanzer

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur

    End Sub
    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeBas()
        positionLimite1Curseur.Y += 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.Y += 90 'pasDeDeplacementDuPanzer
        'positionDeLaBallePanzerJoy.Y += 90 'pasDeDeplacementDuPanzer
        'positionBaliseBalle.Y += 90 'pasDeDeplacementDuPanzer


        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur


        'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub lesBalisesBougesAvecLePanzerJoyVersLeBas()
        positionBalise1Limite1Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.Y += 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.Y += 90 'pasDeDeplacementDuPanzer

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur

    End Sub
    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeHaut()
        positionLimite1Curseur.Y -= 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        'positionDeLaBallePanzerJoy.Y -= 90 'pasDeDeplacementDuPanzer
        'positionBaliseBalle.Y -= 90 'pasDeDeplacementDuPanzer

        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur

        'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub lesBalisesBougesAvecLePanzerJoyVersLeHaut()
        positionBalise1Limite1Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.Y -= 90 'pasDeDeplacementDuPanzer
        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur
    End Sub
    Public Sub leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaGauche()
        positionLimite1Curseur.X -= 90 'pasDeDeplacementDuPanzer '92
        positionLimite4Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionLimite2Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionLimite3Curseur.X -= 90 'pasDeDeplacementDuPanzer
        'positionDeLaBallePanzerJoy.X -= 90 'pasDeDeplacementDuPanzer
        'positionBaliseBalle.X -= 90 'pasDeDeplacementDuPanzer


        Form1.lim1Curseur.Location = positionLimite1Curseur
        Form1.lim2Curseur.Location = positionLimite2Curseur
        Form1.lim3Curseur.Location = positionLimite3Curseur
        Form1.lim4Curseur.Location = positionLimite4Curseur


        'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

    End Sub
    Public Sub lesBalisesBougesAvecLePanzerJoyVersLaGauche()
        positionBalise1Limite1Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionBalise2Limite2Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionBalise3Limite3Curseur.X -= 90 'pasDeDeplacementDuPanzer
        positionBalise4Limite4Curseur.X -= 90 'pasDeDeplacementDuPanzer

        Form1.baliseLimite1.Location = positionBalise1Limite1Curseur
        Form1.baliseLimite2.Location = positionBalise2Limite2Curseur
        Form1.baliseLimit3.Location = positionBalise3Limite3Curseur
        Form1.baliseLimite4.Location = positionBalise4Limite4Curseur
    End Sub

    Friend Sub deplacerPanzerJoyVersDroite()

        If (Form1.healthPointBar.Value < 40) Then
            'Changer la couleur de la healthBar lorsqu'on diminue ou augmente les points de vie.
            Form1.healthPointBar.ForeColor = Color.Red
        Else
            Form1.healthPointBar.ForeColor = Color.Lime
        End If

        AugmenterVitesseDesKamikazes()
        If (Form1.lim2.Location.X < limiteDroite) Then

            positionLim1.X += pasDeDeplacementDuPanzer
            positionLim2.X += pasDeDeplacementDuPanzer
            positionLim3.X += pasDeDeplacementDuPanzer
            positionLim4.X += pasDeDeplacementDuPanzer
            positionDuPanzerJoy.X += pasDeDeplacementDuPanzer

            lesBalisesBougesAvecLePanzerJoyVersLaDroite()
            ajouterUneBarreDeVieAuPanzerJoy()
            If (leCurseurPeutBougerAvecLePanzerJoyVersLaDroite) Then
                leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaDroite()
            End If

            'deplacerLeCurseurVersLaDroite()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4


            '    If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
            '        'Ici on verifie si le panzerJoy a touché le kamikaze intentionnelement sur le Droite.
            '        Form1.Label22.Text = "On a toucher le panzer5555f044drJoy"
            '        Form1.enemi6.Location = pointQuelquonque
            '        Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            '    End If

            '    If (Form1.enemi6.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) And ((Form1.panzerJoy.Location.X < Form1.enemi6.Location.X) Or (Form1.panzerJoy.Location.X > Form1.enemi6.Location.X)) Then
            '        'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            '        'Form1.Label15.Text = "Location Y : " & Form1.lim3.Location.Y & " | Y.K : " & Form1.enemi6.Location.Y
            '        Form1.leKamikazeAttaqueParL_Horizontale.Start()
            '        Form1.leKamikazeAttaqueParLaVerticale.Stop()
            '    ElseIf (Form1.enemi6.Location.X < Form1.lim3.Location.X) And (Form1.enemi6.Location.X > Form1.lim4.Location.X) And ((Form1.panzerJoy.Location.Y < Form1.enemi6.Location.Y) Or (Form1.panzerJoy.Location.Y > Form1.enemi6.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            '        'Form1.Label22.Text = "ON EST LE HAUT!"
            '        Form1.leKamikazeAttaqueParLaVerticale.Start()
            '        Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            '    End If

            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi6)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi5)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi4)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi3)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi2)

        End If

    End Sub
    Friend Sub deplacerPanzerJoyVersGauche()

        If (Form1.healthPointBar.Value < 40) Then
            'Changer la couleur de la healthBar lorsqu'on diminue ou augmente les points de vie.
            Form1.healthPointBar.ForeColor = Color.Red
        Else
            Form1.healthPointBar.ForeColor = Color.Lime
        End If


        If (Form1.healthPointBar.Value < 40) Then
            'Changer la couleur de la healthBar lorsqu'on diminue ou augmente les points de vie.
            Form1.healthPointBar.ForeColor = Color.Red
        Else
            Form1.healthPointBar.ForeColor = Color.Lime
        End If


        AugmenterVitesseDesKamikazes()
        If (Form1.lim1.Location.X > limiteHautEtGauche) Then

            positionLim1.X -= pasDeDeplacementDuPanzer
            positionLim2.X -= pasDeDeplacementDuPanzer
            positionLim3.X -= pasDeDeplacementDuPanzer
            positionLim4.X -= pasDeDeplacementDuPanzer
            positionDuPanzerJoy.X -= pasDeDeplacementDuPanzer

            lesBalisesBougesAvecLePanzerJoyVersLaGauche()
            ajouterUneBarreDeVieAuPanzerJoy()
            If (leCurseurPeutBougerAvecLePanzerJoyVersLaGauche) Then
                leCurseurEtLaBalleBougeAvecLePanzerJoyVersLaGauche()
            End If

            'deplacerLeCurseurVersLaGauche()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4

            'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
            '    'Ici on verifie si le panzerJoy a touché le kamikaze intentionnelement sur la gauche.
            '    Form1.Label22.Text = "On a toucher le panzer5555f044drJoy"
            '    Form1.enemi6.Location = pointQuelquonque
            '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            'End If

            'If (Form1.enemi6.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) And ((Form1.panzerJoy.Location.X < Form1.enemi6.Location.X) Or (Form1.panzerJoy.Location.X > Form1.enemi6.Location.X)) Then
            '    'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            '    'Form1.Label15.Text = "Location Y : " & Form1.lim3.Location.Y & " | Y.K : " & Form1.enemi6.Location.Y
            '    Form1.leKamikazeAttaqueParL_Horizontale.Start()
            '    Form1.leKamikazeAttaqueParLaVerticale.Stop()
            'ElseIf (Form1.enemi6.Location.X < Form1.lim3.Location.X) And (Form1.enemi6.Location.X > Form1.lim4.Location.X) And ((Form1.panzerJoy.Location.Y < Form1.enemi6.Location.Y) Or (Form1.panzerJoy.Location.Y > Form1.enemi6.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            '    'Form1.Label22.Text = "ON EST LE HAUT!"
            '    Form1.leKamikazeAttaqueParLaVerticale.Start()
            '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            'End If


            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi6)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi5)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi4)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi3)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi2)

        End If
    End Sub
    Friend Sub deplacerPanzerJoyVersHaut()

        If (Form1.healthPointBar.Value < 40) Then
            'Changer la couleur de la healthBar lorsqu'on diminue ou augmente les points de vie.
            Form1.healthPointBar.ForeColor = Color.Red
        Else
            Form1.healthPointBar.ForeColor = Color.Lime
        End If



        AugmenterVitesseDesKamikazes()
        If (Form1.lim1.Location.Y > limiteHautEtGauche) Then
            positionLim1.Y -= pasDeDeplacementDuPanzer
            positionLim2.Y -= pasDeDeplacementDuPanzer
            positionLim3.Y -= pasDeDeplacementDuPanzer
            positionLim4.Y -= pasDeDeplacementDuPanzer
            positionDuPanzerJoy.Y -= pasDeDeplacementDuPanzer

            lesBalisesBougesAvecLePanzerJoyVersLeHaut()
            ajouterUneBarreDeVieAuPanzerJoy()
            If (leCurseurPeutBougerAvecLePanzerJoyVersLeHaut) Then
                leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeHaut()
            End If

            'deplacerLeCurseurVersLeHaut()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4

            'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
            '    'Ici on verifie si le panzerJoy a touché le kamikaze intentionnelement sur le haut.
            '    Form1.Label22.Text = "On a toucher le panzer5555f044drJoy"
            '    Form1.enemi6.Location = pointQuelquonque
            '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            'End If

            'If (Form1.enemi6.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) And ((Form1.panzerJoy.Location.X < Form1.enemi6.Location.X) Or (Form1.panzerJoy.Location.X > Form1.enemi6.Location.X)) Then
            '    'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            '    'Form1.Label15.Text = "Location Y : " & Form1.lim3.Location.Y & " | Y.K : " & Form1.enemi6.Location.Y
            '    Form1.leKamikazeAttaqueParL_Horizontale.Start()
            '    Form1.leKamikazeAttaqueParLaVerticale.Stop()
            'ElseIf (Form1.enemi6.Location.X < Form1.lim3.Location.X) And (Form1.enemi6.Location.X > Form1.lim4.Location.X) And ((Form1.panzerJoy.Location.Y < Form1.enemi6.Location.Y) Or (Form1.panzerJoy.Location.Y > Form1.enemi6.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            '    'Form1.Label22.Text = "ON EST LE HAUT!"
            '    Form1.leKamikazeAttaqueParLaVerticale.Start()
            '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            'End If
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi6)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi5)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi4)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi3)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi2)

        End If

    End Sub
    Friend Sub deplacerPanzerJoyVersBas()

        If (Form1.healthPointBar.Value < 40) Then
            'Changer la couleur de la healthBar lorsqu'on diminue ou augmente les points de vie.
            Form1.healthPointBar.ForeColor = Color.Red
        Else
            Form1.healthPointBar.ForeColor = Color.Lime
        End If

        AugmenterVitesseDesKamikazes()

        If (Form1.lim4.Location.Y < limiteBas) Then
            positionLim1.Y += pasDeDeplacementDuPanzer
            positionLim2.Y += pasDeDeplacementDuPanzer
            positionLim3.Y += pasDeDeplacementDuPanzer
            positionLim4.Y += pasDeDeplacementDuPanzer
            positionDuPanzerJoy.Y += pasDeDeplacementDuPanzer

            lesBalisesBougesAvecLePanzerJoyVersLeBas()
            ajouterUneBarreDeVieAuPanzerJoy()
            If (leCurseurPeutBougerAvecLePanzerJoyVersLeBas) Then
                leCurseurEtLaBalleBougeAvecLePanzerJoyVersLeBas()
            End If
            'deplacerLeCurseurVersLeBas()
            Form1.panzerJoy.Location = positionDuPanzerJoy
            Form1.lim1.Location = positionLim1
            Form1.lim2.Location = positionLim2
            Form1.lim3.Location = positionLim3
            Form1.lim4.Location = positionLim4

            'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
            '    'Ici on verifie si le panzerJoy a touché le kamikaze intentionnelement sur le bas.
            '    Form1.Label22.Text = "On a toucher le panzer5555f044drJoy"
            '    Form1.enemi6.Location = pointQuelquonque
            '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            'End If

            'If (Form1.enemi6.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) And ((Form1.panzerJoy.Location.X < Form1.enemi6.Location.X) Or (Form1.panzerJoy.Location.X > Form1.enemi6.Location.X)) Then
            '    'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            '    'Form1.Label15.Text = "Location Y : " & Form1.lim3.Location.Y & " | Y.K : " & Form1.enemi6.Location.Y
            '    Form1.leKamikazeAttaqueParL_Horizontale.Start()
            '    Form1.leKamikazeAttaqueParLaVerticale.Stop()
            'ElseIf (Form1.enemi6.Location.X < Form1.lim3.Location.X) And (Form1.enemi6.Location.X > Form1.lim4.Location.X) And ((Form1.panzerJoy.Location.Y < Form1.enemi6.Location.Y) Or (Form1.panzerJoy.Location.Y > Form1.enemi6.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            '    'Form1.Label22.Text = "ON EST LE HAUT!"
            '    Form1.leKamikazeAttaqueParLaVerticale.Start()
            '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            'End If

            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi6)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi5)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi4)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi3)
            verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(Form1.enemi2)

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

        If (positionLimite1Curseur.X > Form1.Width) Then
            Form1.Label23.Text = positionLimite4Curseur.Y
            'LE RETOUR DU CURSEUR SUR LES BALISES.
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            desactiverCurseurCarDepasseToutesLimites = True
            leCurseuraAtteintSaCibleSurLaDroite = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True
            onPeutTirerDeNouveau = True
            'activerLeCurseurHaut = False
            'Form1.TimerDeplacementVersLeHautDeLaBalle.Stop()
        Else
            Form1.Label23.Text = ""
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


        If (positionLimite1Curseur.X < 0) Then
            Form1.Label23.Text = positionLimite4Curseur.Y
            'LE RETOUR DU CURSEUR SUR LES BALISES.
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            desactiverCurseurCarDepasseToutesLimites = True
            leCurseuraAtteintSaCibleSurLaGauche = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True
            onPeutTirerDeNouveau = True
            'activerLeCurseurHaut = False
            'Form1.TimerDeplacementVersLeHautDeLaBalle.Stop()
        Else
            Form1.Label23.Text = ""
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
            nvlVal = positionLimite1Curseur.Y ', Si jamais il y'a une erreur sur les deplacements du curseur alors essaye de mettre cette instruction. 
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


        If (positionLimite4Curseur.Y > Form1.Height) Then
            Form1.Label23.Text = positionLimite4Curseur.Y
            'LE RETOUR DU CURSEUR SUR LES BALISES.
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            desactiverCurseurCarDepasseToutesLimites = True
            leCurseuraAtteintSaCibleSurLeBas = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True
            onPeutTirerDeNouveau = True
            'activerLeCurseurHaut = False
            'Form1.TimerDeplacementVersLeHautDeLaBalle.Stop()
        Else
            Form1.Label23.Text = ""
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
                Form1.Label46.Text = "Le curseur a atteint l'objectif."
            Else
                'cadencer = 1 51 46
            End If

            If (positionLimite4Curseur.Y < 0) Then
                Form1.Label23.Text = positionLimite4Curseur.Y
                'LE RETOUR DU CURSEUR SUR LES BALISES.
                positionLimite1Curseur = Form1.baliseLimite1.Location
                positionLimite2Curseur = Form1.baliseLimite2.Location
                positionLimite3Curseur = Form1.baliseLimit3.Location
                positionLimite4Curseur = Form1.baliseLimite4.Location

                Form1.lim1Curseur.Location = positionLimite1Curseur
                Form1.lim2Curseur.Location = positionLimite2Curseur
                Form1.lim3Curseur.Location = positionLimite3Curseur
                Form1.lim4Curseur.Location = positionLimite4Curseur
                desactiverCurseurCarDepasseToutesLimites = True
                leCurseuraAtteintSaCibleSurLeHaut = True
                leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
                leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True
                leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
                leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True
                onPeutTirerDeNouveau = True
                'activerLeCurseurHaut = False
                'Form1.TimerDeplacementVersLeHautDeLaBalle.Stop()
            Else
                Form1.Label23.Text = ""
            End If
            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur

        End If
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
        'P = Form1.case34.Location
        If Not (activerLeCurseurHaut) Then 'And (positionDeLaBallePanzerJoy.X > positionLimite4Curseur.X) And (positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            'If (etat3 = 2) Then
            'leCurseurAtilAtteintUneCaseEntirantVersLeHaut(positionLimite1Curseur)
            'Form1.case34.Hide()
            'Form1.case34.Location = pointQuelquonque
            'My.Computer.Audio.Play(sonProduitParImpactDuCurseur)
            leCurseuraAtteintSaCibleSurLeHaut = False
            leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True 'On redonne la possibilité au panzerJoy de bouger avec le curseur.
            leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True 'On redonne la possibilité au panzerJoy de bouger avec le curseur.
            leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True
            Form1.Label47.Text = "On a toucher la cible. Haut"
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location
            'positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

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

        If Not activerLeCurseurBas Then 'nvlval= Form1.case63.Location.Y Then 'And (positionDeLaBallePanzerJoy.X > positionLimite1Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite2Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            'If (etat3 = 2) Then
            'My.Computer.Audio.Play(sonProduitParImpactDuCurseur)
            Form1.Label47.Text = "On a toucher la cible."
            leCurseuraAtteintSaCibleSurLeBas = False
            leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
            leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True

            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location
            'positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

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
        If Not activerLeCurseurDroit Then 'nvlVal = Form1.case63.Location.X Then
            '(positionDeLaBallePanzerJoy.X > positionLimite1Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite2Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            'If (etat1 = 2) Then
            'My.Computer.Audio.Play(sonProduitParImpactDuCurseur)
            Form1.Label47.Text = "On a toucher la cible."
            leCurseuraAtteintSaCibleSurLaDroite = False
            leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True 'On redonne au panzerJoy la possibilité de bouger avec le curseur , puisqu'il a atteint sa cible.
            leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True

            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location
            'positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location

            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy

            activerLeCurseurDroit = False
            continuerLeTirDeLaBalleAllantADroite = False
            Form1.TimerDeplacementDroitBalle.Stop()


            etat1 = 2

        Else
            Form1.Label47.Text = ""
        End If

    End Sub
    Friend Sub verifierSiLaBalleToucheSaCibleSurLaGauche()
        'positionLimite1Curseur.X = Form1.case46.Location.X
        If Not activerLeCurseurGauche Then 'positionBalise1Limite1Curseur.X = Form1.case46.Location.X Then '(positionDeLaBallePanzerJoy.X > positionLimite1Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y) And (positionDeLaBallePanzerJoy.X < positionLimite2Curseur.X) And (positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y) Then ' And (positionDeLaBallePanzerJoy.X > positionLimite3Curseur.X) And (positionDeLaBallePanzerJoy.X < positionLimite4Curseur.X)) Then 'And (positionDeLaBallePanzerJoy.Y > positionLimite1Curseur.Y And positionDeLaBallePanzerJoy.Y > positionLimite2Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite3Curseur.Y And positionDeLaBallePanzerJoy.Y < positionLimite4Curseur.Y) Then
            'If (etat2 = 2) Then
            'My.Computer.Audio.Play(sonProduitParImpactDuCurseur)
            leCurseuraAtteintSaCibleSurLaGauche = False
            leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
            leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True

            Form1.Label47.Text = "On a toucher la cible."
            positionLimite1Curseur = Form1.baliseLimite1.Location
            positionLimite2Curseur = Form1.baliseLimite2.Location
            positionLimite3Curseur = Form1.baliseLimit3.Location
            positionLimite4Curseur = Form1.baliseLimite4.Location
            'positionDeLaBallePanzerJoy = Form1.baliseBallePanzerJoy.Location
            Form1.lim1Curseur.Location = positionLimite1Curseur
            Form1.lim2Curseur.Location = positionLimite2Curseur
            Form1.lim3Curseur.Location = positionLimite3Curseur
            Form1.lim4Curseur.Location = positionLimite4Curseur
            'Form1.ballePanzerJoy.Location = positionDeLaBallePanzerJoy
            activerLeCurseurGauche = False
            continuerLeTirDeLaBalleAllantAGauche = False
            Form1.TimerDeplacementGaucheBalle.Stop()
            'End If

            'If (etat2 = 2) Then
            '    activerLeCurseurGauche = False
            '    continuerLeTirDeLaBalleAllantAGauche = False
            'End If

            etat2 = 2

        Else
            Form1.Label47.Text = ""
        End If

    End Sub


    Friend Sub limiterLesDeplacementsDuPanzerJoySurLespaceAutoriser()

        If (mouvementDeLaLimite1 = "droite") Then
            positionDuPanzerLorsquonVerifieSilToucheUneCase = positionBalise1Limite1Curseur
            positionDuPanzerLorsquonVerifieSilToucheUneCase.X += 90
            If (lePanzerJoyVaToucherUneCase()) Then
                deplacerLePanzerJoyaDroite = False
            Else
                deplacerLePanzerJoyaDroite = True
            End If
        ElseIf (mouvementDeLaLimite1 = "bas")
            positionDuPanzerLorsquonVerifieSilToucheUneCase = positionBalise1Limite1Curseur
            positionDuPanzerLorsquonVerifieSilToucheUneCase.Y += 90
            If (lePanzerJoyVaToucherUneCase()) Then
                deplacerLePanzerJoyEnBas = False
            Else
                deplacerLePanzerJoyEnBas = True
            End If
        ElseIf (mouvementDeLaLimite1 = "gauche")
            positionDuPanzerLorsquonVerifieSilToucheUneCase = positionBalise1Limite1Curseur
            positionDuPanzerLorsquonVerifieSilToucheUneCase.X -= 90
            If (lePanzerJoyVaToucherUneCase()) Then
                deplacerLePanzerJoyAGauche = False
            Else
                deplacerLePanzerJoyAGauche = True
            End If
        ElseIf (mouvementDeLaLimite1 = "haut")
            positionDuPanzerLorsquonVerifieSilToucheUneCase = positionBalise1Limite1Curseur
            positionDuPanzerLorsquonVerifieSilToucheUneCase.Y -= 90
            If (lePanzerJoyVaToucherUneCase()) Then
                deplacerLePanzerJoyEnHaut = False
                ArreterLaBoucleIterative = False
            Else
                deplacerLePanzerJoyEnHaut = True
            End If
        End If

    End Sub

    Public Function leCurseurAtilAtteintUneCaseEntirantVersLeHaut(ByRef copiePositionDeLaLimite1 As Point)
        'ICI on va verifier l'egalite des valeurs de la limite1  avec la position des cases.
        'Et on va s'arreter lorsque le curseur aura toucher l'une des cases.
        'Ici à chaque deplacement du curseur , cette verifiaction sera faite sur toutes les cases par rapport à copiePositionDeLaLimite1, à chaque deplacement du curseur.
        'positionLimite1Curseur <> caseAatteindre Then
        'Si la position du curseur est differente de la case à atteindre alors continuer d'avancer.
        'Si la postion du curseur est differente de la position de la case à atteindre alors leCuseurAatteintSaCible=False , dans ce cas il continue d'avencer.
        'Si le curseur atteint la case à atteindre , dans ce cas leCurseurAatteintSaCible=True , donc on arrete d'avencer et on fait disparaitre la case à atteindre.
        'Lorsque le curseurHaut arrete d'avancer , alors la condition dans la procedure verifier... , va s'activer et faire disparaitre le curseur et la balle.
        'Si le curseur est en cours de deplacement alors  , on ne permet pas au panzerJoy de bougeravec le panzerJoy
        'Si le curseur a atteint sa cible alors , on peut de nouveau permettre au panzerJoy de bouger avec le curseur, puisqu'il est deja revenu sur les balises de chacune des limites.
        For Each elmt In tableauDesCasesDeLaCarte
            If Not leCurseuraAtteintSaCibleSurLeHaut Then 'ON CONTINUE CETTE CONDITION SI LE CURSEUR N'A PAS ENCORE ATTEINT SA CIBLE leCurseurAatteintSaCible=False
                If (copiePositionDeLaLimite1 = elmt.Location) Then
                    leCurseuraAtteintSaCibleSurLeHaut = True 'On s'est arreter sur une case.
                    leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
                    onPeutTirerDeNouveau = True 'Instruction1 de tir
                    If (Form1.progressBarDesCasesShooter.Value < Form1.progressBarDesCasesShooter.Maximum) Then
                        Form1.progressBarDesCasesShooter.Value += 1
                    End If
                    elmt.Hide()
                    elmt.Location = pointQuelquonque
                    'Form1.Label23.Text = "on peut encore bouger."
                    'Form1.case34.Hide()
                    'Form1.case34.Location = pointQuelquonque
                Else
                    leCurseuraAtteintSaCibleSurLeHaut = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeBas = False
                    onPeutTirerDeNouveau = False 'Instruction2 de tir
                    Form1.Label23.Text = "Le curseur ne bouge plus ici."
                End If
            End If
        Next

        'For compteur = 0 To tableauDesCasesDeLaCarte.Length - 1
        '    If (copiePositionDeLaLimite1.Y = tableauDesCasesDeLaCarte(compteur).Location.Y) Then
        '        leCurseuraAtteintSaCible = True 'On s'est arreter sur une case.
        '        faireDisparaitreUneCase(copiePositionDeLaLimite1)
        '    Else
        '        leCurseuraAtteintSaCible = False
        '    End If
        'Next

        Return leCurseuraAtteintSaCibleSurLeHaut
    End Function
    Public Function leCurseurAtilAtteintUneCaseEntirantVersLeBas(ByRef copiePositionDeLaLimite1 As Point)
        'ICI on va verifier l'egalite des valeurs de la limite1  avec la position des cases.
        'Et on va s'arreter lorsque le curseur aura toucher l'une des cases.
        'Ici à chaque deplacement du curseur , cette verifiaction sera faite sur toutes les cases par rapport à copiePositionDeLaLimite1, à chaque deplacement du curseur.
        'positionLimite1Curseur <> caseAatteindre Then
        'Si la position du curseur est differente de la case à atteindre alors continuer d'avancer.
        'Si la postion du curseur est differente de la position de la case à atteindre alors leCuseurAatteintSaCible=False , dans ce cas il continue d'avencer.
        'Si le curseur atteint la case à atteindre , dans ce cas leCurseurAatteintSaCible=True , donc on arrete d'avencer et on fait disparaitre la case à atteindre.
        'Lorsque le curseurHaut arrete d'avancer , alors la condition dans la procedure verifier... , va s'activer et faire disparaitre le curseur et la balle.
        'Instructions de tir :
        '1-On va permettre au panzerJoy de tirer à nouveau car , la case cible ete atteinte.
        '2-Si elle n'est pas encore atteinte alors on ne peut pas effectuer un tir pendant qu'un autre est en cours.

        For Each elmt In tableauDesCasesDeLaCarte
            If Not leCurseuraAtteintSaCibleSurLeBas Then 'ON CONTINUE CETTE CONDITION SI LE CURSEUR N'A PAS ENCORE ATTEINT SA CIBLE leCurseurAatteintSaCible=False
                If (copiePositionDeLaLimite1 = elmt.Location) Then
                    leCurseuraAtteintSaCibleSurLeBas = True 'On s'est arreter sur une case.
                    leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True
                    onPeutTirerDeNouveau = True 'Instruction1 de tir
                    If (Form1.progressBarDesCasesShooter.Value < Form1.progressBarDesCasesShooter.Maximum) Then
                        Form1.progressBarDesCasesShooter.Value += 1
                    End If
                    elmt.Hide()
                    elmt.Location = pointQuelquonque
                    'Form1.case34.Hide()
                    'Form1.case34.Location = pointQuelquonque
                Else
                    leCurseuraAtteintSaCibleSurLeBas = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeBas = False
                    onPeutTirerDeNouveau = False 'Instruction2 de tir
                End If
            End If
        Next

        Return leCurseuraAtteintSaCibleSurLeBas
    End Function
    Public Function leCurseurAtilAtteintUneCaseEntirantVersLaGauche(ByRef copiePositionDeLaLimite1 As Point)
        'Si la position du curseur est differente de la case à atteindre alors continuer d'avancer.
        'Si la postion du curseur est differente de la position de la case à atteindre alors leCuseurAatteintSaCible=False , dans ce cas il continue d'avencer.
        'Si le curseur atteint la case à atteindre , dans ce cas leCurseurAatteintSaCible=True , donc on arrete d'avencer et on fait disparaitre la case à atteindre.
        'Lorsque le curseurGauche arrete d'avancer , alors la condition dans la procedure verifier... , va s'activer et faire disparaitre le curseur et la balle.
        'Instructions de tir :
        '1-On va permettre au panzerJoy de tirer à nouveau car , la case cible ete atteinte.
        '2-Si elle n'est pas encore atteinte alors on ne peut pas effectuer un tir pendant qu'un autre est en cours.

        For Each elmt In tableauDesCasesDeLaCarte
            If Not leCurseuraAtteintSaCibleSurLaGauche Then 'ON CONTINUE CETTE CONDITION SI LE CURSEUR N'A PAS ENCORE ATTEINT SA CIBLE leCurseurAatteintSaCible=False
                If (copiePositionDeLaLimite1 = elmt.Location) Then
                    leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True
                    leCurseuraAtteintSaCibleSurLaGauche = True 'On s'est arreter sur une case.
                    onPeutTirerDeNouveau = True 'Instruction1 de tir
                    If (Form1.progressBarDesCasesShooter.Value < Form1.progressBarDesCasesShooter.Maximum) Then
                        Form1.progressBarDesCasesShooter.Value += 1
                    End If
                    elmt.Hide()
                    elmt.Location = pointQuelquonque
                    'Form1.case34.Hide()
                    'Form1.case34.Location = pointQuelquonque
                Else
                    leCurseuraAtteintSaCibleSurLaGauche = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeBas = False
                    onPeutTirerDeNouveau = False 'Instruction2 de tir
                End If
            End If
        Next

        Return leCurseuraAtteintSaCibleSurLaGauche
    End Function
    Public Function leCurseurAtilAtteintUneCaseEntirantVersLaDroite(ByRef copiePositionDeLaLimite1 As Point)
        'Si la position du curseur est differente de la case à atteindre alors continuer d'avancer.
        'Si la postion du curseur est differente de la position de la case à atteindre alors leCuseurAatteintSaCible=False , dans ce cas il continue d'avencer.
        'Si le curseur atteint la case à atteindre , dans ce cas leCurseurAatteintSaCible=True , donc on arrete d'avencer et on fait disparaitre la case à atteindre.
        'Lorsque le curseurGauche arrete d'avancer , alors la condition dans la procedure verifier... , va s'activer et faire disparaitre le curseur et la balle.
        'Instructions de tir :
        '1-On va permettre au panzerJoy de tirer à nouveau car , la case cible ete atteinte.
        '2-Si elle n'est pas encore atteinte alors on ne peut pas effectuer un tir pendant qu'un autre est en cours.
        For Each elmt In tableauDesCasesDeLaCarte
            If Not leCurseuraAtteintSaCibleSurLaDroite Then 'ON CONTINUE CETTE CONDITION SI LE CURSEUR N'A PAS ENCORE ATTEINT SA CIBLE leCurseurAatteintSaCible=False
                If (copiePositionDeLaLimite1 = elmt.Location) Then
                    leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
                    leCurseuraAtteintSaCibleSurLaDroite = True 'On s'est arreter sur une case.
                    onPeutTirerDeNouveau = True 'Instruction1 de tir
                    If (Form1.progressBarDesCasesShooter.Value < Form1.progressBarDesCasesShooter.Maximum) Then
                        Form1.progressBarDesCasesShooter.Value += 1
                    End If
                    elmt.Hide()
                    elmt.Location = pointQuelquonque
                    'Form1.case34.Hide()
                    'Form1.case34.Location = pointQuelquonque
                Else
                    leCurseuraAtteintSaCibleSurLaDroite = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = False 'On n'empeche le panzerJoy d'aller à gauche au cours du deplacement du curseur , ceic pour eviter qu'il ne bouge avec le curseur.
                    leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = False
                    leCurseurPeutBougerAvecLePanzerJoyVersLeBas = False
                    onPeutTirerDeNouveau = False 'Instruction2 de tir
                End If
            End If
        Next

        Return leCurseuraAtteintSaCibleSurLaDroite
    End Function

    Public Sub faireDisparaitreUneCase(ByVal copiePositionDeLaLimite1 As Point)
        'numeroDeLaCaseAtteinte = compteur
        'If (copiePositionDeLaLimite1.X = tableauDesCasesDeLaCarte(numeroDeLaCaseAtteinte).Location.X) And (copiePositionDeLaLimite1.Y = tableauDesCasesDeLaCarte(numeroDeLaCaseAtteinte).Location.Y) Then
        tableauDesCasesDeLaCarte(numeroDeLaCaseAtteinte).Hide()
        tableauDesCasesDeLaCarte(numeroDeLaCaseAtteinte).Location = pointQuelquonque
        'End If
    End Sub
    Public Function lePanzerJoyVaToucherUneCase() As Boolean 'VIENT RAJOUTER LES AUTRES CASES ICI , IL EN MANQUE BEAUCOUP.
        'Condition1: Si le PanzerJoy touche une case alors , on va l'empecher de continuer à se deplacer.
        'Condition2: Si lePanzerJoy ne touche pas une case alors, on lui permet de continuer à avancer.
        onAToucherUneDesCasesActives = positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case1.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case2.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case3.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case4.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case4.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case5.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case6.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case7.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case8.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case9.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case10.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case11.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case12.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case13.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case14.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case15.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case16.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case17.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case18.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case19.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case20.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case21.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case22.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case23.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case24.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case25.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case26.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case27.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case28.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case29.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case30.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case31.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case32.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case33.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case34.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case35.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case36.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case37.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case38.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case39.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case40.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case41.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case42.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case43.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case44.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case45.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case46.Location)
        onAToucherUneDesCasesActives2 = positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case47.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case48.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case49.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case50.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case51.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case52.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case53.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case54.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case55.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case56.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case57.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case58.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case59.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case60.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case61.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case62.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case63.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case64.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case65.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case66.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case67.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case68.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case69.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case70.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case71.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case72.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case73.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case74.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case75.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case76.Location)
        onAToucherUneDesCasesActives3 = positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case77.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case78.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case79.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case80.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case81.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case82.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case83.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case84.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case85.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case86.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case87.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case88.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case89.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case90.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case91.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case92.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case93.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case94.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case95.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case96.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case97.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case98.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case99.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case100.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case101.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case102.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case103.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case104.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case105.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case106.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case107.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case108.Location)
        onAtoucherUneDesCasesActives4 = positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case109.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case110.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case111.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case4.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case112.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case113.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case114.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case115.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case116.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case117.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case118.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case119.Location) Or positionDuPanzerLorsquonVerifieSilToucheUneCase.Equals(Form1.case120.Location)
        Dim valBool As Boolean

        Form1.Label117.Text = onAToucherUneDesCasesActives Or onAToucherUneDesCasesActives2

        If (onAToucherUneDesCasesActives Or onAToucherUneDesCasesActives2 Or onAToucherUneDesCasesActives3 Or onAtoucherUneDesCasesActives4) Then
            'Condition1
            valBool = True
        Else
            'Condition2
            valBool = False
        End If

        Return valBool
    End Function
    Public Sub ajouterUneBarreDeVieAuPanzerJoy()
        If (Form1.baretteDeVie1.Location.X > Form1.baliseLimite1.Location.X) And (Form1.baretteDeVie1.Location.Y > Form1.baliseLimite1.Location.Y) And (Form1.baretteDeVie1.Location.X < Form1.baliseLimite2.Location.X) And (Form1.baretteDeVie1.Location.Y < Form1.baliseLimite4.Location.Y) And (Form1.baretteDeVie1.Location.X > Form1.baliseLimite4.Location.X) And (Form1.baretteDeVie1.Location.Y < Form1.baliseLimit3.Location.Y) And (Form1.baretteDeVie1.Location.X < Form1.baliseLimit3.Location.X) Then
            Form1.Label47.Text = "On a recuperer la barette de vie."
            Form1.baretteDeVie1.Location = pointQuelquonque
            Try
                My.Computer.Audio.Play(sonProduitParRecuperationDeBaretteDeVie)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try
            barretteDeVieRestante -= 1
            If (Form1.healthPointBar.Value < 120) Then
                Form1.healthPointBar.Value += 20
            End If
        ElseIf (Form1.baretteDeVie2.Location.X > Form1.baliseLimite1.Location.X) And (Form1.baretteDeVie2.Location.Y > Form1.baliseLimite1.Location.Y) And (Form1.baretteDeVie2.Location.X < Form1.baliseLimite2.Location.X) And (Form1.baretteDeVie2.Location.Y < Form1.baliseLimite4.Location.Y) And (Form1.baretteDeVie2.Location.X > Form1.baliseLimite4.Location.X) And (Form1.baretteDeVie2.Location.Y < Form1.baliseLimit3.Location.Y) And (Form1.baretteDeVie2.Location.X < Form1.baliseLimit3.Location.X) Then
            Form1.Label47.Text = "On a recuperer la barette de vie."
            Form1.baretteDeVie2.Location = pointQuelquonque
            Try
                My.Computer.Audio.Play(sonProduitParRecuperationDeBaretteDeVie)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try
            barretteDeVieRestante -= 1
            If (Form1.healthPointBar.Value < 120) Then
                Form1.healthPointBar.Value += 20
            End If
        ElseIf (Form1.baretteDeVie3.Location.X > Form1.baliseLimite1.Location.X) And (Form1.baretteDeVie3.Location.Y > Form1.baliseLimite1.Location.Y) And (Form1.baretteDeVie3.Location.X < Form1.baliseLimite2.Location.X) And (Form1.baretteDeVie3.Location.Y < Form1.baliseLimite4.Location.Y) And (Form1.baretteDeVie3.Location.X > Form1.baliseLimite4.Location.X) And (Form1.baretteDeVie3.Location.Y < Form1.baliseLimit3.Location.Y) And (Form1.baretteDeVie3.Location.X < Form1.baliseLimit3.Location.X) Then
            Form1.Label47.Text = "On a recuperer la barette de vie."
            Try
                My.Computer.Audio.Play(sonProduitParRecuperationDeBaretteDeVie)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try

            barretteDeVieRestante -= 1
            Form1.baretteDeVie3.Location = pointQuelquonque
            If (Form1.healthPointBar.Value < 120) Then
                Form1.healthPointBar.Value += 20
            End If
        ElseIf (Form1.baretteDeVie4.Location.X > Form1.baliseLimite1.Location.X) And (Form1.baretteDeVie4.Location.Y > Form1.baliseLimite1.Location.Y) And (Form1.baretteDeVie4.Location.X < Form1.baliseLimite2.Location.X) And (Form1.baretteDeVie4.Location.Y < Form1.baliseLimite4.Location.Y) And (Form1.baretteDeVie4.Location.X > Form1.baliseLimite4.Location.X) And (Form1.baretteDeVie4.Location.Y < Form1.baliseLimit3.Location.Y) And (Form1.baretteDeVie4.Location.X < Form1.baliseLimit3.Location.X) Then
            Form1.Label47.Text = "On a recuperer la barette de vie."
            Try
                My.Computer.Audio.Play(sonProduitParRecuperationDeBaretteDeVie)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try
            barretteDeVieRestante -= 1
            Form1.baretteDeVie4.Location = pointQuelquonque
            If (Form1.healthPointBar.Value < 120) Then
                Form1.healthPointBar.Value += 20
            End If
        ElseIf (Form1.baretteDeVie5.Location.X > Form1.baliseLimite1.Location.X) And (Form1.baretteDeVie5.Location.Y > Form1.baliseLimite1.Location.Y) And (Form1.baretteDeVie5.Location.X < Form1.baliseLimite2.Location.X) And (Form1.baretteDeVie5.Location.Y < Form1.baliseLimite4.Location.Y) And (Form1.baretteDeVie5.Location.X > Form1.baliseLimite4.Location.X) And (Form1.baretteDeVie5.Location.Y < Form1.baliseLimit3.Location.Y) And (Form1.baretteDeVie5.Location.X < Form1.baliseLimit3.Location.X) Then
            Form1.Label47.Text = "On a recuperer la barette de vie."
            Try
                My.Computer.Audio.Play(sonProduitParRecuperationDeBaretteDeVie)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try
            barretteDeVieRestante -= 1
            Form1.baretteDeVie5.Location = pointQuelquonque
            If (Form1.healthPointBar.Value < 120) Then
                Form1.healthPointBar.Value += 20
            End If
        ElseIf (Form1.baretteDeVie6.Location.X > Form1.baliseLimite1.Location.X) And (Form1.baretteDeVie6.Location.Y > Form1.baliseLimite1.Location.Y) And (Form1.baretteDeVie6.Location.X < Form1.baliseLimite2.Location.X) And (Form1.baretteDeVie6.Location.Y < Form1.baliseLimite4.Location.Y) And (Form1.baretteDeVie6.Location.X > Form1.baliseLimite4.Location.X) And (Form1.baretteDeVie6.Location.Y < Form1.baliseLimit3.Location.Y) And (Form1.baretteDeVie6.Location.X < Form1.baliseLimit3.Location.X) Then
            Form1.Label47.Text = "On a recuperer la barette de vie."

            Try
                My.Computer.Audio.Play(sonProduitParRecuperationDeBaretteDeVie)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try
            barretteDeVieRestante -= 1
            Form1.baretteDeVie6.Location = pointQuelquonque
            If (Form1.healthPointBar.Value < 120) Then
                Form1.healthPointBar.Value += 20
            End If
        Else
            Form1.Label47.Text = "Not yet my friend."
        End If
        Form1.pointDeVieRestant.Text = Form1.healthPointBar.Value & "%"
        Form1.nombreDeBarreDeVieRestante.Text = barretteDeVieRestante
    End Sub
    Public Sub positionnerLesBarettesDeVieAuDebutDuJeu()
        'ICI on va choisir la position des barettes de vie  de maniere aleatoire.
        'La position des barette de vie est choisie en leur donnant les meme location que n'importe quelle case de la carte.
        'Puisque en donnant les memes location que les cases de la carte , les barettes vont se situer sur la case, dans le coin de la case comme un point normal.
        'Or pour nous la barette doit se situer au centre des cases, donc on va ajouter 37 en abscisse et 39 en ordonne de la barette pour la centrer.

        For Each elmts In tableauDesBarettesDeVie
            positionAleatoireChoisiePourLesBarettes = valAleatoire.Next(10, 120)

            While (tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesBarettes).Location = Form1.lim1Curseur.Location Or positionAleatoireChoisiePourLesBarettes = caseAleatoireChoisiePourKamikaze1 Or positionAleatoireChoisiePourLesBarettes = caseAleatoireChoisiePourKamikaze2 Or positionAleatoireChoisiePourLesBarettes = caseAleatoireChoisiePourKamikaze3 Or positionAleatoireChoisiePourLesBarettes = caseAleatoireChoisiePourKamikaze4 Or positionAleatoireChoisiePourLesBarettes = caseAleatoireChoisiePourKamikaze5)
                positionAleatoireChoisiePourLesBarettes = valAleatoire.Next(10, 120) 'Les kamikazes , les barettes, le panzerJoy n'auront plus les memes positions ici
            End While


            elmts.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesBarettes).Location
            copieDeLabaretteDeVie = elmts.Location
            copieDeLabaretteDeVie.X += 37
            copieDeLabaretteDeVie.Y += 39
            elmts.Location = copieDeLabaretteDeVie
        Next
    End Sub

    Public Sub positionnerLesKamikazesAuDebutDuJeu(ByVal enemiX As Label)
        'For Each elmts In tableauDesKamikazes
        'RETIRER DES POINTS LORSQU'ON PERD ENLEVER SUR LE SCORE.
        If (enemiX.Equals(Form1.enemi5)) Then
            'positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(40, 60)
            'enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Do 'ICI ON FAIT EN SORTE QUE LA POSITION DU KAMIKAZE NE SOIT PAS LA MEME QUE CELLE DU PANZERJOY
                positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(40, 60)
                enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Loop While (enemiX.Location.Equals(Form1.lim1Curseur.Location))

            copieDeLabaretteDeVie = enemiX.Location
            copieDeLabaretteDeVie.X += 39
            copieDeLabaretteDeVie.Y += 39
            enemiX.Location = copieDeLabaretteDeVie
            caseAleatoireChoisiePourKamikaze1 = positionAleatoireChoisiePourLesKamiKazes
        ElseIf (enemiX.Equals(Form1.enemi6)) Then
            'positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(80, 100)
            'enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Do 'ICI ON FAIT EN SORTE QUE LA POSITION DU KAMIKAZE NE SOIT PAS LA MEME QUE CELLE DU PANZERJOY
                positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(80, 100)
                enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Loop While (enemiX.Location.Equals(Form1.lim1Curseur.Location))

            copieDeLabaretteDeVie = enemiX.Location
            copieDeLabaretteDeVie.X += 39
            copieDeLabaretteDeVie.Y += 39
            enemiX.Location = copieDeLabaretteDeVie
            caseAleatoireChoisiePourKamikaze2 = positionAleatoireChoisiePourLesKamiKazes
        ElseIf (enemiX.Equals(Form1.enemi4)) Then
            'positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(20, 70)
            'enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Do 'ICI ON FAIT EN SORTE QUE LA POSITION DU KAMIKAZE NE SOIT PAS LA MEME QUE CELLE DU PANZERJOY
                positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(20, 70)
                enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Loop While (enemiX.Location.Equals(Form1.lim1Curseur.Location))

            copieDeLabaretteDeVie = enemiX.Location
            copieDeLabaretteDeVie.X += 39
            copieDeLabaretteDeVie.Y += 39
            enemiX.Location = copieDeLabaretteDeVie
            caseAleatoireChoisiePourKamikaze3 = positionAleatoireChoisiePourLesKamiKazes
        ElseIf (enemiX.Equals(Form1.enemi3)) Then
            'positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(30, 40)
            'enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Do 'ICI ON FAIT EN SORTE QUE LA POSITION DU KAMIKAZE NE SOIT PAS LA MEME QUE CELLE DU PANZERJOY
                positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(30, 40)
                enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Loop While (enemiX.Location.Equals(Form1.lim1Curseur.Location))

            copieDeLabaretteDeVie = enemiX.Location
            copieDeLabaretteDeVie.X += 39
            copieDeLabaretteDeVie.Y += 39
            enemiX.Location = copieDeLabaretteDeVie
            caseAleatoireChoisiePourKamikaze4 = positionAleatoireChoisiePourLesKamiKazes
        ElseIf (enemiX.Equals(Form1.enemi2)) Then

            'positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(20, 50)
            'enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Do 'ICI ON FAIT EN SORTE QUE LA POSITION DU KAMIKAZE NE SOIT PAS LA MEME QUE CELLE DU PANZERJOY, ON REPOSITIONE A CHAQUE FOIS C'EST LE CAS.
                positionAleatoireChoisiePourLesKamiKazes = valAleatoire.Next(20, 50)
                enemiX.Location = tableauDesCasesDeLaCarte(positionAleatoireChoisiePourLesKamiKazes).Location
            Loop While (enemiX.Location.Equals(Form1.lim1Curseur.Location))

            copieDeLabaretteDeVie = enemiX.Location
            copieDeLabaretteDeVie.X += 39
            copieDeLabaretteDeVie.Y += 39
            enemiX.Location = copieDeLabaretteDeVie
            caseAleatoireChoisiePourKamikaze5 = positionAleatoireChoisiePourLesKamiKazes
        End If

        'Next
    End Sub

    Public Sub leKamikazeAttaqueSurL_horizontale() 'Soit la droite ,soit la gauche.
        unPoint2 = Form1.enemi6.Location
        If (Form1.panzerJoy.Location.X < Form1.enemi6.Location.X) Then 'Le PanzerJoy se trouve à gauche.
            leKamikazePeutToucherLePanzerJoyOuUneCaseSurLaGauche()
            'Form1.Label22.Text = "On est sur la gauche"
        ElseIf (Form1.panzerJoy.Location.X > Form1.enemi6.Location.X) 'Le PanzerJoy se trouve à droite.
            leKamikazePeutToucherLePanzerJoyOuUneCaseSurLaDroite()
            'Form1.Label22.Text = "On est sur la droite"
        End If
    End Sub
    Public Sub leKamikazeAttaqueSurLaVerticale() 'Soit le haut ,soit le bas.

        If (Form1.panzerJoy.Location.Y < Form1.enemi6.Location.Y) Then 'Vers le haut.
            leKamikazePeutToucherLePanzerJoyOuUneCaseSurLeHaut()
            'Form1.Label22.Text = "On est sur le haut 00."
        ElseIf (Form1.panzerJoy.Location.Y > Form1.enemi6.Location.Y) Then 'Vers le haut.
            leKamikazePeutToucherLePanzerJoyOuUneCaseSurLeBas()
            'Form1.Label22.Text = "On est sur le bas."
        End If

    End Sub
    Public Function verifierSiLeKamikazeToucheUneCase() As Boolean
        For Each elmts In tableauDesCasesDeLaCarte
            If (unPoint3 = elmts.Location) Then
                estCeQueLeKamikazeToucheUneCaseAuCoursDeSonDepLacement = True
                Return estCeQueLeKamikazeToucheUneCaseAuCoursDeSonDepLacement
            Else
                estCeQueLeKamikazeToucheUneCaseAuCoursDeSonDepLacement = False
            End If
        Next
        Return estCeQueLeKamikazeToucheUneCaseAuCoursDeSonDepLacement
    End Function

    '#######################################################################"
    'LE KAMIKAZE SUIT LE PANZERJOY SOIT SUR L'AXE DES ABSCISSES , SOIT SUR L'AXE DES ORDONNEES, PAS LES DEUX EN MEME TEMPS , L'INSTRUCTION_X permet de s'assurer que le Kamikaze ne suive le panzerJoy que sur un seul axe à  la fois. 
    'L'INSTRUCTION_X :consiste à arreter le timerAttaqueDuKamikazeSurLhorizontale lorsque le timerAttaqueDuKamikazeSurLaVerticale est activé
    '                :consiste à arreter le timerAttaqueDuKamikazeSurLaVerticale lorsque le timerAttaqueDuKamikazeSurLhorizontale est activé 

    '#######################################################################"
    Public Sub leKamikazePeutToucherLePanzerJoyOuUneCaseSurLaDroite()
        'Instruction1 : Cette instruction supplementaire est semblable à celle qui la precede , elle permet de corriger le mouvement du kamikaze, si tu veux voir l'erreur qu'elle corrige alors met en commentaire et observe.
        unPoint3.X = unPoint2.X + 51
        unPoint3.Y = unPoint2.Y - 39 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3.X < Form1.Width) Then
            If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case2."
                Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'Form1.deplacementKamikazeBloquerVersLaDroiteVaAGauche.Start()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2.X += 90

                Form1.enemi6.Location = unPoint2


                unPoint3.X = unPoint2.X + 51
                unPoint3.Y = unPoint2.Y - 39

                'ICI If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                '    'Instruction1
                '    Form1.Label15.Text = "le kamikaze a toucher la case2."
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
                If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi6.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                End If
            End If
        Else

        End If
    End Sub
    Public Sub leKamikazePeutToucherLePanzerJoyOuUneCaseSurLaGauche()

        unPoint3.X = unPoint2.X - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier s'il a les memes coordonnees que la case.
        unPoint3.Y = unPoint2.Y - 39

        If (unPoint3.X > 0) Then 'Verifier si le kamikaze a depassé la limite gauche.
            Form1.Label22.Text = "Xzer : " & Form1.lim4.Location.X & " XKami : " & Form1.enemi6.Location.X
            If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case108.Location Or unPoint3 = Form1.case107.Location Or unPoint3 = Form1.case77.Location Or unPoint3 = Form1.case78.Location) Then 'Pendant que le kamikaze touche une case, le kami est statique et le panzer le touche.
                Form1.Label15.Text = "le kamikaze a toucher la case."
                Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2.X -= 90
                Form1.enemi6.Location = unPoint2
                If (Form1.enemi6.Location.X < Form1.lim3.Location.X) And (Form1.enemi6.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then 'le kami est situer entre la lim2 et la lim3, pendant  que le kamikaze est statique sans toucher quoi que ce soit
                    Form1.Label22.Text = "On a toucher le panzeR111Joy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi6.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If
    End Sub
    Public Sub leKamikazePeutToucherLePanzerJoyOuUneCaseSurLeHaut()
        unPoint3.X = unPoint2.X - 39
        unPoint3.Y = unPoint2.Y - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3.Y > 0) Then
            If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case52.Location Or unPoint3 = Form1.case37.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du haut."
                Form1.leKamikazeAttaqueParLaVerticale.Stop()
                'Ici il faut que si le kamikaze bute sur la case haut, alors il doit avoir d'autres choix 
                'soit vers la droite , vers la gauche , vers le bas, ceci pourrait etre un ajout pour une prochaine mise à jour. 
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2.Y -= 90
                Form1.enemi6.Location = unPoint2
                If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer44drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi6.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikazeAttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If
    End Sub
    Public Sub leKamikazePeutToucherLePanzerJoyOuUneCaseSurLeBas()
        unPoint3.X = unPoint2.X - 39
        unPoint3.Y = unPoint2.Y + 51
        'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3.Y < Form1.Height) Then
            If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case82.Location Or unPoint3 = Form1.case97.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du bas."
                Form1.leKamikazeAttaqueParLaVerticale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2.Y += 90
                Form1.enemi6.Location = unPoint2
                If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer894drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi6.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikazeAttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    '#############Ces directions sont pour l'enemi6###################
    '#######################################################################"

    Public Sub leKamikaze5AttaqueSurL_horizontale() 'Soit la droite ,soit la gauche.
        unPoint2Enemi5 = Form1.enemi5.Location
        If (Form1.panzerJoy.Location.X < Form1.enemi5.Location.X) Then 'Le PanzerJoy se trouve à gauche.
            leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLaGauche()
            'Form1.Label22.Text = "On est sur la gauche"
        ElseIf (Form1.panzerJoy.Location.X > Form1.enemi5.Location.X) 'Le PanzerJoy se trouve à droite.
            leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
            'Form1.Label22.Text = "On est sur la droite"
        End If
    End Sub
    Public Sub leKamikaze5AttaqueSurLaVerticale() 'Soit le haut ,soit le bas.

        If (Form1.panzerJoy.Location.Y < Form1.enemi5.Location.Y) Then 'Vers le haut.
            leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
            'Form1.Label22.Text = "On est sur le haut 00."
        ElseIf (Form1.panzerJoy.Location.Y > Form1.enemi5.Location.Y) Then 'Vers le haut.
            leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLeBas()
            'Form1.Label22.Text = "On est sur le bas."
        End If

    End Sub
    Public Function verifierSiLeKamikaze5ToucheUneCase() As Boolean
        For Each elmts In tableauDesCasesDeLaCarte
            If (unPoint3Enemi5 = elmts.Location) Then
                estCeQueLeKamikaze5ToucheUneCaseAuCoursDeSonDepLacement = True
                Return estCeQueLeKamikaze5ToucheUneCaseAuCoursDeSonDepLacement
            Else
                estCeQueLeKamikaze5ToucheUneCaseAuCoursDeSonDepLacement = False
            End If
        Next
        Return estCeQueLeKamikaze5ToucheUneCaseAuCoursDeSonDepLacement
    End Function


    Public Sub leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLaGauche()

        unPoint3Enemi5.X = unPoint2Enemi5.X - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier s'il a les memes coordonnees que la case.
        unPoint3Enemi5.Y = unPoint2Enemi5.Y - 39

        If (unPoint3Enemi5.X > 0) Then 'Verifier si le kamikaze a depassé la limite gauche.
            Form1.Label22.Text = "Xzer : " & Form1.lim4.Location.X & " XKami : " & Form1.enemi6.Location.X
            If (verifierSiLeKamikaze5ToucheUneCase()) Then '(unPoint3 = Form1.case108.Location Or unPoint3 = Form1.case107.Location Or unPoint3 = Form1.case77.Location Or unPoint3 = Form1.case78.Location) Then 'Pendant que le kamikaze touche une case, le kami est statique et le panzer le touche.
                Form1.Label15.Text = "le kamikaze a toucher la case."
                Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi5.X -= 90
                Form1.enemi5.Location = unPoint2Enemi5
                If (Form1.enemi5.Location.X < Form1.lim3.Location.X) And (Form1.enemi5.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi5.Location.Y > Form1.lim2.Location.Y) Then 'le kami est situer entre la lim2 et la lim3, pendant  que le kamikaze est statique sans toucher quoi que ce soit
                    Form1.Label22.Text = "On a toucher le panzeR111Joy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi5.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    Public Sub leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
        'Instruction1 : Cette instruction supplementaire est semblable à celle qui la precede , elle permet de corriger le mouvement du kamikaze, si tu veux voir l'erreur qu'elle corrige alors met en commentaire et observe.
        unPoint3Enemi5.X = unPoint2Enemi5.X + 51
        unPoint3Enemi5.Y = unPoint2Enemi5.Y - 39 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi5.X < Form1.Width) Then
            If (verifierSiLeKamikaze5ToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case2."
                Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
                'Form1.deplacementKamikazeBloquerVersLaDroiteVaAGauche.Start()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi5.X += 90

                Form1.enemi5.Location = unPoint2Enemi5

                unPoint3Enemi5.X = unPoint2Enemi5.X + 51
                unPoint3Enemi5.Y = unPoint2Enemi5.Y - 39

                'ICI If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                '    'Instruction1
                '    Form1.Label15.Text = "le kamikaze a toucher la case2."
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
                If (Form1.enemi5.Location.X > Form1.lim4.Location.X) And (Form1.enemi5.Location.X < Form1.lim2.Location.X) And (Form1.enemi5.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi5.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi5.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else

        End If
    End Sub
    Public Sub leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
        unPoint3Enemi5.X = unPoint2Enemi5.X - 39
        unPoint3Enemi5.Y = unPoint2Enemi5.Y - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi5.Y > 0) Then
            If (verifierSiLeKamikaze5ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case52.Location Or unPoint3 = Form1.case37.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du haut."
                Form1.leKamikaze5AttaqueParLaVerticale.Stop()
                'Ici il faut que si le kamikaze bute sur la case haut, alors il doit avoir d'autres choix 
                'soit vers la droite , vers la gauche , vers le bas, ceci pourrait etre un ajout pour une prochaine mise à jour. 
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi5.Y -= 90
                Form1.enemi5.Location = unPoint2Enemi5
                If (Form1.enemi5.Location.X > Form1.lim4.Location.X) And (Form1.enemi5.Location.X < Form1.lim2.Location.X) And (Form1.enemi5.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi5.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer44drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi5.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze5AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If
    End Sub
    Public Sub leKamikaze5PeutToucherLePanzerJoyOuUneCaseSurLeBas()
        unPoint3Enemi5.X = unPoint2Enemi5.X - 39
        unPoint3Enemi5.Y = unPoint2Enemi5.Y + 51
        'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi5.Y < Form1.Height) Then
            If (verifierSiLeKamikaze5ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case82.Location Or unPoint3 = Form1.case97.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du bas."
                Form1.leKamikaze5AttaqueParLaVerticale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi5.Y += 90
                Form1.enemi5.Location = unPoint2Enemi5
                If (Form1.enemi5.Location.X > Form1.lim4.Location.X) And (Form1.enemi5.Location.X < Form1.lim2.Location.X) And (Form1.enemi5.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi5.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer894drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi5.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze5AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    '#############Ces directions sont pour l'enemi5###################
    '#######################################################################"

    Public Sub leKamikaze4AttaqueSurL_horizontale() 'Soit la droite ,soit la gauche.
        unPoint2Enemi4 = Form1.enemi4.Location
        If (Form1.panzerJoy.Location.X < Form1.enemi4.Location.X) Then 'Le PanzerJoy se trouve à gauche.
            leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLaGauche()
            'Form1.Label22.Text = "On est sur la gauche"
        ElseIf (Form1.panzerJoy.Location.X > Form1.enemi4.Location.X) 'Le PanzerJoy se trouve à droite.
            leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
            'Form1.Label22.Text = "On est sur la droite"
        End If
    End Sub
    Public Sub leKamikaze4AttaqueSurLaVerticale() 'Soit le haut ,soit le bas.

        If (Form1.panzerJoy.Location.Y < Form1.enemi4.Location.Y) Then 'Vers le haut.
            leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
            'Form1.Label22.Text = "On est sur le haut 00."
        ElseIf (Form1.panzerJoy.Location.Y > Form1.enemi4.Location.Y) Then 'Vers le haut.
            leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLeBas()
            'Form1.Label22.Text = "On est sur le bas."
        End If

    End Sub

    Public Function verifierSiLeKamikaze4ToucheUneCase() As Boolean
        For Each elmts In tableauDesCasesDeLaCarte
            If (unPoint3Enemi4 = elmts.Location) Then
                estCeQueLeKamikaze4ToucheUneCaseAuCoursDeSonDepLacement = True
                Return estCeQueLeKamikaze4ToucheUneCaseAuCoursDeSonDepLacement
            Else
                estCeQueLeKamikaze4ToucheUneCaseAuCoursDeSonDepLacement = False
            End If
        Next
        Return estCeQueLeKamikaze4ToucheUneCaseAuCoursDeSonDepLacement
    End Function

    Public Sub leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLaGauche()

        unPoint3Enemi4.X = unPoint2Enemi4.X - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier s'il a les memes coordonnees que la case.
        unPoint3Enemi4.Y = unPoint2Enemi4.Y - 39

        If (unPoint3Enemi4.X > 0) Then 'Verifier si le kamikaze a depassé la limite gauche.
            Form1.Label22.Text = "Xzer : " & Form1.lim4.Location.X & " XKami : " & Form1.enemi6.Location.X
            If (verifierSiLeKamikaze4ToucheUneCase()) Then '(unPoint3 = Form1.case108.Location Or unPoint3 = Form1.case107.Location Or unPoint3 = Form1.case77.Location Or unPoint3 = Form1.case78.Location) Then 'Pendant que le kamikaze touche une case, le kami est statique et le panzer le touche.
                Form1.Label15.Text = "le kamikaze a toucher la case."
                Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi4.X -= 90
                Form1.enemi4.Location = unPoint2Enemi4
                If (Form1.enemi4.Location.X < Form1.lim3.Location.X) And (Form1.enemi4.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi4.Location.Y > Form1.lim2.Location.Y) Then 'le kami est situer entre la lim2 et la lim3, pendant  que le kamikaze est statique sans toucher quoi que ce soit
                    Form1.Label22.Text = "On a toucher le panzeR111Joy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi4.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    Public Sub leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
        unPoint3Enemi4.X = unPoint2Enemi4.X - 39
        unPoint3Enemi4.Y = unPoint2Enemi4.Y - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi4.Y > 0) Then
            If (verifierSiLeKamikaze4ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case52.Location Or unPoint3 = Form1.case37.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du haut."
                'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                Form1.leKamikaze4AttaqueParLaVerticale.Stop()
                'Ici il faut que si le kamikaze bute sur la case haut, alors il doit avoir d'autres choix 
                'soit vers la droite , vers la gauche , vers le bas, ceci pourrait etre un ajout pour une prochaine mise à jour. 
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi4.Y -= 90
                Form1.enemi4.Location = unPoint2Enemi4
                If (Form1.enemi4.Location.X > Form1.lim4.Location.X) And (Form1.enemi4.Location.X < Form1.lim2.Location.X) And (Form1.enemi4.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi4.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer44drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi4.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze4AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If
    End Sub
    Public Sub leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLeBas()
        unPoint3Enemi4.X = unPoint2Enemi4.X - 39
        unPoint3Enemi4.Y = unPoint2Enemi4.Y + 51
        'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi4.Y < Form1.Height) Then
            If (verifierSiLeKamikaze4ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case82.Location Or unPoint3 = Form1.case97.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du bas."
                Form1.leKamikaze4AttaqueParLaVerticale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi4.Y += 90
                Form1.enemi4.Location = unPoint2Enemi4
                If (Form1.enemi4.Location.X > Form1.lim4.Location.X) And (Form1.enemi4.Location.X < Form1.lim2.Location.X) And (Form1.enemi4.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi4.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer894drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi4.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze4AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    Public Sub leKamikaze4PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
        'Instruction1 : Cette instruction supplementaire est semblable à celle qui la precede , elle permet de corriger le mouvement du kamikaze, si tu veux voir l'erreur qu'elle corrige alors met en commentaire et observe.
        unPoint3Enemi4.X = unPoint2Enemi4.X + 51
        unPoint3Enemi4.Y = unPoint2Enemi4.Y - 39 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi4.X < Form1.Width) Then
            If (verifierSiLeKamikaze4ToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case2."
                Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
                'Form1.deplacementKamikazeBloquerVersLaDroiteVaAGauche.Start()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi4.X += 90

                Form1.enemi4.Location = unPoint2Enemi4

                unPoint3Enemi4.X = unPoint2Enemi4.X + 51
                unPoint3Enemi4.Y = unPoint2Enemi4.Y - 39

                'ICI If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                '    'Instruction1
                '    Form1.Label15.Text = "le kamikaze a toucher la case2."
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
                If (Form1.enemi4.Location.X > Form1.lim4.Location.X) And (Form1.enemi4.Location.X < Form1.lim2.Location.X) And (Form1.enemi4.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi4.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi4.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else

        End If
    End Sub

    Public Sub leKamikaze3AttaqueSurL_horizontale() 'Soit la droite ,soit la gauche.

        unPoint2Enemi3 = Form1.enemi3.Location
        If (Form1.panzerJoy.Location.X < Form1.enemi3.Location.X) Then 'Le PanzerJoy se trouve à gauche.
            leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLaGauche()
            'Form1.Label22.Text = "On est sur la gauche"
        ElseIf (Form1.panzerJoy.Location.X > Form1.enemi3.Location.X) 'Le PanzerJoy se trouve à droite.
            leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
            'Form1.Label22.Text = "On est sur la droite"
        End If

    End Sub
    Public Sub leKamikaze3AttaqueSurLaVerticale() 'Soit le haut ,soit le bas.

        If (Form1.panzerJoy.Location.Y < Form1.enemi3.Location.Y) Then 'Vers le haut.
            leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
            'Form1.Label22.Text = "On est sur le haut 00."
        ElseIf (Form1.panzerJoy.Location.Y > Form1.enemi3.Location.Y) Then 'Vers le haut.
            leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLeBas()
            'Form1.Label22.Text = "On est sur le bas."
        End If

    End Sub
    Public Sub leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLaGauche()

        unPoint3Enemi3.X = unPoint2Enemi3.X - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier s'il a les memes coordonnees que la case.
        unPoint3Enemi3.Y = unPoint2Enemi3.Y - 39

        If (unPoint3Enemi3.X > 0) Then 'Verifier si le kamikaze a depassé la limite gauche.
            Form1.Label22.Text = "Xzer : " & Form1.lim4.Location.X & " XKami : " & Form1.enemi6.Location.X
            If (verifierSiLeKamikaze3ToucheUneCase()) Then '(unPoint3 = Form1.case108.Location Or unPoint3 = Form1.case107.Location Or unPoint3 = Form1.case77.Location Or unPoint3 = Form1.case78.Location) Then 'Pendant que le kamikaze touche une case, le kami est statique et le panzer le touche.
                Form1.Label15.Text = "le kamikaze a toucher la case."
                Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi3.X -= 90
                Form1.enemi3.Location = unPoint2Enemi3
                If (Form1.enemi3.Location.X < Form1.lim3.Location.X) And (Form1.enemi3.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi3.Location.Y > Form1.lim2.Location.Y) Then 'le kami est situer entre la lim2 et la lim3, pendant  que le kamikaze est statique sans toucher quoi que ce soit
                    Form1.Label22.Text = "On a toucher le panzeR111Joy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi3.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    Public Sub leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
        unPoint3Enemi3.X = unPoint2Enemi3.X - 39
        unPoint3Enemi3.Y = unPoint2Enemi3.Y - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi3.Y > 0) Then
            If (verifierSiLeKamikaze3ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case52.Location Or unPoint3 = Form1.case37.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du haut."
                Form1.leKamikaze3AttaqueParLaVerticale.Stop()
                'Ici il faut que si le kamikaze bute sur la case haut, alors il doit avoir d'autres choix 
                'soit vers la droite , vers la gauche , vers le bas, ceci pourrait etre un ajout pour une prochaine mise à jour. 
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi3.Y -= 90
                Form1.enemi3.Location = unPoint2Enemi3
                If (Form1.enemi3.Location.X > Form1.lim4.Location.X) And (Form1.enemi3.Location.X < Form1.lim2.Location.X) And (Form1.enemi3.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi3.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer44drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi3.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze3AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If
    End Sub
    Public Sub leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLeBas()
        unPoint3Enemi3.X = unPoint2Enemi3.X - 39
        unPoint3Enemi3.Y = unPoint2Enemi3.Y + 51
        'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi3.Y < Form1.Height) Then
            If (verifierSiLeKamikaze3ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case82.Location Or unPoint3 = Form1.case97.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du bas."
                Form1.leKamikaze3AttaqueParLaVerticale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi3.Y += 90
                Form1.enemi3.Location = unPoint2Enemi3
                If (Form1.enemi3.Location.X > Form1.lim4.Location.X) And (Form1.enemi3.Location.X < Form1.lim2.Location.X) And (Form1.enemi3.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi3.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer894drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi3.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze3AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    Public Sub leKamikaze3PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
        'Instruction1 : Cette instruction supplementaire est semblable à celle qui la precede , elle permet de corriger le mouvement du kamikaze, si tu veux voir l'erreur qu'elle corrige alors met en commentaire et observe.
        unPoint3Enemi3.X = unPoint2Enemi3.X + 51
        unPoint3Enemi3.Y = unPoint2Enemi3.Y - 39 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi3.X < Form1.Width) Then
            If (verifierSiLeKamikaze3ToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case2."
                Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
                'Form1.deplacementKamikazeBloquerVersLaDroiteVaAGauche.Start()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi3.X += 90

                Form1.enemi3.Location = unPoint2Enemi3

                unPoint3Enemi3.X = unPoint2Enemi3.X + 51
                unPoint3Enemi3.Y = unPoint2Enemi3.Y - 39

                'ICI If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                '    'Instruction1
                '    Form1.Label15.Text = "le kamikaze a toucher la case2."
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
                If (Form1.enemi3.Location.X > Form1.lim4.Location.X) And (Form1.enemi3.Location.X < Form1.lim2.Location.X) And (Form1.enemi3.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi3.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi3.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else

        End If
    End Sub
    Public Function verifierSiLeKamikaze3ToucheUneCase() As Boolean
        For Each elmts In tableauDesCasesDeLaCarte
            If (unPoint3Enemi3 = elmts.Location) Then
                estCeQueLeKamikaze3ToucheUneCaseAuCoursDeSonDepLacement = True
                Return estCeQueLeKamikaze3ToucheUneCaseAuCoursDeSonDepLacement
            Else
                estCeQueLeKamikaze3ToucheUneCaseAuCoursDeSonDepLacement = False
            End If
        Next
        Return estCeQueLeKamikaze3ToucheUneCaseAuCoursDeSonDepLacement
    End Function

    Public Sub leKamikaze2AttaqueSurL_horizontale() 'Soit la droite ,soit la gauche.

        unPoint2Enemi2 = Form1.enemi2.Location
        If (Form1.panzerJoy.Location.X < Form1.enemi2.Location.X) Then 'Le PanzerJoy se trouve à gauche.
            leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLaGauche()
            'Form1.Label22.Text = "On est sur la gauche"
        ElseIf (Form1.panzerJoy.Location.X > Form1.enemi2.Location.X) 'Le PanzerJoy se trouve à droite.
            leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
            'Form1.Label22.Text = "On est sur la droite"
        End If

    End Sub
    Public Sub leKamikaze2AttaqueSurLaVerticale() 'Soit le haut ,soit le bas.

        If (Form1.panzerJoy.Location.Y < Form1.enemi2.Location.Y) Then 'Vers le haut.
            leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
            'Form1.Label22.Text = "On est sur le haut 00."
        ElseIf (Form1.panzerJoy.Location.Y > Form1.enemi2.Location.Y) Then 'Vers le haut.
            leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLeBas()
            'Form1.Label22.Text = "On est sur le bas."
        End If

    End Sub
    Public Sub leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLaGauche()

        unPoint3Enemi2.X = unPoint2Enemi2.X - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier s'il a les memes coordonnees que la case.
        unPoint3Enemi2.Y = unPoint2Enemi2.Y - 39

        If (unPoint3Enemi2.X > 0) Then 'Verifier si le kamikaze a depassé la limite gauche.
            Form1.Label22.Text = "Xzer : " & Form1.lim4.Location.X & " XKami : " & Form1.enemi6.Location.X
            If (verifierSiLeKamikaze2ToucheUneCase()) Then '(unPoint3 = Form1.case108.Location Or unPoint3 = Form1.case107.Location Or unPoint3 = Form1.case77.Location Or unPoint3 = Form1.case78.Location) Then 'Pendant que le kamikaze touche une case, le kami est statique et le panzer le touche.
                Form1.Label15.Text = "le kamikaze a toucher la case."
                Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi2.X -= 90
                Form1.enemi2.Location = unPoint2Enemi2
                If (Form1.enemi2.Location.X < Form1.lim3.Location.X) And (Form1.enemi2.Location.Y < Form1.lim3.Location.Y) And (Form1.enemi2.Location.Y > Form1.lim2.Location.Y) Then 'le kami est situer entre la lim2 et la lim3, pendant  que le kamikaze est statique sans toucher quoi que ce soit
                    Form1.Label22.Text = "On a toucher le panzeR111Joy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi2.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub
    Public Sub leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLaDroite()
        'Instruction1 : Cette instruction supplementaire est semblable à celle qui la precede , elle permet de corriger le mouvement du kamikaze, si tu veux voir l'erreur qu'elle corrige alors met en commentaire et observe.
        unPoint3Enemi2.X = unPoint2Enemi2.X + 51
        unPoint3Enemi2.Y = unPoint2Enemi2.Y - 39 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi2.X < Form1.Width) Then
            If (verifierSiLeKamikaze2ToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case2."
                Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
                'Form1.deplacementKamikazeBloquerVersLaDroiteVaAGauche.Start()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi2.X += 90

                Form1.enemi2.Location = unPoint2Enemi2

                unPoint3Enemi2.X = unPoint2Enemi2.X + 51
                unPoint3Enemi2.Y = unPoint2Enemi2.Y - 39

                'ICI If (verifierSiLeKamikazeToucheUneCase()) Then '(unPoint3 = Form1.case83.Location Or unPoint3 = Form1.case84.Location Or unPoint3 = Form1.case85.Location Or unPoint3 = Form1.case86.Location) Then 'Pendant que le kamikaze touche une case. 
                '    'Instruction1
                '    Form1.Label15.Text = "le kamikaze a toucher la case2."
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If

                If (Form1.enemi2.Location.X > Form1.lim4.Location.X) And (Form1.enemi2.Location.X < Form1.lim2.Location.X) And (Form1.enemi2.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi2.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi2.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
                End If
            End If
        Else

        End If
    End Sub
    Public Sub leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLeHaut()
        unPoint2Enemi2.X = unPoint2Enemi2.X - 39
        unPoint2Enemi2.Y = unPoint2Enemi2.Y - 129 'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi2.Y > 0) Then
            If (verifierSiLeKamikaze2ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case52.Location Or unPoint3 = Form1.case37.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du haut."
                Form1.leKamikaze2AttaqueParLaVerticale.Stop()
                'Ici il faut que si le kamikaze bute sur la case haut, alors il doit avoir d'autres choix 
                'soit vers la droite , vers la gauche , vers le bas, ceci pourrait etre un ajout pour une prochaine mise à jour. 
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi2.Y -= 90
                Form1.enemi2.Location = unPoint2Enemi2
                If (Form1.enemi2.Location.X > Form1.lim4.Location.X) And (Form1.enemi2.Location.X < Form1.lim2.Location.X) And (Form1.enemi2.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi2.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer44drJoy"
                    'My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    Form1.enemi2.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze2AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If
    End Sub
    Public Sub leKamikaze2PeutToucherLePanzerJoyOuUneCaseSurLeBas()
        unPoint3Enemi2.X = unPoint2Enemi2.X - 39
        unPoint3Enemi2.Y = unPoint2Enemi2.Y + 51
        'Recuperer la position du kamikaze avant qu'il ne soit lancé et verifier si meme abscisse que case.

        If (unPoint3Enemi2.Y < Form1.Height) Then
            If (verifierSiLeKamikaze2ToucheUneCase()) Then '(unPoint3 = Form1.case67.Location Or unPoint3 = Form1.case82.Location Or unPoint3 = Form1.case97.Location) Then 'Pendant que le kamikaze touche une case. 
                Form1.Label15.Text = "le kamikaze a toucher la case du bas."
                Form1.leKamikaze2AttaqueParLaVerticale.Stop()
            Else
                'On fait avancer le kamikaze jusqu'à atteindre le panzerJoy ou les limites ou une case.
                unPoint2Enemi2.Y += 90
                Form1.enemi2.Location = unPoint2Enemi2
                If (Form1.enemi2.Location.X > Form1.lim4.Location.X) And (Form1.enemi2.Location.X < Form1.lim2.Location.X) And (Form1.enemi2.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi2.Location.Y > Form1.lim2.Location.Y) Then
                    Form1.Label22.Text = "On a toucher le panzer894drJoy"
                    'Try
                    '    My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
                    'Catch ex As Exception
                    '    MsgBox(vbExclamation, "veuillez saisir les chemins d'acces aux fichiers sonores!")
                    'End Try
                    'Form1.enemi2.Location = pointQuelquonque
                    retirerDesBarettesDeVieAuPanzerJoy()
                    Form1.leKamikaze2AttaqueParLaVerticale.Stop()
                End If
                'If (Form1.enemi6.Location.X > Form1.lim4.Location.X) And (Form1.enemi6.Location.X < Form1.lim2.Location.X) And (Form1.enemi6.Location.Y < Form1.lim4.Location.Y) And (Form1.enemi6.Location.Y > Form1.lim2.Location.Y) Then
                '    Form1.Label22.Text = "On a toucher le panzeRRRRrJoy"
                '    Form1.enemi6.Location = pointQuelquonque
                '    Form1.leKamikazeAttaqueParL_Horizontale.Stop()
                'End If
            End If
        Else
            'Ici on met cette condition pour verifier si le panzerJoy touche de lui meme l'enemi qui est statique, quand il ne peut plus avancer.
        End If

    End Sub

    Public Function verifierSiLeKamikaze2ToucheUneCase() As Boolean
        For Each elmts In tableauDesCasesDeLaCarte
            If (unPoint3Enemi2 = elmts.Location) Then
                estCeQueLeKamikaze2ToucheUneCaseAuCoursDeSonDepLacement = True
                Return estCeQueLeKamikaze2ToucheUneCaseAuCoursDeSonDepLacement
            Else
                estCeQueLeKamikaze2ToucheUneCaseAuCoursDeSonDepLacement = False
            End If
        Next
        Return estCeQueLeKamikaze2ToucheUneCaseAuCoursDeSonDepLacement
    End Function

    Public Sub verifierSiLePanzerJoySeTrouveDansLaLigneDeMirDuKamikaze123456(ByRef enemiX As Label)
        If (enemiX.Location.X > Form1.lim4.Location.X) And (enemiX.Location.X < Form1.lim2.Location.X) And (enemiX.Location.Y < Form1.lim4.Location.Y) And (enemiX.Location.Y > Form1.lim2.Location.Y) Then
            'Ici on verifie si le kamikaze se trouve dans le panzerJoy, donc on determine si le panzerJoy a toucher le kamikaze de son plein grès.
            Form1.Label22.Text = "On a toucher le panzer5555f044drJoy"

            enemiX.Location = pointQuelquonque

            If (enemiX.Equals(Form1.enemi6)) Then
                Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi5))
                Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi4))
                Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi3))
                Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi2))
                Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
            End If

            retirerDesBarettesDeVieAuPanzerJoy()
            'End If si il y'a une erreur decommente ça d'abord et laisse comme ça. Et enleve aussi le ElseA cote du ElseIf 
            'Ici en bas.

        ElseIf (enemiX.Location.Y < Form1.lim3.Location.Y) And (enemiX.Location.Y > Form1.lim2.Location.Y) And ((Form1.panzerJoy.Location.X < enemiX.Location.X) Or (Form1.panzerJoy.Location.X > enemiX.Location.X)) Then
            'Ici le panzerJoy est dans la ligne de mir  du Kamikaze par la droite ou la gauche
            'Form1.Label15.Text = "Location Y : " & Form1.lim3.Location.Y & " | Y.K : " & Form1.enemi6.Location.Y
            'Form1.leKamikazeAttaqueParL_Horizontale.Start()
            'Form1.leKamikazeAttaqueParLaVerticale.Stop()

            If (enemiX.Equals(Form1.enemi6)) Then
                Form1.leKamikazeAttaqueParL_Horizontale.Start()
                Form1.leKamikazeAttaqueParLaVerticale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi5)) Then
                Form1.leKamikaze5AttaqueParL_Horizontale.Start()
                Form1.leKamikaze5AttaqueParLaVerticale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi4)) Then
                Form1.leKamikaze4AttaqueParL_Horizontale.Start()
                Form1.leKamikaze4AttaqueParLaVerticale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi3)) Then
                Form1.leKamikaze3AttaqueParL_Horizontale.Start()
                Form1.leKamikaze3AttaqueParLaVerticale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi2)) Then
                Form1.leKamikaze2AttaqueParL_Horizontale.Start()
                Form1.leKamikaze2AttaqueParLaVerticale.Stop()
            End If

        ElseIf (enemiX.Location.X < Form1.lim3.Location.X) And (enemiX.Location.X > Form1.lim4.Location.X) And ((Form1.panzerJoy.Location.Y < enemiX.Location.Y) Or (Form1.panzerJoy.Location.Y > enemiX.Location.Y)) Then 'Ici le panzerJoy est dans la ligne de mir  du Kamikaze sur le bas ou le haut.
            'Form1.Label22.Text = "ON EST LE HAUT!"

            If (enemiX.Equals(Form1.enemi6)) Then
                Form1.leKamikazeAttaqueParLaVerticale.Start()
                Form1.leKamikazeAttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi5)) Then
                Form1.leKamikaze5AttaqueParLaVerticale.Start()
                Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi4)) Then
                Form1.leKamikaze4AttaqueParLaVerticale.Start()
                Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi3)) Then
                Form1.leKamikaze3AttaqueParLaVerticale.Start()
                Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
            ElseIf (enemiX.Equals(Form1.enemi2)) Then
                Form1.leKamikaze2AttaqueParLaVerticale.Start()
                Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
            End If

        End If
    End Sub
    Public Sub ceQuonFaitQuandOnPerd()
        'ICI ON PERD 
        'Quand on est toucher par un kamikaze , lorsqu'on a une barre de vie vide .On est touché une seule fois.
        EnemisRestant -= 1
        Form1.nombreDenemiRestant.Text = EnemisRestant

        Try
            My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
        Catch ex As Exception
            MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
        End Try

        'Form1.afficheDeSurvie1.Visible = True
        'Form1.afficheDeSurvie1.Text = "T'as perdu."
        Reglages.msgDeVictoireOuDeDefaite.Text = "Tu as perdu "
        Reglages.msgDeVictoireOuDeDefaite.BackColor = Color.Red()
        Reglages.Show()
        Reglages.Focus()
        onAouvertLesReglages = True 'Cette variable va nous permettre de donner le focus a la fenetre des reglages, toute la duree pendant laquelle cette fentre sera ouverte. 
        onArreteToutApresUneDefaiteOuUneVictoire()
    End Sub
    Public Sub leTempsEstFiniLePanzerJoyPerdSi()
        'ON PERD AUSSI LORSQUE : 
        '-Le temps se termine sans que le panzerJoy n'ait pu detruire toutes les cases, et sans que le panzerJoy n'ait pu prendre toutes les barettes de vie et la barette bonus.
        maxDesCases = 0
        For Each elmt In tableauDesCasesDeLaCarte
            If (elmt.Location.Equals(pointQuelquonque)) Then
                maxDesCases += 1
            End If
        Next

        If ((barretteDeVieRestante <> 0) Or maxDesCases < 120 Or Not (Form1.bonus.Location.Equals(pointQuelquonque))) Then
            Reglages.msgDeVictoireOuDeDefaite.Text = "Tu as perdu "
            Reglages.msgDeVictoireOuDeDefaite.BackColor = Color.Red()
            Reglages.Show()
            Reglages.Focus()
            onAouvertLesReglages = True 'Cette variable va nous permettre de donner le focus a la fenetre des reglages, toute la duree pendant laquelle cette fentre sera ouverte. 
        End If
        onArreteToutApresUneDefaiteOuUneVictoire()
    End Sub
    Public Sub ceQuonFaitLorsquonGagne()
        'QUAND EST CE QU'ON GAGNE :
        'Lorsque toutes les cases auront été détruites.
        'Lorsque toutes les barettes de vie auront été recupéré, et le bonus aussi.
        'Et lorsque le temps de survie sera terminer.
        'Form1.Label51.Text = Form1.progressBarDesCasesShooter.Value

        If ((barretteDeVieRestante = 0) And Form1.progressBarDesCasesShooter.Value = 119 And Form1.bonus.Location.Equals(pointQuelquonque)) Then
            IO.File.WriteAllText(PATH, monScore) 'ON ECRIT LE SCORE DANS LE FICHIER DES SCORES.
            fichierDeScore.Dispose()
            Reglages.msgDeVictoireOuDeDefaite.Text = "Une nouvelle victoire "
            Reglages.msgDeVictoireOuDeDefaite.BackColor = Color.Lime()
            Reglages.Show()
            onAouvertLesReglages = True 'Cette variable va nous permettre de donner le focus a la fenetre des reglages, toute la duree pendant laquelle cette fentre sera ouverte. 
            Reglages.Focus()
        End If
        onArreteToutApresUneDefaiteOuUneVictoire()
    End Sub
    Public Sub onArreteToutApresUneDefaiteOuUneVictoire()
        Form1.leKamikazeAttaqueParLaVerticale.Stop()
        Form1.leKamikazeAttaqueParL_Horizontale.Stop()
        Form1.leKamikaze2AttaqueParLaVerticale.Stop()
        Form1.leKamikaze2AttaqueParL_Horizontale.Stop()
        Form1.leKamikaze3AttaqueParLaVerticale.Stop()
        Form1.leKamikaze3AttaqueParL_Horizontale.Stop()
        Form1.leKamikaze4AttaqueParLaVerticale.Stop()
        Form1.leKamikaze4AttaqueParL_Horizontale.Stop()
        Form1.leKamikaze5AttaqueParLaVerticale.Stop()
        Form1.leKamikaze5AttaqueParL_Horizontale.Stop()
        Form1.leKamikaze5AttaqueParLaVerticale.Stop()
        Form1.diminuerLeTempsDeSurvie.Stop()
    End Sub
    Public Sub retirerDesBarettesDeVieAuPanzerJoy()

        If (Form1.healthPointBar.Value > 0) Then
            Form1.healthPointBar.Value -= 20
            EnemisRestant -= 1 'Compter le nombre d'enemis restant.
            Form1.nombreDenemiRestant.Text = EnemisRestant
            Try
                My.Computer.Audio.Play(sonProduitParImpactDuKamikaze)
            Catch ex As Exception
                MsgBox("Veullez saisir les chemins d'acces au fichier sonore!", vbExclamation)
            End Try
        Else
            'ICI ON PERD 
            'Quand on est toucher par un kamikaze , lorsqu'on a une barre de vie vide .On est touché une seule fois.
            ceQuonFaitQuandOnPerd()
            'EnemisRestant -= 1
            'Form1.nombreDenemiRestant.Text = EnemisRestant
            'Form1.afficheDeSurvie1.Visible = True
            'Form1.afficheDeSurvie1.Text = "T'as perdu." 'ICI ON VA METTRE SI LE PANZERJOY A GANGNER OU PERDU, L'INSTRUCTION VA PERMETTRE DE CHANGER LE MESSAGE DE VICTOIRE OU DEFAITE DU PANZERJOY SUR LA FENETRE DE REGLAGE.
            'Reglages.msgDeVictoireOuDeDefaite.Text = "Tu as perdu "
            'Reglages.msgDeVictoireOuDeDefaite.BackColor = Color.Red()
            'Reglages.Show()
            'Reglages.Focus()
        End If

        'ON GAGNE AUSSI LORSQUE :
        '-Après avoir détruit toutes les cases et après avoir recupérer toutes les barettes de vie
        '-Et Après avoir été touchés par tous les kamikazes , et malgré tout ça le panzerJoy est toujours en vie.

    End Sub
    Public Sub parametrerLavitesseDesKamikazesDuCurseurEtLeTimer(dureeModifier As Integer, vitDuCurseur As Integer, vitDuKamikaze As Integer)
        DureeDeSurvie = dureeModifier
        Form1.TimerDeplacementDroitBalle.Interval = vitDuCurseur
        Form1.TimerDeplacementGaucheBalle.Interval = vitDuCurseur
        Form1.TimerDeplacementVersLeBasDeLaBalle.Interval = vitDuCurseur
        Form1.TimerDeplacementVersLeHautDeLaBalle.Interval = vitDuCurseur
        vitesseDesKamikazes = vitDuKamikaze
    End Sub
    Public Sub AugmenterVitesseDesKamikazes()
        'Ici le panzerJoy a detruit toutes les cases.
        'Donc on va augmenter la vitesse des kamikazes et donner une certaine durée de survie pour le panzerJoy Après lequel il pourra passer au niveau suivant.
        'Form1.diminuerLeTempsDeSurvie.Start()
        'Form1.afficheDeSurvie1.Text
        If (EnemisRestant = 5) Then '(Form1.progressBarDesCasesShooter.Value = tableauDesCasesDeLaCarte.Length - 1) Then 'And EnemisRestant > 1) Then
            'Form1.afficheDeSurvie1.Text = "fdfdfdfdfd"
            'unPoint0 = Form1.case52.Location
            'unPoint0.X += 37
            'unPoint0.Y += 39

            'Form1.baretteDeVie5.Location = unPoint0

            Form1.leKamikazeAttaqueParLaVerticale.Interval = vitesseDesKamikazes
            Form1.leKamikazeAttaqueParL_Horizontale.Interval = vitesseDesKamikazes
            Form1.leKamikaze2AttaqueParLaVerticale.Interval = vitesseDesKamikazes
            Form1.leKamikaze2AttaqueParL_Horizontale.Interval = vitesseDesKamikazes
            Form1.leKamikaze3AttaqueParLaVerticale.Interval = vitesseDesKamikazes
            Form1.leKamikaze3AttaqueParL_Horizontale.Interval = vitesseDesKamikazes
            Form1.leKamikaze4AttaqueParLaVerticale.Interval = vitesseDesKamikazes
            Form1.leKamikaze4AttaqueParL_Horizontale.Interval = vitesseDesKamikazes
            Form1.leKamikaze5AttaqueParLaVerticale.Interval = vitesseDesKamikazes
            Form1.leKamikaze5AttaqueParL_Horizontale.Interval = vitesseDesKamikazes
            'Form1.afficheDeSurvie1.Text = "Temps restant : " 'METTRE LE TIMER  DE DECOMPTE AU TOUT DEBU DU JEU  
            'Form1.afficheDeSurvie1.Visible = True
            'Form1.afficheDeSurvie2.Visible = True



        End If

        'Form1.case2.Text = Form1.progressBarDesCasesShooter.Value
        Form1.Label51.Text = Form1.progressBarDesCasesShooter.Value
        If (Form1.progressBarDesCasesShooter.Value >= 119) And uneSeulefois Then
            'ICI on a inserer une barette de bonus, pour attirer le panzerJoy.
            If (Form1.enemi4.Location <> pointQuelquonque) Then
                positionDuBonus = Form1.enemi4.Location
            ElseIf (Form1.enemi3.Location <> pointQuelquonque)
                positionDuBonus = Form1.enemi3.Location
            ElseIf (Form1.enemi2.Location <> pointQuelquonque)
                positionDuBonus = Form1.enemi2.Location
            ElseIf (Form1.enemi5.Location <> pointQuelquonque)
                positionDuBonus = Form1.enemi5.Location
            ElseIf (Form1.enemi6.Location <> pointQuelquonque)
                positionDuBonus = Form1.enemi6.Location
            End If

            positionDuBonus.X -= 90
            If (positionDuBonus.X < 0) Then
                positionDuBonus.X += 180
            End If
            If (EnemisRestant >= 1) Then
                Form1.bonus.Location = positionDuBonus
                Form1.bonus.Visible = True
                uneSeulefois = 0
            End If
        End If

        mangerLePointBonus()

    End Sub
    Public Sub mangerLePointBonus()
        'MANGER LE POINT BONUS DOIT JUSTE MANGER ET DONNER +10 AU LIEU DE +20 REGARDE ENCORE. EXECUTE.
        'Ler point bonus se trouve entre les deux limites lim2 et lim4 du panzerJoy.
        If ((Form1.bonus.Location.X < Form1.lim2.Location.X) And (Form1.bonus.Location.X > Form1.lim4.Location.X)) And ((Form1.bonus.Location.Y > Form1.lim2.Location.Y) And (Form1.bonus.Location.Y < Form1.lim4.Location.Y)) Then
            Form1.bonus.Location = pointQuelquonque
            monScore += 10
            'Form1.afficheDeSurvie1.Text = ""
        End If
    End Sub

    Public Sub positionnerAleatoirementLePanzerJoyAuDebutDuJeu()
        'deplacerLeCurseurVersLaDroite()
        uneCaseChoisie.X = Form1.case4.Location.X
        uneCaseChoisie.Y = Form1.case4.Location.Y
        'Form1.case5.Hide()

        copiePositionBaliseLimite1 = uneCaseChoisie
        copiePositionBaliseLimite2 = uneCaseChoisie
        copiePositionBaliseLimite3 = uneCaseChoisie
        copiePositionBaliseLimite4 = uneCaseChoisie

        copielim1Curseur = uneCaseChoisie
        copielim2Curseur = uneCaseChoisie
        copielim3Curseur = uneCaseChoisie
        copielim4Curseur = uneCaseChoisie

        copieLim1 = uneCaseChoisie
        copieLim2 = uneCaseChoisie
        copieLim3 = uneCaseChoisie
        copieLim4 = uneCaseChoisie

        copiePositionBaliseLimite2.X += 79
        copiePositionBaliseLimite3.Y += 79
        copiePositionBaliseLimite4.X += 79
        copiePositionBaliseLimite4.Y += 79

        copielim2Curseur.X += 79
        copielim3Curseur.Y += 79
        copielim4Curseur.X += 79
        copielim4Curseur.Y += 79

        copieLim1.X += 19
        copieLim1.Y += 20
        copieLim2.X += 59
        copieLim2.Y += 20
        copieLim3.X += 19
        copieLim3.Y += 60
        copieLim4.X += 59
        copieLim4.Y += 60

        Form1.baliseLimite1.Location = copiePositionBaliseLimite1
        Form1.baliseLimite2.Location = copiePositionBaliseLimite2
        Form1.baliseLimit3.Location = copiePositionBaliseLimite3
        Form1.baliseLimite4.Location = copiePositionBaliseLimite4

        Form1.lim1Curseur.Location = copiePositionBaliseLimite1
        Form1.lim2Curseur.Location = copiePositionBaliseLimite2
        Form1.lim3Curseur.Location = copiePositionBaliseLimite3
        Form1.lim4Curseur.Location = copiePositionBaliseLimite4

        Form1.lim1.Location = copieLim1
        Form1.panzerJoy.Location = copieLim1
        Form1.lim2.Location = copieLim2
        Form1.lim3.Location = copieLim3
        Form1.lim4.Location = copieLim4

    End Sub
    'IL FAUT CREER UN AUTRE FICHIER POUR STOCKER LE CHEMIN D'ACCES AU EXECUTABLES
    Public Sub arreterLaMusiqueEnCours()
        Select Case musiqueEncoursDeLecture
            Case "musiqueNiveauNormal"
                jouerOuArreterLaMusiqueDuNiveauNormal(False)
            Case "musiqueNiveauMoyen"
                jouerOuArreterLaMusiqueDuNiveauMoyen(False)
            Case "musiqueNiveauElever"
                jouerOuArreterLaMusiqueDuNiveauElever(False)
            Case "musiqueNiveauImpossible"
                jouerOuArreterLaMusiqueDuNiveauImpossible(False)
        End Select
    End Sub
    Public Sub jouerOuArreterLaMusiqueDuNiveauNormal(jouerLaMuisque As Boolean)

        If (musiqueEncoursDeLecture <> "musiqueNiveauNormal") Then
            arreterLaMusiqueEnCours()
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu += "\jouerLaMusique.exe" '"C:\Users\ARMAND COLLINS MBA\Desktop\Taken_Ball_Trap\Taken_Ball_Trap\bin\Debug\jouerLaMusique.exe" '"\jouerLaMusique.exe"
        musiqueEncoursDeLecture = "musiqueNiveauNormal"

        If (jouerLaMuisque) Then
            Process.Start(cheminAccesDeExecutableDesMusiquesDuJeu) '"C:\Users\ARMAND COLLINS MBA\Desktop\Taken_Ball_Trap\Taken_Ball_Trap\bin\Debug\jouerLaMusique.exe")
        Else

            For Each p As Process In System.Diagnostics.Process.GetProcesses
                If (p.ProcessName = "jouerLaMusique") Then
                    p.Kill()
                End If
            Next
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu = IO.File.ReadAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt") 'Il faut reinitialiser pour ne pas avoir d'erreur lors de la concatenation, vu qu'il y' a deja une valeur dedans.
        'jouerOuArreterLaMusiqueDuNiveauMoyen(False)
        'jouerOuArreterLaMusiqueDuNiveauElever(False)
        'jouerOuArreterLaMusiqueDuNiveauImpossible(False)
    End Sub
    Public Sub jouerOuArreterLaMusiqueDuNiveauMoyen(jouerLaMuisque As Boolean)

        If (musiqueEncoursDeLecture <> "musiqueNiveauMoyen") Then
            arreterLaMusiqueEnCours()
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu += "\jouerMusiqueNiveauMoyen.exe"
        musiqueEncoursDeLecture = "musiqueNiveauMoyen"

        If (jouerLaMuisque) Then
            Process.Start(cheminAccesDeExecutableDesMusiquesDuJeu)
        Else
            For Each p As Process In System.Diagnostics.Process.GetProcesses
                If (p.ProcessName = "jouerMusiqueNiveauMoyen") Then
                    p.Kill()
                End If
            Next
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu = IO.File.ReadAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt") 'Il faut reinitialiser pour ne pas avoir d'erreur lors de la concatenation, vu qu'il y' a deja une valeur dedans.

        'jouerOuArreterLaMusiqueDuNiveauNormal(False)
        'jouerOuArreterLaMusiqueDuNiveauElever(False)
        'jouerOuArreterLaMusiqueDuNiveauImpossible(False)
    End Sub
    Public Sub jouerOuArreterLaMusiqueDuNiveauElever(jouerLaMuisque As Boolean)

        If (musiqueEncoursDeLecture <> "musiqueNiveauElever") Then
            arreterLaMusiqueEnCours()
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu += "\jouerMusiqueNiveauElever.exe"
        musiqueEncoursDeLecture = "musiqueNiveauElever"

        If (jouerLaMuisque) Then
            pr = Process.Start(cheminAccesDeExecutableDesMusiquesDuJeu)
        Else
            For Each p As Process In System.Diagnostics.Process.GetProcesses
                If (p.ProcessName = "jouerMusiqueNiveauElever") Then
                    p.Kill()
                End If
            Next
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu = IO.File.ReadAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt") 'Il faut reinitialiser pour ne pas avoir d'erreur lors de la concatenation, vu qu'il y' a deja une valeur dedans.

        'jouerOuArreterLaMusiqueDuNiveauNormal(False)
        'jouerOuArreterLaMusiqueDuNiveauMoyen(False)
        'jouerOuArreterLaMusiqueDuNiveauImpossible(False)

    End Sub
    Public Sub jouerOuArreterLaMusiqueDuNiveauImpossible(jouerLaMuisque As Boolean)

        If (musiqueEncoursDeLecture <> "musiqueNiveauImpossible") Then
            arreterLaMusiqueEnCours()
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu += "\jouerMusiqueNiveauImpossible.exe"
        musiqueEncoursDeLecture = "musiqueNiveauImpossible"

        If (jouerLaMuisque) Then
            pr = Process.Start(cheminAccesDeExecutableDesMusiquesDuJeu)
            Form1.Activate()
        Else
            For Each p As Process In System.Diagnostics.Process.GetProcesses
                If (p.ProcessName = "jouerMusiqueNiveauImpossible") Then
                    p.Kill()
                End If
            Next
        End If

        cheminAccesDeExecutableDesMusiquesDuJeu = IO.File.ReadAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt") 'Il faut reinitialiser pour ne pas avoir d'erreur lors de la concatenation, vu qu'il y' a deja une valeur dedans.

        'jouerOuArreterLaMusiqueDuNiveauNormal(False)
        'jouerOuArreterLaMusiqueDuNiveauMoyen(False)
        'jouerOuArreterLaMusiqueDuNiveauElever(False)

    End Sub
    Public Sub musiqueChoisieEnFonctionDuNiveauDuJeu()
        Select Case numeroDeLaMusiqueAJouer
            Case 1
                For Each p As Process In System.Diagnostics.Process.GetProcesses
                    If (p.ProcessName = "jouerLaMusique") Then
                        p.Kill()
                    End If
                Next
                jouerOuArreterLaMusiqueDuNiveauNormal(True)
            Case 2
                For Each p As Process In System.Diagnostics.Process.GetProcesses
                    If (p.ProcessName = "jouerMusiqueNiveauMoyen") Then
                        p.Kill()
                    End If
                Next
                jouerOuArreterLaMusiqueDuNiveauMoyen(True)
            Case 3
                For Each p As Process In System.Diagnostics.Process.GetProcesses
                    If (p.ProcessName = "jouerMusiqueNiveauElever") Then
                        p.Kill()
                    End If
                Next
                jouerOuArreterLaMusiqueDuNiveauElever(True)
            Case 4
                For Each p As Process In System.Diagnostics.Process.GetProcesses
                    If (p.ProcessName = "jouerMusiqueNiveauImpossible") Then
                        p.Kill()
                    End If
                Next
                jouerOuArreterLaMusiqueDuNiveauImpossible(True)
        End Select

    End Sub
End Module
