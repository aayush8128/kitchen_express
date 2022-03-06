using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using kitchen_express.Models;

namespace kitchen_express.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<kitchen_express.Models.Category> Category { get; set; }
        public DbSet<kitchen_express.Models.Product> Product { get; set; }
    }
}
