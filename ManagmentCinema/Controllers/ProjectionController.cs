using ManagmentCinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentCinema.Controllers
{
    public class ProjectionController : Controller
    {
        private readonly Db_CinemaContext db_CinemaContext;

        public ProjectionController(Db_CinemaContext db_CinemaContext)
        {
            this.db_CinemaContext = db_CinemaContext;
        }
        // GET: ProjectionController
        public ActionResult Index()
        {
            var projection = db_CinemaContext.Projections.ToList();
            return View(projection);
        }

        // GET: ProjectionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjectionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectionController/Create
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

        // GET: ProjectionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectionController/Edit/5
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

        // GET: ProjectionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectionController/Delete/5
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
