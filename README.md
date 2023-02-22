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
11. Created the initial database schema using EF's migration feature

dotnet ef migrations add InitialCreate
dotnet ef database update

12. Navigation Theme added as link

13. Seedata added...5 properties added

14. Seed Initializer 

15. Datebase updated and submitted in BB


//CONTINUING FROM HERE FOR ASSIGNMENT 2

1. New Branch created as Asg_02 and committing.

2. Adding 2 new property to the Branch Int and String

3. Getting error with updates on Database run... committing till here!
    running command - dotnet ef migration add "updated changes to NoOPools & AlottedPool"
    dotnet ef database update

4. Validation entry required for each property, code Required has been added to all properties. Range Added to the new property and character limits added to rest of the string properties. Committing

5. Forgot to update CRUD pages ...completing now and running ef commands...committing till here
    dotnet ef migrations add "rating Database"
    dotnet ef database update

6. Adding search criteria - getting error with updates on Database run...as Cannot implicitly convert type. Committing till here, will resolve the issue.