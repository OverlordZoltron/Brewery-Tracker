using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Brewery_Tracker.Models;
using System.Web.Helpers;

namespace Brewery_Tracker.Controllers
{
    public class BeersCRUDController : Controller
    {
        private BeerFactory db = new BeerFactory();

        // GET: BeersCRUD
        public ActionResult Index()
        {
            return View(db.Beers.ToList());
        }

        // GET: BeersCRUD/Details/5
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

        // GET: BeersCRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeersCRUD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Beer_ID,Beer_Name,Beer_Description,Beer_Rating,ImageName")] Beers beers)
        {
            if (ModelState.IsValid)
            {
                db.Beers.Add(beers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beers);
        }

        // GET: BeersCRUD/Edit/5
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
            return View(beers);
        }

        // POST: BeersCRUD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Beer_ID,Beer_Name,Beer_Description,Beer_Rating,ImageName")] Beers beers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beers);
        }

        // GET: BeersCRUD/Delete/5
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

        // POST: BeersCRUD/Delete/5
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

        public ActionResult Picture(int id)
        {
            // facory instance
            var factory = new BeerFactory();

            //find beer from DB based on the ID
            var beer = factory.Beers.Where(p => p.Beer_ID == id).FirstOrDefault();

            //if null (no match, get ou)
            if (beer == null)
            {
                return HttpNotFound();
            }

            // else we found a match
            // create an image object and resize it
            var img = new WebImage(string.Format("~/Content/Images/{0}.jpg", beer.ImageName));
            img.Resize(300, 300);

            //return this image for use by other actions/methods
            return File(img.GetBytes(), "image/jpeg");
        }
    }
}
