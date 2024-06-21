using Xunit;
using Moq;
using EComIntegrator.Models;
using EComIntegrator.Repositories;
using EComIntegrator.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EComIntegrator.Tests
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductRepository> _mockProductRepository;
        private readonly IProductService _productService;

        public ProductServiceTests()
        {
            _mockProductRepository = new Mock<IProductRepository>();
            _productService = new ProductService(_mockProductRepository.Object);
        }

        [Fact]
        public async Task GetAllProducts_ReturnsListOfProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10 },
                new Product { Id = 2, Name = "Product 2", Price = 20 }
            };
            _mockProductRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(products);

            // Act
            var result = await _productService.GetAllProductsAsync();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Equal("Product 1", result[0].Name);
        }

        // Add more tests as needed
    }
}
