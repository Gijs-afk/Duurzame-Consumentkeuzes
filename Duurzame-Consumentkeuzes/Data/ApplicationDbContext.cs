using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Security.Policy;

namespace Duurzame_Consumentkeuzes.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<EnergyLabel> EnergyLabels { get; set; }
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

            List<Device> devices = new List<Device>
            {
                new Device
                {
                    Id = 1,
                    Name = "Haier HW90 B14959U1",
                    Brand = "Haier",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 599,
                    ImagePath = "/images/devices/haier-hw90-b14959u1.png",
                },

                new Device
                {
                    Id = 2,
                    Name = "Samsung WW90T534AAW",
                    Brand = "Samsung",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 649,
                    ImagePath = "/images/devices/samsung-ww90t534aaw.png"
                },

                new Device
                {
                    Id = 3,
                    Name = "Bosch Serie | 4 WGG04409NL",
                    Brand = "Bosch",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 699,
                    ImagePath = "/images/devices/bosch-serie-4-wgg04409nl.png"
                },
            };
            foreach (var device in devices)
            {
                modelBuilder.Entity<Device>().HasData(device);
            }

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

            List<EnergyLabel> energyLabels = new List<EnergyLabel>
            {
                new EnergyLabel
                {
                    Id = 1,
                    EfficiencyClass = "A",
                    ImagePath = "/images/energylabels/energylabela.png",
                },

                new EnergyLabel
                {
                    Id = 2,
                    EfficiencyClass = "B",
                    ImagePath = "/images/energylabels/energylabelb.png",
                },

                new EnergyLabel
                {
                    Id = 3,
                    EfficiencyClass = "C",
                    ImagePath = "/images/energylabels/energylabelc.png",
                },

                new EnergyLabel
                {
                    Id = 4,
                    EfficiencyClass = "D",
                    ImagePath = "/images/energylabels/energylabeld.png",
                },

                new EnergyLabel
                {
                    Id = 5,
                    EfficiencyClass = "E",
                    ImagePath = "/images/energylabels/energylabele.png",
                },

                new EnergyLabel
                {
                    Id = 6,
                    EfficiencyClass = "F",
                    ImagePath = "/images/energylabels/energylabelf.png",
                },

                new EnergyLabel
                {
                    Id = 7,
                    EfficiencyClass = "G",
                    ImagePath = "/images/energylabels/energylabelg.png",
                },

            };

            foreach (EnergyLabel e in energyLabels)
            {
                modelBuilder.Entity<EnergyLabel>().HasData(e);
            }
        }
    }
}