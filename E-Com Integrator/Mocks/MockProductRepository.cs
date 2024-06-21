using Moq;
using EComIntegrator.Models;
using EComIntegrator.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EComIntegrator.Tests.Mocks
{
    public class MockProductRepository : Mock<IProductRepository>
    {
        public MockProductRepository()
        {
            Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10 },
                new Product { Id = 2, Name = "Product 2", Price = 20 },
            });

            Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((int id) =>
                new Product { Id = id, Name = $"Product {id}", Price = id * 10 });

            // Setup other methods as needed
        }
    }
}
