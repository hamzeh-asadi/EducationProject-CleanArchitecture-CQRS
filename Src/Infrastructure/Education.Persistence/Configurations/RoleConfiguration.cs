using Education.Domain.Entrities.UserAggregation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Education.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name).HasMaxLength(50).IsRequired();
            builder.Property(r => r.Description).HasMaxLength(500);

            builder.HasMany(r => r.UserRoles)
              .WithOne(ur => ur.Role)
              .HasForeignKey(ur => ur.RoleId);

            // Data seeding
            builder.HasData(
                new Role { Id = 1, Name = "Admin", Description = "Administrator role" },
                new Role { Id = 2, Name = "User", Description = "Standard user role" }
            );
        }
    }
}
