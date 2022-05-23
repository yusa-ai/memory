<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FOptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FOptions))
        Me.LabelOptions = New System.Windows.Forms.Label()
        Me.BoutonRetour = New System.Windows.Forms.Button()
        Me.LabelTpsPartie = New System.Windows.Forms.Label()
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.NumTpsPartie = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxSauvegarde = New System.Windows.Forms.TextBox()
        Me.LabelSauvegarde = New System.Windows.Forms.Label()
        Me.CheckBoxPause = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTps = New System.Windows.Forms.CheckBox()
        Me.ComboDifficulté = New System.Windows.Forms.ComboBox()
        Me.LabelDifficulté = New System.Windows.Forms.Label()
        Me.ToolTipOptions = New System.Windows.Forms.ToolTip(Me.components)
        Me.BoutonSauvegarder = New System.Windows.Forms.Button()
        Me.PanelOptions.SuspendLayout()
        CType(Me.NumTpsPartie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelOptions
        '
        Me.LabelOptions.AutoSize = True
        Me.LabelOptions.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelOptions.Location = New System.Drawing.Point(46, 18)
        Me.LabelOptions.Name = "LabelOptions"
        Me.LabelOptions.Size = New System.Drawing.Size(181, 32)
        Me.LabelOptions.TabIndex = 0
        Me.LabelOptions.Text = "Options de jeu"
        Me.LabelOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BoutonRetour
        '
        Me.BoutonRetour.Location = New System.Drawing.Point(46, 288)
        Me.BoutonRetour.Name = "BoutonRetour"
        Me.BoutonRetour.Size = New System.Drawing.Size(181, 23)
        Me.BoutonRetour.TabIndex = 6
        Me.BoutonRetour.Text = "Retour"
        Me.BoutonRetour.UseVisualStyleBackColor = True
        '
        'LabelTpsPartie
        '
        Me.LabelTpsPartie.AutoSize = True
        Me.LabelTpsPartie.Location = New System.Drawing.Point(9, 13)
        Me.LabelTpsPartie.Name = "LabelTpsPartie"
        Me.LabelTpsPartie.Size = New System.Drawing.Size(102, 15)
        Me.LabelTpsPartie.TabIndex = 2
        Me.LabelTpsPartie.Text = "Temps de la partie"
        Me.ToolTipOptions.SetToolTip(Me.LabelTpsPartie, "Durée d'une partie en secondes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum : 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum : 90")
        '
        'PanelOptions
        '
        Me.PanelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOptions.Controls.Add(Me.NumTpsPartie)
        Me.PanelOptions.Controls.Add(Me.TextBoxSauvegarde)
        Me.PanelOptions.Controls.Add(Me.LabelSauvegarde)
        Me.PanelOptions.Controls.Add(Me.CheckBoxPause)
        Me.PanelOptions.Controls.Add(Me.CheckBoxTps)
        Me.PanelOptions.Controls.Add(Me.ComboDifficulté)
        Me.PanelOptions.Controls.Add(Me.LabelDifficulté)
        Me.PanelOptions.Controls.Add(Me.LabelTpsPartie)
        Me.PanelOptions.Location = New System.Drawing.Point(12, 62)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(248, 189)
        Me.PanelOptions.TabIndex = 3
        '
        'NumTpsPartie
        '
        Me.NumTpsPartie.Location = New System.Drawing.Point(117, 11)
        Me.NumTpsPartie.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.NumTpsPartie.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTpsPartie.Name = "NumTpsPartie"
        Me.NumTpsPartie.Size = New System.Drawing.Size(38, 23)
        Me.NumTpsPartie.TabIndex = 0
        Me.NumTpsPartie.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBoxSauvegarde
        '
        Me.TextBoxSauvegarde.Location = New System.Drawing.Point(9, 157)
        Me.TextBoxSauvegarde.Name = "TextBoxSauvegarde"
        Me.TextBoxSauvegarde.Size = New System.Drawing.Size(182, 23)
        Me.TextBoxSauvegarde.TabIndex = 4
        '
        'LabelSauvegarde
        '
        Me.LabelSauvegarde.AutoSize = True
        Me.LabelSauvegarde.Location = New System.Drawing.Point(9, 139)
        Me.LabelSauvegarde.Name = "LabelSauvegarde"
        Me.LabelSauvegarde.Size = New System.Drawing.Size(171, 15)
        Me.LabelSauvegarde.TabIndex = 10
        Me.LabelSauvegarde.Text = "Emplacement de la sauvegarde"
        '
        'CheckBoxPause
        '
        Me.CheckBoxPause.AutoSize = True
        Me.CheckBoxPause.Location = New System.Drawing.Point(9, 102)
        Me.CheckBoxPause.Name = "CheckBoxPause"
        Me.CheckBoxPause.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxPause.Size = New System.Drawing.Size(115, 19)
        Me.CheckBoxPause.TabIndex = 3
        Me.CheckBoxPause.Text = "Bouton de pause"
        Me.ToolTipOptions.SetToolTip(Me.CheckBoxPause, "Lors d'une partie, permet d'utiliser le bouton de pause." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Le joueur ne pourra plu" &
        "s interagir avec les cartes et le compte à rebours, s'il est activé," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sera figé." &
        "")
        Me.CheckBoxPause.UseVisualStyleBackColor = True
        '
        'CheckBoxTps
        '
        Me.CheckBoxTps.AutoSize = True
        Me.CheckBoxTps.Location = New System.Drawing.Point(34, 40)
        Me.CheckBoxTps.Name = "CheckBoxTps"
        Me.CheckBoxTps.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxTps.Size = New System.Drawing.Size(80, 19)
        Me.CheckBoxTps.TabIndex = 1
        Me.CheckBoxTps.Text = "Désactiver"
        Me.ToolTipOptions.SetToolTip(Me.CheckBoxTps, "Désactive le compte à rebours." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prenez tout votre temps !")
        Me.CheckBoxTps.UseVisualStyleBackColor = True
        '
        'ComboDifficulté
        '
        Me.ComboDifficulté.AutoCompleteCustomSource.AddRange(New String() {"FACILE", "NORMALE", "DIFFICILE"})
        Me.ComboDifficulté.FormattingEnabled = True
        Me.ComboDifficulté.Items.AddRange(New Object() {"FACILE", "NORMALE", "DIFFICILE"})
        Me.ComboDifficulté.Location = New System.Drawing.Point(70, 67)
        Me.ComboDifficulté.Name = "ComboDifficulté"
        Me.ComboDifficulté.Size = New System.Drawing.Size(121, 23)
        Me.ComboDifficulté.TabIndex = 2
        '
        'LabelDifficulté
        '
        Me.LabelDifficulté.AutoSize = True
        Me.LabelDifficulté.Location = New System.Drawing.Point(9, 70)
        Me.LabelDifficulté.Name = "LabelDifficulté"
        Me.LabelDifficulté.Size = New System.Drawing.Size(55, 15)
        Me.LabelDifficulté.TabIndex = 4
        Me.LabelDifficulté.Text = "Difficulté"
        Me.ToolTipOptions.SetToolTip(Me.LabelDifficulté, resources.GetString("LabelDifficulté.ToolTip"))
        '
        'BoutonSauvegarder
        '
        Me.BoutonSauvegarder.Location = New System.Drawing.Point(46, 262)
        Me.BoutonSauvegarder.Name = "BoutonSauvegarder"
        Me.BoutonSauvegarder.Size = New System.Drawing.Size(181, 23)
        Me.BoutonSauvegarder.TabIndex = 5
        Me.BoutonSauvegarder.Text = "Sauvegarder"
        Me.BoutonSauvegarder.UseVisualStyleBackColor = True
        '
        'FOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.BoutonSauvegarder)
        Me.Controls.Add(Me.PanelOptions)
        Me.Controls.Add(Me.BoutonRetour)
        Me.Controls.Add(Me.LabelOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory"
        Me.PanelOptions.ResumeLayout(False)
        Me.PanelOptions.PerformLayout()
        CType(Me.NumTpsPartie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelOptions As Label
    Friend WithEvents BoutonRetour As Button
    Friend WithEvents LabelTpsPartie As Label
    Friend WithEvents PanelOptions As Panel
    Friend WithEvents ToolTipOptions As ToolTip
    Friend WithEvents LabelDifficulté As Label
    Friend WithEvents ComboDifficulté As ComboBox
    Friend WithEvents CheckBoxTps As CheckBox
    Friend WithEvents CheckBoxPause As CheckBox
    Friend WithEvents LabelSauvegarde As Label
    Friend WithEvents TextBoxSauvegarde As TextBox
    Friend WithEvents BoutonSauvegarder As Button
    Friend WithEvents NumTpsPartie As NumericUpDown
End Class
