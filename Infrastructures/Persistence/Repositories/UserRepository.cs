
using Application.Repositories;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Generics;

namespace Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
