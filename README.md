# DotNet-Web-Api

>[1. Ingredients](#ingredients)
>
>[2. Include](#include)
>
>[3. Web API](#web-api)
>
>[4. Entity Framework Core](#entity-framework-core)
>
>[5. Authentication](#authentication)
>
>[6. Advanced Relationships EF Core](#advanced-relationships-ef-core)
>
>[7. Add packages](#add-packages)
>
>[8. .NET Commands](#dotnet-commands)
>
>[9. Create Migrations](#create-migrations)
>
>[10. Flow Program](#flow-of-the-program)
>
>[11. Docker Hub](#docker-hub)

---

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

#### [🔼 Back to top](#dotnet-web-api)

---

### **Include:**

- *Build a complete .NET 7 back-end with Web API, Entity Framework Core, SQL Server*
- *Implement Token Authentication with JSON Web Tokens & Roles*
- *Utilize all three types of relationships in database: one-to-one, one-to-many, many-to-many*
- *Use the HTTP request methods GET, POST, PUT & DELETE*
- *Implement best practices like a proper structure for Web API, Dependency Injection, asynchronous calls with async/await and Data-Transfer-Objects (DTOs)*
- *Use LINQ to filter, sort, map, select and access entities.*
- *Seed data with code-first migrations programmatically*

#### [🔼 Back to top](#dotnet-web-api)

---

### **Web API:**

- *The Model-View-Controller (MVC) pattern*
- *Create models and controllers*
- *Attribute routing (with parameters)*
- *The HTTP request methods GET, POST, PUT & DELETE*
- *Best practices for Web API like a ServiceResponse class and Data-Transfer-Objects (DTOs)*
- *Map models with AutoMapper*

#### [🔼 Back to top](#dotnet-web-api)

---

### **Entity Framework Core:**

- *Object-Relational-Mapping*
- *Code-First Migration*
- *SQL Server Express*
- *How to use a DataContext and a proper ConnectionString*
- *All previous HTTP requests with Entity Framework Core to save data in a SQL Server database*
- *Data Seeding: Insert data with a migration programmatically*

#### [🔼 Back to top](#dotnet-web-api)

---

### **Authentication:**

- *Token Authentication with JSON Web Tokens*
- *Claims*
- *Secure controllers with the Authorize attribute*
- *Add roles to the use*

#### [🔼 Back to top](#dotnet-web-api)

---

### **Advanced Relationships EF Core:**

- *One-to-one relationships*
- *One-to-many relationships*
- *Many-to-many relationships*

#### [🔼 Back to top](#dotnet-web-api)

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

#### [🔼 Back to top](#dotnet-web-api)

---

### **DotNet Commands:**

> **Check dotnet installation:**
```
dotnet
```

> **Check dotnet version:**
```
dotnet --version
```

> **Create new web api v.3.1 (out of support):**
```
dotnet new webapi -n dotnet-rpg-3.1 --framework netcoreapp3.1
```

> **Create new web api v.5 (out of support):**
```
dotnet new webapi -n dotnet-rpg-5 --framework net5.0
```

> **Create new web api v.6:**
```
dotnet new webapi -n dotnet-rpg-6 --framework net6.0
```

> **Create new web api v.7:**
```
dotnet new webapi -n dotnet-rpg-7 --framework net7.0
```

> **Build the project:**
```
dotnet build
```

> **Run the project:**
```
dotnet watch run
```

> **Add .gitignore file:**
```
dotnet new .gitignore
```

#### [🔼 Back to top](#dotnet-web-api)

---

### **Create Migrations:**

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

#### [🔼 Back to top](#dotnet-web-api)

---

### **Flow of the program:**
	
#### **JWT Bearer token is use in DotNet-RPG folder (for Postman collection)!*

> **About Postman file:**
- URL is localhost;
- Controllers are separated by folders with HTTP requests;
- Added test data in rows where is needed;
- Added postman test.

#### **To use Postman collection you must to import him in Postman, open project and make the migration and after that run dotnet-rpg with IIS Express.**

> **Auth:**
1.  POST:   Register
2.  POST:   Login -> JWT Bearer

> **Character:**
3.  GET:    Character Get All
4.  GET:    Character Get By Id
5.  POST:   Character Add
6.  POST:   Character Skill
7.  PUT:    Character Edit
8.  DELETE: Character Delete By Id

> **Fight:**
9.  GET:    Fight Get All
10. POST:   Fight
11. POST:   Fight Weapon
12. POST:   Fight Skill

> **Weapon:**
13. POST:   Weapon Add

#### [🔼 Back to top](#dotnet-web-api)

---

### **Docker Hub:**

> **Create .dockerignore file:**
```
New-Item .dockerignore
```

> **Check docker installation:**
```
docker
```

> **Check docker version**
```
docker --version
```

> **Docker login:**
```
docker login
```

> **List all containers:**
```
docker ps --all
```

> **Build docker image:**
```
docker build -t vilislavkalenski/dotnet-rpg-7 .
```

> **Build docker image with latest version:**
```
docker build -t vilislavkalenski/dotnet-rpg-7:latest .
```

> **Scan docker image**
```
docker scout quickview
```

> **Cves about docker image:**
```
docker scout cves vilislavkalenski/dotnet-rpg-7
```

> **Recommendations about docker image:**
```
docker scout recommendations vilislavkalenski/dotnet-rpg-7
```

> **Run docker image:**
```
docker run vilislavkalenski/dotnet-rpg-7
```

> **Run docker image with current port:**
```
docker run -p 8080:80 vilislavkalenski/dotnet-rpg-7
```

> **Push docker image in personal DockerHub:**
```
docker push vilislavkalenski/dotnet-rpg-7
```

> Link Docker Hub: https://hub.docker.com/

> Link to my personal public Docker Hub: https://hub.docker.com/u/vilislavkalenski

#### [🔼 Back to top](#dotnet-web-api)
