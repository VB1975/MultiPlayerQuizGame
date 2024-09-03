Imports MultiPlayerQuizGame.ClsDataStructures

Module ModVBDotNetQuestions

    Public Sub VBDotNetQuestions()

        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What does ""VB"" in VB.NET stand for?",
              .Options = New String() {"Visual Basic ", "Virtual Basic", "Variable Base", "Visual Byte"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What type of language is VB.NET?",
              .Options = New String() {"Functional", "Object-Oriented ", "Procedural", "Assembly"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which data type would you use to store a True/False value in VB.NET?",
              .Options = New String() {"Integer", "Boolean ", "String", "Char"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which keyword is used to declare a variable in VB.NET?",
              .Options = New String() {"declare", "set", "Dim ", "define"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you create a comment in VB.NET?",
              .Options = New String() {"//", "#", "/*", "' "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which keyword is used to create a new object in VB.NET?",
              .Options = New String() {"Make", "New ", "Create", "Build"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct syntax to create a class in VB.NET?",
              .Options = New String() {"Create MyClass", "New Class MyClass", "Class MyClass ", "Define MyClass"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you handle exceptions in VB.NET?",
              .Options = New String() {"using try...catch ", "using check...rescue", "using do...while", "using begin...end"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the extension for a VB.NET file?",
              .Options = New String() {".vbn", ".vb ", ".net", ".cs"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which method is used to output text to the console in VB.NET?",
              .Options = New String() {"Print", "Write", "Console.WriteLine ", "Echo"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare an array in VB.NET?",
              .Options = New String() {"Dim arr() As Integer ", "Array arr", "Set arr() As Integer", "Array arr()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is a loop construct in VB.NET?",
              .Options = New String() {"for...next ", "do...until", "while...next", "until...do"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you define a subroutine in VB.NET?",
              .Options = New String() {"Function subName()", "Sub subName() ", "Method subName()", "Define subName()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to declare a constant in VB.NET?",
              .Options = New String() {"Dim PI As Double = 3.14", "Const PI As Double = 3.14 ", "Let PI As Double = 3.14", "Define PI As Double = 3.14"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Imports"" statement in VB.NET?",
              .Options = New String() {"Import DLL files", "Include namespaces ", "Load plugins", "Define variables"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct syntax for a conditional statement in VB.NET?",
              .Options = New String() {"if x = 10 then...else ", "if x == 10 then...else", "if (x = 10) {...}", "if (x == 10) {...}"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you convert a string to an integer in VB.NET?",
              .Options = New String() {"ToInt32(string)", "Integer.Parse(string) ", "ConvertToInt(string)", "string.ToInt()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is a valid way to declare an interface in VB.NET?",
              .Options = New String() {"Interface IMyInterface ", "Define IMyInterface", "Create IMyInterface", "New IMyInterface"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the base class from which all VB.NET classes inherit?",
              .Options = New String() {"System", "System.Base", "Object ", "BaseClass"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which method is used to read input from the console in VB.NET?",
              .Options = New String() {"Console.ReadLine ", "Console.Input", "Console.Read", "Console.GetInput"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you exit a loop prematurely in VB.NET?",
              .Options = New String() {"Exit Loop", "Break", "Exit For ", "End Loop"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What keyword is used to define an enumeration in VB.NET?",
              .Options = New String() {"enum", "Enum ", "enumeration", "SetEnum"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the default access modifier for a class in VB.NET?",
              .Options = New String() {"Private", "Public ", "Protected", "Friend"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What does the ""Shared"" keyword do in VB.NET?",
              .Options = New String() {"Makes a method or property accessible only within a class", "Creates a static member ", "Allows inheritance", "Makes a variable constant"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Overridable"" keyword in VB.NET?",
              .Options = New String() {"To override a class", "To allow a method to be overridden in a derived class ", "To prevent a method from being overridden", "To inherit a method"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is a valid declaration for a property in VB.NET?",
              .Options = New String() {"Property MyProperty As Integer ", "Get MyProperty As Integer", "Declare MyProperty As Integer", "Define MyProperty As Integer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a two-dimensional array in VB.NET?",
              .Options = New String() {"Dim arr(,) As Integer ", "Dim arr[]() As Integer", "Dim arr[][] As Integer", "Dim arr(,,) As Integer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Friend"" keyword in VB.NET?",
              .Options = New String() {"To create a method that can be accessed anywhere", "To define a member that can be accessed within the same assembly ", "To create a private method", "To create a protected method"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is NOT a loop structure in VB.NET?",
              .Options = New String() {"Do...While", "For...Next", "While...Wend", "For...Until "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which method is used to terminate an application in VB.NET?",
              .Options = New String() {"End", "Stop", "Application.Exit ", "Exit()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you handle multiple exceptions in VB.NET?",
              .Options = New String() {"Multiple try blocks", "Try...Catch...Finally", "Multiple catch blocks ", "try...handle"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the default value of an uninitialized Boolean variable in VB.NET?",
              .Options = New String() {"True", "False ", "Null", "Undefined"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a generic class in VB.NET?",
              .Options = New String() {"Class MyClass(Of T) ", "Generic Class MyClass", "Template MyClass", "Class MyClass<T>"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is a correct way to perform a case-insensitive comparison of strings in VB.NET?",
              .Options = New String() {"string1 = string2", "String.Compare(string1, string2, True) ", "String.Equals(string1, string2, False)", "string1.ToUpper() = string2.ToUpper()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""MustInherit"" keyword in VB.NET?",
              .Options = New String() {"To create an interface", "To enforce method inheritance", "To declare an abstract class ", "To declare a final class"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which method would you use to format a string in VB.NET?",
              .Options = New String() {"String.Format ", "String.Compose", "String.ToString", "String.Print"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you concatenate two strings in VB.NET?",
              .Options = New String() {"Using +", "Using &&", "Using && or + ", "Using ++"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Me"" keyword in VB.NET?",
              .Options = New String() {"Refers to the current instance of the class ", "Refers to the base class", "Refers to the parent object", "Refers to a static method"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following can be used to iterate over a collection in VB.NET?",
              .Options = New String() {"while", "foreach", "for each...next ", "loop...next"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you implement a destructor in VB.NET?",
              .Options = New String() {"Using the `Destroy` method", "Using the `Finalize` method ", "Using the `Dispose` method", "Using the `Destructor` method"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the use of the ""With"" statement in VB.NET?",
              .Options = New String() {"To create a new object", "To define multiple variables", "To simplify repeated access to an object's members ", "To initialize a loop"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following methods is used to start a thread in VB.NET?",
              .Options = New String() {"Thread.Start ", "Thread.Begin", "Thread.Create", "Thread.Run"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What keyword is used to declare a function in VB.NET?",
              .Options = New String() {"func", "Sub", "Def", "Function "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you perform an explicit cast in VB.NET?",
              .Options = New String() {"CInt(value) ", "Cast(value)", "Convert(value)", "ToInt(value)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""NotInheritable"" keyword in VB.NET?",
              .Options = New String() {"To prevent a method from being inherited", "To prevent a class from being inherited ", "To create an abstract class", "To override a method"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to declare a structure in VB.NET?",
              .Options = New String() {"Define MyStructure", "Struct MyStructure", "Structure MyStructure ", "Create MyStructure"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the use of the ""Overloads"" keyword in VB.NET?",
              .Options = New String() {"To inherit methods", "To override a method", "To define multiple methods with the same name but different parameters ", "To handle exceptions"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to declare a delegate in VB.NET?",
              .Options = New String() {"Delegate Sub MyDelegate() ", "Declare MyDelegate()", "Define Delegate MyDelegate", "Delegate MyDelegate()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a read-only property in VB.NET?",
              .Options = New String() {"Using the `Private` keyword", "Using the `Get` keyword only ", "Using the `Set` keyword only", "Using the `Const` keyword"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Handles"" keyword in VB.NET?",
              .Options = New String() {"To create event handlers ", "To manage memory", "To create loops", "To import namespaces"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you raise an event in VB.NET?",
              .Options = New String() {"Call MyEvent()", "Trigger MyEvent()", "RaiseEvent MyEvent() ", "Execute MyEvent()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following keywords is used to define an overloaded operator in VB.NET?",
              .Options = New String() {"overload", "operator ", "newoperator", "redefine"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you prevent a method from being overridden in VB.NET?",
              .Options = New String() {"Using the `Overloads` keyword", "Using the `MustInherit` keyword", "Using the `NotOverridable` keyword ", "Using the `Final` keyword"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""IsNothing"" function in VB.NET?",
              .Options = New String() {"To check if a variable is empty", "To check if a variable is null ", "To initialize a variable", "To convert a variable to null"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to declare an abstract method in VB.NET?",
              .Options = New String() {"Sub MyMethod() Abstract", "MustOverride Sub MyMethod() ", "Overridable Sub MyMethod()", "Abstract Sub MyMethod()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""TryCast"" keyword in VB.NET?",
              .Options = New String() {"To attempt to cast an object to a specific type ", "To handle exceptions", "To raise events", "To override methods"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the default value of an uninitialized integer variable in VB.NET?",
              .Options = New String() {"1", "-1", "0 ", "Null"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a nullable type in VB.NET?",
              .Options = New String() {"Dim value? As Integer ", "Dim value* As Integer", "Dim value As Nullable Integer", "Dim value As Integer?"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Partial"" keyword in VB.NET?",
              .Options = New String() {"To define a partial class or method across multiple files ", "To create an abstract class", "To define a static method", "To inherit methods"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you convert a string to uppercase in VB.NET?",
              .Options = New String() {"string.ToUpperCase()", "UCase(string) ", "UpperCase(string)", "string.Upper()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to handle resources that need to be released in VB.NET?",
              .Options = New String() {"Using the `Dispose` method ", "Using the `Release` method", "Using the `Free` method", "Using the `Close` method"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct syntax for an `If...ElseIf...Else` statement in VB.NET?",
              .Options = New String() {"If x > 10 Then ... ElseIf x = 10 Then ... Else ... ", "If (x > 10) { ... } Else If (x = 10) { ... } Else { ... }", "If x > 10 : ElseIf x = 10 : Else :", "If x > 10, ElseIf x = 10, Else"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you implement an interface in VB.NET?",
              .Options = New String() {"`Implements` keyword ", "`Extends` keyword", "`Inherits` keyword", "`Includes` keyword"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct syntax for a `Select Case` statement in VB.NET?",
              .Options = New String() {"Select x Case 1: ...", "Switch x Case 1: ...", "Case x Select 1: ...", "Select Case x Case 1: ... "}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the use of the ""Await"" keyword in VB.NET?",
              .Options = New String() {"To wait for a task to complete asynchronously ", "To pause a thread", "To create a delay", "To handle events"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you define an asynchronous method in VB.NET?",
              .Options = New String() {"Function MyMethod() Async As Task ", "Async Function MyMethod() As Task", "Task MyMethod() Async", "Function MyMethod() As Task Async"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Yield"" keyword in VB.NET?",
              .Options = New String() {"To return multiple values from a method ", "To stop a loop", "To wait for a condition", "To pause a thread"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a string variable in VB.NET?",
              .Options = New String() {"Dim str As String ", "Declare str As String", "Set str As String", "Var str As String"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to create an instance of a class in VB.NET?",
              .Options = New String() {"MyClass obj = New MyClass()", "Dim obj As New MyClass() ", "New obj = MyClass()", "obj = MyClass.New()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What does the ""Nothing"" keyword represent in VB.NET?",
              .Options = New String() {"A null value ", "An empty string", "An uninitialized variable", "A zero value"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to declare a private method in VB.NET?",
              .Options = New String() {"Method MyMethod() Private", "Private Sub MyMethod() ", "Sub Private MyMethod()", "MyMethod() Private"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you perform string interpolation in VB.NET?",
              .Options = New String() {"String.Format(""Hello, {0}"", name)", "String.Interpolate(""Hello, {name}"")", "$""Hello, {name}"" ", "Interpolate(""Hello, {name}"")"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""ByVal"" keyword in VB.NET?",
              .Options = New String() {"To pass a reference to a method", "To pass a value to a method ", "To declare a variable", "To return a value from a method"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a public variable in VB.NET?",
              .Options = New String() {"Dim myVar As Public Integer", "Public myVar As Integer ", "Declare myVar As Public Integer", "Set myVar As Public Integer"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to catch an exception in VB.NET?",
              .Options = New String() {"Try...Catch...End Try ", "Try...Handle...End Try", "Try...Error...End Try", "Try...Finally...End Try"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Optional"" keyword in VB.NET?",
              .Options = New String() {"To define a method with no parameters", "To specify that a parameter is optional ", "To allow a method to return multiple values", "To define a nullable parameter"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare an event in VB.NET?",
              .Options = New String() {"Declare Event MyEvent()", "Event MyEvent() ", "Sub MyEvent()", "Create Event MyEvent()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to convert an integer to a string in VB.NET?",
              .Options = New String() {"CStr(value) ", "ConvertToString(value)", "IntToStr(value)", "value.ToString()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Inherits"" keyword in VB.NET?",
              .Options = New String() {"To inherit a class ", "To create an interface", "To implement an interface", "To declare a base class"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you define a read-only variable in VB.NET?",
              .Options = New String() {"ReadOnly myVar As Integer ", "Const myVar As Integer", "Set myVar As Integer", "Private myVar As Integer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to declare an array of integers in VB.NET?",
              .Options = New String() {"Dim arr(10) As Integer ", "Array arr(10) As Integer", "Dim arr As Integer[10]", "Dim arr() As Integer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct syntax for a `Do...Loop` statement in VB.NET?",
              .Options = New String() {"Do...End Do", "Do...Loop Until ", "Loop...End Loop", "While...Loop"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a subroutine in VB.NET?",
              .Options = New String() {"Sub MySub() ", "Routine MySub()", "Declare MySub()", "Void MySub()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Get"" keyword in VB.NET?",
              .Options = New String() {"To define a read-only property ", "To declare a variable", "To retrieve data from a database", "To define a constant"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to define a constructor in VB.NET?",
              .Options = New String() {"Sub New() ", "Constructor()", "Init()", "Function New()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to declare a variable in VB.NET?",
              .Options = New String() {"Var myVar As Integer", "Set myVar As Integer", "Dim myVar As Integer ", "Declare myVar As Integer"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you handle null values in VB.NET?",
              .Options = New String() {"If IsNull(value) Then", "If value Is Nothing Then ", "If value = Null Then", "If IsNothing(value) Then"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to create a singleton class in VB.NET?",
              .Options = New String() {"Private Sub New()", "Private Shared Instance As New MyClass() ", "Public Shared Sub GetInstance()", "Public Sub GetInstance()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you specify that a method does not return a value in VB.NET?",
              .Options = New String() {"Void", "Sub ", "None", "Return"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare a variable with a specific data type in VB.NET?",
              .Options = New String() {"Dim myVar As String ", "Var myVar As String", "Define myVar As String", "Set myVar As String"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to define a destructor in VB.NET?",
              .Options = New String() {"Sub Finalize() ", "Sub Destructor()", "Sub Destroy()", "Sub Terminate()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Overridable"" keyword in VB.NET?",
              .Options = New String() {"To declare a method that can be overridden in a derived class ", "To override a method in a base class", "To prevent a method from being overridden", "To declare a static method"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the correct way to implement inheritance in VB.NET?",
              .Options = New String() {"Implements MyBase", "Inherits MyBase ", "Extends MyBase", "Includes MyBase"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you declare an optional parameter in VB.NET?",
              .Options = New String() {"Dim param As Integer = 0", "Optional param As Integer = 0 ", "Param param As Integer = 0", "Set param As Integer = 0"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""AndAlso"" operator in VB.NET?",
              .Options = New String() {"To combine multiple conditions ", "To perform bitwise AND", "To terminate a loop", "To handle exceptions"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you define a static method in VB.NET?",
              .Options = New String() {"Sub MyMethod() Static", "Static Sub MyMethod()", "Shared Sub MyMethod() ", "Sub MyMethod() Shared"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "How do you round a number to the nearest integer in VB.NET?",
              .Options = New String() {"Round(number)", "Math.Round(number) ", "number.ToRound()", "number.Round()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "What is the purpose of the ""Exit"" statement in VB.NET?",
              .Options = New String() {"To terminate a program", "To exit a loop or procedure early ", "To close a form", "To end a conditional block"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to concatenate two strings in VB.NET?",
              .Options = New String() {"str1 + str2", "str1 && str2", "concat(str1, str2)", "str1.Append(str2)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "VB.NET", .Text = "Which of the following is the correct way to initialize a list of integers in VB.NET?",
              .Options = New String() {"Dim numbers As List(Of Integer) = New List()", "Dim numbers As New List(Of Integer) ", "Dim numbers As List = New List(Of Integer)", "Dim numbers As List(Integer) = New List()"}, .CorrectAnswer = 1})

    End Sub
End Module
