using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventory.Services
{
    public class ProductService
    {
        private readonly NileshDBContext _context;

        public ProductService()
        {
            _context = new NileshDBContext();
        }

       
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(int id, Product updatedProduct)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Description = updatedProduct.Description;
                product.Price = updatedProduct.Price;
                product.Quantity = updatedProduct.Quantity;
                product.UpdatedAt = System.DateTime.Now;

                _context.SaveChanges();
            }
        }

       
        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

       
        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

      
        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
    
