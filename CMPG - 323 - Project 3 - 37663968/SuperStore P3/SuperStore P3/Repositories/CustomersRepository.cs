using Data;
using Models;

public class CustomerRepository
{
    protected readonly SuperStoreContext _context = new SuperStoreContext();

    // GET ALL: Products
    public IEnumerable<Customer> GetAll()
    {
        return _context.Customers.ToList();
    }

    // TO DO: Add ‘Get By Id’
    // TO DO: Add ‘Create’
    // TO DO: Add ‘Edit’
    // TO DO: Add ‘Delete’
    // TO DO: Add ‘Exists’
}
