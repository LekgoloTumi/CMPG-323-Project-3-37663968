using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {

        }

        //Get All: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products?.ToList();
        }

        //Get Specific: Product
        public Product GetById(short id)
        {
            return _context.Products?.Find(id);
        }

        //Create: Product
        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Save(Product product)
        {
            _context.SaveChanges();
        }

        //Edit: Product
        public void Update(Product product)
        {
            _context.Products?.Update(product);
            _context.SaveChanges();
        }

        //Remove: Product
        public void Delete(short id)
        {
            Product product = _context.Products?.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
