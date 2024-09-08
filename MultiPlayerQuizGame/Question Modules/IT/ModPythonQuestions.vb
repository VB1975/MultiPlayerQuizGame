Imports MultiPlayerQuizGame.ClsDataStructures

Module ModPythonQuestions

    Public Sub PythonQuestions()

        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct syntax to output the string ""Hello, World"" in Python?",
              .Options = New String() {"cout << ""Hello, World""", "echo ""Hello, World""", "print(""Hello, World"")", "printf(""Hello, World"")"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following is used to define a function in Python?",
              .Options = New String() {"def", "define", "func", "function"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you insert comments in Python code?",
              .Options = New String() {"# This is a comment", "/* This is a comment */", "// This is a comment", "<!-- This is a comment -->"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following data types is mutable in Python?",
              .Options = New String() {"Integer", "List", "String", "Tuple"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct file extension for Python files?",
              .Options = New String() {".py", ".pyth", ".python", ".txt"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of these operators is used for exponentiation in Python?",
              .Options = New String() {"%%", "**", "//", "^"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a variable with the floating number 2.8?",
              .Options = New String() {"float x = 2.8", "x := 2.8", "x = (float(2.8))", "x = 2.8"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you start a while loop in Python?",
              .Options = New String() {"while (condition)", "while condition", "while condition:", "while: condition"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which keyword is used to handle exceptions in Python?",
              .Options = New String() {"catch", "except", "handle", "try"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What will be the output of the following expression: print(10 // 3)?",
              .Options = New String() {"1", "3", "3.33", "10"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How can you convert a string to an integer in Python?",
              .Options = New String() {"bool()", "float()", "int()", "str()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which function is used to read input from the user in Python?",
              .Options = New String() {"get_input()", "input()", "read()", "user_input()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the output of print(bool(0))?",
              .Options = New String() {"0", "False", "None", "True"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you check the length of a list in Python?",
              .Options = New String() {"count()", "len()", "length()", "size()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of these is NOT a valid data type in Python?",
              .Options = New String() {"char", "dictionary", "list", "set"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What does the range() function return?",
              .Options = New String() {"A list of strings", "A random number", "A sequence of numbers", "A single number"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following is the correct syntax to create a dictionary in Python?",
              .Options = New String() {"[""name"": ""John"", ""age"": 30]", "{""name"", ""John"", ""age"", 30}", "{""name"": ""John"", ""age"": 30}", "dict(""name""=""John"", ""age""=30)"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a set in Python?",
              .Options = New String() {"(""apple"", ""banana"", ""cherry"")", "{""apple"", ""banana"", ""cherry""}", "set([""apple"", ""banana"", ""cherry""])", "set{""apple"", ""banana"", ""cherry""}"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct way to declare a lambda function?",
              .Options = New String() {"lambda x: x + 1", "lambda function(x) { return x + 1; }", "def lambda(x): return x + 1", "lambda => x + 1"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which method is used to add an element to a list in Python?",
              .Options = New String() {"add()", "append()", "insert()", "push()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the purpose of the pass statement in Python?",
              .Options = New String() {"It is used as a placeholder for future code", "It is used to handle exceptions", "It is used to terminate a loop", "It skips the next statement"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which function is used to get the maximum value from a list?",
              .Options = New String() {"greatest()", "high()", "largest()", "max()"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the output of print(2 * 3 ** 2)?",
              .Options = New String() {"9", "12", "18", "36"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How can you create a tuple in Python?",
              .Options = New String() {"(1, 2, 3)", "[1, 2, 3]", "{1, 2, 3}", "tuple[1, 2, 3]"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which keyword is used to create a class in Python?",
              .Options = New String() {"class", "def", "object", "struct"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct way to open a file in Python for reading?",
              .Options = New String() {"file(""file.txt"", ""r"")", "open(""file.txt"", ""r"")", "open(""file.txt"", ""read"")", "open(""file.txt"", read)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you add a key-value pair to a dictionary?",
              .Options = New String() {"dict.add(""key"", ""value"")", "dict.insert(""key"", ""value"")", "dict.put(""key"", ""value"")", "dict[""key""] = ""value"""}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct syntax for an if statement in Python?",
              .Options = New String() {"if (x > y)", "if x > y do", "if x > y then", "if x > y:"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a comment that spans multiple lines in Python?",
              .Options = New String() {"Use /* and */", "Use // for each line", "Use a backslash at the end of each line", "Use triple quotes (''' comment ''')"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which method is used to remove whitespace from the beginning and end of a string in Python?",
              .Options = New String() {"clean()", "remove()", "strip()", "trim()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the output of print(10 % 3)?",
              .Options = New String() {"0", "1", "3", "10"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is a correct way to create a list in Python?",
              .Options = New String() {"(1, 2, 3)", "[1, 2, 3]", "{1, 2, 3}", "list(1, 2, 3)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "3How do you check if a key exists in a dictionary?",
              .Options = New String() {"""key"" in dict", "dict.exists(""key"")", "dict.has(""key"")", "key in dict.keys()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which keyword is used to return a value from a function?",
              .Options = New String() {"back", "give", "return", "send"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct way to define a constructor in a Python class?",
              .Options = New String() {"def __init__(self):", "def _init_(self):", "def constructor(self):", "def self.__init__():"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which module is used to work with regular expressions in Python?",
              .Options = New String() {"expr", "re", "reg", "regex"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you convert a list to a tuple in Python?",
              .Options = New String() {"cast()", "convert()", "list()", "tuple()"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the result of this code: print(len([1, 2, 3, 4]))?",
              .Options = New String() {"3", "4", "5", "None"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the default return value of a function that does not return anything explicitly?",
              .Options = New String() {"0", "False", "None", "Null"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you check if a list is empty?",
              .Options = New String() {"if len(list) == 0:", "if list == []:", "if list.empty():", "if not list:"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which method is used to remove the last item from a list?",
              .Options = New String() {"delete()", "drop()", "pop()", "remove()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What will be the output of print(2 * (3 + 5))?",
              .Options = New String() {"10", "16", "21", "26"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the use of the 'with' statement in Python?",
              .Options = New String() {"It is used to create a loop", "It is used to define a block of code", "It is used to import modules", "It is used to simplify exception handling"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct syntax to import a module in Python?",
              .Options = New String() {"import module_name", "include module_name", "module module_name", "using module_name"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the result of print(type(5))?",
              .Options = New String() {"<class 'int'>", "5", "int", "integer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following is a Python built-in function?",
              .Options = New String() {"aggregate()", "calc()", "plus()", "sum()"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a new Python file in an IDE?",
              .Options = New String() {"Save the file with a .py extension", "Save the file with a .pyth extension", "Save the file with a .python extension", "Save the file with a .script extension"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which method is used to reverse a list in Python?",
              .Options = New String() {"flip()", "invert()", "reverse()", "turn()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How can you create an infinite loop in Python?",
              .Options = New String() {"for i in range():", "loop:", "while 1 == 1:", "while True:"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the output of print(2 ** 3)?",
              .Options = New String() {"6", "8", "9", "16"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you handle multiple exceptions in a single block?",
              .Options = New String() {"Use a catch-all except statement", "Use a nested try block", "Use a single except statement", "Use multiple except statements"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following can be used to terminate a loop in Python?",
              .Options = New String() {"break", "end", "exit", "return"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the difference between a list and a tuple?",
              .Options = New String() {"A list is immutable, and a tuple is mutable", "A tuple is immutable, and a list is mutable", "Lists cannot contain duplicates, while tuples can", "Tuples are ordered, while lists are not"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a list comprehension in Python?",
              .Options = New String() {"(x for x in iterable)", "[x for x in iterable]", "{x for x in iterable}", "list(x for x in iterable)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of these is a valid way to create a dictionary?",
              .Options = New String() {"(""one"": 1, ""two"": 2)", "[""one"": 1, ""two"": 2]", "{""one"": 1, ""two"": 2}", "{""one""=1, ""two""=2}"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a new object in Python?",
              .Options = New String() {"By calling the class as a function", "By using the create keyword", "By using the new keyword", "By using the object keyword"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you access the first element of a list?",
              .Options = New String() {"list(0)", "list.first()", "list[0]", "list{0}"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the purpose of the continue statement in Python?",
              .Options = New String() {"It ends the loop", "It moves to the next loop", "It restarts the loop", "It skips the current iteration and moves to the next"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the difference between `==` and `is` in Python?",
              .Options = New String() {"== checks for equality, and is checks for identity", "== checks for identity, and is checks for equality", "== is used for strings, and is is used for numbers", "They are both used for equality checks"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you merge two lists in Python?",
              .Options = New String() {"Use the + operator", "Use the append() method", "Use the combine() method", "Use the join() method"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct way to handle an exception in Python?",
              .Options = New String() {"handle: ...", "if exception: ...", "try: ... catch: ...", "try: ... except: ..."}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you iterate through the keys of a dictionary?",
              .Options = New String() {"for dict in key:", "for dict.key():", "for key in dict.keys():", "for key in dict:"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you remove an item from a dictionary in Python?",
              .Options = New String() {"del dict[""key""]", "dict.delete(""key"")", "dict.pop(""key"")", "dict.remove(""key"")"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following is a valid variable name in Python?",
              .Options = New String() {"1variable", "my variable", "my_variable", "my-variable"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What does the built-in function eval() do in Python?",
              .Options = New String() {"It evaluates a number", "It parses and executes an expression", "It prints the value of a variable", "It validates a string"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you declare a global variable inside a function?",
              .Options = New String() {"declare keyword", "global keyword", "globalize keyword", "makeglobal keyword"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following is NOT a Python keyword?",
              .Options = New String() {"def", "eval", "global", "pass"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a block of code that is executed when an exception does not occur?",
              .Options = New String() {"else block in a try-except statement", "except block in a try-except statement", "finally block in a try-except statement", "no block is executed"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct syntax to declare a recursive function in Python?",
              .Options = New String() {"def func(): ... call func()", "def func(): ... repeat func()", "def func(): ... return func()", "def func(): ... self.func()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which method is used to convert a string to lowercase in Python?",
              .Options = New String() {"lower()", "lowercase()", "strlower()", "tolower()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct syntax for a for loop in Python?",
              .Options = New String() {"for (x = 0; x < 5; x++)", "for i = 0 to 5", "for x in range(5):", "foreach x in range(5)"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you define a constant in Python?",
              .Options = New String() {"Use an all-uppercase variable name", "Use the const keyword", "Use the final keyword", "Use the immutable keyword"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which module is used to generate random numbers in Python?",
              .Options = New String() {"generate", "math", "numbers", "random"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How can you get the current date and time in Python?",
              .Options = New String() {"Use the date module", "Use the datetime module", "Use the now module", "Use the time module"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the output of print([1, 2] + [3, 4])?",
              .Options = New String() {"[1, 2 3, 4]", "[1, 2, 3, 4]", "[1, 2] [3, 4]", "Syntax error"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you declare a multi-line string in Python?",
              .Options = New String() {"Use a backslash", "Use double quotes", "Use single quotes", "Use triple quotes"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you handle a block of code that always runs, regardless of exceptions?",
              .Options = New String() {"default block", "else block", "except block", "finally block"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the purpose of the yield keyword in Python?",
              .Options = New String() {"It exits the function", "It pauses the function", "It returns a generator object", "It returns multiple values"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you install a Python package using pip?",
              .Options = New String() {"pip add package_name", "pip download package_name", "pip get package_name", "pip install package_name"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the use of the isinstance() function in Python?",
              .Options = New String() {"It checks if an object is a class", "It checks if an object is a function", "It checks if an object is a variable", "It checks if an object is an instance of a class"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you generate a random integer between 1 and 10 in Python?",
              .Options = New String() {"random.choice(1, 10)", "random.getint(1, 10)", "random.randint(1, 10)", "random.random(1, 10)"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the difference between a shallow copy and a deep copy?",
              .Options = New String() {"A deep copy creates a new object, while a shallow copy does not", "A shallow copy creates a new object, while a deep copy does not", "Both create new objects, but deep copy is faster", "Both create new objects, but shallow copy is faster"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you convert an integer to a string in Python?",
              .Options = New String() {"int()", "str()", "string()", "toString()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of the following is a valid way to concatenate two strings in Python?",
              .Options = New String() {"""Hello"" && ""World""", """Hello"" + ""World""", """Hello"".concat(""World"")", "concat(""Hello"", ""World"")"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you check if an object has a particular attribute in Python?",
              .Options = New String() {"checkattr()", "getattribute()", "hasattr()", "hasattrattr()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you iterate through both keys and values in a dictionary?",
              .Options = New String() {"for dict.keys(), dict.values():", "for key in dict.items():", "for key, value in dict.items():", "for key, value in dict:"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the difference between list comprehension and a generator expression?",
              .Options = New String() {"Both create iterators, but list comprehension is faster", "Both create lists, but generator expressions are faster", "Generator expressions create a list, while list comprehension creates an iterator", "List comprehension creates a list, while generator expressions create an iterator"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What does the open() function return when used to open a file?",
              .Options = New String() {"A buffer", "A file descriptor", "A file object", "A string"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you check the type of an object in Python?",
              .Options = New String() {"checktype()", "isinstance()", "objtype()", "type()"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a generator in Python?",
              .Options = New String() {"Use the def keyword without a return", "Use the gen keyword", "Use the generate keyword", "Use the yield keyword"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the correct way to delete a variable in Python?",
              .Options = New String() {"del", "delete", "remove", "unset"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you get the first item in a dictionary?",
              .Options = New String() {"dict.first()", "dict[0]", "Use the next() function on the dictionary's iterator", "Use the pop() method"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "Which of these methods is used to sort a list in place?",
              .Options = New String() {"arrange()", "order()", "sort()", "sorted()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the difference between the append() and extend() methods in Python?",
              .Options = New String() {"append() adds a single element, while extend() adds multiple elements", "append() adds multiple elements, while extend() adds a single element", "append() removes elements, while extend() adds elements", "append() sorts the list, while extend() reverses the list"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you read the entire contents of a file in Python?",
              .Options = New String() {"getcontent()", "read()", "readfile()", "readline()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Python", .Text = "What does the zip() function do in Python?",
              .Options = New String() {"Combines elements from multiple iterables", "Compresses a file", "Joins two strings", "Multiplies two numbers"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you create a virtual environment in Python?",
              .Options = New String() {"pip install env", "python create env", "python init env", "python -m venv env"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Python", .Text = "What is the purpose of the super() function in Python?",
              .Options = New String() {"It calls the method from a parent class", "It creates a new object", "It initializes a class", "It returns a special value"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Python", .Text = "How do you generate a sequence of numbers in Python?",
              .Options = New String() {"Use the gen() function", "Use the list() function", "Use the range() function", "Use the seq() function"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Python", .Text = "What does the break statement do in a loop?",
              .Options = New String() {"It pauses the loop", "It restarts the loop", "It skips the current iteration", "It terminates the loop"}, .CorrectAnswer = 3})

    End Sub
End Module
