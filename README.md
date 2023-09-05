# .NET-7-Web-Api

what Include

### **Web API:**

> *The Model-View-Controller (MVC) pattern*
> *Create models and controllers*
> *Attribute routing (with parameters)*
> *The HTTP request methods GET, POST, PUT & DELETE*
> *Best practices for your Web API like a ServiceResponse class and Data-Transfer-Objects (DTOs)*
> *Map your models with AutoMapper*

---

### **Entity Framework Core:**

> *Object-Relational-Mapping*
> *Code-First Migration*
> *SQL Server Express*
> *How to use a DataContext and a proper ConnectionString*
> *All previous HTTP requests with Entity Framework Core to save your data in a SQL Server database*
> *Data Seeding: Insert data with a migration programmatically*

---

### **Authentication:**

> *Token Authentication with JSON Web Tokens*
> *Claims*
> *Secure controllers with the Authorize attribute*
> *Add roles to the use*

---

### **Advanced Relationships with Entity Framework Core:**

> One-to-one relationships
> One-to-many relationships
> Many-to-many relationships

---

### **Commands:**

> Check dotnet installation:
```
dotnet
```

> Check dotnet version:
```
dotnet --version
```

> Create new web api:
```
dotnet new webapi -n dotnet-rpg --framework net7.0
```

> Build the project:
```
dotnet build
```

> Run the project:
```
dotnet watch run
```

> Add .gitignore file:
```
dotnet new .gitignore
```

---

### **Add packages:**

> dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
> dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
> dotnet add package Microsoft.AspNetCore.OpenApi
> dotnet add package Microsoft.EntityFrameworkCore
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet add package Microsoft.EntityFrameworkCore.SQLServer
> dotnet add package Serilog
> dotnet add package Serilog.AspNetCore
> dotnet add package Serilog.Enrichers.Environment
> dotnet add package Serilog.Enrichers.Process
> dotnet add package Serilog.Enrichers.Thread
> dotnet add package Serilog.Extensions.Logging
> dotnet add package Serilog.Settings.Configuration
> dotnet add package Serilog.Sinks.BrowserConsole
> dotnet add package Serilog.Sinks.ColoredConsole
> dotnet add package Serilog.Sinks.Console