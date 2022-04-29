using HairSalonJF.Controllers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HairSalonJF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ClientIntakeFormController> Appointments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientIntakeFormController>().HasKey(et => new { et.Id });

            base.OnModelCreating(modelBuilder);
        }
    }
}
