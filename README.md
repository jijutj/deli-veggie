The solution contains below items

WebApp - deli-veggie-app - Angular application to display product list and product details. Contains 2 pages 1. product list page 2. product details page

Components:

product-list - to show product list.
product-details - to show product details.
services/api.service.ts contains functions to call web api to fetch product list and product details.

Gateway - Web api to get product details.

ProductController Contains 2 apis 1.1) GetProducts (https://localhost:5005/product) - to get all products. 1.2) GetProductDetails (https://localhost:5005/product/{id}) - to get details of a product.

Services/ProductService.cs Service class to call product microservice to fetch product list and product details.

Models\ProductModel.cs - to hold product data.

Services.Product - Microservice to fetch product list and product details from db.

DbModels/ProductMdo - to hold product data
BL\ProductLogic - Business layer to fetch product data from DAL.
DAL\ProductRepository - Repository class to fetch product data from db.

Common - This libraray contains models to pass product data from Gateway to Microservice.
ProductDto.cs - model to pass product data.
Messages\ProductRequest.cs - RabitMq communication model to pass input request
Messages\ProductResponse.cs - RabitMq communication model to pass output response.
Note: Used RabitMq for communication between Getway and Microservice.
