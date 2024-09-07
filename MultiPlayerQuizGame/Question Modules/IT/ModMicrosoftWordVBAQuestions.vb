Imports MultiPlayerQuizGame.ClsDataStructures

Module ModMicrosoftWordVBAQuestions

    Public Sub MicrosoftWordVBAQuestions()

        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What does VBA stand for in Microsoft Word?",
              .Options = New String() {"Visual Basic for Applications", "Virtual Basic for Applications", "Variable Basic for Applications", "Visual Base for Applications"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you open the VBA editor in Word?",
              .Options = New String() {"Alt + F11", "Ctrl + F11", "Alt + F8", "Ctrl + Shift + F11"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "Which object in Word VBA refers to the active document?",
              .Options = New String() {"ActiveDocument", "ThisDocument", "Application", "Documents"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you add a new module in the VBA editor?",
              .Options = New String() {"Insert > Module", "File > New Module", "Tools > New Module", "Edit > Add Module"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the default scope of a subroutine in Word VBA if no access modifier is specified?",
              .Options = New String() {"Public", "Private", "Global", "Protected"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What keyword is used to declare a variable in VBA?",
              .Options = New String() {"Dim", "Declare", "Set", "New"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you refer to the first paragraph in an active Word document?",
              .Options = New String() {"ActiveDocument.Paragraphs(1)", "ActiveDocument.FirstParagraph", "ActiveDocument.P1", "ActiveDocument.Paragraph(1)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What method is used to save a document in Word VBA?",
              .Options = New String() {"ActiveDocument.Save", "ActiveDocument.Store", "ActiveDocument.Write", "ActiveDocument.Persist"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you close a document using VBA?",
              .Options = New String() {"ActiveDocument.Close", "ActiveDocument.Quit", "ActiveDocument.Exit", "ActiveDocument.Stop"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "Which object in Word VBA represents the entire application?",
              .Options = New String() {"Application", "ActiveDocument", "AppObject", "ThisApplication"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you display a message box in Word VBA?",
              .Options = New String() {"MsgBox", "ShowMessage", "Message", "DisplayMsg"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What does the ""Selection"" object represent in Word VBA?",
              .Options = New String() {"The current selection or range of text", "The first paragraph", "The last line of the document", "The active page"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you open a Word document using VBA?",
              .Options = New String() {"Documents.Open", "ActiveDocument.Open", "WordDocument.Open", "File.Open"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the purpose of the ""With"" statement in VBA?",
              .Options = New String() {"To execute a series of statements on a single object", "To create a new object", "To close an object", "To save an object"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What type of loop is used to iterate through a collection in VBA?",
              .Options = New String() {"For Each...Next", "Do...While", "While...End", "Loop Until"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you create a new Word document using VBA?",
              .Options = New String() {"Documents.Add", "ActiveDocument.Create", "Word.NewDocument", "File.NewDocument"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "Which of the following data types is not valid in VBA?",
              .Options = New String() {"Decimal", "Integer", "String", "Boolean"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What function is used to get the current date in VBA?",
              .Options = New String() {"Date", "GetDate", "Now", "Time"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you change the font size of a selected text in Word VBA?",
              .Options = New String() {"Selection.Font.Size = 12", "Selection.Text.Size = 12", "ActiveDocument.Font.Size = 12", "Selection.Text.FontSize = 12"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What does ""End Sub"" indicate in VBA?",
              .Options = New String() {"The end of a subroutine", "The start of a loop", "The end of a function", "A breakpoint"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you run a macro in Word?",
              .Options = New String() {"Alt + F8", "Ctrl + F8", "Alt + F11", "Shift + F8"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the default value of a Boolean variable in VBA?",
              .Options = New String() {"False", "True", "Null", "Undefined"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you reference the headers in a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Sections(1).Headers", "ActiveDocument.Headers", "ActiveDocument.DocumentHeaders", "ActiveDocument.PageHeaders"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you undo the last action in Word VBA?",
              .Options = New String() {"ActiveDocument.Undo", "ActiveDocument.LastAction", "Application.Undo", "Word.Undo"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What method is used to copy text in Word VBA?",
              .Options = New String() {"Selection.Copy", "Selection.Paste", "Selection.Transfer", "Document.Copy"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you delete a paragraph using VBA?",
              .Options = New String() {"ActiveDocument.Paragraphs(1).Range.Delete", "ActiveDocument.Paragraphs(1).Remove", "ActiveDocument.Paragraphs(1).Cut", "ActiveDocument.Paragraphs(1).Erase"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "Which event is triggered when a document is opened in Word VBA?",
              .Options = New String() {"Document_Open", "Document_Start", "Document_Load", "Document_Show"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the extension for a Word Macro-Enabled document?",
              .Options = New String() {"docm", "docx", "doc", "dotm"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you make a subroutine private in VBA?",
              .Options = New String() {"Use the keyword Private", "Use the keyword Hidden", "Use the keyword Local", "Use the keyword Internal"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the purpose of the ""Option Explicit"" statement?",
              .Options = New String() {"It forces explicit declaration of variables", "It disables error handling", "It automatically declares variables", "It ends the program"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you protect a document with a password using VBA?",
              .Options = New String() {"ActiveDocument.Protect", "ActiveDocument.PasswordProtect", "ActiveDocument.Secure", "ActiveDocument.Encrypt"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you change the alignment of a paragraph to center using VBA?",
              .Options = New String() {"Selection.ParagraphFormat.Alignment = wdAlignParagraphCenter", "Selection.Alignment = Center", "ActiveDocument.AlignParagraph = Center", "Paragraph.Alignment = wdAlignCenter"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you check if a document has been saved in Word VBA?",
              .Options = New String() {"ActiveDocument.Saved", "ActiveDocument.IsSaved", "ActiveDocument.HasSaved", "Application.IsSaved"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What method is used to quit the Word application using VBA?",
              .Options = New String() {"Application.Quit", "Application.Close", "Word.Quit", "ActiveDocument.Quit"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you find and replace text in a Word document using VBA?",
              .Options = New String() {"Selection.Find.Execute", "Selection.Replace.Execute", "Document.Find.Replace", "ActiveDocument.FindAndReplace"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you comment out a line of code in VBA?",
              .Options = New String() {"Use an apostrophe (')", "Use a semicolon (;)", "Use two slashes (//)", "Use a hash (#)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you format text as bold using VBA?",
              .Options = New String() {"Selection.Font.Bold = True", "Selection.Text.Bold = True", "ActiveDocument.BoldText = True", "Selection.Bold = True"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you turn off ScreenUpdating in VBA to improve performance?",
              .Options = New String() {"Application.ScreenUpdating = False", "Application.UpdateScreen = False", "Word.ScreenUpdating = False", "ActiveDocument.ScreenUpdating = False"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "Which statement would you use to exit a loop early in VBA?",
              .Options = New String() {"Exit For", "Stop For", "Break For", "Exit Loop"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the purpose of the ""DoEvents"" function in VBA?",
              .Options = New String() {"It allows the system to process other events", "It pauses the macro", "It restarts the macro", "It ends the macro"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you declare an array in VBA?",
              .Options = New String() {"Dim arr(5) As Integer", "Declare arr[5] As Integer", "Set arr = Array(5)", "New Array(5)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you display the Developer tab in Word?",
              .Options = New String() {"File > Options > Customize Ribbon > Developer", "View > Developer", "Insert > Developer", "Home > Developer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you set the value of a bookmark in Word VBA?",
              .Options = New String() {"ActiveDocument.Bookmarks(""BookmarkName"").Range.Text = ""New Value""", "ActiveDocument.SetBookmark(""BookmarkName"", ""New Value"")", "ActiveDocument.BookmarkValue = ""New Value""", "Document.SetBookmark(""BookmarkName"", ""New Value"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "Which method is used to open the Find dialog in Word VBA?",
              .Options = New String() {"Application.Dialogs(wdDialogEditFind).Show", "Application.Dialogs(wdDialogFind).Show", "ActiveDocument.FindDialog.Show", "Word.FindDialog.Show"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you add a table to a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Tables.Add", "ActiveDocument.CreateTable", "Selection.InsertTable", "ActiveDocument.NewTable"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the correct syntax to specify a range from the beginning of a document to a specific point?",
              .Options = New String() {"ActiveDocument.Range(0, Selection.End)", "ActiveDocument.TextRange(0, Selection.End)", "ActiveDocument.Range(Start, Selection.End)", "Document.Range(First, Selection.End)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What property is used to check whether an object exists in VBA?",
              .Options = New String() {"Is Nothing", "Is Empty", "Not Exists", "Exists"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you format a selection as italic in Word VBA?",
              .Options = New String() {"Selection.Font.Italic = True", "Selection.Text.Italic = True", "ActiveDocument.ItalicText = True", "Selection.Italic = True"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you insert a page break in Word VBA?",
              .Options = New String() {"Selection.InsertBreak wdPageBreak", "ActiveDocument.InsertPageBreak", "Selection.NewPage", "Document.PageBreak"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you count the number of words in a document using VBA?",
              .Options = New String() {"ActiveDocument.Words.Count", "ActiveDocument.CountWords", "ActiveDocument.TextCount", "Application.WordCount"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you delete a bookmark in Word VBA?",
              .Options = New String() {"ActiveDocument.Bookmarks(""BookmarkName"").Delete", "ActiveDocument.RemoveBookmark(""BookmarkName"")", "ActiveDocument.Bookmarks.Delete(""BookmarkName"")", "ActiveDocument.BookmarkDelete(""BookmarkName"")"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you set the zoom percentage for a Word document using VBA?",
              .Options = New String() {"ActiveWindow.View.Zoom.Percentage = 100", "ActiveDocument.Zoom = 100", "Word.ZoomPercentage = 100", "Application.SetZoom(100)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the purpose of the ""Call"" keyword in VBA?",
              .Options = New String() {"To invoke a subroutine or function", "To define a function", "To terminate a subroutine", "To pause execution"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you save a Word document as a PDF using VBA?",
              .Options = New String() {"ActiveDocument.ExportAsFixedFormat", "ActiveDocument.SaveAsPDF", "ActiveDocument.SaveAsFormat(""PDF"")", "ActiveDocument.PDFSave"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you reference the footers in a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Sections(1).Footers", "ActiveDocument.Footers", "ActiveDocument.DocumentFooters", "ActiveDocument.PageFooters"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you specify the document's title using VBA?",
              .Options = New String() {"ActiveDocument.BuiltInDocumentProperties(""Title"").Value = ""New Title""", "ActiveDocument.SetTitle(""New Title"")", "ActiveDocument.Title = ""New Title""", "Application.DocumentTitle = ""New Title"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you pause code execution for a specific duration in VBA?",
              .Options = New String() {"Application.Wait", "Application.Pause", "Application.Sleep", "Application.Halt"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you apply a specific style to a paragraph using VBA?",
              .Options = New String() {"Selection.Style = ""Heading 1""", "ActiveDocument.ParagraphStyle = ""Heading 1""", "Selection.ApplyStyle(""Heading 1"")", "Document.SetStyle(""Heading 1"")"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you hide the Word application window using VBA?",
              .Options = New String() {"Application.Visible = False", "ActiveDocument.Hide", "Application.Window.Hide", "Word.HideApplication"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you handle errors in VBA?",
              .Options = New String() {"On Error Resume Next", "Try...Catch", "ErrorHandler", "HandleError"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you move the selection to the start of the document using VBA?",
              .Options = New String() {"Selection.HomeKey wdStory", "Selection.StartDocument", "Selection.GoToStart", "Document.GoToBeginning"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you display the Save As dialog in Word VBA?",
              .Options = New String() {"Application.Dialogs(wdDialogFileSaveAs).Show", "Application.Dialogs(wdDialogSaveAs).Show", "ActiveDocument.SaveAsDialog.Show", "File.SaveAs"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you lock the fields in a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Fields.Lock", "ActiveDocument.LockFields", "Document.Fields.Lock", "Fields.Lock"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you insert text at the end of a document using VBA?",
              .Options = New String() {"ActiveDocument.Content.InsertAfter ""Text""", "Selection.InsertText ""Text""", "ActiveDocument.InsertEnd ""Text""", "Document.InsertTextAtEnd ""Text"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you check if a Word document is protected using VBA?",
              .Options = New String() {"ActiveDocument.ProtectionType", "ActiveDocument.IsProtected", "ActiveDocument.HasProtection", "Document.ProtectionStatus"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you apply a numbered list to a selection in Word VBA?",
              .Options = New String() {"Selection.Range.ListFormat.ApplyNumberDefault", "Selection.ApplyNumberList", "ActiveDocument.NumberList", "ListFormat.ApplyNumbers"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you remove all formatting from selected text using VBA?",
              .Options = New String() {"Selection.ClearFormatting", "Selection.RemoveFormatting", "ActiveDocument.FormatClear", "Selection.FormatNone"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you activate an existing document window using VBA?",
              .Options = New String() {"Windows(""DocumentName"").Activate", "Documents.Activate(""DocumentName"")", "ActiveDocument.ActivateWindow", "Application.SwitchToWindow ""DocumentName"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you loop through all open documents in Word using VBA?",
              .Options = New String() {"For Each doc In Documents", "For doc In OpenDocuments", "For Each doc In ActiveDocuments", "For All Documents In Word"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you display a custom dialog box in VBA?",
              .Options = New String() {"UserForm.Show", "CustomForm.Show", "ActiveDocument.ShowForm", "DialogBox.Show"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you convert a selection to uppercase using VBA?",
              .Options = New String() {"Selection.Text = UCase(Selection.Text)", "Selection.ToUpper()", "ActiveDocument.UpperCase", "Document.ChangeCase ""Upper"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you check the spelling of the entire document using VBA?",
              .Options = New String() {"ActiveDocument.CheckSpelling", "ActiveDocument.SpellCheck", "Application.CheckDocumentSpelling", "Document.CheckGrammarAndSpelling"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you retrieve the page number of a selection in Word VBA?",
              .Options = New String() {"Selection.Information(wdActiveEndPageNumber)", "Selection.GetPageNumber", "ActiveDocument.PageNumber(Selection)", "Application.PageFromSelection"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you update all fields in a document using VBA?",
              .Options = New String() {"ActiveDocument.Fields.Update", "ActiveDocument.UpdateFields", "Application.Fields.Refresh", "Document.RefreshAllFields"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you remove the highlighting from text using VBA?",
              .Options = New String() {"Selection.Range.HighlightColorIndex = wdNoHighlight", "Selection.RemoveHighlight", "ActiveDocument.Text.ClearHighlight", "Document.HighlightColor = wdNoHighlight"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you insert a hyperlink in Word VBA?",
              .Options = New String() {"ActiveDocument.Hyperlinks.Add", "Selection.InsertHyperlink", "Application.AddLink", "ActiveDocument.Links.Add"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you delete a table from a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Tables(1).Delete", "ActiveDocument.RemoveTable(1)", "ActiveDocument.DeleteTable(1)", "Document.TableRemove(1)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "What is the maximum number of arguments a function can have in VBA?",
              .Options = New String() {"60", "10", "32", "255"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you turn on the ruler in Word using VBA?",
              .Options = New String() {"ActiveWindow.DisplayRulers = True", "Application.ShowRuler", "ActiveDocument.EnableRuler", "Document.RulerVisibility = True"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you insert a section break in Word VBA?",
              .Options = New String() {"Selection.InsertBreak Type:=wdSectionBreakNextPage", "ActiveDocument.BreakSection", "Document.InsertSection", "Application.AddSectionBreak"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you protect a section in Word VBA?",
              .Options = New String() {"ActiveDocument.Sections(1).ProtectedForForms = True", "Document.Sections(1).Lock", "ActiveDocument.ProtectSection(1)", "Sections(1).EnableProtection"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you convert a table to text in Word VBA?",
              .Options = New String() {"ActiveDocument.Tables(1).ConvertToText", "ActiveDocument.TextFromTable(1)", "Document.TableToText(1)", "Application.ConvertTableToText(1)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you access the footnotes in a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Footnotes", "ActiveDocument.Notes", "Document.FootNoteCollection", "Application.FootNote"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you check if a macro exists in Word VBA?",
              .Options = New String() {"Application.Macros.Exists(""MacroName"")", "ActiveDocument.HasMacro(""MacroName"")", "Application.CheckMacro(""MacroName"")", "Document.IsMacro(""MacroName"")"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you select the entire document in Word VBA?",
              .Options = New String() {"Selection.WholeStory", "ActiveDocument.SelectAll", "Document.SelectText", "Application.EntireDocument"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you count the number of paragraphs in a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Paragraphs.Count", "ActiveDocument.CountParagraphs", "Application.ParagraphCount", "Document.ParagraphsTotal"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you find the next occurrence of a search term in Word VBA?",
              .Options = New String() {"Selection.Find.Execute FindText:=""Text"", Forward:=True", "Document.FindNext ""Text""", "ActiveDocument.SearchNext ""Text""", "Application.FindForward ""Text"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you stop a running macro in Word VBA?",
              .Options = New String() {"End", "Halt", "StopMacro", "Quit"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you insert a header in a Word document using VBA?",
              .Options = New String() {"ActiveDocument.Sections(1).Headers(wdHeaderFooterPrimary).Range.Text = ""Header Text""", "ActiveDocument.Headers.Insert(""Header Text"")", "Document.AddHeader ""Header Text""", "Application.InsertHeader ""Header Text"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you apply single line spacing to a paragraph using VBA?",
              .Options = New String() {"Selection.ParagraphFormat.LineSpacingRule = wdLineSpaceSingle", "Selection.LineSpacing = Single", "ActiveDocument.ParagraphSpacing = Single", "Document.SetSingleLineSpacing"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you open the Page Setup dialog in Word VBA?",
              .Options = New String() {"Application.Dialogs(wdDialogFilePageSetup).Show", "ActiveDocument.ShowPageSetup", "Document.PageSetupDialog.Show", "Application.OpenPageSetupDialog"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you convert a footnote to an endnote in Word VBA?",
              .Options = New String() {"ActiveDocument.Footnotes(1).Convert", "ActiveDocument.Footnotes(1).ToEndnote", "Document.ConvertFootnote(1)", "Application.FootnoteToEndnote"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you get the total number of characters in a document using VBA?",
              .Options = New String() {"ActiveDocument.Content.Characters.Count", "ActiveDocument.CharacterCount", "Document.CountCharacters", "Application.TotalCharacters"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you restart numbering in a numbered list using VBA?",
              .Options = New String() {"Selection.Range.ListFormat.ApplyNumberDefault RestartNumbering:=True", "ActiveDocument.RestartNumbering", "Document.NumberingRestart", "Application.ListRestart"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you clear the undo stack in Word VBA?",
              .Options = New String() {"ActiveDocument.UndoClear", "Application.ClearUndo", "Document.ResetUndo", "Word.UndoRemove"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you assign a macro to a keyboard shortcut in Word VBA?",
              .Options = New String() {"Application.KeyBindings.Add", "Document.AssignKeyShortcut", "Application.ShortcutAdd", "ActiveDocument.SetKeyBindings"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you insert a text form field using VBA?",
              .Options = New String() {"ActiveDocument.FormFields.Add", "Document.InsertTextField", "ActiveDocument.AddFormField", "Selection.InsertFormField"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you count the number of pages in a document using VBA?",
              .Options = New String() {"ActiveDocument.ComputeStatistics(wdStatisticPages)", "ActiveDocument.CountPages", "Document.TotalPages", "Application.PageCount"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you remove a macro in Word VBA?",
              .Options = New String() {"Application.Macros.Remove(""MacroName"")", "Document.RemoveMacro(""MacroName"")", "ActiveDocument.DeleteMacro(""MacroName"")", "Word.RemoveMacro"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Word VBA", .Text = "How do you display the Insert Table dialog in Word VBA?",
              .Options = New String() {"Application.Dialogs(wdDialogTableInsertTable).Show", "ActiveDocument.ShowTableInsert", "Document.TableInsertDialog.Show", "InsertTable"}, .CorrectAnswer = 0})

    End Sub
End Module
