using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HTPSSystem.DBest.Entities
{
    [Table("Students")]
    class Student
    {
        [Key]
        public int StudentNumber { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20, ErrorMessage = "First Name is limited to 20 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, ErrorMessage = "Last Name is limited to 20 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Display Name is required")]
        [StringLength(20, ErrorMessage = "Display Name is limited to 20 characters")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Country Code is required")]
        [StringLength(2, ErrorMessage = "Country Code is limited to 2 characters")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(1, ErrorMessage = "Gender is limited to 1 character")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        public string BrithDate { get; set; }
    }
}
