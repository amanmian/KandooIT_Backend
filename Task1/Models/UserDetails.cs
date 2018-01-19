using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }

        [ForeignKey("UserTypes")]
        public int UserTypeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public long SSN { get; set; }

        [Required]
        public long TaxId { get; set; }

        [ForeignKey("PrimaryAddress"),Required]
        public int PrimaryAddressId { get; set; }

        [ForeignKey("SecondaryAddress"),Required]
        public int SecondaryAddressId { get; set; }

    }
}
