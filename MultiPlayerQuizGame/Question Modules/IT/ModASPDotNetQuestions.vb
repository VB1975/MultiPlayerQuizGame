Imports MultiPlayerQuizGame.ClsDataStructures

Module ModASPDotNetQuestions

    Public Sub ASPDotNetQuestions()

        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does ASP.NET stand for?",
              .Options = New String() {"Active Server Pages Network", "Active Server Pages New Technology", "Active Server Pages for .NET", "Application Server Pages for .NET"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is a server-side technology in ASP.NET?",
              .Options = New String() {"CSS", "JavaScript", "Web Forms", "HTML"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the file extension for ASP.NET web forms?",
              .Options = New String() {".html", ".aspx", ".php", ".js"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the main entry point for an ASP.NET application?",
              .Options = New String() {"WebForm.aspx", "Global.asax", "Default.aspx", "App.config"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which ASP.NET object is used to store data on a per-user basis?",
              .Options = New String() {"Application", "Session", "ViewState", "Cache"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does MVC stand for in ASP.NET?",
              .Options = New String() {"Model-View-Controller", "Model-Variable-Class", "Monitor-View-Component", "Module-View-Code"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In which year was ASP.NET first released?",
              .Options = New String() {"1999", "2002", "2005", "2008"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is NOT a valid lifecycle event in an ASP.NET page?",
              .Options = New String() {"Page_Init", "Page_Render", "Page_Load", "Page_Shutdown"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `Runat=""Server""` attribute in ASP.NET?",
              .Options = New String() {"To make the control run on the client", "To make the control run on the server", "To validate the control", "To hide the control"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following controls is used for user input in ASP.NET?",
              .Options = New String() {"Label", "TextBox", "Image", "GridView"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default method to submit a form in ASP.NET?",
              .Options = New String() {"POST", "GET", "PUT", "DELETE"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following allows caching in ASP.NET?",
              .Options = New String() {"Session", "Application", "Cache", "ViewState"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, which directive is used to define page-specific attributes?",
              .Options = New String() {"Page", "Form", "CodeBehind", "Session"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `Global.asax` file in ASP.NET?",
              .Options = New String() {"To handle application-level events", "To define page-specific styles", "To store session data", "To create HTML layouts"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what is the full form of ADO?",
              .Options = New String() {"Active Data Objects", "ActiveX Data Objects", "Application Data Objects", "Asynchronous Data Objects"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the role of the `Web.config` file?",
              .Options = New String() {"To handle session data", "To store configuration settings", "To create HTML layouts", "To display database records"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is an authentication mode in ASP.NET?",
              .Options = New String() {"Windows Authentication", "API Authentication", "OAuth Authentication", "Token Authentication"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `EnableViewState` property in ASP.NET control?",
              .Options = New String() {"ViewPage rendering", "Maintaining page and control values during postback", "Session state management", "Form validation"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of these is NOT a valid ASP.NET validation control?",
              .Options = New String() {"RequiredFieldValidator", "RangeValidator", "FormValidator", "CompareValidator"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the maximum number of web.config files that an ASP.NET project can have?",
              .Options = New String() {"1", "2", "Unlimited", "10"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, which method is called to end a user session?",
              .Options = New String() {"Session.Abandon()", "Session.End()", "Session.Clear()", "Session.Stop()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the primary difference between ASP.NET WebForms and ASP.NET MVC?",
              .Options = New String() {"WebForms use code-behind, MVC uses a controller", "WebForms support HTML, MVC doesn't", "MVC requires JavaScript, WebForms doesn't", "WebForms are faster than MVC"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which protocol does ASP.NET use by default for transferring data?",
              .Options = New String() {"TCP", "FTP", "HTTP", "IPX"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default session timeout in ASP.NET?",
              .Options = New String() {"10 minutes", "20 minutes", "30 minutes", "60 minutes"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which control in ASP.NET is used to display data in a tabular format?",
              .Options = New String() {"TextBox", "GridView", "DropDownList", "CheckBox"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `Response.Redirect` method in ASP.NET?",
              .Options = New String() {"To stop the current page from rendering", "To navigate to a new page", "To store session data", "To validate input fields"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what is the purpose of the `Server.Transfer` method?",
              .Options = New String() {"Transfers data between two web servers", "Transfers control from one page to another without changing the URL", "Transfers data between two databases", "Transfers data from client to server"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is a valid ASP.NET authentication mode?",
              .Options = New String() {"Passport", "Forms", "WebAPI", "Basic"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `Trace` object in ASP.NET do?",
              .Options = New String() {"Displays database records", "Displays debugging and tracing messages", "Validates form inputs", "Transfers files between servers"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what does a `Master Page` do?",
              .Options = New String() {"Defines page styles", "Acts as a template for other pages", "Stores session data", "Validates user input"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `Response.Write` method in ASP.NET?",
              .Options = New String() {"To write data to the server", "To write data to the client browser", "To write data to a file", "To write data to the database"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which ASP.NET control is used to link to external web pages?",
              .Options = New String() {"TextBox", "HyperLink", "DropDownList", "Image"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what is the purpose of the `App_Code` folder?",
              .Options = New String() {"To store HTML templates", "To store compiled classes and code files", "To store static images", "To store web configuration files"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default view engine in ASP.NET MVC?",
              .Options = New String() {"Razor", "Web Forms", "PHP", "React"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `ViewBag` in ASP.NET MVC?",
              .Options = New String() {"To store cookies", "To pass temporary data from controller to view", "To validate form inputs", "To store session data"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what does the `Runat=""Server""` attribute specify?",
              .Options = New String() {"The control should run on the client-side", "The control should run on the server-side", "The control should handle database operations", "The control should execute asynchronously"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is NOT a feature of ASP.NET MVC?",
              .Options = New String() {"Separation of concerns", "Testability", "PostBack", "RESTful routing"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, which object is used to send email?",
              .Options = New String() {"SmtpClient", "MailBox", "Emailer", "HttpMailer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `BundleConfig.cs` file in ASP.NET?",
              .Options = New String() {"To configure database connections", "To bundle and minify scripts and styles", "To manage session state", "To configure routes"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, what is a `ViewModel`?",
              .Options = New String() {"A controller", "A representation of the data passed to the view", "A service for web API", "A compiled DLL file"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `HttpResponse.StatusCode` property do in ASP.NET?",
              .Options = New String() {"Returns the HTTP status code to the client", "Stops the current request", "Validates the request", "Handles session data"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which method is used to render partial views in ASP.NET MVC?",
              .Options = New String() {"@RenderPartial", "@Html.Partial", "@IncludePartial", "@Html.Include"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default value of `SessionState` in ASP.NET?",
              .Options = New String() {"Off", "InProc", "SQLServer", "Custom"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `RegisterRoutes` method in ASP.NET MVC?",
              .Options = New String() {"To define routes for MVC applications", "To define controller actions", "To manage session data", "To register users"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET Web API, which HTTP verb is used for retrieving data?",
              .Options = New String() {"POST", "GET", "PUT", "DELETE"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which ASP.NET object allows sharing data across all users of the application?",
              .Options = New String() {"ViewState", "Session", "Application", "Cache"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the main purpose of the `TempData` object in ASP.NET MVC?",
              .Options = New String() {"To pass data from one action to another across requests", "To store session data", "To pass data between controllers", "To persist data across the entire session"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which method is used to stop the execution of the current page in ASP.NET?",
              .Options = New String() {"Response.Stop()", "Response.End()", "Server.Stop()", "Server.Clear()"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `RouteConfig` file in ASP.NET MVC?",
              .Options = New String() {"To configure URL routing for the application", "To configure authentication settings", "To manage session state", "To define controller logic"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, which method is used to render views from a controller?",
              .Options = New String() {"View()", "ShowView()", "RenderView()", "DisplayView()"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what does the term ""postback"" refer to?",
              .Options = New String() {"Sending data from server to client", "Reloading the same page on the server", "Sending data between databases", "Retrieving data from a web service"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the main role of the `Entity Framework` in ASP.NET?",
              .Options = New String() {"To handle authentication", "To manage database operations", "To define controllers", "To render views"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default view folder in an ASP.NET MVC application?",
              .Options = New String() {"/App_Data/", "/Views/", "/Pages/", "/Content/"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which attribute is used to define HTTP methods for Web API actions?",
              .Options = New String() {"[HttpPost]", "[HttpGet]", "[HttpRequest]", "[HttpData]"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, which object helps in passing data from the controller to the view?",
              .Options = New String() {"ControllerData", "Model", "TempData", "ViewState"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is NOT a method to manage state in ASP.NET?",
              .Options = New String() {"ViewState", "Session", "Cookie", "WebService"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `Authorize` attribute in ASP.NET MVC?",
              .Options = New String() {"To authenticate users", "To restrict access to authorized users only", "To log user activities", "To validate user inputs"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default HTTP verb used when submitting a form in ASP.NET MVC?",
              .Options = New String() {"POST", "GET", "PUT", "DELETE"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, what is a `PartialView`?",
              .Options = New String() {"A full-page view", "A reusable section of a view", "A controller action", "A database connection"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is a built-in data access method in ASP.NET?",
              .Options = New String() {"Linq to SQL", "JSON", "Dapper", "JavaScript"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does `AJAX` stand for in the context of ASP.NET?",
              .Options = New String() {"Asynchronous JavaScript and XML", "Active Java Application Exchange", "Advanced Java and XML", "Asynchronous Java Access"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the main function of the `Web API` in ASP.NET?",
              .Options = New String() {"To create desktop applications", "To build RESTful services", "To handle database operations", "To manage server-side authentication"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the `Request.QueryString` used for in ASP.NET?",
              .Options = New String() {"To retrieve form values", "To retrieve values sent via the URL", "To retrieve session data", "To retrieve server logs"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, how do you specify that an action method should respond to HTTP POST requests?",
              .Options = New String() {"[PostMethod]", "[HttpPost]", "[HttpRequest]", "[RequestType(Post)]"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is an ASP.NET AJAX server-side control?",
              .Options = New String() {"UpdatePanel", "TextBox", "Button", "DropDownList"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `Html.RenderAction()` method do in ASP.NET MVC?",
              .Options = New String() {"Renders a partial view", "Renders the output of a child action method", "Renders a JavaScript file", "Renders an image"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of `ViewData` in ASP.NET MVC?",
              .Options = New String() {"To validate user input", "To pass data from the controller to the view", "To render views in partial format", "To store session data"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the significance of the `RouteData` object in ASP.NET MVC?",
              .Options = New String() {"Stores controller and action names extracted from the URL", "Manages view files", "Stores cookies", "Handles exceptions in the controller"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which directive is used to link a code-behind file with an .aspx page?",
              .Options = New String() {"CodeFile", "Inherits", "CodeBehind", "Src"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, which result type is used to return JSON data?",
              .Options = New String() {"ViewResult", "RedirectResult", "JsonResult", "FileResult"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is NOT a valid state management technique in ASP.NET?",
              .Options = New String() {"Cookies", "ViewState", "Session", "QueryView"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default page load event in ASP.NET?",
              .Options = New String() {"Page_Render", "Page_Init", "Page_Load", "Page_PreRender"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, which object allows sharing data between multiple web pages?",
              .Options = New String() {"Application", "Session", "ViewState", "Response"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `OutputCache` directive in ASP.NET?",
              .Options = New String() {"To cache data on the client side", "To cache the output of an ASP.NET page or control", "To cache server-side events", "To cache JavaScript files"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which component in ASP.NET MVC is responsible for handling incoming requests?",
              .Options = New String() {"Controller", "View", "Model", "WebService"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, how do you disable ViewState for a specific control?",
              .Options = New String() {"ViewState = false;", "EnableViewState=""false""", "DisableViewState=""true""", "ViewStateEnabled = false;"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which method is used to start a session in ASP.NET?",
              .Options = New String() {"Session.Create()", "Session.Init()", "Session_Start()", "Session.New()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the role of the `WebMethod` attribute in ASP.NET Web Services?",
              .Options = New String() {"It defines a public method in the service that can be called by clients", "It defines an authentication method", "It sets the return type of the web service", "It caches the web service results"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which of the following is NOT a built-in template in ASP.NET WebForms?",
              .Options = New String() {"Master Page", "Content Page", "User Control", "Model"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, what is the role of `ActionResult`?",
              .Options = New String() {"Defines the data model", "Defines the URL routing", "Defines the result of an action method", "Defines the database schema"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the primary advantage of using Razor syntax in ASP.NET MVC?",
              .Options = New String() {"It supports both server and client-side code", "It is simpler and more concise compared to WebForms", "It supports JavaScript natively", "It requires less server memory"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which ASP.NET WebForms control is used for displaying hierarchical data?",
              .Options = New String() {"GridView", "TreeView", "ListBox", "Repeater"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the function of `Html.BeginForm()` in ASP.NET MVC?",
              .Options = New String() {"Renders a submit button", "Renders an HTML form tag with a specified action", "Renders a link to another page", "Renders a partial view"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, which object is used to cache a page's output?",
              .Options = New String() {"Response.Cache", "HttpCache", "OutputCache", "PageCache"}, .CorrectAnswer = 6})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the main use of `HttpUtility.UrlEncode` in ASP.NET?",
              .Options = New String() {"To encode URL fragments so they can be safely transmitted over HTTP", "To encrypt URL data", "To render HTML on a webpage", "To create unique URLs for caching"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, which method is used to return a file for download?",
              .Options = New String() {"DownloadFile()", "ReturnFile()", "File()", "RenderFile()"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does `Response.WriteFile` do in ASP.NET?",
              .Options = New String() {"Writes data to the client’s filesystem", "Sends a file to the client", "Writes data to a log file", "Writes output to the database"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the default return type of a Web API action method in ASP.NET?",
              .Options = New String() {"ActionResult", "JsonResult", "HttpResponseMessage", "ViewResult"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what is the purpose of the `Literal` control?",
              .Options = New String() {"To allow user input", "To display static text that is not rendered in a control tag", "To display dynamic text with formatting", "To allow data-binding"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `AntiForgeryToken()` method prevent in ASP.NET MVC?",
              .Options = New String() {"SQL injection", "Cross-site request forgery (CSRF) attacks", "Cross-site scripting (XSS)", "Man-in-the-middle attacks"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `Application_BeginRequest` method do in Global.asax?",
              .Options = New String() {"Handles all session start events", "Handles all application-level request processing", "Handles all authentication events", "Handles all form submission events"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET MVC, what does the `Scaffold` template do?",
              .Options = New String() {"Generates database schema", "Generates code for CRUD operations", "Generates security configurations", "Generates API documentation"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the function of the `WebSocket` protocol in ASP.NET?",
              .Options = New String() {"To manage user sessions", "To enable full-duplex communication between the server and the client", "To encrypt web requests", "To render views on the client side"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what does `Server.MapPath` do?",
              .Options = New String() {"Converts a virtual path to a physical path", "Converts a physical path to a virtual path", "Maps server routes", "Resolves domain names"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of `HttpContext.Current` in ASP.NET?",
              .Options = New String() {"To access the server’s file system", "To access the current HTTP request and response objects", "To manage session data", "To store application data"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What is the purpose of the `MasterPage` in ASP.NET WebForms?",
              .Options = New String() {"To define a base layout for multiple pages", "To define CSS for a website", "To define JavaScript scripts", "To handle form submissions"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `HandleError` attribute do in ASP.NET MVC?",
              .Options = New String() {"Handles HTTP requests", "Handles exceptions and displays custom error pages", "Logs user errors", "Handles session management"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "What does the `ValidateAntiForgeryToken` attribute do in ASP.NET MVC?",
              .Options = New String() {"Validates form inputs", "Prevents CSRF attacks", "Encrypts cookies", "Handles routing"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "In ASP.NET, what is the purpose of the `FormView` control?",
              .Options = New String() {"To display data in a single record at a time", "To display data in a tabular format", "To manage file uploads", "To display hierarchical data"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "ASP.NET", .Text = "Which method in ASP.NET MVC is used to return a redirect response to a different URL?",
              .Options = New String() {"Redirect()", "RedirectToAction()", "RedirectResult()", "Response.Redirect()"}, .CorrectAnswer = 1})

    End Sub
End Module
