Imports System.IO

Public Class Form2

    Dim gagne As Boolean = False

    Dim grilleTabJeu(8, 8) As TextBox
    Public tempsRestant As Timer = New Timer
    Public tempsLimite As Integer = Options.tempsMax
    Public tempsActuel As Integer = 0
    Public timerActive As Boolean = Options.timerActive2
    Dim nomFichierGrilles As String = My.Application.Info.DirectoryPath & "\Grilles.txt"

    Private Sub QuitterPartie_Click(sender As Object, e As EventArgs) Handles QuitterPartie.Click
        Dim reponse As String

        reponse = MsgBox("Attention, votre temps ne sera pas enregistré !", vbOKCancel)

        If reponse = vbOK Then


            tempsRestant.Enabled = False

            For i As Integer = 0 To 8
                For j As Integer = 0 To 8

                    grilleTabJeu(i, j).Text = ""
                    grilleTabJeu(i, j).BackColor = Color.White
                    grilleTabJeu(i, j).Enabled = True

                Next
            Next

            Close()
            Me.Close()
            End

        ElseIf reponse = vbCancel Then
            Exit Sub
        End If

    End Sub

    Private Sub QuitterPartieVersMenu_Click(sender As Object, e As EventArgs) Handles QuitterPartieVersMenu.Click
        Dim reponse As String

        reponse = MsgBox("Attention, votre temps ne sera pas enregistré !", vbOKCancel)

        If reponse = vbCancel Then
            Exit Sub
        ElseIf reponse = vbOK Then

            tempsRestant.Enabled = False

            For i As Integer = 0 To 8
                For j As Integer = 0 To 8

                    grilleTabJeu(i, j).Text = ""
                    grilleTabJeu(i, j).BackColor = Color.White
                    grilleTabJeu(i, j).Enabled = True

                Next
            Next

            Me.Close()
            Form1.Show()

        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NomJoueurPartie.Text = "Bonne chance " + Form1.ListeNoms.Text + " !"

        Dim X As Integer = 0
        Dim Y As Integer = 0

        For i As Integer = 0 To 8

            For j As Integer = 0 To 8

                grilleTabJeu(i, j) = New TextBox()
                grilleTabJeu(i, j).Multiline = True
                grilleTabJeu(i, j).Enabled = True
                grilleTabJeu(i, j).Name = i & " " & j
                grilleTabJeu(i, j).Height = 51
                grilleTabJeu(i, j).Width = 57
                grilleTabJeu(i, j).MaxLength = 1
                grilleTabJeu(i, j).TextAlign = HorizontalAlignment.Center
                grilleTabJeu(i, j).Font = New Font("Arial Rounded MT Bold", 20.25)
                grilleTabJeu(i, j).Location = New Point(190 + X, 108 + Y)
                grilleTabJeu(i, j).Visible = True
                Me.Controls.Add(grilleTabJeu(i, j))

                AddHandler grilleTabJeu(i, j).KeyDown, AddressOf TextBox_TextChanged
                AddHandler grilleTabJeu(i, j).KeyDown, AddressOf Verification_Validité

                If j = 2 Or j = 5 Then
                    X += 60
                Else
                    X += 55
                End If

            Next

            If i = 2 Or i = 5 Then
                Y += 55
            Else
                Y += 50
            End If

            X = 0
        Next

        Charger_Grille()

        If timerActive = False Then
            ScoreActuel.Enabled = False
            Label1Score.Enabled = False
        Else
            tempsRestant.Enabled = True
            ScoreActuel.Enabled = True
            Label1Score.Enabled = True
        End If

        tempsActuel = 0
        tempsRestant.Interval = 1000
        AddHandler tempsRestant.Tick, AddressOf tempsRestant_Tick

        ScoreActuel.Text = tempsLimite - tempsActuel & "/" & tempsLimite

    End Sub


    Private Sub Verification_Validité()
        Dim compteur As Integer = 0

        For i As Integer = 0 To 8
            For j As Integer = 0 To 8

                If grilleTabJeu(i, j).BackColor = Color.Red Or grilleTabJeu(i, j).Text = "" Then
                    compteur += 1
                End If

            Next
        Next

        If compteur = 0 Then
            gagne = True
            Gagner()
        End If

    End Sub

    Private Sub Gagner()
        Terminer_Partie()
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Or e.KeyValue = Keys.D2 Or e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad9 Or e.KeyCode = Keys.D9 Then

            Dim pos As String = sender.Name()
            Dim posLigneColonne() As String = pos.Split(New Char() {" "})

            Verifier_Ligne_Verticale(Val(posLigneColonne(0)), Val(posLigneColonne(1)), Convert.ToChar(e.KeyCode))
        Else
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub tempsRestant_Tick(sender As Object, ByVal e As EventArgs)
        tempsActuel += 1
        ScoreActuel.Text = tempsLimite - tempsActuel & "/" & tempsLimite
        Terminer_Partie()
    End Sub

    Private Sub Terminer_Partie()

        If tempsActuel = tempsLimite Then
            tempsRestant.Enabled = False

            MsgBox("Temps limite atteint, partie terminée ! Vous avez échoué ! Par conséquent, vous retournerez au menu et votre temps ne sera pas enregistré !")

            Me.Close()
            Form1.Show()

        ElseIf gagne = True Then

            tempsRestant.Enabled = False

            MsgBox("Bravo, vous avez gagné ! Vous allez retourner au menu et votre temps sera enregistré !")
            Enregistrements.Enregistrer()
            Me.Close()
            Form1.Show()
        End If

    End Sub

    Private Sub Verifier_Ligne_Horizontale(ligne As Integer, colonne As Integer, text As Char)

        For i As Integer = 0 To 8
            If i = colonne Then
                Continue For
            End If

            If grilleTabJeu(ligne, i).Text = grilleTabJeu(ligne, colonne).Text Then
                grilleTabJeu(ligne, colonne).BackColor = Color.Red
                Exit For
            Else
                grilleTabJeu(ligne, colonne).BackColor = Color.White
                Determiner_Carre(ligne, colonne, text)
            End If
        Next

    End Sub

    Private Sub Verifier_Ligne_Verticale(ligne As Integer, colonne As Integer, text As Char)

        If text = "a" Then
            text = "1"
        ElseIf text = "b" Then
            text = "2"
        ElseIf text = "c" Then
            text = "3"
        ElseIf text = "d" Then
            text = "4"
        ElseIf text = "e" Then
            text = "5"
        ElseIf text = "f" Then
            text = "6"
        ElseIf text = "g" Then
            text = "7"
        ElseIf text = "h" Then
            text = "8"
        ElseIf text = "i" Then
            text = "9"
        End If

        Dim numero As String = text

        grilleTabJeu(ligne, colonne).Text = numero

        For i As Integer = 0 To 8
            If i = ligne Then
                Continue For
            End If

            If grilleTabJeu(i, colonne).Text = grilleTabJeu(ligne, colonne).Text Then
                grilleTabJeu(ligne, colonne).BackColor = Color.Red
                Exit For
            Else
                grilleTabJeu(ligne, colonne).BackColor = Color.White
                Verifier_Ligne_Horizontale(ligne, colonne, text)
            End If
        Next

    End Sub

    Private Sub Determiner_Carre(ligne As Integer, colonne As Integer, text As Char)

        If ligne = 0 Or ligne = 1 Or ligne = 2 Then

            If colonne = 0 Or colonne = 1 Or colonne = 2 Then ' Carre 1
                Verrifier_Carre(0, 0, ligne, colonne, text)
            End If

            If colonne = 3 Or colonne = 4 Or colonne = 5 Then ' Carre 2
                Verrifier_Carre(3, 0, ligne, colonne, text)
            End If

            If colonne = 6 Or colonne = 7 Or colonne = 8 Then ' Carre 3
                Verrifier_Carre(6, 0, ligne, colonne, text)
            End If

        End If

        If ligne = 3 Or ligne = 4 Or ligne = 5 Then

            If colonne = 0 Or colonne = 1 Or colonne = 2 Then ' Carre 4
                Verrifier_Carre(0, 3, ligne, colonne, text)
            End If

            If colonne = 3 Or colonne = 4 Or colonne = 5 Then ' Carre 5
                Verrifier_Carre(3, 3, ligne, colonne, text)
            End If

            If colonne = 6 Or colonne = 7 Or colonne = 8 Then ' Carre 6
                Verrifier_Carre(6, 3, ligne, colonne, text)
            End If

        End If

        If ligne = 6 Or ligne = 7 Or ligne = 8 Then

            If colonne = 0 Or colonne = 1 Or colonne = 2 Then ' Carre 7
                Verrifier_Carre(0, 6, ligne, colonne, text)
            End If

            If colonne = 3 Or colonne = 4 Or colonne = 5 Then ' Carre 8
                Verrifier_Carre(3, 6, ligne, colonne, text)
            End If

            If colonne = 6 Or colonne = 7 Or colonne = 8 Then ' Carre 9
                Verrifier_Carre(6, 6, ligne, colonne, text)
            End If

        End If

    End Sub

    Private Sub Verrifier_Carre(indiceColonne As Integer, indiceLigne As Integer, ligne As Integer, colonne As Integer, text As Char)

        For i As Integer = indiceLigne To (indiceLigne + 2)
            For j As Integer = indiceColonne To (indiceColonne + 2)

                If i = ligne And j = colonne Then
                    Continue For
                End If

                If grilleTabJeu(i, j).Text = grilleTabJeu(ligne, colonne).Text Then
                    grilleTabJeu(ligne, colonne).BackColor = Color.Red
                    Exit Sub
                Else
                    grilleTabJeu(ligne, colonne).BackColor = Color.White
                End If
            Next
        Next

    End Sub

    Public Sub Charger_Grille()

        Randomize()

        Dim grilles() = File.ReadAllLines(nomFichierGrilles)
        Dim iAleatoire As Integer = Int(4 * Rnd())
        Dim grilleChoisie() As String = Split(grilles(iAleatoire), ",")
        Dim compteur As Integer = 0

        For i As Integer = 0 To 8

            For j As Integer = 0 To 8


                grilleTabJeu(i, j).Text = grilleChoisie(compteur)

                If grilleTabJeu(i, j).Text <> "" Then
                    grilleTabJeu(i, j).Enabled = False
                Else
                    grilleTabJeu(i, j).Enabled = True
                End If

                compteur += 1
            Next

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If timerActive = True Then

            If Button1.BackgroundImage.Height = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\pause2.png").Height Then
                Button1.BackgroundImage = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\unpause.png")
                tempsRestant.Enabled = False


                For i As Integer = 0 To 8

                    For j As Integer = 0 To 8

                        RemoveHandler grilleTabJeu(i, j).KeyDown, AddressOf TextBox_TextChanged
                        RemoveHandler grilleTabJeu(i, j).KeyDown, AddressOf Verification_Validité
                        AddHandler grilleTabJeu(i, j).KeyDown, AddressOf Inhib_pause
                    Next

                Next


            Else
                Button1.BackgroundImage = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\pause2.png")
                tempsRestant.Enabled = True

                For i As Integer = 0 To 8

                    For j As Integer = 0 To 8

                        AddHandler grilleTabJeu(i, j).KeyDown, AddressOf TextBox_TextChanged
                        AddHandler grilleTabJeu(i, j).KeyDown, AddressOf Verification_Validité
                        RemoveHandler grilleTabJeu(i, j).KeyDown, AddressOf Inhib_pause
                    Next

                Next


            End If

        Else
            MsgBox("Le temps n'est pas activé, vous ne pouvez pas arrêter le temps !")
        End If

    End Sub

    Private Sub Inhib_pause(sender As Object, e As System.Windows.Forms.KeyEventArgs)

        e.SuppressKeyPress = True

    End Sub
End Class