# Neuton E-commerce API

Welcome to the **Neuton E-commerce API**, a robust backend solution built using **ASP.NET Core** to power e-commerce platforms. This API provides essential features for managing products, categories, orders, users, and more.

## Features

- **User Management**: Authentication, authorization, and user roles.
- **Product Management**: Add, update, delete, and fetch product details.
- **Order Management**: Manage customer orders, order statuses, and history.
- **Category Management**: Create and manage product categories.
- **Cart System**: Add products to the cart and manage cart items.
- **Search and Filter**: Search products and filter by various criteria.
- **Comprehensive REST APIs**: Clean and well-documented endpoints for seamless integration.

## Technologies Used

- **Framework**: ASP.NET Core 6.0
- **Database**: SQL Server
- **Authentication**: JWT (JSON Web Tokens)
- **ORM**: Entity Framework Core
- **Tools & Libraries**:
  - AutoMapper
  - FluentValidation
  - Swagger (API Documentation)
  - Serilog (Logging)

## Prerequisites

Before setting up the project, ensure you have the following installed on your system:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Postman](https://www.postman.com/) (optional, for testing APIs)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/MuhamedAlli/Neuton-Ecommerce-API.git
cd Neuton-Ecommerce-API
```

### Configure Database

1. Update the `appsettings.json` file with your SQL Server connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;"
}
```

2. Apply database migrations:

```bash
dotnet ef database update
```

### Run the Application

Start the API locally:

```bash
dotnet run
```

The API will be available at `https://localhost:5001` (or `http://localhost:5000`).

## API Documentation

This project includes Swagger for interactive API documentation. To access it, run the application and navigate to:

```
https://localhost:5001/swagger
```

## Folder Structure

```
Neuton-Ecommerce-API/
├── Controllers/       # API controllers
├── Models/            # Data models
├── Data/              # Database context and migrations
├── Services/          # Business logic
├── DTOs/              # Data transfer objects
├── Repositories/      # Data access layer
├── Middlewares/       # Custom middlewares
└── Program.cs         # Application entry point
```


