<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.QuitterPartie = New System.Windows.Forms.Button()
        Me.ScoreActuel = New System.Windows.Forms.Label()
        Me.Label1Score = New System.Windows.Forms.Label()
        Me.QuitterPartieVersMenu = New System.Windows.Forms.Button()
        Me.NomJoueurPartie = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'QuitterPartie
        '
        Me.QuitterPartie.BackColor = System.Drawing.SystemColors.HotTrack
        Me.QuitterPartie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuitterPartie.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.QuitterPartie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitterPartie.Location = New System.Drawing.Point(12, 585)
        Me.QuitterPartie.Name = "QuitterPartie"
        Me.QuitterPartie.Size = New System.Drawing.Size(148, 68)
        Me.QuitterPartie.TabIndex = 0
        Me.QuitterPartie.Text = "Quitter et enregistrer score"
        Me.QuitterPartie.UseVisualStyleBackColor = False
        '
        'ScoreActuel
        '
        Me.ScoreActuel.AutoSize = True
        Me.ScoreActuel.Font = New System.Drawing.Font("Minerva", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreActuel.Location = New System.Drawing.Point(904, 9)
        Me.ScoreActuel.Name = "ScoreActuel"
        Me.ScoreActuel.Size = New System.Drawing.Size(0, 45)
        Me.ScoreActuel.TabIndex = 1
        '
        'Label1Score
        '
        Me.Label1Score.AutoSize = True
        Me.Label1Score.Font = New System.Drawing.Font("Minerva", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1Score.Location = New System.Drawing.Point(639, 9)
        Me.Label1Score.Name = "Label1Score"
        Me.Label1Score.Size = New System.Drawing.Size(231, 40)
        Me.Label1Score.TabIndex = 6
        Me.Label1Score.Text = "Temps restant :"
        '
        'QuitterPartieVersMenu
        '
        Me.QuitterPartieVersMenu.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.QuitterPartieVersMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuitterPartieVersMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitterPartieVersMenu.Location = New System.Drawing.Point(731, 585)
        Me.QuitterPartieVersMenu.Name = "QuitterPartieVersMenu"
        Me.QuitterPartieVersMenu.Size = New System.Drawing.Size(148, 68)
        Me.QuitterPartieVersMenu.TabIndex = 7
        Me.QuitterPartieVersMenu.Text = "Revenir au menu et enregistrer score"
        Me.QuitterPartieVersMenu.UseVisualStyleBackColor = False
        '
        'NomJoueurPartie
        '
        Me.NomJoueurPartie.AutoSize = True
        Me.NomJoueurPartie.Font = New System.Drawing.Font("Minerva", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomJoueurPartie.Location = New System.Drawing.Point(43, 9)
        Me.NomJoueurPartie.Name = "NomJoueurPartie"
        Me.NomJoueurPartie.Size = New System.Drawing.Size(219, 40)
        Me.NomJoueurPartie.TabIndex = 8
        Me.NomJoueurPartie.Text = "Bonne chance !"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(912, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 658)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NomJoueurPartie)
        Me.Controls.Add(Me.QuitterPartieVersMenu)
        Me.Controls.Add(Me.Label1Score)
        Me.Controls.Add(Me.ScoreActuel)
        Me.Controls.Add(Me.QuitterPartie)
        Me.Name = "Form2"
        Me.Text = "Partie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuitterPartie As Button
    Friend WithEvents ScoreActuel As Label
    Friend WithEvents Label1Score As Label
    Friend WithEvents QuitterPartieVersMenu As Button
    Friend WithEvents NomJoueurPartie As Label
    Friend WithEvents Button1 As Button
End Class
