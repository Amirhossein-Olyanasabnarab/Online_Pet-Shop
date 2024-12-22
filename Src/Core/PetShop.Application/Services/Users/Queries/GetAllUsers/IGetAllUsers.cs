namespace PetShop.Application.Services.Users.Queries.GetAllUsers;

public interface IGetAllUsers
{
    List<ResultOfGetAllUsersDto> Execute(string seachKey, int page =1);
}