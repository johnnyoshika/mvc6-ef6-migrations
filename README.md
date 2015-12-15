Demonstrates the problem when using EF6 migrations with MVC 6.

Support this question on StackOverflow: http://stackoverflow.com/q/34237131/188740

The project names are confusing.  Here's a clarification:

* `src/MVC6_EF6_Migrations` --> MVC 6 startup project
* `Entities1` --> Class library that contains EF6 with migrations enabled.
* `src/Entities2` --> Class Library (Package) that contains EF6 with migrations enabled.

When you checkout the master branch, the `MVC6_EF6_Migrations` project will reference `Entities2`.  Just by running the `MVC6_EF6_Migrations` project, you will get a `FileNotFoundException` because of the incompatibility with EF6 migrations.
You can also test this with the `Class Library (Package)` assembly by deleting the reference to `Entities2` and adding a reference to `Entities`.
