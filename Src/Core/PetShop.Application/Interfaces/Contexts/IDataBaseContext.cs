using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Entities.User;

namespace PetShop.Application.Interfaces.Contexts;

public interface IDataBaseContext 
{
    DbSet<User> Users { get; set; }
    DbSet<Role> Roles { get; set; }
    DbSet<UserInRole> UserInRoles { get; set; }
    int SaveChanges();
    
}