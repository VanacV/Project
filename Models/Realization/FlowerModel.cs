using Microsoft.EntityFrameworkCore;
using Project.Models.Interface;
using Project.Storage;
using Project.Storage.Entity;
using System.Diagnostics.CodeAnalysis;

namespace Project.Models.Realization
{
    public class FlowerModel: IFlowers
    {
        private MyDbContext _dbContext;
        public FlowerModel(MyDbContext myDbContext)
        {
            _dbContext = myDbContext;
        }
        public async Task AddFlower(Flower flower)
        {
            flower.FlowerId = Guid.NewGuid();
            if (flower.Name != null)
            {
                _dbContext.Flowers.Add(flower);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public async Task<IList<Flower>> GetAllFlower() => await _dbContext.Flowers.ToListAsync();
    }
}
