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
    [Migration("20231031192541_RemovedImageModel")]
    partial class RemovedImageModel
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
                            ConcurrencyStamp = "67802011-a03e-4aa0-91a0-d030b39e12b8",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAXm+D9dR7XbqgYgZcvCB5SAhfBSSKMq/isY/yIwDXHa8dGwsbX1OnoGB8zh2AeYDQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0761a914-88b4-4558-9531-30042f522afa",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "8d444423-6e84-4fab-94d2-873c8588257a",
                            AccessFailedCount = 0,
                            Budget = 450m,
                            ConcurrencyStamp = "9b504dd0-177c-4a9e-ba9b-2efa591d25fd",
                            Email = "bruce@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BRUCE@EXAMPLE.COM",
                            NormalizedUserName = "BRUCE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDP1GsAAQ26S4smD1YdjG2lthw/fKfpAFJ7K9j29fg4s0Bld/orBL8A0z6dx3qPuuw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "acd87504-08a4-4eee-b325-f025a39bbc92",
                            TwoFactorEnabled = false,
                            UserName = "bruce@example.com"
                        },
                        new
                        {
                            Id = "a8570272-db34-4b83-8361-44b146d9b0a2",
                            AccessFailedCount = 0,
                            Budget = 500m,
                            ConcurrencyStamp = "92c6f611-dddd-4a64-8ac6-836a7261da56",
                            Email = "gijs@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GIJS@EXAMPLE.COM",
                            NormalizedUserName = "GIJS@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBYLsEK05TcvBsKYKbBcVAUkWkpyZ4+SXLC7fPxsnKW+i0eL4bmSDoYG6ImMhrpOZQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a02eea27-a313-4925-81e9-f85fc5f8eb85",
                            TwoFactorEnabled = false,
                            UserName = "gijs@example.com"
                        },
                        new
                        {
                            Id = "4f1e2a54-97d9-416e-afcd-efa94672b90a",
                            AccessFailedCount = 0,
                            Budget = 650m,
                            ConcurrencyStamp = "4c40c4bc-4dc8-45ea-ad80-ed16d61bbf34",
                            Email = "rick@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RICK@EXAMPLE.COM",
                            NormalizedUserName = "RICK@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEANyNgKzQaLftisiSsEaXY2srCWbcayI4z6iQXrzhFqPPEXtCdAuoqWSw2x+nhdcnA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd2191e9-d0fb-4f89-b022-1ab2cfa40537",
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
                });

            modelBuilder.Entity("Duurzame_Consumentkeuzes.Models.EnergyLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EfficiencyClass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EnergyLabels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EfficiencyClass = "A"
                        },
                        new
                        {
                            Id = 2,
                            EfficiencyClass = "B"
                        },
                        new
                        {
                            Id = 3,
                            EfficiencyClass = "C"
                        },
                        new
                        {
                            Id = 4,
                            EfficiencyClass = "D"
                        },
                        new
                        {
                            Id = 5,
                            EfficiencyClass = "E"
                        },
                        new
                        {
                            Id = 6,
                            EfficiencyClass = "F"
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
                    b.HasOne("Duurzame_Consumentkeuzes.Models.EnergyLabel", null)
                        .WithMany("Devices")
                        .HasForeignKey("EnergyLabelId");
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