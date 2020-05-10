Public Class Options
    Public timerActive2 As Boolean = True
    Public tempsMax As Integer = 180

    Private Sub ValiderOptions_Click(sender As Object, e As EventArgs) Handles ValiderOptions.Click

        If CheckBox1.Checked = True Then
            timerActive2 = False
        Else
            TempsPartie.Enabled = True
            timerActive2 = True
        End If

        If TempsPartie.Text <> "" Then
            tempsMax = TempsPartie.Text
        ElseIf CheckBox1.Checked = True Then

        Else
            MsgBox("Veuillez remplir au moins 1 champ")
            Exit Sub
        End If


        Dim reponse = MsgBox("Enregistré !", vbOKOnly)

        If reponse = vbOK Then
            Me.Hide()

        End If

    End Sub

End Class