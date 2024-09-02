using Application.Repositories;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Generics;

namespace Persistence.Repositories;

public class GalleryRepository : GenericRepository<Gallery>, IGalleryRepository
{
    public GalleryRepository(AppDbContext context) : base(context)
    {
    }
}
