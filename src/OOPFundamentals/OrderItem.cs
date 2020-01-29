using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }
        

        public bool Validate()
        {
            var isValid = true;

            // Code to test order item values

            return isValid;
        }

        public OrderItem Retrieve(int orderId)
        {
            // Code that retrieves the defined order item

            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            // Code that retrieves all of the order items
            
            return new List<OrderItem>();
        }

        public bool Save()
        {
            // Code that saves the defined order item
            
            return true;
        }
    }



}
