using ManagmentCinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentCinema.Controllers
{
    public class GenreFilmController : Controller
    {
        private readonly Db_CinemaContext db_CinemaContext;

        public GenreFilmController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }
        // GET: GenreFilmController
        public ActionResult Index()
        {
            var genreFilm = db_CinemaContext.GenreFilms.ToList();
            return View(genreFilm);
        }

        // GET: GenreFilmController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenreFilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreFilmController/Create
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

        // GET: GenreFilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenreFilmController/Edit/5
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

        // GET: GenreFilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenreFilmController/Delete/5
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
