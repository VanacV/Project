using Project.Storage.Entity;

namespace Project.Models.Interface
{
    public interface IFlowers
    {
        Task AddFlower(Flower flower);
        Task<IList<Flower>>GetAllFlower();

    }
}
