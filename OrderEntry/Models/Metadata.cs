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
        [DisplayFormat(DataFormatString = "{0:MM/dd}")]
        public Nullable<System.DateTime> ODATE { get; set; }

        [Required(ErrorMessage="Required")]
        [DisplayName("Ship Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd}")]
        public Nullable<System.DateTime> SDATE { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        [MaxLength(30, ErrorMessage = "Maximum length is 30 characters.")]
        public string CUSTNA { get; set; }

        [Required]
        [DisplayName("Customer Order#")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public string CORDNO { get; set; }

        [Required]
        [DisplayName("Sales Rep")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string SNAME1 { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25 characters.")]
        public string CSNAME { get; set; } 

        [Required]
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

        [Required]
        [DisplayName("Country")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string CSCOUNTRY { get; set; }

        [DisplayName("Attn")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20 characters.")]
        public string CSATTN { get; set; }

        [DisplayName("Special Instructions")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "Maximum length is 500 characters.")]
        public string REMARKS { get; set; }
    }
}