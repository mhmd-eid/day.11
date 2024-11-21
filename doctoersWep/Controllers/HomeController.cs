using System.Diagnostics;
using doctoersWep.Data;
using doctoersWep.Models;
using Microsoft.AspNetCore.Mvc;

namespace doctoersWep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbcontext dbcontext = new ApplicationDbcontext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
           
            return View();
           
        }
        public IActionResult Show(int DoctorsId)
        {

            var dbconxts = dbcontext.Doctors.Find(DoctorsId);
            if(dbconxts != null) return View(dbconxts);
            return View(dbconxts);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
