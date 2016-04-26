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
    public class MalsidasController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Malsidas
        public ActionResult Index()
        {
            return View(db.Malsidas.ToList());
        }

        // GET: Malsidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malsida malsida = db.Malsidas.Find(id);
            if (malsida == null)
            {
                return HttpNotFound();
            }
            return View(malsida);
        }

        // GET: Malsidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Malsidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MalsidaId,MalsidaNamn,MalsidaUrl")] Malsida malsida)
        {
            if (ModelState.IsValid)
            {
                db.Malsidas.Add(malsida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(malsida);
        }

        // GET: Malsidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malsida malsida = db.Malsidas.Find(id);
            if (malsida == null)
            {
                return HttpNotFound();
            }
            return View(malsida);
        }

        // POST: Malsidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MalsidaId,MalsidaNamn,MalsidaUrl")] Malsida malsida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(malsida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(malsida);
        }

        // GET: Malsidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malsida malsida = db.Malsidas.Find(id);
            if (malsida == null)
            {
                return HttpNotFound();
            }
            return View(malsida);
        }

        // POST: Malsidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Malsida malsida = db.Malsidas.Find(id);
            db.Malsidas.Remove(malsida);
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
