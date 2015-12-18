Demonstrates the problem when using EF6 migrations with MVC 6.

Support this question on StackOverflow: http://stackoverflow.com/q/34237131/188740

The project names are confusing.  Here's a clarification:

* `src/MVC6_EF6_Migrations` --> MVC 6 startup project
* `Entities1` --> Class library that contains EF6 with migrations enabled.
* `src/Entities2` --> Class Library (Package) that contains EF6 with migrations enabled.

### Solution

* Used: https://github.com/staff0rd/entityframework-migrations
* Created `Configuration.cs`: https://github.com/johnnyoshika/mvc6-ef6-migrations/blob/master/src/Entities/Migrations/Configuration.cs
* cd into data context directory and ran:
* `dnx ef add Migration_Name -c "Server=.;Database=MVC6_EF6_Migrations;Integrated Security=SSPI;" -p "System.Data.SqlClient"`

 
