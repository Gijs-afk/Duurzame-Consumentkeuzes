﻿// <auto-generated />
using System;
using Duurzame_Consumentkeuzes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231101085725_EnergyLabelImagePath")]
    partial class EnergyLabelImagePath
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerDevice", b =>
                {
                    b.Property<string>("CustomersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DevicesId")
                        .HasColumnType("int");

                    b.HasKey("CustomersId", "DevicesId");

                    b.HasIndex("DevicesId");

                    b.ToTable("CustomerDevice");
                });

            modelBuilder.Entity("CustomerEnergyLabel", b =>
                {
                    b.Property<string>("CustomersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EnergyLabelsId")
                        .HasColumnType("int");

                    b.HasKey("CustomersId", "EnergyLabelsId");

                    b.HasIndex("EnergyLabelsId");

                    b.ToTable("CustomerEnergyLabel");
                });

            modelBuilder.Entity("Duurzame_Consumentkeuzes.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<decimal?>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c9913544-afa5-426f-9867-11a44df2c7e8",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEkeU884J+KLOQ9SdgNCZaObw/qyulCZ6w/av0lPnkLJnUvjE0yVpDiKSomgCckPVA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d85c52f3-172d-4480-856c-dc4798d3f3ad",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "2ae37372-09e5-4438-b80c-8fecee945418",
                            AccessFailedCount = 0,
                            Budget = 450m,
                            ConcurrencyStamp = "29f22ba7-aebf-44eb-85be-1aaeb6164d08",
                            Email = "bruce@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BRUCE@EXAMPLE.COM",
                            NormalizedUserName = "BRUCE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDtVTafb1RLhp9NnoFX53L3sTL9opY7DBPdpimJtnIoVWNPluC9tRmKvNgiuSDyhXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "61176701-37c1-41eb-b3b1-518c6dfde1fd",
                            TwoFactorEnabled = false,
                            UserName = "bruce@example.com"
                        },
                        new
                        {
                            Id = "35598964-1502-4a0f-a5d0-4932be9512b8",
                            AccessFailedCount = 0,
                            Budget = 500m,
                            ConcurrencyStamp = "98a1a441-4c80-4179-bf75-fe9e0d440189",
                            Email = "gijs@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GIJS@EXAMPLE.COM",
                            NormalizedUserName = "GIJS@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMEpYbrrQySgjJNqR3XvMVRteQtVEHXMndPVUXPcz8pt5a0uobgbk9O2JUr5URfRRw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1cb2812c-58b4-4c19-a7c2-99f194ab79d4",
                            TwoFactorEnabled = false,
                            UserName = "gijs@example.com"
                        },
                        new
                        {
                            Id = "2ebd9892-beb4-497d-9d38-d3624f9ed659",
                            AccessFailedCount = 0,
                            Budget = 650m,
                            ConcurrencyStamp = "bdc3b5d4-8a04-4b59-8479-50cddedc38a5",
                            Email = "rick@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RICK@EXAMPLE.COM",
                            NormalizedUserName = "RICK@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHqoZ8qOZpsozTyh0S2qlM19Lh73WnyMVVH+W7F9INeUN0/YfjAwhqjRM/Ol30CBPg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a4164e6f-dd79-4fd3-9f2c-e41e0d8d3937",
                            TwoFactorEnabled = false,
                            UserName = "rick@example.com"
                        });
                });

            modelBuilder.Entity("Duurzame_Consumentkeuzes.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BuildDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnergyLabelId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnergyLabelId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Haier",
                            EnergyLabelId = 1,
                            ImagePath = "/images/devices/haier-hw90-b14959u1.png",
                            Name = "Haier HW90 B14959U1",
                            Price = 599m,
                            Type = "Wasmachine"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Samsung",
                            EnergyLabelId = 1,
                            ImagePath = "/images/devices/samsung-ww90t534aaw.png",
                            Name = "Samsung WW90T534AAW",
                            Price = 649m,
                            Type = "Wasmachine"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Bosch",
                            EnergyLabelId = 1,
                            ImagePath = "/images/devices/bosch-serie-4-wgg04409nl.png",
                            Name = "Bosch Serie | 4 WGG04409NL",
                            Price = 699m,
                            Type = "Wasmachine"
                        });
                });

            modelBuilder.Entity("Duurzame_Consumentkeuzes.Models.EnergyLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EfficiencyClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EnergyLabels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EfficiencyClass = "A",
                            ImagePath = "/images/energylabels/energylabela.png"
                        },
                        new
                        {
                            Id = 2,
                            EfficiencyClass = "B",
                            ImagePath = "/images/energylabels/energylabelb.png"
                        },
                        new
                        {
                            Id = 3,
                            EfficiencyClass = "C",
                            ImagePath = "/images/energylabels/energylabelc.png"
                        },
                        new
                        {
                            Id = 4,
                            EfficiencyClass = "D",
                            ImagePath = "/images/energylabels/energylabeld.png"
                        },
                        new
                        {
                            Id = 5,
                            EfficiencyClass = "E",
                            ImagePath = "/images/energylabels/energylabele.png"
                        },
                        new
                        {
                            Id = 6,
                            EfficiencyClass = "F",
                            ImagePath = "/images/energylabels/energylabelf.png"
                        },
                        new
                        {
                            Id = 7,
                            EfficiencyClass = "G",
                            ImagePath = "/images/energylabels/energylabelg.png"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5",
                            Name = "Administrators",
                            NormalizedName = "ADMINISTRATORS"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                            RoleId = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CustomerDevice", b =>
                {
                    b.HasOne("Duurzame_Consumentkeuzes.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Duurzame_Consumentkeuzes.Models.Device", null)
                        .WithMany()
                        .HasForeignKey("DevicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerEnergyLabel", b =>
                {
                    b.HasOne("Duurzame_Consumentkeuzes.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Duurzame_Consumentkeuzes.Models.EnergyLabel", null)
                        .WithMany()
                        .HasForeignKey("EnergyLabelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Duurzame_Consumentkeuzes.Models.Device", b =>
                {
                    b.HasOne("Duurzame_Consumentkeuzes.Models.EnergyLabel", "EnergyLabel")
                        .WithMany("Devices")
                        .HasForeignKey("EnergyLabelId");

                    b.Navigation("EnergyLabel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Duurzame_Consumentkeuzes.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Duurzame_Consumentkeuzes.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Duurzame_Consumentkeuzes.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Duurzame_Consumentkeuzes.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Duurzame_Consumentkeuzes.Models.EnergyLabel", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
