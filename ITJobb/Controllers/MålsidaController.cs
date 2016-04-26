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
    public class MålsidaController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Målsida
        public ActionResult Index()
        {
            return View(db.Målsidas.ToList());
        }

        // GET: Målsida/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Målsida målsida = db.Målsidas.Find(id);
            if (målsida == null)
            {
                return HttpNotFound();
            }
            return View(målsida);
        }

        // GET: Målsida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Målsida/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MålsidaId,MålsidaNamn,MålsidaUrl")] Målsida målsida)
        {
            if (ModelState.IsValid)
            {
                db.Målsidas.Add(målsida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(målsida);
        }

        // GET: Målsida/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Målsida målsida = db.Målsidas.Find(id);
            if (målsida == null)
            {
                return HttpNotFound();
            }
            return View(målsida);
        }

        // POST: Målsida/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MålsidaId,MålsidaNamn,MålsidaUrl")] Målsida målsida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(målsida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(målsida);
        }

        // GET: Målsida/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Målsida målsida = db.Målsidas.Find(id);
            if (målsida == null)
            {
                return HttpNotFound();
            }
            return View(målsida);
        }

        // POST: Målsida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Målsida målsida = db.Målsidas.Find(id);
            db.Målsidas.Remove(målsida);
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
