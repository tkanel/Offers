using Offers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prosfores.Models
{
    public class Offer
    {
        public int Id { get; set; }

        

        [Required]
        public string FileName { get; set; }
        public bool OpenClose { get; set; }
        

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public DateTime? LastUpdate { get; set; }

        //Fkeys
        public int CompanyId { get; set; }
        public int offerUserId { get; set; }
        public Company Company { get; set; }
        public offerUser offerUser { get; set; }



    }
}
