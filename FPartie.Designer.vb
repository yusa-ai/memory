<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPartie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPartie))
        Me.LabelMemory = New System.Windows.Forms.Label()
        Me.PanelPartie = New System.Windows.Forms.Panel()
        Me.LabelDifficulté = New System.Windows.Forms.Label()
        Me.BoutonPause = New System.Windows.Forms.Button()
        Me.LabelTimerPartie = New System.Windows.Forms.Label()
        Me.LabelJoueur = New System.Windows.Forms.Label()
        Me.BoutonAbandonner = New System.Windows.Forms.Button()
        Me.PanelCartes = New System.Windows.Forms.TableLayoutPanel()
        Me.Carte20 = New System.Windows.Forms.Label()
        Me.Carte19 = New System.Windows.Forms.Label()
        Me.Carte18 = New System.Windows.Forms.Label()
        Me.Carte17 = New System.Windows.Forms.Label()
        Me.Carte16 = New System.Windows.Forms.Label()
        Me.Carte15 = New System.Windows.Forms.Label()
        Me.Carte14 = New System.Windows.Forms.Label()
        Me.Carte13 = New System.Windows.Forms.Label()
        Me.Carte12 = New System.Windows.Forms.Label()
        Me.Carte11 = New System.Windows.Forms.Label()
        Me.Carte10 = New System.Windows.Forms.Label()
        Me.Carte9 = New System.Windows.Forms.Label()
        Me.Carte8 = New System.Windows.Forms.Label()
        Me.Carte7 = New System.Windows.Forms.Label()
        Me.Carte6 = New System.Windows.Forms.Label()
        Me.Carte5 = New System.Windows.Forms.Label()
        Me.Carte4 = New System.Windows.Forms.Label()
        Me.Carte3 = New System.Windows.Forms.Label()
        Me.Carte2 = New System.Windows.Forms.Label()
        Me.Carte1 = New System.Windows.Forms.Label()
        Me.TimerPartie = New System.Windows.Forms.Timer(Me.components)
        Me.TimerResetPlateau = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPartie.SuspendLayout()
        Me.PanelCartes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMemory
        '
        Me.LabelMemory.AutoSize = True
        Me.LabelMemory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.LabelMemory.Font = New System.Drawing.Font("Leckerli One", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMemory.ForeColor = System.Drawing.Color.White
        Me.LabelMemory.Location = New System.Drawing.Point(37, 25)
        Me.LabelMemory.Name = "LabelMemory"
        Me.LabelMemory.Size = New System.Drawing.Size(124, 39)
        Me.LabelMemory.TabIndex = 4
        Me.LabelMemory.Text = "Memory"
        '
        'PanelPartie
        '
        Me.PanelPartie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPartie.Controls.Add(Me.LabelDifficulté)
        Me.PanelPartie.Controls.Add(Me.BoutonPause)
        Me.PanelPartie.Controls.Add(Me.LabelTimerPartie)
        Me.PanelPartie.Controls.Add(Me.LabelJoueur)
        Me.PanelPartie.Controls.Add(Me.BoutonAbandonner)
        Me.PanelPartie.Controls.Add(Me.LabelMemory)
        Me.PanelPartie.Location = New System.Drawing.Point(9, 6)
        Me.PanelPartie.Name = "PanelPartie"
        Me.PanelPartie.Size = New System.Drawing.Size(200, 400)
        Me.PanelPartie.TabIndex = 5
        '
        'LabelDifficulté
        '
        Me.LabelDifficulté.AutoSize = True
        Me.LabelDifficulté.Location = New System.Drawing.Point(43, 179)
        Me.LabelDifficulté.Name = "LabelDifficulté"
        Me.LabelDifficulté.Size = New System.Drawing.Size(110, 15)
        Me.LabelDifficulté.TabIndex = 10
        Me.LabelDifficulté.Text = "Difficulté : Normale"
        '
        'BoutonPause
        '
        Me.BoutonPause.Enabled = False
        Me.BoutonPause.Location = New System.Drawing.Point(37, 210)
        Me.BoutonPause.Name = "BoutonPause"
        Me.BoutonPause.Size = New System.Drawing.Size(124, 23)
        Me.BoutonPause.TabIndex = 0
        Me.BoutonPause.Text = "Pause"
        Me.BoutonPause.UseVisualStyleBackColor = True
        '
        'LabelTimerPartie
        '
        Me.LabelTimerPartie.AutoSize = True
        Me.LabelTimerPartie.Location = New System.Drawing.Point(40, 159)
        Me.LabelTimerPartie.Name = "LabelTimerPartie"
        Me.LabelTimerPartie.Size = New System.Drawing.Size(116, 15)
        Me.LabelTimerPartie.TabIndex = 8
        Me.LabelTimerPartie.Text = "Temps restant : 01:00"
        '
        'LabelJoueur
        '
        Me.LabelJoueur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelJoueur.AutoSize = True
        Me.LabelJoueur.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelJoueur.Location = New System.Drawing.Point(54, 108)
        Me.LabelJoueur.Name = "LabelJoueur"
        Me.LabelJoueur.Size = New System.Drawing.Size(88, 32)
        Me.LabelJoueur.TabIndex = 6
        Me.LabelJoueur.Text = "Joueur"
        '
        'BoutonAbandonner
        '
        Me.BoutonAbandonner.Location = New System.Drawing.Point(37, 239)
        Me.BoutonAbandonner.Name = "BoutonAbandonner"
        Me.BoutonAbandonner.Size = New System.Drawing.Size(124, 73)
        Me.BoutonAbandonner.TabIndex = 1
        Me.BoutonAbandonner.Text = "Abandonner"
        Me.BoutonAbandonner.UseVisualStyleBackColor = True
        '
        'PanelCartes
        '
        Me.PanelCartes.ColumnCount = 5
        Me.PanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelCartes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelCartes.Controls.Add(Me.Carte20, 4, 3)
        Me.PanelCartes.Controls.Add(Me.Carte19, 3, 3)
        Me.PanelCartes.Controls.Add(Me.Carte18, 2, 3)
        Me.PanelCartes.Controls.Add(Me.Carte17, 1, 3)
        Me.PanelCartes.Controls.Add(Me.Carte16, 0, 3)
        Me.PanelCartes.Controls.Add(Me.Carte15, 4, 2)
        Me.PanelCartes.Controls.Add(Me.Carte14, 3, 2)
        Me.PanelCartes.Controls.Add(Me.Carte13, 2, 2)
        Me.PanelCartes.Controls.Add(Me.Carte12, 1, 2)
        Me.PanelCartes.Controls.Add(Me.Carte11, 0, 2)
        Me.PanelCartes.Controls.Add(Me.Carte10, 4, 1)
        Me.PanelCartes.Controls.Add(Me.Carte9, 3, 1)
        Me.PanelCartes.Controls.Add(Me.Carte8, 2, 1)
        Me.PanelCartes.Controls.Add(Me.Carte7, 1, 1)
        Me.PanelCartes.Controls.Add(Me.Carte6, 0, 1)
        Me.PanelCartes.Controls.Add(Me.Carte5, 4, 0)
        Me.PanelCartes.Controls.Add(Me.Carte4, 3, 0)
        Me.PanelCartes.Controls.Add(Me.Carte3, 2, 0)
        Me.PanelCartes.Controls.Add(Me.Carte2, 1, 0)
        Me.PanelCartes.Controls.Add(Me.Carte1, 0, 0)
        Me.PanelCartes.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.PanelCartes.Location = New System.Drawing.Point(215, 6)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.RowCount = 4
        Me.PanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelCartes.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelCartes.Size = New System.Drawing.Size(413, 409)
        Me.PanelCartes.TabIndex = 6
        '
        'Carte20
        '
        Me.Carte20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte20.Location = New System.Drawing.Point(331, 300)
        Me.Carte20.Name = "Carte20"
        Me.Carte20.Size = New System.Drawing.Size(76, 100)
        Me.Carte20.TabIndex = 27
        Me.Carte20.Text = "Carte20"
        Me.Carte20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte19
        '
        Me.Carte19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte19.Location = New System.Drawing.Point(249, 300)
        Me.Carte19.Name = "Carte19"
        Me.Carte19.Size = New System.Drawing.Size(76, 100)
        Me.Carte19.TabIndex = 26
        Me.Carte19.Text = "Carte19"
        Me.Carte19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte18
        '
        Me.Carte18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte18.Location = New System.Drawing.Point(167, 300)
        Me.Carte18.Name = "Carte18"
        Me.Carte18.Size = New System.Drawing.Size(76, 100)
        Me.Carte18.TabIndex = 25
        Me.Carte18.Text = "Carte18"
        Me.Carte18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte17
        '
        Me.Carte17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte17.Location = New System.Drawing.Point(85, 300)
        Me.Carte17.Name = "Carte17"
        Me.Carte17.Size = New System.Drawing.Size(76, 100)
        Me.Carte17.TabIndex = 24
        Me.Carte17.Text = "Carte17"
        Me.Carte17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte16
        '
        Me.Carte16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte16.Location = New System.Drawing.Point(3, 300)
        Me.Carte16.Name = "Carte16"
        Me.Carte16.Size = New System.Drawing.Size(76, 100)
        Me.Carte16.TabIndex = 23
        Me.Carte16.Text = "Carte16"
        Me.Carte16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte15
        '
        Me.Carte15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte15.Location = New System.Drawing.Point(331, 200)
        Me.Carte15.Name = "Carte15"
        Me.Carte15.Size = New System.Drawing.Size(76, 100)
        Me.Carte15.TabIndex = 22
        Me.Carte15.Text = "Carte15"
        Me.Carte15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte14
        '
        Me.Carte14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte14.Location = New System.Drawing.Point(249, 200)
        Me.Carte14.Name = "Carte14"
        Me.Carte14.Size = New System.Drawing.Size(76, 100)
        Me.Carte14.TabIndex = 21
        Me.Carte14.Text = "Carte14"
        Me.Carte14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte13
        '
        Me.Carte13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte13.Location = New System.Drawing.Point(167, 200)
        Me.Carte13.Name = "Carte13"
        Me.Carte13.Size = New System.Drawing.Size(76, 100)
        Me.Carte13.TabIndex = 20
        Me.Carte13.Text = "Carte13"
        Me.Carte13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte12
        '
        Me.Carte12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte12.Location = New System.Drawing.Point(85, 200)
        Me.Carte12.Name = "Carte12"
        Me.Carte12.Size = New System.Drawing.Size(76, 100)
        Me.Carte12.TabIndex = 19
        Me.Carte12.Text = "Carte12"
        Me.Carte12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte11
        '
        Me.Carte11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte11.Location = New System.Drawing.Point(3, 200)
        Me.Carte11.Name = "Carte11"
        Me.Carte11.Size = New System.Drawing.Size(76, 100)
        Me.Carte11.TabIndex = 18
        Me.Carte11.Text = "Carte11"
        Me.Carte11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte10
        '
        Me.Carte10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte10.Location = New System.Drawing.Point(331, 100)
        Me.Carte10.Name = "Carte10"
        Me.Carte10.Size = New System.Drawing.Size(76, 100)
        Me.Carte10.TabIndex = 17
        Me.Carte10.Text = "Carte10"
        Me.Carte10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte9
        '
        Me.Carte9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte9.Location = New System.Drawing.Point(249, 100)
        Me.Carte9.Name = "Carte9"
        Me.Carte9.Size = New System.Drawing.Size(76, 100)
        Me.Carte9.TabIndex = 16
        Me.Carte9.Text = "Carte9"
        Me.Carte9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte8
        '
        Me.Carte8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte8.Location = New System.Drawing.Point(167, 100)
        Me.Carte8.Name = "Carte8"
        Me.Carte8.Size = New System.Drawing.Size(76, 100)
        Me.Carte8.TabIndex = 15
        Me.Carte8.Text = "Carte8"
        Me.Carte8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte7
        '
        Me.Carte7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte7.Location = New System.Drawing.Point(85, 100)
        Me.Carte7.Name = "Carte7"
        Me.Carte7.Size = New System.Drawing.Size(76, 100)
        Me.Carte7.TabIndex = 14
        Me.Carte7.Text = "Carte7"
        Me.Carte7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte6
        '
        Me.Carte6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte6.Location = New System.Drawing.Point(3, 100)
        Me.Carte6.Name = "Carte6"
        Me.Carte6.Size = New System.Drawing.Size(76, 100)
        Me.Carte6.TabIndex = 13
        Me.Carte6.Text = "Carte6"
        Me.Carte6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte5
        '
        Me.Carte5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte5.Location = New System.Drawing.Point(331, 0)
        Me.Carte5.Name = "Carte5"
        Me.Carte5.Size = New System.Drawing.Size(76, 100)
        Me.Carte5.TabIndex = 12
        Me.Carte5.Text = "Carte5"
        Me.Carte5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte4
        '
        Me.Carte4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte4.Location = New System.Drawing.Point(249, 0)
        Me.Carte4.Name = "Carte4"
        Me.Carte4.Size = New System.Drawing.Size(76, 100)
        Me.Carte4.TabIndex = 11
        Me.Carte4.Text = "Carte4"
        Me.Carte4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte3
        '
        Me.Carte3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte3.Location = New System.Drawing.Point(167, 0)
        Me.Carte3.Name = "Carte3"
        Me.Carte3.Size = New System.Drawing.Size(76, 100)
        Me.Carte3.TabIndex = 10
        Me.Carte3.Text = "Carte3"
        Me.Carte3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte2
        '
        Me.Carte2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte2.Location = New System.Drawing.Point(85, 0)
        Me.Carte2.Name = "Carte2"
        Me.Carte2.Size = New System.Drawing.Size(76, 100)
        Me.Carte2.TabIndex = 9
        Me.Carte2.Text = "Carte2"
        Me.Carte2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Carte1
        '
        Me.Carte1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Carte1.Location = New System.Drawing.Point(3, 0)
        Me.Carte1.Name = "Carte1"
        Me.Carte1.Size = New System.Drawing.Size(76, 100)
        Me.Carte1.TabIndex = 8
        Me.Carte1.Text = "Carte1"
        Me.Carte1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerPartie
        '
        Me.TimerPartie.Interval = 1000
        '
        'TimerResetPlateau
        '
        Me.TimerResetPlateau.Interval = 1000
        '
        'FPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelCartes)
        Me.Controls.Add(Me.PanelPartie)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FPartie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory"
        Me.PanelPartie.ResumeLayout(False)
        Me.PanelPartie.PerformLayout()
        Me.PanelCartes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelMemory As Label
    Friend WithEvents PanelPartie As Panel
    Friend WithEvents BoutonAbandonner As Button
    Friend WithEvents LabelJoueur As Label
    Friend WithEvents PanelCartes As TableLayoutPanel
    Friend WithEvents TimerPartie As Timer
    Friend WithEvents LabelTimerPartie As Label
    Friend WithEvents TimerRetournerCartes As Timer
    Friend WithEvents TimerReset As Timer
    Friend WithEvents TimerResetPlateau As Timer
    Friend WithEvents Carte19 As Label
    Friend WithEvents Carte10 As Label
    Friend WithEvents Carte9 As Label
    Friend WithEvents Carte8 As Label
    Friend WithEvents Carte7 As Label
    Friend WithEvents Carte4 As Label
    Friend WithEvents Carte3 As Label
    Friend WithEvents Carte2 As Label
    Friend WithEvents Carte1 As Label
    Friend WithEvents Carte5 As Label
    Friend WithEvents Carte6 As Label
    Friend WithEvents Carte11 As Label
    Friend WithEvents Carte12 As Label
    Friend WithEvents Carte13 As Label
    Friend WithEvents Carte14 As Label
    Friend WithEvents Carte15 As Label
    Friend WithEvents Carte16 As Label
    Friend WithEvents Carte17 As Label
    Friend WithEvents Carte18 As Label
    Friend WithEvents Carte20 As Label
    Friend WithEvents BoutonPause As Button
    Friend WithEvents LabelDifficulté As Label
End Class
