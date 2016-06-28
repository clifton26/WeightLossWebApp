using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApplication4.Models;
using Microsoft.AspNet.Http;
using WebApplication4.ViewModels;
using System;
using System.Collections.Generic;

namespace WebApplication4.Controllers
{
    public class MealsController : Controller
    {
        private ApplicationDbContext _context;

        public MealsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Meals
        public IActionResult Index()
        {
            var applicationDbContext = _context.Meal.Include(m => m.Owner);
            var ordered = applicationDbContext.ToList().OrderByDescending(m => m.recordDate);
            return View(ordered);
        }

        // GET: Meals/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Meal meal = _context.Meal.Single(m => m.Id == id);
            if (meal == null)
            {
                return HttpNotFound();
            }

            IEnumerable<FoodCalculator> ingredients = _context.FoodCalculator.Where(f => f.MealId == meal.Id);

            MealDetails viewModel = new MealDetails();

            viewModel.meal = meal;
            viewModel.regists = ingredients;

            return View(viewModel);
        }

        // GET: Meals/Create
        public IActionResult Create()
        {
            FoodsCalculator viewModel = new FoodsCalculator();

            List<Food> foods = _context.Food.ToList();
            viewModel.selectList =
                from f in foods
                select new SelectListItem
                {
                    Text = f.Name,
                    Value = f.Id.ToString()
                };

            return View(viewModel);
        }

        // POST: Meals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodsCalculator viewModel, IFormCollection campos)
        {

            var user = _context.Users.Single(u => u.UserName.Equals(User.Identity.Name));

            Meal mealToAdd = new Meal();


            String totalCalories = campos["totalCalories"];
            String totalLipids = campos["totalLipds"];

            mealToAdd.Owner = user;

            mealToAdd.totalCalories = int.Parse(totalCalories.Substring(0, totalCalories.Length - 1));

            mealToAdd.totalLipids = int.Parse(totalLipids.Substring(0, totalLipids.Length - 1));

            mealToAdd.MealName = campos["MealName"];

            mealToAdd.recordDate = DateTime.Now;

            _context.Meal.Add(mealToAdd);
            _context.SaveChanges();

            var meal = _context.Meal.Last(m => m.OwnerId.Equals(user.Id));

            int tableEntries = int.Parse(campos["tableCount"]);

            for (var i = 1; i <= tableEntries; i++)
            {
                FoodCalculator newCalculator = new FoodCalculator();

                newCalculator.MealId = meal.Id;
                newCalculator.FoodName = campos["food" + i];

                String quantity = campos["quantity" + i];
                String lipids = campos["lipids" + i];
                String calories = campos["calories" + i];

                newCalculator.FoodQuantity = int.Parse(quantity.Substring(0, quantity.Length - 1));

                newCalculator.Grams = 100 * int.Parse(quantity.Substring(0, quantity.Length - 1));

                newCalculator.Lipid = int.Parse(lipids.Substring(0, lipids.Length - 1));

                newCalculator.Calories = int.Parse(calories.Substring(0, calories.Length - 1));

                _context.FoodCalculator.Add(newCalculator);

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // GET: Meals/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Meal meal = _context.Meal.Single(m => m.Id == id);
            if (meal == null)
            {
                return HttpNotFound();
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner", meal.OwnerId);
            return View(meal);
        }

        // POST: Meals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Meal meal)
        {
            if (ModelState.IsValid)
            {
                _context.Update(meal);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner", meal.OwnerId);
            return View(meal);
        }

        // GET: Meals/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Meal meal = _context.Meal.Single(m => m.Id == id);
            if (meal == null)
            {
                return HttpNotFound();
            }

            return View(meal);
        }

        // POST: Meals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Meal meal = _context.Meal.Single(m => m.Id == id);
            _context.Meal.Remove(meal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
