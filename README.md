﻿# Students Management System

This is a Students Management System built using ASP.Net Core MVC. The application demonstrates basic CRUD (Create, Read, Update, Delete) operations on a list of students.


## Features

- **Create Student**: Add new students to the database.
- **Read Student**: View details of all students.
- **Update Student**: Edit existing student information.
- **Delete Student**: Remove a student from the database.

## Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/oyldrr/StudentPortal.git
   cd StudentPortal
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Update the database**
   Make sure to update your database connection string in `appsettings.json`. Then, run the following command to update your database.
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

## Usage

Once the application is running, you can navigate to the main page to see a list of all students. From there, you can add, edit, or delete students.

## Screenshots

### Main Screen
![Main Screen](https://github.com/oyldrr/StudentPortal/assets/84236077/949c9fe0-1dd3-4b8b-b651-5af609c5eccd)

### Add Student
![Add Student](https://github.com/oyldrr/StudentPortal/assets/84236077/f7a0a064-4f65-41c4-9624-7114481dbd72)

### Edit Student
![Edit Student](https://github.com/oyldrr/StudentPortal/assets/84236077/6bb67a61-4511-4548-bbed-1557a4e8327e)


## Technologies Used

- **ASP.Net Core MVC**: For building the web application.
- **Entity Framework Core**: For database operations.
- **SQL Server**: As the database.
- **Bootstrap**: For styling the UI.

## License

This project is not licensed. You can freely use in your projects.
