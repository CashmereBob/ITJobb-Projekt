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
    public class RekryteraresController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Rekryterares
        public ActionResult Index()
        {
            return View(db.Rekryterares.ToList());
        }

        // GET: Rekryterares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rekryterare rekryterare = db.Rekryterares.Find(id);
            if (rekryterare == null)
            {
                return HttpNotFound();
            }
            return View(rekryterare);
        }

        // GET: Rekryterares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rekryterares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RekryterareId,FöretagsNamn,RekryterareURL,MailAdress")] Rekryterare rekryterare)
        {
            if (ModelState.IsValid)
            {
                db.Rekryterares.Add(rekryterare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rekryterare);
        }

        // GET: Rekryterares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rekryterare rekryterare = db.Rekryterares.Find(id);
            if (rekryterare == null)
            {
                return HttpNotFound();
            }
            return View(rekryterare);
        }

        // POST: Rekryterares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RekryterareId,FöretagsNamn,RekryterareURL,MailAdress")] Rekryterare rekryterare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rekryterare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rekryterare);
        }

        // GET: Rekryterares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rekryterare rekryterare = db.Rekryterares.Find(id);
            if (rekryterare == null)
            {
                return HttpNotFound();
            }
            return View(rekryterare);
        }

        // POST: Rekryterares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rekryterare rekryterare = db.Rekryterares.Find(id);
            db.Rekryterares.Remove(rekryterare);
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
