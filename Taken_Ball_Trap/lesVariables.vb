Imports System.IO
Module lesVariables
    'CE SONT LES CASES SUR LESQUELS ON PEUT TIRER.
    'AU PREALABLE IL FAIRE UTILISER LE OPENCREATE DANS LE LOAD DE LA FENETRE , ET AINSI FIARE EN SORTE QUE PEUT IMPORTE DANS QUEL MACHINE ON SE TROUVE ON PUISSE JOUER LES DIFFERENTS SON.
    'MAINTENANT A L'INTERIEURE IL FAUDRA METTRE LES DIFFERENTS CHEMINS D'ACCES A CES SONS , DANS LE FICHIER CREER AVEC LE OPENCREATE
    'ON VA CHERCHER COMMENT FAIRE POUR RECUPERER LE CHEMIN D'ACCES D'UN FICHEIR DANS UN ORDINATEUR, CE SONT CES CHEMINS QUI SERONT MIS DANS LES DIFFERENTS FICHIERS CREER AVEC LE OPENCREATE.
    'ENSUITE CES CHEMINS SERONT RECUPERER DE CES FICHIERS , ET ENSUITE ON LES METTRA DANS CHACUNE DES VARIABLES  sonProduitParImpactDuKamikaze,sonProduitParRecuperationDeBaretteDeVie
    Public cheminAccesDeExecutableDesMusiquesDuJeu As String = IO.File.ReadAllText("cheminAccesDeExecutableDesMusiquesDuJeu.txt")
    Public listeDeTimers As New List(Of Timer)
    Public etatDuJeu = "Pause"
    Public musiqueEncoursDeLecture As String
    Public numeroDeLaMusiqueAJouer As Integer = 1
    Public pr As New Process
    Public fichierDeScore As IO.FileStream, fichierSonore1 As IO.FileStream, fichierSonore2 As IO.FileStream
    Public case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19, case20, case21, case22, case23, case24, case25, case26, case27, case28, case29, case30, case31, case32, case33, case34, case35, case36, case37, case38, case39, case40, case41, case42, case43, case44, case45, case46, case47, case48, case49, case50, case51, case52, case53, case54, case55, case56, case57, case58, case59, case60, case61, case62, case63, case64, case65, case66, case67, case68, case69, case70, case71, case72, case73, case74, case75, case76, case77, case78, case79, case80, case81, case82, case83, case84, case85, case86, case87, case88, case89, case90, case91, case92, case93, case94, case95, case96, case97, case98, case99, case100, case101, case102, case103, case104, case105, case106, case107, case108, case109, case110, case111, case112, case113, case114, case115, case116, case117, case118, case119, case120 As Point
    Public Const PATH = "monScore.txt" 'LORS DE L'INSTALLATION DE Taken Ball , il faut indiquer le chemin ou se trouve le fichier de monScore.
    Public tableauDesCasesDeLaCarte() As Label = {Form1.case1, Form1.case2, Form1.case3, Form1.case4, Form1.case5, Form1.case6, Form1.case7, Form1.case8, Form1.case9, Form1.case10, Form1.case11, Form1.case12, Form1.case13, Form1.case14, Form1.case15, Form1.case16, Form1.case17, Form1.case18, Form1.case19, Form1.case20, Form1.case21, Form1.case22, Form1.case23, Form1.case24, Form1.case25, Form1.case26, Form1.case27, Form1.case28, Form1.case29, Form1.case30, Form1.case31, Form1.case32, Form1.case33, Form1.case34, Form1.case35, Form1.case36, Form1.case37, Form1.case38, Form1.case39, Form1.case40, Form1.case41, Form1.case42, Form1.case43, Form1.case44, Form1.case45, Form1.case46, Form1.case47, Form1.case48, Form1.case49, Form1.case50, Form1.case51, Form1.case52, Form1.case53, Form1.case54, Form1.case55, Form1.case56, Form1.case57, Form1.case58, Form1.case59, Form1.case60, Form1.case61, Form1.case62, Form1.case63, Form1.case64, Form1.case65, Form1.case66, Form1.case67, Form1.case68, Form1.case69, Form1.case70, Form1.case71, Form1.case72, Form1.case73, Form1.case74, Form1.case75, Form1.case76, Form1.case77, Form1.case78, Form1.case79, Form1.case80, Form1.case81, Form1.case82, Form1.case83, Form1.case84, Form1.case85, Form1.case86, Form1.case87, Form1.case88, Form1.case89, Form1.case90, Form1.case91, Form1.case92, Form1.case93, Form1.case94, Form1.case95, Form1.case96, Form1.case97, Form1.case98, Form1.case99, Form1.case100, Form1.case101, Form1.case102, Form1.case103, Form1.case104, Form1.case105, Form1.case106, Form1.case107, Form1.case108, Form1.case109, Form1.case110, Form1.case111, Form1.case112, Form1.case113, Form1.case114, Form1.case115, Form1.case116, Form1.case117, Form1.case118, Form1.case119, Form1.case120}
    Public tableauDesBarettesDeVie() As Label = {Form1.baretteDeVie1, Form1.baretteDeVie2, Form1.baretteDeVie3, Form1.baretteDeVie4, Form1.baretteDeVie5} ', Form1.baretteDeVie6}
    Public tableau2DesCasesDeLaCarte() As Point = {case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19, case20, case21, case22, case23, case24, case25, case26, case27, case28, case29, case30, case31, case32, case33, case34, case35, case36, case37, case38, case39, case40, case41, case42, case43, case44, case45, case46, case47, case48, case49, case50, case51, case52, case53, case54, case55, case56, case57, case58, case59, case60, case61, case62, case63, case64, case65, case66, case67, case68, case69, case70, case71, case72, case73, case74, case75, case76, case77, case78, case79, case80, case81, case82, case83, case84, case85, case86, case87, case88, case89, case90, case91, case92, case93, case94, case95, case96, case97, case98, case99, case100, case101, case102, case103, case104, case105, case106, case107, case108, case109, case110, case111, case112, case113, case114, case115, case116, case117, case118, case119, case120}
    Public numeroDeGroupBoxTutorials As Integer = 1
    Public onAouvertLesReglages As Boolean = False
    Public copieDuPointBonus As Point
    Public enemiXCopie As Label
    Public onAToucherUneDesCasesActives As Boolean
    Public onAToucherUneDesCasesActives2 As Boolean
    Public onAToucherUneDesCasesActives3 As Boolean
    Public onAtoucherUneDesCasesActives4 As Boolean
    Public copieDeLabaretteDeVie As Point
    Public directionDuPanzer As String
    Public positionTurbo1DuPanzer As Point = Form1.turbo1Panzer.Location
    Public positionTurbo2DuPanzer As Point = Form1.turbo2Panzer.Location
    Public positionCorpsDuPanzer As Point = Form1.corpsDuPanzer.Location
    Public positionCanonDuPanzer As Point = Form1.canonPanzer.Location
    Public positionLimite1Curseur As Point = Form1.lim1Curseur.Location
    Public positionLimite2Curseur As Point = Form1.lim2Curseur.Location
    Public positionLimite3Curseur As Point = Form1.lim3Curseur.Location
    Public positionLimite4Curseur As Point = Form1.lim4Curseur.Location
    Public unPoint2 = New Point
    Public unPoint3 = New Point
    Public unPoint4 = New Point
    Public unPoint5 = New Point
    Public unPoint6 = New Point
    Public unPoint7 = New Point
    Public unPoint2Enemi5 = New Point, unPoint3Enemi5 = New Point
    Public unPoint2Enemi4 = New Point, unPoint3Enemi4 = New Point
    Public unPoint2Enemi3 = New Point, unPoint3Enemi3 = New Point
    Public unPoint2Enemi2 = New Point, unPoint3Enemi2 = New Point
    Public unPoint2Enemi1 = New Point, unPoint3Enemi1 = New Point
    Public positionBalise1Limite1Curseur As Point = Form1.baliseLimite1.Location
    Public positionBalise2Limite2Curseur As Point = Form1.baliseLimite2.Location
    Public positionBalise3Limite3Curseur As Point = Form1.baliseLimit3.Location
    Public positionBalise4Limite4Curseur As Point = Form1.baliseLimite4.Location
    Public copiePositionBaliseLimite1 = New Point, copiePositionBaliseLimite2 = New Point, copiePositionBaliseLimite3 = New Point, copiePositionBaliseLimite4 = New Point
    Public copielim1Curseur = New Point, copielim2Curseur = New Point, copielim3Curseur = New Point, copielim4Curseur = New Point
    Public copieLim1 = New Point, copieLim2 = New Point, copieLim3 = New Point, copieLim4 = New Point
    Public pointQuelquonque As New Point(1500, 800)

    Public positionDuPanzerJoy As Point = Form1.panzerJoy.Location
    'Public positionDeLaBallePanzerJoy As Point = Form1.ballePanzerJoy.Location
    Public onPeutTirerDeNouveau = True
    Public activerLeCurseurDroit As Boolean, activerLeCurseurGauche = True, activerLeCurseurBas = True, activerLeCurseurHaut = True
    Public continuerLeTirDeLaBalleAllantADroite = True, continuerLeTirDeLaBalleAllantAGauche = True, continuerLeTirDeLaBalleVersLeBas = True, continuerLeTirDeLaBalleVersLeHaut = True
    Public activerTimerBalleAllantAGauche = True, desactiverCurseurCarDepasseToutesLimites = False
    Public enemi5AtoucherLePAnzerJoy = False, enemi6AtoucherLePAnzerJoy = False
    Public etat1 = 1, etat2 = 1, etat3 = 1, etat4 = 1

    Public positionLim1 = Form1.lim1.Location
    Public positionLim2 = Form1.lim2.Location
    Public positionLim3 = Form1.lim3.Location
    Public positionLim4 = Form1.lim4.Location
    Public uneCaseChoisie, positionDuBonus As Point
    Public compteur = 0, compteur2 = 0
    Public caseAleatoireChoisiePourKamikaze1, caseAleatoireChoisiePourKamikaze2, caseAleatoireChoisiePourKamikaze3, caseAleatoireChoisiePourKamikaze4, caseAleatoireChoisiePourKamikaze5
    Public sonProduitParImpactDuKamikaze As String '= "sonMouvement2.wav" '"C:\Users\ARMAND COLLINS MBA\Desktop\Programmations\InterfacesProg\CertainsSonsAInserer\sonMouvement2.wav"
    'Public sonProduitParImpactDuCurseur = "C:\Users\ARMAND COLLINS MBA\Desktop\Programmations\InterfacesProg\CertainsSonsAInserer\SonLaser2.wav"
    Public sonProduitParRecuperationDeBaretteDeVie As String ' = "sonMouvement.wav" '"C:\Users\ARMAND COLLINS MBA\Desktop\Programmations\InterfacesProg\CertainsSonsAInserer\sonMouvement.wav"
    Public cadencer As Integer = 1
    Public cadencer2 As Integer = 1
    Public cadencer3 As Integer = 1
    Public monScore As Integer = 0, DureeDeSurvie = 60
    Public cadencer4 As Integer = 1, EnemisRestant = 5, barretteDeVieRestante = 5, maxDesCases = 0, tempsDeSurvie = DureeDeSurvie
    Public valAleatoire As New Random()

    Public positionAleatoireChoisiePourLesBarettes, positionAleatoireChoisiePourLesKamiKazes As Integer '= valAleatoire.Next(1, 108) ', Form1.case13, Form1.case14, Form1.case15, Form1.case16, Form1.case17, Form1.case18, Form1.case19, Form1.case20, Form1.case21, Form1.case22, Form1.case23, Form1.case24, Form1.case25, Form1.case26, Form1.case27, Form1.case28, Form1.case29, Form1.case30, Form1.case31, Form1.case32, Form1.case33, Form1.case34, Form1.case35, Form1.case36, Form1.case37, Form1.case38, Form1.case39, Form1.case40, Form1.case41, Form1.case42, Form1.case43, Form1.case44, Form1.case45, Form1.case46, Form1.case47, Form1.case48, Form1.case49, Form1.case50, Form1.case51, Form1.case52, Form1.case53, Form1.case54, Form1.case55, Form1.case56, Form1.case57, Form1.case58, Form1.case59, Form1.case60, Form1.case61, Form1.case62, Form1.case63, Form1.case64, Form1.case65, Form1.case66, Form1.case67, Form1.case68, Form1.case69, Form1.case70, Form1.case71, Form1.case72, Form1.case73, Form1.case74, Form1.case75, Form1.case76, Form1.case77, Form1.case78, Form1.case79, Form1.case80, Form1.case81, Form1.case82, Form1.case83, Form1.case84, Form1.case85, Form1.case86, Form1.case87, Form1.case88, Form1.case89, Form1.case90, Form1.case91, Form1.case92, Form1.case93, Form1.case94, Form1.case95, Form1.case96, Form1.case97, Form1.case98, Form1.case99, Form1.case100, Form1.case101, Form1.case102, Form1.case103, Form1.case104, Form1.case105, Form1.case106)
    Public vitesseDesKamikazes As Integer = 200, vitesseDuCurseur As Integer = 10

    Public nvlVal, numeroDeLaCaseAtteinte As Integer
    Public uneSeulefois As Boolean = 1
    Public uneSeulefois2 As Boolean = True 'Donner la possibilité au PanzerJoy de manger la barette de bonus.
    Public mouvementDeLaLimite1 = "droite"
    Public ArreterLaBoucleIterative As Boolean = False 'Boucle qui est utiliser quand on verifie si le panzer lors de son deplacement touche une case.
    Public unPoint, positionDuPanzerLorsquonVerifieSilToucheUneCase As Point
    Public enlever As Integer = 89
    Public pasDeDeplacementDuPanzer As Integer = 90 '2 '10
    Public limiteDroite As Integer = Form1.Width - 89 '30
    Public limiteBas As Integer = Form1.Height - 157 '68
    Public limiteHautEtGauche As Integer = 89
    Public activerUneSeulFois As Integer = 0
    Public activerUneSeulFois2 = 1, activerUneSeulFois3 = 0, activerUneSeulFois4 = 0
    Public statutDuPanneauDesItems As String = "fermer"
    Public positionDuPanneauDesItems As Point = Form1.PanneauDesItems.Location
    Public unPoint0 As New Point()
    Public affectationNestPasEncoreFaite = True, estCeQueLeKamikazeToucheUneCaseAuCoursDeSonDepLacement = True, estCeQueLeKamikaze5ToucheUneCaseAuCoursDeSonDepLacement = True, estCeQueLeKamikaze4ToucheUneCaseAuCoursDeSonDepLacement = True, estCeQueLeKamikaze3ToucheUneCaseAuCoursDeSonDepLacement = True, estCeQueLeKamikaze2ToucheUneCaseAuCoursDeSonDepLacement = True, estCeQueLeKamikaze1ToucheUneCaseAuCoursDeSonDepLacement = True
    Public onArreteLaMonteeOuDescenteDuPanneau = False, leCurseurPeutBougerAvecLePanzerJoyVersLeHaut = True
    Public activer = False, leCurseurPeutBougerAvecLePanzerJoyVersLeBas = True, leCurseurPeutBougerAvecLePanzerJoyVersLaGauche = True, leCurseurPeutBougerAvecLePanzerJoyVersLaDroite = True
    Public leCurseuraAtteintSaCible = False, leCurseuraAtteintSaCibleSurLeBas = False, leCurseuraAtteintSaCibleSurLeHaut = False, leCurseuraAtteintSaCibleSurLaGauche = False, leCurseuraAtteintSaCibleSurLaDroite = False
    Public deplacerLePanzerJoyaDroite = True, deplacerLePanzerJoyEnBas = True, deplacerLePanzerJoyAGauche = True, deplacerLePanzerJoyEnHaut = True
    Public directionDuPanneau = "monte"
End Module
