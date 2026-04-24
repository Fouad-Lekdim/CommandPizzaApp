# 🍕 CommandPizzaApp

A Windows Forms desktop application built with C# and .NET that allows customers to compose and place custom pizza orders, while providing staff with a dedicated management interface to view and manage orders.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Architecture](#architecture)
- [Tech Stack](#tech-stack)
- [Database Structure](#database-structure)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Roadmap](#roadmap)
- [Project Structure](#project-structure)

---

## Overview

CommandPizzaApp is a point-of-sale pizza ordering system with a clean separation between the customer-facing ordering interface and a staff-facing order management panel. Built using a **3-tier architecture**, the application is designed so that only the presentation layer needs to be replaced to deploy a web or mobile version — the business logic and data access layers remain unchanged.

---

## Features

### 🧑‍💻 Customer Interface
- **Compose your pizza** — choose from available sizes, crust types, and toppings
- **Dine-in or takeaway** — select where to eat and have it reflected in the order
- **Live order summary** — price and order details update in real time as selections change
- **Place Order** — submit the composed order to the database
- **Reset** — clear all selections and start fresh

### 👨‍🍳 Staff – Personal Space
- **Order list** — view all placed orders in a DataGridView, fetched directly from the database
- **Search by order number** — quickly locate a specific order using the search box

---

## Architecture

The application follows a strict **3-tier architecture**:

```
┌─────────────────────────────────┐
│        User Layer (UI)          │  ← Windows Forms (.NET)
│  CustomerForm | PersonalSpace   │
└────────────────┬────────────────┘
                 │
┌────────────────▼────────────────┐
│       Business Layer (BL)       │  ← Business logic, rules, calculations
└────────────────┬────────────────┘
                 │
┌────────────────▼────────────────┐
│     Data Access Layer (DAL)     │  ← ADO.NET + SQL Server
└─────────────────────────────────┘
```

This separation means:
- The **DAL** handles all SQL queries and database communication
- The **BL** contains all business rules (pricing, order composition, validation)
- The **UI** is purely presentational — replacing it with a Web API or mobile app requires no changes to BL or DAL

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET Framework) |
| UI | Windows Forms |
| Database | Microsoft SQL Server |
| Data Access | ADO.NET |
| IDE | Visual Studio |

---

## Database Structure

The database is centered around the **Orders** table, linked to supporting lookup tables:

```
Orders
  ├── FK → PizzaSizes   (size of the pizza)
  └── FK → CrustTypes   (type of crust chosen)
```

> Toppings and dine-in/takeaway preference are also captured as part of each order record.

---

## Getting Started

### Prerequisites

- Windows OS
- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later recommended)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server) (LocalDB or full instance)
- .NET Framework (version compatible with project settings)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Fouad-Lekdim/CommandPizzaApp.git
   cd CommandPizzaApp
   ```

2. **Set up the database**
<<<<<<< HEAD
   - Open SQL Server Management Studio (SSMS) or Visual Studio's SQL tools
   - Connect to your SQL Server instance
   - Open the file `database.sql` found at the root of the repository
   - Execute the script (`F5` in SSMS) — it will automatically create the `PizzaDB` database, all tables, seed `PizzaSizes` (Small, Medium, Large) and `CrustTypes` (Thin, Thick), and leave `Orders` empty ready to be filled through the app
   - You should see `PizzaDB is ready. You can now run the app.` in the Messages panel when done
=======
   - Open SQL Server Management Studio (SSMS) or use Visual Studio's SQL tools
   - Create a new database (e.g., `CommandPizzaDB`)
   - Run the provided SQL scripts to create the tables (`Orders`, `PizzaSizes`, `CrustTypes`) and seed initial data
>>>>>>> a507492ebc8d2d45b9055ec806c4b82768090879

3. **Configure the connection string**
   - Open the `DataAccessLayer` project
   - Update the connection string in the configuration file (e.g., `App.config` or a dedicated `DBConnection` class) to point to your SQL Server instance:
     ```xml
     <connectionStrings>
       <add name="PizzaDB"
<<<<<<< HEAD
            connectionString="Server=YOUR_SERVER;Database=PizzaDB;Integrated Security=True;"
=======
            connectionString="Server=YOUR_SERVER;Database=CommandPizzaDB;Integrated Security=True;"
>>>>>>> a507492ebc8d2d45b9055ec806c4b82768090879
            providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

4. **Open and build the solution**
   - Open `CommandPizzaApp.sln` in Visual Studio
   - Restore NuGet packages if prompted
   - Build the solution (`Ctrl+Shift+B`)

5. **Run the application**
   - Set the UI project as the startup project
   - Press `F5` or click **Start**

---

## Usage

### Placing an Order (Customer)

1. Launch the application — the main order form opens
2. Select a **pizza size**, **crust type**, and desired **toppings**
3. Choose **dine-in** or **takeaway**
4. The **order summary panel** updates in real time with selected options and the calculated price
5. Click **Place Order** to save the order to the database
6. Use **Reset** to clear the form and start a new order

### Managing Orders (Staff)

1. Click the **Personal Space** button on the main form
2. The staff panel opens, displaying all orders in a DataGridView
3. Use the **Search by Order Number** text box to filter and locate a specific order

---

## Roadmap

The following features are planned for future releases:

- [ ] **Authentication** — secure login required to access the Personal Space
- [ ] **Edit orders** — allow staff to update the details of an existing order
- [ ] **Delete orders** — allow staff to remove an order from the system
- [ ] *(Read and Create operations are already implemented)*

> Together, these additions will complete full **CRUD** support for order management.

---

## Project Structure

```
CommandPizzaApp/
│
├── DataAccessLayer/         # ADO.NET database access, SQL queries
│   └── ...
│
├── BusinessLayer/           # Business logic, pricing rules, order processing
│   └── ...
│
├── UserLayer/               # Windows Forms UI
│   ├── MainForm.cs          # Customer order interface
│   ├── PersonalSpaceForm.cs # Staff order management panel
│   └── ...
│
<<<<<<< HEAD
├── database.sql             # Run this to create and seed the database
=======
>>>>>>> a507492ebc8d2d45b9055ec806c4b82768090879
└── CommandPizzaApp.sln      # Solution file
```

---

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

---

## Author

**Fouad Lekdim** — [GitHub](https://github.com/Fouad-Lekdim)
