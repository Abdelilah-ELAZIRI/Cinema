using ManagmentCinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentCinema.Controllers
{
    public class PromoController : Controller
    {
        private readonly Db_CinemaContext db_CinemaContext;

        public PromoController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }
        // GET: PromoController
        public ActionResult Index()
        {
            var promo = db_CinemaContext.Promos.ToList();
            return View(promo);
        }

        // GET: PromoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PromoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromoController/Create
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

        // GET: PromoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PromoController/Edit/5
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

        // GET: PromoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PromoController/Delete/5
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
