Imports System.IO

Friend Module Joueurs
    Public joueurCourant As Joueur

    <Serializable>
    Structure Joueur
        Public nom As String
        Public maxCarrés As Integer
        Public tempsMin As Integer ' en secondes
        Public nbParties As Integer
        Public tempsDeJeu As Integer ' en secondes

    End Structure

    Public listeJoueurs As New List(Of Joueur)

    Public Function JoueurExistant(nom As String)
        For Each joueur As Joueur In listeJoueurs
            If joueur.nom = nom Then Return True
        Next
        Return False
    End Function

    Public Sub CréerJoueur(nom As String)
        Dim joueur As Joueur = New Joueur
        With joueur
            .nom = nom
            .maxCarrés = 0
            .tempsMin = 0
            .nbParties = 0
            .tempsDeJeu = 0
        End With

        joueurCourant = joueur
        listeJoueurs.Add(joueurCourant)
    End Sub

    Public Function GetJoueur(nom As String)
        For Each joueur As Joueur In listeJoueurs
            If joueur.nom = nom Then Return joueur
        Next
        Return Nothing
    End Function

    Public Sub EnregistrerPartie(carrés As Integer, tempsMin As Integer, tempsPartie As Integer)
        Dim joueur As Joueur = GetJoueur(joueurCourant.nom)

        If joueur.maxCarrés < carrés Then
            joueur.maxCarrés = carrés
            joueur.tempsMin = tempsMin
        End If
        joueur.nbParties += 1
        joueur.tempsDeJeu += tempsPartie

        EcraserJoueur(joueur)

    End Sub

    Public Sub CréerSauvegarde()
        If Not File.Exists(PATH) Then File.Create(PATH).Dispose()
    End Sub

    Public Sub EnregistrerJoueurs()
        Dim reg As String

        Using sw As StreamWriter = New StreamWriter(PATH, False) ' False: on écrase le fichier existant
            For Each j As Joueur In listeJoueurs
                reg = j.nom & " " & j.maxCarrés & " " & j.tempsMin & " " & j.nbParties & " " & j.tempsDeJeu
                sw.WriteLine(reg)
            Next
        End Using

    End Sub

    Public Sub ChargerSauvegarde()
        Dim sr As New StreamReader(PATH)
        Dim save As String
        Dim data As String()

        Dim j As Joueur = New Joueur

        save = sr.ReadLine
        While save IsNot Nothing
            data = save.Split(" ")
            With j
                .nom = data(0)
                .maxCarrés = data(1)
                .tempsMin = data(2)
                .nbParties = data(3)
                .tempsDeJeu = data(4)
            End With
            listeJoueurs.Add(j)

            save = sr.ReadLine
        End While

        sr.Close()
    End Sub

    Private Sub EcraserJoueur(joueur As Joueur)
        For Each j As Joueur In listeJoueurs
            If j.nom = joueur.nom Then
                listeJoueurs.Remove(j)
                Exit For
            End If
        Next

        listeJoueurs.Add(joueur)
    End Sub

End Module
