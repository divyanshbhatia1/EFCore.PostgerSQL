# Entity Framework Core

### How to use Entity Framework Core with Postgre SQL database in ASP.NET Core

Steps to follow:
- Add data project (Class Library .NET standard 2.1)
- Add nuget package
    ```sh
    Npgsql.EntityFrameworkCore.PostgreSQL
    ```
- Add entities and context in the project
- Add API project
- Add nuget package in API project
    ```sh
    Microsoft.EntityFrameworkCore.Tools
    ```
- Add migrations using command
    ```sh
    Add-Migration 'InitialMigration'
    ```
- Apply migrations using command
    ```sh
    Update-Database
    ```

### How to use Entity Framework Core with SQL Server database in ASP.NET Core

Steps to follow:
- Add data project (Class Library .NET standard 2.1)
- Add nuget package
    ```sh
    Microsoft.EntityFrameworkCore.Tools
    ```
- Add entities and context in the project
- Add API project
- Add nuget package
    ```sh
    Microsoft.EntityFrameworkCore.Tools
    ```
- Add migrations using command
    ```sh
    Add-Migration 'InitialMigration'
    ```
- Apply migrations using command
    ```sh
    Update-Database
    ```
