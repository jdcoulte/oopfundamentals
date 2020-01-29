using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order

            return new Order();
        }

        public List<Order> Retrieve()
        {
            // Code that retrieves all of the orders
            
            return new List<Order>();
        }

        public bool Save()
        {
            // Code that saves the defined order
            
            return true;
        }
    }



}
