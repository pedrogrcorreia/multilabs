using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Models;
using MultiLabs.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLabs.Data {
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int> {
        public DbSet<Laboratory> Laboratories { get; set; }

        public DbSet<Local> Locals { get; set; }

        public DbSet<Test> Tests { get; set; }

        public DbSet<LaboratoryTest> LaboratoryTests { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<LaboratoryTest>().HasKey(fp => new { fp.LaboratoryId, fp.TestId });

            builder.Entity<LaboratoryTest>()
                .HasOne(sp => sp.Laboratory)
                .WithMany(s => s.LaboratoryTests)
                .HasForeignKey(sp => sp.LaboratoryId);

            builder.Entity<LaboratoryTest>()
                .HasOne(sp => sp.Test)
                .WithMany(p => p.LaboratoryTests)
                .HasForeignKey(sp => sp.TestId);


            this.SeedRoles(builder);
            this.SeedUsers(builder);
            this.SeedUserRoles(builder); 
        }

        private void SeedUsers(ModelBuilder builder) {
            string email = "admin@gmail.com";
            User user = new User() {
                Id = 1,
                UserName = email,
                Email = email,
                NormalizedUserName = email.ToUpper(),
                NormalizedEmail = email.ToUpper(),
                LockoutEnabled = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "123Vv#");

            builder.Entity<User>().HasData(user);
        }

        private void SeedRoles(ModelBuilder builder) {
            builder.Entity<IdentityRole<int>>().HasData(RolesUtils.All);
        }

        private void SeedUserRoles(ModelBuilder builder) {
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>() { RoleId = 1, UserId = 1 }
            );
        }
    }
}
