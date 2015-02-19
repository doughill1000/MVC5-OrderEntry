using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderEntry.Models.Orders
{
    public class SeparationViewModel
    {
        public Separation Separation { get; set; }

        public List<Separation> Separations { get; set; }
    }
}