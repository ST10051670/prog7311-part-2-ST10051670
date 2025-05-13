Table of Contents
Preface	1
Version	1
Audience	1
Scope	2
Prerequisites	2
Setting Up the Development Environment	2
Building and Running the Prototype	3
System Functionalities	3
User Roles	4
Troubleshooting	4
Setting Up the SQL Database	5
Program Requirements	5
Usage	6
References	6









Preface

Welcome to the Agri-Energy Connect Prototype Web Application. This document provides comprehensive instructions for setting up the development environment, building and running the prototype, and understanding the system's functionalities and user roles.

 Version

Version: 1.0.0

 Audience

This documentation is intended for developers, testers, and stakeholders involved in the development and maintenance of the Agri-Energy Connect web application.

 Scope

This document covers the setup, build, and usage of the Agri-Energy Connect web application, including prerequisites, environment configuration, and detailed system functionalities.

 Prerequisites

Before setting up the development environment, ensure you have the following installed:

- Visual Studio 2019 or later
- .NET 6.0 SDK
- SQL Server or SQL Server Express
- SQL Server Management Studio (SSMS)
- A web browser (Chrome, Firefox, Edge, etc.)

 Setting Up the Development Environment

1. Clone the Repository:
   Clone the project repository from GitHub to your local machine using the following command:
   
git clone https://github.com/ST10051670/prog7311-part-2-ST10051670.git
   

2. Open the Solution:
   Navigate to the project directory and open the solution file (`MUHAMMED_ZIA_DESAI.ST10051670.POE.sln`) in Visual Studio.

3. Restore NuGet Packages:
   In Visual Studio, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution and click Restore to restore all the required packages.

4. Configure the Database:
   - Open appsettings.json  and configure the connection string to point to your SQL Server instance.
   - Open the Package Manager Console and run the following command to apply migrations and create the database:
     
     PM> Update-Database
     

 Building and Running the Prototype

1. Build the Solution:
   In Visual Studio, click on Build  > Build Solution to compile the project.

2. Run the Application:
   Press F5 or click the Start Debugging button to run the application. This will launch the web application in your default browser.

3. Access the Application:
   The application should be running at https://localhost:5001/ or a similar local URL. You can now explore the functionalities of the prototype.

 System Functionalities

 For Farmers

- Product Addition:
  Farmers can add new products to their profile, including details such as product name, category, price, quantity and production date.

- View Products:
  Farmers can view a list of their own products and manage them as needed.

 For Employees

- Add New Farmer Profiles:
  Employees can add new farmer profiles with essential details such as name, email, password, phone number and location they are based.

- View and Filter Products:
  Employees can view a comprehensive list of products from all farmers and apply filters based on criteria such as date range and product category.

 General Features

- Secure Login and Authentication:
  The application includes secure login functionality with role-based access control to ensure data security and privacy.

- Responsive Design:
  The user interface is designed to be responsive and accessible on various devices, including desktops, tablets, and smartphones.

 User Roles

 Farmers

Farmers can:
- Register and log in to the platform.
- Add and manage their products.
- Access resources and participate in forums.

 Employees

Employees can:
- Register and log in to the platform.
- Add and manage farmer profiles.
- View and filter products from all farmers.

 Troubleshooting

- Database Connection Issues:
  Ensure that your SQL Server instance is running and the connection string in appsettings.json is correctly configured.

- Missing NuGet Packages:
  If you encounter errors related to missing NuGet packages, try restoring the packages again through the NuGet Package Manager.

- Build Errors:
  Ensure that you have all the required dependencies installed and that the project is targeting the correct .NET version.

If you encounter any other issues, please refer to the project documentation or contact the development team for assistance.

 Setting Up the SQL Database

To create and configure your SQL database, follow these steps:

1. Install SQL Server:
   Ensure that SQL Server or SQL Server Express is installed on your machine. If not, download and install it from the [Microsoft website](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

2. Create a New Database:
   Open SQL Server Management Studio (SSMS) and connect to your SQL Server instance. Right-click on the `Databases` folder in the Object Explorer and select `New Database...`. Name your database (e.g., PROG7311).

3. Configure Connection String:
   In the appsettings.json file of your project, update the connection string to point to your newly created database. For example:
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-44P9RME;Database=AgriEnergy;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }

4. Apply Migrations:
   Open the Package Manager Console in Visual Studio and run the following command to apply migrations and create the necessary tables:
   
   PM> Update-Database

 Program Requirements

- Programming Language: C
- Framework: ASP.NET Core 6.0

 Software Requirements

- Development Environment: Visual Studio 2019 or later
- Database Server: SQL Server or SQL Server Express
- Browser: Chrome, Firefox, Edge, or any modern web browser

 Visual Studio Requirements

- Version: Visual Studio 2019 or later
- Workloads: ASP.NET and web development, .NET Core cross-platform development

 SQL Server Management Studio (SSMS) Requirements

- Version: SSMS 18 or later

 Usage

Once the application is set up and running, you can perform the following tasks:

- Farmers: Register, log in, add products, and manage their product listings.
- Employees: Register, log in, add new farmer profiles, and view and filter products from all farmers.
- General Users: Explore the website, view products, and access public resources.

 References

[Microsoft SQL Server Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
[Visual Studio Download](https://visualstudio.microsoft.com/downloads/)
[ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
[Entity Framework Core Migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/)
CRUD Operations using ASP.NET Core MVC, Entity Framework and SQL Server | Create Read Update delete: https://youtu.be/SfWuOFEatYc?si=rZdXGdTK9yRthwEo
ASP.NET Core 7.0 Role Based Authorization || How to Implement Roles Based Authorization: https://www.youtube.com/watch?v=VZgxKbAdbbo
Create ASP.NET Core Web Application With SQL Server Database Connection and CRUD Operations: https://youtu.be/T-e554Zt3n4?si=GG6b2bMW_Q1Rpy5F
APPLICATION DEMO - Asp.Net CORE MVC: https://youtu.be/mxgyZmQ-Krc?si=v5c__HzyA2n6Rx7B
ASP.NET User Roles - Create and Assign Roles for AUTHORIZATION!: https://youtu.be/Y6DCP-yH-9Q?si=-uZluMEra57HfpeK
Create ASP.NET Core Web Application With SQL Server Database Connection and CRUD Operations: https://www.youtube.com/watch?v=T-e554Zt3n4
Perform CRUD Operations using ASP.NET - Razor Pages - Entity Framework and SQL Server Database: https://www.youtube.com/watch?v=nlR1MxHl1O0
ASP.NET Core 7.0 Role Based Authorization || How to Implement Roles Based Authorization: https://www.youtube.com/watch?v=VZgxKbAdbbo
CRUD Operations using ASP.NET Core MVC, Entity Framework and SQL Server | Create Read Update delete: https://youtu.be/SfWuOFEatYc?si=rZdXGdTK9yRthwEo
Perform CRUD Operations using ASP.NET - Razor Pages - Entity Framework and SQL Server Database: https://youtu.be/nlR1MxHl1O0?si=Z4dPf_Ok1BD6W7yn


Thank you for using the Agri-Energy Connect Prototype Web Application!

