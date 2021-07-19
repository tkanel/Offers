using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class offerUser
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }


        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
