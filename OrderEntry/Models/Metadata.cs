using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderEntry.Models
{
    public class OrderMetadata
    {
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}",ApplyFormatInEditMode=true)]
        public Nullable<System.DateTime> ODATE { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Customer #")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid Customer Number")]
        public float CUSTNO { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Customer Name")]     
        [MaxLength(30, ErrorMessage = "Maximum length is 30 characters.")]
        public string CUSTNA { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Customer Order #")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Order Number")]
        public string CORDNO { get; set; }

        [DisplayName("Status")]
        public string OHSTATUS { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Sales Rep")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string SNAME1 { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Sales Rep #")]
        [MaxLength(20, ErrorMessage = "Maximum length is 3 characters.")]
        public string SPERSON1 { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Customer Name")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        public string CSNAME { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Address 1")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        public string CSADR1 { get; set; }

        [DisplayName("Address 2")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        public string CSADR2 { get; set; }

        [DisplayName("Address 3")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        public string CSADR3 { get; set; }

        [DisplayName("City")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string CSCITY { get; set; }

        [DisplayName("State")]
        [MaxLength(2, ErrorMessage = "Maximum length is 2 characters.")]
        public string CSST { get; set; }

        [DisplayName("Zip Code")]
        [MaxLength(5, ErrorMessage = "Maximum length is 5 characters.")]
        public string CSZIP { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Country")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string CSCOUNTRY { get; set; }

        [DisplayName("Attn")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string CSATTN { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Ship Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> SDATE { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Shipping Method")]
        [MaxLength(35, ErrorMessage = "Maximum length is 35 characters.")]
        public Nullable<System.DateTime> SHIP_VIA { get; set; }

        [DisplayName("Special Instructions")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "Maximum length is 500 characters.")]
        public string REMARKS { get; set; }
    }

    public class SeparationMetaData
    {
        [MaxLength(10, ErrorMessage = "Maximum length is 10 characters.")]
        [DisplayName("Design Number")]
        [Required(ErrorMessage="Required")]
        public string DesignNum { get; set; }

        [MaxLength(75, ErrorMessage = "Maximum length is 75 characters.")]
        [DisplayName("Design Name")]
        [Required(ErrorMessage = "Required")]
        public string DesignName { get; set; }

        [MaxLength(15, ErrorMessage = "Maximum length is 15 characters.")]
        [DisplayName("Customer Design Number")]
        [Required(ErrorMessage = "Required")]
        public string CustDesignNum { get; set; }

        [MaxLength(75, ErrorMessage = "Maximum length is 75 characters.")]
        [DisplayName("Customer Design Name")]
        [Required(ErrorMessage = "Required")]
        public string CustDesignName { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        [DisplayName("Owner")]
        [Required(ErrorMessage = "Required")]
        public string Owner { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        [DisplayName("Sold To")]
        public string SoldTo { get; set; }

        [MaxLength(25, ErrorMessage="Maximum Length is 25 characters.")]
        public string Separator { get; set; }

        public Nullable<bool> Disk { get; set; }

        public Nullable<bool> Swatch { get; set; }

        public Nullable<bool> Artwork { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Date Received")]
        [Required(ErrorMessage = "Required")]
        public Nullable<System.DateTime> DateReceived { get; set; }

        [DisplayName("To Be Engraved")]
        [Required(ErrorMessage = "Required")]
        public Nullable<bool> ToBeEngraved { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Sent To Separation")]
        public Nullable<System.DateTime> SentToSeparation { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Sent to Engraving Dept")]
        public Nullable<System.DateTime> SentToEngraveDept { get; set; }

        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        [DisplayName("Design Description")]
        public string DesignDescription { get; set; }

        [MaxLength(15, ErrorMessage = "Maximum length is 15 characters.")]
        [DisplayName("Design Coordinates")]
        public string DesignCoordinates { get; set; }

        [DisplayName("Web Upload")]
        public Nullable<bool> WebUpload { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum length is 100 characters.")]
        public string Comments { get; set; }

        [DisplayName("Separation Charges")]
        public Nullable<decimal> SeparationCharges { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum length is 50 characters.")]
        [DisplayName("Separation Charges Description")]
        public string SeparationChargesDescription { get; set; }
    }
}