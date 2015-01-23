using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderEntry.Models.TransprintTables
{
    public class TransprintViewModel
    {
        public List<Customer> Customers { get; set; }

        public List<Country> Countries { get; set; }
    }
}