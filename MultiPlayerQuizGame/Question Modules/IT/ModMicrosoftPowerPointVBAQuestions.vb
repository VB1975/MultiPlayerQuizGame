Imports MultiPlayerQuizGame.ClsDataStructures

Module ModMicrosoftPowerPointVBAQuestions

    Public Sub MicrosoftPowerPointVBAQuestions()

        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What object in PowerPoint represents a single slide in a presentation?",
              .Options = New String() {"Animation", "Presentation", "Shape", "Slide"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method is used to add a new slide to a presentation?",
              .Options = New String() {"Presentation.Create", "Slide.Insert", "Slides.Add", "SlideShow.New"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What is the default extension of a PowerPoint macro-enabled file?",
              .Options = New String() {".ppsm", ".ppsx", ".pptm", ".pptx"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "In PowerPoint VBA, which collection represents all the slides in a presentation?",
              .Options = New String() {"Slides", "Shapes", "Presentations", "Masters"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you start a slide show from the beginning using VBA?",
              .Options = New String() {"SlideShowWindows.Run", "ActivePresentation.SlideShowSettings.Run", "Slides.StartShow", "Application.RunSlideShow"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What property of a Slide object gives you access to its title text?",
              .Options = New String() {"SlideTitle", "TextFrame", "Title.Text", "Shapes(1).TextFrame.TextRange.Text"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "In VBA, which object represents the entire PowerPoint application?",
              .Options = New String() {"Application", "SlideMaster", "Shape", "Presentation"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you refer to the active presentation in PowerPoint VBA?",
              .Options = New String() {"ActivePresentation.Slides", "Application.ActivePresentation", "Application.CurrentPresentation", "ThisPresentation"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What VBA method would you use to delete a slide?",
              .Options = New String() {"Slide.Delete", "Slide.RemoveSlide", "Slides.Delete", "Slides.Remove"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which VBA property gives you access to the shapes on a slide?",
              .Options = New String() {"Slide.AddShapes", "Slide.Shapes", "Slide.ShapesCollection", "Slide.ShapesList"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What VBA event runs a macro when a slide show begins?",
              .Options = New String() {"OnPresentationOpen", "OnSlideActivate", "OnSlideEnter", "OnSlideShowStart"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What method allows you to save a PowerPoint presentation using VBA?",
              .Options = New String() {"Save", "ActivePresentation.Save", "Presentation.Save", "Application.SavePresentation"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you loop through all slides in a presentation in VBA?",
              .Options = New String() {"For Each slide In Slides", "For slide In Slides", "Loop Slides", "Do While Slides.Count"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which PowerPoint VBA method sets the slide transition effect?",
              .Options = New String() {"SetTransition", "SlideShowTransition", "Slide.SlideTransition", "Slide.SlideShowTransition"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which PowerPoint object represents an image or shape on a slide?",
              .Options = New String() {"Animation", "Media", "Picture", "Shape"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a shape to a slide using VBA?",
              .Options = New String() {"AddShape.Add", "Shapes.NewShape", "Slide.AddNewShape", "Slide.Shapes.AddShape"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What VBA method runs a macro when a slide is clicked during a slide show?",
              .Options = New String() {"OnSlideClick", "SlideShowNextClick", "SlideShowAction", "OnSlideShowClick"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you close the active PowerPoint presentation in VBA?",
              .Options = New String() {"ActivePresentation.Close", "Presentation.ShutDown", "Application.Close", "SlideShow.Close"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What VBA property sets the duration of a slide's transition effect?",
              .Options = New String() {"TransitionDuration", "SlideShowTransition.Duration", "TransitionTime", "Slide.TransitionEffectDuration"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you activate a specific slide in PowerPoint VBA?",
              .Options = New String() {"ActivePresentation.ShowSlide", "Presentation.GotoSlide", "Slide.Activate", "SlideShowWindows(1).View.GotoSlide"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which VBA method sets an action button on a slide?",
              .Options = New String() {"AddAction", "Shape.ActionSettings", "Slide.AddAction", "Button.SetAction"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you export a PowerPoint slide as an image using VBA?",
              .Options = New String() {"Shape.ExportAsImage", "Slide.Export", "Slide.SaveAs", "Slide.SaveAsImage"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which PowerPoint VBA method plays a sound effect during a slide show?",
              .Options = New String() {"PlaySound", "SlideSound.Play", "SlideShowTransition.SoundEffect.Play", "Shape.PlaySound"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you hide a slide in a PowerPoint presentation using VBA?",
              .Options = New String() {"Slide.Hidden = True", "Slide.Visible = False", "Slide.Hide", "Slide.IsHidden = True"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What method would you use to stop a slide show using VBA?",
              .Options = New String() {"SlideShowEnd", "ActivePresentation.SlideShowWindow.View.Exit", "SlideStop", "SlideShowClose"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which VBA property sets the text of a shape?",
              .Options = New String() {"Shape.SetText", "Shape.Text", "TextFrame.SetText", "TextFrame.TextRange.Text"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What object represents a single paragraph or run of text within a shape?",
              .Options = New String() {"Paragraph", "TextFrame", "TextRange", "TextShape"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a table to a slide using VBA?",
              .Options = New String() {"Shapes.AddTable", "Slide.Shapes.InsertTable", "Slide.AddTable", "Shapes.NewTable"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What VBA method would you use to group multiple shapes on a slide?",
              .Options = New String() {"GroupShapes", "Shapes.Combine", "Shapes.Group", "Slide.GroupShapes"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which VBA property is used to set the font of text in a shape?",
              .Options = New String() {"Shape.Font", "Shape.SetFont", "TextFrame.SetFont", "TextFrame.TextRange.Font"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you set the background color of a slide using VBA?",
              .Options = New String() {"Slide.Background.Fill.ForeColor", "Slide.Color = RGB()", "Slide.Fill.BackColor", "Slide.SetBackground"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What method would you use to add a hyperlink to a shape in VBA?",
              .Options = New String() {"AddLink", "Hyperlinks.Add", "Shape.AddHyperlink", "Shape.SetHyperlink"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property sets the zoom level of the slide view in PowerPoint VBA?",
              .Options = New String() {"Presentation.ZoomLevel", "Slide.Zoom", "SlideShow.Zoom", "View.Zoom"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you move a slide to a different position in VBA?",
              .Options = New String() {"Slide.MoveTo", "Slides.Move", "Slide.ChangePosition", "Slides.SetOrder"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property allows you to lock the aspect ratio of a shape in VBA?",
              .Options = New String() {"AspectLock", "LockAspectRatio", "ShapeLock", "ShapeRatio"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What method allows you to change the order of shapes on a slide?",
              .Options = New String() {"ArrangeShapes", "ShapeOrder", "Slide.ZOrder", "ZOrder"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a comment to a slide using VBA?",
              .Options = New String() {"AddNote", "Presentation.Comment", "Slide.Comments.Add", "Slide.SetComment"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which PowerPoint VBA method adds an animation effect to a shape?",
              .Options = New String() {"Shape.Animation.Add", "Slide.AddAnimation", "Shape.AddEffect", "Shape.SetAnimation"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What property controls whether a shape is visible during a slide show?",
              .Options = New String() {"VisibleDuringShow", "Shape.Visible", "Shape.ShowInSlideShow", "SlideShowVisibility"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you delete all shapes on a slide using VBA?",
              .Options = New String() {"Slide.Shapes.DeleteAll", "Shapes.Clear", "Slide.Shapes.RemoveAll", "Slide.Shapes.Range.Delete"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method is used to apply a design template to a presentation?",
              .Options = New String() {"SlideMaster.ApplyTemplate", "Presentation.SetTemplate", "Slide.SetDesign", "SlideTemplate.Apply"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you insert a video file onto a slide using VBA?",
              .Options = New String() {"MediaObject.Insert", "Shape.InsertVideo", "Shapes.AddMediaObject", "Slide.AddVideo"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property would you use to check if a presentation is read-only?",
              .Options = New String() {"IsReadOnly", "Locked", "Presentation.Locked", "ReadOnly"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you duplicate a slide using VBA?",
              .Options = New String() {"Slide.Clone", "Slide.Copy", "Slide.Duplicate", "Slide.Replicate"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What method applies a theme to a PowerPoint presentation?",
              .Options = New String() {"ApplyTheme", "Presentation.SetTheme", "SlideTheme.Apply", "SetPresentationTheme"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property allows you to set a slide as a hidden slide?",
              .Options = New String() {"Slide.Hidden", "Slide.Hide", "Slide.IsHidden", "Slide.Visible"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a custom slide layout in VBA?",
              .Options = New String() {"Slide.CustomLayout.Add", "CustomLayout.Add", "Slide.AddLayout", "SlideDesign.Custom"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property is used to check if the slide show is running?",
              .Options = New String() {"SlideShowRunning", "SlideShowState", "IsRunning", "SlideShow.Active"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add speaker notes to a slide using VBA?",
              .Options = New String() {"Presentation.AddNotes", "Slide.AddNotes", "Slide.NotesPage.Shapes.Placeholders(2).TextFrame.TextRange.Text", "Slide.SpeakerNotes.Add"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method in VBA allows you to change the slide size?",
              .Options = New String() {"PageSetup.SlideSize", "Presentation.SetSize", "SlideMaster.Resize", "SlideResize"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you insert a chart into a PowerPoint slide using VBA?",
              .Options = New String() {"Chart.Insert", "Shapes.AddChart", "Slide.AddGraph", "Slide.InsertChart"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property sets the transition sound for a slide in VBA?",
              .Options = New String() {"Slide.SoundEffect", "SlideShowTransition.SoundEffect", "SlideTransition.SetSound", "Transition.Sound"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you resize a shape on a slide using VBA?",
              .Options = New String() {"Shape.Resize", "Shape.Scale", "Shape.SetSize", "Shape.Width and Shape.Height"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method would you use to apply a slide master to a specific slide?",
              .Options = New String() {"ApplyMaster", "Slide.Design.Apply", "Slide.Master.Apply", "SlideSetMaster"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you make a shape rotate in VBA?",
              .Options = New String() {"Shape.Rotation", "Shape.SetRotation", "Shape.Rotate", "Shape.Angle"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "What VBA method would you use to add a new slide master?",
              .Options = New String() {"Presentation.Designs.Add", "SlideMaster.Add", "Application.AddMaster", "Presentation.Designs(1).SlideMaster"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you check the number of slides in a presentation using VBA?",
              .Options = New String() {"Presentation.SlideCount", "Slides.Count", "ActivePresentation.SlideNumber", "Slide.TotalSlides"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method allows you to set the layout of a slide in VBA?",
              .Options = New String() {"ApplyLayout", "Slide.Layout", "Slide.SetLayout", "SlideDesign.Set"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you pause a slide show in PowerPoint VBA?",
              .Options = New String() {"PauseSlideShow", "Slide.PauseShow", "SlideShow.Pause", "SlideShowWindows(1).View.Pause"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method would you use to change the language of text in a shape?",
              .Options = New String() {"Shape.Language", "Shape.LanguageID", "TextFrame.SetLanguage", "TextRange.LanguageID"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a hyperlink to a text range in PowerPoint VBA?",
              .Options = New String() {"TextRange.ActionSettings.AddHyperlink", "TextRange.AddHyperlink", "Shape.SetLink", "TextFrame.AddLink"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method is used to export the entire presentation as a PDF?",
              .Options = New String() {"ExportAsFixedFormat", "Presentation.ExportPDF", "SaveAsPDF", "SaveFixedFormat"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you start a slide show from the current slide in VBA?",
              .Options = New String() {"SlideShowWindows(1).View.Next", "ActivePresentation.SlideShowSettings.AdvanceMode", "SlideShowWindow.View.GotoSlide", "SlideShowWindows(1).View.StartFromCurrent"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method would you use to display the list of installed add-ins?",
              .Options = New String() {"AddIns.Show", "Application.AddIns", "Application.ShowAddIns", "Presentation.AddIns"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you access the notes pane of a slide using VBA?",
              .Options = New String() {"Slide.NotesPage", "Slide.NotePane", "Presentation.GetNotes", "Slide.GetNotes"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method inserts a 3D model into a slide using VBA?",
              .Options = New String() {"Shape.New3DObject", "Shapes.Add3DModel", "Slide.Add3DObject", "Slide.Insert3D"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you center align a shape on a slide using VBA?",
              .Options = New String() {"Shape.Align msoAlignCenters, msoFalse", "Shape.Center", "Shape.SetAlign", "Slide.AlignCenter"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which VBA property retrieves the current slide index during a slide show?",
              .Options = New String() {"Presentation.CurrentSlideIndex", "SlideShow.Index", "SlideShowPosition", "SlideShowWindows(1).View.CurrentShowPosition"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you adjust the slide's print orientation using VBA?",
              .Options = New String() {"PageSetup.PrintOrientation", "PrintOptions.Orientation", "PrintSettings.Orientation", "SlidePrint.SetOrientation"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method would you use to add an audio clip to a slide using VBA?",
              .Options = New String() {"Media.AddClip", "Shapes.AddMediaObject2", "Shapes.InsertSound", "Slide.AddAudio"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a slide from another presentation in VBA?",
              .Options = New String() {"Presentation.Slides.InsertFromFile", "Slide.AddFromOther", "Slide.InsertFromAnother", "Slide.ShowFromFile"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property would you use to align text within a text box in VBA?",
              .Options = New String() {"Shape.SetAlignment", "Shape.TextAlign", "TextBox.TextAlignment", "TextFrame2.TextRange.ParagraphFormat.Alignment"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you automatically advance slides after a set time in VBA?",
              .Options = New String() {"Slide.AutoAdvance", "Slide.ShowAdvanceTime", "Slide.TransitionTime", "SlideShowTransition.AdvanceTime"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method would you use to check if an animation is running?",
              .Options = New String() {"AnimationEffect.Playing", "AnimationSettings.Running", "Shape.AnimationSettings.PlayState", "SlideShowWindows(1).View.IsPlaying"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you specify the file path to save a presentation using VBA?",
              .Options = New String() {"Application.FilePath", "FileSystem.Save", "Presentation.SaveAs", "Slide.SavePath"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which VBA property adjusts the transparency of a shape's fill?",
              .Options = New String() {"Fill.Opacity", "Fill.Transparency", "Shape.Fill.Opacity", "Shape.Transparency"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you remove animations from all shapes on a slide using VBA?",
              .Options = New String() {"Shape.Animations.Reset", "Shape.ClearAnimations", "Slide.Animations.Remove", "Slide.TimeLine.MainSequence.Clear"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property would you use to check if a slide has animations?",
              .Options = New String() {"AnimationSettings.Check", "Slide.HasAnimations", "SlideShow.HasEffects", "TimeLine.HasAnimations"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you group slides into sections using VBA?",
              .Options = New String() {"Slides.SectionProperties.AddSection", "Slide.CreateSection", "Slide.GroupSlides", "Presentation.AddSection"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method sets a custom show for the slide show?",
              .Options = New String() {"SlideShowSettings.NamedSlideShows", "SlideShowCustomShow.Set", "Presentation.CustomShow", "SlideShowSettings.SetCustom"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you access the handout master using VBA?",
              .Options = New String() {"Presentation.GetHandout", "Presentation.HandoutMaster", "Slide.GetHandout", "SlideMaster.GetHandout"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method in VBA resizes the slide thumbnails in slide sorter view?",
              .Options = New String() {"ActiveWindow.View.SlideSorterThumbnailSize", "Presentation.ThumbnailView", "Slides.SetThumbnailSize", "SlideShowWindows(1).View.ThumbnailSize"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you add a shadow effect to a shape using VBA?",
              .Options = New String() {"Shape.AddShadow", "Shape.ApplyShadow", "Shape.SetShadow", "Shape.Shadow"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method stops the slide show in the middle of a presentation?",
              .Options = New String() {"Presentation.EndShow", "SlideShow.Stop", "SlideShowSettings.EndShow", "SlideShowWindow.View.Exit"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you adjust the brightness of an image in VBA?",
              .Options = New String() {"Image.Brightness", "PictureFormat.Brightness", "PictureFormat.SetBrightness", "Shape.Brightness"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method in VBA allows you to bring a shape to the front?",
              .Options = New String() {"Shape.BringToFront", "Shape.SetOrderToFront", "Shape.ZOrder msoBringToFront", "Slide.ZOrderToFront"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you create a fade-in animation for a shape in VBA?",
              .Options = New String() {"Shape.AnimationSettings.EntryEffect = ppEffectFade", "Shape.FadeEffect", "Shape.SetFade", "Slide.FadeAnimation"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property controls whether a slide has a background fill?",
              .Options = New String() {"Background.Show", "Slide.Background.Fill.Visible", "Slide.BackgroundEnabled", "Slide.Fill.SetBackground"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you print the entire presentation using VBA?",
              .Options = New String() {"ActivePresentation.PrintOut", "Presentation.Print", "Presentation.PrintEntire", "SlideShow.PrintAll"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method applies a gradient fill to a shape using VBA?",
              .Options = New String() {"Shape.Fill.OneColorGradient", "Shape.Gradient", "Shape.SetGradient", "Slide.FillGradient"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you save a presentation as a template using VBA?",
              .Options = New String() {"Presentation.SaveTemplate", "SaveAs ppSaveAsTemplate", "SaveTemplateAs", "Slide.SaveAsTemplate"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method creates a looping slide show in VBA?",
              .Options = New String() {"Presentation.LoopUntilStopped", "Slide.LoopShow", "SlideShow.Loop", "SlideShowSettings.LoopUntilStopped"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you automatically add slide numbers using VBA?",
              .Options = New String() {"HeaderFooter.SlideNumber.Visible", "Presentation.SlideNumbers", "Slide.AddNumbers", "Slide.ShowNumber"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property would you use to access the date footer in VBA?",
              .Options = New String() {"Footer.Date", "HeaderFooter.DateAndTime", "Slide.DateFooter", "Slide.SetFooter"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you merge two shapes into one using VBA?",
              .Options = New String() {"Shape.Combine", "Shape.Join", "ShapeRange.MergeShapes", "Slide.MergeShapes"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method adds a text box to a slide using VBA?",
              .Options = New String() {"Shape.TextBox", "Shapes.AddTextbox", "Shapes.InsertTextBox", "Slide.AddTextBox"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you change the slide show advance settings to manual in VBA?",
              .Options = New String() {"Presentation.SetManualAdvance", "Slide.AdvanceSettings.SetManual", "SlideShow.ManualAdvance", "SlideShowSettings.AdvanceMode = ppSlideShowManualAdvance"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which property returns the total number of slides in a section?",
              .Options = New String() {"Presentation.SectionCount", "Section.SlideTotal", "SectionProperties.SlidesCount", "Slide.TotalInSection"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "How do you convert a shape to a SmartArt graphic in VBA?",
              .Options = New String() {"Shape.ConvertToSmartArt", "Shape.SetSmartArt", "Shape.SmartArt", "Slide.ConvertToSmart"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft PowerPoint VBA", .Text = "Which method is used to reorder slides in a section using VBA?",
              .Options = New String() {"Section.ReorderSlides", "SectionProperties.MoveSlide", "Slide.MoveInSection", "Slide.Reposition"}, .CorrectAnswer = 1})

    End Sub
End Module
