Imports MultiPlayerQuizGame.ClsDataStructures

Public Class FrmQuiz

    Public CurrentPlayerIndex As Integer = 0

    Private Sub FrmQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayNextQuestion()
        UpdateScore()

        CurrentPlayerIndex = 0
        LblCategory.Text = "Category: " & Category
        If Not IsNothing(CategoryImage) Then PicCategoryImage.Image = CategoryImage
        BtnNextPlayer.Enabled = False
        BtnSubmit.Enabled = True

    End Sub

    Private Sub UpdateScore()

        Dim objListItem As ListViewItem

        lvwPlayerScores.Items.Clear()

        For Each player In Players
            objListItem = lvwPlayerScores.Items.Add(player.Name)
            objListItem.SubItems.Add(player.Score)
        Next

        LblCurrentPlayer.Text = "Current Player: " & Players(CurrentPlayerIndex).Name & Environment.NewLine & "Correct Answers: " &
            Players(CurrentPlayerIndex).CorrectAnswers & " - Incorrect Answers: " & Players(CurrentPlayerIndex).IncorrectAnswers

    End Sub

    Private Sub DisplayNextQuestion()

        Dim SelectedCategory = Category
        Dim AvailableQuestions = Questions.Where(Function(q) q.Category = SelectedCategory).ToList()

        If AvailableQuestions.Count > 0 Then
            Dim CurrentQuestion = AvailableQuestions(New Random().Next(AvailableQuestions.Count))
            LblQuestion.Text = CurrentQuestion.Text
            OptOption1.Text = CurrentQuestion.Options(0)
            OptOption2.Text = CurrentQuestion.Options(1)
            OptOption3.Text = CurrentQuestion.Options(2)
            OptOption4.Text = CurrentQuestion.Options(3)
        Else
            MessageBox.Show("No questions available for this category")
        End If

        For Each Ctrl As Control In Controls
            If TypeOf Ctrl Is RadioButton Then
                DirectCast(Ctrl, RadioButton).Checked = False
                DirectCast(Ctrl, RadioButton).Enabled = True
            End If
        Next

        LblSystemMessage.Text = ""

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim SelectedCategory = Category
        Dim CurrentQuestion = Questions.FirstOrDefault(Function(q) q.Text = LblQuestion.Text And q.Category = SelectedCategory)

        If CurrentQuestion IsNot Nothing Then
            Dim SelectedAnswer As Integer = GetSelectedAnswer()
            If SelectedAnswer = -1 Then
                LblSystemMessage.Text = "Select An Answer"
                Exit Sub
            End If
            For Each Ctrl As Control In Controls
                If TypeOf Ctrl Is RadioButton Then DirectCast(Ctrl, RadioButton).Enabled = False
            Next
            If SelectedAnswer = CurrentQuestion.CorrectAnswer Then
                Players(CurrentPlayerIndex).Score += 10
                Players(CurrentPlayerIndex).CorrectAnswers += 1
                LblSystemMessage.Text = "Correct!"
                UpdateScore()
            Else
                Players(CurrentPlayerIndex).IncorrectAnswers += 1
                UpdateScore()
                If NumPlayers > 1 Then
                    ApplyForfeit()
                Else
                    LblSystemMessage.Text = "Incorrect!"
                End If
            End If
        End If

        BtnNextPlayer.Enabled = True
        BtnSubmit.Enabled = False

    End Sub

    Private Function GetSelectedAnswer() As Integer

        If OptOption1.Checked Then Return 0
        If OptOption2.Checked Then Return 1
        If OptOption3.Checked Then Return 2
        If OptOption4.Checked Then Return 3
        Return -1 'no option selected

    End Function

    Private Sub ApplyForfeit()

        Dim Forfeits As New List(Of String) From
            {"Sing the chorus of a song chosen by the group", "Do a funny dance for 30 seconds",
            "Pretend to be a waiter and take fake orders from everyone", "Speak in an accent for the next 10 minutes",
            "Let someone draw on your face with a washable marker", "Do 10 push-ups or sit-ups", "Tell a funny joke or a silly story",
            "Wear socks on your hands for the next round", "Recite a tongue twister 5 times without messing up",
            "Act out a scene from a movie for everyone to guess", "Imitate a celebrity until someone guesses who it is",
            "Walk around the room like a model on a runway", "Pretend to be a human mirror and mimic someone else's actions",
            "Make up a short poem or rap on the spot", "Do an impression of someone in the group",
            "Eat a spoonful of something chosen by the group (within reason)", "Swap an item of clothing with someone for the next round",
            "Hold a plank position for 30 seconds", "Talk in a whisper for the next 5 minutes",
            "Balance a book on your head and walk in a straight line", "Tell the group something embarrassing from your past",
            "Let someone style your hair (without cutting)", "Do your best animal impression for 30 seconds",
            "Compliment everyone in the group", "Take a selfie with a silly face and send it to a friend", "Sing a song chosen by the group",
            "Do 10 jumping jacks", "Talk in an accent for the next 5 minutes", "Share an embarrassing story", "Dance without music for 1 minute",
            "Wear a silly hat for the rest of the game", "Let another player draw on your face (with something washable)",
            "Do a dramatic reading of a random sentence from a book", "Post something funny on social media",
            "Speak only in questions for the next 2 rounds", "Do an impression of a celebrity chosen by the group",
            "Swap seats with another player for the next 3 questions", "Say the alphabet backward", "Hold a funny pose for 1 minute",
            "Pretend to be a statue for 2 minutes", "Do a silly walk around the room", "Say a tongue twister 5 times quickly",
            "Balance a book on your head for 1 minute", "Compliment every player for the next round", "Do an exaggerated slow-motion action scene",
            "Make a paper airplane and see how far it flies", "Act out a famous movie scene without speaking", "Hold your breath for 20 seconds",
            "Recite a nursery rhyme in the most dramatic way possible", "Write your name using your non-dominant hand"}

        Dim RandomForfeit = Forfeits(New Random().Next(Forfeits.Count))
        FrmForfeit.Activate()
        FrmForfeit.LblForfeit.Text = RandomForfeit
        FrmForfeit.ShowDialog()

    End Sub

    Private Sub BtnNextPlayer_Click(sender As Object, e As EventArgs) Handles BtnNextPlayer.Click

        CurrentPlayerIndex = (CurrentPlayerIndex + 1) Mod Players.Count
        BtnNextPlayer.Enabled = False
        BtnSubmit.Enabled = True
        DisplayNextQuestion()
        UpdateScore()

    End Sub

    Private Sub FrmQuiz_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        CategoryImage = Nothing
        FrmQuizSetup.Show()

    End Sub

    Private Sub OptionChanged(sender As Object, e As EventArgs) Handles _
            OptOption1.CheckedChanged, OptOption2.CheckedChanged, OptOption3.CheckedChanged, OptOption4.CheckedChanged

        For Each Ctrl As Control In Controls
            If TypeOf Ctrl Is RadioButton Then
                If DirectCast(Ctrl, RadioButton).Checked = True Then
                    LblSystemMessage.Text = ""
                End If
            End If
        Next

    End Sub
End Class
