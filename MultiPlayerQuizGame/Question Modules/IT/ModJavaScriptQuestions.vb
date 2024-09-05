Imports MultiPlayerQuizGame.ClsDataStructures

Module ModJavaScriptQuestions

    Public Sub JavaScriptQuestions()

        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the correct syntax for referring to an external script called ""app.js""?",
              .Options = New String() {"<script src=""app.js"">", "<script href=""app.js"">", "<script ref=""app.js"">", "<script link=""app.js"">"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which company developed JavaScript?",
              .Options = New String() {"Microsoft", "Netscape", "Google", "Apple"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How can you declare a JavaScript variable?",
              .Options = New String() {"variable x;", "var x;", "v x;", "declare x;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method can be used to convert an array into a string?",
              .Options = New String() {"toString()", "parseString()", "joinString()", "concat()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the correct way to write an if statement in JavaScript?",
              .Options = New String() {"if i = 5", "if (i == 5)", "if i == 5 then", "if i equals 5"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is used to iterate over an array in JavaScript?",
              .Options = New String() {"foreach()", "loop()", "forEach()", "iterate()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you create a function in JavaScript?",
              .Options = New String() {"def function()", "function myFunction()", "create function myFunction()", "myFunction = new Function()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you call a function named ""myFunction""?",
              .Options = New String() {"call myFunction();", "myFunction();", "run myFunction();", "execute myFunction();"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will the following code return: `Boolean(10 > 9)`?",
              .Options = New String() {"true", "false", "null", "undefined"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the correct syntax for a ""for"" loop?",
              .Options = New String() {"for i = 1 to 5", "for (var i = 0; i < 5; i++)", "loop (i < 5) { i++ }", "for (i < 5; i++)"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is not a JavaScript data type?",
              .Options = New String() {"String", "Number", "Boolean", "Character"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How can you add a comment in JavaScript?",
              .Options = New String() {"<!-- Comment -->", "// Comment", "** Comment **", "\\ Comment"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is used to parse a string into an integer?",
              .Options = New String() {"parseInt()", "int()", "parseInteger()", "Number()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does `typeof` operator do in JavaScript?",
              .Options = New String() {"Returns the data type", "Converts the data type", "Initializes a variable", "Changes the scope"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is not a valid JavaScript variable name?",
              .Options = New String() {"_myVar", "123myVar", "$myVar", "my_Var"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `typeof NaN` in JavaScript?",
              .Options = New String() {"number", "NaN", "undefined", "object"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(3 + ""3"")` output?",
              .Options = New String() {"6", "33", "undefined", "error"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you round a number in JavaScript?",
              .Options = New String() {"round()", "Math.round()", "Math.ceil()", "Math.floor()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which symbol is used for strict equality in JavaScript?",
              .Options = New String() {"==", "===", "!=", "="}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to find an element by ID in the DOM?",
              .Options = New String() {"getElementByName()", "getElementByClass()", "getElementById()", "querySelector()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which function is used to parse a string to a floating-point number?",
              .Options = New String() {"parseFloat()", "parseDouble()", "parseNumber()", "toFloat()`"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(typeof null)` return?",
              .Options = New String() {"null", "undefined", "object", "boolean"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which event occurs when the user clicks on an HTML element?",
              .Options = New String() {"onmouseover", "onclick", "onhover", "onpress"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method can be used to remove the last item of an array?",
              .Options = New String() {"pop()", "shift()", "remove()", "slice()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does `JSON.stringify()` do?",
              .Options = New String() {"Converts an object into JSON", "Parses a string into JSON", "Converts JSON into a string", "Formats a string"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which keyword is used to declare a constant in JavaScript?",
              .Options = New String() {"const", "let", "var", "static"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How can you create an object in JavaScript?",
              .Options = New String() {"var obj = {}", "var obj = []", "var obj = ()", "var obj = """""}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you find the number of elements in an array?",
              .Options = New String() {"array.length", "array.count", "array.size", "array.elements"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the value of `2 + ""2""` in JavaScript?",
              .Options = New String() {"4", "22", "NaN", "undefined"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(0 == false)` output?",
              .Options = New String() {"true", "false", "null", "undefined"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is used to create a promise in JavaScript?",
              .Options = New String() {"new Promise()", "new Callback()", "promise()", "callback()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does the `break` statement do in a loop?",
              .Options = New String() {"Terminates the loop", "Skips an iteration", "Restarts the loop", "Pauses the loop"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is `null` in JavaScript?",
              .Options = New String() {"A string", "A number", "A special value representing ""nothing""", "An object"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which array method checks if every element in an array passes a test?",
              .Options = New String() {"every()", "each()", "some()", "filter()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method adds a new item to the end of an array?",
              .Options = New String() {"push()", "unshift()", "concat()", "add()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you declare a class in JavaScript?",
              .Options = New String() {"class MyClass {}", "function class MyClass {}", "define MyClass {}", "createClass MyClass {}"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is a falsy value in JavaScript?",
              .Options = New String() {"1", "true", """0""", "null"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `typeof undefined`?",
              .Options = New String() {"undefined", "null", "object", "function"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which operator is used to spread elements in JavaScript?",
              .Options = New String() {"...", "??", ">>", "::"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will the following code output: `console.log([] + [])`?",
              .Options = New String() {"undefined", """""", "[]", "null"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which keyword is used to handle exceptions in JavaScript?",
              .Options = New String() {"try", "catch", "handle", "error"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you write a switch statement in JavaScript?",
              .Options = New String() {"switch (expression) { case x: break; }", "switch { case: x break }", "switch { case: x; break }", "case (expression) { x: break; }`"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to remove the first item from an array?",
              .Options = New String() {"shift()", "pop()", "unshift()", "remove()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the value of `true + true` in JavaScript?",
              .Options = New String() {"2", "1", "true", "false"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is the correct way to declare a variable in ES6?",
              .Options = New String() {"var x = 5;", "let x = 5;", "variable x = 5;", "int x = 5;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you stop the execution of a function?",
              .Options = New String() {"exit()", "stop()", "break", "return"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of these values is not a primitive data type in JavaScript?",
              .Options = New String() {"String", "Number", "Object", "Boolean"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does `isNaN()` function do?",
              .Options = New String() {"Checks if a value is NaN", "Converts a value to a number", "Checks if a value is undefined", "Formats a number"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will the code `console.log(typeof [])` return?",
              .Options = New String() {"array", "object", "undefined", "null"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to copy an object in JavaScript?",
              .Options = New String() {"Object.assign()", "copy()", "clone()", "duplicate()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `10 % 3`?",
              .Options = New String() {"1", "3", "10", "0"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which JavaScript method is used to filter elements from an array?",
              .Options = New String() {"filter()", "map()", "reduce()", "splice()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which function is used to set a timer in JavaScript?",
              .Options = New String() {"setTimeout()", "startTimer()", "delay()", "startTimeout()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to sort elements of an array?",
              .Options = New String() {"sort()", "order()", "arrange()", "orderBy()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `typeof [] === ""array""`?",
              .Options = New String() {"true", "false", "undefined", "null"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you access a method inside an object?",
              .Options = New String() {"object.method()", "object->method()", "object[method]", "object(method)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following will remove whitespace from both ends of a string?",
              .Options = New String() {"trim()", "strip()", "clean()", "cut()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you convert a string into uppercase in JavaScript?",
              .Options = New String() {"toUpperCase()", "toUpper()", "changeToUpper()", "makeUpperCase()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to combine two arrays in JavaScript?",
              .Options = New String() {"concat()", "merge()", "append()", "combine()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `2 ** 3`?",
              .Options = New String() {"6", "8", "16", "9"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you check if a variable is an array in JavaScript?",
              .Options = New String() {"Array.isArray()", "isArray()", "checkArray()", "typeof array"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to search for a substring in a string?",
              .Options = New String() {"indexOf()", "search()", "find()", "match()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does the `continue` statement do in JavaScript?",
              .Options = New String() {"Skips an iteration", "Terminates the loop", "Pauses the loop", "Resets the loop"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is a closure in JavaScript?",
              .Options = New String() {"A function that remembers variables from its scope", "A global function", "A private function", "A nested object"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is used to handle asynchronous code?",
              .Options = New String() {"Promises", "Objects", "Functions", "Variables"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log([1, 2] == [1, 2])` output?",
              .Options = New String() {"true", "false", "undefined", "null"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to join elements of an array into a string?",
              .Options = New String() {"join()", "concat()", "append()", "merge()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is true for `null` in JavaScript?",
              .Options = New String() {"`null` is an object", "`null` is a string", "`null` is undefined", "`null` is a number"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log([1, 2, 3].map(x => x * 2))` output?",
              .Options = New String() {"[2, 4, 6]", "[1, 2, 3]", "2, 4, 6", "undefined"}, .CorrectAnswer = 4})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `typeof ""Hello""`?",
              .Options = New String() {"string", "object", "undefined", "char"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to reverse the order of elements in an array?",
              .Options = New String() {"reverse()", "invert()", "flip()", "backward()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which operator is used for nullish coalescing?",
              .Options = New String() {"??", "||", "&&&&", "==="}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which keyword is used to export a module in JavaScript?",
              .Options = New String() {"export", "module", "output", "publish"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does `const` keyword mean in JavaScript?",
              .Options = New String() {"The variable cannot be reassigned", "The variable cannot be changed", "The variable cannot be referenced", "The variable cannot be deleted"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you remove a property from a JavaScript object?",
              .Options = New String() {"delete", "remove", "drop", "clear"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to append an element to an array?",
              .Options = New String() {"push()", "append()", "insert()", "concat()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(typeof NaN)` output?",
              .Options = New String() {"number", "NaN", "undefined", "null"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you make a shallow copy of an array?",
              .Options = New String() {"slice()", "copy()", "clone()", "map()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is not a reserved keyword in JavaScript?",
              .Options = New String() {"var", "let", "debugger", "print"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you write an arrow function in JavaScript?",
              .Options = New String() {"(a, b) => a + b", "(a, b) => { return a + b }", "function (a, b) => a + b", "function a, b => return a + b"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(1 == ""1"")` output?",
              .Options = New String() {"true", "false", "null", "undefined"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `2 + 2 * 2` in JavaScript?",
              .Options = New String() {"6", "8", "4", "10"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is a promise in JavaScript?",
              .Options = New String() {"An object that represents the eventual completion of an async operation", "A callback function", "A synchronous function", "A data type"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method returns a promise that resolves when all promises resolve?",
              .Options = New String() {"Promise.all()", "Promise.race()", "Promise.resolve()", "Promise.then()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you define default parameters in JavaScript?",
              .Options = New String() {"function(a = 5)", "function default a = 5", "let a = 5", "var a = 5"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the purpose of `Array.prototype.reduce()`?",
              .Options = New String() {"Reduces an array to a single value", "Filters elements in an array", "Maps an array to a new array", "Sums the values in an array"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(true || false)` output?",
              .Options = New String() {"true", "false", "undefined", "null"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which keyword is used to import a module in JavaScript?",
              .Options = New String() {"import", "require", "fetch", "include"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which of the following is a valid way to define an object method?",
              .Options = New String() {"myMethod: function() {}", "myMethod() => {}", "myMethod: function[] {}", "myMethod = function() {}"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(null === undefined)` output?",
              .Options = New String() {"false", "true", "null", "undefined"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to combine all elements of an array into a string?",
              .Options = New String() {"join()", "concat()", "stringify()", "reduce()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What does `typeof []` return in JavaScript?",
              .Options = New String() {"object", "array", "null", "undefined"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to repeat a string a specified number of times?",
              .Options = New String() {"repeat()", "multiply()", "concat()", "join()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the output of `console.log(1 + true)`?",
              .Options = New String() {"2", "true", "1", "NaN"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method can be used to remove the first item from an array?",
              .Options = New String() {"shift()", "pop()", "unshift()", "splice()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you access the length of a string?",
              .Options = New String() {"string.length", "length(string)", "string.size()", "size(string)"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "Which method is used to execute a function after a specified delay?",
              .Options = New String() {"setTimeout()", "setInterval()", "setDelay(`", "setAfter()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What will `console.log(0 === false)` output?",
              .Options = New String() {"false", "true", "undefined", "null"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "How do you add a new property to an object?",
              .Options = New String() {"object.property = value;", "object->property = value;", "object(property, value)", "object.value = property;"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "JavaScript", .Text = "What is the result of `10 + ""10""` in JavaScript?",
              .Options = New String() {"1010", "20", "NaN", "undefined"}, .CorrectAnswer = 0})

    End Sub
End Module
