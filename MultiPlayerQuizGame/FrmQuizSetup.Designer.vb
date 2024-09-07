<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuizSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuizSetup))
        Me.CboCategories = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnStartQuiz = New System.Windows.Forms.Button()
        Me.LblPlayerName = New System.Windows.Forms.Label()
        Me.TxtPlayerName = New System.Windows.Forms.TextBox()
        Me.BtnAddPlayer = New System.Windows.Forms.Button()
        Me.LstPlayers = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblSystemMessage = New System.Windows.Forms.Label()
        Me.BtnRemovePlayer = New System.Windows.Forms.Button()
        Me.CboSubCategories = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CboCategories
        '
        Me.CboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategories.FormattingEnabled = True
        Me.CboCategories.Location = New System.Drawing.Point(16, 150)
        Me.CboCategories.Name = "CboCategories"
        Me.CboCategories.Size = New System.Drawing.Size(378, 32)
        Me.CboCategories.Sorted = True
        Me.CboCategories.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category"
        '
        'BtnStartQuiz
        '
        Me.BtnStartQuiz.ForeColor = System.Drawing.Color.Green
        Me.BtnStartQuiz.Location = New System.Drawing.Point(400, 461)
        Me.BtnStartQuiz.Name = "BtnStartQuiz"
        Me.BtnStartQuiz.Size = New System.Drawing.Size(125, 76)
        Me.BtnStartQuiz.TabIndex = 4
        Me.BtnStartQuiz.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quiz"
        Me.BtnStartQuiz.UseVisualStyleBackColor = True
        '
        'LblPlayerName
        '
        Me.LblPlayerName.AutoSize = True
        Me.LblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerName.Location = New System.Drawing.Point(12, 202)
        Me.LblPlayerName.Name = "LblPlayerName"
        Me.LblPlayerName.Size = New System.Drawing.Size(129, 24)
        Me.LblPlayerName.TabIndex = 5
        Me.LblPlayerName.Text = "Player Name"
        '
        'TxtPlayerName
        '
        Me.TxtPlayerName.Location = New System.Drawing.Point(16, 229)
        Me.TxtPlayerName.Name = "TxtPlayerName"
        Me.TxtPlayerName.Size = New System.Drawing.Size(378, 29)
        Me.TxtPlayerName.TabIndex = 6
        '
        'BtnAddPlayer
        '
        Me.BtnAddPlayer.Location = New System.Drawing.Point(400, 225)
        Me.BtnAddPlayer.Name = "BtnAddPlayer"
        Me.BtnAddPlayer.Size = New System.Drawing.Size(125, 38)
        Me.BtnAddPlayer.TabIndex = 7
        Me.BtnAddPlayer.Text = "Add Player"
        Me.BtnAddPlayer.UseVisualStyleBackColor = True
        '
        'LstPlayers
        '
        Me.LstPlayers.FormattingEnabled = True
        Me.LstPlayers.ItemHeight = 24
        Me.LstPlayers.Location = New System.Drawing.Point(16, 341)
        Me.LstPlayers.Name = "LstPlayers"
        Me.LstPlayers.Size = New System.Drawing.Size(378, 196)
        Me.LstPlayers.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Players"
        '
        'LblSystemMessage
        '
        Me.LblSystemMessage.AutoSize = True
        Me.LblSystemMessage.ForeColor = System.Drawing.Color.Maroon
        Me.LblSystemMessage.Location = New System.Drawing.Point(12, 9)
        Me.LblSystemMessage.Name = "LblSystemMessage"
        Me.LblSystemMessage.Size = New System.Drawing.Size(153, 24)
        Me.LblSystemMessage.TabIndex = 10
        Me.LblSystemMessage.Text = "System Message"
        Me.LblSystemMessage.Visible = False
        '
        'BtnRemovePlayer
        '
        Me.BtnRemovePlayer.ForeColor = System.Drawing.Color.Maroon
        Me.BtnRemovePlayer.Location = New System.Drawing.Point(400, 341)
        Me.BtnRemovePlayer.Name = "BtnRemovePlayer"
        Me.BtnRemovePlayer.Size = New System.Drawing.Size(125, 76)
        Me.BtnRemovePlayer.TabIndex = 11
        Me.BtnRemovePlayer.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Player"
        Me.BtnRemovePlayer.UseVisualStyleBackColor = True
        '
        'CboSubCategories
        '
        Me.CboSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSubCategories.FormattingEnabled = True
        Me.CboSubCategories.Items.AddRange(New Object() {"Film & Television", "IT"})
        Me.CboSubCategories.Location = New System.Drawing.Point(16, 77)
        Me.CboSubCategories.Name = "CboSubCategories"
        Me.CboSubCategories.Size = New System.Drawing.Size(378, 32)
        Me.CboSubCategories.Sorted = True
        Me.CboSubCategories.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Sub-Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(87, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "(Max . 8)"
        '
        'FrmQuizSetup
        '
        Me.AcceptButton = Me.BtnAddPlayer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 558)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboSubCategories)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRemovePlayer)
        Me.Controls.Add(Me.LblSystemMessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstPlayers)
        Me.Controls.Add(Me.BtnAddPlayer)
        Me.Controls.Add(Me.TxtPlayerName)
        Me.Controls.Add(Me.LblPlayerName)
        Me.Controls.Add(Me.BtnStartQuiz)
        Me.Controls.Add(Me.CboCategories)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "FrmQuizSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboCategories As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStartQuiz As Button
    Friend WithEvents LblPlayerName As Label
    Friend WithEvents TxtPlayerName As TextBox
    Friend WithEvents BtnAddPlayer As Button
    Friend WithEvents LstPlayers As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblSystemMessage As Label
    Friend WithEvents BtnRemovePlayer As Button
    Friend WithEvents CboSubCategories As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
