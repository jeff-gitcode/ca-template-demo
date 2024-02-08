# ca_webapi_only_demo



```dotnetcli

# install template
$ dotnet new install Clean.Architecture.Solution.Template::8.0.0

# To create a ASP.NET Core Web API-only solution:
$ dotnet new ca-sln -cf None -o ca-webapi-only-demo

# Launch the app:
$ cd src/Web
$ dotnet run

# To create a command
$ cd src/application
$ dotnet new ca-usecase --name CreateCustomer --feature-name Customers --usecase-type command --return-type int

# To create a query:
$ dotnet new ca-usecase -n GetCustomers -fn Customers -ut query -rt CustomerVm



```

The project was generated using the [Clean.Architecture.Solution.Template](https://github.com/jasontaylordev/ca_webapi_only_demo) version 8.0.0.

## Build

Run `dotnet build -tl` to build the solution.

## Run

To run the web application:

```bash
cd .\src\Web\
dotnet watch run
```

Navigate to https://localhost:5001. The application will automatically reload if you change any of the source files.

## Code Styles & Formatting

The template includes [EditorConfig](https://editorconfig.org/) support to help maintain consistent coding styles for multiple developers working on the same project across various editors and IDEs. The **.editorconfig** file defines the coding styles applicable to this solution.

## Code Scaffolding

The template includes support to scaffold new commands and queries.

Start in the `.\src\Application\` folder.

Create a new command:

```
dotnet new ca-usecase --name CreateTodoList --feature-name TodoLists --usecase-type command --return-type int
```

Create a new query:

```
dotnet new ca-usecase -n GetTodos -fn TodoLists -ut query -rt TodosVm
```

If you encounter the error *"No templates or subcommands found matching: 'ca-usecase'."*, install the template and try again:

```bash
dotnet new install Clean.Architecture.Solution.Template::8.0.0
```

## Test

The solution contains unit, integration, and functional tests.

To run the tests:
```bash
dotnet test
```

## Help
To learn more about the template go to the [project website](https://github.com/JasonTaylorDev/ca_webapi_only_demo). Here you can find additional guidance, request new features, report a bug, and discuss the template with other users.