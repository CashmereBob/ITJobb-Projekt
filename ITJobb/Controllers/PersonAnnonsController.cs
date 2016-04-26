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
    public class PersonAnnonsController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: PersonAnnons
        public ActionResult Index()
        {
            var annonses = db.PersonAnnonses.Include(p => p.Ort).Include(p => p.Yrkestitel).Include(p => p.Användare);
            return View(annonses.ToList());
        }

        // GET: PersonAnnons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAnnons personAnnons = db.Annonses.Find(id) as PersonAnnons;
            if (personAnnons == null)
            {
                return HttpNotFound();
            }
            return View(personAnnons);
        }

        // GET: PersonAnnons/Create
        public ActionResult Create()
        {
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn");
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn");
            ViewBag.AnvändareRefId = new SelectList(db.Användares, "AnvändareId", "FörNamn");
            return View();
        }

        // POST: PersonAnnons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId,Titel,Beskrivning,AnvändareRefId")] PersonAnnons personAnnons)
        {
            if (ModelState.IsValid)
            {
                db.Annonses.Add(personAnnons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", personAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", personAnnons.YrkestitelRefId);
            ViewBag.AnvändareRefId = new SelectList(db.Användares, "AnvändareId", "FörNamn", personAnnons.AnvändareRefId);
            return View(personAnnons);
        }

        // GET: PersonAnnons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAnnons personAnnons = db.Annonses.Find(id) as PersonAnnons;
            if (personAnnons == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", personAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", personAnnons.YrkestitelRefId);
            ViewBag.AnvändareRefId = new SelectList(db.Användares, "AnvändareId", "FörNamn", personAnnons.AnvändareRefId);
            return View(personAnnons);
        }

        // POST: PersonAnnons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId,Titel,Beskrivning,AnvändareRefId")] PersonAnnons personAnnons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personAnnons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", personAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", personAnnons.YrkestitelRefId);
            ViewBag.AnvändareRefId = new SelectList(db.Användares, "AnvändareId", "FörNamn", personAnnons.AnvändareRefId);
            return View(personAnnons);
        }

        // GET: PersonAnnons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAnnons personAnnons = db.Annonses.Find(id) as PersonAnnons;
            if (personAnnons == null)
            {
                return HttpNotFound();
            }
            return View(personAnnons);
        }

        // POST: PersonAnnons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonAnnons personAnnons = db.Annonses.Find(id) as PersonAnnons;
            db.Annonses.Remove(personAnnons);
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
