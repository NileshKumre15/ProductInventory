using ProductInventory.Models;
using ProductInventory.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductInventory.Controllers
{
    //[Authorize]
    public class ProductController : ApiController
    {
        private readonly ProductService _productService;
        private const string AdminToken = "secure_token";

        public ProductController()
        {
            _productService = new ProductService();
        }

      
        [HttpPost]
        public IHttpActionResult AddProduct(Product product)
        {
            if (product == null) return BadRequest("Invalid data");

            _productService.AddProduct(product);
            return Ok(product);
            
        }


        [HttpPut]
        public IHttpActionResult UpdateProduct(int id, Product product)
        {
            if (product == null) return BadRequest("Invalid data");

            _productService.UpdateProduct(id, product);
            return Ok(product);
        }

      
        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

       
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        
        [HttpGet]
        public Product GetProductById(int id)
        {
            return _productService.GetProductById(id);
        }
    }

}
