![ClassDiagram](https://github.com/user-attachments/assets/cb332b35-e8fe-4a8b-83b4-f288a5659a40)
# RAiso Online Stationery Store

## Project Overview
RAiso is a well-known online store specializing in selling stationery products. With the growing volume of transactions, managing the database efficiently became crucial. This project aims to create a robust ASP.NET-based web application that streamlines the management of RAiso's transactions, ensuring smooth operations and scalability.

The website is developed using **ASP.NET** and follows the **Domain-Driven Design (DDD)** methodology to ensure a structured, maintainable, and scalable application. The layers implemented in the project include the View, Controller, Handler, Repository, Factory, and Model layers.

## Project Structure
The project consists of the following major components:

### 1. **View Layer**
   - Responsible for displaying the information to users and handling user interactions.
   - Implements the UI/UX using ASPX pages, HTML, CSS, and JavaScript.
   
### 2. **Controller Layer**
   - Validates user input and delegates user requests to the Handler layer for further processing.
   - Handles communication between the View and the Handler layers.

### 3. **Handler Layer**
   - Processes the business logic of the application, including data retrieval and manipulation.
   - Delegates queries (select, insert, update, delete) to the Repository layer for database interaction.

### 4. **Repository Layer**
   - Interfaces with the database to manipulate and retrieve data.
   - Provides methods to access and modify the database using Entity Framework.

### 5. **Factory Layer**
   - Encapsulates complex object creation, particularly for creating aggregate objects with references to other objects.
   - Ensures consistency in the object creation process.

### 6. **Model Layer**
   - Represents business concepts and handles the business logic related to the database.
   - Managed using Entity Framework to map objects to database tables.

## Database Design
The project uses a structured Entity-Relationship Diagram (ERD) to model RAiso’s transaction database. The ERD defines the relationships and structure of the entities involved in RAiso’s operations, ensuring efficient data handling.

## Features
- **User-Friendly Interface:** Customers can browse and purchase stationery products.
- **Transaction Management:** Seamless handling of order placements, transaction updates, and customer management.
- **Scalability:** Designed for scalability, allowing the system to grow with RAiso's business needs.
- **Database Integration:** Implements CRUD operations (Create, Read, Update, Delete) with a robust database model using Entity Framework.
- **Domain-Driven Design:** Ensures maintainability and a clear separation of concerns within the application.

## Setup Instructions
1. **Prerequisites:**
   - Visual Studio with ASP.NET support
   - SQL Server for database management
   - .NET Framework version X.X or later

2. **Clone the Repository:**
   ```bash
   git clone https://github.com/fanesliu/RAiso-PSD-Lab-Project
   ```

3. **Database Configuration:**
   - Restore the database using the provided MDF and LDF files.
   - Update the connection string in the `web.config` file to match your local database setup.

4. **Run the Application:**
   - Open the project in Visual Studio.
   - Build and run the solution to start the RAiso web application.

## Documentation
The project includes a detailed documentation file:
- **Project Description:** Overview of all pages and functionality.
- **References:** Links to images, audio, and other assets used in the project.
- **How to Use the Application:** Step-by-step guide for navigating and using the RAiso online store.

## Authors
- **Ryan Marchi**
- **Fanes Liu**
- **Stephen Hau**
- **Stanislaus Kanaya Jerry Febriano**

## License
This project is licensed under the MIT License.

---

This README gives a brief yet informative overview of your RAiso ASP.NET project. Let me know if you want to modify any details!
