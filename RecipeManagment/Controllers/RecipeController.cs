using RecipeManagment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RecipeManagment.Controllers
{
    public class RecipeController : Controller
    {
        // In-memory static list to simulate a database
        private static List<Recipe> recipes = new List<Recipe>();
        private static int nextId = 1;

        // GET: Recipe
        public ActionResult Index(string searchTerm)
        {
            var list = recipes.ToList();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string lowerTerm = searchTerm.ToLower();
                list = list.Where(r =>
                    (r.Name != null && r.Name.ToLower().Contains(lowerTerm)) ||
                    (r.Ingredients != null && r.Ingredients.ToLower().Contains(lowerTerm)) ||
                    (r.Instructions != null && r.Instructions.ToLower().Contains(lowerTerm)) ||
                    (r.CuisineType != null && r.CuisineType.ToLower().Contains(lowerTerm)) ||
                    (r.Metadata != null && r.Metadata.ToLower().Contains(lowerTerm))
                ).ToList();
            }
            return View(list);
        }

        // GET: Recipe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(400);
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null) return HttpNotFound();
            return View(recipe);
        }

        // GET: Recipe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipe/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                recipe.Id = nextId++;
                recipes.Add(recipe);
                return RedirectToAction("Index");
            }
            return View(recipe);
        }

        // GET: Recipe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(400);
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null) return HttpNotFound();
            return View(recipe);
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                var existing = recipes.FirstOrDefault(r => r.Id == recipe.Id);
                if (existing == null) return HttpNotFound();

                // Update fields
                existing.Name = recipe.Name;
                existing.Ingredients = recipe.Ingredients;
                existing.Instructions = recipe.Instructions;
                existing.CuisineType = recipe.CuisineType;
                existing.PreparationTimeInMinutes = recipe.PreparationTimeInMinutes;
                existing.CreatedDate = recipe.CreatedDate;
                existing.Metadata = recipe.Metadata;
                existing.IsFavorite = recipe.IsFavorite;
                existing.ToTry = recipe.ToTry;
                existing.MadeBefore = recipe.MadeBefore;

                return RedirectToAction("Index");
            }
            return View(recipe);
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(400);
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null) return HttpNotFound();
            return View(recipe);
        }

        // POST: Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if (recipe != null)
            {
                recipes.Remove(recipe);
            }
            return RedirectToAction("Index");
        }
    }
}