# BooksStoreDotnetMVC

## Main Function

• Listing books by category and pagination
• Adding books to shipping cart and to check out
• Managing books as an administrator

## Stack

- Asp.net MVC
- Front-end: Asp.Net Razor, Bootstrap,
- Back-end: EntityFramework, LINQ
- DataBase: SQL Server
- IDE: Visual Studio
- DI Container: Autofac
- Mock: Moq
- Cloud: Azure

## Main Steps

1 Creating the Visual Studio Solution and Projects (Domain, UnitTests, WebApp). Then add references in projects.

2 Installing the tool packages:
 DI Container: Autofac, Autofac.Mvc5
 Mock Repository: Moq
 EntityFramework
 Microsoft.Aspnet.Mvc
 Microsoft.Aspnet.WebPages

3 Starting the Domain Model
 Adding Model (Entities / Product)
 Creating an Abstract Repository (Abstract / IProductsRepository)
 Making a Mock Repository (Mock / MockProductsRepository)

3 DisPlaying a list
 Adding a controller  and  a method in the controller
 Adding a View of the method
 Setting the default Route
  Registering Autofac configure in the Global.asax
  Adding AutofacConfig class in the App_start fold

4 Rendering the View data
 Setup Development Environment for EF Code-First
 Creating the Entity Framework Context by installing package EntityFramework in domain and WebApp
 Creating a context class that will associate the model with the database
  /Create/EFDbContext.cs : DbContext
 Creating the EFProductRepository extends IProductRepository
 Bind the EFProductRepository
 Specifying the connection string under <configuration> tag for our database in the Web.config file

5  Pagination
 Add class PagingInfo (TotalItems, ItemsPerPage, CurrentPage, TotalPages).
 Add class PagingHelpers in HtmlHelpers folder.
 Add model ProductsListViewModel
 Update list method in the ProductController using ProductsListViewModel.

6  Navigation

7  Auth and Login

8 Database Connection

10 Azure Deployment
