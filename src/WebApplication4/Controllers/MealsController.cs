using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApplication4.Models;

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
            return View(applicationDbContext.ToList());
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

            return View(meal);
        }

        // GET: Meals/Create
        public IActionResult Create()
        {
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner");
            return View();
        }

        // POST: Meals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Meal meal)
        {
            if (ModelState.IsValid)
            {
                _context.Meal.Add(meal);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner", meal.OwnerId);
            return View(meal);
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
