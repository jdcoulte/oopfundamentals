using System;
using System.Collections.Generic;
using OOPFundamentals;
using Xunit;
using commonclasses;

namespace CommonClasses.Tests
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }       
    }
}
