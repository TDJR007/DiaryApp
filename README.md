
# 📓 Diary App (.NET Core MVC)

A simple diary CRUD app built with ASP.NET Core MVC and Entity Framework Core. Create, read, update, and delete personal diary entries with a web interface.

---

## 🛠️ Features

- Add and edit diary entries
- View all entries
- Delete embarrassing entries 😅
- Seeded with sample data
- SQL Server database with EF Core
- Clean MVC architecture

---

## 🚀 Getting Started

These instructions will get you a local copy of the project up and running.

---

## 📦 Prerequisites

- [Visual Studio 2022+](https://visualstudio.microsoft.com/) (with **ASP.NET and web development** workload)
- [.NET SDK 6 or later](https://dotnet.microsoft.com/en-us/download)
- SQL Server Express or LocalDB (comes with Visual Studio)

---

## 🧪 Clone and Run

1. **Clone the repo**

```bash
git clone https://github.com/TDJR007/DiaryApp.git
cd DiaryApp
```

2. **Update your connection string**

Open `appsettings.json` and update the `DefaultConnection`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=Diary;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

> 💡 Tip: Use `Server=(localdb)\MSSQLLocalDB` for LocalDB  
> Or `Server=localhost\SQLEXPRESS` for SQL Express

You can get the hostname by running `hostname` in command prompt.

---

## 🎯 Opening the Project in Visual Studio

1. **Open Visual Studio**

   Launch Visual Studio 2022 or later.

2. **Open the Solution File**

   Click on `File → Open → Project/Solution`  
   Navigate to the folder where you cloned the repo, and open the `Diary.sln` file.

   > 🧠 The `.sln` (solution) file links all your project files, so always open this.

---

## 📅 Apply Migrations

To create the database and seed it with initial data:

1. Go to **Tools → NuGet Package Manager → Package Manager Console**
2. Run this:

```powershell
Update-Database
```

You should see a new database created in SQL Server.

---

## ▶️ Run the App

Click the green **Start** button in Visual Studio, or press `F5`.  
Navigate to `/DiaryEntries` to start journaling!

---

## 🙌 Contributing

Pull requests welcome! If you spot a bug or want to add features like user authentication or Markdown support, open an issue or fork and go wild 🎉

---

## 📄 License

MIT — use this for anything!
