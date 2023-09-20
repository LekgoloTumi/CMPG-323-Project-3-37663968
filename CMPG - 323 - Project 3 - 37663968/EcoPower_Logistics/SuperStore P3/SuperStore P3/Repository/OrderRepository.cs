using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
            
        }

        //Get All: Orders
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders?.ToList();
        }

        //Get Specific: Order
        public Order GetById(int id)
        {
            return _context.Orders?.Find(id);
        }

        //Create: Order
        public void Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Save(Order order)
        {
            _context.SaveChanges();
        }

        //Edit: Order
        public void Update(Order order)
        {
            _context.Orders?.Update(order);
            _context.SaveChanges();
        }

        //Remove: Order
        public void Delete(int id)
        {
            Order order = _context.Orders?.Find(id);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
