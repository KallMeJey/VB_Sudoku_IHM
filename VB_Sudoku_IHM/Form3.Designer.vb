<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListeScores = New System.Windows.Forms.ListBox()
        Me.RevenirMenu = New System.Windows.Forms.Button()
        Me.QuitterScores = New System.Windows.Forms.Button()
        Me.Scores = New System.Windows.Forms.ListBox()
        Me.Label1Score = New System.Windows.Forms.Label()
        Me.OrdreAlphabetique = New System.Windows.Forms.Button()
        Me.OrdreMeilleurTemps = New System.Windows.Forms.Button()
        Me.BoutonStatistiques = New System.Windows.Forms.Button()
        Me.Reinitialiser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListeScores
        '
        Me.ListeScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListeScores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListeScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeScores.FormattingEnabled = True
        Me.ListeScores.ItemHeight = 29
        Me.ListeScores.Location = New System.Drawing.Point(134, 36)
        Me.ListeScores.Name = "ListeScores"
        Me.ListeScores.Size = New System.Drawing.Size(209, 350)
        Me.ListeScores.TabIndex = 0
        '
        'RevenirMenu
        '
        Me.RevenirMenu.BackColor = System.Drawing.SystemColors.Highlight
        Me.RevenirMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RevenirMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevenirMenu.Location = New System.Drawing.Point(363, 445)
        Me.RevenirMenu.Name = "RevenirMenu"
        Me.RevenirMenu.Size = New System.Drawing.Size(162, 63)
        Me.RevenirMenu.TabIndex = 2
        Me.RevenirMenu.Text = "Revenir au menu"
        Me.RevenirMenu.UseVisualStyleBackColor = False
        '
        'QuitterScores
        '
        Me.QuitterScores.BackColor = System.Drawing.SystemColors.HotTrack
        Me.QuitterScores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuitterScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitterScores.Location = New System.Drawing.Point(157, 445)
        Me.QuitterScores.Name = "QuitterScores"
        Me.QuitterScores.Size = New System.Drawing.Size(162, 63)
        Me.QuitterScores.TabIndex = 3
        Me.QuitterScores.Text = "Quitter"
        Me.QuitterScores.UseVisualStyleBackColor = False
        '
        'Scores
        '
        Me.Scores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Scores.Enabled = False
        Me.Scores.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scores.FormattingEnabled = True
        Me.Scores.ItemHeight = 46
        Me.Scores.Location = New System.Drawing.Point(388, 183)
        Me.Scores.Name = "Scores"
        Me.Scores.Size = New System.Drawing.Size(128, 48)
        Me.Scores.TabIndex = 4
        '
        'Label1Score
        '
        Me.Label1Score.AutoSize = True
        Me.Label1Score.Font = New System.Drawing.Font("Minerva", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1Score.Location = New System.Drawing.Point(372, 9)
        Me.Label1Score.Name = "Label1Score"
        Me.Label1Score.Size = New System.Drawing.Size(274, 34)
        Me.Label1Score.TabIndex = 5
        Me.Label1Score.Text = "Temps : (en secondes)"
        '
        'OrdreAlphabetique
        '
        Me.OrdreAlphabetique.Location = New System.Drawing.Point(105, 36)
        Me.OrdreAlphabetique.Name = "OrdreAlphabetique"
        Me.OrdreAlphabetique.Size = New System.Drawing.Size(23, 20)
        Me.OrdreAlphabetique.TabIndex = 6
        Me.OrdreAlphabetique.Text = "A"
        Me.OrdreAlphabetique.UseVisualStyleBackColor = True
        '
        'OrdreMeilleurTemps
        '
        Me.OrdreMeilleurTemps.Location = New System.Drawing.Point(105, 62)
        Me.OrdreMeilleurTemps.Name = "OrdreMeilleurTemps"
        Me.OrdreMeilleurTemps.Size = New System.Drawing.Size(23, 20)
        Me.OrdreMeilleurTemps.TabIndex = 7
        Me.OrdreMeilleurTemps.Text = "M"
        Me.OrdreMeilleurTemps.UseVisualStyleBackColor = True
        '
        'BoutonStatistiques
        '
        Me.BoutonStatistiques.BackColor = System.Drawing.SystemColors.Info
        Me.BoutonStatistiques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoutonStatistiques.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BoutonStatistiques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.BoutonStatistiques.Font = New System.Drawing.Font("Minerva", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoutonStatistiques.Location = New System.Drawing.Point(544, 191)
        Me.BoutonStatistiques.Name = "BoutonStatistiques"
        Me.BoutonStatistiques.Size = New System.Drawing.Size(115, 32)
        Me.BoutonStatistiques.TabIndex = 8
        Me.BoutonStatistiques.Text = "Statistiques"
        Me.BoutonStatistiques.UseVisualStyleBackColor = False
        '
        'Reinitialiser
        '
        Me.Reinitialiser.Location = New System.Drawing.Point(105, 88)
        Me.Reinitialiser.Name = "Reinitialiser"
        Me.Reinitialiser.Size = New System.Drawing.Size(23, 20)
        Me.Reinitialiser.TabIndex = 9
        Me.Reinitialiser.Text = "R"
        Me.Reinitialiser.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 533)
        Me.Controls.Add(Me.Reinitialiser)
        Me.Controls.Add(Me.BoutonStatistiques)
        Me.Controls.Add(Me.OrdreMeilleurTemps)
        Me.Controls.Add(Me.OrdreAlphabetique)
        Me.Controls.Add(Me.Label1Score)
        Me.Controls.Add(Me.Scores)
        Me.Controls.Add(Me.QuitterScores)
        Me.Controls.Add(Me.RevenirMenu)
        Me.Controls.Add(Me.ListeScores)
        Me.Name = "Form3"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListeScores As ListBox
    Friend WithEvents RevenirMenu As Button
    Friend WithEvents QuitterScores As Button
    Friend WithEvents Scores As ListBox
    Friend WithEvents Label1Score As Label
    Friend WithEvents OrdreAlphabetique As Button
    Friend WithEvents OrdreMeilleurTemps As Button
    Friend WithEvents BoutonStatistiques As Button
    Friend WithEvents Reinitialiser As Button
End Class
