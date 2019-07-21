using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {   //Create order class instance
            //pass in the id
            Order order = new Order(orderId);

            //retreives defined irder

            //test code
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        //save customer
        public bool Save(Order order)
        {
            return true;
        }
    }
}
