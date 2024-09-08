Imports MultiPlayerQuizGame.ClsDataStructures
Module ModMicrosoftExcelQuestions

    Public Sub MicrosoftExcelQuestions()

        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the default file extension for an Excel workbook?",
              .Options = New String() {".xlsx ", ".xls", ".csv", ".xml"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to find the sum of a range of cells?",
                      .Options = New String() {"AVERAGE", "MAX", "SUM ", "COUNT"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the PMT function calculate?",
                      .Options = New String() {"Principal amount", "Monthly payment on a loan ", "Profit margin total", "Present value"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which symbol is used to start a formula in Excel?",
                      .Options = New String() {"$", "@", "= ", "#"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function will return the current date and time?",
                      .Options = New String() {"TODAY()", "DATE()", "NOW() ", "TIME()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following is NOT a type of chart in Excel?",
                      .Options = New String() {"Line", "Pie", "Radar", "Histogram "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut key for saving a workbook?",
                      .Options = New String() {"Ctrl + S ", "Ctrl + C", "Ctrl + Z", "Ctrl + P"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function returns the number of characters in a text string?",
                      .Options = New String() {"LEFT", "MID", "LEN ", "TRIM"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you insert a new worksheet in an Excel workbook?",
                      .Options = New String() {"Alt + F", "Ctrl + N", "Shift + F11 ", "Ctrl + Shift + N"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the VLOOKUP function do?",
                      .Options = New String() {"Looks for a value in the first column of a range and returns a value in the same row from another column ", "Searches for a value horizontally in a range", "Returns the largest value in a range", "Combines text from multiple cells"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which key combination is used to lock cell references in formulas?",
                      .Options = New String() {"Ctrl + $", "Alt + F4", "F4 ", "Ctrl + Shift + L"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function will return the minimum value in a range?",
                      .Options = New String() {"MAX", "AVERAGE", "MIN ", "COUNT"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How can you quickly copy a formula down a column?",
                      .Options = New String() {"Drag the fill handle ", "Press Ctrl + C and Ctrl + V", "Use the Copy Formula tool", "Click and hold the Shift key"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to combine text from two or more cells?",
                      .Options = New String() {"CONCATENATE ", "TEXTJOIN", "MERGE", "SPLIT"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which tool is used to create a chart?",
                      .Options = New String() {"Data Analysis", "PivotTable", "Chart Wizard ", "Solver"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the COUNT function do?",
                      .Options = New String() {"Counts the number of cells that contain numbers ", "Counts the total number of characters in a range", "Counts the number of empty cells in a range", "Counts the number of cells with text"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you remove duplicate values from a range?",
                      .Options = New String() {"Use the Remove Duplicates tool ", "Sort and delete duplicates manually", "Use the Filter function", "Apply conditional formatting"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function can be used to round a number to a specified number of digits?",
                      .Options = New String() {"TRUNC", "ROUND ", "CEILING", "FLOOR"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut for opening the Format Cells dialog box?",
                      .Options = New String() {"Ctrl + 1 ", "Ctrl + 2", "Ctrl + Shift + F", "Ctrl + F1"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function returns the day of the week for a given date?",
                      .Options = New String() {"DATE", "DAY", "WEEKDAY ", "TODAY"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the purpose of a PivotTable?",
                      .Options = New String() {"To sort and filter data", "To create dynamic summary reports ", "To visualize data", "To enter raw data"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which key combination will allow you to edit the active cell?",
                      .Options = New String() {"F1", "F2 ", "Ctrl + E", "Alt + Enter"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function checks whether a condition is met, and returns one value if TRUE and another if FALSE?",
                      .Options = New String() {"OR", "AND", "IF ", "XOR"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How can you remove all the formatting in a cell?",
                      .Options = New String() {"Press Ctrl + R", "Use the Clear Formats option ", "Apply the default style", "Manually remove each format"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut for inserting a new row?",
                      .Options = New String() {"Ctrl + R", "Ctrl + Shift + + ", "Ctrl + Alt + I", "Ctrl + N"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function returns the largest value in a range?",
                      .Options = New String() {"SUM", "MAX ", "MIN", "COUNT"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you create a named range?",
                      .Options = New String() {"Use the Name Box ", "Use the Insert Function tool", """Press Ctrl + N""", "Right-click and choose ""Create Range"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following functions can be used to lookup and retrieve data from a table?",
                      .Options = New String() {"FIND", "LOOKUP ", "TEXT", "LEFT"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the CONCAT function do?",
                      .Options = New String() {"Combines text from multiple ranges and/or strings ", "Concatenates numbers into a sum", "Extracts text from a cell", "Splits text into separate cells"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which feature allows you to apply formatting based on a cell's value?",
                      .Options = New String() {"Data Validation", "Filters", "Conditional Formatting ", "Sparklines"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the IFERROR function do?",
                      .Options = New String() {"Checks for errors in formulas", "Returns a value you specify if a formula evaluates to an error ", "Displays a warning message", "Traces errors in the worksheet"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function will return the current date?",
                      .Options = New String() {"NOW", "DATE", "TODAY ", "TIME"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the purpose of the Freeze Panes option?",
                      .Options = New String() {"To keep specific rows or columns visible while scrolling ", "To lock cells for editing", "To sort data", "To protect the workbook"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which Excel feature allows you to see the result of a formula directly in the cell?",
                      .Options = New String() {"Live Preview", "Formula Auditing", "In-cell editing ", "Cell Trace"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function will count the number of blank cells in a range?",
                      .Options = New String() {"COUNT", "COUNTA", "COUNTBLANK ", "ISBLANK"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the use of the TRIM function?",
                      .Options = New String() {"To trim down the size of a worksheet", "To remove leading and trailing spaces from a text string ", "To shorten a number", "To resize a chart"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How can you group rows in Excel?",
                      .Options = New String() {"Right-click and select Group", "Use the Group tool under the Data tab ", "Apply a filter", "Use the Merge Cells option"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to convert a text string to uppercase?",
                      .Options = New String() {"UPPER ", "LOWER", "PROPER", "TEXT"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut key for copying a cell's value or formula?",
                      .Options = New String() {"Ctrl + C ", "Ctrl + X", "Ctrl + V", "Ctrl + P"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which option would you use to split a worksheet into multiple panes?",
                      .Options = New String() {"Split ", "Group", "Freeze Panes", "Window"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following is a correct syntax for the SUMIF function?",
                      .Options = New String() {"SUMIF(range, criteria, sum_range) ", "SUMIF(criteria, range, sum_range)", "SUMIF(range, sum_range, criteria)", "SUMIF(sum_range, criteria, range)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which chart type is best for showing trends over time?",
                      .Options = New String() {"Pie Chart", "Bar Chart", "Line Chart ", "Scatter Plot"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the COUNTIF function do?",
                      .Options = New String() {"Counts the number of cells in a range that match a certain condition ", "Counts all non-empty cells in a range", "Counts the number of blank cells in a range", "Returns the average of cells that meet a condition"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut for undoing the last action?",
                      .Options = New String() {"Ctrl + Z ", "Ctrl + Y", "Ctrl + U", "Ctrl + X"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function will return the middle part of a text string?",
                      .Options = New String() {"LEFT", "RIGHT", "MID ", "TEXT"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to find the position of a specific character within a text string?",
                      .Options = New String() {"SEARCH ", "FIND", "LOCATE", "POSITION"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you insert a comment in a cell?",
                      .Options = New String() {"Press Ctrl + C", "Right-click the cell and select ""Insert Comment"" ", "Press Alt + C", "Use the Comment function under the Insert tab"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the function of the Data Validation tool?",
                      .Options = New String() {"To format data", "To restrict the type of data that can be entered in a cell ", "To validate formulas", "To protect the worksheet"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following is a correct formula to calculate the average of a range?",
                      .Options = New String() {"=SUM(range)/COUNT(range)", "=AVERAGE(range) ", "=MEAN(range)", "=MEDIAN(range)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the MATCH function do?",
                      .Options = New String() {"Finds a value in a range and returns the position of that value ", "Matches two text strings", "Matches two ranges of cells", "Finds the maximum value in a range"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following functions will return the largest numeric value in a range?",
                      .Options = New String() {"MAX ", "MIN", "LARGE", "HIGH"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the result of the formula =3+2*2?",
                      .Options = New String() {"10", "7 ", "8", "9"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you protect a worksheet from being edited?",
                      .Options = New String() {"Use the Freeze Panes option", "Apply a password in the Protect Sheet option ", "Use the Data Validation tool", "Lock all cells"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to combine multiple cell ranges?",
                      .Options = New String() {"UNION", "CONCATENATE", "CONCAT ", "MERGE"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you apply a filter to a data range?",
                      .Options = New String() {"Use the Filter tool under the Data tab ", "Apply Data Validation", "Use Conditional Formatting", "Use the Sort tool"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function can be used to replace text within a string?",
                      .Options = New String() {"SUBSTITUTE ", "REPLACE", "FIND", "TRIM"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following functions will return the smallest numeric value in a range?",
                      .Options = New String() {"SMALL", "MIN ", "LOW", "TINY"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you hide a column in Excel?",
                      .Options = New String() {"Right-click the column header and choose ""Hide"" ", "Press Ctrl + H", "Use the Hide tool under the View tab", "Select the column and press Delete"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function can be used to remove extra spaces from text?",
                      .Options = New String() {"CLEAN", "TRIM ", "SUBSTITUTE", "REPLACE"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the purpose of the Goal Seek tool?",
                      .Options = New String() {"To find the desired result by changing an input value ", "To solve complex equations", "To analyze data trends", "To validate data"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following is a volatile function in Excel?",
                      .Options = New String() {"VLOOKUP", "IF", "TODAY ", "AVERAGE"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you transpose data in Excel?",
                      .Options = New String() {"Use the Transpose option under Paste Special ", "Use the Rotate tool", "Apply Conditional Formatting", "Use the Transpose function"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to round a number up to the nearest integer?",
                      .Options = New String() {"ROUNDUP ", "ROUNDDOWN", "INT", "CEILING"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which feature allows you to automatically fill cells with data based on a pattern?",
                      .Options = New String() {"Fill Handle ", "AutoComplete", "AutoFill", "Drag and Drop"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which key combination is used to move to the next worksheet tab?",
                      .Options = New String() {"Ctrl + Tab", "Ctrl + Page Down ", "Alt + Tab", "Shift + Tab"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to calculate the internal rate of return for a series of cash flows?",
                      .Options = New String() {"IRR ", "NPV", "ROI", "PAYBACK"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function will return the square root of a number?",
                      .Options = New String() {"POWER", "SQRT ", "ROOT", "ABS"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the SUMPRODUCT function do?",
                      .Options = New String() {"Multiplies corresponding elements in the specified arrays and returns the sum of those products ", "Sums the products of two ranges", "Returns the sum of squared products", "Calculates the average of products in a range"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following functions will return a value based on a logical test?",
                      .Options = New String() {"AND", "OR", "IF ", "NOT"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How can you display the formulas in the cells instead of their results?",
                      .Options = New String() {"Press Ctrl + ` ", "Use the Show Formulas tool under the Formulas tab", "Use the Formula Auditing tool", "Press Alt + F1"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to extract a portion of text from a string, starting from the left?",
                      .Options = New String() {"RIGHT", "MID", "LEFT ", "TEXT"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut for selecting the entire worksheet?",
                      .Options = New String() {"Ctrl + A ", "Ctrl + S", "Ctrl + W", "Ctrl + E"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you remove the contents of a cell without removing the cell itself?",
                      .Options = New String() {"Press Delete ", "Press Ctrl + X", "Press Backspace", "Use the Clear tool"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to calculate the number of periods for an investment?",
                      .Options = New String() {"NPER ", "PV", "FV", "RATE"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you enable macros in Excel?",
                      .Options = New String() {"Go to File > Options > Trust Center ", "Use the Developer tab", "Enable in the View tab", "Press Ctrl + M"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to find the lowest value in a range?",
                      .Options = New String() {"MIN ", "SMALL", "LOW", "FLOOR"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the DATEDIF function calculate?",
                      .Options = New String() {"The difference between two dates ", "The date after a specified number of days", "The current date", "The date before a specified number of days"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following is the correct syntax for the IF function?",
                      .Options = New String() {"=IF(logical_test, value_if_true, value_if_false) ", "=IF(value_if_true, logical_test, value_if_false)", "=IF(logical_test, value_if_false, value_if_true)", "=IF(value_if_true, value_if_false, logical_test)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to calculate the standard deviation of a dataset?",
                      .Options = New String() {"STDEV.P ", "AVERAGE", "VAR.P", "MEDIAN"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the RANDBETWEEN function do?",
                      .Options = New String() {"Generates a random number between two specified values ", "Generates a random number", "Returns a random integer", "Generates a random decimal value"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you activate the Developer tab in Excel?",
                      .Options = New String() {"File > Options > Customize Ribbon ", "Right-click on the ribbon and select ""Developer""", "Go to the View tab and select Developer", "Press Ctrl + D"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which feature allows you to visualize data changes in a cell over time?",
                      .Options = New String() {"Sparklines ", "Conditional Formatting", "Data Validation", "Data Bars"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function is used to return the value of a cell at the intersection of a row and column in a range?",
                      .Options = New String() {"VLOOKUP", "INDEX ", "MATCH", "OFFSET"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you add a comment to a cell?",
                      .Options = New String() {"Right-click the cell and select ""Insert Comment"" ", "Use the Comment function under the Review tab", "Press Alt + Enter", "Use the Data Validation tool"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the RANK function do?",
                      .Options = New String() {"Returns the rank of a number in a list of numbers ", "Returns the position of a text string", "Ranks a text string in alphabetical order", "Calculates the percentile rank"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following is NOT an Excel error message?",
                      .Options = New String() {"#VALUE!", "#DIV/0!", "#ERROR! ", "#REF!"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How can you combine text from multiple cells into one cell?",
                      .Options = New String() {"CONCATENATE ", "COMBINE", "CONCAT", "MERGE"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What is the shortcut key to open the Find and Replace dialog box?",
                      .Options = New String() {"Ctrl + F ", "Ctrl + H", "Ctrl + G", "Ctrl + R"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to determine the monthly payment on a loan?",
                      .Options = New String() {"PMT ", "NPER", "PV", "FV"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which feature allows you to visually summarize data in a table?",
                      .Options = New String() {"PivotTable ", "Chart Wizard", "Sparklines", "Conditional Formatting"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How do you create a hyperlink in Excel?",
                      .Options = New String() {"Use the HYPERLINK function ", "Use the Insert function", "Press Ctrl + H", "Right-click and select ""Hyperlink"""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the INDIRECT function do?",
                      .Options = New String() {"Returns a reference specified by a text string ", "Returns the address of a cell", "Creates an indirect reference", "Returns the value of a cell reference"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function can be used to convert a text string into a number?",
                      .Options = New String() {"VALUE ", "NUMBERVALUE", "TEXT", "CONVERT"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which of the following functions would you use to generate a random decimal number between 0 and 1?",
                      .Options = New String() {"RAND ", "RANDBETWEEN", "ROUND", "RANDOM"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the FIND function do?",
                      .Options = New String() {"Finds the position of a substring within a text string ", "Searches for a value in a range", "Locates a cell reference", "Finds and replaces text"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which key combination allows you to quickly switch between open workbooks?",
                      .Options = New String() {"Ctrl + Tab ", "Ctrl + F6", "Ctrl + Shift + T", "Alt + Tab"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "How can you prevent someone from editing the contents of a cell?",
                      .Options = New String() {"Use the Protect Sheet option ", "Apply Data Validation", "Use the Freeze Panes option", "d) Hide the cell"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to return the absolute value of a number?",
                      .Options = New String() {"ABS ", "ROUND", "SUM", "INT"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "What does the LARGE function do?",
                      .Options = New String() {"Returns the k-th largest value in a data set ", "Returns the largest value in a range", "Returns the sum of the largest values", "Returns the average of the largest values"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Excel", .Text = "Which function would you use to find the number of days between two dates?",
                      .Options = New String() {"DATEDIF ", "DATE", "DAYS", "NOW"}, .CorrectAnswer = 0})

    End Sub
End Module
