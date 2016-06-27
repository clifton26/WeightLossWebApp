using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Identity;
using WebApplication4.Models;
using System.Collections.Generic;
using WebApplication4.ViewModels;
using Microsoft.AspNet.Http.Internal;
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

        /* GET: FoodCalculators/Create
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
        }*/

        // POST: FoodCalculators/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodCalculator foodCalculator, IFormCollection campos)
        {
            
            var user = _context.Users.Single(u => u.UserName.Equals(User.Identity.Name));

            var meal = _context.Meal.Last(m => m.OwnerId.Equals(user.Id));


            int tableEntries = int.Parse(campos["tableCount"]);

            for(var i = 1; i < tableEntries; i++)
            {
                FoodCalculator newCalculator = new FoodCalculator();

                newCalculator.MealId = meal.Id;
                newCalculator.FoodName = campos["food" + i];
                newCalculator.FoodQuantity = int.Parse(campos["quantity" + i]);

                newCalculator.Grams = int.Parse(campos["quantity" + i]);

                newCalculator.Lipid = int.Parse(campos["lipids" + i]);

                newCalculator.Calories = int.Parse(campos["calories" + i]);

                _context.FoodCalculator.Add(newCalculator);

            }

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
          var suggestions = _context.Food.Where(i => i.Name.ToUpper().Contains(searchstring.ToUpper())).ToList().Select(j => new { Id = j.Id, Name = j.Name, Lipidos = j.Lipid_Tot_g,  Calorias = j.Energy_kcal});
          return Json(suggestions);            
        }
    }
}
