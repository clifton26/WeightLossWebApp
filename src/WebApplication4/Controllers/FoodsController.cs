using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class FoodsController : Controller
    {
        private ApplicationDbContext _context;

        public FoodsController(ApplicationDbContext context)
        {
            _context = context;    
        }
        

        // GET: Foods
        public IActionResult Index()
        {
            ViewBag.Foods = _context.Food.ToList();
            return View();
        }

        // GET: Foods/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Food food = _context.Food.Single(m => m.Id == id);
            if (food == null)
            {
                return HttpNotFound();
            }

            return View(food);
        }

        // GET: Foods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Foods/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Food food)
        {


            if (ModelState.IsValid)
            {
                _context.Food.Add(food);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(food);
            
        }

        
        // GET: Foods/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Food food = _context.Food.Single(m => m.Id == id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // POST: Foods/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                _context.Update(food);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(food);
        }

        // GET: Foods/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Food food = _context.Food.Single(m => m.Id == id);
            if (food == null)
            {
                return HttpNotFound();
            }

            return View(food);
        }

        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Food food = _context.Food.Single(m => m.Id == id);
            _context.Food.Remove(food);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
