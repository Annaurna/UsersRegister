# User Directory Demo

The User Directory App is a full-stack web application built with ASP.NET Core (backend) and Angular (frontend). It provides a centralized platform to manage users with a modern UI and secure APIs.

Simple full-stack CRUD app using:

- ASP.NET Core Web API (.NET 8)
- Angular (Standalone Components)
- In-memory storage (no database)

## Features

- Add user
- View users
- Update user
- Delete user
- Swagger enabled

Data is stored in memory. Restarting the backend resets all data.

## To use this project template, follow the steps below:
                                                                                      
1. Ensure that you have the .NET 7 SDK installed on your machine.
2. Clone or download this repository to your local machine.
3. Open the solution in your preferred IDE (e.g., Visual Studio, Visual Studio Code).
4. Build the solution to restore NuGet packages and compile the code.
5. Configure the necessary database connection settings in the `appsettings.json` file of the Infrastructure project.
6. Open the Package Manager Console, select `Project.Infrastructure` project, and run the `Update-Database` command to create the database.
7. Run the application by starting the `Project.API` project.

## Project Features

This project template includes the following features:

- **Clean Architecture**: The project is structured according to the principles of [Clean Architecture](https://binarybytez.com/understanding-clean-architecture/), which promotes separation of concerns and a clear division of responsibilities.
- **SOLID Design Principles**: The code adheres to [SOLID principles](https://binarybytez.com/mastering-solid-design-principles/) (Single Responsibility, Open-Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion), making it easier to maintain and extend.
- **Repository Pattern**: The [repository pattern](https://binarybytez.com/understanding-clean-architecture/) abstracts the data access layer and provides a consistent interface for working with data.
- **Unit of Work Pattern**: The unit of work pattern helps manage transactions and ensures consistency when working with multiple repositories.
- **Entity Framework Core**: The project utilizes Entity Framework Core as the ORM (Object-Relational Mapping) tool for data access.
- **ASP.NET Core API**: The project includes an [ASP.NET Core API project](https://binarybytez.com/clean-structured-project/) that serves as the API layer, handling HTTP requests and responses.
- **JWT for Token-based Authentication**: Effortlessly manage user sessions, authentication, and authorization with this state-of-the-art token-based approach.
- **API Versioning**: The project can be enhanced to include API versioning to support evolutionary changes while preserving backward compatibility.
- **CRUD Operations**: The project template provides a foundation for implementing complete CRUD (Create, Read, Update, Delete) operations on entities using Entity Framework Core.
- **Dependency Injection**: The project utilizes the built-in [dependency injection](https://binarybytez.com/understanding-dependency-injection/) container in ASP.NET Core, making it easy to manage and inject dependencies throughout the application.
- **Unit Testing**: The solution includes separate test projects for unit testing the core, infrastructure, and API layers.

## Usage

[The project template](https://binarybytez.com/asp-net-core-web-api-project/) provides a starting point for building RESTful APIs using ASP.NET Core. You can modify and extend the existing code to suit your specific application requirements. Here's an overview of the key components involved in building RESTful APIs:

1. **Models**: The `Core` project contains the domain models representing the entities you want to perform CRUD operations on. Update the models or add new ones according to your domain.
2. **Repositories**: The `Infrastructure` project contains repository implementations that handle data access operations using Entity Framework Core. Modify the repositories or create new ones to match your entity models and database structure.
3. **Services**: The `Core` project contains services that encapsulate the business logic and orchestrate the operations on repositories. Update or create new services to handle CRUD operations on your entities.
4. **Controllers**: The `API` project contains controllers that handle HTTP requests and responses. Update or create new controllers to expose the CRUD endpoints for your entities. Implement the appropriate HTTP methods (GET, POST, PUT, DELETE) and perform actions on the core services accordingly.

Make sure to update the routes, validation, and error-handling logic to align with your application requirements and [best practices](https://binarybytez.com/performance-optimization-and-monitoring-in-asp-net-core/).

