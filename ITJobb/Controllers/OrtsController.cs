using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITJobb.Models;

namespace ITJobb.Controllers
{
    public class OrtsController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Orts
        public ActionResult Index()
        {
            return View(db.Orts.ToList());
        }

        // GET: Orts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ort ort = db.Orts.Find(id);
            if (ort == null)
            {
                return HttpNotFound();
            }
            return View(ort);
        }

        // GET: Orts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrtId,OrtNamn")] Ort ort)
        {
            if (ModelState.IsValid)
            {
                db.Orts.Add(ort);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ort);
        }

        // GET: Orts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ort ort = db.Orts.Find(id);
            if (ort == null)
            {
                return HttpNotFound();
            }
            return View(ort);
        }

        // POST: Orts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrtId,OrtNamn")] Ort ort)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ort).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ort);
        }

        // GET: Orts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ort ort = db.Orts.Find(id);
            if (ort == null)
            {
                return HttpNotFound();
            }
            return View(ort);
        }

        // POST: Orts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ort ort = db.Orts.Find(id);
            db.Orts.Remove(ort);
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
