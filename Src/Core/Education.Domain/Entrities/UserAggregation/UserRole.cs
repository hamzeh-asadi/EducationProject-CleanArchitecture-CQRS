using Education.Domain.Entrities.BaseEntities;

namespace Education.Domain.Entrities.UserAggregation
{
    // UserRole entity (junction table for many-to-many relationship)
    public class UserRole : BaseEntity
    {
        // Composite primary key
        public long Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        #region Navigation properties
        public User User { get; set; }
        public Role Role { get; set; }
        #endregion
    }
}
