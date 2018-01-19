using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class SecondaryAddress
    {
        [Key]
        public int SecondaryAddressId { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Address2 { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        [Required]
        public long Zipcode { get; set; }
    }
}
