# 📚 CampusLib - Modern Library Management System

![.NET Core](https://img.shields.io/badge/.NET%20Core-8.0-purple)

**CampusLib** is a full-stack Library Management System built with **ASP.NET Core 8 MVC**. It features a modern, custom "Dark Glassmorphism" UI, role-based security, and full orchestration support via Docker and Kubernetes.

---

## 🚀 Features

### 🎨 User Interface (UI)
* **Custom Theme:** "Charcoal & Neon Green" Cyberpunk aesthetic.
* **Glassmorphism:** Semi-transparent cards, tables, and navbars with blur effects.
* **Responsive:** Fully mobile-friendly layout using Bootstrap 5.

### 👤 User Roles
* **Guest:** View welcome page and login/register.
* **Student (Auth User):** * Browse the Book Catalog.
    * View availability status (Available/On Loan).
    * Manage personal profile.
* **Administrator:**
    * **Book Management:** Create, Edit, Delete books.
    * **Loan Management:** Issue books to users, track return dates, and view history.
    * **User Management:** View and delete user accounts.

---

## 🛠️ Tech Stack

* **Framework:** ASP.NET Core 8.0 (MVC)
* **ORM:** Entity Framework Core
* **Database:** * *Development:* SQL Server LocalDB
    * *Production:* SQL Server 2022 (Docker Container)
* **Frontend:** Razor Views, Bootstrap 5, Bootstrap Icons, Custom CSS
* **Containerization:** Docker Desktop (Linux Containers)
* **Orchestration:** Kubernetes (Manifests included)

---

## 💻 Getting Started (Local Development)

### Prerequisites
* Visual Studio 2022 (with Web Dev workload)
* .NET 8.0 SDK
* SQL Server LocalDB (Installed with VS)

### Installation
1.  **Clone the repository**
    ```bash
    git clone [https://github.com/yourusername/CampusLib.git](https://github.com/yourusername/CampusLib.git)
    cd CampusLib
    ```

2.  **Database Migration**
    Open the **Package Manager Console** in Visual Studio and run:
    ```powershell
    Update-Database
    ```
    *This creates the `LibraryDb` database and seeds the initial Admin account.*

3.  **Run the Application**
    * Select **"https"** or **"CampusLib"** from the launch profile dropdown (do not select Docker yet).
    * Press **F5**.

4.  **Default Admin Credentials**
    * **Email:** `admin@admin.com`
    * **Password:** `Admin123!`

---

## 📂 Project Structure

CampusLib/
├── WebApplication2/
│   ├── Controllers/       # Logic for Books, Loans, Users
│   ├── Data/              # EF Core Context & Seeder
│   ├── Models/            # Database Entities
│   ├── Views/             # Razor Pages (UI)
│   ├── wwwroot/           # CSS, JS, Images
│   ├── k8s/               # Kubernetes YAML Manifests
│   ├── Dockerfile         # Container instructions
│   └── Program.cs         # App entry point & Config

---

## 📸 Screenshots


| Dashboard | Book Catalog |
|:---:|:---:|
| ![Dashboard View](screenshots/1.png) | ![Book Catalog](screenshots/2.png) |

---

Made by Med Amine Khazroun

