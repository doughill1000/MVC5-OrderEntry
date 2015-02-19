using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OrderEntry.Models;

namespace OrderEntry.Controllers
{
    public class SeparationsController : Controller
    {
        private OrderEntryEntities db = new OrderEntryEntities();

        // GET: Separations
        public ActionResult Index()
        {
            return View(db.Separations.ToList());
        }

        // GET: Separations/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Separation separation = db.Separations.Find(id);
            if (separation == null)
            {
                return HttpNotFound();
            }
            return View(separation);
        }

        // GET: Separations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Separations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DesignId,DesignNum,DesignName,CustDesignNum,CustDesignName,Owner,SoldTo,Disk,Swatch,Artwork,DateReceived,ToBeEngraved,SentToSeparation,SentToEngraveDept,DesignDescription,DesignCoordinates,WebUpload,Comments,SeparationCharges,SeparationChargesDescription")] Separation separation)
        {
            if (ModelState.IsValid)
            {
                separation.DesignId = Guid.NewGuid();
                db.Separations.Add(separation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(separation);
        }

        // GET: Separations/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Separation separation = db.Separations.Find(id);
            if (separation == null)
            {
                return HttpNotFound();
            }
            return View(separation);
        }

        // POST: Separations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DesignId,DesignNum,DesignName,CustDesignNum,CustDesignName,Owner,SoldTo,Disk,Swatch,Artwork,DateReceived,ToBeEngraved,SentToSeparation,SentToEngraveDept,DesignDescription,DesignCoordinates,WebUpload,Comments,SeparationCharges,SeparationChargesDescription")] Separation separation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(separation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(separation);
        }

        // GET: Separations/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Separation separation = db.Separations.Find(id);
            if (separation == null)
            {
                return HttpNotFound();
            }
            return View(separation);
        }

        // POST: Separations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Separation separation = db.Separations.Find(id);
            db.Separations.Remove(separation);
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
