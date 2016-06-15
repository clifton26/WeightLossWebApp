using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApplication4.Models;

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
            return View();
        }

        // POST: FoodCalculators/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodCalculator foodCalculator)
        {
            if (ModelState.IsValid)
            {
                _context.FoodCalculator.Add(foodCalculator);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodCalculator);
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
