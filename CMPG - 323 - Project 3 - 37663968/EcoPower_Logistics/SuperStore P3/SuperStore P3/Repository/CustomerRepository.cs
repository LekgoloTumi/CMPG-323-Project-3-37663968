using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository: GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {

        }

        //Get All: Customers
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers?.ToList();
        }

        //Get Specific: Customer
        public Customer GetById(short id)
        {
            return _context.Customers?.Find(id);
        }

        //Create: Customer
        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Save(Customer customer)
        {
            _context.SaveChanges();
        }

        //Edit: Customer
        public void Update(Customer customer)
        {
            _context.Customers?.Update(customer);
            _context.SaveChanges();
        }

        //Remove: Customer
        public void Delete(short id)
        {
             Customer customer = _context.Customers?.Find(id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
