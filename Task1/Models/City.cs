using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

      
        [Required]
        public string CityName { get; set; }

        [Required]
        [ForeignKey("State")]
        public int StateId { get; set; }

        public State State { get; set; }

    }
}
