# Employee Management System

A web-based Employee Management System built using **ASP.NET Core MVC, C#, Entity Framework Core, and Microsoft SQL Server**. This application allows users to manage employee records through a simple and user-friendly interface.

## 🚀 Features

- Create new employee records
- View employee details
- Update existing employee information
- Delete employee records
- Store employee data in SQL Server
- Use Entity Framework Core for database operations
- Responsive user interface using Bootstrap
- Database migrations using Entity Framework Core

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| C# | Backend programming |
| ASP.NET Core MVC | Web application framework |
| Entity Framework Core | Database operations |
| Microsoft SQL Server | Database |
| Razor Views | Frontend |
| HTML & CSS | Web page structure and styling |
| Bootstrap | Responsive UI |
| Git & GitHub | Version control |

## 📋 Employee Details

The application manages the following employee information:

- Employee ID
- Full Name
- Email
- Department
- Designation
- Salary
- Joining Date

## ⚙️ Installation and Setup

### Prerequisites

Install the following software:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Git](https://git-scm.com/downloads)
- Visual Studio or Visual Studio Code

### 1. Clone the repository

```bash
git clone https://github.com/Manojsiva7272/EmployeeCRUD-MVC.git
```

### 2. Navigate to the project directory

```bash
cd EmployeeCRUD-MVC
```

### 3. Configure the database

Open `appsettings.json` and configure the SQL Server connection string according to your SQL Server or LocalDB installation.

### 4. Restore dependencies

```bash
dotnet restore
```

### 5. Apply database migrations

```bash
dotnet ef database update
```

If Entity Framework tools are not installed:

```bash
dotnet tool install --global dotnet-ef
```

### 6. Run the application

```bash
dotnet run
```

Open the local URL shown in the terminal to access the application.

## 📁 Project Structure

```text
EmployeeCRUD-MVC/
│
├── Controllers/
│   └── EmployeesController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Models/
│   └── Employee.cs
│
├── Migrations/
│
├── Views/
│   ├── Employees/
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Index.cshtml
│   │   └── _EmployeeForm.cshtml
│   │
│   ├── Shared/
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── appsettings.json
├── Program.cs
├── EmployeeCRUD.csproj
└── README.md
```

## 💡 CRUD Operations

| Operation | Description |
|---|---|
| Create | Add a new employee |
| Read | View employee records |
| Update | Modify employee information |
| Delete | Remove employee records |

## 🎯 Project Objective

The objective of this project is to understand and implement CRUD operations using ASP.NET Core MVC and SQL Server, while learning how to connect a web application to a relational database using Entity Framework Core.

## 👨‍💻 Developer

**Manoj S**

GitHub: [Manojsiva7272](https://github.com/Manojsiva7272)

## 📌 Repository

[Employee Management System – GitHub](https://github.com/Manojsiva7272/EmployeeCRUD-MVC)
