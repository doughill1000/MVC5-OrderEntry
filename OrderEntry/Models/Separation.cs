//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderEntry.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Separation
    {
        public System.Guid SeparationId { get; set; }
        public string DesignNum { get; set; }
        public string DesignName { get; set; }
        public string CustDesignNum { get; set; }
        public string CustDesignName { get; set; }
        public string Owner { get; set; }
        public string SoldTo { get; set; }
        public string Separator { get; set; }
        public bool Disk { get; set; }
        public bool Swatch { get; set; }
        public bool Artwork { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public bool ToBeEngraved { get; set; }
        public Nullable<System.DateTime> SentToSeparation { get; set; }
        public Nullable<System.DateTime> SentToEngraveDept { get; set; }
        public string DesignDescription { get; set; }
        public string DesignCoordinates { get; set; }
        public bool WebUpload { get; set; }
        public string Comments { get; set; }
        public Nullable<decimal> SeparationCharges { get; set; }
        public string SeparationChargesDescription { get; set; }

        public Separation()
        {
            Disk = false;
            Swatch = false;
            Artwork = false;
            ToBeEngraved = false;
            WebUpload = false;
        }
    }
}
