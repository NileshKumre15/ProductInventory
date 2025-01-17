//using NUnit.Framework;
//using Moq;
//using ProductInventory.Controllers;
//using ProductInventory.Models;
//using ProductInventory.Services;
//using System.Collections.Generic;
////using System.Web.Http;
////using System.Web.Http.Results;

//namespace ProductInventory.Tests.Controllers
//{
//    [TestFixture]
//    public class ProductControllerTests
//    {
//        private Mock<ProductService> _mockService;
//        private ProductController _controller;

//        [SetUp]
//        public void SetUp()
//        {
//            // Create a mock of the ProductService
//            _mockService = new Mock<ProductService>();

//            // Initialize the controller and inject the mock ProductService
//            _controller = new ProductController
//            {
//                _productService = _mockService.Object
//            };
//        }

//        // Test the AddProduct method
//        [Test]
//        public void AddProduct_ValidProduct_ReturnsOk()
//        {
//            // Arrange
//            var product = new Product { Name = "Test Product", Description = "Description", Price = 100, Quantity = 10 };

//            // Act
//            var result = _controller.AddProduct(product);

//            // Assert
//            Assert.IsInstanceOf<OkNegotiatedContentResult<Product>>(result);
//            _mockService.Verify(s => s.AddProduct(product), Times.Once);
//        }

//        // Test the UpdateProduct method
//        [Test]
//        public void UpdateProduct_ValidProduct_ReturnsOk()
//        {
//            // Arrange
//            var product = new Product { Name = "Updated Product", Description = "Updated Description", Price = 200, Quantity = 20 };

//            // Act
//            var result = _controller.UpdateProduct(1, product);

//            // Assert
//            Assert.IsInstanceOf<OkNegotiatedContentResult<Product>>(result);
//            _mockService.Verify(s => s.UpdateProduct(1, product), Times.Once);
//        }

//        // Test the DeleteProduct method
//        [Test]
//        public void DeleteProduct_ExistingProduct_ReturnsOk()
//        {
//            // Act
//            var result = _controller.DeleteProduct(1);

//            // Assert
//            Assert.IsInstanceOf<OkResult>(result);
//            _mockService.Verify(s => s.DeleteProduct(1), Times.Once);
//        }

//        // Test the GetAllProducts method
//        [Test]
//        public void GetAllProducts_ReturnsProductList()
//        {
//            // Arrange
//            var products = new List<Product> { new Product(), new Product() };
//            _mockService.Setup(s => s.GetAllProducts()).Returns(products);

//            // Act
//            var result = _controller.GetAllProducts();

//            // Assert
//            Assert.AreEqual(products.Count, result.Count);
//        }

//        // Test the GetProductById method
//        [Test]
//        public void GetProductById_ExistingProduct_ReturnsProduct()
//        {
//            // Arrange
//            var product = new Product { ProductId = 1, Name = "Product A" };
//            _mockService.Setup(s => s.GetProductById(1)).Returns(product);

//            // Act
//            var result = _controller.GetProductById(1);

//            // Assert
//            Assert.AreEqual(product, result);
//        }
//    }
//}
