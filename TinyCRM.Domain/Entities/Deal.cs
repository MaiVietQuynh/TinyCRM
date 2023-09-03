using TinyCRM.Domain.Entities.Enums;

namespace TinyCRM.Domain.Entities;

public class Deal : EntityBase<Guid>
{
    public string Title { get; set; }
    public decimal EstimatedRevenue { get; set; }
    public string Description { get; set; }
    public DealStatus Status { get; set; }
    public Lead Lead { get; set; }
    public Guid LeadId { get; set; }
    public ICollection<DealProduct> DealProducts { get; set; }
}