using Microsoft.AspNetCore.Http;
using Offers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.ViewModels
{
    public class BuildAnOffer
    {

        public int Id { get; set; }




        public string FileName { get; set; }
        public IFormFile AdditionalFileName { get; set; }
        public bool OpenClose { get; set; }


        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public DateTime? LastUpdate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Fkeys
        public int CompanyId { get; set; }
        public int ΟfferUserId { get; set; }
        public Company Company { get; set; }
        public ΟfferUser ΟfferUser { get; set; }
        public int YearId { get; set; }
        public Year Year { get; set; }
        public int DromologioId { get; set; }
        public Dromologio Dromologio { get; set; }


    }





}

