Imports System.IO

Public Class Form1

    Public tabNoms(50) As String
    Dim compteur As Integer = 0
    Public nomExistant As Boolean = False

    Private Sub QuitterMenu_Click(sender As Object, e As EventArgs) Handles QuitterMenu.Click

        Dim reponse As String

        reponse = MsgBox("Voulez vous vraiment quitter l'application ?", vbOKCancel)

        If reponse = vbOK Then
            Close()
            End
        ElseIf reponse = vbCancel Then
            Exit Sub
        End If

    End Sub

    Private Sub DemarrerPartie_Click(sender As System.Object, e As System.EventArgs) Handles DemarrerPartie.Click

        For i As Integer = 0 To ListeNoms.Items.Count
            If ListeNoms.Text.Equals(tabNoms(i)) Then
                nomExistant = True
            End If
        Next

        If nomExistant = True Then
            MsgBox("Content de vous revoir !")
        End If

        If ListeNoms.Text = "" Then
            MsgBox("Veuillez entrer votre nom")
        Else
            Me.Hide()
            Form2.Show()
            If Form2.timerActive = True Then
                Form2.tempsRestant.Enabled = True
            End If
            Form2.Charger_Grille()
            Form2.tempsActuel = 0

        End If

    End Sub

    Private Sub ListeNoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Charger()
        Call lectureListeNoms()
        ListeNoms.Focus()
    End Sub

    Private Sub lectureListeNoms()
        Dim fichierExistant As Boolean
        Dim longueurFichier As Long

        fichierExistant = System.IO.File.Exists(My.Application.Info.DirectoryPath & nomFichierNOMS)

        If fichierExistant = True Then
            longueurFichier = FileLen(My.Application.Info.DirectoryPath & nomFichierNOMS)
        End If

        If fichierExistant = False Or longueurFichier < 1 Then
            Exit Sub
        End If

        Dim streamReader As New System.IO.StreamReader(CStr(My.Application.Info.DirectoryPath & nomFichierNOMS))

        While streamReader.Peek() >= 0


            ListeNoms.Items.Add(streamReader.ReadLine())

            tabNoms(compteur) = ListeNoms.Items(compteur)
            compteur = compteur + 1
        End While

        streamReader.Close()
        ListeNoms.SelectedIndex = 0
        ListeNoms.Focus()
    End Sub

    Private Sub ListeScores_Click(sender As Object, e As EventArgs) Handles ListeScores.Click

        If File.Exists(My.Application.Info.DirectoryPath & nomFichierListeMeilleurSCORES) Then
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Aucun score n'a encore été enregistré !")
        End If

    End Sub

    Private Sub Options_Click(sender As Object, e As EventArgs) Handles OptionsBouton.Click
        Options.Show()
    End Sub
End Class
