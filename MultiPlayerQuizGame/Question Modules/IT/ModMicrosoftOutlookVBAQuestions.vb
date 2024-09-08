Imports MultiPlayerQuizGame.ClsDataStructures

Module ModMicrosoftOutlookVBAQuestions

    Public Sub MicrosoftOutlookVBAQuestions()

        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the primary object in the Outlook VBA object model for accessing email messages?",
              .Options = New String() {"Outlook.CalendarItem", "Outlook.ContactItem", "Outlook.MailItem", "Outlook.TaskItem"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to send an email in Outlook VBA?",
                      .Options = New String() {".Dispatch", ".Execute", ".Send", ".SendMail"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the default inbox folder in Outlook VBA?",
                      .Options = New String() {"Application.InboxFolder", "Folder(""Inbox"").GetDefault", "GetDefaultFolder(""Inbox"")", "GetNamespace(""MAPI"").GetDefaultFolder(olFolderInbox)"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which event triggers when a new email arrives in Outlook VBA?",
                      .Options = New String() {"EmailArrived", "MailReceived", "NewMailEx", "OnNewMail"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What type of variable is used to hold an email item in Outlook VBA?",
                      .Options = New String() {"EmailObject", "MailItem", "MailObject", "OutlookItem"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the subject of an email in Outlook VBA?",
                      .Options = New String() {"MailItem.GetSubject", "MailItem.MessageTitle", "MailItem.Subject", "MailItem.Title"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which Outlook VBA object represents a calendar appointment?",
                      .Options = New String() {"AppointmentItem", "EventItem", "MeetingItem", "TaskItem"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to display an email item in Outlook VBA?",
                      .Options = New String() {".Display", ".Open", ".Reveal", ".Show"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the body content of an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Body", "MailItem.Content", "MailItem.Message", "MailItem.Text"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you create a new email in Outlook VBA?",
                      .Options = New String() {"Application.CreateItem(olMailItem)", "Application.GenerateItem", "Application.NewEmail", "CreateNewMail"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the VBA constant for an email item?",
                      .Options = New String() {"olEmailItem", "olMailItem", "olMailMessage", "olMessage"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to save an Outlook item?",
                      .Options = New String() {".Persist", ".Save", ".SaveAs", ".Store"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the sender’s email address of a received email?",
                      .Options = New String() {"MailItem.EmailFrom", "MailItem.FromEmail", "MailItem.GetSender", "MailItem.SenderEmailAddress"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which object represents a contact in Outlook VBA?",
                      .Options = New String() {"AddressItem", "ContactItem", "EmailItem", "PersonItem"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to close an Outlook item?",
                      .Options = New String() {".Close", ".Dispose", ".End", ".Terminate"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the recipient's name of an email in Outlook VBA?",
                      .Options = New String() {"MailItem.GetRecipientName", "MailItem.RecipientName", "MailItem.Recipients.Item(1).Name", "MailItem.To.Name"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the Outlook VBA object for representing a task?",
                      .Options = New String() {"AssignmentItem", "JobItem", "TaskItem", "WorkItem"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you delete an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Clear", "MailItem.Delete", "MailItem.Destroy", "MailItem.Remove"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the constant for accessing the drafts folder in Outlook VBA?",
                      .Options = New String() {"olDraftFolder", "olFolderDraftItems", "olFolderDrafts", "olFolderMessages"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the attachments of an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Attachments", "MailItem.EmailAttachments", "MailItem.FileAttachments", "MailItem.GetAttachments"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to create a meeting request in Outlook VBA?",
                      .Options = New String() {"CreateItem(olAppointmentItem)", "CreateNewMeeting", "GenerateMeetingRequest", "ScheduleMeeting"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you mark an email as read in Outlook VBA?",
                      .Options = New String() {"MailItem.MarkRead(True)", "MailItem.Read = True", "MailItem.Status = Read", "MailItem.UnRead = False"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the creation date of an email?",
                      .Options = New String() {"MailItem.CreatedOn", "MailItem.CreationTime", "MailItem.StartTime", "MailItem.TimeCreated"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the Outlook Application object?",
                      .Options = New String() {"Application.GetOutlook", "CreateObject(""Outlook.Application"")", "GetObject(""Outlook.Application"")", "Outlook.GetApplication"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the constant for the sent items folder in Outlook VBA?",
                      .Options = New String() {"olFolderOutbox", "olFolderSentItems", "olFolderSentMail", "olSentFolder"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you move an email to another folder in Outlook VBA?",
                      .Options = New String() {"MailItem.Move(DestinationFolder)", "MailItem.Relocate(DestinationFolder)", "MailItem.SendTo(DestinationFolder)", "MailItem.Transfer(DestinationFolder)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to forward an email in Outlook VBA?",
                      .Options = New String() {"MailItem.DispatchForward", "MailItem.Forward", "MailItem.PassOn", "MailItem.SendForward"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you reply to an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Answer", "MailItem.Reply", "MailItem.Respond", "MailItem.SendReply"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to retrieve the number of attachments in an email?",
                      .Options = New String() {"MailItem.Attachments.Count", "MailItem.Attachments.Total", "MailItem.NumberOfAttachments", "MailItem.TotalAttachments"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you save an attachment from an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Attachments(1).DownloadFile", "MailItem.Attachments(1).SaveAsFile(""C:\path\filename"")", "MailItem.DownloadAttachment(1)", "MailItem.SaveAttachment(1)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the property for accessing the importance of an email?",
                      .Options = New String() {"MailItem.Importance", "MailItem.ImportanceLevel", "MailItem.Level", "MailItem.Priority"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you set the importance of an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Importance = olImportanceHigh", "MailItem.ImportanceLevel = High", "MailItem.Level = High", "MailItem.Priority = olHigh"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which event triggers when a user sends an email in Outlook VBA?",
                      .Options = New String() {"ItemSend", "MailSent", "OnEmailSend", "SentMail"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the Outlook namespace in VBA?",
                      .Options = New String() {"Application.GetNamespace(""MAPI"")", "Application.Namespace", "GetNamespace(""Outlook"")", "Namespace(""MAPI"")"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you create a task in Outlook VBA?",
                      .Options = New String() {"Application.CreateItem(olTaskItem)", "CreateTaskItem()", "GenerateTaskItem", "NewTaskItem()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the constant for the deleted items folder in Outlook VBA?",
                      .Options = New String() {"olDeletedFolder", "olDeletedMessages", "olFolderDeletedItems", "olFolderTrash"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to save an email to a file?",
                      .Options = New String() {"MailItem.Export(""C:\filename.msg"")", "MailItem.SaveAs(""C:\path\filename.msg"")", "MailItem.SaveFile(""filename.msg"")", "MailItem.SaveToFile(""C:\filename.msg"")"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the size of an email in Outlook VBA?",
                      .Options = New String() {"MailItem.EmailSize", "MailItem.FileSize", "MailItem.Length", "MailItem.Size"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the sensitivity of an email?",
                      .Options = New String() {"MailItem.Confidentiality", "MailItem.PrivacyLevel", "MailItem.Sensitivity", "MailItem.SensitivityLevel"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you mark an email as high sensitivity in Outlook VBA?",
                      .Options = New String() {"MailItem.Confidentiality = High", "MailItem.PrivacyLevel = High", "MailItem.Sensitivity = olConfidential", "MailItem.SensitivityLevel = High"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the VBA constant for a recurring task item?",
                      .Options = New String() {"olRecurringTask", "olRepetitiveTask", "olTaskItem", "olTaskSeries"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the start date of a task in Outlook VBA?",
                      .Options = New String() {"TaskItem.BeginDate", "TaskItem.DateStarted", "TaskItem.StartDate", "TaskItem.StartTime"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to display a contact in Outlook VBA?",
                      .Options = New String() {"ContactItem.Display", "ContactItem.Open", "ContactItem.Reveal", "ContactItem.Show"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the list of folders in the default mailbox in Outlook VBA?",
                      .Options = New String() {"Application.GetFolderList", "Application.Mailbox.GetFolders", "Application.Session.Folders", "Application.Session.GetAllFolders"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the constant for the outbox folder in Outlook VBA?",
                      .Options = New String() {"olFolderOutbox", "olFolderOutgoing", "olFolderSent", "olOutboxFolder"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you schedule a task to recur in Outlook VBA?",
                      .Options = New String() {"TaskItem.IsRecurring = True", "TaskItem.Recurring = True", "TaskItem.ScheduleRecurrence", "TaskItem.SetRecur(True)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to cancel a meeting request in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.Cancel", "AppointmentItem.Revoke", "AppointmentItem.Terminate", "AppointmentItem.Void"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you programmatically create a folder in Outlook VBA?",
                      .Options = New String() {"Application.GenerateFolder(""FolderName"")", "Application.NewFolder(""FolderName"")", "Application.Session.CreateFolder(""FolderName"")", "Application.Session.Folders.Add(""FolderName"")"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the due date of a task in Outlook VBA?",
                      .Options = New String() {"TaskItem.DueDate", "TaskItem.EndDate", "TaskItem.FinalDate", "TaskItem.TargetDate"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the total work hours of a task?",
                      .Options = New String() {"TaskItem.HoursWorked", "TaskItem.TotalHours", "TaskItem.TotalWork", "TaskItem.WorkTime"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you assign a task to someone else in Outlook VBA?",
                      .Options = New String() {"TaskItem.Assign", "TaskItem.Delegate", "TaskItem.GiveTask", "TaskItem.Transfer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the property for accessing the location of a meeting in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.Address", "AppointmentItem.Location", "AppointmentItem.Place", "AppointmentItem.Venue"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you set the reminder for an appointment in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.Alarm = True", "AppointmentItem.Notification = True", "AppointmentItem.ReminderSet = True", "AppointmentItem.RemindMe = True"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you dismiss a reminder for an appointment in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.AlarmOff", "AppointmentItem.ClearReminder", "AppointmentItem.ReminderDismiss", "AppointmentItem.ReminderStop"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the notes of a task in Outlook VBA?",
                      .Options = New String() {"TaskItem.Body", "TaskItem.Comments", "TaskItem.Notes", "TaskItem.Text"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to print an email in Outlook VBA?",
                      .Options = New String() {"MailItem.Output", "MailItem.PrintOut", "MailItem.SendToPrint", "MailItem.SendToPrinter"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you send a task request to another user in Outlook VBA?",
                      .Options = New String() {"TaskItem.Dispatch", "TaskItem.Forward", "TaskItem.Send", "TaskItem.Transfer"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the property for accessing the end date of a task?",
                      .Options = New String() {"TaskItem.CompletionDate", "TaskItem.DueDate", "TaskItem.EndDate", "TaskItem.FinalDate"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which object represents a folder in Outlook VBA?",
                      .Options = New String() {"FileFolder", "FolderObject", "MAPIFolder", "OutlookFolder"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you check if an email has been read in Outlook VBA?",
                      .Options = New String() {"MailItem.IsRead = True", "MailItem.MarkRead = True", "MailItem.Status = Read", "MailItem.UnRead = False"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which event triggers when a reminder fires in Outlook VBA?",
                      .Options = New String() {"Alert", "Notify", "OnAlarm", "Reminder"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the recurrence pattern of an appointment in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.GetRecurrencePattern", "AppointmentItem.RecurrenceDetails", "AppointmentItem.Recurring", "AppointmentItem.SetRecurrence"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the method to reply to all recipients of an email?",
                      .Options = New String() {"MailItem.AnswerAll", "MailItem.ReplyAll", "MailItem.RespondAll", "MailItem.RespondToAll"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the categories assigned to an email?",
                      .Options = New String() {"MailItem.Categories", "MailItem.Groups", "MailItem.Labels", "MailItem.Tags"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to snooze a reminder in Outlook VBA?",
                      .Options = New String() {"Reminder.Delay", "Reminder.Pause", "Reminder.Postpone", "Reminder.Snooze"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the duration of an appointment in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.Duration", "AppointmentItem.Elapsed", "AppointmentItem.Length", "AppointmentItem.TimeSpan"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to create a recurring appointment?",
                      .Options = New String() {"AppointmentItem.GetRecurrencePattern", "AppointmentItem.Recurring = True", "AppointmentItem.Repeat", "AppointmentItem.SetRecur"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the response status of a meeting request in Outlook VBA?",
                      .Options = New String() {"AppointmentItem.MeetingStatus", "AppointmentItem.RecipientResponse", "AppointmentItem.ReplyStatus", "AppointmentItem.ResponseStatus"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the property for accessing the billing information of an appointment?",
                      .Options = New String() {"AppointmentItem.Billable", "AppointmentItem.BillingInformation", "AppointmentItem.Charge", "AppointmentItem.Invoice"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you check if an email is flagged in Outlook VBA?",
                      .Options = New String() {"MailItem.CheckFlag", "MailItem.Flag = On", "MailItem.Flagged = True", "MailItem.FlagStatus"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you programmatically dismiss a reminder?",
                      .Options = New String() {"Reminder.Cancel", "Reminder.Clear", "Reminder.Dismiss", "Reminder.End"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the total number of emails in the inbox?",
                      .Options = New String() {"InboxFolder.EmailCount", "InboxFolder.GetItemsCount", "InboxFolder.Items.Count", "InboxFolder.TotalEmails"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the property for accessing the message class of an item?",
                      .Options = New String() {"MailItem.ClassType", "MailItem.ItemType", "MailItem.MessageClass", "MailItem.MessageType"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you programmatically add a category to an email?",
                      .Options = New String() {"MailItem.AddCategory(""CategoryName"")", "MailItem.Categories = ""CategoryName""", "MailItem.Label(""CategoryName"")", "MailItem.Tag(""CategoryName"")"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the voting response options in an email?",
                      .Options = New String() {"MailItem.AnswerOptions", "MailItem.PollingOptions", "MailItem.ResponseOptions", "MailItem.VotingOptions"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you cancel a task assignment in Outlook VBA?",
                      .Options = New String() {"TaskItem.CancelAssign", "TaskItem.Nullify", "TaskItem.Revoke", "TaskItem.VoidAssignment"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you set a reminder time for a task in Outlook VBA?",
                      .Options = New String() {"TaskItem.AlarmTime = Date", "TaskItem.AlertTime = Date", "TaskItem.ReminderTime = Date", "TaskItem.RemindMeAt = Date"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the meeting organizer?",
                      .Options = New String() {"AppointmentItem.Host", "AppointmentItem.Organizer", "AppointmentItem.OrganizerName", "AppointmentItem.Planner"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you check the completion status of a task in Outlook VBA?",
                      .Options = New String() {"TaskItem.CompletionStatus", "TaskItem.Finished", "TaskItem.IsComplete", "TaskItem.Status"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you programmatically open a specific email by its entry ID?",
                      .Options = New String() {"Application.GetMailByID(""EntryID"")", "Application.Mailbox.GetItemByID(""EntryID"")", "Application.OpenEmail(""EntryID"")", "Application.Session.GetItemFromID(""EntryID"")"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you assign a category color to an email?",
                      .Options = New String() {"MailItem.Categories = ""Blue Category""", "MailItem.ColorCategory = ""Blue""", "MailItem.ColorLabel = ""Blue""", "MailItem.SetCategoryColor(""Blue"")"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to retrieve a collection of mail items in a folder?",
                      .Options = New String() {"Folder.GetEmails", "Folder.GetMessages", "Folder.Items", "Folder.MailItems"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you save a contact as a vCard in Outlook VBA?",
                      .Options = New String() {"ContactItem.Export(""filename.vcf"")", "ContactItem.SaveAs(""C:\path\filename.vcf"", olVCard)", "ContactItem.SaveFile(""C:\path\filename.vcf"")", "ContactItem.SaveVCard(""filename.vcf"")"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you add an attachment to a task in Outlook VBA?",
                      .Options = New String() {"TaskItem.AddAttachment(""file.txt"")", "TaskItem.AttachFile(""C:\file.txt"")", "TaskItem.Attachments.Add(""C:\path\file.txt"")", "TaskItem.SetAttachment(""file.txt"")"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the status of a recurring appointment?",
                      .Options = New String() {"AppointmentItem.IsRecurring", "AppointmentItem.RecurrenceState", "AppointmentItem.RecurringStatus", "AppointmentItem.RepeatStatus"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the duration of a task?",
                      .Options = New String() {"TaskItem.ActualWork", "TaskItem.Duration", "TaskItem.ElapsedTime", "TaskItem.TotalHours"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the start time of an appointment?",
                      .Options = New String() {"AppointmentItem.Begin", "AppointmentItem.Start", "AppointmentItem.StartDateTime", "AppointmentItem.TimeStart"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the attachment file name in Outlook VBA?",
                      .Options = New String() {"Attachment.FileName", "Attachment.FileTitle", "Attachment.FullName", "Attachment.Name"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to send an appointment update to attendees?",
                      .Options = New String() {"AppointmentItem.Notify", "AppointmentItem.SendRevision", "AppointmentItem.SendUpdate", "AppointmentItem.UpdateMeeting"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you mark a task as complete in Outlook VBA?",
                      .Options = New String() {"TaskItem.CompleteTask", "TaskItem.Finish", "TaskItem.MarkComplete", "TaskItem.SetComplete"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you create a distribution list in Outlook VBA?",
                      .Options = New String() {"Application.CreateItem(olDistributionListItem)", "Application.GenerateList", "Application.MakeDistributionList", "Application.NewGroupList"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the BCC recipients of an email?",
                      .Options = New String() {"MailItem.BCC", "MailItem.GetBCC", "MailItem.HiddenRecipients", "MailItem.Recipients.BCC"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you access the parent folder of an email?",
                      .Options = New String() {"MailItem.ContainingFolder", "MailItem.Folder", "MailItem.Location", "MailItem.Parent"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "What is the property for accessing the due date of a task?",
                      .Options = New String() {"TaskItem.CompletionDate", "TaskItem.DueDate", "TaskItem.EndDate", "TaskItem.FinishDate"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you check if a task is overdue in Outlook VBA?",
                      .Options = New String() {"TaskItem.CheckDue", "TaskItem.Due = False", "TaskItem.IsLate", "TaskItem.OverDue"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which method is used to remove an attachment from an email?",
                      .Options = New String() {"Attachment.Clear", "Attachment.Delete", "Attachment.Discard", "Attachment.Remove"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the time an email was received?",
                      .Options = New String() {"MailItem.ArrivalTime", "MailItem.GetReceivedTime", "MailItem.ReceivedTime", "MailItem.TimeReceived"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "Which property is used to access the recipients of a meeting request?",
                      .Options = New String() {"AppointmentItem.Attendees", "AppointmentItem.Invitees", "AppointmentItem.Participants", "AppointmentItem.Recipients"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you retrieve the reply-to address of an email?",
                      .Options = New String() {"MailItem.AnswerTo", "MailItem.ReplyRecipient", "MailItem.RespondTo", "MailItem.ResponseAddress"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Outlook VBA", .Text = "How do you set a reminder for a contact’s birthday in Outlook VBA?",
                      .Options = New String() {"ContactItem.Alarm = True", "ContactItem.BirthdayNotify = True", "ContactItem.BirthdayReminder = On", "ContactItem.ReminderSet = True"}, .CorrectAnswer = 3})

    End Sub
End Module
