using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Company
    {

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string CompanyName { get; set; }


        [StringLength(20)]
        public string AFM { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

      
      
    }
}


