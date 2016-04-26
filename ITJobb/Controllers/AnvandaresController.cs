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
    public class AnvandaresController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Anvandares
        public ActionResult Index()
        {
            return View(db.Anvandares.ToList());
        }

        // GET: Anvandares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anvandare anvandare = db.Anvandares.Find(id);
            if (anvandare == null)
            {
                return HttpNotFound();
            }
            return View(anvandare);
        }

        // GET: Anvandares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anvandares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnvandareId,ForNamn,EfterNamn,TelefonNummer,MailAdress,CVURL,PersonligtBrevURL")] Anvandare anvandare)
        {
            if (ModelState.IsValid)
            {
                db.Anvandares.Add(anvandare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anvandare);
        }

        // GET: Anvandares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anvandare anvandare = db.Anvandares.Find(id);
            if (anvandare == null)
            {
                return HttpNotFound();
            }
            return View(anvandare);
        }

        // POST: Anvandares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnvandareId,ForNamn,EfterNamn,TelefonNummer,MailAdress,CVURL,PersonligtBrevURL")] Anvandare anvandare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anvandare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anvandare);
        }

        // GET: Anvandares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anvandare anvandare = db.Anvandares.Find(id);
            if (anvandare == null)
            {
                return HttpNotFound();
            }
            return View(anvandare);
        }

        // POST: Anvandares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anvandare anvandare = db.Anvandares.Find(id);
            db.Anvandares.Remove(anvandare);
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
