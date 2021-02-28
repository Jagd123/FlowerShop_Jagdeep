using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FlowerShop_Jagdeep.BussLayer;

namespace FlowerShop_Jagdeep.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FlowerShop_Jagdeep.BussLayer.Flower> Flower { get; set; }
        public DbSet<FlowerShop_Jagdeep.BussLayer.Employee> Employee { get; set; }
        public DbSet<FlowerShop_Jagdeep.BussLayer.Customer> Customer { get; set; }
    }
}
