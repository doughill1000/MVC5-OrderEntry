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

namespace OrderEntry.Controllers
{
    public class OrderController : Controller
    {
        private IOrderEntryRepository Repository;

        public OrderController()
            :this(new OrderEntryRepository())
        {
        }

        public OrderController(IOrderEntryRepository Repository)
        {
            this.Repository = Repository;
        }

        // GET: /Order/
        public ActionResult Index()
        {
            return View(Repository.GetAll());
        }

        // GET: /Order/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = Repository.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: /Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,ODATE,SDATE,CUSTNO,CUSTNA,CORDNO,OSTATUS,SPERSON1,SNAME1,SPERSON2,SNAME2,CBADR1,CBADR2,CBADR3,CBCITY,CBST,CBZIP,CNTRYNO,COUNTRY,CBPHONE,CSNAME,CSADR1,CSADR2,CSADR3,CSCITY,CSST,CSZIP,CSCOUNTRY,CSATTN,XPORT,XRATE,TERMNO,TERMS,CURRENCY,LABPRT,OCONPRT,OHSTATUS,REMARKS,DELIVERY_TERMS,SHIP_VIA,MARKET,OFFICE_REMARKS,NOT_BEFORE,AUTHORIZATION")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.ID = Guid.NewGuid();
                Repository.Create(order);
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: /Order/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = Repository.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: /Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,ODATE,SDATE,CUSTNO,CUSTNA,CORDNO,OSTATUS,SPERSON1,SNAME1,SPERSON2,SNAME2,CBADR1,CBADR2,CBADR3,CBCITY,CBST,CBZIP,CNTRYNO,COUNTRY,CBPHONE,CSNAME,CSADR1,CSADR2,CSADR3,CSCITY,CSST,CSZIP,CSCOUNTRY,CSATTN,XPORT,XRATE,TERMNO,TERMS,CURRENCY,LABPRT,OCONPRT,OHSTATUS,REMARKS,DELIVERY_TERMS,SHIP_VIA,MARKET,OFFICE_REMARKS,NOT_BEFORE,AUTHORIZATION")] Order order)
        {
            if (ModelState.IsValid)
            {
                Repository.Edit(order);
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: /Order/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = Repository.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: /Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Repository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Repository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
