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
    
    public partial class Order
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> ODATE { get; set; }
        public Nullable<System.DateTime> SDATE { get; set; }
        public Nullable<double> CUSTNO { get; set; }
        public string CUSTNA { get; set; }
        public string CORDNO { get; set; }
        public string OSTATUS { get; set; }
        public string SPERSON1 { get; set; }
        public string SNAME1 { get; set; }
        public string SPERSON2 { get; set; }
        public string SNAME2 { get; set; }
        public string CBADR1 { get; set; }
        public string CBADR2 { get; set; }
        public string CBADR3 { get; set; }
        public string CBCITY { get; set; }
        public string CBST { get; set; }
        public string CBZIP { get; set; }
        public string CNTRYNO { get; set; }
        public string COUNTRY { get; set; }
        public string CBPHONE { get; set; }
        public string CSNAME { get; set; }
        public string CSADR1 { get; set; }
        public string CSADR2 { get; set; }
        public string CSADR3 { get; set; }
        public string CSCITY { get; set; }
        public string CSST { get; set; }
        public string CSZIP { get; set; }
        public string CSCOUNTRY { get; set; }
        public string CSATTN { get; set; }
        public string XPORT { get; set; }
        public Nullable<double> XRATE { get; set; }
        public string TERMNO { get; set; }
        public string TERMS { get; set; }
        public string CURRENCY { get; set; }
        public string LABPRT { get; set; }
        public string OCONPRT { get; set; }
        public string OHSTATUS { get; set; }
        public string REMARKS { get; set; }
        public string DELIVERY_TERMS { get; set; }
        public string SHIP_VIA { get; set; }
        public string MARKET { get; set; }
        public string OFFICE_REMARKS { get; set; }
        public Nullable<System.DateTime> NOT_BEFORE { get; set; }
        public string AUTHORIZATION { get; set; }
    }
}
