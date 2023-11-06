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
                    ImagePath = "/images/devices/wasmachines/haier-hw90-b14959u1.png",
                },

                new Device
                {
                    Id = 2,
                    Name = "Samsung WW90T534AAW",
                    Brand = "Samsung",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 649,
                    ImagePath = "/images/devices/wasmachines/samsung-ww90t534aaw.png"
                },

                new Device
                {
                    Id = 3,
                    Name = "Bosch Serie | 4 WGG04409NL",
                    Brand = "Bosch",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 699,
                    ImagePath = "/images/devices/wasmachines/bosch-serie-4-wgg04409nl.png"
                },

                new Device
                {
                    Id = 4,
                    Name = "AEG LR6BERLIN",
                    Brand = "AEG",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 649,
                    ImagePath = "/images/devices/wasmachines/aeg-lr6berlin.png"
                },

                new Device
                {
                    Id = 5,
                    Name = "Siemens IQ700 WG56B2A5NL",
                    Brand = "Siemens",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 1099,
                    ImagePath = "/images/devices/wasmachines/siemens-iq700-wg56b2a5nl.png"
                },

                new Device
                {
                    Id = 6,
                    Name = "Bosch Serie | 6 WAU28P95NL",
                    Brand = "Bosch",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 875,
                    ImagePath = "/images/devices/wasmachines/bosch-serie-6-wau28p95nl.png"
                },

                new Device
                {
                    Id = 7,
                    Name = "Siemens IQ300 WM14N297NL",
                    Brand = "Siemens",
                    Type = "Wasmachine",
                    EnergyLabelId = 1,
                    Price = 779,
                    ImagePath = "/images/devices/wasmachines/siemens-iq300-wm14n297nl.png"
                },
                
                new Device
                {
                    Id = 8,
                    Name = "Beko WTV8712BLW1",
                    Brand = "Beko",
                    Type = "Wasmachine",
                    EnergyLabelId = 3,
                    Price = 399,
                    ImagePath = "/images/devices/wasmachines/beko-wtv8712blw1.png"
                },

                new Device
                {
                    Id = 9,
                    Name = "Whirlpool FFB 9458 WV BE",
                    Brand = "Whirlpool",
                    Type = "Wasmachine",
                    EnergyLabelId = 2,
                    Price = 403,
                    ImagePath = "/images/devices/wasmachines/whirlpool-ffb-9458-wv-be.png"
                },

                new Device
                {
                    Id = 10,
                    Name = "Beko WTV8711BC1",
                    Brand = "Beko",
                    Type = "Wasmachine",
                    EnergyLabelId = 3,
                    Price = 429,
                    ImagePath = "/images/devices/wasmachines/beko-wtv8711bc1.png"
                },

                new Device
                {
                    Id = 11,
                    Name = "Bosch Serie | 6 KGN39AIAT",
                    Brand = "Bosch",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 1249,
                    ImagePath = "/images/devices/koelkasten/bosch-serie-6-kgn39aiat.png"
                },

                new Device
                {
                    Id = 12,
                    Name = "Siemens KG39E8XBA",
                    Brand = "Siemens",
                    Type = "Koelkast",
                    EnergyLabelId = 2,
                    Price = 839,
                    ImagePath = "/images/devices/koelkasten/siemens-kg39e8xba.png"
                },

                new Device
                {
                    Id = 13,
                    Name = "LG GBP62PZNBC",
                    Brand = "LG",
                    Type = "Koelkast",
                    EnergyLabelId = 2,
                    Price = 1009,
                    ImagePath = "/images/devices/koelkasten/lg-gbp62pznbc.png"
                },

                new Device
                {
                    Id = 14,
                    Name = "LG GBB92STBAP",
                    Brand = "LG",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 1378,
                    ImagePath = "/images/devices/koelkasten/lg-gbb92stbap.png"
                },

                new Device
                {
                    Id = 15,
                    Name = "Siemens IQ500 KG39NAIAT",
                    Brand = "Siemens",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 1399,
                    ImagePath = "/images/devices/koelkasten/siemens-iq500-kg39naiat.png"
                },

                new Device
                {
                    Id = 16,
                    Name = "Etna KKS4088",
                    Brand = "Etna",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 348,
                    ImagePath = "/images/devices/koelkasten/etna-kks4088.png"
                },

                new Device
                {
                    Id = 17,
                    Name = "Siemens KU15RAFF0",
                    Brand = "Siemens",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 576,
                    ImagePath = "/images/devices/koelkasten/siemens-ku15raff0.png"
                },

                new Device
                {
                    Id = 18,
                    Name = "Siemens KI51FADE0",
                    Brand = "Siemens",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 893.36M,
                    ImagePath = "/images/devices/koelkasten/siemens-ki51fade0.png"
                },

                new Device
                {
                    Id = 19,
                    Name = "Etna KKD4122 ",
                    Brand = "Etna",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 499,
                    ImagePath = "/images/devices/koelkasten/etna-kkd4122.png"
                },

                new Device
                {
                    Id = 20,
                    Name = "Bosch KSV33VLEP",
                    Brand = "Bosch",
                    Type = "Koelkast",
                    EnergyLabelId = 1,
                    Price = 719,
                    ImagePath = "/images/devices/koelkasten/bosch-ksv33vlep.png"
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