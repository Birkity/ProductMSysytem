# ProductMSysytem
A simple ASP .net core web app for product Management System
# Product Management System

The Product Management System is a web application built using ASP.NET Core MVC. It allows users to manage products and perform various operations related to product management.

## Features

- View a list of products
- Add new products
- Edit existing products
- Delete products

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- Microsoft SQL Server (for database storage)
- HTML/CSS
- Razor view engine

## Prerequisites

- .NET Core SDK 
- Microsoft SQL Server (or SQL Server Express)

## Getting Started

1. Clone the repository: git clone https://github.com/your-username/product-management-system.git

2. Open the solution file (`ProductManagementSystem.sln`) in Visual Studio or your preferred IDE.

3. Configure the database connection string:
   - Open the `appsettings.json` file.
   - Locate the `"DefaultConnection"` property under `"ConnectionStrings"`.
   - Update the connection string to point to your SQL Server instance.

4. Build the solution to restore the NuGet packages and compile the project.

5. Run the database migrations:
   - Open the Package Manager Console (PMC) in Visual Studio (`Tools` > `NuGet Package Manager` > `Package Manager Console`).
   - Set the default project to the `ProductManagementSystem.Data` project.
   - Run the following command to apply the migrations and create the database:
     Add-migration initialDatabase 
     Update-Database


6. Run the application:
   - Set the `ProductManagementSystem.Web` project as the startup project.
   - Press `F5` or click the "Run" button in your IDE.

7. Access the application in your web browser:
   - Open your preferred web browser.
   - Navigate to `http://localhost:port` (replace `port` with the appropriate port number).

## Usage

- Home Page: The home page displays a list of products. You can click on a product to view its details.
- Add Product: Click on the "Add Product" button to add a new product. Fill in the required details and click "Save" to add the product to the database.
- Edit Product: On the product details page, click the "Edit" button to modify the product's information.
- Delete Product: On the product details page, click the "Delete" button to remove the product from the database.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.






