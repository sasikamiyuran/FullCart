using FullCart.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional model configurations or relationships can be added here
            // Use seed method here
            ApplicationDbContextSeed.Seed(modelBuilder);
        }

        //private static void SeedRoles(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<IdentityRole>().HasData(
        //        new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
        //        new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" }
        //    );
        //}

        //private static void SeedUsers(ModelBuilder modelBuilder)
        //{
        //    var adminUserId = Guid.NewGuid().ToString();
        //    var adminUser = new IdentityUser
        //    {
        //        Id = adminUserId,
        //        UserName = "admin@example.com",
        //        Email = "admin@example.com",
        //        NormalizedUserName = "ADMIN@EXAMPLE.COM",
        //        NormalizedEmail = "ADMIN@EXAMPLE.COM",
        //        EmailConfirmed = true
        //    };
        //    adminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(adminUser, "Admin@123");

        //    modelBuilder.Entity<IdentityUser>().HasData(adminUser);

        //    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
        //        new IdentityUserRole<string> { RoleId = "1", UserId = adminUserId }
        //    );

        //    var customerUserId = Guid.NewGuid().ToString();
        //    var customerUser = new IdentityUser
        //    {
        //        Id = customerUserId,
        //        UserName = "customer@example.com",
        //        Email = "customer@example.com",
        //        NormalizedUserName = "CUSTOMER@EXAMPLE.COM",
        //        NormalizedEmail = "CUSTOMER@EXAMPLE.COM",
        //        EmailConfirmed = true
        //    };
        //    customerUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(customerUser, "Customer@123");

        //    modelBuilder.Entity<IdentityUser>().HasData(customerUser);

        //    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
        //        new IdentityUserRole<string> { RoleId = "2", UserId = customerUserId }
        //    );
        //}
    }
}
