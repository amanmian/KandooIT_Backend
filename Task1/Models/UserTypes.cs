using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class UserTypes
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required]
        public string UserTypeName { get; set; }

    }
}
