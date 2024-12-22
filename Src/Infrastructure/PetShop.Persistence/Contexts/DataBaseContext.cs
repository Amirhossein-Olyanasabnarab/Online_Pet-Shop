using Microsoft.EntityFrameworkCore;
using PetShop.Application.Interfaces.Contexts;
using PetShop.Domain.Entities.User;

namespace PetShop.Persistence.Contexts;

public class DataBaseContext : DbContext, IDataBaseContext
{
    public DataBaseContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserInRole> UserInRoles { get; set; }
    
}