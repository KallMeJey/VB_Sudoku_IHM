Imports System.IO

Module Enregistrements

    Public nomFichierNOMS As String = "\EnregistrementNoms.txt"
    Public nomFichierListeMeilleurSCORES = "\EnregistrementScores.txt"
    Public nomFichierTempsJEU = "\EnregistrementTempsJeu.txt"
    Public nomFichierNBJOUEES = "\EnregistrementNbParties.txt"
    Public tabEnregistrementNOMS As New List(Of Joueurs)
    Dim fichiersExistent = False

    Public Sub Charger()
        If Len(Dir(My.Application.Info.DirectoryPath & nomFichierNOMS)) > 0 And Len(Dir(My.Application.Info.DirectoryPath & nomFichierListeMeilleurSCORES)) > 0 And Len(Dir(My.Application.Info.DirectoryPath & nomFichierNBJOUEES)) > 0 And Len(Dir(My.Application.Info.DirectoryPath & nomFichierTempsJEU)) > 0 Then
            Dim streamReaderNOMS As New System.IO.StreamReader(CStr(My.Application.Info.DirectoryPath & nomFichierNOMS))
            Dim streamReaderMeilleurSCORES As New System.IO.StreamReader(CStr(My.Application.Info.DirectoryPath & nomFichierListeMeilleurSCORES))
            Dim streamReaderNBJOUEES As New System.IO.StreamReader(CStr(My.Application.Info.DirectoryPath & nomFichierNBJOUEES))
            Dim streamReaderTPSJEU As New System.IO.StreamReader(CStr(My.Application.Info.DirectoryPath & nomFichierTempsJEU))

            While streamReaderNOMS.Peek() >= 0
                tabEnregistrementNOMS.Add(New Joueurs(streamReaderNOMS.ReadLine(), streamReaderNBJOUEES.ReadLine(), streamReaderMeilleurSCORES.ReadLine(), streamReaderTPSJEU.ReadLine()))
            End While

            streamReaderNOMS.Close()
            streamReaderMeilleurSCORES.Close()
            streamReaderNBJOUEES.Close()
            streamReaderTPSJEU.Close()

            fichiersExistent = True
        Else
            fichiersExistent = False
        End If
    End Sub

    Public Sub Enregistrer()

        If Form1.nomExistant = True Then

            For i As Integer = 0 To tabEnregistrementNOMS.Count - 1

                Dim j As Joueurs = tabEnregistrementNOMS.Item(i)

                If j.GetnomJ = Form1.ListeNoms.Text Then

                    j.AugmenterNbPartie()
                    j.AugmenterTempsJeu(Form2.tempsActuel)

                    If j.GetmeilleurTempsJ > Form2.tempsActuel Then
                        j.SetMeilleurTemps(Form2.tempsActuel)
                    End If

                End If

            Next

        Else
            tabEnregistrementNOMS.Add(New Joueurs(Form1.ListeNoms.Text, 1, Form2.tempsActuel, Form2.tempsActuel))
        End If


        If fichiersExistent = True Then
            Kill(My.Application.Info.DirectoryPath & nomFichierListeMeilleurSCORES)
            Kill(My.Application.Info.DirectoryPath & nomFichierNOMS)
            Kill(My.Application.Info.DirectoryPath & nomFichierNBJOUEES)
            Kill(My.Application.Info.DirectoryPath & nomFichierTempsJEU)
        End If


        For i As Integer = 0 To tabEnregistrementNOMS.Count - 1

            Dim j As Joueurs = tabEnregistrementNOMS.Item(i)

            If Form1.ListeNoms.Text <> "" Then

                Using StreamWriter As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & nomFichierListeMeilleurSCORES, True)
                    StreamWriter.WriteLine(j.GetmeilleurTempsJ)
                End Using

                Using StreamWriter As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & nomFichierNOMS, True)
                    StreamWriter.WriteLine(j.GetnomJ)
                End Using

                Using StreamWriter As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & nomFichierNBJOUEES, True)
                    StreamWriter.WriteLine(j.GetnbPartieJ)
                End Using

                Using StreamWriter As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & nomFichierTempsJEU, True)
                    StreamWriter.WriteLine(j.GettempsJeuJ)
                End Using

            End If

        Next

    End Sub

End Module

Public Class Joueurs

    Private nomJ As String
    Private meilleurTempsJ As Integer
    Private nbPartieJ As Integer = 1
    Private tempsJeuJ As Integer = 0
    Private tempsJeuJMIN As Integer = 0
    Private tempsJeuJSEC As Integer = 0

    Sub New(ByVal nom As String, ByVal nbPartie As Integer, ByVal meilleurTemps As Integer, ByVal tempsJeu As Integer)
        nomJ = nom
        nbPartieJ = nbPartie
        meilleurTempsJ = meilleurTemps
        tempsJeuJ += tempsJeu

    End Sub

    Public Function GetnomJ() As String
        Return nomJ
    End Function

    Public Function GetmeilleurTempsJ() As String
        Return meilleurTempsJ
    End Function

    Public Function GetnbPartieJ() As String
        Return nbPartieJ
    End Function

    Public Function GettempsJeuJ() As String
        Return tempsJeuJ
    End Function

    Public Sub AugmenterNbPartie()
        nbPartieJ += 1
    End Sub

    Public Sub SetMeilleurTemps(tps As Integer)
        meilleurTempsJ = tps
    End Sub

    Public Sub AugmenterTempsJeu(tps As Integer)
        tempsJeuJ += tps
    End Sub

    Public Sub SetTempsJeuJMIN(tps As Integer)
        tempsJeuJMIN = tps
    End Sub

    Public Sub SetTempsJeuJSEC(tps As Integer)
        tempsJeuJSEC = tps
    End Sub

    Public Function GettempsJeuJMIN() As String
        Return tempsJeuJMIN
    End Function

    Public Function GettempsJeuJSEC() As String
        Return tempsJeuJSEC
    End Function

End Class