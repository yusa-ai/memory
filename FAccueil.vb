Public Class FAccueil
    Private Sub ComboJoueur_Saisie(sender As Object, e As KeyEventArgs) Handles ComboJoueur.KeyUp
        VérifierNomJoueur()
    End Sub

    Private Sub ComboJoueur_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboJoueur.SelectionChangeCommitted
        ComboJoueur.Text = ComboJoueur.SelectedItem.ToString
        VérifierNomJoueur()
    End Sub

    Private Sub VérifierNomJoueur()
        If Len(ComboJoueur.Text) >= 3 Then
            BoutonJouer.Enabled = True
            LabelErrNom.Visible = False
        Else
            BoutonJouer.Enabled = False
            LabelErrNom.Visible = True
        End If
    End Sub

    Private Sub BoutonQuitter_Click(sender As Object, e As EventArgs) Handles BoutonQuitter.Click, Me.Closed
        Dim choix = MsgBox("Souhaitez-vous vraiment quitter l'application ?", vbQuestion + vbYesNo, "Quitter l'application ?")
        If choix = vbYes Then
            ' Enregistrement des joueurs dans un fichier
            EnregistrerJoueurs()

            Application.Exit()
        End If
    End Sub

    Private Sub BoutonJouer_Click(sender As Object, e As EventArgs) Handles BoutonJouer.Click
        If Not JoueurExistant(ComboJoueur.Text) Then
            CréerJoueur(ComboJoueur.Text)
        Else
            joueurCourant = GetJoueur(ComboJoueur.Text)
        End If
        Hide()
        FPartie.Show()
    End Sub

    Private Sub ActualiserJoueurs()
        ComboJoueur.Items.Clear()

        Dim suggestionsNoms As New AutoCompleteStringCollection()
        For Each joueur As Joueurs.Joueur In listeJoueurs
            ' Le joueur peut dérouler la liste et sélectionner un nom enregistré...
            ComboJoueur.Items.Add(joueur.nom)
            ' ... ou commencer à le taper et voir apparaître des suggestions
            suggestionsNoms.Add(joueur.nom)
        Next

        ComboJoueur.AutoCompleteCustomSource = suggestionsNoms
    End Sub

    Private Sub FormulaireAccueil_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            ComboJoueur.Text = ""
            BoutonJouer.Enabled = False
            ActualiserJoueurs()
        End If
    End Sub

    Private Sub FormulaireAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerParamètres()

        CréerSauvegarde() ' s'il n'y en a pas
        ChargerSauvegarde()
    End Sub

    Private Sub BoutonOptions_Click(sender As Object, e As EventArgs) Handles BoutonOptions.Click
        Hide()
        FOptions.Show()
    End Sub
End Class
