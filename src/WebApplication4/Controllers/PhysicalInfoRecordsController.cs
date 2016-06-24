using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PhysicalInfoRecordsController : Controller
    {
        private ApplicationDbContext _context;

        public PhysicalInfoRecordsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: PhysicalInfoRecords
        public IActionResult Index()
        {
            var user = _context.Users.Single(u => u.UserName.Equals(User.Identity.Name));
            var records = _context.PhysicalInfoRecord.Where(p => p.OwnerId.Equals(user.Id)).ToList();
            return View(records);
        }

        // GET: PhysicalInfoRecords/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PhysicalInfoRecord physicalInfoRecord = _context.PhysicalInfoRecord.Single(m => m.id == id);
            if (physicalInfoRecord == null)
            {
                return HttpNotFound();
            }

            return View(physicalInfoRecord);
        }

        // GET: PhysicalInfoRecords/Create
        public IActionResult Create()
        {
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner");
            return View();
        }

        // POST: PhysicalInfoRecords/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PhysicalInfoRecord physicalInfoRecord)
        {
            if (ModelState.IsValid)
            {
                _context.PhysicalInfoRecord.Add(physicalInfoRecord);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner", physicalInfoRecord.OwnerId);
            return View(physicalInfoRecord);
        }

        // GET: PhysicalInfoRecords/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PhysicalInfoRecord physicalInfoRecord = _context.PhysicalInfoRecord.Single(m => m.id == id);
            if (physicalInfoRecord == null)
            {
                return HttpNotFound();
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner", physicalInfoRecord.OwnerId);
            return View(physicalInfoRecord);
        }

        // POST: PhysicalInfoRecords/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PhysicalInfoRecord physicalInfoRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Update(physicalInfoRecord);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Owner", physicalInfoRecord.OwnerId);
            return View(physicalInfoRecord);
        }

        // GET: PhysicalInfoRecords/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PhysicalInfoRecord physicalInfoRecord = _context.PhysicalInfoRecord.Single(m => m.id == id);
            if (physicalInfoRecord == null)
            {
                return HttpNotFound();
            }

            return View(physicalInfoRecord);
        }

        // POST: PhysicalInfoRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            PhysicalInfoRecord physicalInfoRecord = _context.PhysicalInfoRecord.Single(m => m.id == id);
            _context.PhysicalInfoRecord.Remove(physicalInfoRecord);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
