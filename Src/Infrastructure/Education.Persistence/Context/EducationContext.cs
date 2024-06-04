using Education.Domain.Entrities.UserAggregation;
using Education.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Education.Persistence.Context
{
    public class EducationContext : DbContext
    {
        public EducationContext(DbContextOptions<EducationContext> options) : base(options)
        {
            
        }

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EducationContext).Assembly);
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
