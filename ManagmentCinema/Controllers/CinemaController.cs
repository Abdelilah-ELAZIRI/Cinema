using ManagmentCinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentCinema.Controllers
{
    public class CinemaController : Controller
    {
        private readonly Db_CinemaContext db_CinemaContext;

        public CinemaController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }

        // GET: CinemaController
        public ActionResult Index()
        {
            var cinema = db_CinemaContext.Cinemas.ToList();
            return View(cinema);
        }

        // GET: CinemaController/Details/5
        public ActionResult Details(int id)
        {
            var cinema = db_CinemaContext.Cinemas.Find(id);
            return View(cinema);
        }

        // GET: CinemaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cinema cinema)
        {
            try
            {
                db_CinemaContext.Cinemas.Add(cinema);
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaController/Edit/5
        public ActionResult Edit(int id)
        {
            var cinema = db_CinemaContext.Cinemas.Find(id);
            return View(cinema);
        }

        // POST: CinemaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cinema cinema)
        {
            try
            {
                db_CinemaContext.Entry(cinema).State = EntityState.Modified;
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaController/Delete/5
        public ActionResult Delete(int id)
        {
            var cinema = db_CinemaContext.Cinemas.Find(id);
            return View(cinema);
        }

        // POST: CinemaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Cinema cinema)
        {
            try
            {
                db_CinemaContext.Cinemas.Remove(cinema);
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
