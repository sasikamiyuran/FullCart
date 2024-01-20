using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Infrastructure.Data
{
    public class SeedIdentityData : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(
            new IdentityUser { UserName = "admin@example.com", Email = "admin@example.com" }
            // Add more users as needed
        );

            builder.HasData(
                new IdentityRole { Name = "Admin" },
                new IdentityRole { Name = "Member" }
                // Add more roles as needed
            );
        }
    }
}
