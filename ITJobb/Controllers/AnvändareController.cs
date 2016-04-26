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
    public class AnvändareController : Controller
    {
        private ITJobbDbContext db = new ITJobbDbContext();

        // GET: Användare
        public ActionResult Index()
        {
            return View(db.Användares.ToList());
        }

        // GET: Användare/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Användare användare = db.Användares.Find(id);
            if (användare == null)
            {
                return HttpNotFound();
            }
            return View(användare);
        }

        // GET: Användare/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Användare/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnvändareId,FörNamn,EfterNamn,TelefonNummer,MailAdress,CVURL,PersonligtBrevURL")] Användare användare)
        {
            if (ModelState.IsValid)
            {
                db.Användares.Add(användare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(användare);
        }

        // GET: Användare/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Användare användare = db.Användares.Find(id);
            if (användare == null)
            {
                return HttpNotFound();
            }
            return View(användare);
        }

        // POST: Användare/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnvändareId,FörNamn,EfterNamn,TelefonNummer,MailAdress,CVURL,PersonligtBrevURL")] Användare användare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(användare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(användare);
        }

        // GET: Användare/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Användare användare = db.Användares.Find(id);
            if (användare == null)
            {
                return HttpNotFound();
            }
            return View(användare);
        }

        // POST: Användare/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Användare användare = db.Användares.Find(id);
            db.Användares.Remove(användare);
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
