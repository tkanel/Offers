using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class FileName
    {
        public int Id { get; set; }

        [StringLength(500, ErrorMessage = "must be below 500 characters")]
        public string  Filename { get; set; }

        public bool isInserted { get; set; }
    }
}
