Imports MultiPlayerQuizGame.ClsDataStructures

Public Class FrmQuizSetup

    Private Sub CboSubCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSubCategories.SelectedIndexChanged

        LblSystemMessage.Visible = False
        CboCategories.Items.Clear()

        Select Case CboSubCategories.SelectedItem
            Case "IT"
                'CboCategories.Items.Add("ASP.NET")
                CboCategories.Items.Add("C#")
                CboCategories.Items.Add("C++")
                'CboCategories.Items.Add("JavaScript")
                CboCategories.Items.Add("Microsoft Access")
                CboCategories.Items.Add("Microsoft Excel")
                CboCategories.Items.Add("Microsoft PowerPoint")
                CboCategories.Items.Add("Microsoft Word")
                CboCategories.Items.Add("VB.NET")
            Case "Film & Television"
                CboCategories.Items.Add("Buffy The Vampire Slayer")
                'CboCategories.Items.Add("Angel")
                CboCategories.Items.Add("Star Trek")
        End Select

        CboCategories.DroppedDown = True

    End Sub

    Private Sub CboCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategories.SelectedIndexChanged

        If CboCategories.SelectedIndex >= 0 Then Category = CboCategories.SelectedItem.ToString()

        LblSystemMessage.Visible = False
        TxtPlayerName.Focus()

        Select Case Category
            Case "C#" : CategoryImage = My.Resources.CSharp
            Case "C++" : CategoryImage = My.Resources.CPlusPlus
            Case "ASP.NET" : CategoryImage = My.Resources.ASPDotNET
            Case "JavaScript" : CategoryImage = My.Resources.JavaScript
            Case "VB.NET" : CategoryImage = My.Resources.VBDotNet
            Case "Microsoft Access" : CategoryImage = My.Resources.MicrosoftAccess
            Case "Microsoft Excel" : CategoryImage = My.Resources.MicrosoftExcel
            Case "Microsoft Word" : CategoryImage = My.Resources.MicrosoftWord
            Case "Microsoft PowerPoint" : CategoryImage = My.Resources.MicrosoftPowerPoint
            Case "Buffy The Vampire Slayer" : CategoryImage = My.Resources.BuffyTheVampireSlayer
            Case "Star Trek" : CategoryImage = My.Resources.StarTrek
        End Select

    End Sub

    Private Sub EnableButtons()

        If LstPlayers.SelectedIndex >= 0 Then
            BtnRemovePlayer.Enabled = True
        Else
            BtnRemovePlayer.Enabled = False
        End If

    End Sub

    Private Sub BtnStartQuiz_Click(sender As Object, e As EventArgs) Handles BtnStartQuiz.Click

        Dim frm As New FrmQuiz

        LblSystemMessage.Visible = False

        If CboSubCategories.SelectedIndex < 0 Then
            LblSystemMessage.Text = "Select a Sub-Category"
            CboSubCategories.DroppedDown = True
            LblSystemMessage.Visible = True
            Exit Sub
        End If

        If CboCategories.SelectedIndex < 0 Then
            LblSystemMessage.Text = "Select a Category"
            CboCategories.DroppedDown = True
            LblSystemMessage.Visible = True
            Exit Sub
        End If

        If LstPlayers.Items.Count = 0 Then
            LblSystemMessage.Text = "At least one player is needed to play"
            TxtPlayerName.Focus()
            LblSystemMessage.Visible = True
            Exit Sub
        End If

        NumPlayers = LstPlayers.Items.Count

        frm.Activate()
        If NumPlayers = 1 Then
            frm.BtnNextPlayer.Text = "Next Question"
        Else
            frm.BtnNextPlayer.Text = "Next player"
        End If
        Dim AvailableQuestions = Questions.Where(Function(q) q.Category = Category).ToList()
        If AvailableQuestions.Count = 0 Then
            MessageBox.Show("No questions available for this category")
            Exit Sub
        End If
        frm.Show()
        Hide()

    End Sub

    Private Sub BtnAddPlayer_Click(sender As Object, e As EventArgs) Handles BtnAddPlayer.Click

        LblSystemMessage.Visible = False

        If LstPlayers.Items.Count = 8 Then
            LblSystemMessage.Text = "Maximum of 8 players only"
            BtnStartQuiz.Focus()
            LblSystemMessage.Visible = True
            Exit Sub
        End If

        If TxtPlayerName.Text = "" Then
            LblSystemMessage.Text = "Enter a Player Name"
            TxtPlayerName.Focus()
            LblSystemMessage.Visible = True
            Exit Sub
        End If

        Players.Add(New Player With {.Name = TxtPlayerName.Text, .Score = 0})
        LstPlayers.Items.Add(TxtPlayerName.Text)

        TxtPlayerName.Clear()
        TxtPlayerName.Focus()

    End Sub

    Private Sub BtnRemovePlayer_Click(sender As Object, e As EventArgs) Handles BtnRemovePlayer.Click

        If LstPlayers.Items.Count > 0 Then
            If LstPlayers.SelectedIndex >= 0 Then
                Players.RemoveAt(LstPlayers.SelectedIndex)
                LstPlayers.Items.RemoveAt(LstPlayers.SelectedIndex)
            End If
        End If

    End Sub

    Private Sub InitializeQuestions()

        MicrosoftAccessQuestions() : MicrosoftExcelQuestions() : MicrosoftWordQuestions() : MicrosoftPowerPointQuestions()
        VBDotNetQuestions() : CSharpQuestions() : CPlusPlusQuestions()

        BuffyTheVampireSlayerQuestions() : StarTrekQuestions()

    End Sub

    Private Sub FrmQuizSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeQuestions()
        EnableButtons()

    End Sub

    Private Sub LstPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstPlayers.SelectedIndexChanged

        EnableButtons()

    End Sub

    Private Sub FilterCategories()

    End Sub
End Class