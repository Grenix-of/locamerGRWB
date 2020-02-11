using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using locamerguu;

namespace locamerguu.Controllers
{
    public class EmplacementsController : Controller
    {
        private LocamerGRuEntities db = new LocamerGRuEntities();

        // GET: Emplacements
        public ActionResult Index()
        {
            var emplacement = db.Emplacement.Include(e => e.Tarif);
            return View(emplacement.ToList());
        }

        // GET: Emplacements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emplacement emplacement = db.Emplacement.Find(id);
            if (emplacement == null)
            {
                return HttpNotFound();
            }
            return View(emplacement);
        }

        // GET: Emplacements/Create
        public ActionResult Create()
        {
            ViewBag.idTarif = new SelectList(db.Tarif, "idTarif", "libelle");
            return View();
        }

        // POST: Emplacements/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codeEmplacement,capaciteMob,terrasseCouv,idTarif")] Emplacement emplacement)
        {
            if (ModelState.IsValid)
            {
                db.Emplacement.Add(emplacement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idTarif = new SelectList(db.Tarif, "idTarif", "libelle", emplacement.idTarif);
            return View(emplacement);
        }

        // GET: Emplacements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emplacement emplacement = db.Emplacement.Find(id);
            if (emplacement == null)
            {
                return HttpNotFound();
            }
            ViewBag.idTarif = new SelectList(db.Tarif, "idTarif", "libelle", emplacement.idTarif);
            return View(emplacement);
        }

        // POST: Emplacements/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codeEmplacement,capaciteMob,terrasseCouv,idTarif")] Emplacement emplacement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emplacement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idTarif = new SelectList(db.Tarif, "idTarif", "libelle", emplacement.idTarif);
            return View(emplacement);
        }

        // GET: Emplacements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emplacement emplacement = db.Emplacement.Find(id);
            if (emplacement == null)
            {
                return HttpNotFound();
            }
            return View(emplacement);
        }

        // POST: Emplacements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emplacement emplacement = db.Emplacement.Find(id);
            db.Emplacement.Remove(emplacement);
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
