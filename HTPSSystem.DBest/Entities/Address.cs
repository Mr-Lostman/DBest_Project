using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HTPSSystem.DBest.Entities
{
    [Table("Addresses")]
    class Address
    {
        [Key]
        public int? AddressID { get; set; }

        [Required(ErrorMessage ="Number is required")]
        [StringLength(30, ErrorMessage ="Number is limited to 30 characters")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [StringLength(30, ErrorMessage = "Street is limited to 30 characters")]
        public string Street { get; set; }

        [StringLength(30, ErrorMessage = "Community is limited to 30 characters")]
        public string Community { get; set; }

        [StringLength(5, ErrorMessage = "Unit is limited to 5 characters")]
        public string Unit { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(30, ErrorMessage = "City is limited to 30 characters")]
        public string City { get; set; }

        [StringLength(20, ErrorMessage = "ProvinceState is limited to 20 characters")]
        public string ProvinceState { get; set; }

        [StringLength(12, ErrorMessage = "PostalCodeZip is limited to 12 characters")]
        public string PostalCodeZip { get; set; }

        [StringLength(2, ErrorMessage = "CountryCode is limited to 2 characters")]
        public string CountryCode { get; set; }

        public int? LandLordID { get; set; }

        [NotMapped]
        public string FullAddress
        {
            get { return Number + " " + Street; }
        }
    }
}
