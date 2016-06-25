using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Identity;
using WebApplication4.Models;
using System.Collections.Generic;
using WebApplication4.ViewModels;
using Microsoft.AspNet.Http;

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
        public IActionResult Create(FoodsCalculator viewModel, IFormCollection campos)
        {
            Food food = new Food();
            if (!string.IsNullOrEmpty(campos["IdComida"]))
            {
                food = _context.Food.Single(m => m.Id == int.Parse(campos["IdComida"]));
            }
            
            var user = _context.Users.Single(u => u.UserName.Equals(User.Identity.Name));

            

          //viewModel.calculator.Meal = viewModel.calculator.Meal;
            viewModel.calculator.FoodName = food.Name;
            // # 3 Rule to obtain the calories by user quantity
            viewModel.calculator.Grams = 100 * viewModel.calculator.FoodQuantity;
            //viewModel.calculator.Lipid = (int) food.Lipid_Tot_g * viewModel.calculator.FoodQuantity;
            //viewModel.calculator.Calories = (int) food.Energy_kcal * viewModel.calculator.FoodQuantity;

            var ruleCalories = (viewModel.calculator.FoodQuantity * (int)food.Energy_kcal) / 100;
            var ruleLipids = (viewModel.calculator.FoodQuantity * (int)food.Lipid_Tot_g) / 100;
            //se dejo el tipo de dato inicial

            viewModel.calculator.Calories = ruleCalories;
            viewModel.calculator.Lipid = ruleLipids;

            // string strDDLValue = Request.Form["MealCombobox"].ToString();
            string mealName = Request.Form["MealName"];
            viewModel.calculator.Meal = mealName;

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

        [HttpPost]
        public JsonResult GetFoodName (string searchstring)
        {
          var suggestions = _context.Food.Where(i => i.Name.ToUpper().Contains(searchstring.ToUpper())).ToList().Select(j => new { Id = j.Id, Name = j.Name});
          return Json(suggestions);            
         }
    }
        
}
