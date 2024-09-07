Imports MultiPlayerQuizGame.ClsDataStructures

Module ModMicrosoftExcelVBAQuestions

    Public Sub MicrosoftExcelVBAQuestions()

        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does VBA stand for?",
              .Options = New String() {"Visual Basic for Applications", "Virtual Basic for Applications", "Visual Basic for Analytics", "Virtual Binary Application"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which object is used to refer to a worksheet in VBA?",
              .Options = New String() {"Workbook", "Worksheet", "Range", "Cell"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to display a message box in VBA?",
              .Options = New String() {"ShowBox", "MessageBox", "MsgBox", "DisplayBox"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following is NOT a valid loop in VBA?",
              .Options = New String() {"Do Until", "For Each", "While End While", "For Next Until"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you start a subroutine in VBA?",
              .Options = New String() {"Subroutine name()", "Sub name()", "Sub name", "Routine name()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you declare a variable in VBA?",
              .Options = New String() {"Let var As Type", "Dim var As Type", "Declare var As Type", "Var var As Type"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the default scope of a variable declared with `Dim` inside a procedure?",
              .Options = New String() {"Global", "Local to the procedure", "Module-level", "Public"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following is used to exit a loop early in VBA?",
              .Options = New String() {"Stop Loop", "Exit Do", "Terminate Loop", "Break"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What keyword is used to handle errors in VBA?",
              .Options = New String() {"On Error", "Try Catch", "Handle Error", "If Error"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to activate a worksheet in VBA?",
              .Options = New String() {"ActivateSheet", "Worksheet.Activate", "Sheet.Select", "Worksheet.Select"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the result of the expression `3 \ 2` in VBA?",
              .Options = New String() {"1", "1.5", "2", "Error"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to determine the type of a variable in VBA?",
              .Options = New String() {"TypeOf", "VarType", "GetType", "TypeName"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What keyword is used to create an array in VBA?",
              .Options = New String() {"Dim", "Array", "Set", "Arr"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you call a subroutine named `MySub`?",
              .Options = New String() {"Call MySub", "MySub.Call", "Sub MySub", "Execute MySub"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which operator is used to concatenate strings in VBA?",
              .Options = New String() {"+", "-&&", "+&&", "&&"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to clear the contents of a cell range?",
              .Options = New String() {"Range.ClearContents", "Range.Delete", "Range.Remove", "Range.Clear"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does `Option Explicit` do in VBA?",
              .Options = New String() {"Automatically declares variables", "Forces explicit variable declaration", "Disables implicit conversions", "Enables error tracking"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of the `Set` keyword in VBA?",
              .Options = New String() {"To declare a variable", "To assign an object reference", "To reset a variable", "To set a constant"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which statement is used to declare a constant in VBA?",
              .Options = New String() {"Static", "Const", "Immutable", "DefConst"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to round a number to the nearest integer in VBA?",
              .Options = New String() {"Int", "Fix", "Round", "Ceiling"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which statement is used to skip the current iteration of a loop in VBA?",
              .Options = New String() {"Skip Iteration", "Next Loop", "Continue", "Continue For"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What data type would you use to store a large text string in VBA?",
              .Options = New String() {"String", "Char", "Long", "Byte"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does the `End Sub` statement do in VBA?",
              .Options = New String() {"Terminates the script", "Marks the end of a subroutine", "Exits a loop", "Ends a function"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which object represents the active workbook in VBA?",
              .Options = New String() {"ActiveWorkbook", "ThisWorkbook", "Workbook", "CurrentWorkbook"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How can you protect a worksheet in VBA?",
              .Options = New String() {"ProtectSheet", "Worksheet.Protect", "SecureSheet", "Sheet.Secure"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you add a new worksheet in VBA?",
              .Options = New String() {"Sheets.Add", "Workbook.Add", "Worksheet.New", "Sheet.New"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does the `DoEvents` function do in VBA?",
              .Options = New String() {"Pauses the execution of the code", "Allows the operating system to process other events", "Triggers an event", "Exits the current procedure"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does `Application.ScreenUpdating = False` do?",
              .Options = New String() {"Disables screen refresh to speed up code execution", "Hides the workbook", "Pauses the code", "Turns off workbook updates"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function would you use to return the current date in VBA?",
              .Options = New String() {"Now", "Date", "Today", "CurrentDate"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which keyword is used to declare a public variable in VBA?",
              .Options = New String() {"Global", "Public", "Shared", "Const"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to save a workbook in VBA?",
              .Options = New String() {"Save", "Workbook.SaveAs", "Workbook.Save", "ActiveWorkbook.Save"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the default value for an uninitialized Boolean variable in VBA?",
              .Options = New String() {"True", "False", "Null", "Empty"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you refer to the active cell in VBA?",
              .Options = New String() {"ActiveCell", "CurrentCell", "SelectedCell", "ThisCell"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of the `Unload` statement in VBA?",
              .Options = New String() {"Close a workbook", "Remove an object from memory", "Unload a module", "Terminate a loop"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which statement is used to convert a value to a string in VBA?",
              .Options = New String() {"Str", "Convert.ToString", "CString", "ToStr"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to find the length of a string in VBA?",
              .Options = New String() {"StrLen", "Length", "Len", "StringLength"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which event is triggered when a workbook is opened in VBA?",
              .Options = New String() {"Workbook_Open", "Workbook_Start", "Workbook_Load", "Workbook_Activate"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which keyword is used to define a procedure that returns a value?",
              .Options = New String() {"Function", "Sub", "Return", "Procedure"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which Excel VBA object is used to refer to a cell range?",
              .Options = New String() {"Worksheet", "Workbook", "Range", "Cell"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you comment a single line of code in VBA?",
              .Options = New String() {"//", "#", "%", "'"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What keyword would you use to start error handling in VBA?",
              .Options = New String() {"Try", "On Error", "Catch", "Throw"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the maximum number of dimensions an array can have in VBA?",
              .Options = New String() {"1", "10", "40", "60"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following is the correct syntax for an `If` statement in VBA?",
              .Options = New String() {"If (condition) Then {statements}", "If condition Then", "If condition {statements}", "If (condition) {statements}"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function in VBA is used to return a random number between 0 and 1?",
              .Options = New String() {"Random", "Rnd", "Rand", "Randomize"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to convert a string to uppercase in VBA?",
              .Options = New String() {"Upper", "ToUpper", "UCase", "StringUpper"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to delete a worksheet in VBA?",
              .Options = New String() {"Worksheets.Remove", "Worksheets.Delete", "Worksheets.Clear", "Worksheets.Drop"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the result of `6 Mod 4` in VBA?",
              .Options = New String() {"2", "1", "0", "4"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which keyword is used to assign a reference to an object variable?",
              .Options = New String() {"Assign", "Let", "Set", "Ref"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function in VBA converts a string to lowercase?",
              .Options = New String() {"LCase", "Lower", "ToLower", "StringLower"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you declare a dynamic array in VBA?",
              .Options = New String() {"Dim arr() As Type", "Dim arr As Type", "Static arr As Type", "ReDim arr() As Type"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function in VBA is used to display an input box for user input?",
              .Options = New String() {"MsgBox", "InputPrompt", "InputBox", "Prompt"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of the `ReDim` statement in VBA?",
              .Options = New String() {"Reallocate memory for variables", "Resize an array", "Redefine a function", "Rename a variable"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following data types can hold decimal values?",
              .Options = New String() {"Integer", "Long", "Single", "Byte"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which statement would you use to handle specific errors in VBA?",
              .Options = New String() {"On Error Goto", "Catch Error", "If Error", "Trap Error"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of `For Each` in VBA?",
              .Options = New String() {"To loop through every item in a collection", "To execute a loop once", "To create a variable", "To assign a value to an array"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following operators is used for comparison in VBA?",
              .Options = New String() {"?", "==", "*", "="}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function in VBA is used to determine the ASCII value of a character?",
              .Options = New String() {"CharValue", "ASC", "ASCII", "ChrVal"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the file extension for Excel workbooks with macros enabled?",
              .Options = New String() {".xls", ".xlsx", ".xlsm", ".csv"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following keywords is used to return control from a function?",
              .Options = New String() {"Return", "End", "Exit Function", "Close"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What method is used to hide a worksheet in VBA?",
              .Options = New String() {"HideSheet", "Worksheet.Hide", "Sheet.Visible = False", "Worksheet.Invisible"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you define a constant in VBA?",
              .Options = New String() {"Const name As Type = value", "Static name As Type = value", "Dim name As Type = value", "Define name As Type = value"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which keyword is used to declare an array with fixed size?",
              .Options = New String() {"Static", "Fixed", "Dim", "Set"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of `Do Until` in VBA?",
              .Options = New String() {"Executes a loop until the condition is true", "Skips the loop if the condition is false", "Executes a single iteration of a loop", "Waits for an event to occur"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which keyword is used to declare a private variable in VBA?",
              .Options = New String() {"Dim", "Private", "Public", "Const"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of `IsEmpty` function in VBA?",
              .Options = New String() {"To check if a cell contains a formula", "To check if a variable or cell is empty", "To clear a variable", "To empty a cell"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you refer to the last row with data in a column in VBA?",
              .Options = New String() {"Range.End(xlDown)", "Range.Last", "Range.Bottom", "Range.Limit"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does the `Application.Calculation = xlCalculationManual` statement do?",
              .Options = New String() {"Enables automatic calculations", "Disables automatic calculations", "Performs a manual calculation", "Forces recalculation of all formulas"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which object is used to refer to a cell's formatting in VBA?",
              .Options = New String() {"FormatObject", "CellFormat", "Range.Style", "Range.Font"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What function is used to get the current system time in VBA?",
              .Options = New String() {"Now", "Time", "GetTime", "SysTime"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What keyword is used to force a procedure to stop in VBA?",
              .Options = New String() {"Halt", "Stop", "Terminate", "End"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does the `Option Base 1` statement do in VBA?",
              .Options = New String() {"Sets the default lower bound for arrays to 1", "Changes the array size to 1", "Increases the array length", "Adds an option to a form"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which object represents a collection of all worksheets in a workbook?",
              .Options = New String() {"Sheets", "Worksheets", "Workbook", "Workbook.Sheets"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What function would you use to round down a number in VBA?",
              .Options = New String() {"RoundDown", "Floor", "Fix", "Int"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the maximum value an `Integer` variable can hold in VBA?",
              .Options = New String() {"2,147,483,647", "32,767", "65,535", "1,073,741,823"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which event occurs when a worksheet is activated?",
              .Options = New String() {"Worksheet_Activate", "Worksheet_Open", "Worksheet_Load", "Worksheet_Enter"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What function is used to convert a number to a string in VBA?",
              .Options = New String() {"Str", "ToString", "StringConvert", "Val"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you exit a loop in VBA?",
              .Options = New String() {"Exit Loop", "Exit For", "Break For", "Stop Loop"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the purpose of the `With` statement in VBA?",
              .Options = New String() {"To exit a loop", "To perform multiple operations on an object", "To define a range", "To close a procedure"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which data type would you use for a variable to store True or False values?",
              .Options = New String() {"Boolean", "Byte", "Integer", "Long"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which property is used to change the background color of a cell in VBA?",
              .Options = New String() {"Range.BackColor", "Range.Background", "Range.Interior.Color", "Range.Fill.Color"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does `Application.EnableEvents = False` do?",
              .Options = New String() {"Stops all event handlers from executing", "Pauses the code execution", "Disables screen updating", "Disables workbook opening"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you close an open workbook in VBA?",
              .Options = New String() {"Workbook.Close", "CloseWorkbook", "ActiveWorkbook.Shutdown", "Application.Exit"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does `Range(""A1"").Value = """"` do in VBA?",
              .Options = New String() {"Deletes the cell", "Clears the content of the cell", "Sets the formula for the cell", "Hides the cell"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which keyword is used to declare a static variable in VBA?",
              .Options = New String() {"Static", "Fixed", "Const", "Var"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function in VBA is used to return the square root of a number?",
              .Options = New String() {"Sqr", "Sqrt", "Root", "Pow"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What keyword is used to define the data type of a variable?",
              .Options = New String() {"As", "Let", "Set", "Var"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which property is used to get the number of rows in a range?",
              .Options = New String() {"Range.Count", "Range.Rows.Count", "Range.TotalRows", "Range.Size"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to return the remainder of a division operation in VBA?",
              .Options = New String() {"Remainder", "Mod", "DivRem", "Res"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What is the default value of a numeric variable in VBA?",
              .Options = New String() {"0", "1", "Null", "Empty"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which of the following methods is used to copy data from one cell to another?",
              .Options = New String() {"Range.Copy", "Range.Transfer", "Range.Cut", "Range.Move"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to reverse a string in VBA?",
              .Options = New String() {"StrReverse", "ReverseString", "RevStr", "Reverse"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you display a user form in VBA?",
              .Options = New String() {"ShowForm", "UserForm.Show", "Form.Show", "Form.Load"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function is used to remove extra spaces from a string in VBA?",
              .Options = New String() {"Trim", "Remove", "Strip", "Clean"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to select a range of cells in VBA?",
              .Options = New String() {"Range.Pick", "Range.Select", "Range.Highlight", "Range.Get"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which function in VBA converts a value to an integer?",
              .Options = New String() {"CInt", "IntVal", "ToInt", "Convert.ToInteger"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What function is used to return the current row number in VBA?",
              .Options = New String() {"ActiveRow", "RowNumber", "ActiveCell.Row", "Row.Current"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which method is used to insert a row in VBA?",
              .Options = New String() {"Rows.Add", "Rows.Insert", "Rows.New", "InsertRow"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "Which event occurs when a workbook is closed?",
              .Options = New String() {"Workbook_Close", "Workbook_Terminate", "Workbook_End", "Workbook_Shutdown"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "What does the `Exit Sub` statement do in VBA?",
              .Options = New String() {"Exits the procedure immediately", "Stops the program", "Closes the workbook", "Ends a loop"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel VBA", .Text = "How do you enable editing in a protected worksheet in VBA?",
              .Options = New String() {"Worksheet.Edit", "Worksheet.Unprotect", "Worksheet.AllowEdit", "Worksheet.Unlock"}, .CorrectAnswer = 1})

    End Sub
End Module
