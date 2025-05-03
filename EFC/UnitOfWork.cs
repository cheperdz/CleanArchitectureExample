// using EntityFrameworkCore.Context;
// using EntityFrameworkCore.Repositories.Interfaces;

using Patterns.UnitOfWork;

namespace EFC;

public class UnitOfWork : IUnitOfWork
{
    // private readonly EllieCoreSoftwareDbContext _context;

    // public UnitOfWork(EllieCoreSoftwareDbContext context) => _context = context;

    public Task<int> SaveChangesAsync() => throw new NotImplementedException(); //_context.SaveChangesAsync();
}
