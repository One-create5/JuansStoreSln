# JuansStoreSln
This is a class build MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstration purposes. 
## Link
[Pro ASP.NET Core 3 Textbook](https://www.apress.com/gp/book/9781484254394)


## Build Script 
dotnet new globaljson --sdk-version 3.1.101 --output JuansStoreSln/FightGearProducts
dotnet new web --no-https --output JuansStoreSln/FightGearProducts --framework netcoreapp3.1
dotnet new sln -o JuansStoreSln
dotnet sln JuansStoreSln add JuansStoreSln/FightGearProducts 
dotnet new xunit -o JuansStoreSln/FightGearProducts.Tests --framework netcoreapp3.1
dotnet sln JuansStoreSln add JuansStoreSln/FightGearProducts.Tests 
dotnet add JuansStoreSln/FightGearProducts.Tests reference JuansStoreSln/FightGearProducts 

# Chapter 7
## Image 

![Step 1](https://github.com/One-create5/JuansStoreSln/blob/master/images/Step1_p128.JPG)

## Adding Data to the Application
### Entity Framework
#### What is Entity Framework?
Entity Framework Core is the Microsoft object-to-relational mapping (ORM) framework, and it is the most widely used method of accessing databases in ASP.NET Core projects.
#### What is a Connection String?
A connection string provides the information that a provider needs to communicate with a particular database. The Connection String includes parameters such as the name of the driver, Server name and Database name , as well as security information such as user name and password.
#### What is a Database Context?
The context class is a most important class while working with Entity Framework Core. It represent a session with the underlying database using which you can perform CRUD (Create, Read, Update, Delete) operations. The context class is used to query or save data to the database.
#### What is a Model Repository?
According to Microsoft docs Repositories are classes or components that encapsulate the logic required to access data sources. They centralize common data access functionality, providing better maintainability and decoupling the infrastructure or technology used to access databases from the domain model layer. If you use an Object-Relational Mapper (ORM) like Entity Framework, the code that must be implemented is simplified, thanks to LINQ and strong typing. This lets you focus on the data persistence logic rather than on data access plumbing.
#### Migration vs Scaffolding?
Entity Framework Core is able to generate the schema for the database using the data model classes through a feature called migrations. When you prepare a migration, Entity Framework Core creates a C# class that contains the SQL commands required to prepare the database. If you need to modify your model classes, then you can create a new migration that contains the SQL commands required to reflect the changes. In this way, you don’t have to worry about manually writing and testing SQL commands and can just focus on the C# model classes in the application

Scaffolding is a technique used by many MVC frameworks to generate code for basic CRUD (create, read, update, and delete) operations against your database effectively.
#### Seeding the database
Adding initial data to the database

## Bootstrap styling applied

![Figure 7-9](https://github.com/One-create5/JuansStoreSln/blob/master/images/Figure%207-9.JPG)

# Chapter 8 

#### Category
![Figure 8-5](https://github.com/One-create5/JuansStoreSln/blob/master/images/Figure%208-5.JPG)

#### Shopping Cart and Session Data
![Figure 8-10](https://github.com/One-create5/JuansStoreSln/blob/master/images/Figure%208-10.JPG)
![Figure 8-11](https://github.com/One-create5/JuansStoreSln/blob/master/images/Figure%208-11.JPG)

#### Tests
![Figure 7-9](https://github.com/One-create5/JuansStoreSln/blob/master/images/Chpater8Tests.JPG)

