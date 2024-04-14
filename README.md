
# Blazor Forum (.NET & Blazor Web App)

This project aims to create a clone of the popular internet platform EksiSozluk. Developed using .NET and Blazor Web App technologies, this project provides a platform where users can add content, comment, and rate.


## Approaches

- **Onion Architecture**: The project is designed based on Onion Architecture principles. This architectural pattern divides the application into layers focusing on business logic, infrastructure, and presentation, creating a modular and maintainable structure.

- **CQRS (Command Query Responsibility Segregation) Pattern**: The project utilizes the CQRS pattern, which separates read and write operations into separate models. This pattern enhances scalability, performance, and maintainability by allowing different models to evolve independently.

- **Mediator Pattern**: The project implements the Mediator pattern, which promotes loose coupling between components by centralizing communication between them. This pattern enhances reusability and testability by decoupling classes and simplifying communication.

- **Generic Repository Pattern**: The project follows the Generic Repository pattern, which provides a generic interface to perform CRUD operations on various entities. This pattern promotes code reuse and simplifies data access logic by abstracting away the underlying data storage mechanism.

- **JWT (JSON Web Token) Authentication**: JSON Web Tokens are used for authentication and authorization in the project. JWT provides a secure way to transmit information between parties as a JSON object and is commonly used for implementing stateless authentication mechanisms.

- **Blazor**: The project is developed using Blazor Web App, a .NET web framework for building interactive web UIs using C# instead of JavaScript. Blazor enables developers to create rich web applications with a single-page app (SPA) architecture, leveraging .NET's ecosystem and tools.

## Technologies

- **Entity Framework Core**: Entity Framework Core is used as the ORM (Object-Relational Mapping) framework in the project. It simplifies data access by allowing developers to work with databases using .NET objects, and provides features such as LINQ queries, change tracking, and migrations.

- **FluentValidation**: FluentValidation is used for input validation in the project. It provides a fluent interface for defining validation rules and helps ensure the validity of input data before processing it.

- **Mediatr**: Mediatr is used to implement the Mediator pattern, which promotes loose coupling between components by centralizing communication between them. This pattern enhances reusability and testability by decoupling classes and simplifying communication.

- **Automapper**: AutoMapper is used for object-object mapping in the project. It simplifies the mapping process between objects by automatically mapping properties with the same name and providing a fluent configuration API for custom mappings.

- **Bogus**: Bogus is used for generating fake data in the project. It provides a simple and flexible API for creating realistic-looking fake data for testing and development purposes.

- **RabbitMQ**: RabbitMQ is used as a message broker in the project. It provides a reliable way to send and receive messages between different parts of the application or between different applications, enhancing scalability and decoupling components.

- **Dapper**: Dapper is used as a micro ORM in the project. It provides a lightweight and high-performance data access layer, allowing developers to execute SQL queries and map results to .NET objects with minimal overhead.

- **Sql Server**: SQL Server is used as the relational database management system (RDBMS) in the project. It provides robust data storage and management capabilities, along with support for advanced features such as transactions, indexing, and security.

## General Structure

![BlazorForum-general-structure](https://github.com/burakgunce/Blazor-Forum/assets/87397100/f98c939b-14ae-48d8-9cf8-9ce27204a5e5)
