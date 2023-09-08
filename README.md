# .NET-Web-Api

### **Ingredients**

1. .NET SDK (free):
    - .NET Core 3.1 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/3.1
    - .NET 5 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/5.0
    - .NET 6 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/6.0
    - .NET 7 SDK (free): https://dotnet.microsoft.com/en-us/download/dotnet/7.0
2. Visual Studio Community (free): https://visualstudio.microsoft.com/downloads/
3. VS Code (free): https://code.visualstudio.com/download
4. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download
5. GitHub Desktop (free): https://desktop.github.com/
6. SQL Server Management Studio (free):
    - https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
    
    *(or DBeaver for Linux or Mac users)*
7. Docker (optional to set up SQL Server) (free): https://www.docker.com/products/docker-desktop/

#### [🔼 Back to top](#dependency-injection)

---

### **Include:**

- *Build a complete .NET 7 back-end with Web API, Entity Framework Core, SQL Server*
- *Implement Token Authentication with JSON Web Tokens & Roles*
- *Utilize all three types of relationships in your database: one-to-one, one-to-many, many-to-many*
- *Use the HTTP request methods GET, POST, PUT & DELETE*
- *Implement best practices like a proper structure for your Web API, Dependency Injection, asynchronous calls with async/await and Data-Transfer-Objects (DTOs)*
- *Use LINQ to filter, sort, map, select and access your entities.*
- *Seed data with code-first migrations programmatically*

#### [🔼 Back to top](#dependency-injection)

---

### **Web API:**

- *The Model-View-Controller (MVC) pattern*
- *Create models and controllers*
- *Attribute routing (with parameters)*
- *The HTTP request methods GET, POST, PUT & DELETE*
- *Best practices for your Web API like a ServiceResponse class and Data-Transfer-Objects (DTOs)*
- *Map your models with AutoMapper*

#### [🔼 Back to top](#dependency-injection)

---

### **Entity Framework Core:**

- *Object-Relational-Mapping*
- *Code-First Migration*
- *SQL Server Express*
- *How to use a DataContext and a proper ConnectionString*
- *All previous HTTP requests with Entity Framework Core to save your data in a SQL Server database*
- *Data Seeding: Insert data with a migration programmatically*

#### [🔼 Back to top](#dependency-injection)

---

### **Authentication:**

- *Token Authentication with JSON Web Tokens*
- *Claims*
- *Secure controllers with the Authorize attribute*
- *Add roles to the use*

#### [🔼 Back to top](#dependency-injection)

---

### **Advanced Relationships with Entity Framework Core:**

- One-to-one relationships
- One-to-many relationships
- Many-to-many relationships

#### [🔼 Back to top](#dependency-injection)

---

### **Add packages:**

- dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
- dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
- dotnet add package Microsoft.AspNetCore.OpenApi
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.SQLServer
- dotnet add package Serilog
- dotnet add package Serilog.AspNetCore
- dotnet add package Serilog.Enrichers.Environment
- dotnet add package Serilog.Enrichers.Process
- dotnet add package Serilog.Enrichers.Thread
- dotnet add package Serilog.Extensions.Logging
- dotnet add package Serilog.Settings.Configuration
- dotnet add package Serilog.Sinks.BrowserConsole
- dotnet add package Serilog.Sinks.ColoredConsole
- dotnet add package Serilog.Sinks.Console

#### [🔼 Back to top](#dependency-injection)

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

#### [🔼 Back to top](#dependency-injection)

---

### **Create Migrations**

> **Check .NET Entity Framework:**
```
dotnet-ef
```

> **Update dotnet-ef tool to last version:**
```
dotnet tool update --global dotnet-ef
```

> **Create first migration:**
```
dotnet-ef migrations add 'InitialCreate'
```

> **Update database:**
```
dotnet-ef database update
```

#### [🔼 Back to top](#data-transfer-objects)

---

### **Flow of the program (Swagger or Postman file):**
	
#### **JWT Bearer token is use in DotNet-RPG folder!*

1. Register
2. Login -> JWT Bearer
3. Character Get All
4. Character Get By Id
5. Character Add
6. Character Skill
7. Character Edit
8. Character Delete By Id
9. Fight Get All
10. Fight
11. Fight Weapon
12. Fight Skill
13. Weapon Add

> About Postman file:
- URL is localhost;
- Separated by folders;
- Added test data where is needed;
- Added postman test.