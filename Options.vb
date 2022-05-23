Imports System.IO

Module Options
    Public ReadOnly NB_CARRES As Integer = 5
    Public ReadOnly NB_CARTES_CARRE As Integer = 4
    Public ReadOnly IMAGES_CARTES As Bitmap() = {My.Resources.Card0, My.Resources.Card1, My.Resources.Card2,
        My.Resources.Card3, My.Resources.Card4}

    Public Enum Difficulté
        Facile
        Normale
        Difficile
    End Enum
    Public DIFFICULTE As Difficulté = Difficulté.Normale
    Public ReadOnly PENALITE = 2

    Public PATH As String = Environment.CurrentDirectory & "\joueurs.txt" ' par défaut

    Public Sub ChargerParamètres()

        If File.Exists(My.Settings.PATH) Then
            PATH = My.Settings.PATH
        End If

        DIFFICULTE = ToDifficulté(My.Settings.DIFFICULTE)
    End Sub

    Public Function ToDifficulté(libellé As String)
        Select Case libellé
            Case "FACILE"
                Return Difficulté.Facile
            Case "NORMALE"
                Return Difficulté.Normale
            Case "DIFFICILE"
                Return Difficulté.Difficile
        End Select
        Return Difficulté.Normale
    End Function
End Module
