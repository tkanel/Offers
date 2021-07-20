using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Offers.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace Offers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<ΟfferUser> OfferUsers { get; set; }
        public DbSet<Year> Years { get; set; }


    }
}
