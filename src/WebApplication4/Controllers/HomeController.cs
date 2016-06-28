using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication4.Models;
using Microsoft.AspNet.Identity;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public string backgroundImage= "";
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _context.Users.Single(u => u.UserName.Equals(User.Identity.Name));

                HomeViewModel viewModel = new HomeViewModel();
                viewModel.user = user;
                DateTime now = DateTime.Now;
                DateTime threeDaysAgo = new DateTime(now.Year, now.Month, now.Day - 3);

                viewModel.physicalRecords = _context.PhysicalInfoRecord.Where(r => r.OwnerId.Equals(user.Id) && r.recordDate.Date >= threeDaysAgo.Date && r.recordDate.Date <= DateTime.Now.Date).ToList().OrderByDescending(p => p.recordDate);

                viewModel.meals = _context.Meal.Where(r => r.OwnerId.Equals(user.Id) && r.recordDate.Date.Equals(DateTime.Now.Date)).ToList().OrderByDescending(m => m.recordDate);

                return View(viewModel);

            }else
            {
                return View();
            }

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
