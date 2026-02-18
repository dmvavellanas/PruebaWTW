using Microsoft.EntityFrameworkCore;
using PruebaWTW.Domain.Entities;

namespace PruebaWTW.Infrastructure.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Product> Products { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}