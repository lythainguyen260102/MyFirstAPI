using System.Collections.Generic;

namespace MyAPI.Entities
{
    public class AIO
    {
        public List<Account> Accounts { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Store> Stores { get; set; }
        public List<Goods> Goods { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrdersDetail> OrdersDetails { get; set; }
    }
}
