# SimpleProductCatalog
This is the backend API for the Product Catalog application, built using .NET Core Web API. The API handles the storage and retrieval of product data.

## Requirements
- [.NET Core SDK](https://dotnet.microsoft.com/download)

## API Endpoints

### 1. `GET /api/products`
   - Retrieves a list of all products.
   - **Response**: Returns a JSON array of products.
     - Example:
       ```json
       [
         {
           "name": "Product 1",
           "category": "Category 1",
           "price": 100
         },
         {
           "name": "Product 2",
           "category": "Category 2",
           "price": 150
         }
       ]
       ```

### 2. `POST /api/products`
   - Adds a new product.
   - **Request Body**:
     - `name` (string): The name of the product (required).
     - `category` (string): The category of the product (required).
     - `price` (number): The price of the product (required).
   - **Example Request**:
     ```json
     {
       "name": "Product 3",
       "category": "Category 3",
       "price": 200
     }
     ```
   - **Response**: Returns a status message confirming the product was added.
     - Example:
       ```json
       {
         "message": "Product added successfully"
       }
       ```

## Running the API

### 1. Clone the Repository
   Clone the repository to your local machine.

### 2. Navigate to the API Directory
   Open a terminal and navigate to the directory containing the backend project.

### 3. Run the API
   Run the following command to start the backend:
   dotnet run
 ### 4. Access the API
The API will be available at http://localhost:5000.
