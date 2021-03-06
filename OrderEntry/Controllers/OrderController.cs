﻿using OrderEntry.Models;
using OrderEntry.Models.Orders;
using OrderEntry.Models.Repository;
using OrderEntry.Models.Utility;
using System;
using System.Net;
using System.Web.Mvc;
using System.Globalization;

namespace OrderEntry.Controllers
{
    public class OrderController : Controller
    {
        private IOrderEntryRepository orderRepository;
        private ITransprintRepository transprintRepository;

        public OrderController()
            :this(new OrderEntryRepository(), new TransprintRepository())
        {
        }

        public OrderController(IOrderEntryRepository orderRepository, ITransprintRepository transprintRepository)
        {
            this.orderRepository = orderRepository;
            this.transprintRepository = transprintRepository;
        }

        // GET: /Order/
        public ActionResult Index()
        {
            return View(orderRepository.GetAll());
        }

        // GET: /Order/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = orderRepository.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: /Order/Create
        public ActionResult Create()
        {
            OrderViewModel model = new OrderViewModel();

            model.Customers = transprintRepository.GetCustomers();

            model.SalesPersons = orderRepository.GetSalesPersons();

            return View(model);
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
                orderRepository.Create(order);
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: /Order/Edit/5
        public ActionResult Edit(Guid? id)
        {
            OrderViewModel model = new OrderViewModel();

            model.Customers = transprintRepository.GetCustomers();

            model.SalesPersons = orderRepository.GetSalesPersons();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = orderRepository.GetById(id);
            if (order == null)
            {
                return HttpNotFound();
            }

            model.Order = order;

            return View(model);
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
                orderRepository.Update(order);
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
            Order order = orderRepository.GetById(id);
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
            orderRepository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                orderRepository.Dispose();
            }
            base.Dispose(disposing);
        }

        //[HttpPost]
        /// <summary>
        /// Populates the address fields based on the customer number selected in dropdown
        /// </summary>
        /// <param name="custNum"></param>
        /// <returns></returns>
        public JsonResult PopulateAddress(double custNum)
        {
            var customer = transprintRepository.GetByCustNum(custNum);

            return new JsonNetResult(customer, JsonRequestBehavior.DenyGet);            
        }

        //[HttpPost]
        /// <summary>
        /// Retrieves list of shipping methods from database
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public JsonResult GetShippingMethods(String text)
        {
            var shippingMethods = orderRepository.GetAllActiveShippingMethods(text);

            return new JsonNetResult(shippingMethods, JsonRequestBehavior.DenyGet);
        }
    }
}
