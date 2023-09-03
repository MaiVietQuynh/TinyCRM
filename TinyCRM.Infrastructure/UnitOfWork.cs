using TinyCRM.Domain.Interface;

namespace TinyCRM.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    public Task<int> CommitAsync()
    {
        
    }
}