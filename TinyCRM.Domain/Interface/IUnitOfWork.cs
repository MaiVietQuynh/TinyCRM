namespace TinyCRM.Domain.Interface;

public interface IUnitOfWork
{
    Task<int> CommitAsync();
}