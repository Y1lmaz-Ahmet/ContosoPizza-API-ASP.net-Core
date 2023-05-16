# ContosoPizza API - Pizza Controller

This project contains the PizzaController class for the ContosoPizza API built using ASP.NET Core.

## Table of Contents

- [Description](#description)
- [Endpoints](#endpoints)
- [Models](#models)
- [Getting Started](#getting-started)

## Description

The `PizzaController` class is responsible for handling HTTP requests related to pizzas. It interacts with the `PizzaService` to perform CRUD (Create, Read, Update, Delete) operations on pizza data.

## Endpoints

The following endpoints are available:

- `GET /api/pizza`: Retrieves all pizzas.
- `GET /api/pizza/{id}`: Retrieves a specific pizza by its ID.
- `POST /api/pizza`: Creates a new pizza.
- `PUT /api/pizza/{id}`: Updates an existing pizza.
- `DELETE /api/pizza/{id}`: Deletes a pizza.

## Models

The `Pizza` class represents a pizza entity in the ContosoPizza API. It has the following properties:

- `Id` (integer): The unique identifier of the pizza.
- `Name` (string, nullable): The name of the pizza.
- `IsGlutenFree` (boolean): Indicates whether the pizza is gluten-free.

## PizzaService

The `PizzaService` class provides methods for interacting with pizza data. It has the following static methods:

- `GetAll()`: Retrieves all pizzas.
- `Get(id)`: Retrieves a specific pizza by its ID.
- `Add(pizza)`: Adds a new pizza to the collection.
- `Delete(id)`: Deletes a pizza by its ID.
- `Update(pizza)`: Updates an existing pizza.

## Getting Started

To run the ContosoPizza API and test the endpoints:

1. Ensure you have the necessary prerequisites installed (e.g., .NET Core SDK).
2. Clone the repository.
3. Open the project in your preferred IDE.
4. Build and run the project.
5. Use an HTTP client (e.g., Postman) to send requests to the API endpoints.
