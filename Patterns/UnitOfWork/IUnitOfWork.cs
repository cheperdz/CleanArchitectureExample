namespace Patterns.UnitOfWork;

public interface IUnitOfWork
{
    public Task<int> SaveChangesAsync();
}
