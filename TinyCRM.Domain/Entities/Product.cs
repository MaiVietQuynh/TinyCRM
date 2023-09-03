using TinyCRM.Domain.Entities.Enums;

namespace TinyCRM.Domain.Entities;

public class Product : EntityBase<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public ProductType ProductType { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public ICollection<DealProduct> DealProducts { get; set; }
}