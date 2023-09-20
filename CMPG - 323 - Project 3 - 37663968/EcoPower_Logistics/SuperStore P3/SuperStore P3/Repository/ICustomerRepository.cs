using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        public IEnumerable<Customer> GetAll();
        public Customer GetById(short id);
        public void Create(Customer customer);
        void Save(Customer customer);
        void Update(Customer customer);
        public void Delete(short id);
    }
}
