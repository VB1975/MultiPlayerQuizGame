<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuiz))
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.OptOption1 = New System.Windows.Forms.RadioButton()
        Me.OptOption2 = New System.Windows.Forms.RadioButton()
        Me.OptOption3 = New System.Windows.Forms.RadioButton()
        Me.OptOption4 = New System.Windows.Forms.RadioButton()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnNextPlayer = New System.Windows.Forms.Button()
        Me.LblSystemMessage = New System.Windows.Forms.Label()
        Me.lvwPlayerScores = New System.Windows.Forms.ListView()
        Me.ColPlayerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblCurrentPlayer = New System.Windows.Forms.Label()
        Me.PicCategoryImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PicCategoryImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblQuestion
        '
        Me.LblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQuestion.Location = New System.Drawing.Point(12, 142)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(779, 122)
        Me.LblQuestion.TabIndex = 2
        Me.LblQuestion.Text = "Question"
        '
        'OptOption1
        '
        Me.OptOption1.Checked = True
        Me.OptOption1.Location = New System.Drawing.Point(12, 280)
        Me.OptOption1.Name = "OptOption1"
        Me.OptOption1.Size = New System.Drawing.Size(779, 54)
        Me.OptOption1.TabIndex = 5
        Me.OptOption1.TabStop = True
        Me.OptOption1.Text = "RadioButton1"
        Me.OptOption1.UseVisualStyleBackColor = True
        '
        'OptOption2
        '
        Me.OptOption2.Location = New System.Drawing.Point(12, 333)
        Me.OptOption2.Name = "OptOption2"
        Me.OptOption2.Size = New System.Drawing.Size(779, 54)
        Me.OptOption2.TabIndex = 6
        Me.OptOption2.Text = "RadioButton2"
        Me.OptOption2.UseVisualStyleBackColor = True
        '
        'OptOption3
        '
        Me.OptOption3.Location = New System.Drawing.Point(12, 386)
        Me.OptOption3.Name = "OptOption3"
        Me.OptOption3.Size = New System.Drawing.Size(779, 54)
        Me.OptOption3.TabIndex = 7
        Me.OptOption3.Text = "RadioButton3"
        Me.OptOption3.UseVisualStyleBackColor = True
        '
        'OptOption4
        '
        Me.OptOption4.Location = New System.Drawing.Point(12, 439)
        Me.OptOption4.Name = "OptOption4"
        Me.OptOption4.Size = New System.Drawing.Size(779, 54)
        Me.OptOption4.TabIndex = 8
        Me.OptOption4.Text = "RadioButton4"
        Me.OptOption4.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(255, 512)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(154, 50)
        Me.BtnSubmit.TabIndex = 9
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnNextPlayer
        '
        Me.BtnNextPlayer.Location = New System.Drawing.Point(415, 512)
        Me.BtnNextPlayer.Name = "BtnNextPlayer"
        Me.BtnNextPlayer.Size = New System.Drawing.Size(154, 50)
        Me.BtnNextPlayer.TabIndex = 10
        Me.BtnNextPlayer.Text = "Next Player"
        Me.BtnNextPlayer.UseVisualStyleBackColor = True
        '
        'LblSystemMessage
        '
        Me.LblSystemMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSystemMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSystemMessage.ForeColor = System.Drawing.Color.Teal
        Me.LblSystemMessage.Location = New System.Drawing.Point(12, 596)
        Me.LblSystemMessage.Name = "LblSystemMessage"
        Me.LblSystemMessage.Size = New System.Drawing.Size(779, 122)
        Me.LblSystemMessage.TabIndex = 11
        Me.LblSystemMessage.Text = "System Message"
        Me.LblSystemMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvwPlayerScores
        '
        Me.lvwPlayerScores.BackColor = System.Drawing.SystemColors.Control
        Me.lvwPlayerScores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColPlayerName, Me.ColScore})
        Me.lvwPlayerScores.Enabled = False
        Me.lvwPlayerScores.FullRowSelect = True
        Me.lvwPlayerScores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwPlayerScores.HideSelection = False
        Me.lvwPlayerScores.Location = New System.Drawing.Point(813, 197)
        Me.lvwPlayerScores.MultiSelect = False
        Me.lvwPlayerScores.Name = "lvwPlayerScores"
        Me.lvwPlayerScores.Size = New System.Drawing.Size(333, 521)
        Me.lvwPlayerScores.TabIndex = 12
        Me.lvwPlayerScores.UseCompatibleStateImageBehavior = False
        Me.lvwPlayerScores.View = System.Windows.Forms.View.Details
        '
        'ColPlayerName
        '
        Me.ColPlayerName.Text = "Player Name"
        Me.ColPlayerName.Width = 250
        '
        'ColScore
        '
        Me.ColScore.Text = "Score"
        Me.ColScore.Width = 75
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblCategory.Location = New System.Drawing.Point(12, 83)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(164, 37)
        Me.LblCategory.TabIndex = 14
        Me.LblCategory.Text = "Category:"
        '
        'LblCurrentPlayer
        '
        Me.LblCurrentPlayer.AutoSize = True
        Me.LblCurrentPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentPlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblCurrentPlayer.Location = New System.Drawing.Point(12, 9)
        Me.LblCurrentPlayer.Name = "LblCurrentPlayer"
        Me.LblCurrentPlayer.Size = New System.Drawing.Size(651, 74)
        Me.LblCurrentPlayer.TabIndex = 15
        Me.LblCurrentPlayer.Text = "Current Player:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Correct Answers: 0 - Incorrect Answers: 0"
        '
        'PicCategoryImage
        '
        Me.PicCategoryImage.Location = New System.Drawing.Point(813, 12)
        Me.PicCategoryImage.Name = "PicCategoryImage"
        Me.PicCategoryImage.Size = New System.Drawing.Size(333, 120)
        Me.PicCategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCategoryImage.TabIndex = 16
        Me.PicCategoryImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(809, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Scoreboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(808, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(1058, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Score"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 732)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PicCategoryImage)
        Me.Controls.Add(Me.LblCurrentPlayer)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwPlayerScores)
        Me.Controls.Add(Me.LblSystemMessage)
        Me.Controls.Add(Me.BtnNextPlayer)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.OptOption4)
        Me.Controls.Add(Me.OptOption3)
        Me.Controls.Add(Me.OptOption2)
        Me.Controls.Add(Me.OptOption1)
        Me.Controls.Add(Me.LblQuestion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        CType(Me.PicCategoryImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblQuestion As Label
    Friend WithEvents OptOption1 As RadioButton
    Friend WithEvents OptOption2 As RadioButton
    Friend WithEvents OptOption3 As RadioButton
    Friend WithEvents OptOption4 As RadioButton
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnNextPlayer As Button
    Friend WithEvents LblSystemMessage As Label
    Friend WithEvents lvwPlayerScores As ListView
    Friend WithEvents ColPlayerName As ColumnHeader
    Friend WithEvents ColScore As ColumnHeader
    Friend WithEvents LblCategory As Label
    Friend WithEvents LblCurrentPlayer As Label
    Friend WithEvents PicCategoryImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
