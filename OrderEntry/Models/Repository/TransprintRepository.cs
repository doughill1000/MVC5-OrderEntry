﻿using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderEntry.Models.Utility;

namespace OrderEntry.Models.Repository
{
    public class TransprintRepository : ITransprintRepository
    {

        private TransprintEntities db;

        /// <summary>
        /// Constructs a new order repository
        /// </summary>
        public TransprintRepository()
        {
            db = new TransprintEntities();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        /// <summary>
        /// Gets a list of all Customers for the dropdown on the Create View for Orders.
        /// 999 indicates a deactivated customer, and customers above 4000 are not used
        /// </summary>
        /// <returns>A list of customers</returns>
        public List<SelectListItem> GetCustomers()
        {
            var customers = db.Customers
                .ToList()
                .Where(c => c.SPERSON1 != "999" && c.CUSTNO < 4000)
                .Select(c => new SelectListItem
            {
                Value = c.CUSTNO.ToString().Trim(),
                Text = c.CUSTNA.ConvertToTitleCase()
                
            }).OrderBy(c => c.Text).ToList();

            return customers;

            throw new NotImplementedException();
        }

        public List<SelectListItem> GetCountries()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a customer by the Customer Number
        /// </summary>
        /// <param name="custnum">The customer number</param>
        /// <returns>A customer</returns>
        public Customer GetByCustNum(double custnum)
        {
            Customer customer = db.Customers.Where(c => c.CUSTNO == custnum).First();

            return customer;
        }
    }
}