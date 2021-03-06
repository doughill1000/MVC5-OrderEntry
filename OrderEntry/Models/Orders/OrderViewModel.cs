﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace OrderEntry.Models.Orders
{
    public class OrderViewModel
    {
        public Order Order { get; set; }

        public List<Order> Orders { get; set; }

        public List<SelectListItem> Customers { get; set; }

        public List<SelectListItem> SalesPersons { get; set; }

        public ShippingMethod ShippingMethod { get; set; }
    }
}