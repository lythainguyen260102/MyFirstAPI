using MyAPI.Entities;
using MyAPI.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Services
{
    public class AIOService : IAIOService
    {
        private MyAPI.Entities.MyAPIDbContext myAPIDbContext;

        public AIOService(MyAPIDbContext myAPIDbContext)
        {
            this.myAPIDbContext = myAPIDbContext;
        }

        public Task<AIO> GetAIO()
        {
            AIO aio = new AIO();

            var accounts = myAPIDbContext.Accounts;
            var stores = myAPIDbContext.Stores;
            var customers = myAPIDbContext.Customers;
            var goods = myAPIDbContext.Goods;
            var orders = myAPIDbContext.Orders;
            var ordersdetails = myAPIDbContext.OrdersDetails;

            aio.Accounts = accounts.ToList();
            aio.Stores = stores.ToList();
            aio.Customers = customers.ToList();
            aio.Goods = goods.ToList();
            aio.Orders = orders.ToList();
            aio.OrdersDetails = ordersdetails.ToList();

            return Task.FromResult(aio);
        }
    }
}
