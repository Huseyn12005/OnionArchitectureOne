using Application.Services;
using Application.UnitOfWorks;
using Domain.DTOs.Users;
using Domain.Entities.Concretes;

namespace Infrastructure.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<string> AddAsync(AddUserDto model)
    {
        // Validation edilmelidir.
        User newUser = new User()
        {
            UserName = model.UserName,
            Name = model.Name,
            Email = model.Email,
            Surname = model.Surname,
        };

        try
        {
            await _unitOfWork.UserRepository.AddAsync(newUser);
            await _unitOfWork.UserRepository.SaveAllChangesAsync();
            return "Data Ugurla elave edildi...";
        }
        catch(Exception ex)
        {
            return ex.Message;
        }
    }
}
