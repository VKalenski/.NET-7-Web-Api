# .NET-7-Web-Api


---

dotnet

dotnet --version

dotnet new webapi -n dotnet-rpg --framework net7.0

dotnet build

dotnet watch run

dotnet new .gitignore



dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.AspNetCore.OpenApi
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLServer
dotnet add package Swashbuckle.AspNetCore.Filters

dotnet add package Serilog
dotnet add package Serilog.AspNetCore
dotnet add package Serilog.Enrichers.Environment
dotnet add package Serilog.Enrichers.Process
dotnet add package Serilog.Enrichers.Thread
dotnet add package Serilog.Extensions.Logging
dotnet add package Serilog.Settings.Configuration
dotnet add package Serilog.Sinks.BrowserConsole
dotnet add package Serilog.Sinks.ColoredConsole
dotnet add package Serilog.Sinks.Console