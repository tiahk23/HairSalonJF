using HairSalonJF.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HairSalonJF.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ClientIntakeForm> ClientIntakeForms { get; set; }
        //public object ClientIntakeForms { get; internal set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientIntakeForm>().HasKey(et => new { et.Id });

            base.OnModelCreating(modelBuilder);
        }
    }
}
