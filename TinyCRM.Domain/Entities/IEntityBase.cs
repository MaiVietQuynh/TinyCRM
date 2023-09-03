namespace TinyCRM.Domain.Entities;

public interface IEntityBase<TKey>
{
    TKey Id { get; set; }
}

public abstract class EntityBase<TKey> : IEntityBase<TKey>
{
    public virtual TKey Id { get; set; }
}