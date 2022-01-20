﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiLabs.Data;

namespace MultiLabs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220120012154_PopulateTesters")]
    partial class PopulateTesters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2",
                            Name = "LabManager",
                            NormalizedName = "LABMANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "3",
                            Name = "LabTester",
                            NormalizedName = "LABTESTER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "4",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 6,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 7,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 8,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 9,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 10,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 11,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 12,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 13,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 14,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 15,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MultiLabs.Models.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocalId");

                    b.HasIndex("UserId");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("MultiLabs.Models.LaboratoryTest", b =>
                {
                    b.Property<int>("LaboratoryId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("LaboratoryId", "TestId");

                    b.HasIndex("TestId");

                    b.ToTable("LaboratoryTests");
                });

            modelBuilder.Entity("MultiLabs.Models.LaboratoryTesters", b =>
                {
                    b.Property<int>("LaboratoryId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LaboratoryId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("LaboratoryTesters");
                });

            modelBuilder.Entity("MultiLabs.Models.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locals");
                });

            modelBuilder.Entity("MultiLabs.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LaboratoryId")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LaboratoryId");

                    b.HasIndex("TestId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("MultiLabs.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("MultiLabs.Models.TimeSlots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableSlots")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LaboratoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LaboratoryId");

                    b.ToTable("TimeSlots");
                });

            modelBuilder.Entity("MultiLabs.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f00729d-1ca8-4b25-b32b-b105d8b0a65e",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJB3oHFs/6QxQVLkx1CQ5rFkULgmPQPjcu437XpwHLY9rZ21D8cNa4Jexz6p5iN9Eg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "164b6392-ea3a-4b7e-a5f6-c2398e31497e",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "340352eb-9cbe-4a90-b3f0-1234194238e8",
                            Email = "tester6@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER6@GMAIL.COM",
                            NormalizedUserName = "TESTER6@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDKLRM0fAunIyaTIU34qTi5T6s+taifp2LNN5OxLLrOYwYuHP6YEomSfENjoEmIiOQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "410986a9-2081-4e48-9926-1e98784764c6",
                            TwoFactorEnabled = false,
                            UserName = "tester6@gmail.com"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d32a03a3-9e49-4469-a400-ec96b83b902c",
                            Email = "tester7@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER7@GMAIL.COM",
                            NormalizedUserName = "TESTER7@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENcSI7XLF1OVS2fpE6eVJzsqnlYXiMae2yNUXVoShqRyxFbJk6Qh6E4ULRRudn9k2A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0513f656-ce17-42d6-a02f-0bf01ec28505",
                            TwoFactorEnabled = false,
                            UserName = "tester7@gmail.com"
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f42c3bb-64c8-4567-8399-be96a23722e5",
                            Email = "tester8@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER8@GMAIL.COM",
                            NormalizedUserName = "TESTER8@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOob8HT5MVGRrUIfr7J9Su64jT0xSqdWgS2rdBXWYuCXQLt/0/7NqBRLnC29mET1LQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ee12f90b-283e-42e9-930b-37249c7fcb81",
                            TwoFactorEnabled = false,
                            UserName = "tester8@gmail.com"
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f9313028-e7cd-4e23-a57b-b6c842362d1e",
                            Email = "tester9@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER9@GMAIL.COM",
                            NormalizedUserName = "TESTER9@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKa/v5cVJVhwnC8+uq339hHtOhxJGHXe7i1Hguxus7RLBcmKdApqPdTvY0A3IRbQ0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0a02a717-a15c-42f9-9ffd-f8540d49c355",
                            TwoFactorEnabled = false,
                            UserName = "tester9@gmail.com"
                        },
                        new
                        {
                            Id = 10,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "621fc9d0-4863-4662-a228-3a343b17251f",
                            Email = "tester10@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER10@GMAIL.COM",
                            NormalizedUserName = "TESTER10@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHYgL7o0xAV26y2zo9LdDzenLlqiW0eaUsdsVI8FQeCyUZw2w3cpIJl3Pk9Th6t0tg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "57442334-3d24-4a71-aa12-aceda3968d90",
                            TwoFactorEnabled = false,
                            UserName = "tester10@gmail.com"
                        },
                        new
                        {
                            Id = 11,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7557a15a-ca28-454b-8c97-18eb487ffaba",
                            Email = "tester11@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER11@GMAIL.COM",
                            NormalizedUserName = "TESTER11@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENurdCz+LXu2+n2l3gnSVZrgwvJDkSIDsKOiJ332MCDcKNFR9cEkMTtjhwQkSeXthA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8bd4fd7b-1b48-4760-a6b9-9fb64990c04a",
                            TwoFactorEnabled = false,
                            UserName = "tester11@gmail.com"
                        },
                        new
                        {
                            Id = 12,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ccc8e322-7601-4099-b57c-2fd29ab14258",
                            Email = "tester12@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER12@GMAIL.COM",
                            NormalizedUserName = "TESTER12@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEF9mm+1p5eqPfHIBmfgik6HzHl+e+HdvTxvJO3e6gQPxjFq8CTvEJC4JapW/jYwiw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29d5893f-7073-47a7-ae84-03934a1d50cc",
                            TwoFactorEnabled = false,
                            UserName = "tester12@gmail.com"
                        },
                        new
                        {
                            Id = 13,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7dcb2b36-805e-48f4-8030-b3cb925a8428",
                            Email = "tester13@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER13@GMAIL.COM",
                            NormalizedUserName = "TESTER13@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENKOEot1OB9LUy6eoSfOzsLlmYzz0/bxCsXD/LUdjDsI61am1p0BwSzEhwsFW7yoFg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "691ee82a-c5d8-42c7-a20a-f129848e7f15",
                            TwoFactorEnabled = false,
                            UserName = "tester13@gmail.com"
                        },
                        new
                        {
                            Id = 14,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "509a56ac-c231-4421-b892-c085dc78d622",
                            Email = "tester14@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER14@GMAIL.COM",
                            NormalizedUserName = "TESTER14@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAbYIZmBnP+4noWOLiuCGv2b4sVHJxB1/pugKo7oiUXegNhICDdDS9muAjYnVtOg0w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dcc6bd96-0642-46a8-a444-c71dfd0e72e4",
                            TwoFactorEnabled = false,
                            UserName = "tester14@gmail.com"
                        },
                        new
                        {
                            Id = 15,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "583f5fc5-aa57-4872-8b12-ecf50ac11db6",
                            Email = "tester15@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TESTER15@GMAIL.COM",
                            NormalizedUserName = "TESTER15@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECJBJ7DxxxgOkJ7VWLmpO86FEwBdRYdIlBZKpwdferflBQfEJM4bY+FU7lo6fIr2ag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "963754b2-0038-4f3a-ac91-b58694dcf013",
                            TwoFactorEnabled = false,
                            UserName = "tester15@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MultiLabs.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MultiLabs.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MultiLabs.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MultiLabs.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MultiLabs.Models.Laboratory", b =>
                {
                    b.HasOne("MultiLabs.Models.Local", "Local")
                        .WithMany("Laboratories")
                        .HasForeignKey("LocalId");

                    b.HasOne("MultiLabs.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Local");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MultiLabs.Models.LaboratoryTest", b =>
                {
                    b.HasOne("MultiLabs.Models.Laboratory", "Laboratory")
                        .WithMany("LaboratoryTests")
                        .HasForeignKey("LaboratoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MultiLabs.Models.Test", "Test")
                        .WithMany("LaboratoryTests")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratory");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("MultiLabs.Models.LaboratoryTesters", b =>
                {
                    b.HasOne("MultiLabs.Models.Laboratory", "Laboratory")
                        .WithMany("LaboratoryTesters")
                        .HasForeignKey("LaboratoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MultiLabs.Models.User", "User")
                        .WithMany("LaboratoryTesters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MultiLabs.Models.Schedule", b =>
                {
                    b.HasOne("MultiLabs.Models.Laboratory", "Laboratory")
                        .WithMany()
                        .HasForeignKey("LaboratoryId");

                    b.HasOne("MultiLabs.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");

                    b.Navigation("Laboratory");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("MultiLabs.Models.TimeSlots", b =>
                {
                    b.HasOne("MultiLabs.Models.Laboratory", "Laboratory")
                        .WithMany()
                        .HasForeignKey("LaboratoryId");

                    b.Navigation("Laboratory");
                });

            modelBuilder.Entity("MultiLabs.Models.Laboratory", b =>
                {
                    b.Navigation("LaboratoryTesters");

                    b.Navigation("LaboratoryTests");
                });

            modelBuilder.Entity("MultiLabs.Models.Local", b =>
                {
                    b.Navigation("Laboratories");
                });

            modelBuilder.Entity("MultiLabs.Models.Test", b =>
                {
                    b.Navigation("LaboratoryTests");
                });

            modelBuilder.Entity("MultiLabs.Models.User", b =>
                {
                    b.Navigation("LaboratoryTesters");
                });
#pragma warning restore 612, 618
        }
    }
}
