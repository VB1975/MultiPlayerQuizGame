Imports MultiPlayerQuizGame.ClsDataStructures

Module ModCPlusPlusQuestions

    Public Sub CPlusPlusQuestions()

        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to declare a pointer in C++?",
              .Options = New String() {"int p;", "int* p;", "int p*;", "pointer int p;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is the correct syntax to create an object of class `MyClass`?",
              .Options = New String() {"MyClass obj;", "class obj;", "object MyClass;", "MyClass.create();"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a valid C++ data type?",
              .Options = New String() {"int", "float", "char", "number"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the size of an `int` in a typical C++ implementation?",
              .Options = New String() {"2 bytes", "4 bytes", "8 bytes", "1 byte"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the default access level for class members in C++?",
              .Options = New String() {"public", "private", "protected", "static"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following operators cannot be overloaded?",
              .Options = New String() {"+", "::", "[]", "-"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is used to dynamically allocate memory in C++?",
              .Options = New String() {"malloc", "alloc", "new", "free"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "How do you define a constant in C++?",
              .Options = New String() {"const int x = 10;", "int const x = 10;", "constant int x = 10;", "#define x 10"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is a destructor in C++?",
              .Options = New String() {"A function that initializes an object", "A function that is called when an object is destroyed", "A function that allocates memory", "A function that deletes a pointer"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which keyword is used to inherit a class in C++?",
              .Options = New String() {"inherits", "extends", "public", "class"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of `5 / 2` in C++?",
              .Options = New String() {"2.5", "3", "2", "2.0"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "How can you catch an exception in C++?",
              .Options = New String() {"try...finally", "catch", "try...catch", "try...except"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the keyword `virtual` signify in C++?",
              .Options = New String() {"Function is static", "Function can be overridden in derived classes", "Function is private", "Function is inline"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to declare a pure virtual function in C++?",
              .Options = New String() {"virtual void func() = 0;", "virtual void func();", "void func() = 0;", "pure void func();"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the purpose of a copy constructor in C++?",
              .Options = New String() {"To create an object from another object of the same class", "To copy one function to another", "To create a new class from an existing one", "To copy a class definition"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "How is a comment added in C++?",
              .Options = New String() {"// This is a comment", "/* This is a comment", "-- This is a comment", "# This is a comment"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following loops is guaranteed to execute at least once?",
              .Options = New String() {"`for` loop", "`while` loop", "`do...while` loop", "`for...each` loop"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following statements is used to skip the current iteration of a loop?",
              .Options = New String() {"break", "continue", "exit", "skip"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does `nullptr` represent in C++?",
              .Options = New String() {"A null character", "A null reference", "A null pointer", "A null array"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct declaration of a reference variable?",
              .Options = New String() {"int &&ref = a;", "int ref = &&a;", "int *ref = &&a;", "int &&ref = &&a;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a storage class in C++?",
              .Options = New String() {"auto", "register", "static", "mutable"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "How do you create an inline function in C++?",
              .Options = New String() {"inline void func();", "inline func();", "void inline func();", "void func() inline;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `this` pointer in C++?",
              .Options = New String() {"To access static variables", "To refer to the current object", "To access private members", "To declare a new object"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a feature of C++?",
              .Options = New String() {"Inheritance", "Encapsulation", "Garbage collection", "Polymorphism"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does `sizeof()` operator return in C++?",
              .Options = New String() {"Number of elements in an array", "Size in bits", "Size in bytes", "Size in kilobytes"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct syntax for a `for` loop in C++?",
              .Options = New String() {"for (int i = 0, i < 10, i++)", "for (i = 0; i < 10; i++)", "for (int i = 0; i < 10; i++)", "for (int i = 0; i < 10)"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the return type of the `main()` function in C++?",
              .Options = New String() {"void", "int", "float", "char"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a valid loop control statement in C++?",
              .Options = New String() {"break", "continue", "goto", "stop"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is a `friend` function in C++?",
              .Options = New String() {"A function that can access private and protected members of a class", "A function that only works with friend classes", "A function that is private to a class", "A function that must be declared inside a class"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "How can you declare a constant pointer to an integer in C++?",
              .Options = New String() {"const int *ptr;", "int *const ptr;", "const int *const ptr;", "int const *ptr;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the purpose of the `namespace` keyword in C++?",
              .Options = New String() {"To define a class", "To define a block of code", "To avoid name conflicts", "To define a function"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct example of function overloading in C++?",
              .Options = New String() {"Two functions with the same name but different return types", "Two functions with the same name but different parameter types", "Two functions with different names but the same parameter types", "Two functions with the same name and same parameters"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "How can you allocate a block of memory for an array in C++?",
              .Options = New String() {"int *arr = malloc(10 * sizeof(int));", "int *arr = new int[10];", "int *arr = alloc(10 * sizeof(int));", "int arr[10];"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a feature of `std::vector` in C++?",
              .Options = New String() {"Fixed-size array", "Dynamic array", "Linked list", "Hash table"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << 5 % 2;`",
              .Options = New String() {"2", "1", "0", "2.5"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following data types is used to store a single character in C++?",
              .Options = New String() {"string", "char", "int", "bool"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following statements is correct for a C++ string?",
              .Options = New String() {"A string is a sequence of characters", "A string is a single character", "A string is a numerical value", "A string is a data type in C++"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the default return type of functions in C++ if none is specified?",
              .Options = New String() {"int", "void", "float", "double"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following statements is true about C++?",
              .Options = New String() {"C++ supports procedural programming", "C++ supports object-oriented programming", "C++ supports both procedural and object-oriented programming", "C++ does not support object-oriented programming"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does `cout` stand for in C++?",
              .Options = New String() {"Console Output", "Character Output", "Central Output", "Class Output"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `&&` operator in C++?",
              .Options = New String() {"It is a bitwise OR operator", "It is a bitwise AND operator", "It returns the address of a variable", "It is a logical AND operator"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the function of the `break` statement in C++?",
              .Options = New String() {"It exits from a loop or switch statement", "It skips the current iteration of a loop", "It restarts the loop from the beginning", "It terminates the program"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct way to create a multi-dimensional array in C++?",
              .Options = New String() {"int arr[][];", "int arr[3,3];", "int arr[3][3];", "int arr(3)(3);"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct statement for declaring a function in C++?",
              .Options = New String() {"int func(int a, int b);", "int func(int a int b);", "int func(int, int);", "func(int a, int b);"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which operator is used to access the members of a structure through a pointer?",
              .Options = New String() {".", "->", "*", "&&"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to include a header file in C++?",
              .Options = New String() {"#include [iostream]", "#include <iostream>", "include <iostream>", "#include ""iostream""`"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the `new` keyword do in C++?",
              .Options = New String() {"It declares a variable", "It creates a new function", "It allocates memory dynamically", "It creates a new class"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the purpose of the `delete` keyword in C++?",
              .Options = New String() {"To delete a variable", "To delete a class", "To deallocate memory allocated by `new`", "To delete a function"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `#include` directive in C++?",
              .Options = New String() {"To include libraries or other source files", "To include comments in code", "To include data in variables", "To include classes in a program"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a feature of Object-Oriented Programming in C++?",
              .Options = New String() {"Encapsulation", "Inheritance", "Polymorphism", "All of the above"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which operator is used to access the value at the address stored in a pointer?",
              .Options = New String() {"&&", "*", "->", "."}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following statements is correct about the `return` statement in C++?",
              .Options = New String() {"It returns a value from a function to the caller", "It exits a loop", "It starts a loop", "It returns to the start of a function"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the term ""overloading"" refer to in C++?",
              .Options = New String() {"Using the same name for different functions with different parameters", "Using the same name for multiple variables", "Using the same name for multiple classes", "Using the same function in different classes"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following keywords is used to prevent a class from being inherited?",
              .Options = New String() {"final", "sealed", "protected", "private"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to define a constructor in a class?",
              .Options = New String() {"ClassName();", "void ClassName();", "int ClassName();", "constructor ClassName();"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a type of polymorphism in C++?",
              .Options = New String() {"Compile-time polymorphism", "Run-time polymorphism", "Both A and B", "None of the above"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the difference between `struct` and `class` in C++?",
              .Options = New String() {"Members of a `struct` are private by default", "Members of a `class` are private by default", "`struct` does not support inheritance", "`class` does not support multiple inheritance"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following operators is used to test if two values are equal?",
              .Options = New String() {"=", "==", "!=", "==="}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << (2 > 1 ? ""Yes"" : ""No"");`",
              .Options = New String() {"No", "Yes", "Error", "2"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "How do you initialize an array of 10 integers to 0 in C++?",
              .Options = New String() {"int arr[10] = {0};", "int arr[10];", "int arr[10] = 0;", "int arr[10] = {0,0,0,0,0,0,0,0,0,0};"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following functions is used to read a single character from the console in C++?",
              .Options = New String() {"getchar()", "getc()", "cin.get()", "cin.getline()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the `static` keyword signify when used with a variable in C++?",
              .Options = New String() {"The variable is global", "The variable retains its value between function calls", "The variable is immutable", "The variable is local"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the result of `8 >> 2` in C++?",
              .Options = New String() {"16", "4", "2", "2"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a valid access specifier in C++?",
              .Options = New String() {"public", "private", "protected", "internal"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `extern` keyword in C++?",
              .Options = New String() {"To declare a global variable", "To declare a function prototype", "To declare a variable without defining it", "To declare a static variable"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is used to create a reference variable in C++?",
              .Options = New String() {"*", "&&", "&&&&", "#"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the term ""overriding"" refer to in C++?",
              .Options = New String() {"Defining a function with the same name in multiple classes", "Redefining a base class function in a derived class", "Using the same name for multiple variables", "Using the same function in different classes"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `enum` keyword in C++?",
              .Options = New String() {"To define a set of integer constants", "To define a set of float constants", "To define a set of string constants", "To define a set of character constants"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct way to handle multiple exceptions in C++?",
              .Options = New String() {"Multiple `try` blocks", "Multiple `catch` blocks", "Nested `try` blocks", "Nested `catch` blocks"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << (3 &&&& 0);`",
              .Options = New String() {"3", "0", "1", "Error"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to declare a function that does not return a value?",
              .Options = New String() {"int func();", "void func();", "func();", "return func();"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a type of inheritance in C++?",
              .Options = New String() {"Single", "Multiple", "Hybrid", "Hierarchical"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following operators is used for dereferencing a pointer?",
              .Options = New String() {"&&", "*", "->", "."}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the `bool` data type represent in C++?",
              .Options = New String() {"A number", "A character", "A boolean value (true/false)", "A floating-point number"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the purpose of the `friend` keyword in C++?",
              .Options = New String() {"To define a function outside a class", "To grant a non-member function access to private and protected members of a class", "To declare a global variable", "To define a static function"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct way to declare an array in C++?",
              .Options = New String() {"int arr[] = {1, 2, 3};", "int arr = {1, 2, 3};", "int arr[3] = 1, 2, 3;", "int arr = new int[3]{1, 2, 3};"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a feature of C++?",
              .Options = New String() {"Inline functions", "Template classes", "Automatic garbage collection", "Exception handling"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to define a macro in C++?",
              .Options = New String() {"#define MAX 100", "macro MAX 100", "MAX = 100;", "const int MAX = 100;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << 7 / 2;`",
              .Options = New String() {"3", "3.5", "4", "3"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the `auto` keyword signify in C++?",
              .Options = New String() {"The variable type is automatically determined", "The variable is an integer", "The variable is a float", "The variable is a pointer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << 10 << 20;`",
              .Options = New String() {"1020", "10 20", "30", "Error"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a feature of `std::map` in C++?",
              .Options = New String() {"It stores unique key-value pairs", "It allows duplicate keys", "It is a dynamic array", "It is a fixed-size array"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `private` keyword in C++?**",
              .Options = New String() {"To restrict access to class members", "To declare a global variable", "To create a constructor", "To define a static function"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the purpose of the `protected` keyword in C++?",
              .Options = New String() {"To restrict access to derived classes", "To allow access to derived classes", "To declare a static variable", "To define a global variable"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct way to initialize a pointer in C++?",
              .Options = New String() {"int *p = 0;", "int *p = NULL;", "int *p = nullptr;", "int *p = none;"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `register` keyword in C++?",
              .Options = New String() {"To declare a global variable", "To declare a variable that should be stored in a CPU register", "To declare a static variable", "To declare a pointer"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is a correct way to handle an exception in C++?",
              .Options = New String() {"try...finally", "try...except", "try...catch", "try...throw"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to declare a function pointer in C++?",
              .Options = New String() {"int *func(int a);", "int (*func)(int a);", "int *func(int a)();", "int (&&func)(int a);"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to check for null pointer in C++?",
              .Options = New String() {"if (ptr == 0)", "if (ptr == NULL)", "if (ptr == nullptr)", "All of the above"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << (5 && 3);`",
              .Options = New String() {"7", "3", "5", "1"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the `volatile` keyword indicate in C++?",
              .Options = New String() {"The variable is constant", "The variable can be changed unexpectedly", "The variable is global", "The variable is static"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to create an object of a class in C++?",
              .Options = New String() {"ClassName obj;", "object obj;", "ClassName obj();", "obj ClassName;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "Which of the following is not a type of constructor in C++?",
              .Options = New String() {"Default constructor", "Copy constructor", "Move constructor", "Static constructor"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `explicit` keyword in C++?",
              .Options = New String() {"To prevent implicit conversions", "To declare a function as inline", "To declare a static variable", "To define a global variable"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << (1 << 3);`",
              .Options = New String() {"8", "3", "6", "1"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the correct way to define a function template in C++?",
              .Options = New String() {"template<typename T> void func(T a);", "template<class T> void func(T a);", "template<T> void func(T a);", "template void func(T a);"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the use of the `final` keyword in C++?",
              .Options = New String() {"To prevent a class from being inherited", "To declare a constant variable", "To define a static function", "To declare a global variable"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the output of the following code? `cout << sizeof(char);`",
              .Options = New String() {"1", "2", "4", "8"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "C++", .Text = "What is the purpose of the `typeid` operator in C++?",
              .Options = New String() {"To get the size of a variable", "To get the data type of an object at runtime", "To define a template", "To cast a variable to another type"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "C++", .Text = "What does the `mutable` keyword indicate in C++?",
              .Options = New String() {"The variable is constant", "The variable can be modified even if it is a member of a `const` object", "The variable is global", "The variable is static"}, .CorrectAnswer = 1})

    End Sub
End Module
