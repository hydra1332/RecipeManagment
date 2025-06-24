# Recipe Management ASP.NET MVC App

A simple web application for managing recipes, built with ASP.NET MVC.  
This app uses an in-memory list (no database required) and demonstrates basic CRUD operations, search, and status tagging for recipes.

---

## Features

- **Create, Read, Update, Delete (CRUD) Recipes**
- **Search Recipes** by name, ingredients, instructions, cuisine type, or metadata
- **Status Tags:** Mark recipes as "Favorite", "To Try", or "Made Before"
- **Details View** for each recipe
- **In-Memory Storage:** No database setup required (data resets on app restart)

---

## Getting Started

### Prerequisites

- Visual Studio 2017 or newer
- .NET Framework 4.6 or newer

### Setup

1. **Clone this repository**  
   `git clone https://github.com/<your-username>/<your-repo>.git`

2. **Open the solution** (`.sln`) file in Visual Studio.

3. **Build and Run** the project (`F5` or green "Start" button).

4. The app will open in your browser.  
   You can now add, edit, delete, and search recipes.

---

## Usage

- **Add Recipe:**  
  Click "Create New Recipe", fill out the form, and submit.

- **Edit/Delete/Details:**  
  Use the links in the recipe list to edit, view, or delete any recipe.

- **Search:**  
  Use the search box above the recipe list to find recipes by any field.

- **Status Tags:**  
  Use checkboxes to mark recipes as "Favorite", "To Try", or "Made Before". These appear as colored badges in the recipe list.

---

## File Structure

- `/Controllers/RecipeController.cs` – Main controller, uses a static list for recipes
- `/Models/Recipe.cs` – Recipe model with all fields and status tags
- `/Views/Recipe/` – All Razor views for CRUD, details, and search UI
- `/README.md` – This file

---

## Notes

- **Persistence:**  
  All data is stored in memory and will be lost when the app restarts.

- **Extending:**  
  To use a database, replace the static list in the controller with Entity Framework logic.  
  For cloud/production apps, always use a database.

---

## .gitignore

A standard Visual Studio `.gitignore` is recommended. Example [here](https://github.com/github/gitignore/blob/main/VisualStudio.gitignore).

---

## License

This project is for learning and demonstration purposes.  
Feel free to use, modify, and share!
