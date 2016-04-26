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
    public class YrkesTitelsController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: YrkesTitels
        public ActionResult Index()
        {
            return View(db.Yrkestitels.ToList());
        }

        // GET: YrkesTitels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YrkesTitel yrkesTitel = db.Yrkestitels.Find(id);
            if (yrkesTitel == null)
            {
                return HttpNotFound();
            }
            return View(yrkesTitel);
        }

        // GET: YrkesTitels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YrkesTitels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YrkesTitelId,YrkesNamn,MedelLon")] YrkesTitel yrkesTitel)
        {
            if (ModelState.IsValid)
            {
                db.Yrkestitels.Add(yrkesTitel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yrkesTitel);
        }

        // GET: YrkesTitels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YrkesTitel yrkesTitel = db.Yrkestitels.Find(id);
            if (yrkesTitel == null)
            {
                return HttpNotFound();
            }
            return View(yrkesTitel);
        }

        // POST: YrkesTitels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YrkesTitelId,YrkesNamn,MedelLon")] YrkesTitel yrkesTitel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yrkesTitel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yrkesTitel);
        }

        // GET: YrkesTitels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YrkesTitel yrkesTitel = db.Yrkestitels.Find(id);
            if (yrkesTitel == null)
            {
                return HttpNotFound();
            }
            return View(yrkesTitel);
        }

        // POST: YrkesTitels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            YrkesTitel yrkesTitel = db.Yrkestitels.Find(id);
            db.Yrkestitels.Remove(yrkesTitel);
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
