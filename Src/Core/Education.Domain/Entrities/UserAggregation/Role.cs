using Education.Domain.Entrities.BaseEntities;

namespace Education.Domain.Entrities.UserAggregation
{
    // Role entity
    public class Role : BaseEntity
    {
        // Primary key
        public int Id { get; set; }

        // Role details
        public string Name { get; set; }
        public string Description { get; set; }

        #region Navigation properties
        public ICollection<UserRole> UserRoles { get; set; }
        #endregion
    }
}
