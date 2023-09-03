using TinyCRM.Domain.Entities.Enums;

namespace TinyCRM.Domain.Entities;

public class Lead : EntityBase<Guid>
{
    public string Title { get; set; }
    public Source Source { get; set; }
    public double EstimatedRevenue { get; set; }
    public string Description { get; set; }
    public LeadStatus Status { get; set; }
    public Disqualification? Disqualification { get; set; }
    public string DisqualificationDescription { get; set; }
    public Guid CustomerId { get; set; }
    public Account Customer { get; set; }
    public Deal? Deal { get; set; }
}