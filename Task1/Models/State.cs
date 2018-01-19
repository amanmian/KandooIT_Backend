using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        public string StateName { get; set; }

        public List<City> City { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public Country Country { get; set; }

    }
}
