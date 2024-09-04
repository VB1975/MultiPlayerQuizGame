Imports MultiPlayerQuizGame.ClsDataStructures

Module ModCSharpQuestions

    Public Sub CSharpQuestions()

        Questions.Add(New Question With {.Category = "C#", .Text = "What is the default value of an uninitialized `int` variable in C#?",
              .Options = New String() {"1", "-1", "0", "null"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is the correct way to declare a constant in C#?",
              .Options = New String() {"int const value = 10;", "const int value = 10;", "value const int = 10;", "final int value = 10;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `static` keyword mean in C#?",
              .Options = New String() {"The method or variable belongs to the instance of the class", "The method or variable can be accessed without creating an instance of the class", "The method or variable is hidden", "The method or variable cannot be accessed outside the class"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of these access modifiers is the most restrictive in C#?",
              .Options = New String() {"private", "protected", "internal", "public"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the purpose of the `using` statement in C#?",
              .Options = New String() {"To include namespaces", "To create loops", "To handle exceptions", "To define a class"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(5 / 2);`?",
              .Options = New String() {"2.5", "3", "2", "2.0"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which type cannot be used as a `Nullable` type in C#?",
              .Options = New String() {"int", "double", "bool", "string"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a value type in C#?",
              .Options = New String() {"class", "struct", "interface", "delegate"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `ref` keyword do in C#?",
              .Options = New String() {"Allows a method to return multiple values", "Passes the parameter by reference", "Creates a reference to an object", "Refers to an external library"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following collections is indexed by a key in C#?",
              .Options = New String() {"Array", "List<T>", "Dictionary<TKey, TValue>", "Queue<T>"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the default access modifier for class members in C#?",
              .Options = New String() {"private", "public", "protected", "internal"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following statements correctly defines a delegate?",
              .Options = New String() {"delegate void MyDelegate(int x);", "void delegate MyDelegate(int x);", "MyDelegate delegate void(int x);", "void MyDelegate(int x);"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to read all lines of a file in C#?",
              .Options = New String() {"File.ReadText()", "File.ReadAllLines()", "File.Read()", "File.GetLines()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which exception is thrown when trying to access an array index that does not exist?",
              .Options = New String() {"NullReferenceException", "IndexOutOfRangeException", "InvalidOperationException", "ArrayTypeMismatchException"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "How do you specify that a method can accept a variable number of parameters?",
              .Options = New String() {"By using the `ref` keyword", "By using the `params` keyword", "By using the `out` keyword", "By using the `in` keyword"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a correct way to declare an array in C#?",
              .Options = New String() {"int[] array = new int[5];", "int array = new int[5];", "array[] int = new int[5];", "int array[5];"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `finally` block do in C#?",
              .Options = New String() {"Executes code when an exception is thrown", "Executes code only if no exceptions are thrown", "Executes code after a `try` block, regardless of whether an exception was thrown", "Skips execution if an exception is thrown"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a reference type in C#?",
              .Options = New String() {"int", "float", "struct", "class"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to inherit a class in C#?",
              .Options = New String() {"implements", "inherits", "extends", ":"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is boxing in C#?",
              .Options = New String() {"Converting a value type to a reference type", "Converting a reference type to a value type", "Encapsulating data in a `struct`", "Storing a value in an `enum`"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to override a method in a derived class?",
              .Options = New String() {"virtual", "override", "sealed", "abstract"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `is` keyword do in C#?",
              .Options = New String() {"Checks for type compatibility", "Assigns a value to a variable", "Casts an object to another type", "Returns the type of an object"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a valid enum declaration in C#?",
              .Options = New String() {"enum Colors { Red, Green, Blue };", "enum Colors = { Red, Green, Blue };", "enum Colors (Red, Green, Blue);", "enum Colors { Red = 1, Green = 2, Blue = 3 } = 3;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(true &&&& false);`?",
              .Options = New String() {"true", "false", "1", "0"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following types are non-inheritable in C#?",
              .Options = New String() {"class", "interface", "sealed class", "abstract class"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is the correct syntax to create a generic class?",
              .Options = New String() {"class MyClass<T> {}", "class<T> MyClass {}", "MyClass class<T> {}", "class MyClass<> {}"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to declare an abstract method in a class?",
              .Options = New String() {"static", "virtual", "override", "abstract"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the return type of a constructor in C#?",
              .Options = New String() {"void", "int", "Constructor", "Constructors do not have a return type"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following operators is used to check if two object references refer to the same object?",
              .Options = New String() {"==", "Equals()", "ReferenceEquals()", "CompareTo()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true for a method marked as `virtual` in C#?",
              .Options = New String() {"It must be overridden in a derived class", "It can be overridden in a derived class", "It cannot be called directly", "It cannot be inherited"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which loop is guaranteed to execute at least once?",
              .Options = New String() {"for", "while", "do-while", "foreach"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of these keywords is used to define an interface in C#?",
              .Options = New String() {"interface", "struct", "class", "delegate"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to add an item to a List in C#?",
              .Options = New String() {"Insert()", "Append()", "Add()", "Push()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the size of a `bool` in C#?",
              .Options = New String() {"8 bits", "1 bit", "16 bits", "32 bits"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following methods is called first in a C# application?",
              .Options = New String() {"Main()", "Start()", "Begin()", "Init()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following statements is true about `struct` in C#?",
              .Options = New String() {"It is a reference type", "It is a value type", "It supports inheritance", "It cannot implement interfaces"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following operators is used for string concatenation in C#?",
              .Options = New String() {"&&", "+", "*", "^"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `null` keyword represent in C#?",
              .Options = New String() {"A zero value", "A default value for reference types", "The absence of a value", "A negative value"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the purpose of the `out` keyword in C#?",
              .Options = New String() {"To indicate a method returns a value", "To pass parameters by value", "To return multiple values from a method", "To specify a constant value"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to convert a string to an integer in C#?",
              .Options = New String() {"int.Parse()", "Convert.ToInt()", "Int.Parse()", "string.ToInt()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following collections represents a first-in, first-out (FIFO) collection in C#?",
              .Options = New String() {"Stack<T>", "Queue<T>", "List<T>", "Dictionary<TKey, TValue>"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `throw` keyword do in C#?",
              .Options = New String() {"Catches an exception", "Handles an exception", "Re-throws an existing exception", "Silently logs an exception"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about `readonly` fields in C#?",
              .Options = New String() {"They can only be assigned during declaration", "They can only be assigned in the constructor or at declaration", "They can be modified anywhere in the code", "They cannot be assigned a value at any point"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is NOT a valid method of handling exceptions in C#?",
              .Options = New String() {"try", "catch", "finally", "trap"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true for a `sealed` class in C#?",
              .Options = New String() {"It can be inherited", "It cannot be inherited", "It can be abstract", "It cannot be instantiated"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which access modifier makes a member accessible within its own class and derived classes in C#?",
              .Options = New String() {"private", "protected", "internal", "public"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the result of the expression `5 + ""5""` in C#?",
              .Options = New String() {"10", "55", "Error", "NaN"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is the correct syntax for creating an instance of a class named `Car`?",
              .Options = New String() {"Car car = new Car();", "Car = new Car();", "new Car() = car;", "new Car = Car();"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to remove the last element from a List in C#?",
              .Options = New String() {"RemoveAt()", "Pop()", "RemoveLast()", "RemoveAt(List.Count - 1)"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `const` keyword signify in C#?",
              .Options = New String() {"The value can be changed", "The value cannot be changed", "The value is assigned at runtime", "The value is nullable"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about `async` methods in C#?",
              .Options = New String() {"They must return `Task` or `void`", "They cannot have return types", "They must execute synchronously", "They cannot contain `await` statements"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a correct way to create a multi-dimensional array in C#?",
              .Options = New String() {"int[,] array = new int[3,3];", "int[][] array = new int[3,3];", "int array = new int[3,3];", "int[3,3] array = new int[,]();"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following methods stops the execution of a thread in C#?",
              .Options = New String() {"Pause()", "Abort()", "Stop()", "Break()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the primary purpose of the `using` statement when working with resources in C#?",
              .Options = New String() {"To import namespaces", "To ensure resources are disposed of properly", "To declare a variable as constant", "To cast variables to different types"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to prevent a class from being inherited in C#?",
              .Options = New String() {"abstract", "sealed", "static", "final"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to compare two strings for equality in C#?",
              .Options = New String() {"Compare()", "==", "Equals()", "CompareTo()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a correct declaration of a nullable type in C#?",
              .Options = New String() {"int? number = null;", "nullable<int> number = null;", "int number = null;", "nullable int number = null;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(2 << 3);`?",
              .Options = New String() {"10", "14", "8", "16"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following statements is true about extension methods in C#?",
              .Options = New String() {"They must be declared inside the class they extend", "They can be called as if they are instance methods", "They are always static methods", "They cannot be static"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a valid way to define a property in C#?",
              .Options = New String() {"public int MyProperty { get; set; }", "int public MyProperty { get; set; }", "public MyProperty int { get; set; }", "MyProperty public int { get; set; }"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `nameof` operator do in C#?",
              .Options = New String() {"Returns the name of the class", "Returns the name of a variable or type as a string", "Returns the type of an object", "Returns the namespace of a type"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following types does not support arithmetic operations?",
              .Options = New String() {"int", "double", "bool", "decimal"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the purpose of the `lock` statement in C#?",
              .Options = New String() {"To prevent race conditions in multi-threaded code", "To prevent exceptions from being thrown", "To prevent memory leaks", "To lock a resource so it cannot be modified"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to define a constant value in C#?",
              .Options = New String() {"final", "const", "static", "sealed"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(5 % 2);`?",
              .Options = New String() {"1", "2", "0", "5"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `virtual` keyword indicate about a method in C#?",
              .Options = New String() {"The method cannot be overridden", "The method can be overridden in a derived class", "The method is static", "The method is abstract"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following types is a reference type in C#?",
              .Options = New String() {"int", "enum", "class", "struct"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to inherit from an interface in C#?",
              .Options = New String() {"inherits", "extends", "implements", ":"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following collections represents a last-in, first-out (LIFO) collection in C#?",
              .Options = New String() {"Queue<T>", "List<T>", "Stack<T>", "Dictionary<TKey, TValue>"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following operators is used to determine whether an object is of a certain type in C#?",
              .Options = New String() {"typeof", "instanceof", "is", "as"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to check if a string contains a specific substring in C#?",
              .Options = New String() {"Find()", "Contains()", "IndexOf()", "Check()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `as` keyword do in C#?",
              .Options = New String() {"Performs a cast and throws an exception if the cast fails", "Performs a cast and returns `null` if the cast fails", "Performs an implicit conversion", "Performs a type check"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a correct way to create an immutable string in C#?",
              .Options = New String() {"string s = ""Hello"";", "const string s = ""Hello"";", "readonly string s = ""Hello"";", "immutable string s = ""Hello"";"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following correctly declares a method that returns a value in C#?",
              .Options = New String() {"void MyMethod() {}", "int MyMethod() { return 0; }", "void MyMethod() { return 0; }", "return int MyMethod() {}"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to find the length of a string in C#?",
              .Options = New String() {"LengthOf()", "GetLength()", "Length", "SizeOf()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following methods converts a string to uppercase in C#?",
              .Options = New String() {"ToUpperCase()", "ToUpper()", "MakeUpper()", "ConvertToUpper()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to indicate that a method or class cannot be overridden in C#?",
              .Options = New String() {"sealed", "abstract", "override", "virtual"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(10 / 3);`?",
              .Options = New String() {"3.33", "3", "4", "3.0"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to remove all elements from a List in C#?",
              .Options = New String() {"RemoveAll()", "Clear()", "DeleteAll()", "Purge()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following operators is used to perform bitwise AND in C#?",
              .Options = New String() {"&&", "&&&&", "|", "||"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(4 | 2);`?",
              .Options = New String() {"0", "2", "4", "6"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is a valid way to define an event in C#?",
              .Options = New String() {"public delegate void MyEventHandler();", "public event EventHandler MyEvent;", "public MyEvent EventHandler;", "public MyEventHandler Event;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about destructors in C#?",
              .Options = New String() {"They are explicitly called", "They are automatically called when an object is destroyed", "They can be overloaded", "They can have parameters"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the default value of a `bool` variable in C#?",
              .Options = New String() {"true", "false", "null", "0"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following methods is used to determine the data type of a variable in C#?",
              .Options = New String() {"typeof()", "getType()", "typeOf()", "varType()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following statements is true about `interfaces` in C#?",
              .Options = New String() {"They can contain fields", "They can contain method implementations", "They can contain abstract methods only", "They can contain methods without implementations"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about partial classes in C#?",
              .Options = New String() {"A partial class cannot be split across multiple files", "A partial class allows its definition to be split across multiple files", "A partial class cannot contain methods", "A partial class must be fully defined in a single file"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following methods is used to explicitly release unmanaged resources in C#?",
              .Options = New String() {"Dispose()", "Finalize()", "Free()", "Release()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the output of `Console.WriteLine(1 == 1.0);` in C#?",
              .Options = New String() {"true", "false", "Error", "NaN"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which keyword is used to create an alias for a namespace or a class in C#?",
              .Options = New String() {"as", "alias", "namespace", "using"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about the `params` keyword in C#?",
              .Options = New String() {"It allows a method to accept a single parameter", "It allows a method to accept a fixed number of parameters", "It allows a method to accept a variable number of parameters", "It allows a method to accept only one type of parameter"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the purpose of the `GetHashCode()` method in C#?",
              .Options = New String() {"To compare two objects", "To return a unique identifier for an object", "To return the memory address of an object", "To convert an object to a string"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about the `Task` class in C#?",
              .Options = New String() {"It is used for asynchronous programming", "It is used for file handling", "It is used for exception handling", "It is used for thread synchronization"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about the `Lazy<T>` class in C#?",
              .Options = New String() {"It initializes the object immediately", "It delays the object initialization until it's needed", "It cannot be used with reference types", "It is used for thread synchronization"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "What does the `default` keyword do in a switch statement in C#?",
              .Options = New String() {"It specifies the value to be returned", "It catches all values not caught by other cases", "It defines a default variable value", "It throws an exception if no cases match"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to convert a string to lowercase in C#?",
              .Options = New String() {"ToLowerCase()", "ToLower()", "MakeLower()", "ConvertToLower()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following is true about the `StringBuilder` class in C#?",
              .Options = New String() {"It is immutable", "It is used to efficiently modify a string", "It cannot be used with `string` objects", "It is slower than using `string` concatenation"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which of the following statements is true about the `ref` keyword in C#?",
              .Options = New String() {"It allows a method to modify an argument passed to it", "It allows a method to return a reference", "It passes a value by value", "It allows a method to return multiple values"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "Which method is used to convert a string to an integer safely in C#?",
              .Options = New String() {"int.TryParse()", "Convert.ToInt()", "Int.TryParse()", "string.TryInt()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C#", .Text = "What is the result of the expression `3 && 6` in C#?",
              .Options = New String() {"2", "3", "6", "0"}, .CorrectAnswer = 0})

    End Sub
End Module
