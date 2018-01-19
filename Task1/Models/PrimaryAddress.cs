using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class PrimaryAddress
    {
        [Key]
        public int PrimaryAddressId { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Address2 { get; set; }

        [ForeignKey("CityId")]
        public int CityId { get; set; }

        [Required]
        public long Zipcode { get; set; }
    }
}
