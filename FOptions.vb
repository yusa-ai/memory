Imports System.IO

Public Class FOptions

    Private Sub FormulaireOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.DECOMPTER_TEMPS Then CheckBoxTps.Checked = True
        NumTpsPartie.Value = My.Settings.TEMPS_PARTIE
        ComboDifficulté.Text = UCase(DIFFICULTE.ToString)
        ComboDifficulté.DropDownStyle = ComboBoxStyle.DropDownList
        CheckBoxPause.Checked = My.Settings.BOUTON_PAUSE
        TextBoxSauvegarde.Text = PATH
    End Sub

    Private Sub BoutonRetour_Click(sender As Object, e As EventArgs) Handles BoutonRetour.Click
        RetourAccueil()
    End Sub

    Private Sub CheckBoxTps_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTps.CheckedChanged
        LabelTpsPartie.Enabled = Not LabelTpsPartie.Enabled
        NumTpsPartie.Enabled = Not NumTpsPartie.Enabled
    End Sub

    Private Sub BoutonSauvegarder_Click(sender As Object, e As EventArgs) Handles BoutonSauvegarder.Click
        If NumTpsPartie.Enabled Then My.Settings.TEMPS_PARTIE = NumTpsPartie.Value

        My.Settings.DECOMPTER_TEMPS = Not CheckBoxTps.Enabled OrElse Not CheckBoxTps.Checked

        My.Settings.DIFFICULTE = ComboDifficulté.Text
        DIFFICULTE = ToDifficulté(My.Settings.DIFFICULTE)

        My.Settings.BOUTON_PAUSE = CheckBoxPause.Checked

        My.Settings.PATH = TextBoxSauvegarde.Text

        If My.Settings.PATH <> PATH And File.Exists(PATH) Then
            My.Computer.FileSystem.MoveFile(PATH, My.Settings.PATH)
        End If
        ChargerParamètres()

        MsgBox("Vos paramètres ont bien été enregistrés.", vbInformation + vbOKOnly, "Sauvegarde effectuée")
        RetourAccueil()
    End Sub

    Private Sub RetourAccueil()
        FAccueil.Show()
        Close()
    End Sub

    Private Sub ComboDifficulté_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDifficulté.SelectedIndexChanged
        If ToDifficulté(ComboDifficulté.Text) = Difficulté.Difficile Then
            ' Le mode Difficile pénalise les joueurs en retirant des secondes,
            ' il faut donc nécessairement que le décompte soit activé
            LabelTpsPartie.Enabled = True
            NumTpsPartie.Enabled = True
            CheckBoxTps.Enabled = False
        Else
            CheckBoxTps.Enabled = True
        End If
    End Sub

End Class