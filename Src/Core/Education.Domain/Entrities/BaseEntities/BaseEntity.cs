namespace Education.Domain.Entrities.BaseEntities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; } = "system";
        public string UpdatedBy { get; set; } = "system";

    }
}
