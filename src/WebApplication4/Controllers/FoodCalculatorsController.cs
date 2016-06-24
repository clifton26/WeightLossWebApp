using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Identity;
using WebApplication4.Models;
using System.Collections.Generic;
using WebApplication4.ViewModels;


namespace WebApplication4.Controllers
{
    public class FoodCalculatorsController : Controller
    {
        private ApplicationDbContext _context;

        public FoodCalculatorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FoodCalculators
        public IActionResult Index()
        {
            return View(_context.FoodCalculator.ToList());
        }

        // GET: FoodCalculators/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FoodCalculator foodCalculator = _context.FoodCalculator.Single(m => m.Id == id);
            if (foodCalculator == null)
            {
                return HttpNotFound();
            }

            return View(foodCalculator);
        }

        // GET: FoodCalculators/Create
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

        // POST: FoodCalculators/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodsCalculator viewModel)
        {
            var food = _context.Food.Single(m => m.Id == viewModel.foodId);
            var user = _context.Users.Single(u => u.UserName.Equals(User.Identity.Name));

          //viewModel.calculator.Meal = viewModel.calculator.Meal;
            viewModel.calculator.FoodName = food.Name;
            viewModel.calculator.Grams = 100* viewModel.calculator.FoodQuantity;
            viewModel.calculator.Lipid = (int) food.Lipid_Tot_g * viewModel.calculator.FoodQuantity;
            viewModel.calculator.Calories = (int) food.Energy_kcal * viewModel.calculator.FoodQuantity;
            viewModel.calculator.Owner = user;

            _context.FoodCalculator.Add(viewModel.calculator);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }

        // GET: FoodCalculators/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FoodCalculator foodCalculator = _context.FoodCalculator.Single(m => m.Id == id);
            if (foodCalculator == null)
            {
                return HttpNotFound();
            }
            return View(foodCalculator);
        }

        // POST: FoodCalculators/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FoodCalculator foodCalculator)
        {
            if (ModelState.IsValid)
            {
                _context.Update(foodCalculator);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodCalculator);
        }

        // GET: FoodCalculators/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FoodCalculator foodCalculator = _context.FoodCalculator.Single(m => m.Id == id);
            if (foodCalculator == null)
            {
                return HttpNotFound();
            }

            return View(foodCalculator);
        }

        // POST: FoodCalculators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            FoodCalculator foodCalculator = _context.FoodCalculator.Single(m => m.Id == id);
            _context.FoodCalculator.Remove(foodCalculator);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
