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
    public class AnnonsController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Annons
        public ActionResult Index()
        {
            var annonses = db.Annonses.Include(a => a.Ort).Include(a => a.Yrkestitel);
            return View(annonses.ToList());
        }

        // GET: Annons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annons annons = db.Annonses.Find(id);
            if (annons == null)
            {
                return HttpNotFound();
            }
            return View(annons);
        }

        // GET: Annons/Create
        public ActionResult Create()
        {
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn");
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn");
            return View();
        }

        // POST: Annons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId")] Annons annons)
        {
            if (ModelState.IsValid)
            {
                db.Annonses.Add(annons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", annons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", annons.YrkestitelRefId);
            return View(annons);
        }

        // GET: Annons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annons annons = db.Annonses.Find(id);
            if (annons == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", annons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", annons.YrkestitelRefId);
            return View(annons);
        }

        // POST: Annons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId")] Annons annons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(annons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", annons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", annons.YrkestitelRefId);
            return View(annons);
        }

        // GET: Annons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annons annons = db.Annonses.Find(id);
            if (annons == null)
            {
                return HttpNotFound();
            }
            return View(annons);
        }

        // POST: Annons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Annons annons = db.Annonses.Find(id);
            db.Annonses.Remove(annons);
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
