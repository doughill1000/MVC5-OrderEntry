using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OrderEntry.Models;
using OrderEntry.Models.Repository;
using OrderEntry.Models.Orders;

namespace OrderEntry.Controllers
{
    public class SeparationController : Controller
    {
        private ISeparationRepository separationRepository;
        private ITransprintRepository transprintRepository;

        public SeparationController()
            : this(new SeparationRepository(), new TransprintRepository())
        { }

        public SeparationController(ISeparationRepository separationRepository, ITransprintRepository transprintRepository)
        {
            this.separationRepository = separationRepository;
            this.transprintRepository = transprintRepository;
        }
        // GET: Separation
        public ActionResult Index()
        {
            return View(separationRepository.GetAll());
        }

        // GET: Separation/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Separation separation = separationRepository.GetById(id);
            if (separation == null)
            {
                return HttpNotFound();
            }
            return View(separation);
        }

        // GET: Separation/Create
        public ActionResult Create()
        {
            SeparationViewModel model = new SeparationViewModel();

            return View(model);
        }

        // POST: Separation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SeparationId,DesignNum,DesignName,CustDesignNum,CustDesignName,Owner,SoldTo,Disk,Swatch,Artwork,DateReceived,ToBeEngraved,SentToSeparation,SentToEngraveDept,DesignDescription,DesignCoordinates,WebUpload,Comments,SeparationCharges,SeparationChargesDescription")] Separation separation)
        {
            if (ModelState.IsValid)
            {
                separation.SeparationId = Guid.NewGuid();
                separationRepository.Create(separation);
                return RedirectToAction("Index");
                
            }

            return View(separation);
        }

        // GET: Separation/Edit/5
        public ActionResult Edit(Guid? id)
        {
            SeparationViewModel model = new SeparationViewModel();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Separation separation = separationRepository.GetById(id);
            if (separation == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Separation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SeparationId,DesignNum,DesignName,CustDesignNum,CustDesignName,Owner,SoldTo,Disk,Swatch,Artwork,DateReceived,ToBeEngraved,SentToSeparation,SentToEngraveDept,DesignDescription,DesignCoordinates,WebUpload,Comments,SeparationCharges,SeparationChargesDescription")] Separation separation)
        {
            if (ModelState.IsValid)
            {
                separationRepository.Update(separation);
                return RedirectToAction("Index");
            }
            return View(separation);
        }

        // GET: Separation/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Separation separation = separationRepository.GetById(id);
            if (separation == null)
            {
                return HttpNotFound();
            }
            return View(separation);
        }

        // POST: Separation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            separationRepository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                separationRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
