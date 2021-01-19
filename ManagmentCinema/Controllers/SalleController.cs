using ManagmentCinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentCinema.Controllers
{
    public class SalleController : Controller
    {
        private readonly Db_CinemaContext db_CinemaContext;

        public SalleController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }
        // GET: SalleController
        public ActionResult Index()
        {
            var salle = db_CinemaContext.Salles.ToList();
            return View(salle);
        }

        // GET: SalleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SalleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
