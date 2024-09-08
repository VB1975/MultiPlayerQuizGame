Imports MultiPlayerQuizGame.ClsDataStructures

Public Class FrmQuizSetup

    Private Sub CboSubCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSubCategories.SelectedIndexChanged

        LblSystemMessage.Visible = False
        CboCategories.Items.Clear()

        ' Populate category combo box
        Select Case CboSubCategories.SelectedItem
            Case "IT"
                CboCategories.Items.Add("ASP.NET")
                CboCategories.Items.Add("C#")
                CboCategories.Items.Add("C++")
                CboCategories.Items.Add("JavaScript")
                CboCategories.Items.Add("Microsoft Access")
                CboCategories.Items.Add("Microsoft Access VBA")
                CboCategories.Items.Add("Microsoft Excel")
                CboCategories.Items.Add("Microsoft Excel VBA")
                CboCategories.Items.Add("Microsoft Outlook")
                CboCategories.Items.Add("Microsoft Outlook VBA")
                CboCategories.Items.Add("Microsoft PowerPoint")
                CboCategories.Items.Add("Microsoft PowerPoint VBA")
                CboCategories.Items.Add("Microsoft Word")
                CboCategories.Items.Add("Microsoft Word VBA")
                CboCategories.Items.Add("Python")
                CboCategories.Items.Add("VB.NET")
            Case "Film & Television"
                CboCategories.Items.Add("Buffy The Vampire Slayer")
                CboCategories.Items.Add("Angel")
                CboCategories.Items.Add("Star Trek")
                CboCategories.Items.Add("Power Rangers")
                CboCategories.Items.Add("American Pie")
        End Select

        CboCategories.DroppedDown = True

    End Sub

    Private Sub SetCategoryImage()

        ' Set category images
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
            Case "Microsoft Access VBA" : CategoryImage = My.Resources.MicrosoftAccessVBA
            Case "Microsoft Excel VBA" : CategoryImage = My.Resources.MicrosoftExcelVBA
            Case "Microsoft Word VBA" : CategoryImage = My.Resources.MicrosoftWordVBA
            Case "Microsoft PowerPoint VBA" : CategoryImage = My.Resources.MicrosoftPowerPointVBA
            Case "Microsoft Outlook" : CategoryImage = My.Resources.MicrosoftOutlook
            Case "Microsoft Outlook VBA" : CategoryImage = My.Resources.MicrosoftOutlookVBA
            Case "Python" : CategoryImage = My.Resources.Python
            Case "Buffy The Vampire Slayer" : CategoryImage = My.Resources.BuffyTheVampireSlayer
            Case "Star Trek" : CategoryImage = My.Resources.StarTrek
            Case "Angel" : CategoryImage = My.Resources.Angel
            Case "Power Rangers" : CategoryImage = My.Resources.PowerRangers
            Case "American Pie" : CategoryImage = My.Resources.AmericanPie
        End Select

    End Sub

    Private Sub CboCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategories.SelectedIndexChanged

        If CboCategories.SelectedIndex >= 0 Then Category = CboCategories.SelectedItem.ToString()

        LblSystemMessage.Visible = False
        TxtPlayerName.Focus()

    End Sub

    Private Sub EnableControls()

        If LstPlayers.Items.Count < 8 Then
            LblPlayerName.Enabled = True
            TxtPlayerName.Enabled = True
            BtnAddPlayer.Enabled = True
        Else
            LblPlayerName.Enabled = False
            TxtPlayerName.Enabled = False
            BtnAddPlayer.Enabled = False
        End If

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
        SetCategoryImage()
        frm.Show()
        Hide()

    End Sub

    Private Sub BtnAddPlayer_Click(sender As Object, e As EventArgs) Handles BtnAddPlayer.Click

        LblSystemMessage.Visible = False

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
        EnableControls()

    End Sub

    Private Sub BtnRemovePlayer_Click(sender As Object, e As EventArgs) Handles BtnRemovePlayer.Click

        If LstPlayers.Items.Count > 0 Then
            If LstPlayers.SelectedIndex >= 0 Then
                Players.RemoveAt(LstPlayers.SelectedIndex)
                LstPlayers.Items.RemoveAt(LstPlayers.SelectedIndex)
                EnableControls()
            End If
        End If

    End Sub

    Private Sub InitializeQuestions()

        ' IT Questions
        MicrosoftAccessQuestions() : MicrosoftExcelQuestions() : MicrosoftWordQuestions() : MicrosoftPowerPointQuestions() : MicrosoftOutlookQuestions()
        MicrosoftAccessVBAQuestions() : MicrosoftExcelVBAQuestions() : MicrosoftWordVBAQuestions() : MicrosoftPowerPointVBAQuestions() : MicrosoftOutlookVBAQuestions()
        VBDotNetQuestions() : CSharpQuestions() : CPlusPlusQuestions() : JavaScriptQuestions() : ASPDotNetQuestions() : PythonQuestions()

        ' Film & Television Questions
        BuffyTheVampireSlayerQuestions() : StarTrekQuestions() : AngelQuestions() : PowerRangersQuestions() : AmericanPieQuestions()

    End Sub

    Private Sub FrmQuizSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeQuestions()
        EnableControls()

    End Sub

    Private Sub LstPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstPlayers.SelectedIndexChanged

        EnableControls()

    End Sub
End Class