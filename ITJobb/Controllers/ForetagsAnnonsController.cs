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
    public class ForetagsAnnonsController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: ForetagsAnnons
        public ActionResult Index()
        {
            var annonses = db.ForetagsAnnonses.Include(f => f.Ort).Include(f => f.Yrkestitel).Include(f => f.Malsida).Include(f => f.Rekryterare);
            return View(annonses.ToList());
        }

        // GET: ForetagsAnnons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ForetagsAnnons foretagsAnnons = db.Annonses.Find(id) as ForetagsAnnons;
            if (foretagsAnnons == null)
            {
                return HttpNotFound();
            }
            return View(foretagsAnnons);
        }

        // GET: ForetagsAnnons/Create
        public ActionResult Create()
        {
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn");
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn");
            ViewBag.MalsidaRefId = new SelectList(db.Malsidas, "MalsidaId", "MalsidaNamn");
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "ForetagsNamn");
            return View();
        }

        // POST: ForetagsAnnons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId,AnnonsURL,MalsidaRefId,RekryterareRefId")] ForetagsAnnons foretagsAnnons)
        {
            if (ModelState.IsValid)
            {
                db.Annonses.Add(foretagsAnnons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", foretagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", foretagsAnnons.YrkestitelRefId);
            ViewBag.MalsidaRefId = new SelectList(db.Malsidas, "MalsidaId", "MalsidaNamn", foretagsAnnons.MalsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "ForetagsNamn", foretagsAnnons.RekryterareRefId);
            return View(foretagsAnnons);
        }

        // GET: ForetagsAnnons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ForetagsAnnons foretagsAnnons = db.Annonses.Find(id) as ForetagsAnnons;
            if (foretagsAnnons == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", foretagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", foretagsAnnons.YrkestitelRefId);
            ViewBag.MalsidaRefId = new SelectList(db.Malsidas, "MalsidaId", "MalsidaNamn", foretagsAnnons.MalsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "ForetagsNamn", foretagsAnnons.RekryterareRefId);
            return View(foretagsAnnons);
        }

        // POST: ForetagsAnnons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId,AnnonsURL,MalsidaRefId,RekryterareRefId")] ForetagsAnnons foretagsAnnons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foretagsAnnons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", foretagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", foretagsAnnons.YrkestitelRefId);
            ViewBag.MalsidaRefId = new SelectList(db.Malsidas, "MalsidaId", "MalsidaNamn", foretagsAnnons.MalsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "ForetagsNamn", foretagsAnnons.RekryterareRefId);
            return View(foretagsAnnons);
        }

        // GET: ForetagsAnnons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ForetagsAnnons foretagsAnnons = db.Annonses.Find(id) as ForetagsAnnons;
            if (foretagsAnnons == null)
            {
                return HttpNotFound();
            }
            return View(foretagsAnnons);
        }

        // POST: ForetagsAnnons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ForetagsAnnons foretagsAnnons = db.Annonses.Find(id) as ForetagsAnnons;
            db.Annonses.Remove(foretagsAnnons);
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
