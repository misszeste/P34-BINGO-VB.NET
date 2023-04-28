Imports System
Public Class form1
    Public carteDeBingoB(4) As Integer
    Public carteDeBingoI(4) As Integer
    Public carteDeBingoN(4) As Integer
    Public carteDeBingoG(4) As Integer
    Public carteDeBingoO(4) As Integer
    Public LblCarteDeBingoB(4) As Label
    Public LblCarteDeBingoI(4) As Label
    Public LblCarteDeBingoN(4) As Label
    Public LblCarteDeBingoG(4) As Label
    Public LblCarteDeBingoO(4) As Label
    Public ValiderCarteDeBingoB(4) As Boolean
    Public ValiderCarteDeBingoI(4) As Boolean
    Public ValiderCarteDeBingoN(4) As Boolean
    Public ValiderCarteDeBingoG(4) As Boolean
    Public ValiderCarteDeBingoO(4) As Boolean

    Public compteurBoule As Integer
    Public lblLabel(75) As Label
    Public tirage(75) As Integer
    Public bingo As Boolean
    Public compteurBingo As Integer
    Dim reponseJoueur As String
    Public table(20) As TableLayoutPanel
    Public nbJoueur As Integer
    Public carteDeBingoJoueurB(20, 4) As Integer
    Public carteDeBingoJoueurI(20, 4) As Integer
    Public carteDeBingoJoueurN(20, 4) As Integer
    Public carteDeBingoJoueurG(20, 4) As Integer
    Public carteDeBingoJoueurO(20, 4) As Integer
    Public ValiderCarteBingoJoueurB(20, 4) As Boolean
    Public ValiderCarteBingoJoueurI(20, 4) As Boolean
    Public ValiderCarteBingoJoueurN(20, 4) As Boolean
    Public ValiderCarteBingoJoueurG(20, 4) As Boolean
    Public ValiderCarteBingoJoueurO(20, 4) As Boolean






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenue sur mon application Bingo!") 'affiche msg avant d'ouvrir l'app'

        Dim reponseNom As String

        Dim valide As Boolean

        Do
            reponseNom = InputBox(" Quel est votre nom de joueur?")
            If String.ReferenceEquals(reponseNom, String.Empty) Then 'validation btn cancel 
                MsgBox("Écrivez un nom!", vbOK)
            Else
                lblPrenon.Text = "Bonjour " & reponseNom
            End If
        Loop While reponseNom = Nothing

        Do
            reponseJoueur = InputBox("Entrez le nombre de joueur ( Entre 4 et 20 )")
            valide = False
            If IsNumeric(reponseJoueur) = False Then
                MsgBox("Entrez le nombre de joueur")
            Else
                If reponseJoueur < 4 Or reponseJoueur > 20 Then
                    MsgBox("Entre un nombre en 4 et 20 ")
                Else
                    NumericUpDownJoueur.Text = reponseJoueur
                    valide = True
                End If
            End If

        Loop While valide = False

        Dim i As Integer = 1
        Dim lettre = {"B", "I", "N", "G", "O"}

        Me.Boulier.RowCount = 15
        Me.Boulier.ColumnCount = 5
        Me.Boulier.SuspendLayout()
        For column = 0 To Me.Boulier.ColumnCount - 1
            For row = 0 To Me.Boulier.RowCount - 1
                Dim olable As New Label
                olable.Text = i
                olable.TextAlign = 2

                lblLabel(i) = olable
                i = i + 1
                Me.Boulier.Controls.Add(olable, column, row)
            Next row
        Next column
        Me.Boulier.ResumeLayout()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GenererBoule()
        If compteurBoule = 75 And bingo = True Then
            Timer1.Enabled = False
            btnJouer.Enabled = True
        End If
    End Sub

    Public Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        'validation des RDB
        Dim choix As Boolean
        choix = False
        NumericUpDownJoueur.Enabled = False

        If RdbNormal.Checked = True Then
            choix = True
        End If

        If Rdb4Coins.Checked = True Then
            choix = True
        End If

        If RdbPleine.Checked = True Then
            choix = True
        End If

        If choix = False Then
            MsgBox(" Fait un choix de mode de jeux !!")
        Else

            Dim y As Integer = 560

            For nbJoueur = 0 To (Convert.ToInt32(reponseJoueur) - 1)
                Dim Label As New Label
                Label.Visible = True
                Label.Text = "Joueur " + (nbJoueur + 2).ToString()
                Label.Size = New System.Drawing.Size(150, 40)
                Me.GroupBoxBingo.Controls.Add(Label)
                'instancier une nouvel tablelayoutPanel
                table(nbJoueur) = New TableLayoutPanel
                Me.GroupBoxBingo.Controls.Add(table(nbJoueur))
                table(nbJoueur).Visible = True
                table(nbJoueur).RowCount = 5
                table(nbJoueur).ColumnCount = 5
                table(nbJoueur).BorderStyle = 1
                table(nbJoueur).Size = New System.Drawing.Size(318, 236)
                table(nbJoueur).BackColor = System.Drawing.Color.DarkSlateBlue
                table(nbJoueur).BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
                table(nbJoueur).CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
                table(nbJoueur).ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).RowStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).RowStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).RowStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).RowStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).RowStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
                table(nbJoueur).Location = New System.Drawing.Point(895, y)
                Label.Location = New System.Drawing.Point(1000, y - 40)
                y = y + 270

                'Appeler la fonction qui gene les cartes (numéros)
                CreerCarteBingo()

            Next



            RdbNormal.Enabled = False
            Rdb4Coins.Enabled = False
            RdbPleine.Enabled = False
            'Initialiser le random-number generator.
            Randomize()
            ReDim carteDeBingoB(4)
            ReDim carteDeBingoI(4)
            ReDim carteDeBingoN(4)
            ReDim carteDeBingoG(4)
            ReDim carteDeBingoO(4)
            Dim compteurBoule As Integer

            For i As Integer = 0 To 4
                Dim value As Integer
                Dim trouve As Boolean
                Do
                    trouve = True
                    ' Generer random timerBoule between 1 and 15
                    value = Int(Int((15 * Rnd()) + 1))
                    For x As Integer = 0 To 4
                        If carteDeBingoB(x) = value Then
                            trouve = False 'numero existant dans la combinaison
                        End If
                    Next
                Loop While trouve = False

                carteDeBingoB(i) = value
                LabelB1.Text = carteDeBingoB(0)
                LabelB2.Text = carteDeBingoB(1)
                LabelB3.Text = carteDeBingoB(2)
                LabelB4.Text = carteDeBingoB(3)
                LabelB5.Text = carteDeBingoB(4)
                LblCarteDeBingoB = {LabelB1, LabelB2, LabelB3, LabelB4, LabelB5}

                Do
                    trouve = True
                    ' Generer random timerBoule between 16 and 30
                    value = Int(Int((15 * Rnd()) + 16))
                    For x As Integer = 0 To 4
                        If carteDeBingoI(x) = value Then
                            trouve = False 'numero existant dans la combinaison
                        End If
                    Next
                Loop While trouve = False
                carteDeBingoI(i) = value
                LabelI1.Text = carteDeBingoI(0)
                LabelI2.Text = carteDeBingoI(1)
                LabelI3.Text = carteDeBingoI(2)
                LabelI4.Text = carteDeBingoI(3)
                LabelI5.Text = carteDeBingoI(4)
                LblCarteDeBingoI = {LabelI1, LabelI2, LabelI3, LabelI4, LabelI5}

                Do
                    trouve = True
                    ' Generer random timerBoule between 31 and 45
                    value = Int(Int((15 * Rnd()) + 31))
                    For x As Integer = 0 To 4
                        If carteDeBingoN(x) = value Then
                            trouve = False 'numero existant dans la combinaison
                        End If
                    Next
                Loop While trouve = False

                carteDeBingoN(i) = value
                LabelN1.Text = carteDeBingoN(0)
                LabelN2.Text = carteDeBingoN(1)
                LabelN3.Text = carteDeBingoN(2)
                LabelN4.Text = carteDeBingoN(3)
                LabelN5.Text = carteDeBingoN(4)
                LblCarteDeBingoN = {LabelN1, LabelN2, LabelN3, LabelN4, LabelN5}

                Do
                    trouve = True
                    ' Generer random timerBoule between 46 and 60
                    value = Int(Int((15 * Rnd()) + 46))
                    For x As Integer = 0 To 4
                        If carteDeBingoG(x) = value Then
                            trouve = False 'numero existant dans la combinaison
                        End If
                    Next
                Loop While trouve = False

                carteDeBingoG(i) = value
                LabelG1.Text = carteDeBingoG(0)
                LabelG2.Text = carteDeBingoG(1)
                LabelG3.Text = carteDeBingoG(2)
                LabelG4.Text = carteDeBingoG(3)
                LabelG5.Text = carteDeBingoG(4)
                LblCarteDeBingoG = {LabelG1, LabelG2, LabelG3, LabelG4, LabelG5}

                Do
                    trouve = True
                    ' Generer random timerBoule between 61 and 75
                    value = Int(Int((15 * Rnd()) + 61))
                    For x As Integer = 0 To 4
                        If carteDeBingoO(x) = value Then
                            trouve = False 'numero existant dans la combinaison
                        End If
                    Next
                Loop While trouve = False

                carteDeBingoO(i) = value
                LabelO1.Text = carteDeBingoO(0)
                LabelO2.Text = carteDeBingoO(1)
                LabelO3.Text = carteDeBingoO(2)
                LabelO4.Text = carteDeBingoO(3)
                LabelO5.Text = carteDeBingoO(4)
                LblCarteDeBingoO = {LabelO1, LabelO2, LabelO3, LabelO4, LabelO5}
            Next

            ' reset couleur boulier
            For x = 1 To 75
                lblLabel(x).BackColor = Nothing
            Next

            'reset couleur carte
            For x = 0 To 4
                LblCarteDeBingoB(x).BackColor = Nothing
                LblCarteDeBingoI(x).BackColor = Nothing
                LblCarteDeBingoN(x).BackColor = Nothing
                LblCarteDeBingoG(x).BackColor = Nothing
                LblCarteDeBingoO(x).BackColor = Nothing
                ValiderCarteDeBingoB(x) = False
                ValiderCarteDeBingoI(x) = False
                ValiderCarteDeBingoN(x) = False
                ValiderCarteDeBingoG(x) = False
                ValiderCarteDeBingoO(x) = False

            Next
            compteurBoule = 0
            bingo = False
            Timer1.Enabled = True
            btnJouer.Enabled = False
        End If
    End Sub

    Public Sub CreerCarteBingo()
        Randomize()
        ReDim carteDeBingoB(4)
        ReDim carteDeBingoI(4)
        ReDim carteDeBingoN(4)
        ReDim carteDeBingoG(4)
        ReDim carteDeBingoO(4)
        Dim compteurBoule As Integer

        For i As Integer = 0 To 4
            Dim value As Integer
            Dim trouve As Boolean
            Do
                trouve = True
                ' Generer random timerBoule between 1 and 15
                value = Int(Int((15 * Rnd()) + 1))
                For x As Integer = 0 To 4
                    If carteDeBingoB(x) = value Then
                        trouve = False 'numero existant dans la combinaison
                    End If
                Next
            Loop While trouve = False
            carteDeBingoB(i) = value
            Dim labeltextb As New Label
            labeltextb.Height = 42
            labeltextb.TextAlign = 2
            labeltextb.Text = carteDeBingoB(i)
            carteDeBingoJoueurB(nbJoueur, i) = carteDeBingoB(i)
            labeltextb.Visible = True
            table(nbJoueur).Controls.Add(labeltextb, 0, i)


            Do
                trouve = True
                ' Generer random timerBoule between 16 and 30
                value = Int(Int((15 * Rnd()) + 16))
                For x As Integer = 0 To 4
                    If carteDeBingoI(x) = value Then
                        trouve = False 'numero existant dans la combinaison
                    End If
                Next
            Loop While trouve = False
            carteDeBingoI(i) = value
            Dim labeltexti As New Label
            labeltexti.Height = 42
            labeltexti.TextAlign = 2
            labeltexti.Text = carteDeBingoI(i)
            carteDeBingoJoueurI(nbJoueur, i) = carteDeBingoI(i)
            labeltexti.Visible = True
            table(nbJoueur).Controls.Add(labeltexti, 1, i)

            Do
                trouve = True
                ' Generer random timerBoule between 31 and 45
                value = Int(Int((15 * Rnd()) + 31))
                For x As Integer = 0 To 4
                    If carteDeBingoN(x) = value Then
                        trouve = False 'numero existant dans la combinaison
                    End If
                Next
            Loop While trouve = False
            carteDeBingoN(i) = value
            Dim labeltextn As New Label
            labeltextn.Height = 42
            labeltextn.TextAlign = 2
            labeltextn.Text = carteDeBingoN(i)
            carteDeBingoJoueurN(nbJoueur, i) = carteDeBingoN(i)
            labeltextn.Visible = True
            table(nbJoueur).Controls.Add(labeltextn, 2, i)

            Do
                trouve = True
                ' Generer random timerBoule between 46 and 60
                value = Int(Int((15 * Rnd()) + 46))
                For x As Integer = 0 To 4
                    If carteDeBingoG(x) = value Then
                        trouve = False 'numero existant dans la combinaison
                    End If
                Next
            Loop While trouve = False
            carteDeBingoG(i) = value
            Dim labeltextg As New Label
            labeltextg.Height = 42
            labeltextg.TextAlign = 2
            labeltextg.Text = carteDeBingoG(i)
            carteDeBingoJoueurG(nbJoueur, i) = carteDeBingoG(i)
            labeltextg.Visible = True
            table(nbJoueur).Controls.Add(labeltextg, 3, i)
            Do
                trouve = True
                ' Generer random timerBoule between 61 and 75
                value = Int(Int((15 * Rnd()) + 61))
                For x As Integer = 0 To 4
                    If carteDeBingoO(x) = value Then
                        trouve = False 'numero existant dans la combinaison
                    End If
                Next
            Loop While trouve = False
            carteDeBingoO(i) = value
            Dim labeltexto As New Label
            labeltexto.Height = 42
            labeltexto.TextAlign = 2
            labeltexto.Text = carteDeBingoO(i)
            carteDeBingoJoueurO(nbJoueur, i) = carteDeBingoO(i)
            labeltexto.Visible = True
            table(nbJoueur).Controls.Add(labeltexto, 4, i)
        Next

        'reset couleur carte
        For x = 0 To 4

            ValiderCarteDeBingoB(x) = False
            ValiderCarteDeBingoI(x) = False
            ValiderCarteDeBingoN(x) = False
            ValiderCarteDeBingoG(x) = False
            ValiderCarteDeBingoO(x) = False

        Next
        compteurBoule = 0
        bingo = False
        Timer1.Enabled = True
        btnJouer.Enabled = False


    End Sub

    Private Sub ChangerTirer(tirageNbr)
        For j = 0 To nbJoueur - 1
            Select Case tirageNbr 'valider si nbr est present sur la carte du joueur
                Case Is < 16
                    For i = 0 To 4

                        If carteDeBingoJoueurB(j, i) = tirageNbr Then
                            table(j).GetControlFromPosition(i, 0).BackColor = Color.DarkTurquoise
                            ValiderCarteBingoJoueurB(j, i) = True
                        End If
                    Next

                Case 15 To 30
                    For i = 0 To 4
                        If carteDeBingoJoueurI(j, i) = tirageNbr Then
                            table(j).GetControlFromPosition(i, 1).BackColor = Color.DarkTurquoise
                            ValiderCarteBingoJoueurI(j, i) = True
                        End If
                    Next

                Case 31 To 45
                    For i = 0 To 4
                        If carteDeBingoJoueurN(j, i) = tirageNbr Then
                            table(j).GetControlFromPosition(i, 2).BackColor = Color.DarkTurquoise
                            ValiderCarteBingoJoueurN(j, i) = True
                        End If
                    Next

                Case 46 To 60
                    For i = 0 To 4
                        If carteDeBingoJoueurG(j, i) = tirageNbr Then
                            table(j).GetControlFromPosition(i, 3).BackColor = Color.DarkTurquoise
                            ValiderCarteBingoJoueurG(j, i) = True
                        End If
                    Next

                Case 61 To 75
                    For i = 0 To 4
                        If carteDeBingoJoueurO(j, i) = tirageNbr Then
                            table(j).GetControlFromPosition(i, 4).BackColor = Color.DarkTurquoise
                            ValiderCarteBingoJoueurO(j, i) = True
                        End If
                    Next
            End Select
        Next
    End Sub

    Private Sub ValiderCarteGagnante()
        'Valide si on gagne donc bingo = true
        For j = 1 To nbJoueur
            ' carte Normal
            If RdbNormal.Checked = True Then

                Dim compteurTrouveV(4)
                Dim compteurTrouveH(4)
                Dim gagner As Boolean = False

                'ligne verticale
                For x = 0 To 4
                    If ValiderCarteBingoJoueurB(j, x) = True Then
                        compteurTrouveV(0) = compteurTrouveV(0) + 1
                    End If
                Next

                For x = 0 To 4
                    If ValiderCarteBingoJoueurI(j, x) = True Then
                        compteurTrouveV(1) = compteurTrouveV(1) + 1
                    End If
                Next

                For x = 0 To 4
                    If ValiderCarteBingoJoueurN(j, x) = True Then
                        compteurTrouveV(2) = compteurTrouveV(2) + 1
                    End If
                Next

                For X = 0 To 4
                    If ValiderCarteBingoJoueurG(j, X) = True Then
                        compteurTrouveV(3) = compteurTrouveV(3) + 1
                    End If
                Next

                For x = 0 To 4
                    If ValiderCarteBingoJoueurO(j, x) = True Then
                        compteurTrouveV(4) = compteurTrouveV(4) + 1
                    End If
                Next



                'ligne horizontale
                For x = 0 To 4
                    If ValiderCarteBingoJoueurB(j, x) = True And ValiderCarteBingoJoueurI(j, x) = True And ValiderCarteBingoJoueurN(j, x) = True And ValiderCarteBingoJoueurG(j, x) = True And ValiderCarteBingoJoueurO(j, x) = True Then
                        compteurTrouveH(0) = 5
                    End If
                Next

                For i = 0 To 4
                    If compteurTrouveH(i) = 5 Or compteurTrouveV(i) = 5 Then
                        gagner = True
                    End If
                Next



                ' ligne diagonale
                If ValiderCarteBingoJoueurB(j, 0) = True And ValiderCarteBingoJoueurI(j, 1) = True And ValiderCarteBingoJoueurN(j, 2) = True And ValiderCarteBingoJoueurG(j, 3) = True And ValiderCarteBingoJoueurO(j, 4) = True Then
                    gagner = True
                End If

                If ValiderCarteBingoJoueurB(j, 4) = True And ValiderCarteBingoJoueurI(j, 3) = True And ValiderCarteBingoJoueurN(j, 2) = True And ValiderCarteBingoJoueurG(j, 1) = True And ValiderCarteBingoJoueurO(j, 0) = True Then
                    gagner = True
                End If

                If gagner = True Then
                    ResetRdb(" BINGO!!! ")
                End If
            End If

            'carte pleine
            If RdbPleine.Checked = True Then
                Dim trouve As Boolean
                trouve = False
                For x = 0 To 4
                    If ValiderCarteBingoJoueurB(j, x) = False Then
                        trouve = True
                    End If

                    If ValiderCarteBingoJoueurI(j, x) = False Then
                        trouve = True
                    End If

                    If ValiderCarteBingoJoueurN(j, x) = False Then
                        trouve = True
                    End If

                    If ValiderCarteBingoJoueurG(j, x) = False Then
                        trouve = True
                    End If

                    If ValiderCarteBingoJoueurO(j, x) = False Then
                        trouve = True
                    End If
                Next

                If trouve = False Then
                    ResetRdb(" BINGO !!! Carte Pleine !")
                End If
            End If



            ' 4 coins 
            If Rdb4Coins.Checked = True Then
                If ValiderCarteBingoJoueurB(j, 0) = True And ValiderCarteBingoJoueurB(j, 4) = True And ValiderCarteBingoJoueurO(j, 0) = True And ValiderCarteBingoJoueurO(j, 4) = True Then
                    ResetRdb(" BINGO !!! 4 COINS ! ")
                End If
            End If
        Next
    End Sub

    Private Sub GenererBoule()
        'tirage boulier
        Array.Clear(tirage)
        For position As Integer = 1 To 75
            tirage(position) = 0
        Next

        Dim trouver As Boolean
        Dim tirageNbr As Integer
        Do
            trouver = True
            ' Generer random timerBoule between 1 and 75
            tirageNbr = Int(Int((75 * Rnd()) + 1))
            For x As Integer = 1 To 75
                If tirage(x) = tirageNbr Then
                    trouver = False 'numero déjà tiré
                End If
            Next
        Loop While trouver = False
        compteurBoule = compteurBoule + 1
        tirage(tirageNbr) = tirageNbr
        lblLabel(tirageNbr).BackColor = Color.DarkTurquoise

        Select Case tirageNbr 'valider si nbr est present sur la carte du joueur
            Case Is < 16
                For i = 0 To 4
                    If carteDeBingoB(i) = tirageNbr Then
                        LblCarteDeBingoB(i).BackColor = Color.DarkTurquoise
                        ValiderCarteDeBingoB(i) = True
                    End If
                Next

            Case 15 To 30
                For i = 0 To 4
                    If carteDeBingoI(i) = tirageNbr Then
                        LblCarteDeBingoI(i).BackColor = Color.DarkTurquoise
                        ValiderCarteDeBingoI(i) = True
                    End If
                Next

            Case 31 To 45
                For i = 0 To 4
                    If carteDeBingoN(i) = tirageNbr Then
                        LblCarteDeBingoN(i).BackColor = Color.DarkTurquoise
                        ValiderCarteDeBingoN(i) = True
                    End If
                Next

            Case 46 To 60
                For i = 0 To 4
                    If carteDeBingoG(i) = tirageNbr Then
                        LblCarteDeBingoG(i).BackColor = Color.DarkTurquoise
                        ValiderCarteDeBingoG(i) = True
                    End If
                Next

            Case 61 To 75
                For i = 0 To 4
                    If carteDeBingoO(i) = tirageNbr Then
                        LblCarteDeBingoO(i).BackColor = Color.DarkTurquoise
                        ValiderCarteDeBingoO(i) = True
                    End If
                Next
        End Select

        ChangerTirer(tirageNbr)


        'Valide si on gagne donc bingo = true

        ' carte Normal
        If RdbNormal.Checked = True Then

            Dim compteurTrouveV(4)
            Dim compteurTrouveH(4)
            Dim gagner As Boolean = False

            'ligne verticale
            For x = 0 To 4
                If ValiderCarteDeBingoB(x) = True Then
                    compteurTrouveV(0) = compteurTrouveV(0) + 1
                End If
            Next

            For x = 0 To 4
                If ValiderCarteDeBingoI(x) = True Then
                    compteurTrouveV(1) = compteurTrouveV(1) + 1
                End If
            Next

            For x = 0 To 4
                If ValiderCarteDeBingoN(x) = True Then
                    compteurTrouveV(2) = compteurTrouveV(2) + 1
                End If
            Next

            For X = 0 To 4
                If ValiderCarteDeBingoG(X) = True Then
                    compteurTrouveV(3) = compteurTrouveV(3) + 1
                End If
            Next

            For x = 0 To 4
                If ValiderCarteDeBingoO(x) = True Then
                    compteurTrouveV(4) = compteurTrouveV(4) + 1
                End If
            Next



            'ligne horizontale
            For x = 0 To 4
                If ValiderCarteDeBingoB(x) = True And ValiderCarteDeBingoI(x) = True And ValiderCarteDeBingoN(x) = True And ValiderCarteDeBingoG(x) = True And ValiderCarteDeBingoO(x) = True Then
                    compteurTrouveH(0) = 5
                End If
            Next

            For i = 0 To 4
                If compteurTrouveH(i) = 5 Or compteurTrouveV(i) = 5 Then
                    gagner = True
                End If
            Next



            ' ligne diagonale
            If ValiderCarteDeBingoB(0) = True And ValiderCarteDeBingoI(1) = True And ValiderCarteDeBingoN(2) = True And ValiderCarteDeBingoG(3) = True And ValiderCarteDeBingoO(4) = True Then
                gagner = True
            End If

            If ValiderCarteDeBingoB(4) = True And ValiderCarteDeBingoI(3) = True And ValiderCarteDeBingoN(2) = True And ValiderCarteDeBingoG(1) = True And ValiderCarteDeBingoO(0) = True Then
                gagner = True
            End If

            If gagner = True Then
                ResetRdb(" BINGO!!! ")
            End If
        End If

        'carte pleine
        If RdbPleine.Checked = True Then
            Dim trouve As Boolean
            trouve = False
            For x = 0 To 4
                If ValiderCarteDeBingoB(x) = False Then
                    trouve = True
                End If

                If ValiderCarteDeBingoI(x) = False Then
                    trouve = True
                End If

                If ValiderCarteDeBingoN(x) = False Then
                    trouve = True
                End If

                If ValiderCarteDeBingoG(x) = False Then
                    trouve = True
                End If

                If ValiderCarteDeBingoO(x) = False Then
                    trouve = True
                End If
            Next

            If trouve = False Then
                ResetRdb(" BINGO !!! Carte Pleine !")
            End If
        End If



        ' 4 coins 
        If Rdb4Coins.Checked = True Then
            If ValiderCarteDeBingoB(0) = True And ValiderCarteDeBingoB(4) = True And ValiderCarteDeBingoO(0) = True And ValiderCarteDeBingoO(4) = True Then
                ResetRdb(" BINGO !!! 4 COINS ! ")
            End If
        End If

        ValiderCarteGagnante()
    End Sub

    Private Sub ResetRdb(message As String)
        Timer1.Enabled = False
        NumericUpDownJoueur.Enabled = True
        btnJouer.Enabled = True
        RdbNormal.Enabled = True
        Rdb4Coins.Enabled = True
        RdbPleine.Enabled = True
        RdbNormal.Checked = False
        Rdb4Coins.Checked = False
        RdbPleine.Checked = False
        MsgBox(message)
    End Sub


    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim reponse As Integer
        reponse = MsgBox("Êtes-vous certain de vouloir quitter?", vbYesNo)

        If reponse = 6 Then
            Application.Exit()
        End If
    End Sub
End Class
