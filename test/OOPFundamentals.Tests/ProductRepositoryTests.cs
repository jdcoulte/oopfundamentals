using System;
using Xunit;

namespace OOPFundamentals.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Product 1",
                CurrentPrice = 9.99m
            };

            //-- Act
            var actual = productRepository.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.ProductId, actual.ProductId);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}