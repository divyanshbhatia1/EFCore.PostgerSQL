# Entity Framework Core with Postgre SQL
## How to use Entity Framework Core with Postgre SQL database in ASP.NET Core

This solution has two projects.
- EFCore.Data.PostgreSQL (Class Library .NET standard 2.1)
- EFCore.API (ASP.NET Core 3.1 Web API)

Steps to follow:
- Create empty solution project
- Add data project (Class Library .NET standard 2.1)
- Add following nuget package
    ```sh
    Npgsql.EntityFrameworkCore.PostgreSQL
    ```
- Add entities and context in the project
- Add API project
- Add following nuget package
    ```sh
    Microsoft.EntityFrameworkCore.Tools
    ```
- Add migrations using following command
    ```sh
    Add-Migration 'InitialMigration'
    ```
- Apply migrations using following command
    ```sh
    Update-Database
    ```
