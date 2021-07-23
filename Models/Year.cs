using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Year
    {

        public int Id { get; set; }

        [Required]
        public string YearSelected { get; set; }

    }
}
