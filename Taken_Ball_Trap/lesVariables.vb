Module lesVariables

    Public directionDuPanzer As String
    Public positionTurbo1DuPanzer As Point = Form1.turbo1Panzer.Location
    Public positionTurbo2DuPanzer As Point = Form1.turbo2Panzer.Location
    Public positionCorpsDuPanzer As Point = Form1.corpsDuPanzer.Location
    Public positionCanonDuPanzer As Point = Form1.canonPanzer.Location
    Public positionPointABouffer As Point = Form1.pointABouffer.Location
    Public positionLimite1Curseur As Point = Form1.lim1Curseur.Location
    Public positionLimite2Curseur As Point = Form1.lim2Curseur.Location
    Public positionLimite3Curseur As Point = Form1.lim3Curseur.Location
    Public positionLimite4Curseur As Point = Form1.lim4Curseur.Location

    Public positionBalise1Limite1Curseur As Point = Form1.baliseLimite1.Location
    Public positionBalise2Limite2Curseur As Point = Form1.baliseLimite2.Location
    Public positionBalise3Limite3Curseur As Point = Form1.baliseLimit3.Location
    Public positionBalise4Limite4Curseur As Point = Form1.baliseLimite4.Location
    Public positionBaliseBalle As Point = Form1.baliseBallePanzerJoy.Location
    Public pointQuelquonque As New Point(1500, 800)
    Public tableauDesCasesDeLaCarte() As Label = {Form1.case31, Form1.case32, Form1.case33, Form1.case34, Form1.case35, Form1.case36, Form1.case37, Form1.case38, Form1.case39, Form1.case40}

    Public positionDuPanzerJoy As Point = Form1.panzerJoy.Location
    Public positionDeLaBallePanzerJoy As Point = Form1.ballePanzerJoy.Location
    Public activerLeTir As Boolean = True
    Public activerLeCurseurDroit As Boolean, activerLeCurseurGauche = True, activerLeCurseurBas = True, activerLeCurseurHaut = True
    Public continuerLeTirDeLaBalleAllantADroite = True, continuerLeTirDeLaBalleAllantAGauche = True, continuerLeTirDeLaBalleVersLeBas = True, continuerLeTirDeLaBalleVersLeHaut = True
    Public activerTimerBalleAllantAGauche As Boolean = True
    Public etat1 = 1, etat2 = 1, etat3 = 1, etat4 = 1

    Public positionLim1 = Form1.lim1.Location
    Public positionLim2 = Form1.lim2.Location
    Public positionLim3 = Form1.lim3.Location
    Public positionLim4 = Form1.lim4.Location
    Public compteur As Integer = 0

    Public cadencer As Integer = 1
    Public cadencer2 As Integer = 1
    Public cadencer3 As Integer = 1
    Public cadencer4 As Integer = 1
    Public nvlVal, numeroDeLaCaseAtteinte As Integer
    Public mouvementDeLaLimite1 = "droite"
    Public onNeDepassePasCesCases As Boolean
    Public unPoint, pos As Point
    Public enlever As Integer = 89
    Public pasDeDeplacementDuPanzer As Integer = 90 '2 '10
    Public limiteDroite As Integer = Form1.Width - 89 '30
    Public limiteBas As Integer = Form1.Height - 157 '68
    Public limiteHautEtGauche As Integer = 89
    Public activerUneSeulFois As Integer = 0
    Public activerUneSeulFois2 = 1, activerUneSeulFois3 = 0, activerUneSeulFois4 = 0
    Public statutDuPanneauDesItems As String = "fermer"
    Public positionDuPanneauDesItems As Point = Form1.PanneauDesItems.Location
    Public onArreteLaMonteeOuDescenteDuPanneau As Boolean = False
    Public activer As Boolean = False
    Public leCurseuraAtteintSaCible As Boolean = False
    Public deplacerLePanzerJoyaDroite = True, deplacerLePanzerJoyEnBas = True, deplacerLePanzerJoyAGauche = True, deplacerLePanzerJoyEnHaut = True
    Public directionDuPanneau = "monte"
End Module
