using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Dromologio
    {

        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}
