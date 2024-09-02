using Domain.DTOs.Users;

namespace Application.Services;

public interface IUserService
{
    Task<string> AddAsync(AddUserDto model);
}
