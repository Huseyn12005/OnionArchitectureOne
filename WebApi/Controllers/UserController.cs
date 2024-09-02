using Application.Services;
using Domain.DTOs.Users;
using Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Add(AddUserDto model)
    {
        var result = await _userService.AddAsync(model);
        return Ok(result);
    }
}
