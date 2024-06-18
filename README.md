# Title : Student Management System
# .NET CORE 8 WEB API
# CRUD

***
# Author
- [SAHAL](https://github.com/sahal56)

***
STEPS:
1. Create Web Api Project
2. Intall Nuget Packages: EntityFrameworkCore EFC, EFC.Tools, Database-specific Driver Package e.g. EFC.SqlServer
3. Create Models and Contex class
4. Connect Database Settings
  1. Get Connection settings/information from your Database MySql or SQL or Orcale
  2. using above details, add ConnectionString in appsettings.json
  3. Update Program.cs to use above ConnectionString and Context
  4. Run Commands in Package Manager Console
6. Migration
  1. Open Package Manager Console and Run Commands
  2. `Add-Migration "Init"`
  3. `Update-Database`
  4. Check Database Client wheter Database-Tables Schema is created or not
5. Create Webapi Controller >  EF with actions
6. Run Project

# NOTE :  DOCKER support comming in next update
