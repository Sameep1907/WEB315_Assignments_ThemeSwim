# WEB315_Assignments_ThemeSwim

1. Created Private repository name WEB315_Assignments_ThemeSwim
2. gitignore created
3. readme.md created
4. collaboration link sent to proff Majid
5. Creating new webapp and committing
6. changes made to welcome page
7. created model folder with ThemeSwim.cs name
8. 6 properties added including one ID and one Date input...committing
9. Installing the EF Tools and NuGet packages

    dotnet tool install --global dotnet-ef --version 5
    dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*
10. Using the Scaffolding terminal commands to build out CRUD pages for model and committing.

    dotnet-aspnet-codegenerator razorpage -m ThemeSwim -dc ThemeSwimContext -udl -outDir Pages/ThemeSwim --referenceScriptLibraries -sqlite
11. 