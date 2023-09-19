using Data;
using Models;

public class OrderRepository
{
    protected readonly SuperStoreContext _context = new SuperStoreContext();

    // GET ALL: Products
    public IEnumerable<Order> GetAll()
    {
        return _context.Orders.ToList();
    }

    // TO DO: Add ‘Get By Id’
    // TO DO: Add ‘Create’
    // TO DO: Add ‘Edit’
    // TO DO: Add ‘Delete’
    // TO DO: Add ‘Exists’
}
