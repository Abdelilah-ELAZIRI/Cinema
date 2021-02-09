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
    public class GenreController : Controller
    {
        private readonly Db_CinemaContext db_CinemaContext;

        public GenreController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }

        // GET: GenreController
        public ActionResult Index()
        {
            var genre = db_CinemaContext.Genres.ToList();
            return View(genre);
        }

        // GET: GenreController/Details/5
        public ActionResult Details(int id)
        {
            var genre = db_CinemaContext.Genres.Find(id);
            return View(genre);
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            try
            {
                db_CinemaContext.Genres.Add(genre);
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            var genre = db_CinemaContext.Genres.Find(id);
            return View(genre);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Genre genre)
        {
            try
            {
                db_CinemaContext.Entry(genre).State = EntityState.Modified;
                db_CinemaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            var genre = db_CinemaContext.Genres.Find(id);
            return View(genre);
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Genre genre)
        {
            try
            {
                db_CinemaContext.Genres.Remove(genre);
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
