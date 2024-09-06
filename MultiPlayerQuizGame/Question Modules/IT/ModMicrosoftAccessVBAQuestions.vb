Imports MultiPlayerQuizGame.ClsDataStructures

Module ModMicrosoftAccessVBAQuestions

    Public Sub MicrosoftAccessVBAQuestions()

        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What does VBA stand for in Microsoft Access?",
              .Options = New String() {"Visual Basic Automation", "Virtual Basic for Applications", "Visual Basic for Access", "Visual Basic for Applications"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the main use of VBA in Access?",
              .Options = New String() {"To design forms", "To automate tasks and customize functionality", "To manage databases", "To create tables"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which method is used to open a form in VBA?",
              .Options = New String() {"DoCmd.OpenReport", "DoCmd.OpenForm", "DoCmd.OpenTable", "DoCmd.RunForm"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you refer to the current database in VBA?",
              .Options = New String() {"CurrentProject", "CurrentDB", "ActiveDatabase", "DatabaseProject"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What event occurs when a form is loaded in Access?",
              .Options = New String() {"BeforeOpen", "OnClick", "OnLoad", "AfterClose"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you display a message box in VBA?",
              .Options = New String() {"MsgPop", "MessageBox", "ShowMessage", "MsgBox"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the default data type for variables in VBA if none is specified?",
              .Options = New String() {"String", "Integer", "Variant", "Object"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you declare a variable in VBA?",
              .Options = New String() {"variable Dim", "Dim variable As DataType", "Declare variable", "Define variable"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which property would you use to determine if a form is open in VBA?",
              .Options = New String() {"IsLoaded", "IsOpen", "FormLoaded", "FormStatus"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What does the DoCmd.RunSQL method do?",
              .Options = New String() {"Executes a macro", "Runs a VBA function", "Executes an SQL statement", "Opens a form"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you create a loop in VBA that runs a specific number of times?",
              .Options = New String() {"For Next", "Do While", "While Wend", "If Then"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What keyword is used to end a VBA procedure?",
              .Options = New String() {"Stop", "Exit", "End", "Terminate"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you trap errors in VBA?",
              .Options = New String() {"On Error Resume Next", "Try Catch", "If Err Then", "Exception Handling"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What function is used to return the current system date in VBA?",
              .Options = New String() {"CurrentDate", "Now", "GetDate", "Date"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the Me keyword in VBA?",
              .Options = New String() {"Refers to the current form", "Refers to the current module", "Refers to the Access database", "Refers to the VBA editor"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which statement is used to execute one or more lines of code depending on a condition?",
              .Options = New String() {"For Loop", "DoCmd.Run", "If...Then...Else", "Try...Catch"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function is used to convert a string to uppercase in VBA?",
              .Options = New String() {"Upper", "ToUpper", "UCase", "UpperCase"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What method would you use to close a form in VBA?",
              .Options = New String() {"CloseForm", "Form.Close", "DoCmd.Close", "Application.Close"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you define an array in VBA?",
              .Options = New String() {"Array()", "Dim ArrayName As Array", "Dim ArrayName(10)", "CreateArray"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which statement is used to declare a constant in VBA?",
              .Options = New String() {"Static", "Const", "Dim", "Permanent"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What function is used to get the length of a string in VBA?",
              .Options = New String() {"LengthOf", "Len", "StrLen", "StringLength"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is a subroutine in VBA?",
              .Options = New String() {"A function that returns a value", "A block of code that performs a task but doesn't return a value", "A collection of macros", "A property of a form"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you add a comment in VBA code?",
              .Options = New String() {"// Comment", "/* Comment */", "# Comment", "' Comment"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which keyword is used to create a user-defined function in VBA?",
              .Options = New String() {"Func", "Function", "Define", "Declare"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the default scope of a variable declared with Dim?",
              .Options = New String() {"Public", "Global", "Private to the procedure", "Local"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you handle a user-defined error in VBA?",
              .Options = New String() {"Raise", "Err.Raise", "Error", "UserError"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which object would you use to refer to a table in VBA?",
              .Options = New String() {"RecordSet", "QueryDef", "TableDef", "DataObject"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What function is used to return the current system time?",
              .Options = New String() {"CurrentTime", "TimeNow", "GetTime", "Time"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you prevent a form from closing in the OnClose event?",
              .Options = New String() {"Cancel = True", "Close = False", "StopClose", "Form.Exit"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which method is used to save a record in VBA?",
              .Options = New String() {"DoCmd.Save", "Form.Save", "DoCmd.RunSave", "DoCmd.RunCommand acCmdSaveRecord"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the Option Explicit statement?",
              .Options = New String() {"To enforce variable declaration", "To enable error handling", "To disable undeclared variables", "To allow dynamic variables"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you open a report in VBA?",
              .Options = New String() {"DoCmd.OpenTable", "DoCmd.OpenForm", "DoCmd.OpenQuery", "DoCmd.OpenReport"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function can you use to join two strings in VBA?",
              .Options = New String() {"Combine", "Merge", "Join", "&&"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the return value of the MsgBox function in VBA?",
              .Options = New String() {"Boolean", "String", "Integer", "Variant"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you make a VBA procedure available to all forms and reports?",
              .Options = New String() {"Declare it in a form", "Place it in a module", "Use it in a class", "Write it in the VBA editor"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you exit a For loop prematurely in VBA?",
              .Options = New String() {"Stop", "Exit Loop", "Break", "Exit For"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the main difference between a Sub and a Function in VBA?",
              .Options = New String() {"A Sub can return a value, a Function cannot", "A Function can return a value, a Sub cannot", "Both are the same", "A Sub is global, a Function is private"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which event occurs when a user clicks a button in Access?",
              .Options = New String() {"OnLoad", "AfterUpdate", "OnClick", "BeforeClose"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the Set keyword in VBA?",
              .Options = New String() {"To assign a value to an object", "To declare a variable", "To define a constant", "To initialize a procedure"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function is used to return the square root of a number in VBA?",
              .Options = New String() {"Sqrt", "SquareRoot", "Root", "Sqr"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you loop through all records in a Recordset?",
              .Options = New String() {"Do Until EOF", "For Each Record", "While Not RecordSet.EOF", "Do While Not RecordSet.EOF"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you display a form as a dialog box in VBA?",
              .Options = New String() {"DoCmd.OpenForm, acDialog", "Form.Show", "OpenForm acDialog", "DisplayDialog Form"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function returns the absolute value of a number in VBA?",
              .Options = New String() {"Abs", "Absolute", "ValueOf", "PositiveValue"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What does the GoTo statement do in VBA?",
              .Options = New String() {"Moves control to another procedure", "Exits the current subroutine", "Transfers control to a labeled line of code", "Closes the current form"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you pass an argument by reference in VBA?",
              .Options = New String() {"ByVal", "ByRef", "Param", "Argument"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the default value for an uninitialized Boolean variable in VBA?",
              .Options = New String() {"True", "False", "Null", "0"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which of the following functions returns the remainder of a division in VBA?",
              .Options = New String() {"Div", "Mod", "Rem", "Fraction"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you assign a value to a form control in VBA?",
              .Options = New String() {"Control.Value", "Control = ""Value""", "Me.Control.Value = ""Value""", "Control.Assign"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What event occurs when a control loses focus in VBA?",
              .Options = New String() {"OnLost", "AfterUpdate", "OnBlur", "OnLostFocus"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which method would you use to copy a file in VBA?",
              .Options = New String() {"FileCopy", "CopyFile", "MoveFile", "DuplicateFile"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What keyword would you use to declare a public variable in VBA?",
              .Options = New String() {"Global", "Private", "Public", "Dim"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you determine the data type of a variable in VBA?",
              .Options = New String() {"VarType", "TypeOf", "DataType", "IsType"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What function returns the highest value in an array?",
              .Options = New String() {"Max", "UBound", "Highest", "Top"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you check if a form control is empty in VBA?",
              .Options = New String() {"If Control.Value = Null", "If Control = Empty", "If IsNull(Control.Value)", "If Control.IsEmpty"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the Debug.Print statement in VBA?",
              .Options = New String() {"To halt program execution", "To print output in the immediate window", "To print on paper", "To show output in a message box"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you assign a value to a variable in VBA?",
              .Options = New String() {"var = 10", "Set var = 10", "Assign var 10", "var := 10"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which operator is used for concatenation in VBA?",
              .Options = New String() {"+", "@", ".concat", "&&"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the use of the With statement in VBA?",
              .Options = New String() {"To declare variables", "To execute multiple methods on a single object", "To start a loop", "To define a class"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function would you use to remove spaces from a string in VBA?",
              .Options = New String() {"Trim", "RemoveSpaces", "Strip", "Clean"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you convert a string to a number in VBA?",
              .Options = New String() {"CInt", "ToInt", "ConvertToNumber", "StrToNum"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What does the Resume Next statement do in error handling?",
              .Options = New String() {"Continues execution at the next line", "Terminates the program", "Resumes execution at the start of the procedure", "Ignores the error and continues"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you declare a dynamic array in VBA?",
              .Options = New String() {"Dim arr(0 to 100)", "Dim arr()", "Array arr", "Declare arr()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which event is triggered when a form is resized in VBA?",
              .Options = New String() {"OnSize", "OnResize", "AfterResize", "FormResized"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the Optional keyword in VBA?",
              .Options = New String() {"To make a variable nullable", "To allow a procedure argument to be omitted", "To declare a default value", "To exit a procedure"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you set a breakpoint in VBA code?",
              .Options = New String() {"Right-click the code", "Use the Debug menu", "Press F9", "Insert a comment"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which statement can you use to terminate a Do While loop in VBA?",
              .Options = New String() {"Exit Do", "Stop", "End Loop", "Terminate While"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you display a dialog box in VBA that allows users to select a file?",
              .Options = New String() {"Application.Dialogs", "FileDialog", "FileSelector", "DoCmd.OpenDialog"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What function is used to calculate the remainder after division in VBA?",
              .Options = New String() {"Remainder", "Mod", "Div", "Fract"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you access the value of a control on another form in VBA?",
              .Options = New String() {"Forms!FormName!ControlName", "Control.FormName.Value", "Form[ControlName].Value", "FormControls.Value"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you clear all variables in VBA?",
              .Options = New String() {"ClearVariables", "Reset", "Erase", "Clear"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What keyword is used to define a new class in VBA?",
              .Options = New String() {"Define Class", "ClassModule", "Class", "Module"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What function can you use to convert a value to a string in VBA?",
              .Options = New String() {"ToStr", "CStr", "ConvertToStr", "StrConv"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function is used to calculate the difference between two dates in VBA?",
              .Options = New String() {"DateDiff", "DaysBetween", "DateSub", "DiffDate"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you refer to the currently active form in VBA?",
              .Options = New String() {"ActiveForm", "ThisForm", "Me", "CurrentForm"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What does the InputBox function do in VBA?",
              .Options = New String() {"Prompts the user to enter a value", "Displays a message", "Runs a form", "Opens a dialog box"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you handle multiple conditions in VBA?",
              .Options = New String() {"ElseIf", "ElseIf Else", "If Else", "Switch"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What keyword is used to make a procedure available to other modules in VBA?",
              .Options = New String() {"Shared", "Global", "Public", "Static"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you create a reference to another database in VBA?",
              .Options = New String() {"CreateDB", "Set db = OpenDatabase", "OpenDB", "ConnectDatabase"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What does the DoCmd.TransferText method do in VBA?",
              .Options = New String() {"Transfers a file", "Imports or exports text files", "Opens a text editor", "Converts text"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you handle an error that cannot be ignored in VBA?",
              .Options = New String() {"On Error Resume Next", "On Error GoTo", "Try Catch", "Ignore Error"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the Call keyword in VBA?",
              .Options = New String() {"To call another procedure", "To execute a loop", "To define a class", "To display a form"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you pause code execution in VBA?",
              .Options = New String() {"Pause", "Sleep", "Stop", "Wait"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you create a reference to a form in VBA?",
              .Options = New String() {"Set frm = Forms![FormName]", "frm = FormName", "CreateForm", "Declare Form"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What method is used to send an email in VBA?",
              .Options = New String() {"DoCmd.SendEmail", "Application.SendMail", "DoCmd.SendObject", "SendOutlookMail"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function is used to convert a string to lowercase in VBA?",
              .Options = New String() {"ToLower", "LowerCase", "LCase", "SmallLetters"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you define a private procedure in VBA?",
              .Options = New String() {"Dim Sub", "Private Sub", "Hidden Sub", "Sub Private"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you display the immediate window in the VBA editor?",
              .Options = New String() {"Ctrl + G", "F12", "Alt + I", "Shift + G"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you declare a module-level variable in VBA?",
              .Options = New String() {"Global Variable", "Public Variable", "Private Variable", "Dim Variable"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function is used to return the minimum value in an array in VBA?",
              .Options = New String() {"Min", "LBound", "Low", "Bottom"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you determine the number of items in an array in VBA?",
              .Options = New String() {"Size", "UBound - LBound + 1", "GetLength", "Count"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you create a new Recordset object in VBA?",
              .Options = New String() {"Set rs = CreateObject(""Recordset"")", "Set rs = New RecordSet", "Set rs = CurrentDB.OpenRecordset", "CreateRecordSet"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you reference the first record in a Recordset object?",
              .Options = New String() {"rs.MoveFirst", "rs.First", "rs.Start", "rs.FirstRecord"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What keyword would you use to exit a function in VBA?",
              .Options = New String() {"Return", "End", "Exit Function", "Break"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How can you check if a string is numeric in VBA?",
              .Options = New String() {"IsNumeric", "IsNumber", "CheckNumeric", "IsDigit"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What is the purpose of the IsNull function in VBA?",
              .Options = New String() {"To check if a variable is empty", "To check if a value is null", "To check if a string is null", "To validate input"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you create a new module in VBA?",
              .Options = New String() {"Insert > Module", "Create > Module", "Add > Module", "New > Module"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you convert a number to a string in VBA?",
              .Options = New String() {"ToStr", "CStr", "NumToStr", "StrConvert"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "What method is used to delete a record in VBA?",
              .Options = New String() {"DeleteRecord", "Remove", "DoCmd.RunCommand acCmdDeleteRecord", "RemoveRecord"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "Which function is used to display an input box where the user can type text in VBA?",
              .Options = New String() {"GetInput", "InputBox", "TextBox", "UserInput"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access VBA", .Text = "How do you round a number to the nearest integer in VBA?",
              .Options = New String() {"Round", "Int", "Fix", "Ceiling"}, .CorrectAnswer = 0})

    End Sub
End Module
