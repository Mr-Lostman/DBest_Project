using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HTPSSystem.DBest.Entities
{
    [Table("StudentAddresses")]
    class StudentAddress
    {
        [Key]
        public int? StudentAddressID { get; set; }

        
        public int? StudentID { get; set; }

        public int? AddressID { get; set; }

        [Required(ErrorMessage = "Since Date is required")]
        public string SinceDate { get; set; }

        public string UntilDate { get; set; }

        public int? FowardingAddressID { get; set; }

        [Required(ErrorMessage = "Is Primary Residence is required")]
        public bool IsPrimaryResidence { get; set; }
    }
}
