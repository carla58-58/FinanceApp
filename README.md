# Expenses Tracker App

📋 **Table of Contents**

1. 🤖 [Introduction](#introduction)
2. ⚙️ [Tech Stack](#tech-stack)
3. 🔋 [Features](#features)
4. 🚀 [Quick Start](#quick-start)

---

## 🤖 Introduction

Welcome to the **ASP.NET Expenses Tracker App**!  
This web application helps users efficiently manage and monitor their personal or business expenses, offering a clear overview of spending patterns and budget tracking.

Built with **ASP.NET Core** and **SQL Server**, the app is ideal for individuals and small teams who want a secure, modern, and easy-to-use expense management solution.

---

## ⚙️ Tech Stack

- **ASP.NET Core** – Robust framework for building scalable web applications
- **C#** – Main programming language for backend logic
- **SQL Server** – Relational database for secure, reliable data storage
- **Entity Framework Core** – ORM for database access and migrations
- **Bootstrap** – Responsive front-end framework for user-friendly UI

---

## 🔋 Features

- **Expense Management:**  
  Add, delete, and view expenses with details like amount, category, date, and description

- **Category Tracking:**  
  Organize expenses by customizable categories

- **Total Expenses Summary:**  
  View total spending per category

---

## 🚀 Quick Start

Follow these steps to run the Expenses Tracker App locally:

### Prerequisites

- [.NET SDK 7.0 or later](https://dotnet.microsoft.com/)
- [SQL Server Express](https://www.microsoft.com/en-au/sql-server/sql-server-downloads) (or a local/remote SQL Server instance)
- [Git](https://git-scm.com/)

### Installation

1. **Clone the repository:**
git clone <repository-url>
cd expenses-tracker-app

text

2. **Configure the Database:**
- Update the `appsettings.json` file with your SQL Server connection string:
  ```
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ExpensesTrackerDb;Trusted_Connection=True;"
  }
  ```

3. **Apply Database Migrations:**
dotnet ef database update

text

4. **Run the Application:**
dotnet run

text

5. **Access the App:**
- Open [http://localhost:5123](http://localhost:5123) in your browser.

---

Thank you for checking out the ASP.NET Expenses Tracker App!  
Feel free to contribute, suggest features, or ask questions
