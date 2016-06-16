using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication4.Models;
using Microsoft.AspNet.Identity;


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
                var lista = _context.FoodCalculator.Where(r => r.OwnerId.Equals(user.Id)).ToList();
                return View(lista);

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
