<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TempsPartie = New System.Windows.Forms.TextBox()
        Me.ValiderOptions = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minerva", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temps de partie :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minerva", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(144, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OPTIONS"
        '
        'TempsPartie
        '
        Me.TempsPartie.Location = New System.Drawing.Point(212, 140)
        Me.TempsPartie.Name = "TempsPartie"
        Me.TempsPartie.Size = New System.Drawing.Size(54, 20)
        Me.TempsPartie.TabIndex = 2
        '
        'ValiderOptions
        '
        Me.ValiderOptions.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ValiderOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ValiderOptions.Font = New System.Drawing.Font("Minerva", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValiderOptions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ValiderOptions.Location = New System.Drawing.Point(148, 316)
        Me.ValiderOptions.Name = "ValiderOptions"
        Me.ValiderOptions.Size = New System.Drawing.Size(97, 42)
        Me.ValiderOptions.TabIndex = 3
        Me.ValiderOptions.Text = "Valider"
        Me.ValiderOptions.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Minerva", 15.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(20, 103)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(206, 29)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = ": Désactiver le temps"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 395)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ValiderOptions)
        Me.Controls.Add(Me.TempsPartie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TempsPartie As TextBox
    Friend WithEvents ValiderOptions As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
