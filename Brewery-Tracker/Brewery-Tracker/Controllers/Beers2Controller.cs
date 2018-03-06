using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Brewery_Tracker.Models;

namespace Brewery_Tracker.Controllers
{
    public class Beers2Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Beers2
        public ActionResult Index()
        {
            var beers = db.Beers.Include(b => b.Brewery);
            return View(beers.ToList());
        }

        // GET: Beers2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beers beers = db.Beers.Find(id);
            if (beers == null)
            {
                return HttpNotFound();
            }
            return View(beers);
        }

        // GET: Beers2/Create
        public ActionResult Create()
        {
            ViewBag.Brewery_ID = new SelectList(db.Breweries, "Brewery_ID", "Brewery_Name");
            return View();
        }

        // POST: Beers2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Beer_ID,Beer_Name,Beer_Description,Beer_Rating,ImageName,Brewery_ID")] Beers beers)
        {
            if (ModelState.IsValid)
            {
                db.Beers.Add(beers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Brewery_ID = new SelectList(db.Breweries, "Brewery_ID", "Brewery_Name", beers.Brewery_ID);
            return View(beers);
        }

        // GET: Beers2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beers beers = db.Beers.Find(id);
            if (beers == null)
            {
                return HttpNotFound();
            }
            ViewBag.Brewery_ID = new SelectList(db.Breweries, "Brewery_ID", "Brewery_Name", beers.Brewery_ID);
            return View(beers);
        }

        // POST: Beers2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Beer_ID,Beer_Name,Beer_Description,Beer_Rating,ImageName,Brewery_ID")] Beers beers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Brewery_ID = new SelectList(db.Breweries, "Brewery_ID", "Brewery_Name", beers.Brewery_ID);
            return View(beers);
        }

        // GET: Beers2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beers beers = db.Beers.Find(id);
            if (beers == null)
            {
                return HttpNotFound();
            }
            return View(beers);
        }

        // POST: Beers2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Beers beers = db.Beers.Find(id);
            db.Beers.Remove(beers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
