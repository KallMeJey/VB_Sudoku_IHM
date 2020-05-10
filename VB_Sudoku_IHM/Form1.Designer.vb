<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListeNoms = New System.Windows.Forms.ComboBox()
        Me.DemarrerPartie = New System.Windows.Forms.Button()
        Me.QuitterMenu = New System.Windows.Forms.Button()
        Me.ListeScores = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OptionsBouton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListeNoms
        '
        Me.ListeNoms.FormattingEnabled = True
        Me.ListeNoms.Location = New System.Drawing.Point(305, 156)
        Me.ListeNoms.Name = "ListeNoms"
        Me.ListeNoms.Size = New System.Drawing.Size(241, 21)
        Me.ListeNoms.TabIndex = 0
        '
        'DemarrerPartie
        '
        Me.DemarrerPartie.BackColor = System.Drawing.SystemColors.Highlight
        Me.DemarrerPartie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DemarrerPartie.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DemarrerPartie.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemarrerPartie.Location = New System.Drawing.Point(336, 222)
        Me.DemarrerPartie.Name = "DemarrerPartie"
        Me.DemarrerPartie.Size = New System.Drawing.Size(176, 86)
        Me.DemarrerPartie.TabIndex = 1
        Me.DemarrerPartie.Text = "Démarrer une partie"
        Me.DemarrerPartie.UseVisualStyleBackColor = False
        '
        'QuitterMenu
        '
        Me.QuitterMenu.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.QuitterMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuitterMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitterMenu.Location = New System.Drawing.Point(12, 345)
        Me.QuitterMenu.Name = "QuitterMenu"
        Me.QuitterMenu.Size = New System.Drawing.Size(176, 68)
        Me.QuitterMenu.TabIndex = 2
        Me.QuitterMenu.Text = "Quitter le jeu"
        Me.QuitterMenu.UseVisualStyleBackColor = False
        '
        'ListeScores
        '
        Me.ListeScores.BackColor = System.Drawing.SystemColors.Info
        Me.ListeScores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListeScores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ListeScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeScores.Location = New System.Drawing.Point(688, 343)
        Me.ListeScores.Name = "ListeScores"
        Me.ListeScores.Size = New System.Drawing.Size(176, 68)
        Me.ListeScores.TabIndex = 3
        Me.ListeScores.Text = "Scores"
        Me.ListeScores.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 40.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(347, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 65)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sudoku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minerva", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bienvenue dans le jeu de "
        '
        'OptionsBouton
        '
        Me.OptionsBouton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.OptionsBouton.BackgroundImage = CType(resources.GetObject("OptionsBouton.BackgroundImage"), System.Drawing.Image)
        Me.OptionsBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OptionsBouton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionsBouton.Location = New System.Drawing.Point(548, 245)
        Me.OptionsBouton.Name = "OptionsBouton"
        Me.OptionsBouton.Size = New System.Drawing.Size(53, 53)
        Me.OptionsBouton.TabIndex = 6
        Me.OptionsBouton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 437)
        Me.Controls.Add(Me.OptionsBouton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListeScores)
        Me.Controls.Add(Me.QuitterMenu)
        Me.Controls.Add(Me.DemarrerPartie)
        Me.Controls.Add(Me.ListeNoms)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListeNoms As ComboBox
    Friend WithEvents DemarrerPartie As Button
    Friend WithEvents QuitterMenu As Button
    Friend WithEvents ListeScores As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OptionsBouton As Button
End Class
