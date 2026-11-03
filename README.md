# Employee CRUD - ASP.NET Core MVC + SQL Server

A basic Create, Read, Update, Delete (CRUD) employee management application.

## Pages
- **Create Employee**: `Employees/Create`
- **Employee List**: `Employees/Index`
- **Edit Employee**: `Employees/Edit/{id}`
- **Delete**: action from the list page (confirmation included)

## Technology
- ASP.NET Core MVC (.NET 8)
- Entity Framework Core 8
- Microsoft SQL Server / LocalDB
- Bootstrap 5

## Requirements
- .NET 8 SDK
- SQL Server LocalDB, SQL Server Express, or SQL Server
- Visual Studio 2022 (ASP.NET and web development workload)

## Run using Visual Studio
1. Open `EmployeeCRUD.csproj`.
2. Check `appsettings.json` and update `DefaultConnection` if your SQL Server instance differs.
3. Open **Tools → NuGet Package Manager → Package Manager Console** and run:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```
   Or install `dotnet-ef` and run:
   ```bash
   dotnet tool install --global dotnet-ef
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
4. Press F5 / run the project. The default route opens the Employee List.

## Run using CLI
```bash
dotnet restore
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

## SQL schema (created by EF migration)
`Employees`: Id (int identity PK), FullName (nvarchar(100)), Email (nvarchar(150), unique), Department (nvarchar(50)), Designation (nvarchar(100)), Salary (decimal(18,2)), JoiningDate (datetime2).

## CRUD flow
- GET `Employees/Create` -> form
- POST `Employees/Create` -> validate and insert
- GET `Employees/Index` -> list
- GET `Employees/Edit/{id}` -> populate edit form
- POST `Employees/Edit/{id}` -> validate and update
- POST `Employees/Delete/{id}` -> delete

Email uniqueness is validated in the controller and enforced by a database unique index. Forms include anti-forgery tokens.
