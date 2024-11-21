using doctoersWep.Data;
using doctoersWep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace doctoersWep.Controllers
{
    public class BookanAppointmentController : Controller
    {
        private readonly ApplicationDbcontext dbcontext = new ApplicationDbcontext();
        private readonly Patient _patient = new Patient();
        public IActionResult Index()
        {
            var dbconxt = dbcontext.Doctors.ToList();
            return View(dbconxt);
        }

        public IActionResult Create()
        {
            var patient = dbcontext.patients.ToList();
            return View();
        }

        //public IActionResult CreateNew(string name)
        //{
        //    var patient = dbcontext.patients.Add(new()
        //    {
        //        Name = name
        //    });
        //    dbcontext.SaveChanges();
        //    return View();
        //}
    }
}
