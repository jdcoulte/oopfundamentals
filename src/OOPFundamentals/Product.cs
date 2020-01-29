using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product

            return new Product();
        }

        public List<Product> Retrieve()
        {
            // Code that retrieves all of the products
            
            return new List<Product>();
        }

        public bool Save()
        {
            // Code that saves the defined product
            
            return true;
        }

    }



}
