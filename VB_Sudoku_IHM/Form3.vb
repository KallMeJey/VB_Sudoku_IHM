Imports System.IO

Public Class Form3

    Dim IndexSelectionneNOMS As Integer
    Dim IndexSelectionneSCORES As Integer

    Private Sub QuitterScores_Click(sender As Object, e As EventArgs) Handles QuitterScores.Click
        End
    End Sub

    Private Sub RevenirMenu_Click(sender As Object, e As EventArgs) Handles RevenirMenu.Click
        MyBase.Close()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1
            ListeScores.Items.Add(tabEnregistrementNOMS.Item(i).GetnomJ)
        Next

    End Sub

    Private Sub ListeScores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeScores.SelectedIndexChanged

        Scores.Items.Clear()
        Scores.Height = 48
        Scores.Width = 137
        Scores.Location = New Point(388, 183)

        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1
            If ListeScores.SelectedItem = tabEnregistrementNOMS.Item(i).GetnomJ Then
                Scores.Items.Add(tabEnregistrementNOMS.Item(i).GetmeilleurTempsJ + " s")
            End If
        Next

        Scores.Enabled = False

    End Sub

    Private Sub Scores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Scores.SelectedIndexChanged

        ListeScores.Items.Clear()

        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1
            If Scores.SelectedItem = tabEnregistrementNOMS.Item(i).GetmeilleurTempsJ Then
                ListeScores.Items.Add(tabEnregistrementNOMS.Item(i).GetnomJ)
            End If
        Next

        ListeScores.Enabled = False

    End Sub

    Private Sub OrdreAlphabetique_Click(sender As Object, e As EventArgs) Handles OrdreAlphabetique.Click

        ListeScores.Sorted = True

    End Sub

    Private Sub OrdreMeilleurTemps_Click(sender As Object, e As EventArgs) Handles OrdreMeilleurTemps.Click

        Scores.Items.Clear()
        Scores.Height = 352
        Scores.Width = 128
        Scores.Location = New Point(388, 45)

        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1
            Scores.Items.Add(tabEnregistrementNOMS.Item(i).GetmeilleurTempsJ)
        Next
        
        Scores.Sorted = True
        Scores.Enabled = True

    End Sub

    Private Sub Reinitialiser_Click(sender As Object, e As EventArgs) Handles Reinitialiser.Click

        ListeScores.Items.Clear()
        ListeScores.Sorted = False
        ListeScores.Enabled = True

        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1
            ListeScores.Items.Add(tabEnregistrementNOMS.Item(i).GetnomJ)
        Next

    End Sub

    Private Sub BoutonStatistiques_Click(sender As Object, e As EventArgs) Handles BoutonStatistiques.Click

        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1
            If ListeScores.SelectedItem = tabEnregistrementNOMS.Item(i).GetnomJ Then

                Dim tempsJeu As String

                If tabEnregistrementNOMS.Item(i).GettempsJeuJ > 60 Then

                    tabEnregistrementNOMS.Item(i).SetTempsJeuJMIN(Int(tabEnregistrementNOMS.Item(i).GettempsJeuJ / 60))
                    tabEnregistrementNOMS.Item(i).SetTempsJeuJSEC(tabEnregistrementNOMS.Item(i).GettempsJeuJ Mod 60)

                    tempsJeu = tabEnregistrementNOMS.Item(i).GettempsJeuJMIN + "min et " + tabEnregistrementNOMS.Item(i).GettempsJeuJSEC + "s"
                    MsgBox("Nom : " + tabEnregistrementNOMS.Item(i).GetnomJ + " - Meilleur temps : " + tabEnregistrementNOMS.Item(i).GetmeilleurTempsJ + "s" + " - Nombre de parties jouées : " + tabEnregistrementNOMS.Item(i).GetnbPartieJ + " - Temps de jeu : " + tempsJeu, vbOK)
                Else
                    MsgBox("Nom : " + tabEnregistrementNOMS.Item(i).GetnomJ + " - Meilleur temps : " + tabEnregistrementNOMS.Item(i).GetmeilleurTempsJ + "s" + " - Nombre de parties jouées : " + tabEnregistrementNOMS.Item(i).GetnbPartieJ + " - Temps de jeu : " + tabEnregistrementNOMS.Item(i).GettempsJeuJ + "s", vbOK)
                End If

            End If
        Next

    End Sub

End Class