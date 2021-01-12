using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SPR.Models;

namespace SPR.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<SPR.Models.ApplicationUser> ApplicationUser { get; set; }
        public DbSet<SPR.Models.UserProfile> UserProfile { get; set; }
        public DbSet<SPR.Models.CustomerType> CustomerType { get; set; }
        public DbSet<SPR.Models.AirTreatment> AirTreatment { get; set; }
        public DbSet<SPR.Models.AssignedRoles> AssignedRoles { get; set; }
        public DbSet<SPR.Models.BoughtoutInstrument> BoughtoutInstrument { get; set; }
        public DbSet<SPR.Models.BusinessDivision> BusinessDivision { get; set; }
        public DbSet<SPR.Models.Competition> Competition { get; set; }
        public DbSet<SPR.Models.Facility> Facility { get; set; }
        public DbSet<SPR.Models.Industry> Industry { get; set; }
        public DbSet<SPR.Models.Channel> Channel { get; set; }
        public DbSet<SPR.Models.LRBU> LRBU { get; set; }
        public DbSet<SPR.Models.OilFree> OilFree { get; set; }
        public DbSet<SPR.Models.PricingStatus> PricingStatus { get; set; }
        public DbSet<SPR.Models.Region> Region { get; set; }
        public DbSet<SPR.Models.Registration> Registration { get; set; }
        public DbSet<SPR.Models.roles> roles { get; set; }
        public DbSet<SPR.Models.Rotary> Rotary { get; set; }
        public DbSet<SPR.Models.Smallair> Smallair { get; set; }
        public DbSet<SPR.Models.NumberSequence> NumberSequence { get; set; }
    }
}
