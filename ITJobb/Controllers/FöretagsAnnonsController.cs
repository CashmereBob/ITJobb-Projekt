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
    public class FöretagsAnnonsController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: FöretagsAnnons
        public ActionResult Index()
        {
            var annonses = db.FöretagsAnnonses.Include(f => f.Ort).Include(f => f.Yrkestitel).Include(f => f.Målsida).Include(f => f.Rekryterare);
            return View(annonses.ToList());
        }

        // GET: FöretagsAnnons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FöretagsAnnons företagsAnnons = db.Annonses.Find(id) as FöretagsAnnons;
            if (företagsAnnons == null)
            {
                return HttpNotFound();
            }
            return View(företagsAnnons);
        }

        // GET: FöretagsAnnons/Create
        public ActionResult Create()
        {
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn");
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn");
            ViewBag.MålsidaRefId = new SelectList(db.Målsidas, "MålsidaId", "MålsidaNamn");
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "FöretagsNamn");
            return View();
        }

        // POST: FöretagsAnnons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId,AnnonsURL,MålsidaRefId,RekryterareRefId")] FöretagsAnnons företagsAnnons)
        {
            if (ModelState.IsValid)
            {
                db.Annonses.Add(företagsAnnons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", företagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", företagsAnnons.YrkestitelRefId);
            ViewBag.MålsidaRefId = new SelectList(db.Målsidas, "MålsidaId", "MålsidaNamn", företagsAnnons.MålsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "FöretagsNamn", företagsAnnons.RekryterareRefId);
            return View(företagsAnnons);
        }

        // GET: FöretagsAnnons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FöretagsAnnons företagsAnnons = db.Annonses.Find(id) as FöretagsAnnons;
            if (företagsAnnons == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", företagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", företagsAnnons.YrkestitelRefId);
            ViewBag.MålsidaRefId = new SelectList(db.Målsidas, "MålsidaId", "MålsidaNamn", företagsAnnons.MålsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "FöretagsNamn", företagsAnnons.RekryterareRefId);
            return View(företagsAnnons);
        }

        // POST: FöretagsAnnons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnnonsId,YrkestitelRefId,OrtRefId,AnnonsURL,MålsidaRefId,RekryterareRefId")] FöretagsAnnons företagsAnnons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(företagsAnnons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", företagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", företagsAnnons.YrkestitelRefId);
            ViewBag.MålsidaRefId = new SelectList(db.Målsidas, "MålsidaId", "MålsidaNamn", företagsAnnons.MålsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "FöretagsNamn", företagsAnnons.RekryterareRefId);
            return View(företagsAnnons);
        }

        // GET: FöretagsAnnons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FöretagsAnnons företagsAnnons = db.Annonses.Find(id) as FöretagsAnnons;
            if (företagsAnnons == null)
            {
                return HttpNotFound();
            }
            return View(företagsAnnons);
        }

        // POST: FöretagsAnnons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FöretagsAnnons företagsAnnons = db.Annonses.Find(id) as FöretagsAnnons;
            db.Annonses.Remove(företagsAnnons);
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
