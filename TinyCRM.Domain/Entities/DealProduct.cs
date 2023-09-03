namespace TinyCRM.Domain.Entities;

public class DealProduct : EntityBase<Guid>
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public Guid DealId { get; set; }
    public Deal Deal { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerUnit { get; set; }
}