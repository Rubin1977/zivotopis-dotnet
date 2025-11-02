using RastislavRuzbackyMojeCVmvc.Data;
using RastislavRuzbackyMojeCVmvc.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity;


namespace RastislavRuzbackyMvcOsobnaStranka.Controllers
{
    public class PacientController : Controller
    {
        private AplikaciaDbContext db = new AplikaciaDbContext();

        public ActionResult Index()
        {
            var pacienti = db.Pacienti.ToList(); // Načíta pacientov z databázy
            return View(pacienti);
        }
        public ActionResult Details(int id)
        {
            var pacient = db.Pacienti
                .Include(p => p.Priznaky)
                .Include(p => p.GenetickeVysetrenia)
                .Include(p => p.Diagnozy)
                .FirstOrDefault(p => p.Id == id);

            if (pacient == null)
                return HttpNotFound();

            return View(pacient);
        }
    }
}
