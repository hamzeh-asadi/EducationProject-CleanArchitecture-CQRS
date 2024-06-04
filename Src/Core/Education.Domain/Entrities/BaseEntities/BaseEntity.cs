namespace Education.Domain.Entrities.BaseEntities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "system";
        public string UpdatedBy { get; set; } = "system";

    }
}
