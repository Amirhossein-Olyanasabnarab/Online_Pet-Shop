using PetShop.Application.Interfaces.Contexts;

namespace PetShop.Application.Services.Users.Queries.GetAllUsers;

public class GetAllUsers : IGetAllUsers
{
    private readonly IDataBaseContext _context;

    public GetAllUsers(IDataBaseContext context)
    {
        _context = context;
    }
    public List<ResultOfGetAllUsersDto> Execute(String seachKey, int page = 1)
    {
        var user = _context.Users.AsQueryable();
        var result = user.Select(p => new ResultOfGetAllUsersDto
        {
            Id = p.Id,
            FullName = p.FullName,
            Email = p.Email
        }).ToList();
        return result;
    }
}