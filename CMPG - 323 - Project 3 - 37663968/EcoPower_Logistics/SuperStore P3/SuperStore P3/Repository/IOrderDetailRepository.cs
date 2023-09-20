using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        public IEnumerable<OrderDetail> GetAll();
        public OrderDetail GetById(int id);
        public void Create(OrderDetail orderDetail);
        void Save(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        public void Delete(int id);
    }
}
