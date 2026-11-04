# Task Manager

A task management web application built with ASP.NET Core MVC. 

## Features
- Users can register and log in (Cookkie-based authentication). 
- Users are able to create, view, edit and delete tasks.
- Server-side form validation

## Technology
- C# and ASP.NET Core MVC (.NET 10)
- Entity Framework Core w/ SQLite
- ASP.NET Identity (Cookie authentication)
- Razor views, model validation, dependency injection.

## Getting Started

### Prerequisites
- Install the [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Install Git

1. Clone the repository:
    ```bash
    git clone https://github.com/Asotolara/TaskManager.Web.git
    cd TaskManager.Web
    ```
2. Install EF Core tools:
    ```bash 
    dotnet tool install --global dotnet-ef
    ```
3. Create the database:
    ```bash
    dotnet ef database update
    ```
4. Start the app:
    ```bash
    dotnet run
    ```
5. Open the `localhost` URL shown in the terminal, register, and log in.

## Planned Improvement
- Associate tasks with indiviual users
- Projects and due-date filtering
- REST API and React front end