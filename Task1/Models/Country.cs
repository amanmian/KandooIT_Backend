using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        public int CountryName { get; set; }

        public List<State> State { get; set; }
    }
}
