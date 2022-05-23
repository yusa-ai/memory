<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAccueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAccueil))
        Me.BoutonJouer = New System.Windows.Forms.Button()
        Me.BoutonScores = New System.Windows.Forms.Button()
        Me.BoutonQuitter = New System.Windows.Forms.Button()
        Me.LabelMemory = New System.Windows.Forms.Label()
        Me.LabelJoueur = New System.Windows.Forms.Label()
        Me.ComboJoueur = New System.Windows.Forms.ComboBox()
        Me.LabelErrNom = New System.Windows.Forms.Label()
        Me.BoutonOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BoutonJouer
        '
        Me.BoutonJouer.Enabled = False
        Me.BoutonJouer.Location = New System.Drawing.Point(37, 142)
        Me.BoutonJouer.Name = "BoutonJouer"
        Me.BoutonJouer.Size = New System.Drawing.Size(216, 23)
        Me.BoutonJouer.TabIndex = 1
        Me.BoutonJouer.Text = "Jouer"
        Me.BoutonJouer.UseVisualStyleBackColor = True
        '
        'BoutonScores
        '
        Me.BoutonScores.Location = New System.Drawing.Point(37, 171)
        Me.BoutonScores.Name = "BoutonScores"
        Me.BoutonScores.Size = New System.Drawing.Size(216, 23)
        Me.BoutonScores.TabIndex = 2
        Me.BoutonScores.Text = "Scores"
        Me.BoutonScores.UseVisualStyleBackColor = True
        '
        'BoutonQuitter
        '
        Me.BoutonQuitter.Location = New System.Drawing.Point(37, 229)
        Me.BoutonQuitter.Name = "BoutonQuitter"
        Me.BoutonQuitter.Size = New System.Drawing.Size(216, 23)
        Me.BoutonQuitter.TabIndex = 4
        Me.BoutonQuitter.Text = "Quitter"
        Me.BoutonQuitter.UseVisualStyleBackColor = True
        '
        'LabelMemory
        '
        Me.LabelMemory.AutoSize = True
        Me.LabelMemory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.LabelMemory.Font = New System.Drawing.Font("Leckerli One", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMemory.ForeColor = System.Drawing.Color.White
        Me.LabelMemory.Location = New System.Drawing.Point(83, 21)
        Me.LabelMemory.Name = "LabelMemory"
        Me.LabelMemory.Size = New System.Drawing.Size(124, 39)
        Me.LabelMemory.TabIndex = 3
        Me.LabelMemory.Text = "Memory"
        '
        'LabelJoueur
        '
        Me.LabelJoueur.AutoSize = True
        Me.LabelJoueur.Location = New System.Drawing.Point(37, 70)
        Me.LabelJoueur.Name = "LabelJoueur"
        Me.LabelJoueur.Size = New System.Drawing.Size(88, 15)
        Me.LabelJoueur.TabIndex = 4
        Me.LabelJoueur.Text = "Nom du joueur"
        '
        'ComboJoueur
        '
        Me.ComboJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboJoueur.FormattingEnabled = True
        Me.ComboJoueur.Location = New System.Drawing.Point(37, 88)
        Me.ComboJoueur.Name = "ComboJoueur"
        Me.ComboJoueur.Size = New System.Drawing.Size(216, 23)
        Me.ComboJoueur.TabIndex = 0
        '
        'LabelErrNom
        '
        Me.LabelErrNom.AutoSize = True
        Me.LabelErrNom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.LabelErrNom.ForeColor = System.Drawing.Color.Red
        Me.LabelErrNom.Location = New System.Drawing.Point(37, 114)
        Me.LabelErrNom.Name = "LabelErrNom"
        Me.LabelErrNom.Size = New System.Drawing.Size(177, 13)
        Me.LabelErrNom.TabIndex = 6
        Me.LabelErrNom.Text = "Veuillez saisir au moins 3 caractères"
        Me.LabelErrNom.Visible = False
        '
        'BoutonOptions
        '
        Me.BoutonOptions.Location = New System.Drawing.Point(37, 200)
        Me.BoutonOptions.Name = "BoutonOptions"
        Me.BoutonOptions.Size = New System.Drawing.Size(216, 23)
        Me.BoutonOptions.TabIndex = 3
        Me.BoutonOptions.Text = "Options"
        Me.BoutonOptions.UseVisualStyleBackColor = True
        '
        'FAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 273)
        Me.Controls.Add(Me.BoutonOptions)
        Me.Controls.Add(Me.LabelErrNom)
        Me.Controls.Add(Me.ComboJoueur)
        Me.Controls.Add(Me.LabelJoueur)
        Me.Controls.Add(Me.LabelMemory)
        Me.Controls.Add(Me.BoutonQuitter)
        Me.Controls.Add(Me.BoutonScores)
        Me.Controls.Add(Me.BoutonJouer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BoutonQuitter As Button
    Friend WithEvents LabelMemory As Label
    Friend WithEvents LabelJoueur As Label
    Friend WithEvents ComboJoueur As ComboBox
    Friend WithEvents BoutonJouer As Button
    Friend WithEvents BoutonScores As Button
    Friend WithEvents LabelErrNom As Label
    Friend WithEvents BoutonOptions As Button
End Class
