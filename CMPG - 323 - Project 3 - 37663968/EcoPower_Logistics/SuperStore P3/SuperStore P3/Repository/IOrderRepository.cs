using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public IEnumerable<Order> GetAll();
        public Order GetById(int id);
        public void Create(Order order);
        void Save(Order prder);
        void Update(Order order);
        public void Delete(int id);
    }
}
