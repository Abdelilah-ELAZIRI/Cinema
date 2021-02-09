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
    public class FilmController : Controller
    {
        
        private readonly Db_CinemaContext db_CinemaContext;
        public FilmController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }
        // GET: FilmController
        public ActionResult Index()
        {
            var film = db_CinemaContext.Films.ToList();
            return View(film);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            var film = db_CinemaContext.Films.Find(id);
            return View(film);
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            try
            {
                db_CinemaContext.Films.Add(film);
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            var film = db_CinemaContext.Films.Find(id);
            return View(film);
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film film)
        {
            try
            {
                db_CinemaContext.Entry(film).State = EntityState.Modified;
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            var film = db_CinemaContext.Films.Find(id);
            return View(film);
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Film film)
        {
            try
            {
                db_CinemaContext.Films.Remove(film);
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
