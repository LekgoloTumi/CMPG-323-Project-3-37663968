using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Data;
using Microsoft.CodeAnalysis;

public class ProductRepository
{
    protected readonly SuperStoreContext _context = new SuperStoreContext();

    // GET ALL: Products
    public IEnumerable<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    //Get by Id: Products
    public Product GetProductById(Product productId)
    {
        return _context.Set<Product>().FirstOrDefault(p => p.Id == productId);
    }

    //Create: Products
    public void Create(Product product)
    {
        _context.Products.Add(product);
    }

    //Edit: Products
    public void Edit(Product productId)
    {
        if(productId != null) 
        {

        }
    }

    //Exists: Products
    public bool Exists(Product productId)
    {
        var product = _context.Set<Product>().FirstOrDefault(p => p.Id == productId);
        if (product != null) 
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    //Update: Products
    public void Update(Product product) 
    {
        _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }

    //Delete: Products
    public void Delete(Product productId)
    {
        var product = _context.Set<Product>().FirstOrDefault(p => p.Id == productId);
        if (product != null) 
        {
            _context.Set<Product>().Remove(product);
        }
    }

    // TO DO: Add ‘Get By Id’
    // TO DO: Add ‘Create’
    // TO DO: Add ‘Edit’
    // TO DO: Add ‘Delete’
    // TO DO: Add ‘Exists’
}
