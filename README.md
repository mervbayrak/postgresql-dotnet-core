# Npgsql - EF Core .NETCore data provider for PostgreSQL 

## Install NuGet packages

 - Core Layer
 - Data Access Layer
 - Business Layer
 - UI Layer

```
$ dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.7
```
 
```
$ dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.7
```

```
$ dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.4
```

## Migrations
Generate a new migration using Visual Studio Package Manager Console (from menu: Tools -> NuGet Package Manager -> Package Manager Console):
You have selected the Default Project Layer where DbContext is. And Startup Project =  Layer where DbContext is (My Project PostgreSql.DAL)

```
Add-Migration
```
 Or, from the command line via DotNet CLI:
```
$ dotnet ef migrations add Initial
```

Generate a new migration using Visual Studio Package Manager Console (from menu: Tools -> NuGet Package Manager -> Package Manager Console):

```
update-database
```
 Or, from the command line via DotNet CLI:
```
$ dotnet ef database update
```
