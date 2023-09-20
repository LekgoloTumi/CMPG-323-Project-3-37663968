using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(SuperStoreContext context) : base(context)
        {

        }

        //Get All: OrderDetails
        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails?.ToList();
        }

        //Get Specific: OrderDetail
        public OrderDetail GetById(int id)
        {
            return _context.OrderDetails?.Find(id);
        }

        //Create: OrderDetail
        public void Create(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void Save(OrderDetail orderDetail)
        {
            _context.SaveChanges();
        }

        //Edit: OrderDetail
        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails?.Update(orderDetail);
            _context.SaveChanges();
        }

        //Remove: OrderDetail
        public void Delete(int id)
        {
            OrderDetail orderDetail = _context.OrderDetails?.Find(id);
            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();
        }
    }
}
