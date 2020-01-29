using System;
using Xunit;

namespace OOPFundamentals.Tests
{
    public class OrderRepositoryTests
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 1, 29, 10, 00, 00, new TimeSpan(7,0,0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.OrderId, actual.OrderId);
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}