# eCommerceAPI

This is a simple .NET Web API that exposes endpoints for submitting a simple eCommerce order

The SQL database was hosted locally on my machine

# Getting Started
To get started with this API, you'll need to have .NET Core 6.0 or higher installed on your machine

Installing Dependencies
Once you have .NET Core installed, you can install the necessary dependencies by running the following command in the root directory of the project:

- dotnet restore

# Running the API
To run the API, navigate to visual studio and click the run project button


# Endpoints
The following endpoints are available in this API:

# GET /orders/{orderId}
Retrieves a single item by its ID.

# POST /orders
Adds a new order to the system. The request body should contain a JSON including the customer and product details

