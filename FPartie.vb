Public Class FPartie
    Private Sub BoutonAbandonner_Click(sender As Object, e As EventArgs) Handles BoutonAbandonner.Click
        Dim choix = MsgBox("Souhaitez-vous vraiment abandonner la partie ?", vbQuestion + vbYesNo,
                           "Abandonner la partie ?")
        If choix = vbYes Then RetourAccueil()
    End Sub

    Private Sub RetourAccueil()
        FAccueil.Show()
        Close()
    End Sub

    Private Sub FormulairePartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Associe un Tag de 0 à 4 (5 carrés de cartes) à chaque carte
        InitialiserCartes()
        tempsRestant = My.Settings.TEMPS_PARTIE

        LabelJoueur.Text = joueurCourant.nom
        ' Centrage horizontal
        LabelJoueur.Left = (LabelJoueur.Parent.Width \ 2) - (LabelJoueur.Width \ 2)

        LabelDifficulté.Text = "Difficulté : " & DIFFICULTE.ToString
        LabelDifficulté.Left = (LabelDifficulté.Parent.Width \ 2) - (LabelDifficulté.Width \ 2)

        If Not My.Settings.DECOMPTER_TEMPS Then
            LabelTimerPartie.Text = "Temps restant : ∞"
            LabelTimerPartie.Left = (LabelTimerPartie.Parent.Width \ 2) - (LabelTimerPartie.Width \ 2)
        Else
            LabelTimerPartie.Text = "Temps restant : " & FormatTemps(tempsRestant)
        End If

        If My.Settings.BOUTON_PAUSE Then
            BoutonPause.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Convertit des secondes au format "mm:ss" et renvoie la chaîne correspondante
    ''' </summary>
    ''' <param name="secondes">Les secondes à convertir en format chaîne</param>
    ''' <returns></returns>
    Private Shared Function FormatTemps(secondes As Integer)
        Dim ts As TimeSpan = TimeSpan.FromSeconds(secondes)
        Dim temps As Date = New Date(ts.Ticks)
        Return temps.ToString("mm:ss")
    End Function

    Private tempsRestant As Integer
    Private Sub TimerPartie_Tick(sender As Object, e As EventArgs) Handles TimerPartie.Tick
        tempsRestant -= 1
        If tempsRestant <= 0 Then
            tempsRestant = 0
            sender.Stop()
        End If

        If My.Settings.DECOMPTER_TEMPS Then
            LabelTimerPartie.Text = "Temps restant : " & FormatTemps(tempsRestant)
        End If

        VérifFinPartie()
    End Sub

    ''' <summary>
    ''' Assigne un numéro de carré à chaque carte du jeu dans son Tag et les affiche face cachée
    ''' </summary>
    Private Sub InitialiserCartes()

        Dim cartes As New List(Of Label)
        For Each carte As Label In PanelCartes.Controls
            cartes.Add(carte)
            ' Initialisation face cachée
            carte.Image = My.Resources.BackCard
            carte.Text = ""
        Next

        Dim r As New Random
        Dim cartesTraitées As New List(Of Label)

        ' Assignation des carrés
        For i As Integer = 0 To NB_CARRES - 1
            For j As Integer = 0 To NB_CARTES_CARRE - 1

                While True
                    Dim indexCourant = r.Next(0, cartes.Count)
                    Dim carteCourante = cartes(indexCourant)
                    ' On visite chaque carte du jeu une unique fois pour lui assigner son carré
                    If Not cartesTraitées.Contains(carteCourante) Then
                        ' i donne l'indice de l'image de la carte (voir IMAGES_CARTES), True pour "face cachée"
                        carteCourante.Tag = (i, True)
                        cartesTraitées.Add(carteCourante)
                        cartes.RemoveAt(indexCourant)
                        Exit While
                    End If
                End While
            Next
        Next

    End Sub

    Private partieBloquée As Boolean = False
    Private Sub Carte_Click(sender As Object, e As EventArgs) Handles _
        Carte1.Click, Carte2.Click, Carte3.Click, Carte4.Click, Carte5.Click,
        Carte6.Click, Carte7.Click, Carte8.Click, Carte9.Click, Carte10.Click,
        Carte11.Click, Carte12.Click, Carte13.Click, Carte14.Click, Carte15.Click,
        Carte16.Click, Carte17.Click, Carte18.Click, Carte19.Click, Carte20.Click

        If partieBloquée Then Return
        If Not TimerPartie.Enabled Then TimerPartie.Start()

        ' Ignorer une carte déjà dévoilée
        If sender.Tag.Item2 = False Then Return

        ' L'entier en première valeur du Tag de la carte donne son image
        sender.Image = IMAGES_CARTES(sender.Tag.Item1)
        sender.Tag = (sender.Tag.Item1, False)

        ' Vérifier partie
        For Each carte As Label In PanelCartes.Controls
            If carte.Name = sender.Name Then Continue For

            If Not FaceCachée(carte) Then
                ' Si les deux cartes appartiennent au même carré
                ' ou la carte comparée est désactivée (appartient à un autre carré qui est complet)
                If sender.Tag.Item1 = carte.Tag.Item1 OrElse Not carte.Enabled Then
                    Continue For

                    ' Mauvais coup
                Else
                    ' Mode difficile : si la carte appartient à un carré déjà complété auparavant,
                    ' retirer 3 secondes du chrono
                    If DIFFICULTE = Difficulté.Difficile Then
                        If historiqueComplétés.Contains(carte.Tag.Item1) Then
                            tempsRestant -= PENALITE
                            Debug.WriteLine("Cette carte appartient à un carré complété auparavant. -3 !")
                        End If
                    End If

                    RéinitialiserPlateau()
                    sender.Tag = (sender.Tag.Item1, True)
                    Exit Sub
                End If

            End If
        Next

        VérifNouveauCarré(sender)
    End Sub

    Private tempsDernierCarré As Integer = 0
    Private cartesDévoiléesCarré As Integer() = {0, 0, 0, 0, 0}
    Private ReadOnly historiqueComplétés As New List(Of Integer)
    Private Sub VérifNouveauCarré(carte As Label)
        cartesDévoiléesCarré(carte.Tag.Item1) += 1

        ' Si le carré est complet à l'issue de cette incrémentation
        If cartesDévoiléesCarré(carte.Tag.Item1) = NB_CARTES_CARRE Then
            tempsDernierCarré = My.Settings.TEMPS_PARTIE - tempsRestant

            If Not historiqueComplétés.Contains(carte.Tag.Item1) Then
                historiqueComplétés.Add(carte.Tag.Item1) ' utile pour difficultés FACILE/DIFFICILE
            End If
        End If

        ' Désactive les cartes des carrés complets
        For Each carte2 As Label In PanelCartes.Controls
            If cartesDévoiléesCarré(carte2.Tag.Item1) = NB_CARTES_CARRE And carte2.Enabled Then
                carte2.Enabled = False
            End If
        Next

    End Sub

    Private Sub VérifFinPartie()
        Dim nbCarrésComplets = GetNbCarrésComplets()

        If nbCarrésComplets = NB_CARRES Then TimerPartie.Stop()

        If (My.Settings.DECOMPTER_TEMPS And tempsRestant <= 0) OrElse nbCarrésComplets = NB_CARRES Then
            Dim resultat As String = "Nombre de carrés trouvés : " & nbCarrésComplets & "/" & NB_CARRES
            If nbCarrésComplets > 0 Then
                resultat = resultat & vbCrLf &
                    "Temps passé à les identifier : " & FormatTemps(tempsDernierCarré)
            End If

            MsgBox(resultat, vbInformation + vbOKOnly, "Partie terminée")

            EnregistrerPartie(nbCarrésComplets, tempsDernierCarré, My.Settings.TEMPS_PARTIE - tempsRestant)
            RetourAccueil()
        End If
    End Sub

    Private Function GetNbCarrésComplets()
        Dim cartesDésactivées As Integer = 0
        For Each carte As Label In PanelCartes.Controls
            If Not carte.Enabled Then
                cartesDésactivées += 1
            End If
        Next
        Return cartesDésactivées \ NB_CARTES_CARRE
    End Function

    Private Shared Function FaceCachée(carte As Label)
        If carte.Tag.Item2 Then Return True
        Return False
    End Function

    ''' <summary>
    ''' Retourne toutes les cartes en face cachée
    ''' </summary>
    ''' <param name="secondes">Nombre de secondes à attendre, 1 par défaut</param>
    Private Sub RéinitialiserPlateau(Optional secondes As Integer = 1)
        partieBloquée = True
        Me.secondes = secondes
        TimerResetPlateau.Start()
    End Sub

    Private secondes As Integer
    Private Sub TimerResetPlateau_Tick(sender As Object, e As EventArgs) Handles TimerResetPlateau.Tick
        secondes -= 1
        If secondes = 0 Then
            sender.Stop()
            ' On replace toutes les cartes en face cachée
            For Each carte As Label In PanelCartes.Controls
                ' Difficulté facile : si le carré est complet, on laisse les cartes associées
                If DIFFICULTE = Difficulté.Facile Then
                    If historiqueComplétés.Contains(carte.Tag.Item1) Then Continue For
                End If

                With carte
                    .Image = My.Resources.BackCard
                    .Tag = (carte.Tag.Item1, True)
                    .Enabled = True
                End With
            Next

            cartesDévoiléesCarré = {0, 0, 0, 0, 0}
        End If

        If Not DIFFICULTE = Difficulté.Facile Then tempsDernierCarré = 0
        partieBloquée = False
    End Sub

    Private Sub BoutonPause_Click(sender As Object, e As EventArgs) Handles BoutonPause.Click
        If BoutonPause.Text = "Pause" Then
            BoutonPause.Text = "Reprendre"
            partieBloquée = True
            TimerPartie.Stop()
        Else
            BoutonPause.Text = "Pause"
            partieBloquée = False
            TimerPartie.Start()
        End If
    End Sub
End Class