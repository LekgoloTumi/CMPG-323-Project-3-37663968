using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IEnumerable<Product> GetAll();
        public Product GetById(short id);
        public void Create(Product product);
        void Save(Product product);
        void Update(Product product);
        public void Delete(short id);
    }
}
