# DB ORM package Postgres
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0.7
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL.Design --version 1.1.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.11
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.3



# uliti package 
dotnet add package Newtonsoft.Json



# cli database 
dotnet ef migrations add InitialCreate
dotnet ef database update



# cli run
dotnet run 
dotnet watch

# cli publish 
dotnet publish 