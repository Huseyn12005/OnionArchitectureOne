using Application.Repositories;

namespace Application.UnitOfWorks;

public interface IUnitOfWork
{
    public ICarRepository CarRepository { get; set; }
    public IGalleryRepository GalleryRepository { get; set; }
    public IUserRepository UserRepository { get; set; }
}
