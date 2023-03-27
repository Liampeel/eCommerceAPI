# eCommerceAPI

This is a simple .NET Web API that exposes endpoints for submitting a simple eCommerce order

The SQL database was hosted locally on my machine

# Getting Started
To get started with this API, you'll need to have .NET Core 6.0 or higher installed on your machine

Installing Dependencies
Once you have .NET Core installed, you can install the necessary dependencies by running the following command in the root directory of the project:

- dotnet restore


After this, you will need to change your appsettings.json file to edit the SQL Server information

<img width="877" alt="image" src="https://user-images.githubusercontent.com/69147114/227825004-644b3d93-99be-41cb-ba01-fccf83d98208.png">


# Running the API
To run the API, navigate to visual studio and click the run project button. a swagger page will open in your browser

<img width="1440" alt="image" src="https://user-images.githubusercontent.com/69147114/227824281-83587bed-b874-4c97-b746-349e27da93ce.png">



# Endpoints
The following endpoints are available in this API:

# GET /orders/{orderId}
Retrieves a single item by its ID.

<img width="1423" alt="image" src="https://user-images.githubusercontent.com/69147114/227824792-8c75d9e2-ecc3-4c2f-a2cc-2a370fc86673.png">

<img width="1403" alt="image" src="https://user-images.githubusercontent.com/69147114/227824841-787eedf3-ad89-45a8-8537-f8a209d6aa1b.png">


# POST /orders
Adds a new order to the system. The request body should contain a JSON including the customer and product details

<img width="1399" alt="image" src="https://user-images.githubusercontent.com/69147114/227824705-620a9d84-1fa8-42f5-9da0-c8738cef1ae7.png">

<img width="1398" alt="image" src="https://user-images.githubusercontent.com/69147114/227824744-26b4b13a-f38d-41bd-83d4-8c0b15a2eca6.png">
