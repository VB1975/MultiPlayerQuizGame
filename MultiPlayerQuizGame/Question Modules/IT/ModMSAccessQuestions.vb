Imports MultiPlayerQuizGame.ClsDataStructures

Module ModMSAccessQuestions

    Public Sub MicrosoftAccessQuestions()

        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which object in Access allows you to store and manage data?",
              .Options = New String() {"Query", "Table ", "Form", "Report"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is a primary key in a table?",
              .Options = New String() {"A key that opens the database", "A unique identifier for each record ", "A field that can have duplicate values", "A key that allows multiple records to be joined"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What type of relationship is established when one table's primary key is linked to another table's primary key?",
              .Options = New String() {"One-to-Many", "Many-to-One", "One-to-One ", "Many-to-Many"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which object can be used to create a user interface for data entry?",
              .Options = New String() {"Macro", "Table", "Form ", "Report"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "In Access, which query type is used to retrieve data from one or more tables?",
              .Options = New String() {"Append Query", "Update Query", "Select Query ", "Delete Query"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which datatype is used to store long text in Access?",
              .Options = New String() {"Memo ", "Short Text", "Number", "Currency"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the ""Compact And Repair"" tool in Access do?",
              .Options = New String() {"Converts the database to another format", "Shrinks and repairs the database ", "Deletes unused tables", "Imports data from external sources"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT an Access object?",
              .Options = New String() {"Table", "Query", "Workbook ", "Form"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How do you enforce referential integrity between two tables?",
              .Options = New String() {"By creating an index", "By setting up a relationship between primary and foreign keys ", "By using a lookup field", "By creating a macro"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the maximum number of characters a Short Text field can hold in Access?",
              .Options = New String() {"50", "100", "255 ", "512"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which query type allows you to delete records from a table?",
              .Options = New String() {"Make-Table Query", "Delete Query ", "Crosstab Query", "Select Query"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object can be used to display summarized data in a printable format?",
              .Options = New String() {"Table", "Form", "Report ", "Macro"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the Lookup Wizard in Access do?",
              .Options = New String() {"It creates a relationship between tables", "It creates a drop-down list of values for a field ", "It creates a backup of the database", "It adds new fields to a table"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is a foreign key?",
              .Options = New String() {"A key from a foreign database", "A key that uniquely identifies each record in a table", "A field in one table that refers to the primary key in another table ", "A key used to open a secured database"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which view allows you to see the structure of a table in Access?",
              .Options = New String() {"Datasheet View", "Design View ", "Report View", "Layout View"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which action can a form button NOT perform?",
              .Options = New String() {"Open a report", "Close the database", "Delete a table ", "Run a query"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of a Crosstab Query in Access?",
              .Options = New String() {"To create a new table", "To delete records", "To summarize data with aggregates ", "To update records"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which function is used to calculate the sum of a field in a query?",
              .Options = New String() {"SUM() ", "COUNT()", "AVERAGE()", "MIN()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which property ensures that a field must have a value in Access?",
              .Options = New String() {"Validation Text", "Indexed", "Required ", "Default Value"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which object is used to automate tasks in Access?",
              .Options = New String() {"Macro ", "Query", "Report", "Table"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which key do you press to save changes to a table in Design View?",
              .Options = New String() {"F2", "F5", "Ctrl + S ", "Shift + F12"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the default file extension for an Access 2016 database?",
              .Options = New String() {".accdb ", ".mdb", ".xls", ".dbf"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How can you remove a relationship between two tables?",
              .Options = New String() {"Delete the primary key", "Delete the foreign key", "Delete the relationship line in the Relationships window ", "Delete one of the tables"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which view allows you to enter data directly into a table in Access?",
              .Options = New String() {"Design View", "Form View", "Datasheet View ", "PivotChart View"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of the Expression Builder in Access?",
              .Options = New String() {"To build SQL queries", "To create complex expressions for queries and forms ", "To design tables", "To automate database tasks"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which data type is best suited for storing currency values in Access?",
              .Options = New String() {"Number", "Currency ", "Short Text", "AutoNumber"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which feature in Access allows you to filter records based on specific criteria?",
              .Options = New String() {"Sort", "Filter by Form ", "Find", "Group"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object allows you to store the result of a query in a new table?",
              .Options = New String() {"Select Query", "Append Query", "Make-Table Query ", "Update Query"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the “ & ” operator do in an Access query?",
              .Options = New String() {"Multiplies two numbers", "Adds two numbers", "Concatenates two strings ", "Divides two numbers"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the main use of the AutoNumber data type?",
              .Options = New String() {"To store text data", "To generate a unique number automatically ", "To create a foreign key", "To count records in a table"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a valid data type in Access?",
              .Options = New String() {"Number", "Date/Time", "Picture ", "Hyperlink"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does an Append Query do in Access?",
              .Options = New String() {"It appends data to a table from another table or query ", "It deletes records from a table", "It updates records in a table", "It creates a new table with appended data"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is a valid date format in Access?",
              .Options = New String() {"DD-MM-YYYY", "YYYY-MM-DD ", "MM/YY/DD", "YY-MM-DD"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which command is used to create a copy of the database structure and data?",
              .Options = New String() {"Save As", "Compact and Repair", "Backup Database ", "Export"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "In Access, which control is used to add a title to a form or report?",
              .Options = New String() {"Text Box", "Label ", "Combo Box", "Check Box"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is a valid option for setting field properties in Access?",
              .Options = New String() {"Table View", "Form View", "Design View ", "Print Preview"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How do you create a relationship between two tables in Access?",
              .Options = New String() {"By linking fields in Design View", "By using the Relationships window ", "By writing SQL code", "By creating a query"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object can be linked to multiple tables?",
              .Options = New String() {"Macro", "Form", "Query ", "Report"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is used to enforce data integrity in a database?",
              .Options = New String() {"Foreign Key ", "Lookup Field", "Expression Builder", "Pivot Table"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which type of relationship is commonly used to link a primary key to a foreign key?",
              .Options = New String() {"One-to-One", "Many-to-Many", "One-to-Many ", "Many-to-One"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is a ""bound"" control in an Access form?",
              .Options = New String() {"A control linked to a specific field in a table ", "A control not linked to any field", "A control used to create a report", "A control used to automate tasks"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a section of an Access report?",
              .Options = New String() {"Report Header", "Page Footer", "Detail", "Table Footer "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of these actions can you NOT perform with an update query in Access?",
              .Options = New String() {"Modify existing records", "Change data in multiple fields", "Insert new records ", "Use expressions to calculate new values"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of setting a field as ""Indexed""?",
              .Options = New String() {"To allow duplicate values in the field", "To speed up searches and queries on the field ", "To create a primary key", "To prevent the field from being used in a relationship"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following file formats can you NOT import directly into Access?",
              .Options = New String() {"Excel (.xls, .xlsx)", "CSV (.csv)", "Word Document (.docx) ", "XML (.xml)"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which option allows you to create a summary of data in Access?",
              .Options = New String() {"Filter", "Sort", "Group By ", "Query"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the function of a subform in Access?",
              .Options = New String() {"To create a complex query", "To display related data from another table ", "To filter records", "To automate tasks"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What type of query is used to add new records to an existing table?",
              .Options = New String() {"Select Query", "Append Query ", "Update Query", "Delete Query"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a valid field type in Access?",
              .Options = New String() {"Yes/No", "Date/Time", "Rich Text ", "OLE Object"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How can you create a calculated field in a query?",
              .Options = New String() {"By using an expression in the Criteria row", "By using an expression in the Field row ", "By using an expression in the Sort row", "By using an expression in the Table row"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object is primarily used to present data in a printable format?",
              .Options = New String() {"Table", "Query", "Form", "Report "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the ""AND"" operator do in a query?",
              .Options = New String() {"Combines two tables", "Returns records where both conditions are true ", "Returns records where either condition is true", "Adds two fields together"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following properties must be unique for each record in a table?",
              .Options = New String() {"Foreign Key", "Primary Key ", "Indexed", "Required"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of these actions can you perform in Datasheet View?",
              .Options = New String() {"Modify table structure", "Enter data directly into the table ", "Create relationships between tables", "Create a new query"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object can be used to automate repetitive tasks?",
              .Options = New String() {"Macro ", "Table", "Query", "Form"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which data type should you use for a field that stores phone numbers?",
              .Options = New String() {"Number", "Short Text ", "Currency", "Date/Time"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of a validation rule in Access?",
              .Options = New String() {"To allow only unique values in a field", "To prevent users from entering invalid data ", "To create a foreign key", "To define the primary key"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How do you apply a filter to a form in Access?",
              .Options = New String() {"By creating a query", "By using the Filter by Form command ", "By editing the table structure", "By using a subform"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which query type allows you to summarize data with totals, averages, or counts?",
              .Options = New String() {"Crosstab Query ", "Delete Query", "Update Query", "Make-Table Query"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which command in Access is used to run a query and view the results?",
              .Options = New String() {"Save", "Run ", "Export", "Filter"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which property can be set to prevent a user from leaving a field blank?",
              .Options = New String() {"Indexed", "Required ", "Validation Rule", "Format"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which data type should be used for a field that stores dates?",
              .Options = New String() {"Short Text", "Number", "Date/Time ", "OLE Object"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is a query in Access?",
              .Options = New String() {"A way to enter data into a table", "A method for sorting and filtering data", "A way to retrieve and manipulate data from one or more tables ", "A way to print reports"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following cannot be set as a primary key?",
              .Options = New String() {"A field with unique values", "A field with duplicate values ", "An AutoNumber field", "A field with no null values"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of these options allows you to ensure data accuracy in Access?",
              .Options = New String() {"Primary Key", "Validation Rule ", "Lookup Wizard", "Datasheet View"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following views allows you to change the layout of a report in Access?",
              .Options = New String() {"Design View", "Print Preview", "Layout View ", "Datasheet View"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of an input mask in Access?",
              .Options = New String() {"To format the way data is displayed ", "To apply a filter to data", "To automate data entry", "To validate data"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a valid Access database file extension?",
              .Options = New String() {".accdb", ".mdb", ".xlsx ", ".accde"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How do you create a new form in Access?",
              .Options = New String() {"By using the Form Wizard ", "By writing SQL code", "By creating a new table", "By creating a new report"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT an aggregate function in Access?",
              .Options = New String() {"SUM", "COUNT", "AVERAGE", "CONCATENATE "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the ""Like"" operator do in a query?",
              .Options = New String() {"It filters data based on a pattern match ", "It sorts data in ascending order", "It calculates totals", "It groups data by a specific field"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which command allows you to save a query as a new object?",
              .Options = New String() {"Save As ", "Run", "Close", "Export"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which tool in Access helps you find duplicate records in a table?",
              .Options = New String() {"Find Duplicates Query Wizard ", "Compact and Repair", "Lookup Wizard", "Expression Builder"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is a subreport in Access?",
              .Options = New String() {"A report within a report ", "A query used in a report", "A macro that runs with a report", "A form that opens a report"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How do you create a calculated control in a form?",
              .Options = New String() {"Use an expression in the Control Source property ", "Create a query first", "Add a new field to the table", "Create a macro"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the Validation Text property do in Access?",
              .Options = New String() {"It specifies the format of the data", "It displays a message when data violates a validation rule ", "It creates a default value for a field", "It enforces referential integrity"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a type of query in Access?",
              .Options = New String() {"Select Query", "Update Query", "Crosstab Query", "Insert Query "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the default view when you open a table in Access?",
              .Options = New String() {"Design View", "Layout View", "Datasheet View ", "PivotTable View"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which field property controls the maximum length of data that can be entered in a field?",
              .Options = New String() {"Format", "Indexed", "Field Size ", "Caption"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is a split form in Access?",
              .Options = New String() {"A form that contains two subforms", "A form that allows you to view data in two views simultaneously ", "A form with a split window", "A form used for data entry only"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of these can be used to create a calculated field in a query?",
              .Options = New String() {"Expression Builder ", "Lookup Wizard", "Design View", "Macro Builder"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object is used to format and print data?",
              .Options = New String() {"Table", "Form", "Query", "Report "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How do you enforce a one-to-many relationship in Access?",
              .Options = New String() {"By setting a field as indexed", "By creating a relationship between a primary key and a foreign key ", "By creating a unique constraint", "By using a Crosstab Query"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which tool in Access allows you to create a report based on a query or table?",
              .Options = New String() {"Form Wizard", "Expression Builder", "Report Wizard ", "Macro Builder"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a section in a form or report?",
              .Options = New String() {"Detail", "Page Header", "Group Footer", "Table Header "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which Access object is used to store the structure of a database?",
              .Options = New String() {"Query", "Macro", "Table ", "Report"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of these is a way to add new fields to a table in Access?",
              .Options = New String() {"Using the Design View ", "Using the Report Wizard", "Using a query", "Using the Filter by Form"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of the ""Totals"" row in a query?",
              .Options = New String() {"To delete records", "To sort records", "To perform aggregate calculations ", "To filter records"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which tool allows you to view the underlying SQL code of a query?",
              .Options = New String() {"Design View", "SQL View ", "Datasheet View", "Form View"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is used to join two tables on a common field?",
              .Options = New String() {"Filter", "Relationship ", "Macro", "Report"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which command would you use to export data from Access to Excel?",
              .Options = New String() {"Export Wizard ", "Import Wizard", "Save As", "Compact and Repair"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What does the ""Is Null"" criterion do in a query?",
              .Options = New String() {"Filters records with non-empty fields", "Filters records where the field value is null ", "Filters records with zero values", "Filters records with blank spaces"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the purpose of a Lookup field in Access?",
              .Options = New String() {"To perform calculations", "To store multiple values in a field", "To allow the user to select a value from a list ", "To create a relationship between tables"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which command allows you to create a backup of an Access database?",
              .Options = New String() {"Save As", "Backup Database ", "Compact and Repair", "Export"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following is NOT a function available in Access?",
              .Options = New String() {"SUM", "AVG", "MAX", "MERGE "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "How can you modify the design of an existing table?",
              .Options = New String() {"By using Datasheet View", "By using Design View ", "By using Print Preview", "By using Form View"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which field property ensures that values are unique in Access?",
              .Options = New String() {"Required", "Indexed ", "Default Value", "Field Size"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "What is the maximum size of a single field in a table in Access?",
              .Options = New String() {"64 KB", "255 characters ", "2 MB", "1 GB"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of these commands allows you to change the data in an existing table?",
              .Options = New String() {"Select Query", "Update Query ", "Delete Query", "Make-Table Query"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Microsoft Access", .Text = "Which of the following can be used to visually represent data in Access?",
              .Options = New String() {"Macro", "Report ", "Table", "Query"}, .CorrectAnswer = 1})


    End Sub
End Module
