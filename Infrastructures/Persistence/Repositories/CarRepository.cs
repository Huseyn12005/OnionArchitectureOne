using Application.Repositories;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Generics;

namespace Persistence.Repositories;

public class CarRepository : GenericRepository<Car>, ICarRepository
{
    public CarRepository(AppDbContext context) : base(context)
    {
    }
}
