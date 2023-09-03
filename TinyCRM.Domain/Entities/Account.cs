namespace TinyCRM.Domain.Entities;

public class Account : EntityBase<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public decimal TotalSales { get; set; }
    public ICollection<Contact> Contacts { get; set; }
    public ICollection<Lead> Leads { get; set; }
}