# Boston Optics 
Sunglass Store project created with C# and .NET MVC. Project created with Clean Architecture and Generic Repository Design.


## Migrations

## Infrastructure
Firstly, set the project "Web" as startup project.<br>
Choose Infrastructure on package manager console.<br>

```
Add-Migration InitialCreate -context ShopContext -o Data/Migrations
Update-Database -context ShopContext

Add-Migration IdentityInitial -context AppIdentityDbContext -o Identity/Migrations
Update-Database -context AppIdentityDbContext
```


## Packages Installed

### Web
```
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.AspNetCore.Identity.UI -v 6.0.14
Install-Package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.EntityFrameworkCore.Design -v 6.0.14
```
### Application Core
```
Install Package Ardalis.Specification -v 6.1.0
```
### Infrastructure
```
Install-Package Microsoft.EntityFrameworkCore -v 6.0.14
Install-Package Microsoft.EntityFrameworkCore.Tools -v 6.0.14
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -v 6.0.8
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.14
Install-Package Ardalis.Specification.EntityFrameworkCore -v 6.1.0
```

## Resources
### Documentation
* https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/
### GitHub Sample
* https://github.com/dotnet-architecture/eShopOnWeb
### E-Book
* https://aka.ms/webappebook

