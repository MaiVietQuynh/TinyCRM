namespace TinyCRM.Domain.Entities;

public class Contact : EntityBase<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Guid? AccountId { get; set; }
    public Account? Account { get; set; }
}