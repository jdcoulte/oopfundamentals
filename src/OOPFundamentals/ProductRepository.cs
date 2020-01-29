using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            // Code that retrieves the defined customer

            if(productId == 1)
            {
                product.ProductName = "Product 1";
                product.CurrentPrice = 9.99m;
            }
            return product;
        }

        public bool Save(Product product)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}