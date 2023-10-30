using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Duurzame_Consumentkeuzes.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<EnergyLabel> EnergyLabels { get; set; }
        public DbSet<Image> Images { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Administrators",
                NormalizedName = "ADMINISTRATORS",
                Id = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5",
            });

            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    Id = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                },

                new Customer
                {
                    UserName = "bruce@example.com",
                    NormalizedUserName = "BRUCE@EXAMPLE.COM",
                    Email = "bruce@example.com",
                    NormalizedEmail = "BRUCE@EXAMPLE.COM",
                    Budget = 450,
                },

                new Customer
                {
                    UserName = "gijs@example.com",
                    NormalizedUserName = "GIJS@EXAMPLE.COM",
                    Email = "gijs@example.com",
                    NormalizedEmail = "GIJS@EXAMPLE.COM",
                    Budget = 500,
                },

                new Customer
                {
                    UserName = "rick@example.com",
                    NormalizedUserName = "RICK@EXAMPLE.COM",
                    Email = "rick@example.com",
                    NormalizedEmail = "RICK@EXAMPLE.COM",
                    Budget = 650,
                },
            };

            PasswordHasher<Customer> ph = new PasswordHasher<Customer>();
            foreach (var c in customers)
            {
                c.PasswordHash = ph.HashPassword(c, "Pa$$w0rd");
                modelBuilder.Entity<Customer>().HasData(c);
            }

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5",
                UserId = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
            });

        }
    }
}