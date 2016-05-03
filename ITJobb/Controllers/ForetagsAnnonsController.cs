using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITJobb.Models;
using ITJobb.ViewModels;
using System.Data.Entity.Infrastructure;

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
        public ActionResult Create([Bind(Include = "AnnonsId,PubliceringsDatum,YrkestitelRefId,OrtRefId,AnnonsURL,MalsidaRefId,RekryterareRefId")] ForetagsAnnons foretagsAnnons)
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
            ForetagsAnnons foretagsAnnons = db.ForetagsAnnonses
                                        .Include(p => p.Tags) //inkluderar listan med taggar
                                        .Where(i => i.AnnonsId == id) //Där annonsID stämmer överens med inskickat id
                                        .Single(); //Visa endast en artikel
            if (foretagsAnnons == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", foretagsAnnons.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", foretagsAnnons.YrkestitelRefId);
            ViewBag.MalsidaRefId = new SelectList(db.Malsidas, "MalsidaId", "MalsidaNamn", foretagsAnnons.MalsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "ForetagsNamn", foretagsAnnons.RekryterareRefId);
            PopulateAssignedTagData(foretagsAnnons); //Fixa viewbag tags.
            return View(foretagsAnnons);
        }

        // POST: ForetagsAnnons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, string[] valdaTaggar)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }



            var AnnonsUpdate = db.ForetagsAnnonses
                                        .Include(p => p.Tags) //inkluderar listan med taggar
                                        .Where(i => i.AnnonsId == id) //Där annonsID stämmer överens med inskickat id
                                        .Single(); //Visa endast en artikel


            if (TryUpdateModel(AnnonsUpdate, "",
                new string[] { "AnnonsId", "PubliceringsDatum", "YrkestitelRefId", "Yrkestitel", "OrtRefId", "Ort", "AnnonsURL", "MalsidaRefId", "Malsida", "RekryterareRefId", "Rekryterare" }))
            {
                try
                {

                    updateAnnonsTags(valdaTaggar, AnnonsUpdate);
                    db.Entry(AnnonsUpdate).State = EntityState.Modified;

                    db.SaveChanges();

                    return RedirectToAction("Index");

                }
                catch (RetryLimitExceededException)
                {
                    ModelState.AddModelError("", "Unable to save");
                }

            }
            ViewBag.OrtRefId = new SelectList(db.Orts, "OrtId", "OrtNamn", AnnonsUpdate.OrtRefId);
            ViewBag.YrkestitelRefId = new SelectList(db.Yrkestitels, "YrkesTitelId", "YrkesNamn", AnnonsUpdate.YrkestitelRefId);
            ViewBag.MalsidaRefId = new SelectList(db.Malsidas, "MalsidaId", "MalsidaNamn", AnnonsUpdate.MalsidaRefId);
            ViewBag.RekryterareRefId = new SelectList(db.Rekryterares, "RekryterareId", "ForetagsNamn", AnnonsUpdate.RekryterareRefId);
            PopulateAssignedTagData(AnnonsUpdate);
            return View(AnnonsUpdate);
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
        public void updateAnnonsTags(string[] valdaTaggar, Annons annonsToUpdate)
        {
            if (valdaTaggar == null)
            {
                annonsToUpdate.Tags = new List<Tag>();
                return;
            }

            var selectedTagsHS = new HashSet<string>(valdaTaggar);
            var annonsTags = new HashSet<int>
                (annonsToUpdate.Tags.Select(b => b.TagId));

            foreach (var tag in db.Tages)
            {
                if (selectedTagsHS.Contains(tag.TagId.ToString()))
                {
                    if (!annonsTags.Contains(tag.TagId))
                    {
                        annonsToUpdate.Tags.Add(tag);
                    }

                }
                else
                {
                    if (annonsTags.Contains(tag.TagId))
                    {
                        annonsToUpdate.Tags.Remove(tag);
                    }
                }

            }

        }
        public void PopulateAssignedTagData(ForetagsAnnons foretagsAnnons) //Metod för att se assignement av taggar
        {
            var allTags = db.Tages; //Plocka in alla taggar i variabel
            var annonsTags = new HashSet<int>(foretagsAnnons.Tags.Select(b => b.TagId)); //Identiferar ID på taggar som annonsen har
            var viewModel = new List<AnnonsTagWM>(); //Skapar ny lista med view model
            foreach (var tag in allTags) //Loopar igenom alla taggar i databasen
            {
                viewModel.Add(new AnnonsTagWM //Lägger till i listan med view Model
                {
                    TagId = tag.TagId, //Id på taggen
                    TagNamn = tag.TagNamn, //namnet på taggen
                    Selected = annonsTags.Contains(tag.TagId) //om taggen är vald

                });
            }
            ViewBag.Tags = viewModel; // lägger in den nya modellen som viewbag.
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
