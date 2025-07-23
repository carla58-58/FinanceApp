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

Built with **ASP.NET Core** and **SQLite**, the app is ideal for individuals and small teams who want a secure, modern, and easy-to-use expense management solution.

---

## ⚙️ Tech Stack

- **ASP.NET Core** – Robust framework for building scalable web applications
- **C#** – Main programming language for backend logic
- **SQLite** – Lightweight, file-based database for reliable data storage
- **Bootstrap** – Responsive front-end framework for user-friendly UI
- **Chart.js** – JavaScript library for creating interactive and visually appealing charts and graphs in the browser, ideal for displaying expense analytics and trends

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
- [Git](https://git-scm.com/)

### Installation

1. **Clone the repository:**
git clone <repository-url>
cd expenses-tracker-app

text

2. **Apply Database Migrations:**
dotnet ef database update

text

3. **Run the Application:**
dotnet run

text

4. **Access the App:**
- Open [http://localhost:5123/Expenses](http://localhost:5123/Expenses) in your browser.

## 🚀 Deployment

This app is configured for free deployment on **Render.com**:

1. **Push your code to GitHub**
2. **Connect your GitHub repo to Render**
3. **Render will automatically deploy using the included `render.yaml` configuration**
4. **Your app will be live with a free SQLite database!**

The app includes:
- ✅ **Dockerfile** for containerized deployment
- ✅ **render.yaml** for automatic Render deployment
- ✅ **SQLite database** (no additional database costs)
- ✅ **Production configuration** ready
- ✅ **Persistent disk** configured to retain data across deployments

### 💾 Data Persistence on Render

The app uses Render's **persistent disk** feature to ensure your expense data survives container restarts:

- **Persistent Disk**: Mounted at `/app/data` with 1GB storage
- **Database Location**: `/app/data/financeApp.db` (survives restarts)
- **Sample Data**: Automatically added when database is first created
- **Free Tier Compatible**: Works with Render's free plan limitations

**Note**: On first deployment, the app will create sample expenses to verify that data persistence is working correctly. You can delete these and add your own expenses.

---

Thank you for checking out the ASP.NET Expenses Tracker App!  
Feel free to contribute, suggest features, or ask questions
