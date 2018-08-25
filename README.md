# BooksStoreDotnetMVC

Main Steps:

1 Creating the Visual Studio Solution and Projects (Domain, UnitTests, WebApp). Then add references bewtween projects.

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

4 Redering the View data
	Setup Development Environment for EF Code-First
	Creating the Entity Framework Context by installing package EntityFramework in domain and WebApp
	Creating a database connection
	Creating a context class that will associate the model with the database
		/Create/EFDbContext.cs : DbContext
	Creating the EFProductRepository extends IproductRepository
	Bind the EfproductRepository