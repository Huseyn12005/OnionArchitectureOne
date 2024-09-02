using Application.Repositories;
using Application.UnitOfWorks;

namespace Persistence.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(ICarRepository carRepository, IGalleryRepository galleryRepository, IUserRepository userRepository)
    {
        CarRepository = carRepository;
        GalleryRepository = galleryRepository;
        UserRepository = userRepository;
    }

    public ICarRepository CarRepository { get; set; }
    public IGalleryRepository GalleryRepository { get; set; }
    public IUserRepository UserRepository { get; set; }
}
