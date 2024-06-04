using Education.Domain.Entrities.BaseEntities;

namespace Education.Domain.Entrities.UserAggregation
{
    // User entity
    public class User : BaseEntity
    {
        // Primary key
        public long Id { get; set; }

        // Personal details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Authentication details
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public bool IsEmailVerified { get; set; }
        public Guid ActiveCode { get; set; }
        
        public DateTime? LastLoginAt { get; set; }

        #region Navigation properties
        public ICollection<UserRole> UserRoles { get; set; }
        #endregion
    }
}
