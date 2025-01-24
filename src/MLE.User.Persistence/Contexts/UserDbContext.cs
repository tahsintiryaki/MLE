using Microsoft.EntityFrameworkCore;
using MLE.User.Domain.Entities;

namespace MLE.User.Persistence.Contexts;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<Domain.Entities.User> Users { get; set; }
}